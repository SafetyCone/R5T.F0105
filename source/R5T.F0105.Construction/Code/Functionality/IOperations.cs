using System;

using R5T.T0132;
using R5T.T0140;


namespace R5T.F0105.Construction
{
    [FunctionalityMarker]
    public partial interface IOperations : IFunctionalityMarker
    {
        public void ListPropertyNames()
        {
            Instances.ExampleContextReflectionOperator.InExampleTypeContext_Synchronous<ExampleProperties>(
                typeInfo =>
                {
                    foreach (var methodInfo in typeInfo.DeclaredProperties)
                    {
                        Console.WriteLine(methodInfo.Name);
                    }
                });
        }

        public void ListMethodNames()
        {
            Instances.ExampleContextReflectionOperator.InExampleTypeContext_Synchronous<ExampleMethods>(
                typeInfo =>
                {
                    foreach (var methodInfo in typeInfo.DeclaredMethods)
                    {
                        Console.WriteLine(methodInfo.Name);
                    }
                });
        }
    }
}
