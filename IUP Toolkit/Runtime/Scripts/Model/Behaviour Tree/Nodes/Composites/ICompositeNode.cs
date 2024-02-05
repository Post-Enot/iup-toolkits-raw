namespace IUP.Toolkits.BehaviourTree
{
    public interface ICompositeNode<TBlackboard> :
        IMultyNested<TBlackboard> where TBlackboard : IBlackboard { }
}
