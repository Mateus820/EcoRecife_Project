using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaveScript : MonoBehaviour
{
    private Scene stageScene;
    [HideInInspector] public int[] waveMonsterCount;
    public int wave;   
    private bool started;
    public float spawnCooldown;
    private string[] waveMonsters;
    private string[] waveMonstersSpawnPoint;
    [SerializeField] private ObjectPooler objPooler;


    //variaveis de spawn
    private int lane;
    private string monsterColor;


    void Start()
    {
          waveMonsterCount = new int [5];              
          waveMonsters = new string[5];
          waveMonstersSpawnPoint =  new string[5];

          stageScene = SceneManager.GetActiveScene();

         /*stage 1 = tutorial - dom
           stage 2 - dom
           stage 3 - dom e jo
           stage 4 - dom e jo
           stage 5 - dom e jo
           stage 6  - dom, jo e otto
           stage 7  - dom, jo e otto
           stage 8 - dom, jo, otto e riso
           stage 9 - dom, jo, otto e riso
           stage 10 - dom, jo, otto e riso*/

           #region Stage 1 

           /*obs : dps trocar o nome da scene "game" para stage 1 */
           if(stageScene.name == "Stage1")
           {  
              
               wave = 0;  
               /*aqui indicará o numero de monstros de cada wave ,sempre q um monstro morrer,
               irá retirar um. se chegar a zero, vamos à prox wave*/
               waveMonsterCount[0] = 2;
               waveMonsterCount[1] = 2;
               waveMonsterCount[2] = 2;

                waveMonsters[0] = "l,l";
                waveMonsters[1] = "l,l";
                waveMonsters[2] = "l,l";

                waveMonstersSpawnPoint[0] = "0,2";
                waveMonstersSpawnPoint[1] = "1,3";
                waveMonstersSpawnPoint[2] = "0,0";

              StartCoroutine(ManagingWaves());

               
           }

        #endregion Stage 1 
    }

    IEnumerator Wave(string monstersToSpawn , string spawnLane)
    {
        print(monstersToSpawn);
        for (int i = 0; i < monstersToSpawn.Length; i++)
        {
            //checando cor
            switch(monstersToSpawn[i])
            {
                case 'l':
                monsterColor = "Orange";
                break ;

                 case 'p':
                 monsterColor = "Black";            
                break ;

                case 'v':
                monsterColor = "Green";               
                break ;

                case 'a':
                monsterColor = "Blue";               
                break ;

                default:
                //apneas uma virgula, ignore
                monsterColor = null;
                break;
            }

            //checando lane
             switch(spawnLane[i])
            {
                case ',':
               //apneas uma virgula, ignore
                lane = 6;
                break ;

                default:
                lane = (int)System.Char.GetNumericValue(spawnLane[i]);
                break;
            }
            if(monsterColor != null && lane <= 5)
            {
            Spawn(monsterColor,lane);
            yield return new WaitForSeconds(spawnCooldown);
            }
        }
    }


    void Spawn(string monsterColor , int lane)
    {   
        GameObject obj = objPooler.GetPooledObject();
        obj.tag = monsterColor;
        obj.transform.position = Singleton.GetInstance.lanes[lane].position;
        obj.SetActive(true);


    }

    IEnumerator ManagingWaves()
    {  
        for(;;)
        {
            if(!started)
            {
            StartCoroutine(Wave(waveMonsters[wave],waveMonstersSpawnPoint[wave]));
             started = true;
            }   
             if(waveMonsterCount[wave] == 0)
                {
                 wave++;
                 if(wave == 5)
                 {
                     print("fim da fase");
                 }
                StartCoroutine(Wave(waveMonsters[wave],waveMonstersSpawnPoint[wave]));                
                }
        yield return new WaitForSeconds(0.1f);
        }
    }
}

