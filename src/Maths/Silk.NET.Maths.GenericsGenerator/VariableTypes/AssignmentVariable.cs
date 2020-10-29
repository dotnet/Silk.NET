// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace GenericMathsGenerator.VariableTypes
{
    public sealed class AssignmentVariable : IVariable
    {
        public string OriginalName { get; }
        public IValue Value { get; set; }
        public List<IVariableReference> References { get; set; }
        public int ExtraReferences { get; set; }
        public StatementSyntax BuildStatement(IBodyBuilder builder, ExpressionSyntax value)
            => ExpressionStatement
            (AssignmentExpression(SyntaxKind.SimpleAssignmentExpression, IdentifierName(OriginalName), value));

        public AssignmentVariable(string originalName, IValue value)
        {
            OriginalName = originalName;
            Value = value;
            References = new List<IVariableReference>();
        }

        public bool Equals(LocalVariable? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return OriginalName == other.OriginalName && Value.Equals(other.Value);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is AssignmentVariable other && Equals(other);
        }
        
        public bool Equals
            (IVariable other)
            => ReferenceEquals(this, other) || other is AssignmentVariable o && Equals(o);

        public override int GetHashCode()
        {
            unchecked
            {
                return (OriginalName.GetHashCode() * 397) ^ Value.GetHashCode();
            }
        }
    }
}
