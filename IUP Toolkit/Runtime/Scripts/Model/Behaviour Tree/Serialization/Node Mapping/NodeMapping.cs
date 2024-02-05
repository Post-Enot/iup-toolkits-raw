using System.Collections.Generic;
using System.Xml;

namespace IUP.Toolkits.BehaviourTree.Serialization
{
    public sealed class NodeMapping<TBlackboard> : INodeMapping<TBlackboard> where TBlackboard : IBlackboard
    {
        public NodeMapping()
        {
            _nodeInitByXmlTag.Add(
                XmlNodeTag.Sequence,
                NodeInits.InitSequence<TBlackboard>);
            _nodeInitByXmlTag.Add(
                XmlNodeTag.Selector,
                NodeInits.InitSelector<TBlackboard>);

            _nodeInitByXmlTag.Add(
                XmlNodeTag.Invert,
                NodeInits.InitInvert<TBlackboard>);
            _nodeInitByXmlTag.Add(
                XmlNodeTag.AlwaysFailure,
                NodeInits.InitAlwaysFailure<TBlackboard>);
            _nodeInitByXmlTag.Add(
                XmlNodeTag.AlwaysSuccess,
                NodeInits.InitAlwaysSuccess<TBlackboard>);
        }

        private readonly Dictionary<string, NodeInit<TBlackboard>> _nodeInitByXmlTag = new();

        public void Add(string xmlTag, NodeInit<TBlackboard> nodeInit) =>
            _nodeInitByXmlTag.Add(xmlTag, nodeInit);

        public bool Remove(string xmlTag) => _nodeInitByXmlTag.Remove(xmlTag);

        public bool TryInitNode(
            string xmlTag,
            XmlAttributeCollection
            xmlAttributeCollection, out INode<TBlackboard> node)
        {
            if (!_nodeInitByXmlTag.ContainsKey(xmlTag))
            {
                node = null;
                return false;
            }
            NodeInit<TBlackboard> nodeInit = _nodeInitByXmlTag[xmlTag];
            node = nodeInit(xmlAttributeCollection);
            return true;
        }
    }
}
