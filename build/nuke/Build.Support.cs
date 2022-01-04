// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using JetBrains.Annotations;
using Microsoft.Build.Locator;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Utilities;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.Tooling.ProcessTasks;

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

    Dictionary<string, string> CreateEnvVarDictionary()
        => Environment.GetEnvironmentVariables()
            .Cast<DictionaryEntry>()
            .ToDictionary(x => (string) x.Key, x => (string) x.Value);

    IProcess InheritedShell(string cmd, [CanBeNull] string workDir = null)
        => OperatingSystem.IsWindows()
            ? StartProcess("powershell", $"-Command {cmd.DoubleQuote()}", workDir, CreateEnvVarDictionary())
            : StartProcess("bash", $"-c {cmd.DoubleQuote()}", workDir, CreateEnvVarDictionary());

    void AddToPath(string dir)
    {
        var pathVar = Environment.GetEnvironmentVariables()
            .Cast<DictionaryEntry>()
            .First(x => ((string) x.Key).Equals("PATH", StringComparison.OrdinalIgnoreCase));
        Environment.SetEnvironmentVariable
        (
            (string) pathVar.Key,
            (string) pathVar.Value + (OperatingSystem.IsWindows() ? $";{dir}" : $":{dir}")
        );
    }

    static void CopyAll(IEnumerable<AbsolutePath> paths, AbsolutePath dir)
    {
        foreach (var path in paths)
        {
            CopyFile(path, dir / Path.GetFileName(path));
        }
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
