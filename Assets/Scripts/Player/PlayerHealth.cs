using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

	public int curHealth;
	[SerializeField] private int maxHealth;
	[SerializeField] private Text textHealth;

	void Start () {
		curHealth = maxHealth;
		StartCoroutine(CallLessUpdate());
	}

	void LessUpdate(){
		if(curHealth > maxHealth){
			curHealth = maxHealth;
		}
		else if(curHealth <= 0)
		{
			curHealth = 0;
			SceneManager.LoadScene("Main Menu");
		}
	}

	void UpdateUI(){
		textHealth.text = "Vida: " + curHealth;
	}


	//Chamador;
	IEnumerator CallLessUpdate(){
		for(;;){
			LessUpdate();
			UpdateUI();
			yield return new WaitForSeconds(0.1f);
		}
	}
}
