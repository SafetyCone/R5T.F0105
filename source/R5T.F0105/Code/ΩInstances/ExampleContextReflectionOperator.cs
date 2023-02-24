using System;


namespace R5T.F0105
{
    public class ExampleContextReflectionOperator : IExampleContextReflectionOperator
    {
        #region Infrastructure

        public static IExampleContextReflectionOperator Instance { get; } = new ExampleContextReflectionOperator();


        private ExampleContextReflectionOperator()
        {
        }

        #endregion
    }
}
