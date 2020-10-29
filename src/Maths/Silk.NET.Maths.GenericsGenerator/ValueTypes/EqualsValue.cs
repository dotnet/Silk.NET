// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Microsoft.CodeAnalysis.CSharp;

namespace Silk.NET.Maths.GenericsGenerator.ValueTypes
{
    public class EqualsValue : BinaryOperatorValue
    {
        public override Type Type => Type.Boolean;
    
        protected override object Process(object left, object right)
        {
            if (Left.Type != Right.Type)
                throw new ArgumentException("Cannot compare types of unequal Type");
            
            return left == right;
        }

        protected override string OpStr => "==";
        protected override SyntaxKind OpSyntaxKind => SyntaxKind.EqualsExpression;
    }
}
