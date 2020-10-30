// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.Maths.GenericsGenerator.ValueTypes
{
    [DebuggerDisplay("{_value}")]
    public sealed class LiteralValue : IValue, IEquatable<LiteralValue>
    {
        public LiteralValue(float value)
        {
            _value = value;
            Type = Type.Numeric;
        }

        public LiteralValue(bool value)
        {
            _value = value;
            Type = Type.Boolean;
        }

        public LiteralValue(object value, Type type = Type.Unknown)
        {
            _value = value;
            Type = type;
        }

        private object _value;

        public Type Type { get; }
        public IScope Scope { get; set; }
        public IValue? Parent { get; set; }
        public Optional<object> ConstantValue => new Optional<object>(_value);
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
            (IScopeBuilder scopeBuilder, ImmutableArray<ExpressionSyntax> children)
        {
            Debug.Assert(children.Length == 0);
            return Type switch
            {
                Type.Numeric => CastExpression
                (
                    scopeBuilder.NumericType.GetTypeSyntax(), LiteralExpression
                    (
                        SyntaxKind.NumericLiteralExpression, scopeBuilder.NumericType switch
                        {
                            NumericTargetType.Byte => Literal((byte) (float)_value),
                            NumericTargetType.SByte => Literal((sbyte) (float)_value),
                            NumericTargetType.UShort => Literal((ushort) (float)_value),
                            NumericTargetType.Short => Literal((short) (float)_value),
                            NumericTargetType.UInt => Literal((uint) (float)_value),
                            NumericTargetType.Int => Literal((int) (float)_value),
                            NumericTargetType.ULong => Literal((ulong) (float)_value),
                            NumericTargetType.Long => Literal((long) (float)_value),
                            NumericTargetType.Single => Literal((float)_value),
                            NumericTargetType.Double => Literal((double) (float)_value),
                            _ => throw new ArgumentOutOfRangeException(nameof(scopeBuilder.NumericType))
                        }
                    )
                ),
                Type.Boolean => ((bool) _value)
                    ? LiteralExpression(SyntaxKind.TrueLiteralExpression)
                    : LiteralExpression(SyntaxKind.FalseLiteralExpression),
                _ => throw new TypeMismatchException
                    ($"Trying to resolve {Enum.GetName(typeof(Type), Type)} Type Literal")
            };
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

        public void DebugWrite(TextWriter writer, int indentation = 0)
        {
            Helpers.Indent(writer, indentation);
            writer.WriteLine($"LITERAL {ConstantValue.Value}");
        }
    }
}
