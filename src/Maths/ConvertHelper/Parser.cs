#region

using Superpower;
using Superpower.Parsers;

#endregion

namespace ConvertHelper
{
    internal class ArithmeticExpressionParser
    {
        private static readonly TokenListParser<ArithmeticExpressionToken, ExpressionType> Add = Operator
            (ArithmeticExpressionToken.Plus, ExpressionType.Add);

        private static readonly TokenListParser<ArithmeticExpressionToken, ExpressionType> Subtract = Operator
            (ArithmeticExpressionToken.Minus, ExpressionType.Subtract);

        private static readonly TokenListParser<ArithmeticExpressionToken, ExpressionType> Multiply = Operator
            (ArithmeticExpressionToken.Times, ExpressionType.Multiply);

        private static readonly TokenListParser<ArithmeticExpressionToken, ExpressionType> Divide = Operator
            (ArithmeticExpressionToken.Divide, ExpressionType.Divide);

        private static readonly TokenListParser<ArithmeticExpressionToken, ExpressionType> Comma = Operator
            (ArithmeticExpressionToken.Comma, ExpressionType.Comma);

        private static readonly TokenListParser<ArithmeticExpressionToken, string> Variable =
            Token.EqualTo(ArithmeticExpressionToken.None)
                .Apply(Character.LetterOrDigit.Or(Character.EqualTo('.')).AtLeastOnce())
                .Select(n => new string(n))
                .Named("variable");

        private static readonly TokenListParser<ArithmeticExpressionToken, string> Constant =
            Token.EqualTo(ArithmeticExpressionToken.Number)
                .Apply(Numerics.Decimal)
                .Select(n => $"Scalar.As<T>({n.ToString()})")
                .Named("constant")
                .Or(Variable);

        private static readonly TokenListParser<ArithmeticExpressionToken, string> Factor = (from lparen in
            Token.EqualTo(ArithmeticExpressionToken.LParen)
                                                                                             from expr in Parse.Ref(() => Expr)
                                                                                             from rparen in Token.EqualTo(ArithmeticExpressionToken.RParen)
                                                                                             select $"({expr})").Or(Constant);

        private static readonly TokenListParser<ArithmeticExpressionToken, string> Operand =
            (from sign in Token.EqualTo(ArithmeticExpressionToken.Minus)
             from factor in Factor
             select $"Scalar.Negate<T>({factor})").Or(Factor).Named("expression");

        private static readonly TokenListParser<ArithmeticExpressionToken, string> Term = Parse.Chain
            (Multiply.Or(Divide), Operand, AddParenthese);

        private static readonly TokenListParser<ArithmeticExpressionToken, string> Expr = Parse.Chain
            (Add.Or(Subtract), Term, AddParenthese);

        private static readonly TokenListParser<ArithmeticExpressionToken, string> Exprs = Parse.Chain
            (Comma, Expr, AddParenthese);

        public static readonly TokenListParser<ArithmeticExpressionToken, string> Transform = Exprs.AtEnd();

        private static TokenListParser<ArithmeticExpressionToken, ExpressionType> Operator
            (ArithmeticExpressionToken op, ExpressionType opType) => Token.EqualTo(op).Value(opType);

        private static string AddParenthese(ExpressionType type, string left, string right) => type switch
        {
            ExpressionType.Add => $"Scalar.Add<T>({left}, {right})",
            ExpressionType.Subtract => $"Scalar.Subtract<T>({left}, {right})",
            ExpressionType.Multiply => $"Scalar.Multiply<T>({left}, {right})",
            ExpressionType.Divide => $"Scalar.Divide<T>({left}, {right})",
            ExpressionType.Comma => $"({left}), ({right})",
            _ => $"Scalar.???<T>({left}, {right})"
        };

        private enum ExpressionType
        {
            Add,
            Subtract,
            Multiply,
            Divide,
            Comma
        }
    }
}