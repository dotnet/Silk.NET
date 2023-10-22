using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Humanizer;

namespace SilkTouchX.Naming;

/// <summary>
/// Contains utilities used throughout the naming namespace.
/// </summary>
[SuppressMessage("ReSharper", "LoopCanBeConvertedToQuery")]
public static partial class NameUtils
{
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
                .Transform(new FirstLetterUpper())
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

            foundPrefix = prefix;
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

    internal partial class FirstLetterUpper : ICulturedStringTransformer
    {
        public string Transform(string input) => Transform(input, null);

        public string Transform(string input, CultureInfo? culture)
        {
            culture ??= CultureInfo.CurrentCulture;

            var result = input;
            var matches = Words().Matches(input);
            foreach (Match word in matches)
            {
                //if (!AllCapitals(word.Value))
                {
                    result = MakeFirstLetterUpper(word, result, culture);
                }
            }

            return result;
        }

        private static bool AllCapitals(string input) => input.ToCharArray().All(char.IsUpper);

        private static string MakeFirstLetterUpper(Match word, string source, CultureInfo culture)
        {
            var wordToConvert = word.Value;
            var replacement =
                culture.TextInfo.ToUpper(wordToConvert[0])
                + culture.TextInfo.ToLower(wordToConvert.Remove(0, 1));
            return string.Concat(
                source.AsSpan()[..word.Index],
                replacement,
                source.AsSpan(word.Index + word.Length)
            );
        }

        [GeneratedRegex(@"(\w|[^\u0000-\u007F])+'?\w*")]
        private static partial Regex Words();
    }
}
