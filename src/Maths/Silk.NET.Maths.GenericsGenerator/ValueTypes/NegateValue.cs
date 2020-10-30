// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Microsoft.CodeAnalysis.CSharp;

namespace Silk.NET.Maths.GenericsGenerator.ValueTypes
{
    public class NegateValue : UnaryOperatorValue
    {
        protected override object Process(object f)
            => Type switch
            {
                Type.Numeric => -(float) f,
                Type.Boolean => !(bool) f,
                _ => throw new ArgumentException("cannot process unary unknown", nameof(Type))
            };

        protected override string OpStr
            => Type switch
            {
                Type.Numeric => "-", Type.Boolean => "!",
                _ => throw new ArgumentException("cannot process unary unknown", nameof(Type))
            };

        protected override SyntaxKind OpSyntaxKind
            => Type switch
            {
                Type.Numeric => SyntaxKind.UnaryMinusExpression, Type.Boolean => SyntaxKind.LogicalNotExpression,
                _ => throw new ArgumentException("cannot process unary unknown", nameof(Type))
            };
    }
}
