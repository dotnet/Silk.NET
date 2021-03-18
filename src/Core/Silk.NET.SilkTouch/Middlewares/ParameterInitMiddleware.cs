// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Linq;
using Silk.NET.Core.Attributes;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch
{
    public static partial class Middlewares
    {
        public static void ParameterInitMiddleware(ref IMarshalContext ctx, Action next)
        {
            for (int index = 0; index < ctx.MethodSymbol.Parameters.Length; index++)
            {
                var symbol = ctx.MethodSymbol.Parameters[index];
                var id = ctx.DeclareVariable(symbol.Type);
                ctx.SetVariable(id, _ => IdentifierName(FormatName(symbol.Name)));
                ctx.SetParameterToVariable(index, id);
            }

            ctx.TransitionTo(SilkTouchStage.PostInit);
            
            next();
        }
        
        private static string FormatName(string name)
        {
            if (CSharpKeywords.Contains(name))
                return "@" + name;
            return name;
        }

        private static readonly string[] CSharpKeywords =
        {
            "abstract",
            "event",
            "new",
            "struct",
            "as",
            "explicit",
            "null",
            "switch",
            "base",
            "extern",
            "object",
            "this",
            "bool",
            "false",
            "operator",
            "throw",
            "break",
            "finally",
            "out",
            "true",
            "byte",
            "fixed",
            "override",
            "try",
            "case",
            "float",
            "params",
            "typeof",
            "catch",
            "for",
            "private",
            "uint",
            "char",
            "foreach",
            "protected",
            "ulong",
            "checked",
            "goto",
            "public",
            "unchecked",
            "class",
            "if",
            "readonly",
            "unsafe",
            "const",
            "implicit",
            "ref",
            "ushort",
            "continue",
            "in",
            "return",
            "using",
            "decimal",
            "int",
            "sbyte",
            "virtual",
            "default",
            "interface",
            "sealed",
            "volatile",
            "delegate",
            "internal",
            "short",
            "void",
            "do",
            "is",
            "sizeof",
            "while",
            "double",
            "lock",
            "stackalloc",
            "else",
            "long",
            "static",
            "enum",
            "namespace",
            "string"
        };
    }
}
