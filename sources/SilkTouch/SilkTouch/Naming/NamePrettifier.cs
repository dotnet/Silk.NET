// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Globalization;

namespace Silk.NET.SilkTouch.Naming;

/// <summary>
/// Prettifies C# identifiers.
/// </summary>
/// <param name="longAcronymThreshold">
/// The threshold at which "consecutive runs of uppercase characters"
/// are considered too long to remain uppercased.
/// <para/>
/// For reference, 2 is the .NET framework design guideline's threshold.
/// See: https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/capitalization-conventions
/// <para/>
/// For example, using 2 would mean that UI remains UI, but XML is output as Xml.
/// </param>
public class NamePrettifier(int longAcronymThreshold)
{
    /// <summary>
    /// Prettifies the given C# identifier.
    /// </summary>
    /// <remarks>
    /// See the test cases for this method to see examples on how this method behaves.
    /// </remarks>
    /// <param name="identifier">A string that contains only valid C# identifier characters.</param>
    /// <param name="allowAllCaps">Whether the output is allowed to be fully capitalised ("all caps").</param>
    /// <returns>The prettified C# identifier.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the input or output is an empty identifier.</exception>
    public string Prettify(string identifier, bool allowAllCaps = false)
    {
        if (identifier.Length == 0)
        {
            throw new InvalidOperationException("Cannot prettify an empty identifier");
        }

        var words = NameSplitter.BreakIntoWords(identifier);

        // Add "X" to separate out numbers
        for (var i = words.Count - 1; i >= 1; i--)
        {
            var startOfCurrent = NameUtils.GetCharType(words[i][0]);
            var endOfPrevious = NameUtils.GetCharType(words[i - 1][^1]);

            if (startOfCurrent is CharType.Number && endOfPrevious is CharType.Number)
            {
                words.Insert(i, "X");
            }
        }

        // Add "X" if first word is a number
        if (words.Count > 0)
        {
            if (NameUtils.GetCharType(words[0][0]) is CharType.Number)
            {
                words.Insert(0, "X");
            }
        }

        // Pretend there is an underscore between each word
        // This is used as a heuristic for determining whether we can treat short, all uppercase words as acronyms
        //
        // Eg: Assuming longAcronymThreshold is 4
        // ["RGBA"] has an effective length of 4 and can be treated as an acronym even though it is fully uppercase
        // "RGBA" remains "RGBA" (but is usually forced back to pascal case due to the allowAllCaps parameter)
        // ["REG", "0"] is also 4 characters, but has an effective length of 5
        // "REG0" therefore becomes "Reg0"
        //
        // Comment from Exanite: This behavior is ported from the original Silk 3 prettifier, which used spaces instead.
        // Since this leads to better behavior, I'm not sure if this was intentionally taken advantage of
        // or a happy accident from using Humanizer's Humanize method.
        var effectiveLength = int.Max(0, words.Count - 1);
        foreach (var word in words)
        {
            effectiveLength += word.Length;
        }

        var isAllNonLower = true;
        foreach (var word in words)
        {
            // Allow lowercase "x" as a special case
            // Eg: GL_COMPRESSED_RGBA_ASTC_4x4_KHR, GL_DOUBLE_MAT2x3_EXT, VK_FORMAT_ASTC_4x4_SRGB_BLOCK
            // These names contain a lowercase "x", but are effectively still
            // fully uppercase for the purpose of identifying acronyms
            if (word != "x" && !IsAllNonLower(word))
            {
                isAllNonLower = false;
            }
        }

        // We can only identify acronyms if the name is not in all caps
        // We make an exception for short identifiers since the entire name might be an acronym
        var canIdentifyAcronyms = !isAllNonLower || effectiveLength <= longAcronymThreshold;

        // Merge "fragments"
        for (var i = words.Count - 1; i >= 1; i--)
        {
            var startOfCurrent = NameUtils.GetCharType(words[i][0]);
            var endOfPrevious = NameUtils.GetCharType(words[i - 1][^1]);

            // Merge numbers into previous non-numbers
            // Eg: [RGB, 16] becomes [RGB16]
            // This affects acronyms since numbers are treated as being part of acronyms in IsAcronym
            if (startOfCurrent is CharType.Number && endOfPrevious is not CharType.Number)
            {
                words[i - 1] += words[i];
                words.RemoveAt(i);
            }
        }

        // Apply pascal casing
        var wasPreviousAcronym = false;
        var didPreviousEndWithUpper = false;
        for (var i = 0; i < words.Count; i++)
        {
            var current = words[i];
            if (canIdentifyAcronyms)
            {
                var isCurrentAcronym = IsAcronym(current, longAcronymThreshold);
                var doesCurrentEndWithUpper = NameUtils.GetCharType(current[^1]) is CharType.Upper;

                try
                {
                    if (isCurrentAcronym)
                    {
                        // Check if previous or next are preserved acronyms
                        //
                        // Eg: For an acronym threshold of 10,
                        // [RGBA, ASTC] should result in [Rgba, Astc] since "RGBAASTC" can be ambiguous to read
                        //
                        // However, [RGBA8, ASTC] should remain [RGBA8, ASTC] since the 8 separates the two acronyms
                        // This means if the previous did not end with an uppercase character,
                        // we can still safely preserve the current acronym
                        var isNextAcronym =
                            i + 1 < words.Count && IsAcronym(words[i + 1], longAcronymThreshold);

                        if (
                            (!wasPreviousAcronym || !didPreviousEndWithUpper)
                            && (!isNextAcronym || !doesCurrentEndWithUpper)
                        )
                        {
                            // Preserve the acronym
                            continue;
                        }
                    }
                }
                finally
                {
                    // Save information about the current word so that we have it for the next word
                    // This is important because we lose it after the current word is modified
                    wasPreviousAcronym = isCurrentAcronym;
                    didPreviousEndWithUpper = doesCurrentEndWithUpper;
                }
            }

            // Apply pascal casing
            words[i] = PascalCaseWord(current);
        }

        // Lowercase "X" if it is between two numbers
        // Eg: [2, X2] becomes [2, x2]
        // "2X2" becomes "2x2"
        for (var i = words.Count - 1; i >= 1; i--)
        {
            var current = words[i];
            if (
                current.Length >= 2
                && current[0] == 'X'
                && NameUtils.GetCharType(current[1]) is CharType.Number
            )
            {
                var endOfPrevious = NameUtils.GetCharType(words[i - 1][^1]);
                if (endOfPrevious is CharType.Number)
                {
                    words[i] = "x" + current[1..];
                }
            }
        }

        var result = string.Join("", words);
        if (result.Length == 0)
        {
            throw new InvalidOperationException(
                $"Prettification for '{identifier}' led to an empty identifier"
            );
        }

        // Disallow all capitals
        var resultSpan = result.AsSpan();
        if (!allowAllCaps && IsAllCaps(result))
        {
            Span<char> caps = stackalloc char[resultSpan.Length - 1];
            resultSpan[1..].ToLower(caps, CultureInfo.InvariantCulture);
            result = $"{result[0]}{caps}";
        }

        return result;
    }

    /// <summary>
    /// Returns whether the word is an acronym or not for the purposes of pascal casing.
    /// If the word is longer than the threshold, it is not considered an acronym.
    /// </summary>
    private static bool IsAcronym(string word, int threshold) =>
        word.Length <= threshold && IsAllNonLower(word);

    /// <summary>
    /// Returns if the word is entirely composed of non-lowercase characters.
    /// Uncategorized characters are considered to be lowercase for this method.
    /// </summary>
    private static bool IsAllNonLower(string word) =>
        !word.Any(c => NameUtils.GetCharType(c) is CharType.Other);

    /// <summary>
    /// Returns if the word is entirely composed of capital letters.
    /// </summary>
    private static bool IsAllCaps(string word) =>
        word.All(c => NameUtils.GetCharType(c) is CharType.Upper);

    /// <summary>
    /// Pascal cases the provided word.
    /// This sets the first character to be uppercase and the rest to be lowercase.
    /// </summary>
    private static string PascalCaseWord(string word)
    {
        var chars = word.ToCharArray();
        chars[0] = char.ToUpper(chars[0]);

        for (var i = 1; i < chars.Length; i++)
        {
            chars[i] = char.ToLower(chars[i]);
        }

        return new string(chars);
    }
}
