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
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace GenericMathsGenerator.ValueTypes
{
    [DebuggerDisplay("{_value}")]
    public class LiteralValue : IValue, IEquatable<LiteralValue>
    {
        public LiteralValue(float value)
        {
            _value = value;
        }

        private float _value;

        public IValue? Parent { get; set; }
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

        public ExpressionSyntax BuildExpression
            (IBodyBuilder bodyBuilder, ImmutableArray<ExpressionSyntax> children)
        {
            Debug.Assert(children.Length == 0);
            return CastExpression
            (
                bodyBuilder.Type.GetTypeSyntax(), LiteralExpression
                (
                    SyntaxKind.NumericLiteralExpression, bodyBuilder.Type switch
                    {
                        TargetType.Byte => Literal((byte) _value),
                        TargetType.SByte => Literal((sbyte) _value),
                        TargetType.UShort => Literal((ushort) _value),
                        TargetType.Short => Literal((short) _value),
                        TargetType.UInt => Literal((uint) _value),
                        TargetType.Int => Literal((int) _value),
                        TargetType.ULong => Literal((ulong) _value),
                        TargetType.Long => Literal((long) _value),
                        TargetType.Single => Literal((float) _value),
                        TargetType.Double => Literal((double) _value),
                        _ => throw new ArgumentOutOfRangeException(nameof(bodyBuilder.Type))
                    }
                )
            );
        }

        public bool Equals(LiteralValue? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return _value.Equals(other._value);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is LiteralValue other && Equals(other);
        }
        
        public bool Equals
            (IValue other)
            => ReferenceEquals(this, other) || other is LiteralValue o && Equals(o);

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }
    }
}
