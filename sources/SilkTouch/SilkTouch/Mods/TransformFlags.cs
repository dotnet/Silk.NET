using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Transforms [Flags] enums to have a "None = 0" member if they do not already have an equivalent.
/// </summary>
public class TransformFlags : IMod
{
    /// <inheritdoc />
    public async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        var proj = ctx.SourceProject;
        if (proj == null)
        {
            return;
        }

        var compilation = await proj.GetCompilationAsync(ct);
        if (compilation == null)
        {
            return;
        }

        var rewriter = new Rewriter(compilation);
        foreach (var docId in proj?.DocumentIds ?? [])
        {
            var doc = proj!.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
            proj = doc.WithSyntaxRoot(
                rewriter.Visit(await doc.GetSyntaxRootAsync(ct))?.NormalizeWhitespace()
                ?? throw new InvalidOperationException("Visit returned null.")
            ).Project;
        }

        ctx.SourceProject = proj;
    }

    private class Rewriter(Compilation compilation) : CSharpSyntaxRewriter
    {
        public override SyntaxNode? VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            var isFlagsEnum = node.AttributeLists.SelectMany(list => list.Attributes)
                .Any(attribute => attribute.IsAttribute("System.Flags"));

            if (!isFlagsEnum)
            {
                return base.VisitEnumDeclaration(node);
            }

            var semanticModel = compilation.GetSemanticModel(node.SyntaxTree);
            var symbol = semanticModel.GetDeclaredSymbol(node);
            if (symbol == null)
            {
                return base.VisitEnumDeclaration(node);
            }

            // Add None member if it doesn't exist yet
            var hasNoneMember = symbol.Members().Any(member =>
            {
                if (member.Name == "None")
                {
                    return true;
                }

                if (member is not IFieldSymbol fieldSymbol)
                {
                    return false;
                }

                // ConstantValue is an "object"
                // Directly comparing to 0 doesn't work
                // Casting to int does not either
                var isZero = fieldSymbol.ConstantValue switch
                {
                    sbyte n => n == 0,
                    byte n => n == 0,
                    short n => n == 0,
                    ushort n => n == 0,
                    int n => n == 0,
                    uint n => n == 0,
                    long n => n == 0,
                    ulong n => n == 0,
                    _ => false
                };

                return isZero;
            });

            if (!hasNoneMember)
            {
                var noneMember = EnumMemberDeclaration("None")
                    .WithEqualsValue(
                        EqualsValueClause(
                            LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(0))
                        )
                    );

                node = node.WithMembers(node.Members.Insert(0, noneMember));
            }

            return base.VisitEnumDeclaration(node);
        }
    }
}