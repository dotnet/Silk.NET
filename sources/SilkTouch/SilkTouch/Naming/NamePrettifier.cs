// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Buffers;
using System.Globalization;
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

        // Add "X" to separate out numbers
        for (var i = words.Count - 1; i >= 1; i--)
        {
            var startOfCurrent = GetCharType(words[i][0]);
            var endOfPrevious = GetCharType(words[i - 1][^1]);

            if (startOfCurrent is CharType.Number && endOfPrevious is CharType.Number)
            {
                words.Insert(i, "X");
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

            // Merge numbers into previous non-numbers
            // Eg: [RGB, 16] becomes [RGB16]
            // This affects acronyms since numbers are treated as being part of acronyms in IsAcronym
            if (startOfCurrent is CharType.Number && endOfPrevious is not CharType.Number)
            {
                words[i - 1] += words[i];
                words.RemoveAt(i);
            }
        }

        // We can't identify acronyms if the name is in all caps,
        // unless it itself is short enough to be an acronym
        var canIdentifyAcronyms =
            !IsAllCaps(identifier) || identifier.Length <= longAcronymThreshold;

        // Apply pascal casing
        var wasPreviousAcronym = false;
        for (var wordI = 0; wordI < words.Count; wordI++)
        {
            var current = words[wordI];
            if (canIdentifyAcronyms)
            {
                var isCurrentAcronym = IsAcronym(current, longAcronymThreshold);
                try
                {
                    if (isCurrentAcronym)
                    {
                        // Check if previous or next are acronyms and if they are also preserved
                        // Eg: [RGBA, ASTC] should result in [Rgba, Astc] since "RGBAASTC" is hard to read
                        var isNextAcronym =
                            wordI + 1 < words.Count
                            && IsAcronym(words[wordI + 1], longAcronymThreshold);

                        // TODO: Temporarily disabled
                        // if (!wasPreviousAcronym && !isNextAcronym)
                        {
                            // Preserve the acronym
                            continue;
                        }
                    }
                }
                finally
                {
                    // Save whether the current word was an acronym or not
                    // This is important since we lose information about the current word after it is modified below
                    wasPreviousAcronym = isCurrentAcronym;
                }
            }

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
        if (!allowAllCaps && IsAllCapsStrict(result))
        {
            Span<char> caps = stackalloc char[resultSpan.Length - 1];
            resultSpan[1..].ToLower(caps, CultureInfo.InvariantCulture);
            result = $"{result[0]}{caps}";
        }

        return result;
    }

    /// <summary>
    /// TODO: Probably move this to a separate class and also needs documentation
    /// </summary>
    /// <param name="identifier"></param>
    /// <returns></returns>
    public static List<string> BreakIntoWords(string identifier)
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
                case { } when previous is CharType.Number && current is not CharType.Number:
                {
                    NewWord();
                    AddCurrent();
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

    private static bool IsAcronym(string word, int threshold) =>
        word.Length <= threshold
        && word.All(c => GetCharType(c) is CharType.Upper or CharType.Number);

    private static bool IsAllCaps(string word) =>
        word.All(c => GetCharType(c) is CharType.Upper or CharType.Number or CharType.Separator);

    // TODO: Rename this or handle this better
    private static bool IsAllCapsStrict(string word) =>
        word.All(c => GetCharType(c) is CharType.Upper);
}
