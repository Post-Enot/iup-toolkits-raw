using System.Collections;
using System.Collections.Generic;

namespace IUP.Toolkits.BehaviourTree
{
    public class NestedNodeCollection<TBlackboard> :
        INestedNodeCollection<TBlackboard> where TBlackboard : IBlackboard
    {
        public INode<TBlackboard> this[int index]
        {
            get => _nodes[index];
            set => _nodes[index] = value;
        }

        public int Count => _nodes.Count;

        private readonly List<INode<TBlackboard>> _nodes = new();

        public void AddLeft(INode<TBlackboard> node) => _nodes.Insert(0, node);

        public void AddRight(INode<TBlackboard> node) => _nodes.Add(node);

        public void Insert(int index, INode<TBlackboard> node) => _nodes.Insert(index, node);

        public void Remove(INode<TBlackboard> node) => _nodes.Remove(node);

        public void RemoveAt(int index) => _nodes.RemoveAt(index);

        public void Clear() => _nodes.Clear();

        public bool Contains(INode<TBlackboard> node) => _nodes.Contains(node);

        public IEnumerator<INode<TBlackboard>> GetEnumerator() => _nodes.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => _nodes.GetEnumerator();
    }
}
