using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTower : MonoBehaviour {

	[SerializeField] private string ballTag;
	[SerializeField] private float shotFrequence;
	//[SerializeField] private GameObject ballPrefab;
	[SerializeField] private Renderer rend;
	[SerializeField] private Color color; //Temporario;
	[SerializeField] private ObjectPooler objPooler;

	void OnEnable () {
		StartCoroutine(Shot());
		rend.material.color = color;
	}

	//Verificar se é melhor usar o "InvokeRepeating()";
	IEnumerator Shot(){
		for(;;){
			yield return new WaitForSeconds(shotFrequence);
			var obj = objPooler.GetPooledObject();
			if(obj != null){
				obj.transform.position = new Vector3(transform.position.x , transform.position.y + 3f, transform.position.z);
				obj.tag = ballTag;
				obj.SetActive(true);
			}
			else{
				print("There isn't balls to shot!");
			}
			//colocar o prefab da bola que atira;
		}
	}
}
