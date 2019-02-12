using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    
    [SerializeField] private GameObject pauseBtn;
    [SerializeField] private GameObject menu;
    public bool isPaused;

    void Start()
    {
        menu.SetActive(false);
        pauseBtn.SetActive(true);
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

    public void MenuBtn(){
        SceneManager.LoadScene("Main Menu");
    }

    void Pause()
    {
        Time.timeScale = 0f;
        pauseBtn.SetActive(false);
        menu.SetActive(true);
        AudioManager.instance.Pause("Gameplay Theme");
        isPaused = true;
    }

    void Resume(){
        Time.timeScale = 1f;
        pauseBtn.SetActive(true);
        menu.SetActive(false);
        AudioManager.instance.Play("Gameplay Theme");
        isPaused = false;
    }
}
