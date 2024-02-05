namespace IUP.Toolkits.BehaviourTree
{
    public interface INestedNodeCollection<TBlackboard> :
        IReadOnlyNestedNodeCollection<TBlackboard> where TBlackboard : IBlackboard
    {
        public new INode<TBlackboard> this[int index] { get; set; }

        public void Remove(INode<TBlackboard> node);

        public void RemoveAt(int index);

        public void Insert(int index, INode<TBlackboard> node);

        public void AddLeft(INode<TBlackboard> node);

        public void AddRight(INode<TBlackboard> node);

        public void Clear();
    }
}
