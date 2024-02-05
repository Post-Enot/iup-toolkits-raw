namespace IUP.Toolkits.BehaviourTree
{
    public interface INode<TBlackboard> where TBlackboard : IBlackboard
    {
        public Result Perform(TBlackboard blackboard);
    }
}
