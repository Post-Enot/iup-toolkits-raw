namespace IUP.Toolkits.BehaviourTree
{
    public sealed class Invert<TBlackboard> : IDecoratorNode<TBlackboard> where TBlackboard : IBlackboard
    {
        public INode<TBlackboard> NestedNode { get; set; }

        public Result Perform(TBlackboard blackboard) => NestedNode.Perform(blackboard).Invert();
    }
}
