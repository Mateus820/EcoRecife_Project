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

	void Update() {
		if(Input.GetKeyDown(KeyCode.Alpha2)){
			turret = turrets[1];
			print(2);
		}
		else if(Input.GetKeyDown(KeyCode.Alpha4)){
			turret = turrets[3];
			print(4);
		}
	}

	public void SetTurret(string turretName){
		switch(turretName){
			case "Riso":
				//Colocar;
				break;
			case "Dom":
				turret = turrets[1];
				break;
			case "Jo":
				//Colocar;
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
