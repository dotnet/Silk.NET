// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.IO;
using Microsoft.CodeAnalysis.CSharp;

namespace Silk.NET.Maths.GenericsGenerator.ValueTypes
{
    public sealed class SubtractValue : BinaryOperatorValue
    {
        public override Type Type => Type.Numeric;
        
        protected override object Process(object left, object right)
        {
            if (Left.Type == Type.Numeric && Right.Type == Type.Numeric)
                return (float)left - (float)right;
            
            throw new ArgumentException("Cannot subtract non-numeric");
        }

        protected override string OpStr => "-";
        protected override SyntaxKind OpSyntaxKind => SyntaxKind.SubtractExpression;
        public override void DebugWrite(TextWriter writer, int indentation = 0)
        {
            Helpers.Indent(writer, indentation);
            writer.WriteLine("BEGIN SUB");

            indentation++;
            Left.DebugWrite(writer, indentation);
            Right.DebugWrite(writer, indentation);
        }
    }
}
