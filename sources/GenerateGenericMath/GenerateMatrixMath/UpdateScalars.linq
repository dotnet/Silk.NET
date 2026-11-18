<Query Kind="Program">
  <Namespace>Microsoft.CodeAnalysis.CSharp</Namespace>
  <Namespace>Microsoft.CodeAnalysis</Namespace>
  <Namespace>Microsoft.CodeAnalysis.CSharp.Syntax</Namespace>
</Query>

using static Microsoft.CodeAnalysis.CSharp.SyntaxKind;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

void Main()
{
    void Fixup(string path)
    {
        var parsed = CSharpSyntaxTree.ParseText(File.ReadAllText(path));
        var updater = new CodeUpdater();
        File.WriteAllText(path, updater.Visit(parsed.GetRoot()).ToFullString());
    }

    foreach (var csFile in Directory.EnumerateFiles(@"C:\Users\otac0n\Projects\Silk.NET\sources\Maths\Maths\", "*.cs"))
    {
        Fixup(csFile);
    }
}

internal sealed class CodeUpdater : CSharpSyntaxRewriter
{
    private static readonly Dictionary<string, SyntaxKind> OperatorLookup = new()
    {
        { "Scalar.Add",                AddExpression },
        { "Scalar.Subtract",           SubtractExpression },
        { "Scalar.Negate",             UnaryMinusExpression },
        { "Scalar.Multiply",           MultiplyExpression },
        { "Scalar.Divide",             DivideExpression },
        { "Scalar.GreaterThan",        GreaterThanExpression },
        { "Scalar.LessThan",           LessThanExpression },
        { "Scalar.GreaterThanOrEqual", GreaterThanOrEqualExpression },
        { "Scalar.LessThanOrEqual",    LessThanOrEqualExpression },
    };

    private static readonly Dictionary<string, string> MethodReplacements = new()
    {
        { "Scalar.Abs", "T.Abs" },
        { "Scalar.Min", "T.Min" },
        { "Scalar.Max", "T.Max" },
        { "Scalar.Sin", "T.Sin" },
        { "Scalar.Cos", "T.Cos" },
        { "Scalar.Acos", "T.Acos" },
        { "Scalar.Tan", "T.Tan" },
        { "Scalar.Sqrt", "T.Sqrt" },
        { "Scalar.IsPositiveInfinity", "T.IsPositiveInfinity" },
    };

    public override SyntaxNode VisitInvocationExpression(InvocationExpressionSyntax node)
    {
        var visited = base.VisitInvocationExpression(node);
        if (visited is InvocationExpressionSyntax invocation)
        {
            var key = invocation.Expression.ToString();
            var arguments = invocation.ArgumentList.Arguments;
            if (key == "Scalar.Reciprocal")
            {
                return ParenthesizedExpression(
                        BinaryExpression(
                            DivideExpression,
                            ParseName("T.One"),
                            ParenthesizedExpression(arguments[0].Expression)));
            }
            else if (OperatorLookup.TryGetValue(key, out var @operator))
            {
                if (arguments.Count == 1)
                {
                    return ParenthesizedExpression(
                        PrefixUnaryExpression(
                            @operator,
                            ParenthesizedExpression(arguments[0].Expression)));
                }
                else
                {
                    var left = arguments[0].Expression;
                    var right = arguments[1].Expression;
                    return ParenthesizedExpression(
                        BinaryExpression(
                            @operator,
                            ParenthesizedExpression(left),
                            ParenthesizedExpression(right)));
                }
            }
            else if (MethodReplacements.TryGetValue(key, out var replacement))
            {
                return InvocationExpression(
                    ParseName(replacement),
                    invocation.ArgumentList);
            }
        }

        return visited;
    }
}
