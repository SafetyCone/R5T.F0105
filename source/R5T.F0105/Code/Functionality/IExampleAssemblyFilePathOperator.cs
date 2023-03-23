using System;

using R5T.T0132;


namespace R5T.F0105
{
    [FunctionalityMarker]
    public partial interface IExampleAssemblyFilePathOperator : IFunctionalityMarker
    {
        /// <summary>
        /// Get the file path of the example assembly <inheritdoc cref="Documentation.For_ExampleAssembly" path="/identifier"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="Documentation.For_ExampleAssembly" path="/source"/>
        /// </remarks>
        public string Get_ExampleAssemblyFilePath()
        {
            var exampleAssemblyFilePath = Instances.ExecutablePathOperator.Get_ExecutableDirectoryAssemblyFilePath(
                Instances.AssemblyNames.ExampleAssemblyName);

            return exampleAssemblyFilePath;
        }
    }
}
