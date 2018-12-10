using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EnemyController : MonoBehaviour {

	[SerializeField] private float curHealth;
	[SerializeField] private float speed;
	[SerializeField] private bool direction;
	[SerializeField] private Rigidbody rb;
	[SerializeField] private string[] enemiesTag;
	[SerializeField] private Color[] colors;
	private Color curColor;

	void OnEnable() {
		int random = Random.Range(0, enemiesTag.Length);
		gameObject.tag = enemiesTag[random];
		print(enemiesTag[random]);
		curColor = GetComponent<Renderer>().material.color = colors[random];
	}

	void FixedUpdate () {
		int x;
		if(direction) x = 1;
		else x = -1;

		rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, x * speed);
	}

	public void DecreaseLife(float damage){
		if(curHealth <= 0){
			gameObject.SetActive(false);
			return;
		}
		
		curHealth -= damage;
	}

	void OnCollisionEnter(Collision other) {
		if(other.gameObject.tag == "DeathWall")
			gameObject.SetActive(false);
	}

	void OnMouseEnter() {
		GetComponent<Renderer>().material.color = Color.white;
	}

	void OnMouseExit() {
		GetComponent<Renderer>().material.color = curColor;
	}
}
