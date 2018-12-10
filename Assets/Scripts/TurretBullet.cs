using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBullet : MonoBehaviour {

	[SerializeField] private float ballForce;
	[SerializeField] private Rigidbody rb;
	public float damage;

	void OnEnable() {
		rb.AddForce(0, 0, ballForce);
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == gameObject.tag){
			other.gameObject.GetComponent<EnemyController>().DecreaseLife(damage);
			gameObject.SetActive(false);
		}
	}
}
