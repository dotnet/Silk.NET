// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text;

namespace Silk.NET.SilkTouch.Naming;

/// <summary>
/// Contains utilities for splitting names into separate words/fragments.
/// </summary>
public static class NameSplitter
{
    /// <summary>
    /// Splits the given C# identifier into separate words.
    /// </summary>
    /// <remarks>
    /// See the test cases for this method to see examples on how this method behaves.
    /// </remarks>
    /// <param name="identifier">A string that contains only valid C# identifier characters.</param>
    public static List<string> BreakIntoWords(string identifier)
    {
        var words = new List<string>();
        var currentWord = new StringBuilder();

        // Break into words
        for (var i = 0; i < identifier.Length; i++)
        {
            var c = identifier[i];

            var previous =
                i - 1 >= 0 ? NameUtils.GetCharType(identifier[i - 1]) : CharType.Separator;
            var current = NameUtils.GetCharType(c);
            var next =
                i + 1 < identifier.Length
                    ? NameUtils.GetCharType(identifier[i + 1])
                    : CharType.Separator;

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
}
