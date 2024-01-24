using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ClangSharp;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Mods.DSL;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Mods the bindings to use the Silk.NET.Core pointer types.
/// </summary>
public class TransformFunctions(FunctionTransformer ft) : CSharpSyntaxRewriter, IMod
{
    /// <inheritdoc />
    public Task<GeneratedSyntax> AfterScrapeAsync(string key, GeneratedSyntax syntax)
    {
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
                            ft.GetTransformedFunctions(cd.Members.OfType<MethodDeclarationSyntax>())
                                .OrderBy(x => x.Identifier.ToString())
                        )
                )
            )
            : node;
}
