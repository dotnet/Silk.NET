// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch
{
    public partial class NativeApiGenerator
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

        private static void StringMarshaller(ref MarshalContext ctx, Action next)
        {
            var @string = ctx.Compilation.GetSpecialType(SpecialType.System_String);
            var intptr = ctx.Compilation.GetSpecialType(SpecialType.System_IntPtr);
            var oldParamExpressions = ctx.ParameterExpressions.ToArray();
            bool[] b = new bool[ctx.ParameterExpressions.Length];
            Dictionary<int, ExpressionSyntax> readback = new Dictionary<int, ExpressionSyntax>();
            
            for (var index = 0; index < ctx.ParameterExpressions.Length; index++)
            {
                b[index] = !SymbolEqualityComparer.Default.Equals(ctx.LoadTypes[index], @string);
                if (b[index]) continue;
                
                var marshalAs = ctx.ParameterMarshalOptions[index]?.MarshalAs ?? UnmanagedType.LPStr;

                var name = $"smptr{ctx.Slot}{index}";

                var charType = ctx.Compilation.CreatePointerTypeSymbol(marshalAs switch
                {
                    UnmanagedType.BStr => ctx.Compilation.GetSpecialType(SpecialType.System_Char),
                    UnmanagedType.LPWStr => ctx.Compilation.GetSpecialType(SpecialType.System_Char),
                    UnmanagedType.LPStr => ctx.Compilation.GetSpecialType(SpecialType.System_Byte),
                    UnmanagedType.LPTStr => ctx.Compilation.GetSpecialType(SpecialType.System_Byte),
                });
                
                ctx.DeclareVariable(charType, name);
                switch (ctx.MethodSymbol.Parameters[index].RefKind)
                {
                    case RefKind.None:
                    case RefKind.In:
                    case RefKind.Ref:
                        ctx.SetParameterToVariableAndAssign
                        (
                            index, name,
                            CastExpression
                            (
                                IdentifierName(charType.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)),
                                InvocationExpression
                                (
                                    _stringToPtr[marshalAs],
                                    ArgumentList(SingletonSeparatedList(Argument(ctx.ParameterExpressions[index])))
                                )
                            )
                        );
                        ctx.LoadTypes[index] = charType;
                        break;
                    case RefKind.Out:
                        ExpressionSyntax count;

                        if (!ctx.TryGetAttribute(index, "Silk.NET.Core.Attributes.CountAttribute", out var countData))
                        {
                            continue; // diagnostic?
                        }

                        var c = countData.NamedArguments[0];

                        count = c.Key switch
                        {
                            "Count" => LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal((int)c.Value.Value)),
                            "Parameter" => IdentifierName((string)c.Value.Value),
                            "Computed" => throw new Exception(),
                            _ => throw new ArgumentOutOfRangeException(c.Key)
                        };

                        ctx.SetParameterToVariableAndAssign
                        (
                            index, name,
                            CastExpression
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
                        
                        // second address of
                        var name2 = $"smo{ctx.Slot}{index}";
                        var pp = ctx.Compilation.CreatePointerTypeSymbol(charType);
                        ctx.DeclareVariable(pp, name2);
                        ctx.SetParameterToVariableAndAssign(index, name2, PrefixUnaryExpression(SyntaxKind.AddressOfExpression, ctx.ParameterExpressions[index]));
                        ctx.LoadTypes[index] = pp;
                        ctx.ShouldPinParameter[index] = false;
                        break;
                }
            }

            next();
            
            for (var index = 0; index < ctx.ParameterExpressions.Length; index++)
            {
                if (b[index]) continue;
                
                var marshalAs = ctx.ParameterMarshalOptions[index]?.MarshalAs ?? UnmanagedType.LPStr;

                var name = $"smptr{ctx.Slot}{index}";
                if (ctx.MethodSymbol.Parameters[index].RefKind == RefKind.None ||
                    ctx.MethodSymbol.Parameters[index].RefKind == RefKind.Ref ||
                    ctx.MethodSymbol.Parameters[index].RefKind == RefKind.Out)
                {
                    ctx.CurrentStatements = ctx.CurrentStatements.Append
                    (
                        ExpressionStatement
                        (
                            AssignmentExpression
                            (
                                SyntaxKind.SimpleAssignmentExpression, oldParamExpressions[index],
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
                                                    (IdentifierName(intptr.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)), IdentifierName(name))
                                            )
                                        )
                                    )
                                )
                            )
                        )
                    );
                }

                ctx.CurrentStatements = ctx.CurrentStatements.Append
                (
                    ExpressionStatement
                    (
                        InvocationExpression
                        (
                            _freeString[marshalAs],
                            ArgumentList
                            (
                                SingletonSeparatedList
                                (
                                    Argument
                                        (CastExpression(IdentifierName(intptr.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)), IdentifierName(name)))
                                )
                            )
                        )
                    )
                );
            }
        }
    }
}
