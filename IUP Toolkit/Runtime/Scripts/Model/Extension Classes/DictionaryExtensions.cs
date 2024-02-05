using System.Collections.Generic;

namespace IUP.Toolkits
{
    public static class DictionaryExtensions
    {
        public static void ChangeKey<TKey, TValue>(
            this Dictionary<TKey, TValue> dictionary,
            TKey oldKey,
            TKey newKey)
        {
            TValue value = dictionary[oldKey];
            _ = dictionary.Remove(oldKey);
            dictionary.Add(newKey, value);
        }
    }
}
