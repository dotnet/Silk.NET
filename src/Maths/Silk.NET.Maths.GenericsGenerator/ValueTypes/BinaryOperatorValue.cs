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

namespace Silk.NET.Maths.GenericsGenerator.ValueTypes
{
    [DebuggerDisplay("({Left}) {OpStr} ({Right})")]
    public abstract class BinaryOperatorValue : IValue, IEquatable<BinaryOperatorValue>
    {
        private IValue _left;
        private IValue _right;
        private Lazy<int> _step;
        private Lazy<Optional<object>> _constantValue;

        public abstract Type Type { get; }

        public IValue Left
        {
            get => _left;
            set
            {
                _left = value;
                Recalculate();
            }
        }

        public IValue Right
        {
            get => _right;
            set 
            { 
                _right = value;
                Recalculate();
            }
        }

        public int Step => _step.Value;

        public ExpressionSyntax BuildExpression
            (IScopeBuilder scopeBuilder, ImmutableArray<ExpressionSyntax> children)
        {
            Debug.Assert(children.Length == 2);
            return SyntaxFactory.BinaryExpression(OpSyntaxKind, children[0], children[1]);
        }

        public IScope Scope { get; set; }
        public IValue? Parent { get; set; }
        public Optional<object> ConstantValue => _constantValue.Value;
        public IEnumerable<IValue> Children
        {
            get => new[] {Left, Right};
            set
            {
                var arr = value.ToArray();
                if (arr.Length > 2)
                    throw new ArgumentOutOfRangeException(nameof(arr.Length), "Binary operator values have 2 children");
                if (arr.Length > 0)
                {
                    if (arr[0].Type != Type.Numeric && arr[0].Type != Type.Unknown)
                        throw new TypeMismatchException($"Type was {Enum.GetName(typeof(Type), arr[0].Type)} but should be {nameof(Type.Numeric)}");
                    _left = arr[0];
                    if (arr.Length > 1)
                    {
                        if (arr[1].Type != Type.Numeric && arr[1].Type != Type.Unknown)
                            throw new TypeMismatchException($"Type was {Enum.GetName(typeof(Type), arr[1].Type)} but should be {nameof(Type.Numeric)}");
                        _right = arr[1];
                    }
                }

                Recalculate();
            }
        }

        private void Recalculate()
        {
            _step = new Lazy<int>(() => (Left.Step > Right.Step ? Left.Step : Right.Step) + 1);
            _constantValue = new Lazy<Optional<object>>(() => Left.ConstantValue.HasValue && Right.ConstantValue.HasValue ? new Optional<object>(Process(Left.ConstantValue.Value, Right.ConstantValue.Value)) : default);
        }

        protected abstract object Process(object left, object right);
        protected abstract string OpStr { get; }
        protected abstract SyntaxKind OpSyntaxKind { get; }

        public bool Equals(BinaryOperatorValue? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return _left.Equals(other._left) && _right.Equals(other._right) && OpStr == other.OpStr;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is BinaryOperatorValue other && Equals(other);
        }
        
        public bool Equals
            (IValue other)
            => ReferenceEquals(this, other) || other is BinaryOperatorValue o && Equals(o);

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = _left.GetHashCode();
                hashCode = (hashCode * 397) ^ _right.GetHashCode();
                hashCode = (hashCode * 397) ^ OpStr.GetHashCode();
                return hashCode;
            }
        }

        public abstract void DebugWrite(TextWriter writer, int indentation = 0);
    }
}
