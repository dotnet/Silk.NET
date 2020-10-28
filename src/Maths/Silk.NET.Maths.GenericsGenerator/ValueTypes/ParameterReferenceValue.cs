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
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace GenericMathsGenerator
{
    [DebuggerDisplay("{ParameterName}")]
    public class ParameterReferenceValue : IValue, IEquatable<ParameterReferenceValue>
    {
        public string ParameterName { get; }

        public ParameterReferenceValue(string parameterName)
        {
            ParameterName = parameterName;
        }

        public IValue? Parent { get; set; }
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

        public ExpressionSyntax BuildExpression
            (IBodyBuilder bodyBuilder, ImmutableArray<ExpressionSyntax> children)
        {
            return SyntaxFactory.IdentifierName(ParameterName);
        }

        public bool Equals(ParameterReferenceValue? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return ParameterName == other.ParameterName;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is ParameterReferenceValue other && Equals(other);
        }

        public bool Equals
            (IValue other)
            => ReferenceEquals(this, other) || other is ParameterReferenceValue o && Equals(o);

        public override int GetHashCode()
        {
            return ParameterName.GetHashCode();
        }
    }
}
