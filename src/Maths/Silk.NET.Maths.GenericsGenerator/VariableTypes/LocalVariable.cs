// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.Maths.GenericsGenerator.VariableTypes
{
    [DebuggerDisplay("{OriginalName} = ({Value}) ")]
    public sealed class LocalVariable : IVariable, IEquatable<LocalVariable>
    {
        public string OriginalName { get; }
        public IValue Value { get; set; }
        public List<IVariableReference> References { get; set; }
        public int ExtraReferences { get; set; }

        public void BuildStatement(IScopeBuilder builder)
        {
            if (References.Count <= 1 && ExtraReferences <= 0)
                return;

            builder.Statements.Add
            (
                LocalDeclarationStatement
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
                        SingletonSeparatedList
                        (
                            VariableDeclarator
                                    (OriginalName)
                                .WithInitializer
                                (
                                    EqualsValueClause
                                        (Helpers.Cast(builder.NumericType, Value.Type, builder.Resolve(Value)))
                                )
                        )
                    )
                )
            );
        }

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

        public void DebugWrite(TextWriter writer, int indentation = 0)
        {
            Helpers.Indent(writer, indentation);
            writer.WriteLine($"BEGIN LOCAL VAR {OriginalName} REFC: {References.Count} + {ExtraReferences}");
            Value.DebugWrite(writer, indentation + 1);
        }
    }
}
