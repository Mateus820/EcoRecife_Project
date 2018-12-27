using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaveScript : MonoBehaviour
{
    private Scene stageScene;
    public int[] waveMonsterCount;
    private int wave;   
    public float spawnCooldown;


    private string[] waveMonsters;
    
    void Start()
    {
          waveMonsterCount = new int [5];      
          waveMonsters = new string[5];
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
           if(stageScene.name == "Game")
           {  
               wave = 0;  
               waveMonsterCount = new int [3]; 
               /*aqui indicará o numero de monstros de cada wave ,sempre q um monstro morrer,
               irá retirar um. se chegar a zero, vamos à prox wave*/
               waveMonsterCount[0] = 2;
               waveMonsterCount[1] = 2;
               waveMonsterCount[2] = 2;

                waveMonsters[0] = "l,l";
                waveMonsters[1] = "l,l";
                waveMonsters[3] = "l,l";

               
           }

        #endregion Stage 1 
    }

    IEnumerator Wave(string monstersToSpawn)
    {
        for (int i = 0; i < monstersToSpawn.Length; i++)
        {
            switch(monstersToSpawn[i])
            {
                case 'l':
                //spawna o laranja;
                break ;

                case 'v':
                //spawna o verde
                break;

                case 'p':
                //spawna o preto
                break;

                case 'a':
                //spawna o azul
                break;

                default:
                //é apenas uma virgula , ignore
                break;
            }

            yield return new WaitForSeconds(spawnCooldown);
        }
    }

    IEnumerator ManagingWaves()
    {  
        for(;;)
        {
             if(waveMonsterCount[wave] == 0)
                {
                 wave++;
                 if(wave == 6)
                 {
                     print("fim da fase");
                 }
                Wave(waveMonsters[wave]);
                }
        yield return new WaitForSeconds(0.1f);
        }
    }
}

