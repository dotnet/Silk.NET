// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Buffers;
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
    /// <summary>
    /// An instance of <see cref="SearchValues{T}"/> matching capital letters and all digits.
    /// </summary>
    public static readonly SearchValues<char> Uppercase = SearchValues.Create(
        "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
    );

    /// <summary>
    /// An instance of <see cref="SearchValues"/> matching all characters that separate words in a C# identifier.
    /// </summary>
    public static readonly SearchValues<char> Separators = SearchValues.Create("_");

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
        var words = BreakIntoWords(identifier);

        // if (identifier.Length == 0)
        // {
        //     throw new InvalidOperationException("Cannot prettify an empty identifier");
        // }
        //
        // var result = identifier.Transform();
        // if (result.Length == 0)
        // {
        //     throw new InvalidOperationException(
        //         $"Prettification for '{identifier}' led to an empty identifier"
        //     );
        // }
        //
        // // Disallow all capitals
        // var resultSpan = result.AsSpan();
        // if (!allowAllCaps && resultSpan.IndexOfAny(NotUppercase) == -1)
        // {
        //     Span<char> caps = stackalloc char[resultSpan.Length - 1];
        //     resultSpan[1..].ToLower(caps, CultureInfo.InvariantCulture);
        //     result = $"{result[0]}{caps}";
        // }
        //
        // return result;

        return $"[{string.Join(", ", words)}] ({longAcronymThreshold})";
    }

    private static List<string> BreakIntoWords(string identifier)
    {
        var words = new List<string>();
        var currentWord = new StringBuilder();

        for (var i = 0; i < identifier.Length; i++)
        {
            var c = identifier[i];

            var isPreviousUpper = i <= 0 || IsUpper(identifier[i - 1]);
            var isPreviousSeparator = i <= 0 || IsSeparator(identifier[i - 1]);

            var isCurrentUpper = IsUpper(c);
            var isCurrentSeparator = IsSeparator(c);

            var isNextUpper = i + 1 >= identifier.Length || IsUpper(identifier[i + 1]);
            var isNextSeparator = i + 1 >= identifier.Length || IsSeparator(identifier[i + 1]);

            switch (i)
            {
                // Handle separators
                case { } when isCurrentSeparator:
                {
                    if (currentWord.Length > 0)
                    {
                        words.Add(currentWord.ToString());
                        currentWord.Clear();
                    }

                    break;
                }

                // TODO: Might not actually be needed
                // Handle end of acronyms
                case { } when isPreviousUpper && isCurrentUpper && !isNextUpper && !isNextSeparator:
                {
                    if (currentWord.Length > 0)
                    {
                        words.Add(currentWord.ToString());
                        currentWord.Clear();
                    }

                    currentWord.Append(c);
                    break;
                }

                // Handle start of new words
                case { } when !isPreviousUpper && isCurrentUpper:
                {
                    if (currentWord.Length > 0)
                    {
                        words.Add(currentWord.ToString());
                        currentWord.Clear();
                    }

                    currentWord.Append(c);
                    break;
                }

                // Default
                case { }:
                {
                    currentWord.Append(c);
                    break;
                }
            }
        }

        if (currentWord.Length > 0)
        {
            words.Add(currentWord.ToString());
            currentWord.Clear();
        }

        return words;
    }

    private static bool IsSeparator(char c) => Separators.Contains(c);

    private static bool IsUpper(char c) => Uppercase.Contains(c);

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
