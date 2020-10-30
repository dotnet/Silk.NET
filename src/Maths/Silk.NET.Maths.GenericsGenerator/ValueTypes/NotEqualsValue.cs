// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.IO;
using Microsoft.CodeAnalysis.CSharp;

namespace Silk.NET.Maths.GenericsGenerator.ValueTypes
{
    public sealed class NotEqualsValue : BinaryOperatorValue
    {
        public override Type Type => Type.Boolean;
    
        protected override object Process(object left, object right)
        {
            if (Left.Type != Right.Type)
                throw new ArgumentException("Cannot compare types of unequal Type");
            
            return left != right;
        }

        protected override string OpStr => "!=";
        protected override SyntaxKind OpSyntaxKind => SyntaxKind.NotEqualsExpression;
        public override void DebugWrite(TextWriter writer, int indentation = 0)
        {
            Helpers.Indent(writer, indentation);
            writer.WriteLine("BEGIN NOT EQUALS");

            indentation++;
            Left.DebugWrite(writer, indentation);
            Right.DebugWrite(writer, indentation);
        }
    }
}
