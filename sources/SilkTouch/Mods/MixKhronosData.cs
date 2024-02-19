using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using Humanizer;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Naming;

namespace Silk.NET.SilkTouch.Mods;

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
    private static readonly ICulturedStringTransformer Transformer = new NameUtils.NameTransformer(
        4
    );

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

        /// <summary>
        /// Whether the extension vendor
        /// </summary>
        public ExtensionVendorTrimmingMode UseExtensionVendorTrimmings { get; init; }
    }

    /// <summary>
    /// Modes for trimming extension vendor names.
    /// </summary>
    [JsonConverter(typeof(ExtensionVendorTrimmingModeJsonConverter))]
    public enum ExtensionVendorTrimmingMode
    {
        /// <summary>
        /// Do not trim extension vendors from names. Note that matching vendors may still be used to determine the
        /// offset of data type suffixes.
        /// </summary>
        None,

        /// <summary>
        /// Trim all extension vendor names.
        /// </summary>
        All,

        /// <summary>
        /// Only trim Khronos/first-party extension vendor names i.e. KHR and ARB.
        /// </summary>
        KhronosOnly
    }

    private class ExtensionVendorTrimmingModeJsonConverter
        : JsonConverter<ExtensionVendorTrimmingMode>
    {
        public override ExtensionVendorTrimmingMode Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            if (reader.TokenType == JsonTokenType.True)
            {
                return ExtensionVendorTrimmingMode.All;
            }

            if (reader.GetString() is { } str)
            {
                return Enum.Parse<ExtensionVendorTrimmingMode>(str);
            }

            return ExtensionVendorTrimmingMode.None;
        }

        public override void Write(
            Utf8JsonWriter writer,
            ExtensionVendorTrimmingMode value,
            JsonSerializerOptions options
        ) => writer.WriteStringValue(value.ToString());
    }

    /// <inheritdoc />
    // non-versioned trimmer (and needs to be a big number to come after the default trimmers)
    public Version Version { get; } = new(42, 42, 42, 42);

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
                    .Select(x => x.Value.Split('_')[1]) ?? Enumerable.Empty<string>()
            )
            .ToHashSet();
    }

    /// <inheritdoc />
    public void Trim(
        string? container,
        string? hint,
        string? jobKey,
        Dictionary<string, (string Primary, List<string>? Secondary)>? names,
        Dictionary<string, string>? prefixOverrides,
        ref string? identifiedPrefix
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
            var newCurrent = current;
            List<string>? newPrev = null;
            string? identifiedVendor = null;
            var trimVendor = false;
            foreach (var vendor in vendors)
            {
                if (!current.EndsWith(vendor))
                {
                    continue;
                }

                newCurrent = current[..^vendor.Length];
                var newOriginal = original[..^vendor.Length];
                // Sometimes we should keep the vendor prefix so we prefer the promoted functions.
                // ----------vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv--------------------------------------
                trimVendor =
                    !names.ContainsKey(newOriginal)
                    && (
                        cfg.UseExtensionVendorTrimmings == ExtensionVendorTrimmingMode.All
                        || (
                            cfg.UseExtensionVendorTrimmings
                                == ExtensionVendorTrimmingMode.KhronosOnly
                            && vendor is "KHR" or "ARB"
                        )
                    );
                if (trimVendor)
                {
                    newPrev ??= previous ?? [];
                    newPrev.Add(current);
                    names[original] = (newCurrent, newPrev);
                }

                identifiedVendor = vendor;
                break;
            }

            // Below is a hack to ensure extension vendors are capitalised for enums (which are all caps and therefore
            // will not be treated as an acronym)
            if (
                current.All(x => !char.IsLetter(x) || char.IsUpper(x))
                && identifiedVendor is not null
            )
            {
                newPrev ??= previous ?? [];
                var pretty = newCurrent.Prettify(Transformer);

                // Hack to ensure extension vendors are preserved as acronyms
                if (char.IsUpper(pretty[^1]))
                {
                    pretty += ' ';
                }

                if (!trimVendor)
                {
                    // If we're not trimming the vendor, this hack will be the primary name.
                    newPrev.Add(current);
                    names[original] = (pretty + identifiedVendor, newPrev);
                }
                else
                {
                    // If we are trimming the vendor, if at any point we have to fall back on the untrimmed version
                    // we'll want that version to be this hack.
                    newPrev.Add(pretty + identifiedVendor);
                    names[original] = (pretty, newPrev);
                }
            }

            // Another hack to make sure that extension vendors are preserved as acronyms e.g. glTexImage4DSGIS was
            // becoming glTexImage4Dsgis instead of glTexImage4DSGIS
            if (
                current.Any(char.IsLower)
                && char.IsUpper(newCurrent[^1])
                && identifiedVendor is not null
            )
            {
                newPrev ??= previous ?? [];
                if (!trimVendor)
                {
                    // If we're not trimming the vendor, this hack will be the primary name.
                    newPrev.Add(current);
                    names[original] = ($"{newCurrent} {identifiedVendor}", newPrev);
                }
                else
                {
                    // If we are trimming the vendor, if at any point we have to fall back on the untrimmed version
                    // we'll want that version to be this hack. Note that to do this we actually have to nuke the
                    // original name because PrettifyNames orders by match length.
                    newPrev.Remove(current);
                    newPrev.Add($"{newCurrent} {identifiedVendor}");
                    names[original] = (newCurrent, newPrev);
                }
            }

            if (
                !cfg.UseDataTypeTrimmings // don't trim data types
                || newCurrent.Count(x => x == '_') > 1 // is probably an enum
                || EndingsToTrim().Match(newCurrent) is not { Success: true } match // we don't have a data type suffix
                || EndingsNotToTrim().IsMatch(newCurrent) // we need to keep it
            )
            {
                continue;
            }

            newPrev ??= previous ?? [];
            var newPrim = newCurrent.Remove(match.Index);
            if (identifiedVendor is not null && trimVendor)
            {
                // If the only difference between this function and other functions that could conflict is the vendor,
                // it would be extremely confusing if the difference between e.g. a NV function and a non-NV function
                // was one had data type suffixes and the other didn't. Therefore, let's add the new name but with the
                // vendor added as the first secondary (e.g. for glVertex2bOES we first try Vertex2OES). If that doesn't
                // work, we still have the original one (modulo GL prefix) that we added to the secondary list when
                // originally trimming the vendor.
                newPrev.Add(newPrim + identifiedVendor);
            }
            else
            {
                // If trimVendor is false, add the vendor back. We're not trimming vendors so the only other secondary
                // we have is the original current name i.e. primary = glVertex2OES, secondary = glVertex2bOES, which
                // WOULDN'T be in the secondary list already per the if trimVendor above. If we're hitting this else
                // because we haven't identified a vendor, then we're just appending null to this string which does
                // nothing and is effectively equivalent to us having primary = glVertex2, secondary = glVertex2b
                newPrim += identifiedVendor;
                newPrev.Add(current);
            }

            names[original] = (newPrim, newPrev);
        }
    }

    /// <summary>
    /// This regex matches against known OpenGL function endings, picking them out from function names.
    /// It is comprised of two parts - the main matching set (here, the main capturing group), and a negative
    /// lookbehind workaround for difficult-to-match names. The primary set matches the actual function ending,
    /// while the lookbehind asserts that the ending match will not overreach into the end of a word.
    /// </summary>
    // NOTE: LET THIS BE A LESSON! Do NOT add x (fixed) here, these will frequently conflict with integer overloads.
    [GeneratedRegex("(?<!xe)([fdh]v?|u?[isb](64)?v?|v|i_v|fi|hi)$")]
    private static partial Regex EndingsToTrim();

    /// <summary>
    /// This regex acts like a whitelist for endings that could have been matched in some way by the main
    /// expression, but should be exempt from trimming altogether.
    /// </summary>
    [GeneratedRegex(
        "(sh|ib|[tdrey]s|(?<![A-Z])[eE]n[vd]|bled|Attrib|Access|Boolean|Coord|Depth|Feedbacks|Finish|Flag|"
            + "Groups|IDs|Indexed|Instanced|Pixels|Queries|Status|Tess|Through|Uniforms|Varyings|Weight|Width|Bias|Id|"
            + "Fixed|Pass|Address|Configs|Thread|Subpass|Deferred|Extended|Affix|Annex|Box|Aux|Ex|Index|Vertex|Path|"
            + "Arch|ArithAfresh|Both|High|Math|Mesh|Sinh|Bench|Brush|Bunch|Crash|Flush|Depth|Latch|Morph|Pinch|"
            + "Pitch|Stretch|Smooth|Matrix|Radix)$"
    )]
    private static partial Regex EndingsNotToTrim();
}
