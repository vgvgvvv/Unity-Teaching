using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationClipOverrides : List<KeyValuePair<AnimationClip, AnimationClip>>
{
    public AnimationClipOverrides(int capacity = 4) : base(capacity) { }

    public AnimationClip this[string name]
    {
        get { return this.Find(x => x.Key.name.Equals(name)).Value; }
        set
        {
            int index = this.FindIndex(x => x.Key.name.Equals(name));
            if (index != -1)
                this[index] = new KeyValuePair<AnimationClip, AnimationClip>(this[index].Key, value);
        }
    }
}

public enum ActionState
{
	Move,
	Idle
}

public class TestAnimator : MonoBehaviour
{
    private Animator _animator;
    private AnimatorOverrideController _overrideController;
    private AnimationClipOverrides _animationClipOverrides;
	private ActionState _actionState;

    [SerializeField]
    private AnimationClip _moveClip;
    [SerializeField]
    private AnimationClip _idleClip;

    void Awake()
    {
        _animator = GetComponent<Animator>();
        _overrideController = new AnimatorOverrideController();
        _animationClipOverrides = new AnimationClipOverrides();

        _overrideController.runtimeAnimatorController = _animator.runtimeAnimatorController;
        _animator.runtimeAnimatorController = _overrideController;
        _overrideController.GetOverrides(_animationClipOverrides);
        _animationClipOverrides["Idle"] = _idleClip;
        _animationClipOverrides["Run"] = _moveClip;
        _overrideController.ApplyOverrides(_animationClipOverrides);
	    _actionState = ActionState.Idle;
    }

    // Use this for initialization
    void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.W))
	    {
		    if (_actionState != ActionState.Move)
		    {
			    _animator.SetTrigger("ToMove");
			    _actionState = ActionState.Move;
		    }

		    transform.localEulerAngles = new Vector3(0, 0, 0);
		    transform.position += transform.forward * 0.1f;
	    }
	    else if(Input.GetKey(KeyCode.S))
	    {
		    if (_actionState != ActionState.Move)
		    {
			    _animator.SetTrigger("ToMove");
			    _actionState = ActionState.Move;
		    }

		    transform.localEulerAngles = new Vector3(0, 180, 0);
		    transform.position += transform.forward * 0.1f;
	    }
	    else if (Input.GetKey(KeyCode.A))
	    {
		    if (_actionState != ActionState.Move)
		    {
			    _animator.SetTrigger("ToMove");
			    _actionState = ActionState.Move;
		    }
		    
		    transform.localEulerAngles = new Vector3(0, 270, 0);
		    transform.position += transform.forward * 0.1f;
	    }
	    else if (Input.GetKey(KeyCode.D))
	    {
		    if (_actionState != ActionState.Move)
		    {
			    _animator.SetTrigger("ToMove");
			    _actionState = ActionState.Move;
		    }
		    
		    transform.localEulerAngles = new Vector3(0, 90, 0);
		    transform.position += transform.forward * 0.1f;
	    }
	    else
	    {
		    if (_actionState != ActionState.Idle)
		    {
			    _animator.SetTrigger("ToStand");
			    _actionState = ActionState.Idle;
		    }
	    }
	}

	
}
