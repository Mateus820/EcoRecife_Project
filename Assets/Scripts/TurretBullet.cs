﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class TurretBullet : MonoBehaviour {

	[SerializeField] private float ballForce;
	[SerializeField] private float damage;
	[SerializeField] private float clampValue;
	[SerializeField] private Rigidbody rb;
	[SerializeField] private GameObject particles;

	void OnEnable() {
		rb.velocity = new Vector3(0, 0, Mathf.Clamp(rb.velocity.z, 0, clampValue));
		rb.AddForce(0, 0, ballForce);
	}

	void OnTriggerEnter(Collider other) {
		
		//Instantiate(particles,transform.position,Quaternion.identity);
		print(other.gameObject.name);

		if(other.gameObject.tag == gameObject.tag){
			gameObject.SetActive(false);
			other.gameObject.GetComponent<EnemyController>().DecreaseLife(damage * 2);
		}
		else if (other.gameObject.tag == "Up")
		{
			print("sobe sobe sobe");
			transform.position = new Vector3(transform.position.x,transform.position.y + 1.5f, transform.position.z);
		}

		else if(other.gameObject.tag == "DeathBall"){
			gameObject.SetActive(false);
		}
		else if(other.gameObject.tag != "Untagged" || other.gameObject.tag != "DeathBall"){
			gameObject.SetActive(false);
			other.gameObject.GetComponent<EnemyController>().DecreaseLife(damage);
		}

		
		
	}
}
