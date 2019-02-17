using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnimator : MonoBehaviour
{
	private MAnimator _animator;
	
	// Use this for initialization
	void Start ()
	{
		_animator = new MAnimator();
		_animator.Init(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
