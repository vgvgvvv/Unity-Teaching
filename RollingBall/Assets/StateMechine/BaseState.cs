namespace StateMechine
{

    public enum StateEnum
    {
        Idle,
        Run,
        Walk
    }
    
    public abstract class BaseState
    {
        public abstract void OnEnter();

        public abstract void Update();

        public abstract void OnExit();
    }


    public class IdleState : BaseState
    {
        public override void OnEnter()
        {
            
        }

        public override void Update()
        {
            
        }

        public override void OnExit()
        {
            
        }
    }


    public class RunState : BaseState
    {
        public override void OnEnter()
        {
            
        }

        public override void Update()
        {
            
        }

        public override void OnExit()
        {
            
        }
    }

    public class WalkState : BaseState
    {
        public override void OnEnter()
        {
            
        }

        public override void Update()
        {
            
        }

        public override void OnExit()
        {
            
        }
    }
}