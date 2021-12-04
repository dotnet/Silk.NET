// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Microsoft.Build.Locator;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;

partial class Build
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode
    public static int Main() => Execute<Build>(x => x.Compile);
    static int IndexOfOrThrow(string x, char y)
    {
        var idx = x.IndexOf(y);
        if (idx == -1)
        {
            throw new ArgumentException();
        }

        return idx;
    }

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly string Configuration = IsLocalBuild ? "Debug" : "Release";

    [Parameter("Extra properties passed to MSBuild commands")]
    readonly string[] MsbuildProperties = Array.Empty<string>();

    [Solution] readonly Solution OriginalSolution;

    bool HasProcessedProperties { get; set; }

    Dictionary<string, object> ProcessedMsbuildPropertiesValue;

    Dictionary<string, object> ProcessedMsbuildProperties
    {
        get
        {
            if (!HasProcessedProperties)
            {
                ProcessedMsbuildPropertiesValue = MsbuildProperties.ToDictionary
                (
                    x => x.Substring(0, IndexOfOrThrow(x, '=')), x =>
                    {
                        var idx = IndexOfOrThrow(x, '=');
                        return (object) x.Substring(idx + 1, x.Length - idx - 1);
                    }
                );
            }

            return ProcessedMsbuildPropertiesValue;
        }
    }

    Target Prerequisites => _ => _.Executes(GenerateSolution);

    AbsolutePath SourceDirectory => RootDirectory / "src";
    
    ConcurrentDictionary<Target, Target> Targets = new();
    static Target GetEmptyTarget() => _ => _.Executes(() => {});
    Target CommonTarget([CanBeNull] Target actualTarget = null) => Targets.GetOrAdd
    (
        actualTarget ??= GetEmptyTarget(), def =>
        {
            def = def.DependsOn(Prerequisites);
            return actualTarget is null ? def : actualTarget(def);
        }
    );
}
