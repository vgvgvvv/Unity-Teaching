using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XmlGamePlay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		XmlReader.CreateSceneFromXml();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		
	}
}
