using Microsoft.Build.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tobasco.CodeGeneration
{
    public class DapperCodeGenerator
    {
        public void ResolveDapperCodeFiles(CustomBuilderResolver customBuilderResolver, EntityInformation entityInformation, List<string> filePaths, TaskLoggingHelper log)
        {            
            var builders = new BuilderResolver(customBuilderResolver);
                        
            foreach(var path in filePaths)
            {
                log.LogMessage(path);
            }
        }
    }
}
