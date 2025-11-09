// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Options;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Matches on native function names, and generates matching private <c>partial</c> methods to allow non-generated code
/// to intercept the function call with custom logic. The original implementation is available with an <c>Internal</c>
/// suffix.
/// </summary>
/// <param name="options">The configuration for the mod.</param>
[ModConfiguration<Configuration>]
public class InterceptNativeFunctions(
    IOptionsSnapshot<InterceptNativeFunctions.Configuration> options
) : IMod
{
    /// <summary>
    /// The configuration for the <see cref="InterceptNativeFunctions"/> mod.
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// The native function names to generate intercepted <c>partial</c> for.
        /// </summary>
        public List<string>? NativeFunctionNames { get; init; }
    }

    /// <inheritdoc />
    public async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        var cfg = options.Get(ctx.JobKey);
        if (cfg.NativeFunctionNames is not { Count: > 0 })
        {
            return;
        }

        var rewriter = new Rewriter(cfg);
        var proj = ctx.SourceProject;
        foreach (var docId in proj?.DocumentIds ?? [])
        {
            var doc =
                proj!.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
            proj = doc.WithSyntaxRoot(
                rewriter.Visit(await doc.GetSyntaxRootAsync(ct))?.NormalizeWhitespace()
                    ?? throw new InvalidOperationException("Visit returned null.")
            ).Project;
        }

        ctx.SourceProject = proj;
    }

    class Rewriter(Configuration cfg) : CSharpSyntaxRewriter
    {
        private List<MethodDeclarationSyntax> _newMethods = [];

        public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            var ret = base.VisitClassDeclaration(node);
            if (_newMethods.Count != 0 && ret is ClassDeclarationSyntax cds)
            {
                ret = cds.WithMembers(List(cds.Members.Concat(_newMethods)));
            }

            _newMethods.Clear();
            return ret;
        }

        public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            if (
                (
                    node.Body is null
                    && node.ExpressionBody is null
                    && !node.Modifiers.Any(SyntaxKind.ExternKeyword)
                )
                || !node.AttributeLists.GetNativeFunctionInfo(out _, out var ep, out _)
                || !cfg.NativeFunctionNames!.Contains(ep ?? node.Identifier.ToString())
            )
            {
                return node;
            }

            _newMethods.Add(
                MethodDeclaration(node.ReturnType, node.Identifier)
                    .WithParameterList(node.ParameterList)
                    .WithAttributeLists(
                        List(
                            node.AttributeLists.SelectMany(x => x.Attributes)
                                .Where(x =>
                                    !x.IsAttribute("System.Runtime.InteropServices.DllImport")
                                    && !x.IsAttribute("Silk.NET.Core.NativeFunction")
                                )
                                .Select(x =>
                                    ((AttributeListSyntax)x.Parent!).WithAttributes(
                                        SingletonSeparatedList(x)
                                    )
                                )
                        )
                    )
                    .AddNativeFunction(node)
                    .WithModifiers(
                        [
                            .. node.Modifiers.Where(x => x.Kind() is not SyntaxKind.ExternKeyword),
                            Token(SyntaxKind.PartialKeyword),
                        ]
                    )
                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
            );

            return node.WithRenameSafeAttributeLists()
                .WithIdentifier(Identifier($"{node.Identifier}Internal"))
                .WithModifiers(
                    [
                        Token(SyntaxKind.PrivateKeyword),
                        .. node.Modifiers.Where(x =>
                            x.Kind()
                                is not (
                                    SyntaxKind.PrivateKeyword
                                    or SyntaxKind.PublicKeyword
                                    or SyntaxKind.InternalKeyword
                                    or SyntaxKind.ProtectedKeyword
                                )
                        ),
                    ]
                );
        }
    }
}
