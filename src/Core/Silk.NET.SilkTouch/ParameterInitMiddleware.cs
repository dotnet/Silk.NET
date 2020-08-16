// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Linq;
using Microsoft.CodeAnalysis;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch
{
    public partial class NativeApiGenerator
    {
        private void ParameterInitMiddleware(ref MarshalContext ctx, Action next)
        {
            for (int index = 0; index < ctx.MethodSymbol.Parameters.Length; index++)
            {
                var symbol = ctx.MethodSymbol.Parameters[index];
                if (ctx.MethodSymbol.Parameters[index].RefKind == RefKind.None && !ctx.MethodSymbol.Parameters[index].Type.IsReferenceType)
                {
                    var name = $"dp{ctx.Slot}{index}";
                    ctx.DeclareVariable(symbol.Type, name);
                    ctx.SetParameterToVariableAndAssign(index, name, IdentifierName(FormatName(symbol.Name)));
                }
                else
                {
                    // the parameter is by ref of some sort, leave to other initializer
                    ctx.ParameterExpressions[index] = IdentifierName(FormatName(symbol.Name));
                }
            }

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
