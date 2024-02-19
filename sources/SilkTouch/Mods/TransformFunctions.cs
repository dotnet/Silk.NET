using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Mods.Transformation;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Mods the bindings to use the Silk.NET.Core pointer types.
/// </summary>
public class TransformFunctions(FunctionTransformer ft) : ModCSharpSyntaxRewriter, IMod
{
    private ThreadLocal<string> _jobKey = new();

    /// <inheritdoc />
    public Task<GeneratedSyntax> AfterScrapeAsync(string key, GeneratedSyntax syntax)
    {
        _jobKey.Value = key;
        foreach (var (fName, node) in syntax.Files)
        {
            if (fName.StartsWith("sources/"))
            {
                syntax.Files[fName] = Visit(node);
            }
        }

        return Task.FromResult(syntax);
    }

    /// <inheritdoc />
    public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node) =>
        base.VisitClassDeclaration(node) is ClassDeclarationSyntax cd
            ? cd.WithMembers(
                List(
                    cd.Members.Where(x => x is not MethodDeclarationSyntax)
                        .Concat(
                            ft.GetTransformedFunctions(
                                    _jobKey.Value,
                                    cd.Members.OfType<MethodDeclarationSyntax>(),
                                    this
                                )
                                .OrderBy(x => x.Identifier.ToString())
                        )
                )
            )
            : node;

    /// <inheritdoc />
    public override SyntaxNode? VisitInterfaceDeclaration(InterfaceDeclarationSyntax node) =>
        base.VisitInterfaceDeclaration(node) is InterfaceDeclarationSyntax id
            ? id.WithMembers(
                List(
                    id.Members.Where(x => x is not MethodDeclarationSyntax)
                        .Concat(
                            ft.GetTransformedFunctions(
                                    _jobKey.Value,
                                    id.Members.OfType<MethodDeclarationSyntax>(),
                                    this
                                )
                                .OrderBy(x => x.Identifier.ToString())
                        )
                )
            )
            : node;
}
