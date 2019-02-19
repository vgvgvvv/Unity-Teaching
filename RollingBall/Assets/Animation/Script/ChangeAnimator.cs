using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RoleState
{
	Idle,
	Run
}

public class ChangeAnimator : MonoBehaviour
{

	private Animator _animator;
	private RoleState _roleState = RoleState.Idle;

	private void Awake()
	{
		_animator = GetComponent<Animator>();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W))
		{
			if (_roleState != RoleState.Run)
			{
				_animator.SetTrigger("ToRun");
				_roleState = RoleState.Run;
			}
			transform.localEulerAngles = new Vector3(0, 0, 0);
			transform.position += transform.forward * 0.1f;
		}
		else if(Input.GetKey(KeyCode.S))
		{
			if (_roleState != RoleState.Run)
			{
				_animator.SetTrigger("ToRun");
				_roleState = RoleState.Run;
			}
			transform.localEulerAngles = new Vector3(0, 180, 0);
			transform.position += transform.forward * 0.1f;
		}
		else if (Input.GetKey(KeyCode.A))
		{
			if (_roleState != RoleState.Run)
			{
				_animator.SetTrigger("ToRun");
				_roleState = RoleState.Run;
			}
			transform.localEulerAngles = new Vector3(0, 270, 0);
			transform.position += transform.forward * 0.1f;
		}
		else if (Input.GetKey(KeyCode.D))
		{
			if (_roleState != RoleState.Run)
			{
				_animator.SetTrigger("ToRun");
				_roleState = RoleState.Run;
			}
			transform.localEulerAngles = new Vector3(0, 90, 0);
			transform.position += transform.forward * 0.1f;
		}
		else
		{
			if (_roleState != RoleState.Idle)
			{
				_animator.SetTrigger("ToIdle");
				_roleState = RoleState.Idle;
			}
		}
	}
}
