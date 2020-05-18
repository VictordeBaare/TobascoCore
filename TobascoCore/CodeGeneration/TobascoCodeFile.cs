namespace Tobasco.CodeGeneration
{
    public class TobascoCodeFile
    {
        public string Path { get; internal set; }

        public string GeneratedCode { get; internal set; }

        public TobascoGeneratorResult Result { get; set; }
    }

    public enum TobascoGeneratorResult 
    {
        None = 0,
        Success = 1,
    }
}