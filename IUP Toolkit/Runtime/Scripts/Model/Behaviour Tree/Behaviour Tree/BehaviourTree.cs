namespace IUP.Toolkits.BehaviourTree
{
    public sealed class BehaviourTree<TBlackboard> :
        IBehaviourTree<TBlackboard> where TBlackboard : IBlackboard
    {
        public BehaviourTree(INode<TBlackboard> rootNode) => RootNode = rootNode;

        public TBlackboard Blackboard { get; set; }
        public INode<TBlackboard> RootNode { get; }

        public Result Perform() => RootNode.Perform(Blackboard);
    }
}
