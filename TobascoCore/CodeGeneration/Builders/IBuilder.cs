using Microsoft.Build.Framework;

namespace Tobasco.CodeGeneration.Builders
{
    public interface IBuilder
    {
        ITaskItem[] GeneratedCodeFiles(Entity entity, EntityInformation entityInformation);
    }
}
