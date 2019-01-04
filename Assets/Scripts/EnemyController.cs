﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EnemyController : MonoBehaviour {

	[SerializeField] private float basicHealth;
	[SerializeField] private float curHealth;
	[SerializeField] private float speed;
	[SerializeField] private bool direction;
	[SerializeField] private Rigidbody rb;
	[SerializeField] private string[] enemiesTag;
	[SerializeField] private Color[] colors;
	private Color curColor;

	void OnEnable() {
		
		curHealth = basicHealth;
		
		switch (gameObject.tag)
		{
		case "Orange" :
		curColor = GetComponent<Renderer>().material.color = colors[0];
		break;

		case "Blue" :
		curColor = GetComponent<Renderer>().material.color = colors[1];
		break;

		case "Black" : 
		curColor = GetComponent<Renderer>().material.color = colors[2];
		break;
		}

	}

	void FixedUpdate () {
		int x;
		if(direction) x = 1;
		else x = -1;

		rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, x * speed);
	}

	public void DecreaseLife(float damage){
		
		StartCoroutine(TakingDamage());
		curHealth -= damage;
		if(curHealth <= 0){
			Singleton.GetInstance.waveScript.waveMonsterCount[Singleton.GetInstance.waveScript.wave]--;
			gameObject.SetActive(false);
			return;
		}
	}

	void OnCollisionEnter(Collision other) {
		if(other.gameObject.tag == "DeathWall")
		{
			Singleton.GetInstance.waveScript.waveMonsterCount[Singleton.GetInstance.waveScript.wave]--;
			gameObject.SetActive(false);
			Singleton.GetInstance.health.curHealth--;
		}
	}

	void OnMouseEnter() {
		GetComponent<Renderer>().material.color = Color.white;
	}

	void OnMouseExit() {
		GetComponent<Renderer>().material.color = curColor;
	}

	IEnumerator TakingDamage()
	{
		GetComponent<Renderer>().material.color = Color.magenta;
		yield return new WaitForSeconds(1f);
		GetComponent<Renderer>().material.color = curColor;
	}
}
