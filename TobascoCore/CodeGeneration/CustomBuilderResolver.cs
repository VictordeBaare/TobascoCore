using System;
using System.Collections.Generic;
using Tobasco.CodeGeneration.Builders;

namespace Tobasco.CodeGeneration
{
    public class CustomBuilderResolver
    {
        private Dictionary<string, IBuilder> _builders;

        public CustomBuilderResolver()
        {
            _builders = new Dictionary<string, IBuilder>();
        }

        public IBuilder GetCustomBuilderByKey(string key)
        {
            if (_builders.ContainsKey(key))
            {
                return _builders[key];
            }
            throw new ArgumentOutOfRangeException(nameof(key), $"No builder could be found with the key: {key}");
        }

        public void AddCustomBuilderByKey(string key, IBuilder builder)
        {
            if (!_builders.ContainsKey(key))
            {
                _builders.Add(key, builder);
            }
        }
    }
}
