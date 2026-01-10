// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Buffers;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

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
    private enum CharType
    {
        /// <summary>
        /// Characters that are capital letters.
        /// </summary>
        Upper,

        /// <summary>
        /// Characters that are digits.
        /// </summary>
        Number,

        /// <summary>
        /// Characters that separate words in C# identifiers.
        /// </summary>
        Separator,

        /// <summary>
        /// All other characters.
        /// Often lowercase letters.
        /// </summary>
        Other,
    }

    /// <summary>
    /// All capital letters.
    /// </summary>
    private static readonly SearchValues<char> UpperChars = SearchValues.Create(
        "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    );

    /// <summary>
    /// All digits.
    /// </summary>
    private static readonly SearchValues<char> NumberChars = SearchValues.Create("0123456789");

    /// <summary>
    /// All characters that separate words in C# identifiers.
    /// </summary>
    private static readonly SearchValues<char> SeparatorChars = SearchValues.Create("_");

    /// <summary>
    /// Prettifies the given C# identifier.
    /// </summary>
    /// <param name="identifier">
    /// The C# identifier to prettify.
    /// Must be a valid identifier for defined behavior.
    /// </param>
    /// <param name="allowAllCaps">Whether the output is allowed to be fully capitalised ("all caps").</param>
    /// <returns>The prettified C# identifier.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the input or output is an empty identifier.</exception>
    public string Prettify(string identifier, bool allowAllCaps = false)
    {
        if (identifier.Length == 0)
        {
            throw new InvalidOperationException("Cannot prettify an empty identifier");
        }

        var words = BreakIntoWords(identifier);

        // Add "x" to separate out numbers
        for (var i = words.Count - 1; i >= 1; i--)
        {
            var startOfCurrent = GetCharType(words[i][0]);
            var endOfPrevious = GetCharType(words[i - 1][^1]);

            if (startOfCurrent is CharType.Number && endOfPrevious is CharType.Number)
            {
                words.Insert(i, "x");
            }
        }

        // Add "X" if first word is a number
        if (words.Count > 0)
        {
            if (GetCharType(words[0][0]) is CharType.Number)
            {
                words.Insert(0, "X");
            }
        }

        // Merge "fragments"
        for (var i = words.Count - 1; i >= 1; i--)
        {
            var startOfCurrent = GetCharType(words[i][0]);
            var endOfPrevious = GetCharType(words[i - 1][^1]);

            // Merge lowercase into previous
            // Eg: [RGB, 16, f] becomes [RGB, 16f]
            // Eg: [RGB, 16, F] remains [RGB, 16, F]
            if (startOfCurrent is CharType.Other && endOfPrevious is CharType.Number)
            {
                words[i - 1] += words[i];
                words.RemoveAt(i);
            }

            // Merge numbers into previous
            // Eg: [RGB, 16] becomes [RGB16]
            if (startOfCurrent is CharType.Number && endOfPrevious is not CharType.Number)
            {
                words[i - 1] += words[i];
                words.RemoveAt(i);
            }
        }

        // Apply pascal casing
        var wasPreviousAcronym = false;
        for (var wordI = 0; wordI < words.Count; wordI++)
        {
            var current = words[wordI];
            var isCurrentAcronym = current.Length <= longAcronymThreshold && IsAcronym(current);
            if (isCurrentAcronym)
            {
                // Check if previous or next are acronyms and if they are also preserved
                // Eg: [RGBA, ASTC] should result in [Rgba, Astc] since "RGBAASTC" is hard to read
                var isNextAcronym =
                    wordI + 1 < words.Count
                    && words[wordI + 1].Length <= longAcronymThreshold
                    && IsAcronym(words[wordI + 1]);

                if (!wasPreviousAcronym && !isNextAcronym)
                {
                    // Preserve the acronym
                    wasPreviousAcronym = true;
                    continue;
                }
            }

            wasPreviousAcronym = isCurrentAcronym;

            // Apply pascal casing
            var chars = current.ToCharArray();
            chars[0] = char.ToUpper(chars[0]);

            for (var charI = 1; charI < chars.Length; charI++)
            {
                chars[charI] = char.ToLower(chars[charI]);
            }

            words[wordI] = new string(chars);
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
        if (!allowAllCaps && resultSpan.IndexOfAny(NameUtils.NotUppercase) == -1)
        {
            Span<char> caps = stackalloc char[resultSpan.Length - 1];
            resultSpan[1..].ToLower(caps, CultureInfo.InvariantCulture);
            result = $"{result[0]}{caps}";
        }

        return result;
    }

    private static List<string> BreakIntoWords(string identifier)
    {
        var words = new List<string>();
        var currentWord = new StringBuilder();

        // Break into words
        for (var i = 0; i < identifier.Length; i++)
        {
            var c = identifier[i];

            var previous = i - 1 >= 0 ? GetCharType(identifier[i - 1]) : CharType.Separator;
            var current = GetCharType(c);
            var next =
                i + 1 < identifier.Length ? GetCharType(identifier[i + 1]) : CharType.Separator;

            // Identify breakpoints within the identifier by examining 3 characters at a time
            switch (i)
            {
                // Split at separators
                case { } when current == CharType.Separator:
                {
                    NewWord();
                    break;
                }

                // Split at end of acronyms
                case { }
                    when previous is CharType.Upper
                        && current is CharType.Upper
                        && next is CharType.Other:
                {
                    NewWord();
                    AddCurrent();
                    break;
                }

                // Split at start of new words
                case { } when previous is not CharType.Upper && current is CharType.Upper:
                {
                    NewWord();
                    AddCurrent();
                    break;
                }

                // Split at start of numbers
                case { } when previous is not CharType.Number && current is CharType.Number:
                {
                    NewWord();
                    AddCurrent();
                    break;
                }

                // Split at end of numbers
                case { } when current is CharType.Number && next is not CharType.Number:
                {
                    AddCurrent();
                    NewWord();
                    break;
                }

                // Default
                case { }:
                {
                    AddCurrent();
                    break;
                }
            }

            continue;

            // Adds the current character to the current word
            void AddCurrent()
            {
                currentWord.Append(c);
            }
        }

        // Flush pending word
        NewWord();

        return words;

        // Starts a new word
        void NewWord()
        {
            if (currentWord.Length > 0)
            {
                words.Add(currentWord.ToString());
                currentWord.Clear();
            }
        }
    }

    private static CharType GetCharType(char c) =>
        c switch
        {
            { } when UpperChars.Contains(c) => CharType.Upper,
            { } when NumberChars.Contains(c) => CharType.Number,
            { } when SeparatorChars.Contains(c) => CharType.Separator,
            _ => CharType.Other,
        };

    private static bool IsAcronym(string word) =>
        word.All(c => GetCharType(c) is CharType.Upper or CharType.Number);

    // public string Transform(string input, CultureInfo? culture)
    // {
    //     var words = RemoveNullOrWhiteSpace(Words().Split(input));
    //     for (var i = 0; i < words.Length; i++)
    //     {
    //         ref var word = ref words[i];
    //         if (
    //             word.Length > longAcronymThreshold
    //             || !AllCapitals(word)
    //             || (
    //                 AllCapitals(input)
    //                 && input.Length > longAcronymThreshold
    //                 && words.Length > 1
    //             )
    //         )
    //         {
    //             word = MakeFirstLetterUpper(word, culture);
    //         }
    //
    //         var previous = i - 1;
    //         if (previous >= 0)
    //         {
    //             if (i > 0 && char.IsDigit(word[0]) && char.IsDigit(words[previous][^1]))
    //             {
    //                 word = $"x{word}";
    //             }
    //
    //             break;
    //         }
    //     }
    //
    //     return string.Join(" ", words);
    // }

    // /// <summary>
    // /// Returns a span without entries that are null or whitespace.
    // /// This is done by sorting those entries to the end of the input span
    // /// and returning the slice that doesn't contain those entries.
    // /// </summary>
    // private static Span<string> RemoveNullOrWhiteSpace(Span<string> values)
    // {
    //     values.Sort(
    //         static (a, b) =>
    //             string.IsNullOrWhiteSpace(a).CompareTo(string.IsNullOrWhiteSpace(b))
    //     );
    //
    //     for (var i = 0; i < values.Length; i++)
    //     {
    //         if (string.IsNullOrWhiteSpace(values[i]))
    //         {
    //             return values[..i];
    //         }
    //     }
    //
    //     return values;
    // }
    //
    // private static bool AllCapitals(string input) =>
    //     input.ToCharArray().All(x => char.IsUpper(x) || !char.IsLetter(x));
    //
    // private static string MakeFirstLetterUpper(string wordToConvert, CultureInfo culture)
    // {
    //     var nextLetter = wordToConvert.TakeWhile(char.IsDigit).Count() + 1;
    //     if (nextLetter > wordToConvert.Length)
    //     {
    //         // It's not a word?
    //         return wordToConvert;
    //     }
    //
    //     return culture.TextInfo.ToUpper(wordToConvert[..nextLetter])
    //         + culture.TextInfo.ToLower(wordToConvert.Remove(0, nextLetter));
    // }
    //
    // // https://chat.openai.com/share/f5eb195b-96a4-4f0f-955b-9d08b976a955
    // // https://chat.openai.com/share/8d3f2ec4-7eec-4dbd-a01e-a8d73e885964
    // [GeneratedRegex(@"(?<=\D)(?=\d)|(?<=\d)(?=\D)|\W+")]
    // private static partial Regex Words();
}
