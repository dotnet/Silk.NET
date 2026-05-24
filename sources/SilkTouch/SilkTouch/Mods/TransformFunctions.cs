using System;
using System.Collections.Generic;
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
[ModConfiguration<Configuration>]
public class TransformFunctions(FunctionTransformer ft) : ModCSharpSyntaxRewriter, IMod
{
    private ThreadLocal<string> _jobKey = new();

    /// <summary>
    /// Configuration for the <see cref="TransformFunctions"/> and related code.
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// Whether all integer return types should be treated as potentially boolean.
        /// </summary>
        public required bool IntReturnsMaybeBool { get; init; }

        /// <summary>
        /// Types to treat as boolean and their boolean schemes if different to default.
        /// </summary>
        public Dictionary<string, string?>? BoolTypes { get; init; }
    }

    /// <inheritdoc />
    public override string? JobKey
    {
        get => _jobKey.Value;
        set
        {
            if (value is null)
            {
                return;
            }
            _jobKey.Value = value;
        }
    }

    /// <inheritdoc />
    public async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        _jobKey.Value = ctx.JobKey;
        var proj = ctx.SourceProject;
        foreach (var docId in ctx.SourceProject?.DocumentIds ?? [])
        {
            var doc =
                proj!.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
            if (await doc.GetSyntaxRootAsync(ct) is { } root)
            {
                proj = doc.WithSyntaxRoot(Visit(root)).Project;
            }
        }

        ctx.SourceProject = proj;
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
