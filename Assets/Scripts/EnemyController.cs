using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EnemyController : MonoBehaviour {

	[SerializeField] private int curHealth;
	[SerializeField] private float speed;
	[SerializeField] private bool direction;
	[SerializeField] private Rigidbody rb;
	
	void Start () {
		
	}
	
	void FixedUpdate () {
		int x;
		if(direction) x = 1;
		else x = -1;

		rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, x * speed);
	}

	public void DecreaseLife(int damage){
		if(curHealth <= 0){
			Destroy(gameObject);
			return;
		}

		curHealth -= damage;
	}

	void OnCollisionEnter(Collision other) {
		if(other.gameObject.tag == "DeathWall")
			gameObject.SetActive(false);
	}
}
