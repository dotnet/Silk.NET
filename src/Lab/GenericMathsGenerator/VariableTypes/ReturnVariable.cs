// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using GenericMathsGenerator.ValueTypes;

namespace GenericMathsGenerator.VariableTypes
{
    [DebuggerDisplay("return ({Value})")]
    public class ReturnVariable : IVariable, IEquatable<ReturnVariable>
    {
        public IValue Value { get; set; }
        public ReturnVariable(IValue value)
        {
            Value = value;
        }

        public bool Equals(ReturnVariable? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Value.Equals(other.Value);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is ReturnVariable other && Equals(other);
        }
        
        public bool Equals
            (IVariable other)
            => ReferenceEquals(this, other) || other is ReturnVariable o && Equals(o);

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}
