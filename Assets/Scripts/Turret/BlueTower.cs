using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueTower : MonoBehaviour {

	[SerializeField] private string ballTag;
	[SerializeField] private float shotFrequence;
	[SerializeField] private Renderer rend;
	[SerializeField] private Color color; //Temporario;
	[SerializeField] private ObjectPooler objPooler;

	[SerializeField] private ObjectPooler objPoolerR;
	[SerializeField] private ObjectPooler objPoolerL;

	[SerializeField] private Transform dirRight;
	[SerializeField] private Transform dirLeft;


	void OnEnable () {
		StartCoroutine(Shot());
		rend.material.color = color;
	}

	//Verificar se é melhor usar o "InvokeRepeating()";
	IEnumerator Shot(){
		for(;;){
			yield return new WaitForSeconds(shotFrequence);

			var obj = objPooler.GetPooledObject();

			var objRight = objPoolerR.GetPooledObject();
			var objLeft = objPoolerL.GetPooledObject();

			print(objRight);

			if(obj != null){
				obj.transform.position = transform.position;
				obj.tag = ballTag;
				obj.SetActive(true);
			}
			if(objLeft != null && objRight != null){
				objLeft.GetComponent<BlueShotgun>().target = dirLeft;
				objLeft.SetActive(true);
				objRight.GetComponent<BlueShotgun>().target = dirRight;
				objRight.SetActive(true);
			}
			else{
				print("There isn't balls to shot!");
			}
			//obj.GetComponent<TurretBullet>().damage = tw.damage;
			//colocar o prefab da bola que atira;
		}
	}
}
