// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.Maths.GenericsGenerator.ValueTypes
{
    public sealed class AssignmentValue : IValue, IEquatable<AssignmentValue>
    {
        private IValue _left;
        private IValue _right;
        private Lazy<int> _step;
        
        public void DebugWrite(TextWriter writer, int indentation = 0)
        {
            Helpers.Indent(writer, indentation);
            writer.WriteLine("BEGIN ASSIGNMENT");
            Left.DebugWrite(writer, indentation + 1);
            Right.DebugWrite(writer, indentation + 1);
        }

        public IScope Scope { get; set; }
        public IValue? Parent { get; set; }
        public Type Type => Left.Type; // it's very likely we don't know the type of right, but it's very likely we know the type of left
        public Optional<object> ConstantValue => default;
        
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

        public IEnumerable<IValue> Children
        {
            get => new[] {_left, _right};
            set
            {
                var arr = value.ToArray();
                if (arr.Length > 2)
                    throw new ArgumentOutOfRangeException(nameof(arr.Length), "Assignment values have 2 children");
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
            }
        }

        public void Recalculate()
        {
            _step = new Lazy<int>(() => (Left.Step > Right.Step ? Left.Step : Right.Step) + 1);
        }

        public int Step => _step.Value;
        public ExpressionSyntax BuildExpression(IScopeBuilder scopeBuilder, ImmutableArray<ExpressionSyntax> children)
        {
            return AssignmentExpression(SyntaxKind.SimpleAssignmentExpression, children[0] , Helpers.Cast(scopeBuilder.NumericType, Left.Type, children[1]));
        }

        public bool Equals(IValue other) => other is AssignmentValue v && Equals(v);

        public bool Equals(AssignmentValue? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return _left.Equals(other._left) && _right.Equals(other._right) && _step.Equals(other._step) && Scope.Equals(other.Scope) && Equals(Parent, other.Parent) && Type == other.Type;
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is AssignmentValue other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = _left.GetHashCode();
                hashCode = (hashCode * 397) ^ (_right?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (_step?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (Scope?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (Parent != null ? Parent.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (int) Type;
                return hashCode;
            }
        }

        public static bool operator ==(AssignmentValue? left, AssignmentValue? right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AssignmentValue? left, AssignmentValue? right)
        {
            return !Equals(left, right);
        }
    }
}
