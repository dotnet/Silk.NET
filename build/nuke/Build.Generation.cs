// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Nuke.Common;
using Nuke.Common.CI.GitHubActions;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Octokit;
using Octokit.Internal;
using Serilog;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.Tools.Git.GitTasks;
using static Nuke.Common.Tooling.ProcessTasks;

partial class Build
{
    [Nuke.Common.Parameter("Create a PR after bindings regeneration completes")] readonly bool CreateBindingsPr;
    [Nuke.Common.Parameter("Don't let BuildTools parallelize")] readonly bool NoParallelGeneration;

    Target RegenerateBindings => CommonTarget
    (
        x => x.After(Clean)
            .Executes
            (
                () =>
                {
                    var project = OriginalSolution.GetProject("Silk.NET.BuildTools");
                    if (project == default)
                    {
                        Log.Error("Couldn't find BuildTools in the solution file.");
                        return;
                    }

                    DotNetRun
                    (
                        s => s.SetProjectFile(project)
                            .SetConfiguration("Release")
                            .SetApplicationArguments
                            (
                                Path.Combine(RootDirectory, "generator.json") +
                                (NoParallelGeneration ? " --no-parallel" : "")
                            )
                    );

                    if (CreateBindingsPr)
                    {
                        foreach (var missedOut in GetNewProjects())
                        {
                            DotNet($"sln \"{Path.GetFileName(OriginalSolution.FileName)}\" add \"{missedOut}\"");
                        }

                        PrUpdatedBindings();
                    }
                }
            )
    );


    void PrUpdatedBindings()
    {
        var pushableToken = EnvironmentInfo.GetVariable<string>("PUSHABLE_GITHUB_TOKEN");
        var curBranch = GitCurrentBranch(RootDirectory);
        if (!string.IsNullOrWhiteSpace(pushableToken) &&
            GitHubActions.Instance?.Repository == "dotnet/Silk.NET" &&
            curBranch != "HEAD" &&
            !string.IsNullOrWhiteSpace(curBranch))
        {
            Git("fetch --all", RootDirectory);
            Git("pull");
            Git("add src build/cache build/submodules Silk.NET.sln", RootDirectory);
            var newBranch = $"ci/{curBranch}/bindings_regen";
            var curCommit = GitCurrentCommit(RootDirectory);
            var commitCmd = InheritedShell
                (
                    $"git commit -m \"Regenerated bindings as of {DateTime.UtcNow:dd/MM/yyyy (HH:mm:ss)}\""
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
                            ("dotnet", "Silk.NET", new($"Regenerate bindings as of {DateTime.UtcNow:dd/MM/yyyy}", newBranch, curBranch))
                        .GetAwaiter()
                        .GetResult();
                }
            }
        }
    }

}
