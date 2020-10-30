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
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.Maths.GenericsGenerator.ValueTypes
{
    [DebuggerDisplay("{Name}: {LocalVariable}")]
    public sealed class LocalReferenceValue : IValue, IVariableReference, IEquatable<LocalReferenceValue>
    {
        public LocalReferenceValue(string name)
        {
            Name = name;
        }
        
        public IVariable? LocalVariable { get; set; }
        public string Name { get; }

        public int Step => (LocalVariable?.Value.Step + 1) ?? 0;

        public ExpressionSyntax BuildExpression
            (IScopeBuilder scopeBuilder, ImmutableArray<ExpressionSyntax> children)
        {
            if (LocalVariable is null)
                throw new InvalidOperationException($"Local variable reference has not been resolved");
            
            var name = Name;
            return IdentifierName(name);
        }

        public IScope Scope { get; set; }
        public IValue? Parent { get; set; }
        public Type Type => LocalVariable?.Value.Type ?? Type.Unknown;
        public Optional<object> ConstantValue => LocalVariable?.Value.ConstantValue ?? default;

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

            return Equals(LocalVariable, other.LocalVariable) && Name == other.Name;
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
                return ((LocalVariable != null ? LocalVariable.GetHashCode() : 0) * 397) ^ Name.GetHashCode();
            }
        }

        public void DebugWrite(TextWriter writer, int indentation = 0)
        {
            Helpers.Indent(writer, indentation);
            writer.WriteLine($"LOCAL REF {Name}");
        }
    }
}
