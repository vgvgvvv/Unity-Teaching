using System.Collections;
using System.Collections.Generic;
using StateMechine;
using UnityEngine;

public class StateMechineDemo : MonoBehaviour {

	public Dictionary<StateEnum, BaseState> stateDict = new Dictionary<StateEnum, BaseState>()
	{
		{StateEnum.Idle, new IdleState()},
		{StateEnum.Run, new RunState()},
		{StateEnum.Walk, new WalkState()}
	};

	public FSM FSM { get; private set; }
	
	public void Start()
	{
		FSM = new FSM();
		FSM.Init(stateDict, StateEnum.Idle);
	}

	private void Update()
	{
		FSM.Update();
	}
}
