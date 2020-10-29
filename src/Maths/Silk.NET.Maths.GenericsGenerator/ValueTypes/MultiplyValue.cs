// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Microsoft.CodeAnalysis.CSharp;

namespace Silk.NET.Maths.GenericsGenerator.ValueTypes
{
    public class MultiplyValue : BinaryOperatorValue
    {
        public override Type Type => Type.Numeric;
        
        protected override object Process(object left, object right)
        {
            if (Left.Type == Type.Numeric && Right.Type == Type.Numeric)
                return (float)left * (float)right;
            
            throw new ArgumentException("Cannot multiply non-numeric");
        }

        protected override string OpStr => "*";
        protected override SyntaxKind OpSyntaxKind => SyntaxKind.MultiplyExpression;
    }
}
