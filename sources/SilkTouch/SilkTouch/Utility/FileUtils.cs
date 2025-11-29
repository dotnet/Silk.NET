// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;
using Microsoft.Extensions.FileSystemGlobbing;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Converters;

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

        internal static string GlobToRegexInput(string glob)
        {
            return glob.Replace("*", "**").Replace("****", "(.*)").Replace("/", "./").Replace("\\", @"[\/\\]").Replace("./", @"[\/\\]").Replace("**", @"([^\/\\]*)");
        }

        internal static string GlobToRegexOutput(string glob)
        {
            int index = 1;
            return glob.Split("**")
                .SelectMany(split => split.Split('*'))
                .Aggregate((s1, s2) => $"{s1}${index++}{s2}");
        }

        internal static bool ImportIfRegexMatches(Dictionary<Regex, string> regexConverters, string filePath, bool isTest, string? relativeKey,
            ConcurrentDictionary<string, SyntaxTree> aggregatedTests, ConcurrentDictionary<string, SyntaxTree> aggregatedSources,
            ILogger? logger = null, Stream ? fallbackStream = null)
        {
            bool matchFound = false;
            bool regexKey = relativeKey is null;
            foreach (var regex in regexConverters)
            {
                if (regexKey)
                {
                    string outputLocation = regex.Key.Replace(filePath, regex.Value);
                    isTest = outputLocation.StartsWith("tests/");
                    outputLocation = outputLocation.Remove(
                        0,
                        outputLocation.IndexOf(isTest ? "tests/" : "sources/")
                    );
                    relativeKey = outputLocation.Remove(0, isTest ? 6 : 8);
                }

                if (regex.Key.Match(filePath).Success)
                {
                    fallbackStream = File.OpenRead(regexKey ? filePath : regex.Key.Replace(filePath, regex.Value));
                    matchFound = true;
                }
            }

            if (fallbackStream is null || relativeKey is null)
            {
                return matchFound;
            }

            if (!(isTest ? aggregatedTests : aggregatedSources).TryAdd(
                            relativeKey,
                             CSharpSyntaxTree.ParseText(
                                SourceText.From(fallbackStream),
                                path: relativeKey
                            )
                        )
                    )
            {
                logger?.LogError(
                    "Failed to add {0} - are the response file outputs conflicting?",
                    relativeKey
                );
            }
            else
            {
                logger?.LogTrace("Manual file imported {0}", relativeKey);
            }
            return matchFound;
        }
    }
}
