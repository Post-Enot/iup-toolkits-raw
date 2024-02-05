using System.Xml;

namespace IUP.Toolkits.BehaviourTree.Serialization
{
    internal static class NodeInits
    {
        internal static INode<TBlackboard> InitSequence<TBlackboard>(
            XmlAttributeCollection xmlAttributeCollection)
            where TBlackboard : IBlackboard
        {
            return new Sequence<TBlackboard>();
        }

        internal static INode<TBlackboard> InitSelector<TBlackboard>(
            XmlAttributeCollection xmlAttributeCollection)
            where TBlackboard : IBlackboard
        {
            return new Selector<TBlackboard>();
        }

        internal static INode<TBlackboard> InitInvert<TBlackboard>(
            XmlAttributeCollection xmlAttributeCollection)
            where TBlackboard : IBlackboard
        {
            return new Invert<TBlackboard>();
        }

        internal static INode<TBlackboard> InitAlwaysFailure<TBlackboard>(
            XmlAttributeCollection xmlAttributeCollection)
            where TBlackboard : IBlackboard
        {
            return new AlwaysFailure<TBlackboard>();
        }

        internal static INode<TBlackboard> InitAlwaysSuccess<TBlackboard>(
            XmlAttributeCollection xmlAttributeCollection)
            where TBlackboard : IBlackboard
        {
            return new AlwaysSuccess<TBlackboard>();
        }
    }
}
