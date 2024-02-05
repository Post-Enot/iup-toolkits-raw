namespace IUP.Toolkits.BehaviourTree
{
    public sealed class Sequence<TBlackboard> : ICompositeNode<TBlackboard> where TBlackboard : IBlackboard
    {
        public INestedNodeCollection<TBlackboard> NestedNodes { get; }

        public Result Perform(TBlackboard blackboard)
        {
            foreach (INode<TBlackboard> node in NestedNodes)
            {
                Result result = node.Perform(blackboard);
                if (result != Result.Success)
                {
                    return Result.Failure;
                }
            }
            return Result.Success;
        }
    }
}
