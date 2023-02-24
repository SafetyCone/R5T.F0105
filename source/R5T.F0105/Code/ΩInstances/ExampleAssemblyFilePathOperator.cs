using System;


namespace R5T.F0105
{
    public class ExampleAssemblyFilePathOperator : IExampleAssemblyFilePathOperator
    {
        #region Infrastructure

        public static IExampleAssemblyFilePathOperator Instance { get; } = new ExampleAssemblyFilePathOperator();


        private ExampleAssemblyFilePathOperator()
        {
        }

        #endregion
    }
}
