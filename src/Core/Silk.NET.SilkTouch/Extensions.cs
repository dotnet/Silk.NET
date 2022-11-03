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
    internal static class Extensions
    {
        public static bool IsNet5OrGreater(this SyntaxTree syntaxTree)
            => syntaxTree
                .Options
                .PreprocessorSymbolNames // newer SDKs (circa .NET 6) have _OR_GREATER
                .Any(static x => x is "NET5_0" or "NET6_0" or "NET5_0_OR_GREATER");

        public static string GetCallingConvention(this CallingConvention convention)
            => convention switch
            {
                CallingConvention.Winapi => string.Empty,
                CallingConvention.Cdecl => "Cdecl",
                CallingConvention.ThisCall => "Thiscall",
                CallingConvention.StdCall => "Stdcall",
                CallingConvention.FastCall => "Fastcall",
                _ => throw new ArgumentException("convention is invalid", nameof(convention))
            };

        public static FunctionPointerTypeSyntax GetFuncPtrType
        (
            this IEnumerable<ITypeSymbol> loadTypes,
            CallingConvention? unmanagedCallingConvention
        ) => loadTypes.Select
            (
                static x => FunctionPointerParameter
                    (IdentifierName(x.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)))
            )
            .GetFuncPtrType(unmanagedCallingConvention);

        public static FunctionPointerTypeSyntax GetFuncPtrType
        (
            this IEnumerable<TypeSyntax> loadTypes,
            CallingConvention? unmanagedCallingConvention
        ) => loadTypes
            .Select(FunctionPointerParameter)
            .GetFuncPtrType(unmanagedCallingConvention);

        public static FunctionPointerTypeSyntax GetFuncPtrType
        (
            this IEnumerable<FunctionPointerParameterSyntax> parameters,
            CallingConvention? unmanagedCallingConvention
        ) => FunctionPointerType
        (
            unmanagedCallingConvention switch
            {
                CallingConvention.Winapi => FunctionPointerCallingConvention(Token(SyntaxKind.UnmanagedKeyword)),
                { } => FunctionPointerCallingConvention
                (
                    Token(SyntaxKind.UnmanagedKeyword),
                    FunctionPointerUnmanagedCallingConventionList
                    (
                        SingletonSeparatedList
                        (
                            FunctionPointerUnmanagedCallingConvention
                                (Identifier(GetCallingConvention(unmanagedCallingConvention.Value)))
                        )
                    )
                ),
                _ => FunctionPointerCallingConvention(Token(SyntaxKind.ManagedKeyword))
            },
            FunctionPointerParameterList(SeparatedList(parameters))
        );
    }
}
