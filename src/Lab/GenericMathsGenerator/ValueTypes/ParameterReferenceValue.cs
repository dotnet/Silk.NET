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

namespace GenericMathsGenerator
{
    [DebuggerDisplay("{ParameterName}")]
    public class ParameterReferenceValue : IValue
    {
        public string ParameterName { get; }

        public ParameterReferenceValue(string parameterName)
        {
            ParameterName = parameterName;
        }

        public Optional<float> ConstantValue => default;

        public IEnumerable<IValue> Children
        {
            get => ImmutableArray<IValue>.Empty;
            set
            {
                if (value.Any())
                    throw new ArgumentOutOfRangeException(nameof(value), "Parameter reference values do not have children");
            }
        }

        public int Step => 0;
    }
}
