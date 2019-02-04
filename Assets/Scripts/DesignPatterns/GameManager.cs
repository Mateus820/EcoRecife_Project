using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
   
    void Start()
    {
        AudioManager audio =  AudioManager.instance;
        switch(SceneManager.GetActiveScene().name)
            {
             case "Menu":
             // nada
             break;

             case "Credits":
             //nada
             break;

            case "LevelSelection":
            //nada
            break;

            default :
            audio.Play("Gameplay Theme");
            break;
            }

    }
}
