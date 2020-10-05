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
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace GenericMathsGenerator.ValueTypes
{
    [DebuggerDisplay("{OriginalName}: {LocalVariable}")]
    public class LocalReferenceValue : IValue, IEquatable<LocalReferenceValue>
    {
        public LocalReferenceValue(string originalName)
        {
            OriginalName = originalName;
        }
        
        public LocalVariable? LocalVariable { get; set; }
        public string OriginalName { get; }

        public int Step => LocalVariable?.Value.Step ?? 0;
        public ExpressionSyntax BuildExpression
            (ImmutableArray<ExpressionSyntax> children, ref List<StatementSyntax> statements, TargetType targetType) 
            => throw new InvalidOperationException();

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

        public bool Equals(LocalReferenceValue? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Equals(LocalVariable, other.LocalVariable) && OriginalName == other.OriginalName;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is LocalReferenceValue other && Equals(other);
        }
        public bool Equals
            (IValue other)
            => ReferenceEquals(this, other) || other is LocalReferenceValue o && Equals(o);

        public override int GetHashCode()
        {
            unchecked
            {
                return ((LocalVariable != null ? LocalVariable.GetHashCode() : 0) * 397) ^ OriginalName.GetHashCode();
            }
        }
    }
}
