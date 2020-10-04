// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Superpower.Display;

namespace ConvertHelper
{
    internal enum ArithmeticExpressionToken
    {
        None,

        Number,

        [Token(Category = "operator", Example = "+")]
        Plus,

        [Token(Category = "operator", Example = "-")]
        Minus,

        [Token(Category = "operator", Example = "*")]
        Times,

        [Token(Category = "operator", Example = "-")]
        Divide,

        [Token(Example = "(")] LParen,

        [Token(Example = ")")] RParen,

        [Token(Example = ",")] Comma
    }
}