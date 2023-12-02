using System;
using System.Collections.Generic;
using System.Linq;

namespace Silk.NET.SilkTouch.Workspace;

/// <summary>
/// Contains utilities for working with makefile-style deps files.
/// </summary>
// The logic for picking this file type was because it is the file type that clang natively outputs for its
// compilations, and eventually I want to add support in ClangSharp to mirror this functionality in the clang compiler.
public static class DepsFile
{
    /// <summary>
    /// Reads the given span containing deps file contents.
    /// </summary>
    /// <param name="inputText">The input contents.</param>
    /// <returns>The read input and output files.</returns>
    /// <exception cref="InvalidOperationException">Bad file contents.</exception>
    public static (string[] Inputs, string[] Outputs) Parse(ReadOnlySpan<char> inputText)
    {
        var outputEnd = inputText.LastIndexOf(':');
        if (outputEnd == -1)
        {
            throw new InvalidOperationException(
                "Deps file did not contain ':' - should be in makefile format."
            );
        }

        var outputs = inputText[..outputEnd];
        var inputEnd = inputText.LastIndexOf(';');
        if (inputEnd == -1)
        {
            inputEnd = inputText.Length;
        }

        var inputs = inputText[(outputEnd + 1)..inputEnd];
        return (SplitFiles(inputs).ToArray(), SplitFiles(outputs).ToArray());
        static IEnumerable<string> SplitFiles(ReadOnlySpan<char> text)
        {
            var ret = new List<string>();
            int idx;
            while ((idx = text.IndexOf(' ')) != -1)
            {
                ret.Add(text[..idx].ToString());
                text = text[(idx + 1)..].Trim();
            }

            return ret;
        }
    }

    /// <summary>
    /// Creates the contents of a deps file for the given inputs and outputs.
    /// </summary>
    /// <param name="inputs">Input file names.</param>
    /// <param name="outputs">Output file names.</param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public static string Create(IEnumerable<string> inputs, IEnumerable<string> outputs)
    {
        var ins = string.Join(' ', inputs);
        if (ins.Length == 0)
        {
            ins = ";";
        }

        var outs = string.Join(' ', outputs);
        if (outs.Length == 0)
        {
            throw new InvalidOperationException("Must have at least one output.");
        }
        return $"{outs}: {ins}\n";
    }
}
