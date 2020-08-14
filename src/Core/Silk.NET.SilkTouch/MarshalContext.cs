// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Silk.NET.SilkTouch
{

        public class MarshalContext
        {
            private readonly Compilation _compilation;

            /// <summary>
            /// Indicates the method slot
            /// </summary>
            public int Slot { get; }

            /// <summary>
            /// All Load types in order, last is the return type
            /// </summary>
            public string[] LoadTypes { get; }
            
            /// <summary>
            /// The type loaded as return type from native
            /// </summary>
            public ref string ReturnLoadType => ref LoadTypes[LoadTypes.Length - 1];

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
            /// Based on whether this is before or after invoking of `next` this refers to the pre/post Load invoke
            /// </summary>
            public IEnumerable<StatementSyntax> CurrentStatements { get; set; }

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
            public string? CurrentResultType { get; set; }

            public MarshalOptions?[] ParameterMarshalOptions { get; }
            public MarshalOptions? ReturnMarshalOptions { get; }

            public class MarshalOptions
            {
                public MarshalOptions(UnmanagedType marshalAs)
                {
                    MarshalAs = marshalAs;
                }
                public UnmanagedType MarshalAs { get; }
            }

            public MarshalContext(Compilation compilation, IMethodSymbol methodSymbol, int slot)
            {
                _compilation = compilation;
                MethodSymbol = methodSymbol;
                Slot = slot;
                ParameterExpressions = MethodSymbol.Parameters.Select(x => SyntaxFactory.IdentifierName(x.Name)).Cast<ExpressionSyntax>().ToArray();
                LoadTypes = MethodSymbol.Parameters.Select
                        (x => x.Type.ToDisplayString())
                    .Append(MethodSymbol.ReturnsVoid ? "void" : MethodSymbol.ReturnType.ToDisplayString())
                    .ToArray();
                ShouldPinParameter = MethodSymbol.Parameters.Select(x => x.RefKind != RefKind.None).ToArray();
                CurrentStatements = Enumerable.Empty<StatementSyntax>();

                ParameterMarshalOptions = methodSymbol.Parameters.Select
                (
                    x => x.GetAttributes().FirstOrDefault(x => SymbolEqualityComparer.Default.Equals(x.AttributeClass, _compilation.GetTypeByMetadataName("System.Runtime.InteropServices.MarshalAsAttribute")))
                ).Select(x => x is null ? null : new MarshalOptions((UnmanagedType)x.ConstructorArguments[0].Value)).ToArray();

                var v = methodSymbol.ReturnType.GetAttributes()
                    .FirstOrDefault
                    (
                        x => SymbolEqualityComparer.Default.Equals
                        (
                            x.AttributeClass,
                            _compilation.GetTypeByMetadataName("System.Runtime.InteropServices.MarshalAsAttribute")
                        )
                    );
                ReturnMarshalOptions =
                    v is null ? null : new MarshalOptions((UnmanagedType) v.ConstructorArguments[0].Value);
            }
        }
}
