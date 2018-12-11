using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBullet : MonoBehaviour {

	[SerializeField] private float ballForce;
	[SerializeField] private float timeLife;
	[SerializeField] private Rigidbody rb;
	public float damage;

	void OnEnable() {
		rb.AddForce(Vector3.zero);
		rb.AddForce(0, 0, ballForce);
		Invoke("DestroyObject", timeLife);
	}

	void Update() {
		rb.velocity = new Vector3(0, 0, Mathf.Clamp(rb.velocity.z, 0, 10));	
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == gameObject.tag){
			gameObject.SetActive(false);
			other.gameObject.GetComponent<EnemyController>().DecreaseLife(damage);
			print(other.gameObject.GetComponent<EnemyController>());
		}
	}

	void DestroyObject(){
		gameObject.SetActive(false);
	}
}
