using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
   
    [SerializeField] private GameObject[] frames ;
    private int number;
    private bool canChange;
    [SerializeField] private int framesToSkip;
    

    private void Start() 
    {
        canChange =  true;
        number = 0;
        StartCoroutine(FrameSkiper());
    }

//   void Update() 
 //  {   
    //   if(canChange)
    //   {   
            
//   }

   IEnumerator FrameSkiper()
   {
       for (;;)
       {
           for (int i = 0 ; i < framesToSkip; i++)
           {
               yield return new WaitForEndOfFrame();
           }
           
           frames[number].SetActive(true);

            for (int i = 0; i < frames.Length; i++)
            {
                if(frames[i] != frames[number])
                {
                    frames[i].SetActive(false);
                }
            }

            number++;
            if(number == frames.Length)
            {
                print(number);
                number = 0;
                
            }
       }
            //curDelay++;
            //print(curDelay);

            //if(curDelay == delay)
            //{ 
             //   curDelay = 0;    
                canChange = !canChange;
           // }
        }
    }       

//}
    
 
 
 
    

