using System;

using R5T.T0131;


namespace R5T.F0105
{
    [ValuesMarker]
    public partial interface IAssemblyNames : IValuesMarker
    {
        public string ExampleAssemblyName => this.R5T_T0140;

        public string R5T_T0140 => "R5T.T0140";
    }
}
