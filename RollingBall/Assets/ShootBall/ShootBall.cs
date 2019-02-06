using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour
{


	private GameObject _bullet;
	private Vector3 _center;

	private void Awake()
	{
		_bullet = Resources.Load<GameObject>("Bullet");
		_center = Input.mousePosition;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey(KeyCode.Space))
		{
			var bulletGo = GameObject.Instantiate(_bullet);
			bulletGo.transform.position = transform.position;
			var rigidbody = bulletGo.GetComponent<Rigidbody>();
			var forward =  Camera.main.transform.forward + 
			               Camera.main.transform.right * (Input.mousePosition.x - _center.x) / 200 + 
			               Vector3.up * (Input.mousePosition.y - _center.y) / 200;
			rigidbody.AddForce(forward * 2000);
		}
	}
}
