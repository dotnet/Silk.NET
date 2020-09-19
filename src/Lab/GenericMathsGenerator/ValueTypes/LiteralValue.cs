// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace GenericMathsGenerator.ValueTypes
{
    [DebuggerDisplay("{_value}")]
    public class LiteralValue : IValue
    {
        public LiteralValue(float value)
        {
            _value = value;
        }

        private float _value;
        public Optional<float> ConstantValue => new Optional<float>(_value);
        public IEnumerable<IValue> Children
        {
            get => ImmutableArray<IValue>.Empty;
            set
            {
                if (value.Any())
                    throw new ArgumentOutOfRangeException(nameof(value), "Literal values do not have children");
            }
        }

        public int Step => 0;
    }
}
