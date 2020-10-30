// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.Maths.GenericsGenerator.VariableTypes
{
    [DebuggerDisplay("return ({Value})")]
    public sealed class ReturnVariable : IVariable, IEquatable<ReturnVariable>
    {
        public IValue Value { get; set; }
        public List<IVariableReference> References { get; set; }
        public int ExtraReferences { get; set; }

        public void BuildStatement(IScopeBuilder builder)
            => builder.Statements.Add
                (ReturnStatement(Helpers.Cast(builder.NumericType, Value.Type, builder.Resolve(Value))));

        public ReturnVariable(IValue value)
        {
            Value = value;
            References = new List<IVariableReference>();
        }

        public bool Equals(ReturnVariable? other)
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
            return ReferenceEquals(this, obj) || obj is ReturnVariable other && Equals(other);
        }
        
        public bool Equals
            (IVariable other)
            => ReferenceEquals(this, other) || other is ReturnVariable o && Equals(o);

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public void DebugWrite(TextWriter writer, int indentation = 0)
        {
            Helpers.Indent(writer, indentation);
            writer.WriteLine($"BEGIN RETURN REFC: {References.Count} + {ExtraReferences}");
            Value.DebugWrite(writer, indentation + 1);
        }
    }
}
