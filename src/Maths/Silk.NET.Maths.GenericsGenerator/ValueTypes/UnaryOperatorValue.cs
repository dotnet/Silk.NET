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
    [DebuggerDisplay("{OpStr}({Child})")]
    public abstract class UnaryOperatorValue : IValue, IEquatable<UnaryOperatorValue>
    {
        private IValue _child;
        private Lazy<int> _step;
        private Lazy<Optional<object>> _constantValue;

        public IValue Child
        {
            get => _child;
            set
            {
                _child = value;
                Recalculate();
            }
        }

        public int Step => _step.Value;
        public ExpressionSyntax BuildExpression
            (IBodyBuilder bodyBuilder, ImmutableArray<ExpressionSyntax> children)
        {
            Debug.Assert(children.Length == 1);
            return SyntaxFactory.PrefixUnaryExpression(OpSyntaxKind, children[0]);
        }

        public Scope Scope { get; set; }
        public IValue? Parent { get; set; }

        public Type Type => Type.Numeric;

        public Optional<object> ConstantValue
            => _constantValue.Value;

        public IEnumerable<IValue> Children
        {
            get => new[] {Child};
            set
            {
                var arr = value.ToArray();
                if (arr.Length > 1)
                    throw new ArgumentOutOfRangeException
                        (nameof(arr.Length), "Unary operator values have 1 child");
                if (arr.Length > 0)
                {
                    if (arr[0].Type != Type.Numeric)
                        throw new TypeMismatchException($"Type was {Enum.GetName(typeof(Type), arr[0].Type)} but should be {nameof(Type.Numeric)}");
                    _child = arr[0];
                }

                Recalculate();
            }
        }

        private void Recalculate()
        {
            _step = new Lazy<int>(() => Child.Step + 1);
            _constantValue = new Lazy<Optional<object>>(() => Child.ConstantValue.HasValue ? new Optional<object>(Process(Child.ConstantValue.Value)) : default);
        }

        protected abstract object Process(object f);
        protected abstract string OpStr { get; }
        protected abstract SyntaxKind OpSyntaxKind { get; }

        public bool Equals(UnaryOperatorValue? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return _child.Equals(other._child) && OpStr == other.OpStr;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is UnaryOperatorValue other && Equals(other);
        }

        public bool Equals
            (IValue other)
            => ReferenceEquals(this, other) || other is UnaryOperatorValue o && Equals(o);
        
        public override int GetHashCode()
        {
            unchecked
            {
                return (_child.GetHashCode() * 397) ^ OpStr.GetHashCode();
            }
        }
    }
}
