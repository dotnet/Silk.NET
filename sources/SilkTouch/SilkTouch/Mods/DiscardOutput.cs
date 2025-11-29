// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Logging;
using Silk.NET.SilkTouch.Naming;
using Silk.NET.SilkTouch.Utility;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// A mod that will discard any output specified
/// </summary>
/// <param name="logger">The logger.</param>
/// <param name="config">Configuration snapshot.</param>
/// <param name="progressService">the progress service</param>
[ModConfiguration<Configuration>]
public class DiscardOutput(
    ILogger<DiscardOutput> logger,
    IOptionsSnapshot<DiscardOutput.Configuration> config,
    IProgressService progressService
    ) : Mod
{
    /// <summary>
    /// The configuration for the discard output mod.
    /// </summary>
    public record Configuration // DON'T USE CONSTRUCTOR-STYLE RECORDS! Needs a default ctor.
    {
        /// <summary>
        /// List of output files to discard
        /// </summary>
        public required List<string> OutputToDiscard { get; init; }
    }

    /// <inheritdoc/>
    public override async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        await base.ExecuteAsync(ctx, ct);

        var cfg = config.Get(ctx.JobKey);
        var proj = ctx.SourceProject;

        if (proj is null)
        {
            return;
        }

        if (cfg.OutputToDiscard is null || cfg.OutputToDiscard.Count == 0)
        {
            logger.LogWarning("Skipping DiscardOutput as no files were flagged for discard was provided");
            return;
        }

        int count = proj?.DocumentIds.Count ?? 0;
        int index = 0;

        List<Regex> discardRegex = [];

        foreach (var discard in cfg.OutputToDiscard)
        {
            string regexPattern = FileUtils.GlobToRegexInput(discard);

            discardRegex.Add(new(regexPattern));
        }

        List<DocumentId> documentsToRemove = [];
        progressService.SetTask("Flagging Documents for removal");
        foreach (var docId in proj?.DocumentIds ?? [])
        {
            index++;

            var doc =
                proj?.GetDocument(docId)
                ?? throw new InvalidOperationException("Document missing");

            if (doc.FilePath is not null)
            {
                bool found = false;
                foreach (var regex in discardRegex)
                {
                    if (regex.IsMatch(doc.FilePath))
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    documentsToRemove.Add(docId);
                    logger.LogInformation($"Flagged {doc.Name} for removal");
                }
            }

            progressService.SetProgress((float)index / count);
        }

        progressService.SetTask("Removing Documents");
        for (var i = 0; i < documentsToRemove.Count; i++)
        {
            var docId = documentsToRemove[i];
            proj = proj?.RemoveDocument(docId);

            progressService.SetProgress((float)i / documentsToRemove.Count);
        }
        progressService.SetProgress(1);

        if (proj?.ContainsDocument(documentsToRemove[0]) ?? false)
        {
            throw new Exception("WE DIDN't DO IT");
        }

        ctx.SourceProject = proj;
    }

}
