using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SilkTouchX.Naming;

/// <summary>
/// The default name trimmer ported from Silk.NET 2.18 with modifications for 3.0.
/// </summary>
public class NameTrimmer : INameTrimmer
{
    /// <inheritdoc />
    public virtual Version Version => new(3, 0);

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
    public void Trim(
        string? container,
        string? hint,
        Dictionary<string, (string Primary, List<string>? Secondary)>? names,
        Dictionary<string, string>? prefixOverrides
    )
    {
        string prefix = null!;
        Dictionary<string, (string Primary, List<string>? Secondary, string Original)> localNames =
            null!;
        var nPasses = HasRawPass
            ? HasNaivePass
                ? 3
                : 2
            : 1;
        for (var i = 0; i < nPasses; i++) // try with both trimming name and non trimming name
        {
            var result = GetPrefix(container, hint, names, prefixOverrides, i == 0, i == 2);
            if (result is null || names is null)
            {
                // skip outright.
                return;
            }

            (prefix, localNames) = result.Value;

            // If we have found a prefix,
            if (prefix.Length > 0 && prefix.Length < localNames.Keys.Min(x => x.Length))
            {
                // break and use it for trimming!
                break;
            }

            // If not, do they at least start with the hint?
            if (
                hint is null
                || !localNames.Keys.All(x => x.StartsWith(hint, StringComparison.OrdinalIgnoreCase))
            )
            {
                // Nope, nothing we can do it seems, we've already tried both trimming name and non trimming name...
                continue;
            }

            // The prefix is the hint!
            prefix = hint;
            break;
        }

        foreach (var (trimmingName, (oldPrimary, secondary, originalName)) in localNames)
        {
            if (prefix.Length >= trimmingName.Length)
            {
                continue;
            }
            var sec = secondary ?? new List<string>();
            sec.Add(oldPrimary);
            names![originalName] = (trimmingName[prefix.Length..], sec);
        }
    }

    /// <summary>
    /// Gets the prefix for the given constituents of the given container.
    /// </summary>
    /// <param name="container">The container name if applicable.</param>
    /// <param name="hint">The global prefix hint if applicable.</param>
    /// <param name="names">The names to get a prefix for.</param>
    /// <param name="prefixOverrides">Prefix overrides.</param>
    /// <param name="getTrimmingName">
    /// Whether to use <see cref="GetTrimmingName"/> or to use the native name as-is.
    /// </param>
    /// <param name="naive">
    /// Just match the start of the strings, don't bother checking for obvious name separation gaps.
    /// </param>
    /// <returns>
    /// Null to skip this container outright, empty if no prefix was found, or the prefix otherwise.
    /// Returns the local names dictionary alongside it as well. That is, the mapping of the results of
    /// <see cref="GetTrimmingName"/> to the new name.
    /// </returns>
    protected (
        string Prefix,
        Dictionary<string, (string Primary, List<string>? Secondary, string Original)>
    )? GetPrefix(
        string? container,
        string? hint,
        Dictionary<string, (string Primary, List<string>? Secondary)>? names,
        Dictionary<string, string>? prefixOverrides,
        bool getTrimmingName,
        bool naive
    )
    {
        // If the type has no members,
        if (names is null || names.Count == 0)
        {
            // skip it
            return null;
        }

        // Get the trimming names
        var containerTrimmingName = getTrimmingName
            ? GetTrimmingName(prefixOverrides, container ?? hint ?? string.Empty, true)
            : container ?? hint ?? string.Empty;
        var localNames = names.ToDictionary(
            x => getTrimmingName ? GetTrimmingName(prefixOverrides, x.Key, false) : x.Key,
            x => (x.Value.Primary, x.Value.Secondary, x.Key)
        );

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
        var prefix =
            container is not null
            && (prefixOverrides?.TryGetValue(container, out var @override) ?? false)
                ? @override
                : names.Count == 1 && !string.IsNullOrWhiteSpace(containerTrimmingName)
                    ? NameUtils.FindCommonPrefix(
                        new List<string> { names.Keys.First(), containerTrimmingName },
                        true,
                        false,
                        naive
                    )
                    : NameUtils.FindCommonPrefix(
                        localNames.Keys.ToList(),
                        // If naive mode is on and we're trimming type names, allow full matches (method class is
                        // probably the prefix)
                        naive && container is null,
                        false,
                        naive
                    );

        // If any of the children's trimming name is shorter than the prefix length,
        if (
            localNames.Keys.Any(x => x.Length <= prefix.Length)
            && !string.IsNullOrWhiteSpace(containerTrimmingName)
        )
        {
            // Do a second pass, but put the container name in the loop to see if it makes a difference
            prefix = NameUtils.FindCommonPrefix(
                localNames.Keys.Concat(Enumerable.Repeat(containerTrimmingName, 1)).ToList(),
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
                //     word = GL
                //     prefix = THIS_GL_
                //
                //     it makes prefix = THIS
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
    /// <returns>The trimming name.</returns>
    protected virtual string GetTrimmingName(
        Dictionary<string, string>? prefixOverrides,
        string name,
        bool isContainer
    )
    {
        // If theres a prefix override for this enum,
        if (prefixOverrides?.ContainsKey(name) ?? false)
        {
            // Use the raw native name as the trimming name
            return name;
        }

        return name.LenientUnderscore();
    }
}
