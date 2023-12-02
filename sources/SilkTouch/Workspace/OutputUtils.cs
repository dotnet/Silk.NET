using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CSharpier;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Silk.NET.SilkTouch.Workspace;

/// <summary>
/// Utilities for the output namespace.
/// </summary>
public static class OutputUtils
{
    /// <summary>
    /// Prettifies the given syntax tree using <see cref="CSharpier"/> if possible, otherwise uses Roslyn to normalize
    /// the whitespace.
    /// </summary>
    /// <param name="root">The root of the syntax tree.</param>
    /// <param name="ct">A cancellation token.</param>
    /// <returns>An asynchronous task returning the string.</returns>
    public static async Task<string> ToNormalisedString(
        this SyntaxNode root,
        CancellationToken ct = default
    )
    {
        var result = await CodeFormatter.FormatAsync(
            root.NormalizeWhitespace().SyntaxTree,
            new CodeFormatterOptions(),
            ct
        );
        return !result.CompilationErrors.Any()
            ? result.Code
            : root.NormalizeWhitespace().ToFullString();
    }
}
