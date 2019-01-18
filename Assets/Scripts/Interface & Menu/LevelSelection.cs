using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    [SerializeField] Button[] levelButtons;
    void Start()
    {
        print(PlayerPrefs.GetInt("LevelsCleared"));
      //  if(PlayerPrefs.GetInt("LevelsCleared" , 0) == 0)
     //   {
            for (int i = 0; i <= PlayerPrefs.GetInt("LevelsCleared") && i < 10; i++)
            {
                levelButtons[i].interactable = true;
         //   }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            levelButtons[0].interactable =  !levelButtons[0].interactable;
        }
        
    }
}
