using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	[SerializeField] private float time;
	[SerializeField] private ObjectPooler objPooler;
	[SerializeField] private Transform[] pointsToSpwan;

	void Start () {
		InvokeRepeating("Spawn", time, time);	
	}

	void Spawn(){

		int random = Random.Range(0, pointsToSpwan.Length);

		var obj = objPooler.GetPooledObject();
		obj.transform.position = pointsToSpwan[random].position;
		obj.SetActive(true);
	}
}
