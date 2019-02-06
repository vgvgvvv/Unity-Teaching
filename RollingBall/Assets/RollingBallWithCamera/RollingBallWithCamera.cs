using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBallWithCamera : MonoBehaviour
{

	public Camera _camera;
	private Rigidbody _rigid;

	private const float Force = 10;
	private float rot = 0;
	private float dis = 5;

	private Vector3 _currentMousePos;
	
	// Use this for initialization
	void Awake ()
	{
		_rigid = gameObject.GetComponent<Rigidbody>();
		_currentMousePos = Input.mousePosition;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey(KeyCode.A))
		{
			_rigid.AddForce(_camera.transform.right * Force * -1);
		}else if (Input.GetKey(KeyCode.D))
		{
			_rigid.AddForce(_camera.transform.right * Force);
		}else if (Input.GetKey(KeyCode.W))
		{
			_rigid.AddForce(_camera.transform.forward * Force);
		}else if (Input.GetKey(KeyCode.S))
		{
			_rigid.AddForce(_camera.transform.forward * Force * -1);
		}

		var offset = _currentMousePos - Input.mousePosition;
		_currentMousePos = Input.mousePosition;

		rot = offset.x;

		_camera.transform.position = transform.position + Quaternion.Euler(0, rot, 0) * -Vector3.forward * dis;

	}
}
