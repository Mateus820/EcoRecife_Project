using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Tower", menuName = "Tower")]
public class TowersObject : ScriptableObject {

	public string name;
	public string ballTag;
	public float damage;
	public float shotSpeed;
	public Color color;
	public GameObject prefab;
}
