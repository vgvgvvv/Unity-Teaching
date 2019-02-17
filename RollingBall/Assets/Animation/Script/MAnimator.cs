using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MAnimator
{

	private Animator _animator;
	private AnimatorOverrideController _overrideController;

	public void Init(GameObject go)
	{
		_animator = go.GetComponent<Animator>();
		_overrideController = new AnimatorOverrideController();
		_animator.runtimeAnimatorController = _overrideController;
		
	}

}
