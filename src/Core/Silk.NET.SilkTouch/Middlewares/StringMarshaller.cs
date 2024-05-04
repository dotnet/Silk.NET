// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.Core.Native;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch
{
    public static partial class Middlewares
    {
        private static ExpressionSyntax _marshal = // Silk.NET.Core.Native.SilkMarshal
            MemberAccessExpression
            (
                SyntaxKind.SimpleMemberAccessExpression,
                MemberAccessExpression
                (
                    SyntaxKind.SimpleMemberAccessExpression,
                    MemberAccessExpression
                    (
                        SyntaxKind.SimpleMemberAccessExpression,
                        MemberAccessExpression
                        (
                            SyntaxKind.SimpleMemberAccessExpression, IdentifierName("Silk"),
                            IdentifierName("NET")
                        ), IdentifierName("Core")
                    ), IdentifierName("Native")
                ), IdentifierName("SilkMarshal")
            );

        private static TypeSyntax _nativeStringEncoding = // Silk.NET.Core.Native.NativeStringEncoding
            QualifiedName
            (
                QualifiedName
                (
                    QualifiedName(QualifiedName(IdentifierName("Silk"), IdentifierName("NET")), IdentifierName("Core")),
                    IdentifierName("Native")
                ), IdentifierName("NativeStringEncoding")
            );

        private const UnmanagedType Default = UnmanagedType.LPStr;

        public static void StringMarshaller(ref IMarshalContext ctx, Action next)
        {
            var @string = ctx.Compilation.GetSpecialType(SpecialType.System_String);
            var intptr = ctx.Compilation.GetSpecialType(SpecialType.System_IntPtr);

            var oldVariables = ctx.ParameterVariables.ToArray();
            bool[] b = new bool[ctx.ParameterVariables.Length];
            int[] bufferVars = new int[ctx.ParameterVariables.Length];
            Dictionary<int, ExpressionSyntax> readback = new Dictionary<int, ExpressionSyntax>();
            
            for (var index = 0; index < ctx.ParameterVariables.Length; index++)
            {
                b[index] = !SymbolEqualityComparer.Default.Equals(ctx.LoadTypes[index], @string);
                if (b[index]) continue;
                
                var marshalAs = ctx.ParameterMarshalOptions[index]?.UnmanagedType ?? Default;
                var charType = ctx.Compilation.CreatePointerTypeSymbol(marshalAs switch
                {
                    UnmanagedType.BStr => ctx.Compilation.GetSpecialType(SpecialType.System_Char),
                    UnmanagedType.LPWStr => ctx.Compilation.GetSpecialType(SpecialType.System_Char),
                    UnmanagedType.LPStr => ctx.Compilation.GetSpecialType(SpecialType.System_Byte),
                    UnmanagedType.LPTStr => ctx.Compilation.GetSpecialType(SpecialType.System_Byte),
                    UnmanagedType.LPUTF8Str => ctx.Compilation.GetSpecialType(SpecialType.System_Byte),
                    UnmanagedType.WinString => ctx.Compilation
                        .GetTypeByMetadataName("Silk.NET.Core.Native.WinString.Header")
                });
                
                var id = ctx.DeclareVariable(charType);
                bufferVars[index] = id;
                var parameter = ctx.ResolveVariable(ctx.ParameterVariables[index]);
                switch (ctx.MethodSymbol.Parameters[index].RefKind)
                {
                    // TODO case RefKind.None when marshalAs == UnmanagedType.WinString (use fixed blocks + DangerousCreate)
                    case RefKind.None:
                    case RefKind.In:
                    case RefKind.Ref:
                        ctx.SetVariable
                        (
                            id,
                            ctx => CastExpression
                            (
                                IdentifierName(charType.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)),
                                InvocationExpression
                                (
                                    MemberAccessExpression
                                    (
                                        SyntaxKind.SimpleMemberAccessExpression, _marshal, IdentifierName("StringToPtr")
                                    ),
                                    ArgumentList
                                    (
                                        SeparatedList
                                        (
                                            new[]
                                            {
                                                Argument(parameter.Value),
                                                Argument
                                                (
                                                    CastExpression
                                                    (
                                                        _nativeStringEncoding,
                                                        LiteralExpression
                                                        (
                                                            SyntaxKind.NumericLiteralExpression,
                                                            Literal((int) marshalAs)
                                                        )
                                                    )
                                                )
                                            }
                                        )
                                    )
                                )
                            )
                        );
                        if (ctx.MethodSymbol.Parameters[index].RefKind is RefKind.Ref)
                        {
                            ctx.DeclareExtraRef(id); // readback
                            ctx.DeclareExtraRef(ctx.ParameterVariables[index]); // ptrToString
                        }
                        ctx.DeclareExtraRef(id); // free
                        ctx.SetParameterToVariable(index, id);
                        break;
                    case RefKind.Out:
                    {
                        b[index] = false;
                            
                        if (!ctx.TryGetAttribute(index, "Silk.NET.Core.Attributes.CountAttribute", out var countData))
                        {
                            continue; // diagnostic?
                        }
                        
                        var c = countData.NamedArguments[0];

                        ExpressionSyntax count = c.Key switch
                        {
                            "Count" => LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal((int)c.Value.Value)),
                            "Parameter" => IdentifierName((string)c.Value.Value),
                            "Computed" => throw new Exception(),
                            _ => throw new ArgumentOutOfRangeException(c.Key)
                        };

                        ctx.SetVariable
                        (
                            id, ctx => CastExpression
                            (
                                IdentifierName(charType.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)),
                                InvocationExpression
                                (
                                    MemberAccessExpression
                                    (
                                        SyntaxKind.SimpleMemberAccessExpression, _marshal,
                                        IdentifierName("AllocateString")
                                    ), ArgumentList
                                    (
                                        SeparatedList
                                        (
                                            new[]
                                            {
                                                Argument
                                                (
                                                    CastExpression(PredefinedType(Token(SyntaxKind.IntKeyword)), count)
                                                ),
                                                Argument
                                                (
                                                    CastExpression
                                                    (
                                                        _nativeStringEncoding,
                                                        LiteralExpression
                                                        (
                                                            SyntaxKind.NumericLiteralExpression,
                                                            Literal((int) marshalAs)
                                                        )
                                                    )
                                                )
                                            }
                                        )
                                    )
                                )
                            )
                        );
                        ctx.SetParameterToVariable(index, id);
                        ctx.DeclareExtraRef(ctx.ParameterVariables[index]); // ptrToString
                        ctx.DeclareExtraRef(id); // free
                        
                        ctx.ShouldPinParameter[index] = false;
                        break;
                    }
                }
            }

            var marshalReturn = !ctx.ReturnsVoid && SymbolEqualityComparer.Default.Equals(ctx.ReturnLoadType, @string);
            int returnLocal = default;
            var returnMarshalAs = ctx.ReturnMarshalOptions?.UnmanagedType ?? Default;
            if (marshalReturn)
            {
                returnLocal = ctx.DeclareVariable(@string);
                ctx.ReturnLoadType = ctx.Compilation.CreatePointerTypeSymbol
                (
                    returnMarshalAs switch
                    {
                        UnmanagedType.BStr => ctx.Compilation.GetSpecialType(SpecialType.System_Char),
                        UnmanagedType.LPWStr => ctx.Compilation.GetSpecialType(SpecialType.System_Char),
                        UnmanagedType.LPStr => ctx.Compilation.GetSpecialType(SpecialType.System_Byte),
                        UnmanagedType.LPTStr => ctx.Compilation.GetSpecialType(SpecialType.System_Byte),
                        UnmanagedType.LPUTF8Str => ctx.Compilation.GetSpecialType(SpecialType.System_Byte),
                    }
                );
            }
            
            next();

            if (marshalReturn)
            {
                var resultVariable = ctx.ResolveVariable(ctx.ResultVariable.Value);
                ctx.SetVariable
                (
                    returnLocal, ctx => InvocationExpression
                    (
                        MemberAccessExpression
                            (SyntaxKind.SimpleMemberAccessExpression, _marshal, IdentifierName("PtrToString")),
                        ArgumentList
                        (
                            SeparatedList
                            (
                                new[]
                                {
                                    Argument
                                    (
                                        CastExpression
                                        (
                                            IdentifierName
                                            (
                                                ctx.Compilation.GetSpecialType
                                                        (SpecialType.System_IntPtr)
                                                    .ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)
                                            ), resultVariable.Value
                                        )
                                    ),
                                    Argument
                                    (
                                        CastExpression
                                        (
                                            _nativeStringEncoding,
                                            LiteralExpression
                                                (SyntaxKind.NumericLiteralExpression, Literal((int) returnMarshalAs))
                                        )
                                    )
                                }
                            )
                        )
                    )
                );
                ctx.ResultVariable = returnLocal;
            }

            for (var index = 0; index < ctx.ParameterVariables.Length; index++)
            {
                if (b[index]) continue;
                
                var marshalAs = ctx.ParameterMarshalOptions[index]?.UnmanagedType ?? Default;

                if (ctx.MethodSymbol.Parameters[index].RefKind == RefKind.Ref ||
                    ctx.MethodSymbol.Parameters[index].RefKind == RefKind.Out)
                {
                    var p2 = ctx.ResolveVariable(ctx.ParameterVariables[index]);

                    var n = ctx.MethodSymbol.Parameters[index].Name;
                    ctx.AddSideEffect
                    (
                        ctx => ExpressionStatement
                        (
                            AssignmentExpression
                            (
                                SyntaxKind.SimpleAssignmentExpression, IdentifierName(FormatName(n)),
                                InvocationExpression
                                (
                                    MemberAccessExpression
                                    (
                                        SyntaxKind.SimpleMemberAccessExpression, _marshal,
                                        IdentifierName("PtrToString")
                                    ), ArgumentList
                                    (
                                        SeparatedList
                                        (
                                            new[]
                                            {
                                                Argument
                                                (
                                                    CastExpression
                                                    (
                                                        IdentifierName
                                                        (
                                                            intptr.ToDisplayString
                                                                (SymbolDisplayFormat.FullyQualifiedFormat)
                                                        ), p2.Value
                                                    )
                                                ),
                                                Argument
                                                (
                                                    CastExpression
                                                    (
                                                        _nativeStringEncoding,
                                                        LiteralExpression
                                                        (
                                                            SyntaxKind.NumericLiteralExpression,
                                                            Literal((int) marshalAs)
                                                        )
                                                    )
                                                )
                                            }
                                        )
                                    )
                                )
                            )
                        )
                    );
                    ctx.SetParameterToVariable(index, oldVariables[index]);
                }
                
                var p1 = ctx.ResolveVariable(bufferVars[index]);

                ctx.AddSideEffect
                (
                    ctx => ExpressionStatement
                    (
                        InvocationExpression
                        (
                            MemberAccessExpression
                                (SyntaxKind.SimpleMemberAccessExpression, _marshal, IdentifierName("FreeString")),
                            ArgumentList
                            (
                                SeparatedList
                                (
                                    new[]
                                    {
                                        Argument
                                        (
                                            CastExpression
                                            (
                                                IdentifierName
                                                    (intptr.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)),
                                                p1.Value
                                            )
                                        ),
                                        Argument
                                        (
                                            CastExpression
                                            (
                                                _nativeStringEncoding,
                                                LiteralExpression
                                                (
                                                    SyntaxKind.NumericLiteralExpression, Literal((int) marshalAs)
                                                )
                                            )
                                        )
                                    }
                                )
                            )
                        )
                    )
                );
            }
        }
    }
}
