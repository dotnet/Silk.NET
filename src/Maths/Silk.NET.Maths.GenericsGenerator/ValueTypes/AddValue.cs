// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Microsoft.CodeAnalysis.CSharp;

namespace GenericMathsGenerator
{
    public class AddValue : BinaryOperatorValue
    {
        protected override object Process(object left, object right)
        {
            if (Type == Type.Numeric)
                return (float)left + (float)right;
            
            throw new ArgumentException("Cannot add non-numeric");
        }

        protected override string OpStr => "+";
        protected override SyntaxKind OpSyntaxKind => SyntaxKind.AddExpression;
    }
}
