using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueShotgun : MonoBehaviour {

	public Transform target;
	[SerializeField] private float speedToTarget;
	[SerializeField] private Rigidbody rb;

	void Start () {

	}
	
	
	void Update () {
		if(transform.position != target.position){
			transform.position = Vector3.MoveTowards(transform.position, target.position, speedToTarget);
			return;
		}
		rb.velocity = new Vector3(0, 0, speedToTarget);
	}
}
