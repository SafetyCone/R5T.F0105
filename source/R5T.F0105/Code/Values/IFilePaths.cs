using System;

using R5T.T0131;


namespace R5T.F0105
{
    [ValuesMarker]
    public partial interface IFilePaths : IValuesMarker
    {
        public string ExampleAssemblyFilePath => Instances.ExampleAssemblyFilePathOperator.Get_ExampleAssemblyFilePath();
    }
}
