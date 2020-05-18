using Microsoft.Build.Utilities;
using System.IO;
using System.Text;

namespace Tobasco.CodeGeneration
{
    public class FileWriter
    {
        private readonly TaskLoggingHelper log;

        public FileWriter(TaskLoggingHelper log)
        {
            this.log = log;
        }

        public void WriteOutputToFile(TobascoCodeFile tobascoCodeFile)
        {
            if (File.Exists(tobascoCodeFile.Path))
            {
                if(FileComparer.IsFileContentEqual(tobascoCodeFile.Path, tobascoCodeFile.GeneratedCode))
                {
                    File.WriteAllText(tobascoCodeFile.Path, tobascoCodeFile.GeneratedCode, Encoding.UTF8);
                }
            }
            else
            {
                File.WriteAllText(tobascoCodeFile.Path, tobascoCodeFile.GeneratedCode); 
            }
        }
    }
}
