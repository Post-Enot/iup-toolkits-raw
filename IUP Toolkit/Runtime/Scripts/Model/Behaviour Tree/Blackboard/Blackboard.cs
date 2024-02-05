using System.Collections.Generic;

namespace IUP.Toolkits.BehaviourTree
{
    public class Blackboard : IBlackboard
    {
        private readonly Dictionary<string, object> _paramByName = new();

        public void Add<TValue>(string name, TValue value) => _paramByName.Add(name, value);

        public void Remove(string name) => _paramByName.Remove(name);

        public TValue Get<TValue>(string name) => (TValue)_paramByName[name];

        public void Set<TValue>(string name, TValue value) => _paramByName[name] = value;

        public void Rename(string oldName, string newName) => _paramByName.ChangeKey(oldName, newName);

        public bool Contains(string name) => _paramByName.ContainsKey(name);

        public void Clear() => _paramByName.Clear();
    }
}
