using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SilkTouchX.Naming;

namespace SilkTouchX.Mods;

/// <summary>
/// A mod that reads Khronos specifications to influence codegen.
/// </summary>
/// <param name="logger">The logger.</param>
/// <param name="cfg">The configuration.</param>
[ModConfiguration<Configuration>]
public partial class MixKhronosData(
    ILogger<MixKhronosData> logger,
    IOptionsSnapshot<MixKhronosData.Configuration> cfg
) : IMod, INameTrimmer
{
    private Dictionary<string, HashSet<string>> _vendors = new();
    private Dictionary<string, Configuration> _jobs = new();

    /// <summary>
    /// Khronos mod configuration.
    /// </summary>
    public record Configuration
    {
        /// <summary>
        /// The path to the XML specification file.
        /// </summary>
        /// <remarks>
        /// Can be null, in which case this is equivalent to just using OpenGL style trimmings on non-OpenGL bindings
        /// which we do want to do in some cases (like OpenAL)
        /// </remarks>
        public string? SpecPath { get; init; }

        /// <summary>
        /// Whether OpenGL-style data type suffixes should be trimmed.
        /// </summary>
        public bool UseDataTypeTrimmings { get; init; }
    }

    /// <inheritdoc />
    public Version Version { get; } = new(0, 0); // non-versioned (also needs to be zero for sorting)

    /// <inheritdoc />
    public async Task BeforeJobAsync(string key, SilkTouchConfiguration config)
    {
        var currentConfig = cfg.Get(key);
        _jobs[key] = currentConfig;
        var specPath = currentConfig.SpecPath;
        if (specPath is null)
        {
            _vendors[key] = new HashSet<string>();
            return;
        }
        logger.LogInformation("Reading Khronos XML from \"{}\"...", specPath);
        await using var fs = File.OpenRead(specPath);
        var xml = await XDocument.LoadAsync(fs, LoadOptions.None, default);

        // Get all vendor names
        _vendors[key] = (
            xml.Element("registry")
                ?.Element("tags")
                ?.Elements("tag")
                .Attributes("name")
                .Select(x => x.Value) ?? Enumerable.Empty<string>()
        )
            .Concat(
                xml.Element("registry")
                    ?.Element("extensions")
                    ?.Elements("extension")
                    .Attributes("name")
                    .Where(x => !x.Value.StartsWith("cl"))
                    .Select(x => x.Value[(x.Value.IndexOf('_') + 1)..])
                    ?? Enumerable.Empty<string>()
            )
            .ToHashSet();
    }

    /// <inheritdoc />
    public void Trim(
        string? container,
        string? hint,
        string? jobKey,
        Dictionary<string, (string Primary, List<string>? Secondary)>? names,
        Dictionary<string, string>? prefixOverrides
    )
    {
        if (names is null || jobKey is null)
        {
            return;
        }

        if (
            !_vendors.TryGetValue(jobKey, out var vendors)
            || !_jobs.TryGetValue(jobKey, out var cfg)
        )
        {
            throw new InvalidOperationException(
                "BeforeJobAsync has not run yet! MixKhronosData must come before PrettifyNames in the mod list."
            );
        }

        if (vendors.Count == 0)
        {
            logger.LogWarning(
                "No vendor information present, assuming no XML was provided? Extension trimming will be skipped."
            );
        }

        // Trim the extension vendor names
        foreach (var (original, (current, previous)) in names)
        {
            foreach (var vendor in vendors)
            {
                if (!current.EndsWith(vendor))
                {
                    continue;
                }

                var newPrev = previous ?? new List<string>();
                newPrev.Add(current);
                names[original] = (current[..^vendor.Length], newPrev);
                break;
            }
        }

        // Trim data types
        if (!cfg.UseDataTypeTrimmings)
        {
            return;
        }

        foreach (var (original, (current, previous)) in names)
        {
            if (original == "glDisablei")
            {
                Debugger.Break();
            }

            if (
                EndingsToTrim().Match(current) is not { Success: true } match
                || EndingsNotToTrim().IsMatch(current)
            )
            {
                continue;
            }

            var newPrev = previous ?? new List<string>();
            newPrev.Add(current);
            names[original] = (current.Remove(match.Index), newPrev);
        }
    }

    /// <summary>
    /// This regex matches against known OpenGL function endings, picking them out from function names.
    /// It is comprised of two parts - the main matching set (here, the main capturing group), and a negative
    /// lookbehind workaround for difficult-to-match names. The primary set matches the actual function ending,
    /// while the lookbehind asserts that the ending match will not overreach into the end of a word.
    /// </summary>
    [GeneratedRegex("(?<!xe)([fd]v?|u?[isb](64)?v?|v|i_v|fi)$")]
    private static partial Regex EndingsToTrim();

    /// <summary>
    /// This regex acts like a whitelist for endings that could have been matched in some way by the main
    /// expression, but should be exempt from trimming altogether.
    /// </summary>
    [GeneratedRegex(
        "(sh|ib|[tdrey]s|[eE]n[vd]|bled|Attrib|Access|Boolean|Coord|Depth|Feedbacks|Finish|Flag|Groups|IDs|Indexed|"
            + "Instanced|Pixels|Queries|Status|Tess|Through|Uniforms|Varyings|Weight|Width|Bias|Id|Fixed|Pass|"
            + "Address|Configs|Thread|Subpass|Deferred)$"
    )]
    private static partial Regex EndingsNotToTrim();
}
