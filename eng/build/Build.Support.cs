// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.RegularExpressions;
using Nuke.Common;
using Nuke.Common.ProjectModel;

partial class Build
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode
    public static int Main()
    {
        Environment.SetEnvironmentVariable("NUKE_TELEMETRY_OPTOUT", "1");
        return Execute<Build>(x => x.Compile);
    }

    [GeneratedRegex("refs\\/pull\\/([0-9]+).*", RegexOptions.Compiled)]
    private static partial Regex PrRegex();

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    readonly Configuration Configuration = IsLocalBuild
        ? Configuration.Debug
        : Configuration.Release;

    [Parameter("Extra properties passed to MSBuild commands")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    readonly string[] MsbuildProperties = [];

    [Solution]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    readonly Solution Solution = null!;

    Dictionary<string, object>? _processedMsbuildPropertiesValue;

    Dictionary<string, object> ProcessedMsbuildProperties
    {
        get
        {
            return _processedMsbuildPropertiesValue ??= MsbuildProperties.ToDictionary(
                x => x[..IndexOfOrThrow(x, '=')],
                object (x) =>
                {
                    var idx = IndexOfOrThrow(x, '=');
                    return x.Substring(idx + 1, x.Length - idx - 1);
                }
            );

            static int IndexOfOrThrow(string x, char y)
            {
                var idx = x.IndexOf(y);
                if (idx == -1)
                {
                    throw new ArgumentException();
                }

                return idx;
            }
        }
    }

    // NOTE: this is needed so that NUKE can cross-reference dependencies later.
    readonly ConcurrentDictionary<Target, Target> _targets = new();

    static Target GetEmptyTarget() => x => x.Executes(() => { });

    Target CommonTarget(Target? actualTarget = null) =>
        _targets.GetOrAdd(
            actualTarget ??= GetEmptyTarget(),
            def =>
            {
                def = def.DependsOn(Prerequisites);
                return actualTarget is null ? def : actualTarget(def);
            }
        );
}
