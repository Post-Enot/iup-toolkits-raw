namespace IUP.Toolkits.BehaviourTree
{
    public interface IDecoratorNode<TBlackboard> : IOneNested<TBlackboard> where TBlackboard : IBlackboard { }
}
