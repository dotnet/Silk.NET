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
    [DebuggerDisplay("{OriginalName} = ({Value}) ")]
    public class LocalVariable : IVariable, IEquatable<LocalVariable>
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

        public bool Equals(LocalVariable? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return OriginalName == other.OriginalName && Value.Equals(other.Value);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is LocalVariable other && Equals(other);
        }
        
        public bool Equals
            (IVariable other)
            => ReferenceEquals(this, other) || other is LocalVariable o && Equals(o);

        public override int GetHashCode()
        {
            unchecked
            {
                return (OriginalName.GetHashCode() * 397) ^ Value.GetHashCode();
            }
        }
    }
}
