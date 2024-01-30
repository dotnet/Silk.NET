﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Humanizer;

namespace Silk.NET.SilkTouch.Naming;

/// <summary>
/// Contains utilities used throughout the naming namespace.
/// </summary>
[SuppressMessage("ReSharper", "LoopCanBeConvertedToQuery")]
public static partial class NameUtils
{
    private const int LongAcronymThreshold = 4;

    /// <summary>
    /// Prettifies the given string.
    /// </summary>
    /// <param name="str">The string to prettify.</param>
    /// <returns>The pretty string.</returns>
    public static string Prettify(this string str)
    {
        var ret = string.Join(
            null,
            str.LenientUnderscore()
                .Humanize()
                .Transform(new NameTransformer())
                .Pascalize()
                .Where(x => char.IsLetter(x) || char.IsNumber(x))
        );
        return !char.IsLetter(ret[0]) ? $"X{ret}" : ret;
    }

    /// <summary>
    /// Finds a common prefix in a set of names with respect to the word boundaries
    /// </summary>
    /// <param name="names">Set of names, snake_case</param>
    /// <param name="allowFullMatch">Allows result to be a a full match with one of the names</param>
    /// <param name="allowLeadingDigits">Allows remainder tokens to start with a digit</param>
    /// <param name="naive">
    /// Just match the start of the strings, don't bother checking for obvious name separation gaps.
    /// </param>
    /// <returns>String that is common between all provided names</returns>
    public static string FindCommonPrefix(
        List<string> names,
        bool allowFullMatch,
        bool allowLeadingDigits,
        bool naive = false
    )
    {
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
    /// <param name="allowFullMatch">Allows result to be a a full match with one of the names</param>
    /// <param name="maxLen">Match length limit</param>
    /// <param name="naive">
    /// Just match the start of the strings, don't bother checking for obvious name separation gaps.
    /// </param>
    /// <returns>String that is common between all provided names</returns>
    public static string FindCommonPrefix(
        List<string> names,
        bool allowFullMatch,
        int maxLen,
        bool naive = false
    )
    {
        var pos = 0;
        var foundPrefix = "";
        var minLen = names.Min(x => x.Length);
        var found = false;
        while (!found)
        {
            pos++;
            if (pos >= maxLen || pos > (naive ? minLen : names[0].Length))
            {
                break;
            }

            var prefix = names[0][..pos];
            foreach (var name in names.Skip(1))
            {
                if (name.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                found = true;
                break;
            }

            if (pos > 1) // if pos is smaller, that means we haven't even done a full loop yet and already tripped up.
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

        return foundPrefix[..(naive ? foundPrefix.Length : foundPrefix.LastIndexOf('_') + 1)];
    }

    /// <summary>
    /// Separates the input words with underscore
    /// </summary>
    /// <param name="input">The string to be underscored</param>
    /// <returns></returns>
    public static string LenientUnderscore(this string input) =>
        // This is a modified version of Humanizer's Underscore methods with the following changes:
        // - The regex ([\p{Ll}\d])([\p{Lu}]) has been replaced with
        //   ([\p{Ll}\d])(?=[\p{Lu}][\p{Lu}\p{Ll}])([\p{Lu}]) - In this regex, the positive lookahead assertion
        //   (?=[\p{Lu}][\p{Lu}\p{Ll}]) ensures that the next character after the match is an uppercase letter,
        //   followed by any letter (uppercase or lowercase). This will only match if the 2nd character after the
        //   initial match is uppercase. That was suggested by ChatGPT, a human had to add the final
        //   [\p{Ll}])([\p{Lu}]) to ensure we don't erroneous match non-pascal case strings and to capture the
        //   second character to ensure we can do the replacement. Still pretty smart though.
        // - The final ToLower has been omitted as it was not deemed necessary
        // - The regex ([\p{Ll}])([\p{Lu}]) has been added to replace lowercase letters followed by an uppercase letter with the
        //   same sequence but with an underscore inbetween,
        //   this fixes cases like SpvImageFormatR32ui being Spv_Image_FormatR32ui instead of Spv_Image_Format_R32ui
        KebabOrSpace()
            .Replace(
                LowerUpper()
                    .Replace(
                        LowerUpperAnyUpper()
                            .Replace(LowerUpperLower().Replace(input, "$1_$2"), "$1_$2"),
                        "$1_$2"
                    ),
                "_"
            );

    [GeneratedRegex(@"[-\s]")]
    private static partial Regex KebabOrSpace();

    [GeneratedRegex(@"([\p{Ll}])([\p{Lu}])")]
    private static partial Regex LowerUpper();

    [GeneratedRegex(@"([\p{Ll}])(?=[\p{Lu}][\p{Lu}\p{Ll}])([\p{Lu}])")]
    private static partial Regex LowerUpperAnyUpper();

    [GeneratedRegex(@"([\p{Lu}]+)([\p{Lu}][\p{Ll}])")]
    private static partial Regex LowerUpperLower();

    internal partial class NameTransformer : ICulturedStringTransformer
    {
        public string Transform(string input) => Transform(input, null);

        public string Transform(string input, CultureInfo? culture)
        {
            culture ??= CultureInfo.CurrentCulture;

            var matches = Words().Split(input);
            for (var i = 0; i < matches.Length; i++)
            {
                ref var word = ref matches[i];
                if (string.IsNullOrWhiteSpace(word))
                {
                    continue;
                }
                if (word.Length > LongAcronymThreshold || !AllCapitals(word) ||
                    (AllCapitals(input) && input.Length > LongAcronymThreshold && matches.Length > 1))
                {
                    word = MakeFirstLetterUpper(word, culture);
                }

                for (var j = i - 1; j >= 0; j--)
                {
                    if (string.IsNullOrWhiteSpace(matches[j]))
                    {
                        continue;
                    }
                    if (i > 0 && char.IsDigit(word[0]) && char.IsDigit(matches[j][^1]))
                    {
                        word = $"x{word}";
                    }

                    break;
                }
            }

            return string.Join(" ", matches);
        }

        private static bool AllCapitals(string input) =>
            input.ToCharArray().All(x => char.IsUpper(x) || !char.IsLetter(x));

        private static string MakeFirstLetterUpper(string wordToConvert, CultureInfo culture)
        {
            var nextLetter = wordToConvert.TakeWhile(char.IsDigit).Count() + 1;
            if (nextLetter > wordToConvert.Length)
            {
                // It's not a word?
                return wordToConvert;
            }

            return
                culture.TextInfo.ToUpper(wordToConvert[..nextLetter])
                + culture.TextInfo.ToLower(wordToConvert.Remove(0, nextLetter));
        }

        // https://chat.openai.com/share/f5eb195b-96a4-4f0f-955b-9d08b976a955
        // https://chat.openai.com/share/8d3f2ec4-7eec-4dbd-a01e-a8d73e885964
        [GeneratedRegex(@"(?<=\D)(?=\d)|(?<=\d)(?=\D)|\W+")]
        private static partial Regex Words();
    }
}