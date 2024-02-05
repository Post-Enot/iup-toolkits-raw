using System.Xml;

namespace IUP.Toolkits.BehaviourTree.Serialization
{
    public interface INodeMapping<TBlackboard> where TBlackboard : IBlackboard
    {
        public void Add(string xmlTag, NodeInit<TBlackboard> nodeInit);

        public bool Remove(string xmlTag);

        public bool TryInitNode(
            string xmlTag,
            XmlAttributeCollection xmlAttributeCollection,
            out INode<TBlackboard> node);
    }
}
