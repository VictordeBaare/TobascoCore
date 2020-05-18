using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tobasco.CodeGeneration.Builders
{
    public class DapperRepositoryBuilder : IBuilder
    {
        public ITaskItem[] GeneratedCodeFiles(Entity entity, EntityInformation entityInformation)
        {
            return Array.Empty<ITaskItem>();
        }
    }
}
