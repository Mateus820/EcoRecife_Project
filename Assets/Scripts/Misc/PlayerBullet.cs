using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour {

[SerializeField] private float bulletSpeed;

[SerializeField] private float damage;
[SerializeField] private float distance;
[SerializeField] private float radius;

[SerializeField] private LayerMask whatToCollide;
private RaycastHit hit;
		void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	private void FixedUpdate() 
	{
		
			transform.Translate(transform.forward * bulletSpeed, Space.World);
			if(Physics.SphereCast(transform.position ,radius, transform.forward ,out hit ,distance ,whatToCollide))
			{
				
				if(hit.collider.gameObject.tag == "Orange")
				{
					hit.collider.gameObject.SendMessage("DecreaseLife", damage , SendMessageOptions.DontRequireReceiver);
					gameObject.SetActive(false);
				}
			}

		
	}
	private void OnDrawGizmos() {
		
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position ,radius);
	}
}
