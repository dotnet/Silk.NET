// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.Build.Locator;
using Nuke.Common;
using Nuke.Common.CI.GitHubActions;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Utilities;
using Octokit;
using Serilog;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.Tooling.ProcessTasks;
using static Nuke.Common.Tools.DotNet.DotNetTasks;

partial class Build
{
    static readonly Regex PrRegex = new("refs\\/pull\\/([0-9]+).*", RegexOptions.Compiled);

    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode
    public static int Main() => Execute<Build>(x => x.Compile);

    [Nuke.Common.Parameter("Outputs build warnings instead of keeping the MSBuild logging quiet with just errors.")]
    bool Warnings;

    [Parameter("Matrix job argument e.g. a RID for native builds."), CanBeNull]
    string MatrixArg;

    static int IndexOfOrThrow(string x, char y)
    {
        var idx = x.IndexOf(y);
        if (idx == -1)
        {
            throw new ArgumentException();
        }

        return idx;
    }

    Dictionary<string, string> CreateEnvVarDictionary([CanBeNull] IReadOnlyDictionary<string, string> concat = null)
        => Environment.GetEnvironmentVariables()
            .Cast<DictionaryEntry>()
            .Concat((concat ?? Enumerable.Empty<KeyValuePair<string, string>>()).Select(x => new DictionaryEntry(x.Key, x.Value)))
            .ToDictionary(x => (string) x.Key, x => (string) x.Value);

    IProcess InheritedShell(string cmd, [CanBeNull] string workDir = null, [CanBeNull] IReadOnlyDictionary<string, string> envVars = null)
        => OperatingSystem.IsWindows()
            ? StartProcess("powershell", $"-Command {cmd.DoubleQuote()}", workDir, CreateEnvVarDictionary(envVars))
            : StartProcess("bash", $"-c {cmd.DoubleQuote()}", workDir, CreateEnvVarDictionary(envVars));

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
            CopyFile(path, dir / Path.GetFileName(path), FileExistsPolicy.Overwrite);
        }
    }

    [Nuke.Common.Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly string Configuration = IsLocalBuild ? "Debug" : "Release";

    [Nuke.Common.Parameter("Extra properties passed to MSBuild commands")]
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

    Target Prerequisites => _ => _.Executes
    (
        () =>
        {
            try
            {
                if (DotNet("dotnet nuget list source").Any(x => x.Text.Contains("Silk-PushPackages")))
                {
                    DotNet("dotnet nuget remove source \"Silk-PushPackages\"");
                }
            }
            catch
            {
                // probably hasn't existed yet, don't care.
            }
            try
            {
                if (Native)
                {
                    DotNet("workload install android");
                }
            }
            catch
            {
                // oh well. maybe it's already installed?
            }

            GenerateSolution();
        }
    );

    AbsolutePath SourceDirectory => RootDirectory / "src";

    ConcurrentDictionary<Target, Target> Targets = new();
    static Target GetEmptyTarget() => _ => _.Executes(() => { });
    Target CommonTarget([CanBeNull] Target actualTarget = null) => Targets.GetOrAdd
    (
        actualTarget ??= GetEmptyTarget(), def =>
        {
            def = def.DependsOn(Prerequisites);
            return actualTarget is null ? def : actualTarget(def);
        }
    );

    async Task AddOrUpdatePrComment(string type, string file, bool editOnly = false, params KeyValuePair<string, string>[] subs)
    {
        var githubToken = EnvironmentInfo.GetVariable<string>("GITHUB_TOKEN");
        if (string.IsNullOrWhiteSpace(githubToken))
        {
            Log.Information("GitHub token not found, skipping writing a comment.");
            return;
        }

        var @ref = GitHubActions.Instance?.Ref;
        if (string.IsNullOrWhiteSpace(@ref))
        {
            Log.Information("Not running in GitHub Actions, skipping writing a comment.");
            return;
        }

        var prMatch = PrRegex.Match(@ref);
        if (!prMatch.Success || prMatch.Groups.Count < 2)
        {
            Log.Information($"Couldn't match {@ref} to a PR, skipping writing a comment.");
            return;
        }

        if (!int.TryParse(prMatch.Groups[1].Value, out var pr))
        {
            Log.Information($"Couldn't parse {@prMatch.Groups[1].Value} as an int, skipping writing a comment.");
            return;
        }

        var github = new GitHubClient
        (
            new ProductHeaderValue("Silk.NET-CI"),
            new Octokit.Internal.InMemoryCredentialStore(new Credentials(githubToken))
        );

        var existingComment = (await github.Issue.Comment.GetAllForIssue("dotnet", "Silk.NET", pr))
            .FirstOrDefault(x => x.Body.Contains($"`{type}`") && x.User.Name == "github-actions[bot]");
        if (existingComment is null && editOnly)
        {
            Log.Information("Edit only mode is on and no existing comment found, skipping writing a comment.");
            return;
        }

        var commentDir = RootDirectory / "build" / "comments";
        var commentText = await File.ReadAllTextAsync(commentDir / $"{file}.md") +
                          await File.ReadAllTextAsync(commentDir / "footer.md");
        foreach (var (key, value) in subs)
        {
            commentText = commentText.Replace($"{{{key}}}", value);
        }

        commentText = commentText.Replace("{actionsRun}", GitHubActions.Instance?.RunNumber.ToString())
            .Replace("{typeId}", type);

        if (existingComment is not null)
        {
            Log.Information("Updated the comment on the PR.");
            await github.Issue.Comment.Update("dotnet", "Silk.NET", existingComment.Id, commentText);
        }
        else
        {
            Log.Information("Added a comment to the PR.");
            await github.Issue.Comment.Create("dotnet", "Silk.NET", pr, commentText);
        }
    }

    IReadOnlyCollection<Output> ErrorsOnly<T>(Configure<T> settings) where T : ToolSettings, new()
    {
        var toolSettings = settings(new T());
        var arguments = toolSettings.GetProcessArguments();

        var finalArgs = arguments.RenderForExecution();
        if (!Warnings)
        {
            finalArgs += " /clp:errorsonly";
        }

        using var proc = StartProcess
        (
            toolSettings.ProcessToolPath,
            finalArgs,
            toolSettings.ProcessWorkingDirectory,
            toolSettings.ProcessEnvironmentVariables,
            toolSettings.ProcessExecutionTimeout,
            toolSettings.ProcessLogOutput,
            toolSettings.ProcessLogInvocation,
            toolSettings.ProcessCustomLogger,
            arguments.FilterSecrets
        );

        proc.AssertZeroExitCode();
        return proc.Output;
    }
}
