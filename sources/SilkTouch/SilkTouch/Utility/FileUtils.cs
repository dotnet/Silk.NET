// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.FileSystemGlobbing;

namespace Silk.NET.SilkTouch.Utility
{
    internal static class FileUtils
    {
        internal static string PathFixup(string path)
        {
            if (Path.IsPathFullyQualified(path))
            {
                path = Path.GetRelativePath(Path.GetPathRoot(path)!, path);
            }

            return path.Replace('\\', '/');
        }

        internal static IEnumerable<string> Glob(
            IReadOnlyCollection<string> paths,
            string? cd = null
        )
        {
            cd ??= Environment.CurrentDirectory;
            var matcher = GetGlobMatcher(paths);

            return matcher
                .GetResultsInFullPath(cd)
                .Concat(
                    paths
                        .Select(x => x.StartsWith('!') ? x[1..] : x)
                        .Where(Path.IsPathFullyQualified)
                        .Select(Path.GetPathRoot)
                        .Where(x => x is not null)
                        .Distinct()
                        .SelectMany(x => matcher.GetResultsInFullPath(x!))
                )
                .Concat(paths.Where(File.Exists))
                .Select(x => Path.GetFullPath(x).Replace('\\', '/'))
                .Distinct()
                .ToArray();
        }

        internal static Matcher GetGlobMatcher(IReadOnlyCollection<string> paths)
        {
            var matcher = new Matcher();

            matcher.AddIncludePatterns(paths.Where(x => !x.StartsWith("!")).Select(PathFixup));
            matcher.AddExcludePatterns(
                paths.Where(x => x.StartsWith("!")).Select(x => x[1..]).Select(PathFixup)
            );

            return matcher;
        }
    }
}
