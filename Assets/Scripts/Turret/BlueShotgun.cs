using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueShotgun : MonoBehaviour {

	public Transform target;
	[SerializeField] private float damage;
	[SerializeField] private float speedToTarget;
	[SerializeField] private Rigidbody rb;
	private bool reachPos;

	void Start () {
		reachPos = false;
	}
	
	void OnTriggerEnter(Collider other) {

		if(other.gameObject.tag == gameObject.tag){
			gameObject.SetActive(false);
			other.gameObject.GetComponent<EnemyController>().DecreaseLife(damage * 2);
			reachPos = false;
		}
		else if(other.gameObject.tag == "DeathBall"){
			gameObject.SetActive(false);
			reachPos = false;
		}
		else if(other.gameObject.tag != "Untagged" || other.gameObject.tag != "DeathBall"){
			gameObject.SetActive(false);
			other.gameObject.GetComponent<EnemyController>().DecreaseLife(damage);
			reachPos = false;
		}
	}

	void Update () {
		if(transform.position != target.position && !reachPos){
			transform.position = Vector3.MoveTowards(transform.position, target.position, speedToTarget/5);
			if(transform.position == target.position){
				reachPos = true;
			}
			return;
		}
		rb.velocity = new Vector3(0, 0, speedToTarget);
	}
}
