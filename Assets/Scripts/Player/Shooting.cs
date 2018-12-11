using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	private bool canShot;
	[SerializeField] private float shotCooldown;
		void Start () 
		{
			canShot = true;
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if(Input.GetButton("Fire1") && canShot)
		{
			StartCoroutine(ShootingCooldown());
			var obj = PlayerBulletsObjectPooler.instance.GetPooledObject();
			obj.SetActive(true);
			obj.transform.position = Camera.main.transform.position;
			obj.transform.rotation = Camera.main.transform.rotation;
		
		}
	}

	IEnumerator ShootingCooldown()
	{
		canShot = false;
		yield return new WaitForSeconds(shotCooldown);
		canShot = true;
	}
}
