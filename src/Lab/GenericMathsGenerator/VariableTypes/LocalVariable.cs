// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Diagnostics;
using GenericMathsGenerator.ValueTypes;

namespace GenericMathsGenerator.VariableTypes
{
    [DebuggerDisplay("{OriginalName} = ({Value}) ")]
    public class LocalVariable : IVariable
    {
        public string OriginalName { get; }
        public IValue Value { get; set; }
        public List<LocalReferenceValue> References { get; set; }

        public LocalVariable(string originalName, IValue value)
        {
            OriginalName = originalName;
            Value = value;
            References = new List<LocalReferenceValue>();
        }
    }
}
