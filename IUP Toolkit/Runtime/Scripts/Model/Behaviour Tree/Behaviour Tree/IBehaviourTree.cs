namespace IUP.Toolkits.BehaviourTree
{
    public interface IBehaviourTree<TBlackboard> where TBlackboard : IBlackboard
    {
        public TBlackboard Blackboard { get; set; }
        public INode<TBlackboard> RootNode { get; }

        public Result Perform();
    }
}
