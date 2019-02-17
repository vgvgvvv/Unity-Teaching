using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBar : MonoBehaviour
{

	public GameObject target;
	public Camera mainCamera;
	public Camera uiCamera;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (target == null)
		{
			return;
		}
		
		Vector3 screenPos = mainCamera.WorldToScreenPoint(target.transform.position + Vector3.up * 1);
		Vector3 uiSpaceWorldPos = uiCamera.ScreenToWorldPoint(screenPos);
		transform.position = uiSpaceWorldPos;
		transform.LookAt(uiCamera.transform);
		
	}
}
