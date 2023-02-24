using System;


namespace R5T.F0105
{
    public static class Instances
    {
        public static IAssemblyNames AssemblyNames => F0105.AssemblyNames.Instance;
        public static IExampleAssemblyFilePathOperator ExampleAssemblyFilePathOperator => F0105.ExampleAssemblyFilePathOperator.Instance;
        public static F0002.IExecutablePathOperator ExecutablePathOperator => F0002.ExecutablePathOperator.Instance;
        public static F0000.IFileNameOperator FileNameOperator => F0000.FileNameOperator.Instance;
        public static IFilePaths FilePaths => F0105.FilePaths.Instance;
        public static F0018.F001.IReflectionOperator ReflectionOperator => F0018.F001.ReflectionOperator.Instance;
        public static F0018.F001.ITypeOperator TypeOperator => F0018.F001.TypeOperator.Instance;
    }
}