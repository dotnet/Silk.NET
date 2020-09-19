// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using GenericMathsGenerator.VariableTypes;
using Microsoft.CodeAnalysis;

namespace GenericMathsGenerator.ValueTypes
{
    [DebuggerDisplay("{OriginalName}: {LocalVariable}")]
    public class LocalReferenceValue : IValue
    {
        public LocalReferenceValue(string originalName)
        {
            OriginalName = originalName;
        }
        
        public LocalVariable? LocalVariable { get; set; }
        public string OriginalName { get; }

        public int Step => LocalVariable?.Value.Step ?? 0;

        public Optional<float> ConstantValue => LocalVariable?.Value.ConstantValue ?? default;

        public IEnumerable<IValue> Children
        {
            get => LocalVariable?.Value.Children ?? ImmutableArray<IValue>.Empty;
            set
            {
                if (LocalVariable is null)
                {
                    if (value.Any())
                        throw new ArgumentOutOfRangeException(nameof(value), $"Unresolved {nameof(LocalReferenceValue)}s cannot passthrough setters");
                }
                else
                {
                    LocalVariable.Value.Children = value;
                }
            }
        }
    }
}
