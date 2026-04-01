using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Mods;
using Silk.NET.SilkTouch.Mods.LocationTransformation;

namespace Silk.NET.SilkTouch.Naming;

/// <summary>
/// Contains utilities used throughout the naming namespace.
/// </summary>
[SuppressMessage("ReSharper", "LoopCanBeConvertedToQuery")]
public static class NameUtils
{
    /// <summary>
    /// All capital letters.
    /// </summary>
    public static readonly SearchValues<char> UpperChars = SearchValues.Create(
        "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    );

    /// <summary>
    /// All digits.
    /// </summary>
    public static readonly SearchValues<char> NumberChars = SearchValues.Create("0123456789");

    /// <summary>
    /// All characters that separate words in C# identifiers.
    /// </summary>
    public static readonly SearchValues<char> SeparatorChars = SearchValues.Create("_");

    /// <summary>
    /// ASCII letters, numbers, and an underscore.
    /// </summary>
    public static readonly SearchValues<char> IdentifierChars = SearchValues.Create(
        "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_"
    );

    /// <summary>
    /// Prefixes the given identifier with the specified prefix if it starts with a number.
    /// </summary>
    public static string PrefixIfStartsWithNumber(string identifier, string prefix = "X")
    {
        if (identifier.Length > 0 && char.IsDigit(identifier[0]))
        {
            return $"X{identifier}";
        }

        return identifier;
    }

    /// <summary>
    /// Gets the char type for the specified character according
    /// to the categorization defined by <see cref="CharType"/>.
    /// </summary>
    public static CharType GetCharType(char c) =>
        c switch
        {
            { } when UpperChars.Contains(c) => CharType.Upper,
            { } when NumberChars.Contains(c) => CharType.Number,
            { } when SeparatorChars.Contains(c) => CharType.Separator,
            _ => CharType.Other,
        };

    /// <summary>
    /// Finds a common prefix in a set of names with respect to the word boundaries
    /// </summary>
    /// <param name="names">Set of names, snake_case</param>
    /// <param name="allowFullMatch">Allows result to be a full match with one of the names</param>
    /// <param name="allowLeadingDigits">Allows remainder tokens to start with a digit</param>
    /// <param name="naive">
    /// Just match the start of the strings, don't bother checking for obvious name separation gaps.
    /// </param>
    /// <returns>String that is common between all provided names</returns>
    public static string FindCommonPrefix(
        IReadOnlyCollection<string> names,
        bool allowFullMatch,
        bool allowLeadingDigits,
        bool naive = false
    )
    {
        if (names.Count == 0)
        {
            return "";
        }

        if (allowFullMatch && names.Count == 1)
        {
            return names.First();
        }

        var commonPrefixFirstPass = FindCommonPrefix(
            names,
            allowFullMatch,
            names.Max(x => x.Length),
            naive
        );
        if (allowLeadingDigits)
        {
            return commonPrefixFirstPass;
        }

        var tgtPos = commonPrefixFirstPass.Length;

        var startingWithDigit = names.Where(n => n.Length > tgtPos && char.IsDigit(n[tgtPos]));
        return startingWithDigit.Any()
            ? FindCommonPrefix(names, allowFullMatch, tgtPos - 1, naive)
            : commonPrefixFirstPass;
    }

    /// <summary>
    /// Finds a common prefix in a set of names with respect to the word boundaries
    /// </summary>
    /// <param name="names">Set of names, snake_case</param>
    /// <param name="allowFullMatch">Allows result to be a full match with one of the names</param>
    /// <param name="maxLen">Match length limit</param>
    /// <param name="naive">
    /// Just match the start of the strings, don't bother checking for obvious name separation gaps.
    /// </param>
    /// <returns>String that is common between all provided names</returns>
    public static string FindCommonPrefix(
        IReadOnlyCollection<string> names,
        bool allowFullMatch,
        int maxLen,
        bool naive = false
    )
    {
        if (names.Count == 0)
        {
            return "";
        }

        var pos = 0;
        var foundPrefix = "";
        var minLen = names.Min(x => x.Length);
        var found = false;
        var firstName = names.First();
        while (!found)
        {
            pos++;
            if (pos > (naive ? maxLen : maxLen - 1) || pos > (naive ? minLen : firstName.Length))
            {
                break;
            }

            var prefix = firstName[..pos];
            foreach (var name in names)
            {
                if (name.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                found = true;
                break;
            }

            if (pos > 1 && !found) // if pos is smaller, that means we haven't even done a full loop yet and already tripped up.
            {
                foundPrefix = prefix;
            }
        }

        if (!naive && !foundPrefix.Contains('_'))
        {
            return "";
        }

        if (foundPrefix.Length == minLen && allowFullMatch)
        {
            return foundPrefix;
        }

        // @Perksey says: Originally I added a -1 here in the naive case in #2020 because it felt like it was wrong
        // (why would we want the prefix to be equal to something we *know* isn't applicable to all
        // names?) and was producing one specific bad result for which there is now a regression test.
        // If this is having catastrophic impacts on other bindings then please reverse this change and
        // find a smarter fix.
        //
        // It turns out however there were other cases where this wasn't doing what it should, for instance finding the
        // prefix between Silk.NET.SDL and Silk.NET.SDL with allowFullMatch set (i.e. the result should be Silk.NET.SDL)
        // so instead a naive case was added in the while loop itself, changing to
        // `if (pos > (naive ? maxLen : maxLen - 1)...` so that it should hopefully have the same effect and then some.
        // This was done in #2207. I guess this was the smarter fix my previous comment was talking about.
        return foundPrefix[..(naive ? foundPrefix.Length : foundPrefix.LastIndexOf('_') + 1)];
    }

    /// <summary>
    /// Rename all symbols with the given new names
    /// </summary>
    /// <param name="ctx">Mod context to use</param>
    /// <param name="toRename">list of symbols to rename with new names</param>
    /// <param name="ct">cancellation token</param>
    /// <param name="logger">logger</param>
    public static async Task RenameAllAsync(
        IModContext ctx,
        IEnumerable<(ISymbol Symbol, string NewName)> toRename,
        ILogger? logger = null,
        CancellationToken ct = default
    )
    {
        var newNames = toRename.ToList();
        await LocationTransformationUtils.ModifyAllReferencesAsync(
            ctx,
            newNames.Select(x => x.Symbol),
            [new IdentifierRenamingTransformer(newNames)],
            logger,
            ct
        );
    }
}
