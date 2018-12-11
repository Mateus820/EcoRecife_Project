using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Draggable : MonoBehaviour {

	private Vector3 startPosition;
	public bool isDragging;
	public bool nodeOrBar;

	// Use this for initialization
	void Start ()
	 {
		 isDragging = false;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void BeginDrag()
	{
		startPosition = transform.position;
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
			gameObject.SetActive(false);
		}

		isDragging = false;

	}


}
