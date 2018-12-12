using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour {

[SerializeField] private float bulletSpeed;

[SerializeField] private float damage;
[SerializeField] private float distance;
[SerializeField] private float radius;

[SerializeField] private LayerMask whatToCollide;

private string[] enemyTags;
private RaycastHit hit;
		void Start () 
	{
		enemyTags = new string[4];
		enemyTags[0] = "Orange";
		enemyTags[1] = "Blue";
		enemyTags[2] = "Black";
		

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
				for(int i = 0; i < enemyTags.Length;i++)
				{
					if(hit.collider.gameObject.tag == enemyTags[i])
					{
						hit.collider.gameObject.SendMessage("DecreaseLife", damage , SendMessageOptions.DontRequireReceiver);
						gameObject.SetActive(false);
					}
				}
			}

		
	}
	private void OnDrawGizmos() {
		
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position ,radius);
	}
}
