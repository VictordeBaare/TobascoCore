using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using Tobasco.CodeGeneration.Xml;

namespace Tobasco.CodeGeneration
{
    public class CodeGenerator : Task
    {
        [Required]
        public string ProjectPath { get; set; }

        public ITaskItem[] TobascoFiles { get; set; }

        public ITaskItem TobascoConfigFile { get; set; }

        [Output]
        public ITaskItem[] GeneratedFiles { get; private set; }

        public string ProjectFolder => Path.GetDirectoryName(ProjectPath);

        public override bool Execute()
        {
            var tobascoFilePaths = TobascoFiles?.Select(x => x.ItemSpec).ToList() ?? new List<string>();
            var tobascoConfigFilePath = TobascoConfigFile?.ItemSpec ?? string.Empty;

            var tobascoConfig = XmlLoader.Load<EntityInformation>(tobascoConfigFilePath);

            new DapperCodeGenerator().ResolveDapperCodeFiles(new CustomBuilderResolver(), tobascoConfig, tobascoFilePaths, Log);

            GeneratedFiles = new List<ITaskItem> { new TaskItem { ItemSpec = "Test" } }.ToArray();
            return true;
        }
    }
}
