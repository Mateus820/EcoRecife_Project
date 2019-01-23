using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

	public static BuildManager instance;

	[SerializeField] private GameObject turret;
	[SerializeField] private GameObject[] turrets;

	public GameObject GetTurretToBuild{
		get{
			return turret;
		}
	}

	void Awake() {
		instance = this;	
	}

	public void SetTurret(string turretName){
		switch(turretName){
			case "Riso":
				turret = turrets[0];
				break;
			case "Dom":
				turret = turrets[1];
				break;
			case "Jo":
				turret = turrets[2];
				break;
			case "Otto":
				turret = turrets[3];
				break;
			default:
				print("Nenhuma torreta com esse nome!");
				break;
		}
		print(turret);
	}
}
