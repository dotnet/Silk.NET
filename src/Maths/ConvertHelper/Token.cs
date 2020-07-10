#region

using Superpower.Display;

#endregion

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