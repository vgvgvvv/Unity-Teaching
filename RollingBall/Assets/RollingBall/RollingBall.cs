using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBall : MonoBehaviour
{

	private Rigidbody _rigid;
	private const float Force = 10;

	private void Awake()
	{
		_rigid = GetComponent<Rigidbody>();
	}

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A))
		{
			_rigid.AddForce(Vector3.left * Force);
		}else if (Input.GetKey(KeyCode.D))
		{
			_rigid.AddForce(Vector3.right * Force);
		}else if (Input.GetKey(KeyCode.W))
		{
			_rigid.AddForce(Vector3.forward * Force);
		}else if (Input.GetKey(KeyCode.S))
		{
			_rigid.AddForce(Vector3.back * Force);
		}
	}
}
