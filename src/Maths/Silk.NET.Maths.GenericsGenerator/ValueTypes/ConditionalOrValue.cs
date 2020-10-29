// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Microsoft.CodeAnalysis.CSharp;
using Type = Silk.NET.Maths.GenericsGenerator.Type;

namespace Silk.NET.Maths.GenericsGenerator.ValueTypes
{
    public class ConditionalOrValue : BinaryOperatorValue
    {
        public override Type Type => Type.Boolean;

        protected override object Process(object left, object right)
        {
            if (Type == Type.Boolean)
                return (bool) left || (bool) right;

            throw new ArgumentException("Cannot or non-bool values");
        }

        protected override string OpStr => "||";
        protected override SyntaxKind OpSyntaxKind => SyntaxKind.LogicalOrExpression;
    }
}
