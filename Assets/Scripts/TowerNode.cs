using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerNode : MonoBehaviour {

	private GameObject curTurret;

	[SerializeField] private Color color;
	[SerializeField] private Color startColor;
	[SerializeField] private Renderer rend;
	[SerializeField] private Vector3 towerOffset;
	public Draggable draggingToMe;
	
	void OnMouseDown() {
		
	}

	void OnMouseEnter() {
			rend.material.color = color;
			for(int i = 0; i < Singleton.GetInstance.dgs.Length;i++)
			{
				if(Singleton.GetInstance.dgs[i].isDragging)
				{
					draggingToMe = Singleton.GetInstance.dgs[i];
					break;
				}
			}
			if(draggingToMe != null)
			{
				draggingToMe.nodeOrBar = true;
				Vector3 pos = new Vector3(transform.position.x + towerOffset.x, transform.position.y + towerOffset.y, transform.position.z + towerOffset.z);
				draggingToMe.posToBuild = pos;
				curTurret = BuildManager.instance.GetTurretToBuild;
				if(curTurret != null){
				print("You can't build a turret here!");
				return;
			}
		}
	}

	void OnMouseExit() {
		rend.material.color = startColor;
		if(draggingToMe != null)
		{
			draggingToMe.nodeOrBar = false;
			if(draggingToMe.isDragging)
			{
			curTurret = null;
			}
		}
		draggingToMe =  null;

	}
}
