using System;
using System.Reflection;

using R5T.T0132;
using R5T.T0161;


namespace R5T.F0105
{
    [FunctionalityMarker]
    public partial interface IExampleContextReflectionOperator : IFunctionalityMarker
    {
        public void InExampleMethodContext_Synchronous(
            TypeName typeName,
            MethodName methodName,
            Action<MethodInfo> methodInfoAction)
        {
            Instances.ReflectionOperator.InMethodContext_Synchronous(
                Instances.FilePaths.ExampleAssemblyFilePath,
                typeName,
                methodName,
                methodInfoAction);
        }

        public void InExamplePropertyContext_Synchronous(
            TypeName typeName,
            PropertyName propertyName,
            Action<PropertyInfo> propertyInfoAction)
        {
            Instances.ReflectionOperator.InPropertyContext_Synchronous(
                Instances.FilePaths.ExampleAssemblyFilePath,
                typeName,
                propertyName,
                propertyInfoAction);
        }

        public void InExampleTypeContext_Synchronous(
            TypeName typeName,
            Action<TypeInfo> typeInfoAction)
        {
            Instances.ReflectionOperator.InTypeContext_Synchronous(
                Instances.FilePaths.ExampleAssemblyFilePath,
                typeName,
                typeInfoAction);
        }

        public void InExampleTypeContext_Synchronous(
            Type type,
            Action<TypeInfo> typeInfoAction)
        {
            Instances.ReflectionOperator.InTypeContext_Synchronous(
                Instances.FilePaths.ExampleAssemblyFilePath,
                type,
                typeInfoAction);
        }

        public void InExampleTypeContext_Synchronous<T>(
            Action<TypeInfo> typeInfoAction)
        {
            Instances.ReflectionOperator.InTypeContext_Synchronous<T>(
                 Instances.FilePaths.ExampleAssemblyFilePath,
                 typeInfoAction);
        }
    }
}
