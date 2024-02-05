namespace IUP.Toolkits.BehaviourTree
{
    public interface IActionNode<TBlackboard> : INode<TBlackboard> where TBlackboard : IBlackboard { }
}
