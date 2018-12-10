using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

	public static BuildManager instance;

	[SerializeField] private GameObject turret;

	public GameObject GetTurretToBuild{
		get{
			return turret;
		}
	}

	void Awake() {
		instance = this;	
	}
}
