using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour {

	public TowersObject tw;
	[SerializeField] private ObjectPooler objPooler;
	private float damage;
	private float speed;

	void OnEnable () {
		GetComponent<Renderer>().material.color = tw.color;
		damage = tw.damage;
		speed = tw.shotSpeed;

		StartCoroutine(Shot());
	}

	IEnumerator Shot(){
		for(;;){
			yield return new WaitForSeconds(speed);
			var obj = objPooler.GetPooledObject();
			obj.transform.position = transform.position;
			obj.SetActive(true);
		}
	}


}
