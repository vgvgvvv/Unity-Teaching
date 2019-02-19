using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		StartCoroutine(Test1());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Test1()
	{
		while (true)
		{
			Debug.Log("!!!");
			yield return (1);
			
		}
	}
}
