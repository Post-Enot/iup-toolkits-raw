namespace IUP.Toolkits.BehaviourTree
{
    public interface IMultyNested<TBlackboard> : INode<TBlackboard> where TBlackboard : IBlackboard
    {
        public INestedNodeCollection<TBlackboard> NestedNodes { get; }
    }
}
