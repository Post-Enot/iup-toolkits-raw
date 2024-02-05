namespace IUP.Toolkits.BehaviourTree
{
    public interface IOneNested<TBlackboard> : INode<TBlackboard> where TBlackboard : IBlackboard
    {
        public INode<TBlackboard> NestedNode { get; set; }
    }
}
