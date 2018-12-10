using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

		void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if(Input.GetButtonDown("Fire1"))
		{
			var obj = PlayerBulletsObjectPooler.instance.GetPooledObject();
			obj.SetActive(true);
			obj.transform.position = Camera.main.transform.position;
			obj.transform.rotation = Camera.main.transform.rotation;
		
		}
	}
}
