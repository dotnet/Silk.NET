using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;

namespace Silk.NET.SilkTouch.Naming;

/// <summary>
/// The default name trimmer ported from Silk.NET 2.18 with modifications for 3.0.
/// </summary>
public class NameTrimmer : INameTrimmer
{
    /// <inheritdoc />
    public virtual Version Version => new(3, 0);

    /// <inheritdoc/>
    public virtual int Order => (int)TrimmerOrder.NameTrimmer;

    /// <summary>
    /// Determines whether a second pass without using <see cref="GetTrimmingName"/> is warranted.
    /// </summary>
    protected virtual bool HasRawPass => true;

    /// <summary>
    /// Determines whether a third pass using "naive" prefix detection is warranted. Only applicable if
    /// <see cref="HasRawPass"/> is true.
    /// </summary>
    /// <seealso cref="NameUtils"/>
    protected virtual bool HasNaivePass => true;

    private static readonly HashSet<string> s_forbiddenTrimmings = new() { "unsigned", "per" };

    /// <inheritdoc />
    public void Trim(NameTrimmerContext context)
    {
        string? identifiedPrefix = null;
        List<AugmentedCandidateNames> localNames = null!;
        var nPasses = HasRawPass
            ? HasNaivePass
                ? 3
                : 2
            : 1;
        var naive = false;
        if (identifiedPrefix is null)
        {
            for (var i = 0; i < nPasses; i++) // try with both trimming name and non trimming name
            {
                // Attempt to identify the hint being used.
                string? hint = null;
                foreach (var candidateHint in context.Configuration.GlobalPrefixHints ?? [])
                {
                    var match = true;
                    foreach (var (name, _) in context.Names.Values)
                    {
                        if (!name.StartsWith(candidateHint, StringComparison.OrdinalIgnoreCase))
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match)
                    {
                        hint = candidateHint;
                        break;
                    }
                }

                var result = GetPrefix(
                    context.Container,
                    hint,
                    context.Names,
                    context.Configuration.PrefixOverrides,
                    context.NonDeterminant,
                    i == 0,
                    naive = i == 2
                );

                if (result is null)
                {
                    // skip outright.
                    return;
                }

                (identifiedPrefix, localNames) = result.Value;

                // If we have found a prefix,
                if (
                    identifiedPrefix.Length > 0
                    && identifiedPrefix.Length < localNames.Min(x => x.TrimmingName.Length)
                )
                {
                    // break and use it for trimming!
                    break;
                }

                // If not, do most of them at least start with the hint?
                if (
                    hint is null
                    || localNames.Count(x =>
                        x.TrimmingName.StartsWith(hint, StringComparison.OrdinalIgnoreCase)
                    )
                        >= localNames.Count / 2
                )
                {
                    // Nope, nothing we can do it seems, we've already tried both trimming name and non trimming name...
                    continue;
                }

                // The prefix is the hint!
                identifiedPrefix = hint;
                naive = true;
                break;
            }
        }

        // If identifiedPrefix is null, we fall back to the hints. I know we've checked above whether this is the
        // obvious answer for a given pass, but if we've still got no possible prefix after all of the passes then this
        // is better than nothing - if the name doesn't start with the prefix we simply won't use the prefix.
        if (
            string.IsNullOrWhiteSpace(identifiedPrefix)
            && context.Configuration.GlobalPrefixHints is not { Count: > 0 }
        )
        {
            return;
        }

        identifiedPrefix = identifiedPrefix?.Trim('_');
        foreach (var (oldPrimary, secondary, originalName, trimmingName) in localNames)
        {
            foreach (
                var candidatePrefix in !string.IsNullOrWhiteSpace(identifiedPrefix)
                    ? [identifiedPrefix] // otherwise we fall back to the hints...
                    : context.Configuration.GlobalPrefixHints ?? []
            )
            {
                if (
                    naive
                    && (
                        candidatePrefix.Length >= trimmingName.Length
                        || !trimmingName.StartsWith(
                            candidatePrefix,
                            StringComparison.OrdinalIgnoreCase
                        )
                    )
                )
                {
                    continue;
                }

                var oldPrimaryI = 0;
                var isPrefixTooLong = false;
                for (var candidateI = 0; candidateI < candidatePrefix.Length; candidateI++)
                {
                    if (oldPrimaryI >= oldPrimary.Length)
                    {
                        isPrefixTooLong = true;
                        break;
                    }

                    if (
                        char.ToLower(candidatePrefix[candidateI])
                        == char.ToLower(oldPrimary[oldPrimaryI])
                    )
                    {
                        oldPrimaryI++;
                        continue;
                    }

                    if (candidatePrefix[candidateI] == '_')
                    {
                        oldPrimaryI++;
                    }
                }

                if (isPrefixTooLong)
                {
                    continue;
                }

                // this was trimmingName originally. given that we're using trimming name to determine a prefix but then
                // using that prefix on the old primary, this could cause intended behaviour in some cases. there's probably
                // a better way to do this. (this is working around glDisablei -> glDisable -> Disablei).
                context.Names[originalName] = new CandidateNames(
                    oldPrimary[oldPrimaryI..].Trim('_'),
                    secondary
                );
                break;
            }
        }
    }

    /// <summary>
    /// Gets the prefix for the given constituents of the given container.
    /// </summary>
    /// <param name="container">The container name if applicable.</param>
    /// <param name="hint">The global prefix hint if applicable.</param>
    /// <param name="names">The names to get a prefix for.</param>
    /// <param name="prefixOverrides">Prefix overrides.</param>
    /// <param name="nonDeterminant">List of names that should not be used for prefix determination.</param>
    /// <param name="getTrimmingName">
    /// Whether to use <see cref="GetTrimmingName"/> or to use the native name as-is.
    /// </param>
    /// <param name="naive">
    /// Just match the start of the strings, don't bother checking for obvious name separation gaps.
    /// </param>
    /// <returns>
    /// Null to skip this container outright, empty if no prefix was found, or the prefix otherwise.
    /// <para/>
    /// A local names list is also returned.
    /// This is the list of names to be used for the remainder of the trimming process
    /// and contains the trimming name and original name.
    /// </returns>
    protected (string Prefix, List<AugmentedCandidateNames>)? GetPrefix(
        string? container,
        string? hint,
        Dictionary<string, CandidateNames> names,
        Dictionary<string, string>? prefixOverrides,
        HashSet<string>? nonDeterminant,
        bool getTrimmingName,
        bool naive
    )
    {
        // If the type has no members,
        if (names.Count == 0)
        {
            // skip it
            return null;
        }

        // Get the trimming names
        var containerTrimmingName = getTrimmingName
            ? GetTrimmingName(prefixOverrides, container ?? hint ?? string.Empty, true, hint)
            : container ?? hint ?? string.Empty;

        var localNames = names
            .Select(x => new AugmentedCandidateNames(
                x.Value.Primary,
                x.Value.Secondary,
                x.Key,
                getTrimmingName
                    ? GetTrimmingName(prefixOverrides, x.Value.Primary, false, hint)
                    : x.Value.Primary
            ))
            .ToList();

        // Set the prefix to the prefix override for this container, if it exists.
        // This is to allow us to handle poorly/inconsistently named containers,
        // without putting special cases elsewhere in the logic
        // ex: For the enum
        //     enum Things {
        //       ThingsRGB
        //       ThingRGB
        //     }
        // If we specify a prefix override of "Thing",
        // then it will trim ThingsRGB to sRGB and ThingRGB to RGB
        // a case like this is simple to add a special case for in the generator to handle sRGB specially,
        // but see ImageChannelOrder from spirv.h for a more problematic occurrence.
        string prefix;
        if (
            container is not null
            && (prefixOverrides?.TryGetValue(container, out var @override) ?? false)
        )
        {
            // Use the override
            prefix = @override;
        }
        else
        {
            if (names.Count == 1)
            {
                if (!string.IsNullOrWhiteSpace(containerTrimmingName))
                {
                    // Use the member name and its container.
                    prefix = NameUtils.FindCommonPrefix(
                        [
                            names
                                .First(x => !(nonDeterminant?.Contains(x.Key) ?? false))
                                .Value.Primary,
                            containerTrimmingName,
                        ],
                        true,
                        false,
                        naive
                    );
                }
                else
                {
                    // One name. Can't determine prefix.
                    prefix = "";
                }
            }
            else
            {
                // Common case - Find the prefix based on the container's members
                prefix = NameUtils.FindCommonPrefix(
                    localNames
                        .Where(x => !(nonDeterminant?.Contains(x.Original) ?? false))
                        .Select(x => x.TrimmingName)
                        .ToList(),
                    // If naive mode is on and we're trimming type names, allow full matches (method class is
                    // probably the prefix)
                    naive && container is null,
                    false,
                    naive
                );
            }
        }

        // If any of the children's trimming name is shorter than the prefix length,
        if (
            localNames.Any(x =>
                x.TrimmingName.Length <= prefix.Length
                && !(nonDeterminant?.Contains(x.Original) ?? false)
            ) && !string.IsNullOrWhiteSpace(containerTrimmingName)
        )
        {
            // Do a second pass, but put the container name in the loop to see if it makes a difference
            prefix = NameUtils.FindCommonPrefix(
                localNames.Select(x => x.TrimmingName).Append(containerTrimmingName).ToList(),
                // If naive mode is on and we're trimming type names, allow full matches (method class is probably the
                // prefix)
                naive && container is null,
                false,
                naive
            );
        }

        // Iterate through all of the forbidden trimmings,
        foreach (var word in s_forbiddenTrimmings)
        {
            // If the prefix starts with a forbidden trimming,
            if (prefix.StartsWith($"{word}_"))
            {
                // Clear the prefix
                prefix = string.Empty;
            }

            // If the prefix contains the forbidden trimming surrounded by underscores,
            var idx = prefix.IndexOf($"_{word}_", StringComparison.OrdinalIgnoreCase);
            if (idx != -1)
            {
                // Trim the end of the prefix to the start of the forbidden trimming
                // ex:
                //     input prefix = THIS_GL_
                //     forbidden trimming = GL
                //
                //     resulting prefix = THIS
                prefix = prefix[..idx];
            }
        }

        return (prefix, localNames);
    }

    /// <summary>
    /// Gets the name to feed into <see cref="NameUtils"/>.
    /// </summary>
    /// <param name="prefixOverrides">The prefix overrides.</param>
    /// <param name="name">The name to get a trimming name for.</param>
    /// <param name="isContainer">Whether the name passed into <paramref name="name"/> is the container name.</param>
    /// <param name="hint">The global prefix hint.</param>
    /// <returns>The trimming name.</returns>
    public virtual string GetTrimmingName(
        Dictionary<string, string>? prefixOverrides,
        string name,
        bool isContainer,
        string? hint = null
    )
    {
        // If theres a prefix override for this enum,
        if (prefixOverrides?.ContainsKey(name) ?? false)
        {
            // Use the raw native name as the trimming name
            return name;
        }

        if (hint is not null && name.StartsWith(hint, StringComparison.OrdinalIgnoreCase))
        {
            return $"{hint}_{name[hint.Length..].Trim('_').LenientUnderscore()}";
        }

        return name.Trim('_').LenientUnderscore();
    }

    /// <summary>
    /// Similar to <see cref="CandidateNames"/>, but with some additional information.
    /// </summary>
    /// <param name="Primary">The preferred version of the trimmed name.</param>
    /// <param name="Secondary">The fallback versions of the trimmed name in case the primary does not work.</param>
    /// <param name="Original">The original, unmodified name.</param>
    /// <param name="TrimmingName">The name used for trimming purposes.</param>
    protected record struct AugmentedCandidateNames(
        string Primary,
        List<string> Secondary,
        string Original,
        string TrimmingName
    )
    {
        /// <summary>
        /// Formats this instance as a string.
        /// </summary>
        public override string ToString() =>
            $"(Original={Original}, TrimmingName={TrimmingName}, Primary={Primary}, Secondary=[{string.Join(", ", Secondary)}])";
    }
}
