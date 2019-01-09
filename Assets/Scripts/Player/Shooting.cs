using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	private bool canShot;
	[SerializeField] private float shotCooldown;

	[SerializeField] private Animator rightClaw;

	[SerializeField] private Animator leftClaw;

	private bool shootingWithRightClaw;

		void Start () 
		{
			canShot = true;
			shootingWithRightClaw = true;
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if(Input.GetButton("Fire1") && canShot)
		{

			TogglingClaws();
			StartCoroutine(ShootingCooldown());
			var obj = PlayerBulletsObjectPooler.instance.GetPooledObject();
			obj.SetActive(true);
			obj.transform.position = Camera.main.transform.position;
			obj.transform.rotation = Camera.main.transform.rotation;
		
		}
	}

	void TogglingClaws()
	{
		if (shootingWithRightClaw)
		{
			rightClaw.SetTrigger("shot");	
		}

		else
		{
			leftClaw.SetTrigger("shot");	
		}
		
		shootingWithRightClaw = !shootingWithRightClaw;
		print("aq ó" + shootingWithRightClaw);
	}

	IEnumerator ShootingCooldown()
	{
		canShot = false;
		yield return new WaitForSeconds(shotCooldown);
		canShot = true;
	}
}
