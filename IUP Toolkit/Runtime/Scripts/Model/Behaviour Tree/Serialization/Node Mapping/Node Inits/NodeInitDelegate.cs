using System.Xml;

namespace IUP.Toolkits.BehaviourTree.Serialization
{
    public delegate INode<TBlackboard> NodeInit<TBlackboard>(XmlAttributeCollection attributes)
        where TBlackboard : IBlackboard;
}
