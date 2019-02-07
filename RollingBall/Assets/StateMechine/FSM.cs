using System.Collections.Generic;

namespace StateMechine
{
    public class FSM
    {
        public BaseState CurrentState { get; private set; }
        
        private Dictionary<StateEnum, BaseState> _stateDict;

        public void Init(Dictionary<StateEnum, BaseState> stateDict, StateEnum startState)
        {
            _stateDict = stateDict;
            CurrentState = _stateDict[startState];
            CurrentState.OnEnter();
        }
        
        public void Enter(StateEnum nextState)
        {
            CurrentState.OnExit();
            CurrentState = _stateDict[nextState];
            CurrentState.OnEnter();
        }

        public void Update()
        {
            CurrentState.Update();
        }
        
    }
}