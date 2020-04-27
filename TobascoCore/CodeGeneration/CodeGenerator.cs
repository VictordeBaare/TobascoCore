using System;
using System.Collections.Generic;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace Tobasco.CodeGeneration
{
    public class CodeGenerator : Task
    {
        [Output]
        public ITaskItem[] GeneratedFiles { get; private set; }

        public override bool Execute()
        {
            GeneratedFiles = new List<ITaskItem> { new TaskItem { ItemSpec = "Test" } }.ToArray();
            return true;
        }
    }
}
