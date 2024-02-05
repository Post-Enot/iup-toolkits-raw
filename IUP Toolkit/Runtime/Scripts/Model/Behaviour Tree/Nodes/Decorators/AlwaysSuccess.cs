namespace IUP.Toolkits.BehaviourTree
{
    public sealed class AlwaysSuccess<TBlackboard> :
        IDecoratorNode<TBlackboard> where TBlackboard : IBlackboard
    {
        public INode<TBlackboard> NestedNode { get; set; }

        public Result Perform(TBlackboard blackboard)
        {
            Result result = NestedNode.Perform(blackboard);
            if (result == Result.Failure)
            {
                return Result.Success;
            }
            return result;
        }
    }
}
