// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.Maths.GenericsGenerator.VariableTypes
{
    public sealed class ExtraVariable : IVariable, IEquatable<ExtraVariable>
    {
        public ExtraVariable(IValue value)
        {
            Value = value;
        }

        public void DebugWrite(TextWriter writer, int indentation = 0)
        {
            Helpers.Indent(writer, indentation);
            writer.WriteLine("BEGIN EXTRA");

            Value.DebugWrite(writer, indentation + 1);
        }

        public void BuildStatement(IScopeBuilder builder)
        {
            builder.Statements.Add(ExpressionStatement(builder.Resolve(Value)));
        }

        public IValue Value { get; set; }
        public List<IVariableReference> References { get; set; } = new List<IVariableReference>(0);

        public int ExtraReferences
        {
            get => 10000;
            set { /* no thanks */ }
    }

        public bool Equals(IVariable variable) => variable is ExtraVariable v && Equals(v);

        public bool Equals(ExtraVariable? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Value.Equals(other.Value);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is ExtraVariable other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Value.GetHashCode() * 397) ^ References.GetHashCode();
            }
        }

        public static bool operator ==(ExtraVariable? left, ExtraVariable? right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ExtraVariable? left, ExtraVariable? right)
        {
            return !Equals(left, right);
        }
    }
}
