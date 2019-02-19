using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBallByTransform : MonoBehaviour
{


	private void Awake()
	{
	}

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A))
		{
			transform.position += Vector3.left
			                      * Time.deltaTime;
		}else if (Input.GetKey(KeyCode.D))
		{
			transform.position += Vector3.right
			                      * Time.deltaTime;
		}else if (Input.GetKey(KeyCode.W))
		{
			transform.position += Vector3.forward
			                      * Time.deltaTime;
		}else if (Input.GetKey(KeyCode.S))
		{
			transform.position += Vector3.back
			                      * Time.deltaTime;
		}
	}
}
