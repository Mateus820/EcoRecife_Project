using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaveScript : MonoBehaviour
{
    private Scene stageScene;

    private int stageNumber;

    public int[] waveMonsterCount;  
    private int wave;
    void Start()
    {
          waveMonsterCount = new int [5];      
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
           if(stageScene.name == "Game")
           {    
               waveMonsterCount = new int [3]; 
               stageNumber = 1;
               /*aqui indicará o numero de monstros de cada wave ,sempre q um monstro morrer,
               irá retirar um. se chegar a zero, vamos à prox wave*/
               waveMonsterCount[0] = 2;
               waveMonsterCount[1] = 2;
               waveMonsterCount[2] = 2;
           }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Stage1()
    {


    }

}

