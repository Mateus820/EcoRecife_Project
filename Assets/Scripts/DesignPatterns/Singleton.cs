using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour {

	private static Singleton instance;
	
	public Transform[] lanes; 
	
	public Draggable[] dgs;

	public GameObject[] turretUI;
	
	public PlayerHealth health;

	public static Singleton GetInstance{
		get{
			if(instance == null){
				instance = GameObject.FindObjectOfType<Singleton>();
			}

			return instance;
		}
	}
}
