// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
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
        private static ExpressionSyntax _sysMarshal = // System.Runtime.InteropServices.Marshal
            MemberAccessExpression
            (
                SyntaxKind.SimpleMemberAccessExpression,
                MemberAccessExpression
                (
                    SyntaxKind.SimpleMemberAccessExpression,
                    MemberAccessExpression
                        (SyntaxKind.SimpleMemberAccessExpression, IdentifierName("System"), IdentifierName("Runtime")),
                    IdentifierName("InteropServices")
                ), IdentifierName("Marshal")
            );
        private static ExpressionSyntax _freeHGlobal = MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, _sysMarshal, IdentifierName("FreeHGlobal"));
        private static ExpressionSyntax _allocHGlobal = MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, _sysMarshal, IdentifierName("AllocHGlobal"));
        private static Dictionary<UnmanagedType, ExpressionSyntax> _stringToPtr =
            new Dictionary<UnmanagedType, ExpressionSyntax>
            {
                [UnmanagedType.BStr] = MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, _sysMarshal, IdentifierName("StringToBSTR")),
                [UnmanagedType.LPWStr] = MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, _sysMarshal, IdentifierName("StringToHGlobalUni")),
                [UnmanagedType.LPStr] = MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, _sysMarshal, IdentifierName("StringToHGlobalAnsi")),
                [UnmanagedType.LPTStr] = MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, _sysMarshal, IdentifierName("StringToHGlobalAuto")),
            };
        private static Dictionary<UnmanagedType, ExpressionSyntax> _stringFromPtr =
            new Dictionary<UnmanagedType, ExpressionSyntax>
            {
                [UnmanagedType.BStr] = MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, _sysMarshal, IdentifierName("PtrToStringBSTR")),
                [UnmanagedType.LPWStr] = MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, _sysMarshal, IdentifierName("PtrToStringUni")),
                [UnmanagedType.LPStr] = MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, _sysMarshal, IdentifierName("PtrToStringAnsi")),
                [UnmanagedType.LPTStr] = MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, _sysMarshal, IdentifierName("PtrToStringAuto")),
            };
        private static Dictionary<UnmanagedType, ExpressionSyntax> _freeString =
            new Dictionary<UnmanagedType, ExpressionSyntax>
            {
                [UnmanagedType.BStr] = MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, _sysMarshal, IdentifierName("FreeBSTR")),
                [UnmanagedType.LPWStr] = _freeHGlobal,
                [UnmanagedType.LPStr] = _freeHGlobal,
                [UnmanagedType.LPTStr] = _freeHGlobal,
            };

        private static Dictionary<UnmanagedType, ExpressionSyntax> _allocString =
            new Dictionary<UnmanagedType, ExpressionSyntax>
            {
                [UnmanagedType.BStr] =
                    // Silk.NET.Core.Native.SilkMarshal.AllocBStr
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
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    MemberAccessExpression
                                    (
                                        SyntaxKind.SimpleMemberAccessExpression, IdentifierName("Silk"),
                                        IdentifierName("NET")
                                    ), IdentifierName("Core")
                                ), IdentifierName("Native")
                            ), IdentifierName("SilkMarshal")
                        ), IdentifierName("AllocBStr")
                    ),
                [UnmanagedType.LPWStr] = _allocHGlobal,
                [UnmanagedType.LPStr] = _allocHGlobal,
                [UnmanagedType.LPTStr] = _allocHGlobal,
            };

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
                });
                
                var id = ctx.DeclareVariable(charType);
                bufferVars[index] = id;
                var parameter = ctx.ResolveVariable(ctx.ParameterVariables[index]);
                switch (ctx.MethodSymbol.Parameters[index].RefKind)
                {
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
                                    _stringToPtr[marshalAs],
                                    ArgumentList
                                        (SingletonSeparatedList(Argument(parameter.Value)))
                                )
                            )
                        );
                        ctx.DeclareExtraRef(id); // readback
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
                            id,
                            ctx => CastExpression
                            (
                                IdentifierName(charType.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)),
                                InvocationExpression
                                (
                                    _allocString[marshalAs],
                                    ArgumentList
                                    (
                                        SingletonSeparatedList
                                        (
                                            Argument
                                                (CastExpression(PredefinedType(Token(SyntaxKind.IntKeyword)), count))
                                        )
                                    )
                                )
                            )
                        );
                        
                        ctx.SetParameterToVariable(index, id);
                        ctx.ShouldPinParameter[index] = false;
                        break;
                    }
                }
                ctx.DeclareExtraRef(ctx.ParameterVariables[index]); // ptrToString
                ctx.DeclareExtraRef(id); // free
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
                    }
                );
            }
            
            next();

            if (marshalReturn)
            {
                var resultVariable = ctx.ResolveVariable(ctx.ResultVariable.Value);
                ctx.SetVariable
                (
                    returnLocal,
                    ctx => InvocationExpression
                    (
                        _stringFromPtr[returnMarshalAs],
                        ArgumentList
                        (
                            SingletonSeparatedList
                            (
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
                                )
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

                if (ctx.MethodSymbol.Parameters[index].RefKind == RefKind.None ||
                    ctx.MethodSymbol.Parameters[index].RefKind == RefKind.Ref ||
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
                                SyntaxKind.SimpleAssignmentExpression,
                                IdentifierName(FormatName(n)),
                                InvocationExpression
                                (
                                    _stringFromPtr[marshalAs],
                                    ArgumentList
                                    (
                                        SingletonSeparatedList
                                        (
                                            Argument
                                            (
                                                CastExpression
                                                (
                                                    IdentifierName
                                                    (
                                                        intptr.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)
                                                    ), p2.Value
                                                )
                                            )
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
                            _freeString[marshalAs],
                            ArgumentList
                            (
                                SingletonSeparatedList
                                (
                                    Argument
                                        (CastExpression(IdentifierName(intptr.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)), p1.Value))
                                )
                            )
                        )
                    )
                );
            }
        }
    }
}
