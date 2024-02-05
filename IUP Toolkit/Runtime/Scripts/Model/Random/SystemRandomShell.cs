using System;

namespace IUP.Toolkits
{
    public sealed class SystemRandomShell : IRandom
    {
        public SystemRandomShell(Random random) => _random = random;

        private readonly Random _random;

        public int InRange(int minInclusive, int maxExclusive) => _random.Next(minInclusive, maxExclusive);
    }
}
