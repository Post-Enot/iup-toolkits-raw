using System.Collections.Generic;

namespace IUP.Toolkits.BehaviourTree
{
    public interface IReadOnlyNestedNodeCollection<TBlackboard> :
        IReadOnlyCollection<INode<TBlackboard>> where TBlackboard : IBlackboard
    {
        public INode<TBlackboard> this[int index] { get; }

        public bool Contains(INode<TBlackboard> node);
    }
}
