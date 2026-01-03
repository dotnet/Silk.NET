// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Logging;
using Silk.NET.SilkTouch.Naming;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// A mod that will remap given type names to the given names
/// </summary>
/// <param name="logger">The logger.</param>
/// <param name="config">Configuration snapshot.</param>
/// <param name="progressService">the progress service</param>
[ModConfiguration<Configuration>]
public class RemapTypes(
    ILogger<RemapTypes> logger,
    IOptionsSnapshot<RemapTypes.Configuration> config,
    IProgressService progressService
    ) : Mod
{
    /// <summary>
    /// The configuration for the remap types mod.
    /// </summary>
    public record Configuration // DON'T USE CONSTRUCTOR-STYLE RECORDS! Needs a default ctor.
    {
        /// <summary>
        /// List of type Mapping
        /// </summary>
        public required Dictionary<string, string> Mappings { get; init; }
    }

    /// <inheritdoc/>
    public override async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        await base.ExecuteAsync(ctx, ct);

        var cfg = config.Get(ctx.JobKey);

        if (ctx.SourceProject is null)
        {
            return;
        }

        if (cfg.Mappings is null || cfg.Mappings.Count == 0)
        {
            logger.LogWarning("Skipping RemapTypes as no type mapping was provided");
            return;
        }

        var proj = ctx.SourceProject;
        var comp =
            await proj.GetCompilationAsync(ct)
            ?? throw new InvalidOperationException(
                "Failed to obtain compilation for source project!"
            );

        var diagnostics = comp.GetDiagnostics();
        progressService.SetTask("Searching for Errored Typing");

        List<Location> retrievedLocations = [];

        progressService.SetTask("Remapping Errored Types");
        await NameUtils.RemapAllAsync(ctx, cfg.Mappings!, diagnostics.Select(diagnostic => diagnostic.Location), logger);
        progressService.SetProgress(1);

        proj = ctx.SourceProject;
        comp =
            await proj.GetCompilationAsync(ct)
            ?? throw new InvalidOperationException(
                "Failed to obtain compilation for source project!"
            );

        progressService.SetTask("Remapping Known Types");

        await NameUtils.RenameAllAsync(
            ctx,
            cfg.Mappings.SelectMany(x => comp.GetSymbolsWithName(x.Key, SymbolFilter.Type, ct).OfType<ITypeSymbol>().Select(y => ((ISymbol)y, x.Value))),
            logger,
            ct,
            false
        );
        progressService.SetProgress(1);
    }
}
