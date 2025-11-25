// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Options;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Marks identifiers with the [NativeName] attribute.
/// </summary>
public class MarkNativeNames(IOptionsSnapshot<MarkNativeNames.Configuration> cfg) : IMod
{
    /// <summary>
    /// MarkNativeNames mod configuration.
    /// </summary>
    public record Configuration
    {
        /// <summary>
        /// Should identifiers marked with the [Transformed] attribute be included?
        /// These are ignored by default.
        /// </summary>
        public bool IncludeTransformed { get; init; } = false;

        // TODO: Probably add an exclude regex list
    }

    /// <inheritdoc />
    public async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        var config = cfg.Get(ctx.JobKey);

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

        var rewriter = new Rewriter();
        foreach (var docId in proj.DocumentIds)
        {
            var doc = proj.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
            proj = doc.WithSyntaxRoot(
                rewriter.Visit(await doc.GetSyntaxRootAsync(ct))?.NormalizeWhitespace()
                ?? throw new InvalidOperationException("Visit returned null.")
            ).Project;
        }

        ctx.SourceProject = proj;
    }

    private class Rewriter : ModCSharpSyntaxRewriter
    {

    }
}
