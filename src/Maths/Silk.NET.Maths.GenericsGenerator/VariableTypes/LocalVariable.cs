// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.Maths.GenericsGenerator.VariableTypes
{
    [DebuggerDisplay("{OriginalName} = ({Value}) ")]
    public class LocalVariable : IVariable, IEquatable<LocalVariable>
    {
        public string OriginalName { get; }
        public IValue Value { get; set; }
        public List<IVariableReference> References { get; set; }
        public int ExtraReferences { get; set; }

        public StatementSyntax BuildStatement(IBodyBuilder builder, ExpressionSyntax value)
            => LocalDeclarationStatement
            (
                VariableDeclaration
                (
                    Value.Type switch
                    {
                        Type.Numeric => builder.NumericType.GetTypeSyntax(),
                        Type.Boolean => PredefinedType(Token(SyntaxKind.BoolKeyword)),
                        _ => throw new TypeMismatchException
                            ($"Trying to resolve {Enum.GetName(typeof(Type), Value.Type)} Type Literal")
                    },
                    SingletonSeparatedList(VariableDeclarator(OriginalName).WithInitializer(EqualsValueClause(value)))
                )
            );

        public LocalVariable(string originalName, IValue value)
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
            return ReferenceEquals(this, obj) || obj is LocalVariable other && Equals(other);
        }
        
        public bool Equals
            (IVariable other)
            => ReferenceEquals(this, other) || other is LocalVariable o && Equals(o);

        public override int GetHashCode()
        {
            unchecked
            {
                return (OriginalName.GetHashCode() * 397) ^ Value.GetHashCode();
            }
        }
    }
}
