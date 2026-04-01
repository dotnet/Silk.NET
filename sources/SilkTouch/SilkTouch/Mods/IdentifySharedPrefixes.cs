// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis.CSharp;
using Microsoft.Extensions.Options;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Identifies shared prefixes,
/// such as namespace prefixes (eg: vk, gl)
/// and enum constant prefixes (eg: VK_ACCESS).
/// <para/>
/// These are identified as [NameAffix] attributes that
/// <see cref="PrettifyNames"/> and other mods can then process further.
/// </summary>
public class IdentifySharedPrefixes(IOptionsSnapshot<IdentifySharedPrefixes.Configuration> config)
    : Mod
{
    /// <summary>
    /// The configuration for the <see cref="IdentifySharedPrefixes"/> mod.
    /// </summary>
    public record Configuration
    {
        /// <summary>
        /// Corrections to the automatic prefix determination.
        /// </summary>
        public Dictionary<string, string> PrefixOverrides { get; init; } = [];

        /// <summary>
        /// A list of known prefixes that are commonly used by names in the native API.
        /// These are preferred when identifying shared prefixes.
        /// </summary>
        public IReadOnlyList<string> GlobalPrefixHints { get; init; } = [];
    }

    /// <inheritdoc />
    public override async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        var cfg = config.Get(ctx.JobKey);
        if (ctx.SourceProject is null)
        {
            return;
        }

        // Sort the hints from large to small
        // This makes it so that we prefer longer prefixes
        var hints = cfg.GlobalPrefixHints.ToList();
        hints.Sort((x, y) => -x.Length.CompareTo(y.Length));
        cfg = cfg with { GlobalPrefixHints = hints };
    }

    private class Visitor : CSharpSyntaxRewriter { }
}
