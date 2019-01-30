using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthUI : MonoBehaviour {
	 //Mileva
	[SerializeField] private Sprite[] playerHealthSps;
	[SerializeField] private Image playerHealthUI;
	
	[HideInInspector]public int curHealth;

	[SerializeField] private int maxHealth;


	 void Start()
	{
		curHealth = maxHealth;
		StartCoroutine(LessUpdate());
	}

	IEnumerator LessUpdate()
	{
		for(;;)
		{
			playerHealthUI.sprite = playerHealthSps[curHealth];
			yield return new WaitForSeconds(0.2f);
			if(curHealth <=0)
			{
				SceneManager.LoadScene("Main Menu");
			}
		}
		
	}
		
	}


