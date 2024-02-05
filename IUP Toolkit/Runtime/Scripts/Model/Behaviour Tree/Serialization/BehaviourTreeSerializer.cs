using System;
using System.Xml;

namespace IUP.Toolkits.BehaviourTree.Serialization
{
    public static class BehaviourTreeSerializer
    {
        public static BehaviourTree<TBlackboard> FromXml<TBlackboard>(
            string xml,
            INodeMapping<TBlackboard> nodeMapping) where TBlackboard : IBlackboard
        {
            XmlDocument xmlDocument = LoadXml(xml);
            INode<TBlackboard> rootNode = Deserialize(xmlDocument.DocumentElement.FirstChild, nodeMapping);
            return new BehaviourTree<TBlackboard>(rootNode);
        }

        private static XmlDocument LoadXml(string xml)
        {
            XmlDocument xmlDocument = new();
            xmlDocument.LoadXml(xml);
            ValidateXmlDocument(xmlDocument);
            return xmlDocument;
        }

        private static void ValidateXmlDocument(XmlDocument xmlDocument)
        {
            if (xmlDocument.DocumentElement.Name != XmlNodeTag.Root)
            {
                throw new NotImplementedException(); // TODO.
            }
            if (xmlDocument.DocumentElement.ChildNodes.Count != 1)
            {
                throw new NotImplementedException(); // TODO.
            }
        }

        private static INode<TBlackboard> Deserialize<TBlackboard>(
            XmlNode xmlNode,
            INodeMapping<TBlackboard> nodeMapping) where TBlackboard : IBlackboard
        {
            if (!nodeMapping.TryInitNode(xmlNode.Name, xmlNode.Attributes, out INode<TBlackboard> node))
            {
                throw new NotImplementedException(); // TODO.
            }
            if (node is IActionNode<TBlackboard>)
            {
                if (xmlNode.ChildNodes.Count != 0)
                {
                    throw new NotImplementedException(); // TODO.
                }
            }
            else if (node is IOneNested<TBlackboard> oneNested)
            {
                if (xmlNode.ChildNodes.Count != 1)
                {
                    throw new NotImplementedException(); // TODO;
                }
                oneNested.NestedNode = Deserialize(xmlNode.FirstChild, nodeMapping);
            }
            else if (node is IMultyNested<TBlackboard> multyNested)
            {
                if (xmlNode.ChildNodes.Count == 0)
                {
                    throw new NotImplementedException(); // TODO.
                }
                foreach (XmlNode xmlChildNode in xmlNode.ChildNodes)
                {
                    INode<TBlackboard> childNode = Deserialize(xmlChildNode, nodeMapping);
                    multyNested.NestedNodes.AddRight(childNode);
                }
            }
            return node;
        }
    }
}
