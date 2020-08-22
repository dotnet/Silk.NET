// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch
{

        public class MarshalContext
        {
            /// <summary>
            /// The Compilation this method originated from
            /// </summary>
            public Compilation Compilation { get; }

            /// <summary>
            /// Indicates the method slot
            /// </summary>
            public int Slot { get; }

            /// <summary>
            /// All Load types in order, last is the return type
            /// </summary>
            public ITypeSymbol[] LoadTypes { get; }
            
            /// <summary>
            /// The type loaded as return type from native
            /// </summary>
            public ref ITypeSymbol ReturnLoadType => ref LoadTypes[LoadTypes.Length - 1];

            /// <summary>
            /// Indicates whether the parameter at each index should be pinned before sent to native
            /// </summary>
            public bool[] ShouldPinParameter { get; }

            /// <summary>
            /// The expressions passed to the loaded invoke
            /// </summary>
            public ExpressionSyntax[] ParameterExpressions { get; }

            /// <summary>
            /// The source method symbol
            /// </summary>
            public IMethodSymbol MethodSymbol { get; }

            /// <summary>
            /// Indicates whether the source method returns void (and therefore whether there is a Result Expression)
            /// </summary>
            public bool ReturnsVoid => MethodSymbol.ReturnsVoid;

            /// <summary>
            /// The Expression used to access the result
            /// </summary>
            public ExpressionSyntax? ResultExpression { get; set; }

            /// <summary>
            /// The current type of the <see cref="ResultExpression"/>
            /// </summary>
            public ITypeSymbol? CurrentResultType { get; set; }

            /// <summary>
            /// Parameter Marshal pptions
            /// </summary>
            public MarshalOptions?[] ParameterMarshalOptions { get; }
            
            /// <summary>
            /// Return Marshal options
            /// </summary>
            public MarshalOptions? ReturnMarshalOptions { get; }

            private readonly List<StatementSyntax> _prelude = new List<StatementSyntax>();
            private List<StatementSyntax> _statements = new List<StatementSyntax>();

            public class MarshalOptions
            {
                public MarshalOptions(UnmanagedType marshalAs)
                {
                    MarshalAs = marshalAs;
                }
                public UnmanagedType MarshalAs { get; }
            }

            public void AddPrelude(StatementSyntax statement) => _prelude.Add(statement);

            public void AddStatement(StatementSyntax statement) => _statements.Add(statement);

            public void AddBlock(Func<IEnumerable<StatementSyntax>, StatementSyntax> func)
            {
                var s = func(_statements);
                _statements.Clear();
                _statements.Add(s);
            }
            
            public void DeclareVariable(ITypeSymbol type, string name)
            {
                AddPrelude
                (
                    LocalDeclarationStatement
                    (
                        VariableDeclaration
                            (IdentifierName(type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)), SingletonSeparatedList(VariableDeclarator(name)))
                    )
                );
            }

            public void SetParameterToVariableAndAssign(int index, string variableName, ExpressionSyntax assign)
            {
                var identifer = IdentifierName(variableName);
               AddStatement(ExpressionStatement(AssignmentExpression(SyntaxKind.SimpleAssignmentExpression, identifer, assign)));
                ParameterExpressions[index] = identifer;
            }

            public bool TryGetAttribute(int index, string typeFullName, out AttributeData? attributeData)
            {
                ImmutableArray<AttributeData> attributes;
                if (index > MethodSymbol.Parameters.Length - 1)
                    attributes = MethodSymbol.GetReturnTypeAttributes();
                else
                    attributes = MethodSymbol.Parameters[index]
                        .GetAttributes();

                attributeData = attributes.FirstOrDefault
                (
                    x => SymbolEqualityComparer.Default.Equals
                        (x.AttributeClass, Compilation.GetTypeByMetadataName(typeFullName))
                );

                return !(attributeData is null);
            }

            public bool TryGetAttribute
                (int index, Type type, out AttributeData? attributeData)
                => TryGetAttribute(index, type.FullName, out attributeData);

            public bool TryGetAttribute<T>
                (int index, out AttributeData? attributeData) where T : Attribute
                => TryGetAttribute(index, typeof(T), out attributeData);

            public BlockSyntax BuildLastBlock() => Block(_prelude.Concat(_statements));

            public MarshalContext(Compilation compilation, IMethodSymbol methodSymbol, int slot)
            {
                Compilation = compilation;
                MethodSymbol = methodSymbol;
                Slot = slot;
                ParameterExpressions = new ExpressionSyntax[MethodSymbol.Parameters.Length];

                LoadTypes = MethodSymbol.Parameters.Select
                        (x => x.Type)
                    .Append
                    (
                        MethodSymbol.ReturnsVoid
                            ? Compilation.GetSpecialType(SpecialType.System_Void)
                            : MethodSymbol.ReturnType
                    )
                    .ToArray();
                ShouldPinParameter = MethodSymbol.Parameters.Select(x => x.RefKind != RefKind.None).ToArray();

                ParameterMarshalOptions = methodSymbol.Parameters.Select
                (
                    x => x.GetAttributes().FirstOrDefault(x => SymbolEqualityComparer.Default.Equals(x.AttributeClass, Compilation.GetTypeByMetadataName("System.Runtime.InteropServices.MarshalAsAttribute")))
                ).Select(x => x is null ? null : new MarshalOptions((UnmanagedType)x.ConstructorArguments[0].Value)).ToArray();

                var v = methodSymbol.ReturnType.GetAttributes()
                    .FirstOrDefault
                    (
                        x => SymbolEqualityComparer.Default.Equals
                        (
                            x.AttributeClass,
                            Compilation.GetTypeByMetadataName("System.Runtime.InteropServices.MarshalAsAttribute")
                        )
                    );
                ReturnMarshalOptions =
                    v is null ? null : new MarshalOptions((UnmanagedType) v.ConstructorArguments[0].Value);
            }
        }
}
