// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using GenericMathsGenerator.VariableTypes;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace GenericMathsGenerator.ValueTypes
{
    [DebuggerDisplay("{Name}: {LocalVariable}")]
    public class LocalReferenceValue : IValue, IVariableReference, IEquatable<LocalReferenceValue>
    {
        public LocalReferenceValue(string name)
        {
            Name = name;
        }
        
        public IVariable? LocalVariable { get; set; }
        public string Name { get; }

        public int Step => (LocalVariable?.Value.Step + 1) ?? 0;

        public ExpressionSyntax BuildExpression
            (IBodyBuilder bodyBuilder, ImmutableArray<ExpressionSyntax> children)
        {
            if (LocalVariable is null)
                throw new InvalidOperationException($"Local variable reference has not been resolved");
            
            var name = Name;
            if (!bodyBuilder.ResolvedVariables.Contains(LocalVariable))
            {
                switch (LocalVariable)
                {
                    case AssignmentVariable assignmentVariable:
                        bodyBuilder.Statements.Add
                        (
                            ExpressionStatement
                            (
                                AssignmentExpression
                                (
                                    SyntaxKind.SimpleAssignmentExpression,
                                    IdentifierName(assignmentVariable.OriginalName),
                                    bodyBuilder.ResolveValue(LocalVariable.Value)
                                )
                            )
                        );
                        break;
                    case LocalVariable localVariable:
                        bodyBuilder.Statements.Add
                        (
                            LocalDeclarationStatement
                            (
                                VariableDeclaration
                                (
                                    Type switch
                                    {
                                        Type.Numeric => bodyBuilder.NumericType.GetTypeSyntax(),
                                        Type.Boolean => PredefinedType(Token(SyntaxKind.BoolKeyword)),
                                        _ => throw new TypeMismatchException
                                            ($"Trying to resolve {Enum.GetName(typeof(Type), Type)} Type Literal")
                                    },
                                    SingletonSeparatedList
                                    (
                                        VariableDeclarator
                                                (name)
                                            .WithInitializer
                                                (EqualsValueClause(bodyBuilder.ResolveValue(LocalVariable.Value)))
                                    )
                                )
                            )
                        );
                        break;
                    case ReturnVariable returnVariable:
                        throw new InvalidOperationException("Cannot reference a return \"variable\"");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(LocalVariable));
                }

                bodyBuilder.ResolvedVariables.Add(LocalVariable);
            }

            return IdentifierName(name);
        }

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
    }
}
