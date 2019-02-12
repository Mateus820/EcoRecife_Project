using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Draggable : MonoBehaviour {

	private Vector3 startPosition;
	public bool isDragging;
	public bool nodeOrBar;

	public string name;

	[HideInInspector]public GameObject obj;

	 [HideInInspector]public Vector3 posToBuild;

	void Start ()
	{
		 isDragging = false;
		 startPosition = transform.position;
	}

	public void BeginDrag()
	{
		
		isDragging = true;
	}

	public void Dragging()
	{
		transform.position = Input.mousePosition;
	}

	public void Drop()
	{
		if(!nodeOrBar)
		{
			transform.position = startPosition;
		}

		else 
		{
			transform.position = startPosition;
			BuildManager.instance.SetTurret(name);
			switch (name){
				case "":
					posToBuild = new Vector3();
				break;
			}
			obj = Instantiate(BuildManager.instance.GetTurretToBuild, posToBuild, Quaternion.identity);
			//obj.SetParent(~o target aqui , como um transfrom~)
			gameObject.SetActive(false);
		}
		isDragging = false;

	}


}
