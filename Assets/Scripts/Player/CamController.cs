using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour {

	private float horizontalRotation;
	[SerializeField] private float horizontalRotationBound;

	private float verticalRotation;

	[SerializeField] private float verticalRotationBound;
	void Start() {

		//Cursor.lockState = CursorLockMode.Locked;
			}
	
	// Update is called once per frame
	void Update () {
		
		horizontalRotation = Input.GetAxis("Mouse X");
		verticalRotation -= Input.GetAxis("Mouse Y");
		verticalRotation = Mathf.Clamp(verticalRotation , -verticalRotationBound , verticalRotationBound);
		transform.Rotate(0 , horizontalRotation , 0);
		Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation,0,0);
		
		
	}
}
