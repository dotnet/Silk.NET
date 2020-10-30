// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.Maths.GenericsGenerator
{
    public static class Helpers
    {
        public static SyntaxTokenList TryRemove
            (this SyntaxTokenList list, Func<SyntaxToken, bool> predicate)
        {
            var tokens = list.Where(predicate);

            foreach (var token in tokens)
            {
                var cIndex = list.IndexOf(token);

                if (cIndex > 0 && cIndex < list.Count)
                {
                    list = list.RemoveAt(cIndex);
                }
            }

            return list;
        }
        
        public static void Indent(TextWriter textWriter, int count)
        {
            textWriter.Write(new string(' ', count * 2));
        }

        public static ExpressionSyntax Cast(NumericTargetType t1, Type t2, ExpressionSyntax source)
            => t2 switch
            {
                Type.Numeric => ParenthesizedExpression
                    (CastExpression(t1.GetTypeSyntax(), ParenthesizedExpression(source))),
                Type.Boolean => ParenthesizedExpression
                    (CastExpression(PredefinedType(Token(SyntaxKind.BoolKeyword)), ParenthesizedExpression(source))),
                _ => throw new ArgumentOutOfRangeException(nameof(t1), $"Unknown Type {Enum.GetName(typeof(Type), t1)}")
            };
        
        public const string DebugFolder = @"C:\Silk.NET\src\Lab\GenericMaths\";
    }

    public class NumericType { }
}
