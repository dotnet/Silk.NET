// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Diagnostics;
using GenericMathsGenerator.ValueTypes;

namespace GenericMathsGenerator.VariableTypes
{
    [DebuggerDisplay("return ({Value})")]
    public class ReturnVariable : IVariable
    {
        public IValue Value { get; set; }
        public List<LocalReferenceValue> References { get; set; }

        public ReturnVariable(IValue value)
        {
            Value = value;
            References = new List<LocalReferenceValue>();
        }
    }
}
