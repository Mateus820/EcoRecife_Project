using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	[SerializeField] private float ballForce;
	[SerializeField] private Rigidbody rb;

	void OnEnable() {
		rb.AddForce(0, 0, ballForce);
	}
}
