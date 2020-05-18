using System;
using System.Collections.Generic;
using System.Text;
using Tobasco.CodeGeneration.Builders;

namespace Tobasco.CodeGeneration
{
    public class BuilderResolver
    {
        private readonly CustomBuilderResolver _customBuilderResolver;

        public BuilderResolver(CustomBuilderResolver customBuilderResolver)
        {
            _customBuilderResolver = customBuilderResolver;
        }

        public IBuilder GetRepositoryBuilder(Entity entity, EntityInformation entityInformation)
        {
            if (string.IsNullOrEmpty(entity.EntityLocation.overrideKey))
            {
                return new DapperRepositoryBuilder();
            }
            return _customBuilderResolver.GetCustomBuilderByKey(entity.EntityLocation.overrideKey);
        }

        public IBuilder GetEntityBuilder(Entity entity, EntityInformation entityInformation)
        {
            if (string.IsNullOrEmpty(entity.EntityLocation.overrideKey))
            {
                return new DapperRepositoryBuilder();
            }
            return _customBuilderResolver.GetCustomBuilderByKey(entity.EntityLocation.overrideKey);
        }

        public IBuilder GetDatabaseBuilder(Entity entity, EntityInformation entityInformation)
        {
            if (string.IsNullOrEmpty(entity.EntityLocation.overrideKey))
            {
                return new DapperRepositoryBuilder();
            }
            return _customBuilderResolver.GetCustomBuilderByKey(entity.EntityLocation.overrideKey);
        }
    }
}
