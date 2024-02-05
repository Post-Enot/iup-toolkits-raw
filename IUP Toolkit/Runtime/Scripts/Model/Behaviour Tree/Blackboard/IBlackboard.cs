namespace IUP.Toolkits.BehaviourTree
{
    public interface IBlackboard
    {
        public void Add<TValue>(string name, TValue value);

        public TValue Get<TValue>(string name);

        public void Set<TValue>(string name, TValue value);

        public void Rename(string oldName, string newName);

        public bool Contains(string name);

        public void Remove(string name);

        public void Clear();
    }
}
