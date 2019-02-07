namespace StateMechine
{
    public class SwitchDemo
    {

        public StateEnum CurrentState { get; private set; }
        
        void Start()
        {
            CurrentState = StateEnum.Idle;
        }

        void Update()
        {
            switch (CurrentState)
            {
                case StateEnum.Idle:
                    //DoSomething
                    break;
                case StateEnum.Run:
                    //DoSomething
                    break;
                case StateEnum.Walk:
                    //DoSomething
                    break;
            }
        }
        
    }
}