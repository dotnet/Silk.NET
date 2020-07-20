// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using Superpower;
using Superpower.Model;
using Superpower.Parsers;

namespace ConvertHelper
{
    internal class ArithmeticExpressionTokenizer : Tokenizer<ArithmeticExpressionToken>
    {
        private readonly Dictionary<char, ArithmeticExpressionToken> _operators =
            new Dictionary<char, ArithmeticExpressionToken>
            {
                ['+'] = ArithmeticExpressionToken.Plus,
                ['-'] = ArithmeticExpressionToken.Minus,
                ['*'] = ArithmeticExpressionToken.Times,
                ['/'] = ArithmeticExpressionToken.Divide,
                ['('] = ArithmeticExpressionToken.LParen,
                [')'] = ArithmeticExpressionToken.RParen,
                [','] = ArithmeticExpressionToken.Comma
            };

        protected override IEnumerable<Result<ArithmeticExpressionToken>> Tokenize(TextSpan span)
        {
            var next = SkipWhiteSpace(span);
            if (!next.HasValue)
            {
                yield break;
            }

            do
            {
                ArithmeticExpressionToken charToken;

                var ch = next.Value;
                if (ch >= '0' && ch <= '9')
                {
                    var integer = Numerics.Integer(next.Location);
                    next = integer.Remainder.ConsumeChar();
                    yield return Result.Value(ArithmeticExpressionToken.Number, integer.Location, integer.Remainder);
                }
                else if (_operators.TryGetValue(ch, out charToken))
                {
                    yield return Result.Value(charToken, next.Location, next.Remainder);
                    next = next.Remainder.ConsumeChar();
                }
                else
                {
                    var start = next.Location;
                    while (true)
                    {
                        var c = next.Location.ConsumeChar();
                        if (!c.HasValue || _operators.TryGetValue(c.Value, out _))
                        {
                            break;
                        }

                        if (char.IsWhiteSpace(c.Value))
                        {
                            break;
                        }

                        next = c.Remainder.ConsumeChar();
                    }

                    var location = start.Until(next.Location);
                    yield return Result.Value(ArithmeticExpressionToken.None, location, next.Location);
                }

                next = SkipWhiteSpace(next.Location);
            } while (next.HasValue);
        }
    }
}