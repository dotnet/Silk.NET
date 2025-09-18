﻿using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Silk.NET.SilkTouch.Clang;

/// <summary>
/// Resolver for the C standard include paths on UNIX-like systems.
/// </summary>
public partial class UnixStdIncludeResolver : IStdIncludeResolver
{
    private string[]? _ret = null;

    /// <inheritdoc />
    public IEnumerable<string> GetStandardIncludes() =>
        _ret ??= CoreGetStandardIncludes().ToArray();

    /// <inheritdoc cref="GetStandardIncludes" />
    protected virtual IEnumerable<string> CoreGetStandardIncludes()
    {
        // Add standard include directories
        yield return "-I/usr/include";
        yield return "-I/usr/local/include";

        // Attempt to find and add clang include folder
        if (Directory.Exists("/usr/lib/clang/"))
        {
            var clangIncludeFolder = Directory.GetDirectories("/usr/lib/clang/", "*", SearchOption.AllDirectories)
                .Select(path => ClangIncludeFolderRegex().Match(path))
                .Where(match => match.Success)
                // Select the latest version
                .OrderByDescending(match => int.Parse(match.Groups["Version"].Value))
                .FirstOrDefault()
                ?.Value;

            if (clangIncludeFolder != null)
            {
                yield return $"-I{clangIncludeFolder}";
            }
        }

    }

    [GeneratedRegex("^/usr/lib/clang/(?<Version>\\d+)/include$")]
    private static partial Regex ClangIncludeFolderRegex();
}
