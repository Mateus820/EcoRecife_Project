using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    
    [SerializeField] private GameObject menuPause;
    public bool isPaused;

    void Start()
    {
        //menuPause.SetActive(false);
        isPaused = false;
    }

    public void PauseBtnPress(){
        if(!isPaused){
            Pause();
        }
        else
        {
            Resume();
        }
    }

    void Pause()
    {
        Time.timeScale = 0f;
        //menuPause.SetActive(true);
        isPaused = true;
    }

    void Resume(){
        Time.timeScale = 1f;
        //menuPause.SetActive(false);
        isPaused = false;
    }
}
