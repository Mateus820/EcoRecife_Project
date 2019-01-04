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

    private int[] randomized;

    private List<int> index;

    


    void Start()
    {
          waveMonsterCount = new int [5];              
          waveMonsters = new string[5];
          waveMonstersSpawnPoint =  new string[5];
          wave = 0;
          index = new List<int>();
          
         
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

           if(stageScene.name == "Stage1")
           {  
              print("starting stage 1");              

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
   
           #region Stage 2 

             if(stageScene.name == "Stage2")
           {                
               /*aqui indicará o numero de monstros de cada wave ,sempre q um monstro morrer,
               irá retirar um. se chegar a zero, vamos à prox wave*/
               waveMonsterCount[0] = 2;
               waveMonsterCount[1] = 3;
               waveMonsterCount[2] = 3;
               waveMonsterCount[3] = 3;
               waveMonsterCount[4] = 4;

                waveMonsters[0] = "l,l";
                waveMonsters[1] = "l,l,l";
                waveMonsters[2] = "l,l,l";
                waveMonsters[3] = "l,l,l";
                waveMonsters[4] = "l,l,l,l";

                waveMonstersSpawnPoint[0] = "2,4";
                waveMonstersSpawnPoint[1] = "1,1,2";
                waveMonstersSpawnPoint[2] = "1,2,4";
                waveMonstersSpawnPoint[3] = "0,0,2";
                waveMonstersSpawnPoint[4] = "0,1,3,4";

              StartCoroutine(ManagingWaves());
              
           }

            
           #endregion Stage 2 

           #region Stage 3

             if(stageScene.name == "Stage3")
           {                
               /*aqui indicará o numero de monstros de cada wave ,sempre q um monstro morrer,
               irá retirar um. se chegar a zero, vamos à prox wave*/
               waveMonsterCount[0] = 4;
               waveMonsterCount[1] = 4;
               waveMonsterCount[2] = 4;
               waveMonsterCount[3] = 5;
               waveMonsterCount[4] = 5;

                waveMonsters[0] = "l,v,v,l";
                waveMonsters[1] = "l,l,v,v";
                waveMonsters[2] = "l,l,v,v";
                waveMonsters[3] = "l,l,l,v,v";
                waveMonsters[4] = "l,v,l,v,v";

                waveMonstersSpawnPoint[0] = "0,1,2,3";
                waveMonstersSpawnPoint[1] = "1,2,4,4";
                waveMonstersSpawnPoint[2] = "0,0,3,4";
                waveMonstersSpawnPoint[3] = "0,1,2,3,3";
                waveMonstersSpawnPoint[4] = "0,1,2,3,4";

              StartCoroutine(ManagingWaves());
              
           }
           

           #endregion Stage 3
            
            #region Stage 4

             if(stageScene.name == "Stage4")
           {                
               /*aqui indicará o numero de monstros de cada wave ,sempre q um monstro morrer,
               irá retirar um. se chegar a zero, vamos à prox wave*/
               waveMonsterCount[0] = 5;
               waveMonsterCount[1] = 5;
               waveMonsterCount[2] = 5;
               waveMonsterCount[3] = 5;
               waveMonsterCount[4] = 5;

                waveMonsters[0] = "l,v,v,l,l";
                waveMonsters[1] = "v,l,l,v,v";
                waveMonsters[2] = "v,v,l,v,l";
                waveMonsters[3] = "v,v,v,l,l";
                waveMonsters[4] = "v,v,v,l,l";

                waveMonstersSpawnPoint[0] = "0,1,1,2,2";
                waveMonstersSpawnPoint[1] = "1,2,2,3,3";
                waveMonstersSpawnPoint[2] = "0,0,2,3,4";
                waveMonstersSpawnPoint[3] = "0,0,1,1,4";
                waveMonstersSpawnPoint[4] = "0,1,2,3,4";

              StartCoroutine(ManagingWaves());
              
           }
           

           #endregion Stage 5

           #region Stage 5

             if(stageScene.name == "Stage5")
           {                
               /*aqui indicará o numero de monstros de cada wave ,sempre q um monstro morrer,
               irá retirar um. se chegar a zero, vamos à prox wave*/
               waveMonsterCount[0] = 6;
               waveMonsterCount[1] = 6;
               waveMonsterCount[2] = 6;
               waveMonsterCount[3] = 6;
               waveMonsterCount[4] = 6;

                waveMonsters[0] = "v,v,v,v,l,l";
                waveMonsters[1] = "v,v,v,l,l,l";
                waveMonsters[2] = "v,l,l,l,v,v";
                waveMonsters[3] = "v,l,l,l,v,v";
                waveMonsters[4] = "v,l,l,v,v,l";

                waveMonstersSpawnPoint[0] = "0,1,1,2,3,4";
                waveMonstersSpawnPoint[1] = "0,1,1,2,3,3";
                waveMonstersSpawnPoint[2] = "0,2,3,3,4,4";
                waveMonstersSpawnPoint[3] = "0,2,3,3,4,4";
                waveMonstersSpawnPoint[4] = "0,1,3,3,4,4";

              StartCoroutine(ManagingWaves());
              
           }
           

           #endregion Stage 5
           
           #region Stage 6

             if(stageScene.name == "Stage6")
           {                
               /*aqui indicará o numero de monstros de cada wave ,sempre q um monstro morrer,
               irá retirar um. se chegar a zero, vamos à prox wave*/
               waveMonsterCount[0] = 6;
               waveMonsterCount[1] = 6;
               waveMonsterCount[2] = 6;
               waveMonsterCount[3] = 6;
               waveMonsterCount[4] = 6;

                waveMonsters[0] = "v,p,p,l,l,v";
                waveMonsters[1] = "v,p,p,v,l,l";
                waveMonsters[2] = "v,v,p,p,v,l";
                waveMonsters[3] = "v,p,v,p,l,l";
                waveMonsters[4] = "v,v,p,v,p,l";

                waveMonstersSpawnPoint[0] = "0,1,2,3,3,4";
                waveMonstersSpawnPoint[1] = "0,1,1,2,4,4";
                waveMonstersSpawnPoint[2] = "0,0,1,1,4,4";
                waveMonstersSpawnPoint[3] = "0,1,2,3,4,4";
                waveMonstersSpawnPoint[4] = "0,0,1,2,3,4";

              StartCoroutine(ManagingWaves());
              
           }
           

           #endregion Stage 6
           
           #region Stage 7

             if(stageScene.name == "Stage7")
           {                
               /*aqui indicará o numero de monstros de cada wave ,sempre q um monstro morrer,
               irá retirar um. se chegar a zero, vamos à prox wave*/
               waveMonsterCount[0] = 7;
               waveMonsterCount[1] = 6;
               waveMonsterCount[2] = 6;
               waveMonsterCount[3] = 6;
               waveMonsterCount[4] = 6;

                waveMonsters[0] = "v,v,v,p,p,l,l";
                waveMonsters[1] = "v,v,p,p,l,l";
                waveMonsters[2] = "l,l,p,p,v,v";
                waveMonsters[3] = "l,v,p,p,v,l";
                waveMonsters[4] = "l,v,p,p,l,v";

                waveMonstersSpawnPoint[0] = "0,0,2,3,3,4,4";
                waveMonstersSpawnPoint[1] = "0,0,1,1,4,4";
                waveMonstersSpawnPoint[2] = "0,0,2,3,4,4";
                waveMonstersSpawnPoint[3] = "0,1,1,3,4,4";
                waveMonstersSpawnPoint[4] = "0,1,1,3,4,4";

              StartCoroutine(ManagingWaves());
              
           }
           

           #endregion Stage 7

           #region Stage 8

             if(stageScene.name == "Stage8")
           {                
               /*aqui indicará o numero de monstros de cada wave ,sempre q um monstro morrer,
               irá retirar um. se chegar a zero, vamos à prox wave*/
               waveMonsterCount[0] = 7;
               waveMonsterCount[1] = 7;
               waveMonsterCount[2] = 9;
               waveMonsterCount[3] = 9;
               waveMonsterCount[4] = 9;

                waveMonsters[0] = "l,v,p,a,p,l,v";
                waveMonsters[1] = "a,v,l,p,p,l,a";
                waveMonsters[2] = "p,v,v,l,l,p,a,l,a";
                waveMonsters[3] = "l,l,v,v,p,a,a,a,p";
                waveMonsters[4] = "l,p,a,p,a,v,l,a,p";

                waveMonstersSpawnPoint[0] = "0,1,1,2,3,4,4";
                waveMonstersSpawnPoint[1] = "0,1,2,3,3,4,4";
                waveMonstersSpawnPoint[2] = "0,0,1,1,2,2,3,4,4";
                waveMonstersSpawnPoint[3] = "0,0,1,1,2,2,3,4,4";
                waveMonstersSpawnPoint[4] = "0,0,1,2,2,3,3,4,4";

              StartCoroutine(ManagingWaves());      
           }
           

           #endregion Stage 8

           #region Stage 9

             if(stageScene.name == "Stage9")
           {                
               /*aqui indicará o numero de monstros de cada wave ,sempre q um monstro morrer,
               irá retirar um. se chegar a zero, vamos à prox wave*/
               waveMonsterCount[0] = 9;
               waveMonsterCount[1] = 11;
               waveMonsterCount[2] = 10;
               waveMonsterCount[3] = 10;
               waveMonsterCount[4] = 10;

                waveMonsters[0] = "l,p,a,p,a,v,l,a,p";
                waveMonsters[1] = "p,a,a,a,v,v,v,l,p,p,a";
                waveMonsters[2] = "p,v,v,p,l,a,p,p,a,l";
                waveMonsters[3] = "p,p,p,a,a,l,v,a,l,l";
                waveMonsters[4] = "p,l,v,v,l,a,p,p,l,l";

                waveMonstersSpawnPoint[0] = "0,0,1,2,2,3,3,4,4";
                waveMonstersSpawnPoint[1] = "0,0,0,1,1,2,2,3,3,4,4";
                waveMonstersSpawnPoint[2] = "0,0,1,1,2,2,3,3,4,4";
                waveMonstersSpawnPoint[3] = "0,0,1,1,2,2,3,3,4,4";
                waveMonstersSpawnPoint[4] = "0,0,1,1,2,3,3,3,4,4";

              StartCoroutine(ManagingWaves());      
           }
           

           #endregion Stage 9

           #region Stage 10

             if(stageScene.name == "Stage10")
           {                
               /*aqui indicará o numero de monstros de cada wave ,sempre q um monstro morrer,
               irá retirar um. se chegar a zero, vamos à prox wave*/
               waveMonsterCount[0] = 12;
               waveMonsterCount[1] = 12;
               waveMonsterCount[2] = 12;
               waveMonsterCount[3] = 15;
               waveMonsterCount[4] = 11;

                waveMonsters[0] = "l,l,l,v,v,v,p,p,p,a,a,l";
                waveMonsters[1] = "l,l,v,v,v,a,p,p,l,p,a,a";
                waveMonsters[2] = "v,a,a,a,v,v,l,v,v,p,p,l";
                waveMonsters[3] = "a,p,v,v,l,l,a,a,p,p,p,l,l,v,v";
                waveMonsters[4] = "l,a,a,v,v,l,p,p,p,a,l";

                waveMonstersSpawnPoint[0] = "0,0,0,1,1,1,2,2,2,3,3,4";
                waveMonstersSpawnPoint[1] = "0,0,0,1,1,1,2,2,2,3,4,4";
                waveMonstersSpawnPoint[2] = "0,0,0,1,1,1,2,3,3,4,4,4";
                waveMonstersSpawnPoint[3] = "0,0,1,1,1,2,2,2,3,3,3,4,4,4";
                waveMonstersSpawnPoint[4] = "0,0,0,1,1,1,2,2,2,3,4";

              StartCoroutine(ManagingWaves());      
           }
           

           #endregion Stage 9
    }
    


    IEnumerator Wave(string monstersToSpawn , string spawnLane)
    {
      
        for (int i = 0; i < monstersToSpawn.Length; i++)
        {
            //checando cor
            switch(monstersToSpawn[randomized[i]])
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
             switch(spawnLane[randomized[i]])
            {
                case ',':
               //apneas uma virgula, ignore
                lane = 6;
               
                break ;

                default:
                lane = (int)System.Char.GetNumericValue(spawnLane[randomized[i]]);
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

    void Randomizer(int extension)
    {
        randomized = new int[extension];
        
        for (int i = 0; i < extension; i++)
        {
            index.Add(i);
        }

        for (int i = 0; i < extension; i++)
        {
            int r = Random.Range(0,index.Count);
            randomized[i] = index[r];
            index.RemoveAt(r);
        } 

    }

    IEnumerator ManagingWaves()
    {  
        for(;;)
        {
          
            if(!started)
            {
            Randomizer(waveMonsters[wave].Length);    
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
                 Randomizer(waveMonsters.Length);
                StartCoroutine(Wave(waveMonsters[wave],waveMonstersSpawnPoint[wave]));                
                }
        yield return new WaitForSeconds(0.05f);
        }
    }
}

