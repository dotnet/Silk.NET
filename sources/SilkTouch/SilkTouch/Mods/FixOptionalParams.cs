// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Logging;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;


namespace Silk.NET.SilkTouch.Mods
{
    /// <summary>
    /// A Mod to fix optional parameters types
    /// </summary>
    /// <param name="config">The configuration to use.</param>
    /// <param name="progressService">the progress service to use</param>
    [ModConfiguration<Configuration>]
    public class FixOptionalParams(
        IOptionsSnapshot<FixOptionalParams.Configuration> config,
        IProgressService progressService
    ) : Mod
    {
        /// <summary>
        /// The configuration for the <see cref="Configuration"/> mod.
        /// </summary>
        public class Configuration
        {
            /// <summary>
            /// The types of optional parameters to fix
            /// </summary>
            public string[]? TypesToFix { get; set; }
        }

        /// <inheritdoc/>
        public override async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
        {
            await base.ExecuteAsync(ctx, ct);

            // Read the configuration.
            var proj = ctx.SourceProject;
            var cfg = config.Get(ctx.JobKey);

            if (proj is null || cfg.TypesToFix is null)
            {
                return;
            }

            int count = proj?.DocumentIds.Count ?? 0;
            int index = 0;

            index = 0;
            var rewriter = new Rewriter(cfg.TypesToFix);
            progressService.SetTask("Fixing Optional Parameters");
            foreach (var docId in proj?.DocumentIds ?? [])
            {
                index++;
                var doc =
                    proj?.GetDocument(docId)
                    ?? throw new InvalidOperationException("Document missing");
                if (await doc.GetSyntaxRootAsync(ct) is not { } root)
                {
                    continue;
                }

                doc = doc.WithSyntaxRoot(root = rewriter.Visit(root).NormalizeWhitespace());

                proj = doc.Project;
                progressService.SetProgress((float)index / count);
            }
            ctx.SourceProject = proj;
        }

        private class Rewriter(string[] TypesToFix) : ModCSharpSyntaxRewriter
        {
            public override SyntaxNode? VisitParameterList(ParameterListSyntax node)
            {
                if (node.Parameters.Any(param => TypesToFix.Contains(param.Type?.ToString()) &&
                    param.Default is not null))
                {
                    var newParams = node.Parameters.Select((param, index) => new {
                        Param = param,
                        Priority = param.Default is null ? 0 :
                            ((TypesToFix.Contains(param.Type?.ToString()) &&
                            param.Default is not null) ? 1 : 2),
                        OriginalIndex = index
                    })
                        .OrderBy(x => x.Priority)
                        .ThenBy(x => x.OriginalIndex)
                        .Select(x => x.Param);
                    node = node.WithParameters(SeparatedList(newParams));
                }
                return base.VisitParameterList(node);
            }

            public override SyntaxNode? VisitParameter(ParameterSyntax param)
            {
                if (TypesToFix.Contains(param.Type?.ToString()) &&
                    param.Default is not null)
                {
                    return param.AddAttributeLists(AttributeList(SeparatedList<AttributeSyntax>(
                        new SyntaxNodeOrToken[] {
                        Attribute(IdentifierName("Optional")),
                        Token(SyntaxKind.CommaToken),
                        Attribute(
                            IdentifierName("DefaultParameterValue"))
                            .WithArgumentList(
                                AttributeArgumentList(
                                    SingletonSeparatedList(
                                        AttributeArgument(
                                            param.Default.Value.DescendantNodesAndSelf().OfType<LiteralExpressionSyntax>().First())))
                            )
                        })))
                        .WithDefault(null
                    );
                }

                return base.VisitParameter(param);
            }
        }
    }
}
