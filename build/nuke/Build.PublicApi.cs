// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.IO;
using System.Linq;
using Nuke.Common;
using Nuke.Common.CI.GitHubActions;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using Octokit;
using Octokit.Internal;
using Serilog;
using static Nuke.Common.Tools.Git.GitTasks;
using static Nuke.Common.Tooling.ProcessTasks;
using static Nuke.Common.Tools.DotNet.DotNetTasks;

partial class Build
{
    const string DefaultFormatCmd = "dotnet format";
    string FormatCmd
    {
        get
        {
            // hack to use the dotnet-format NOT included with the SDK if it's available. this is useful if the one
            // that's shipped with the SDK is bugged.
            var process = OperatingSystem.IsWindows()
                ? InheritedShell("cmd /c where dotnet-format")
                : InheritedShell("whereis dotnet-format");
            process.AssertWaitForExit();
            if (process.ExitCode == 1)
            {
                return DefaultFormatCmd;
            }

            var path = process.Output.FirstOrDefault(x => !string.IsNullOrWhiteSpace(x.Text)).Text;
            if (path is null)
            {
                return DefaultFormatCmd;
            }

            const string startsWith = "dotnet-format:";
            if (path.StartsWith(startsWith))
            {
                path = path[startsWith.Length..].Trim();
            }

            var split = path.Split(' ');
            for (var i = 1; i <= split.Length; i++)
            {
                var candidatePath = string.Join(' ', split[..i]).Trim();
                if (File.Exists(candidatePath))
                {
                    var preface = OperatingSystem.IsWindows() ? "& " : string.Empty;
                    return $"{preface}\"{candidatePath}\"";
                }
            }

            return DefaultFormatCmd;
        }
    }
    string FormatDeclCmd => $"{FormatCmd} analyzers {{0}} --diagnostics=RS0016 --severity=error -v=diag --include-generated";

    Target ShipApi => CommonTarget
    (
        x => x.Executes
        (
            () =>
            {
                foreach (var unshippedFile in RootDirectory.GlobFiles("**/PublicAPI.Unshipped.txt"))
                {
                    var shippedFile = unshippedFile.Parent / "PublicAPI.Shipped.txt";
                    if (!File.Exists(shippedFile))
                    {
                        // common.props should've made this file, so if it's not here then i'm guessing this isn't a
                        // public api after all.
                        continue;
                    }

                    var shippedLines = File.ReadAllLines(shippedFile).ToList();
                    var unshippedLines = File.ReadAllLines(unshippedFile).ToList();
                    for (var i = 0; i < unshippedLines.Count; i++)
                    {
                        var unshippedLine = unshippedLines[i];
                        if (unshippedLine.StartsWith("//") || unshippedLine.StartsWith("#"))
                        {
                            continue;
                        }

                        if (!shippedLines.Contains(unshippedLine))
                        {
                            shippedLines.Add(unshippedLine);
                        }

                        unshippedLines.RemoveAt(i);
                        i--; // so we don't skip the next element
                    }

                    File.WriteAllLines(unshippedFile, unshippedLines);
                    File.WriteAllLines(shippedFile, shippedLines);
                }

                MakePr();
            }
        )
    );

    Target DeclareApi => CommonTarget
    (
        x => x.Executes
        (
            () => InheritedShell(string.Format(FormatDeclCmd, "Silk.NET.sln"))
                .AssertZeroExitCode()
        )
    );

    Target EnsureApiDeclared => CommonTarget
    (
        x => x.Executes
        (
            async () =>
            {
                try
                {
                    var cmd = string.Format
                    (
                        FormatDeclCmd,
                        GitHubActions.Instance.Ref?.Contains("/pull/") ?? false
                            ? "inbound_pr/Silk.NET.sln"
                            : "Silk.NET.sln"
                    );

                    // I have no trust of incoming code, so let's take the github token away from them before they think
                    // about adding dodgy MSBuild targets that could swipe it
                    var githubToken = EnvironmentInfo.GetVariable<string>("GITHUB_TOKEN");
                    EnvironmentInfo.SetVariable("GITHUB_TOKEN", string.Empty);

                    // run the format command
                    InheritedShell($"{cmd} --verify-no-changes").AssertZeroExitCode();

                    // add our github token back
                    EnvironmentInfo.SetVariable("GITHUB_TOKEN", githubToken);
                    await AddOrUpdatePrComment("public_api", "public_api_declared", true);
                }
                catch (ProcessException)
                {
                    await AddOrUpdatePrComment("public_api", "public_api_not_declared");
                    throw;
                }
            }
        )
    );

    void MakePr()
    {
        var pushableToken = EnvironmentInfo.GetVariable<string>("PUSHABLE_GITHUB_TOKEN");
        var curBranch = GitCurrentBranch(RootDirectory);
        if (GitHubActions.Instance?.Repository == "dotnet/Silk.NET" &&
            !string.IsNullOrWhiteSpace(pushableToken))
        {
            if (curBranch == "HEAD" || string.IsNullOrWhiteSpace(curBranch))
            {
                curBranch = "main"; // not a good assumption to make, but fine for now for our purposes
                // (tags are created from main usually)
            }

            // it's assumed that the pushable token was used to checkout the repo
            Git("fetch --all", RootDirectory);
            Git("pull");
            Git("add **/PublicAPI.*.txt", RootDirectory);
            var newBranch = $"ci/{curBranch}/ship_apis";
            var curCommit = GitCurrentCommit(RootDirectory);
            var commitCmd = StartProcess
                (
                    $"git commit -m \"Move unshipped APIs to shipped\""
                )
                .AssertWaitForExit();
            if (!commitCmd.Output.Any(x => x.Text.Contains("nothing to commit", StringComparison.OrdinalIgnoreCase)))
            {
                commitCmd.AssertZeroExitCode();
            }

            // ensure there are no other changes
            Git("checkout HEAD .nuke/", RootDirectory);
            Git("reset --hard", RootDirectory);
            if (GitCurrentCommit(RootDirectory) != curCommit) // might get "nothing to commit", you never know...
            {
                Log.Information("Checking for existing branch...");
                var exists = StartProcess("git", $"checkout \"{newBranch}\"", RootDirectory)
                    .AssertWaitForExit()
                    .ExitCode == 0;
                if (!exists)
                {
                    Log.Information("None found, creating a new one...");
                    Git($"checkout -b \"{newBranch}\"");
                }

                Git($"merge -X theirs \"{curBranch}\" --allow-unrelated-histories");
                Git($"push --set-upstream origin \"{newBranch}\"");
                if (!exists)
                {
                    var github = new GitHubClient
                    (
                        new ProductHeaderValue("Silk.NET-CI"),
                        new InMemoryCredentialStore(new Credentials(pushableToken))
                    );

                    var pr = github.PullRequest.Create
                            ("dotnet", "Silk.NET", new("Move unshipped APIs to shipped", newBranch, curBranch))
                        .GetAwaiter()
                        .GetResult();
                }
            }
        }
    }
}
