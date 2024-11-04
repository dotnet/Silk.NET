// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using Nuke.Common;
using Nuke.Common.CI.GitHubActions;
using Nuke.Common.Git;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.Git;
using Octokit;
using Octokit.Internal;
using Serilog;
using static Nuke.Common.IO.CompressionTasks;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.HttpTasks;
using static Nuke.Common.Tooling.ProcessTasks;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.Tools.Git.GitTasks;
using static Nuke.Common.Tools.GitHub.GitHubTasks;

partial class Build {
    [Nuke.Common.Parameter("Build native code")] readonly bool Native;

    [Nuke.Common.Parameter("Android home. Will be determined from dotnet if not provided.")] [CanBeNull] string AndroidHomeValue;

    static string JobsArg => string.IsNullOrWhiteSpace(GitHubActions.Instance?.Job)
        ? $" -j{Jobs}"
        : string.Empty;

    static int Jobs => string.IsNullOrWhiteSpace(GitHubActions.Instance?.Job)
        ? Environment.ProcessorCount - 1
        : 1;

    public string GetCMakeToolchainFlag(string target)
    {
        return $"-DCMAKE_TOOLCHAIN_FILE={RootDirectory / "build" / "cmake" / target}.cmake";
    }

    public void CopyAs(AbsolutePath @out, string from, string to)
    {
        var file = @out.GlobFiles(from).First();
        CopyFile(file, to, FileExistsPolicy.Overwrite);
    }

    public void PrUpdatedNativeBinary(string name)
    {
        var pushableToken = EnvironmentInfo.GetVariable<string>("PUSHABLE_GITHUB_TOKEN");
        var curBranch = GitCurrentBranch(RootDirectory);
        if (!string.IsNullOrWhiteSpace(pushableToken) &&
            GitHubActions.Instance?.Repository == "dotnet/Silk.NET" &&
            curBranch != "HEAD" &&
            !string.IsNullOrWhiteSpace(curBranch) &&
            !curBranch.StartsWith("ci/", StringComparison.OrdinalIgnoreCase) && // ignore other CI branches
            !curBranch.StartsWith("main", StringComparison.OrdinalIgnoreCase) && // submodule updates are done in PRs...
            !curBranch.StartsWith("develop/", StringComparison.OrdinalIgnoreCase))
        {
            // it's assumed that the pushable token was used to checkout the repo

            Git("fetch --all", RootDirectory);
            Git("pull");
            Git("add -f src/Native/*/runtimes/*/native/*", RootDirectory);
            Git("add **/*.aar **/*.java **/PublicAPI.Unshipped.txt", RootDirectory);
            var newBranch = $"ci/{curBranch}/{name.ToLower().Replace(' ', '_')}_bins";
            var curCommit = GitCurrentCommit(RootDirectory);
            var commitCmd = InheritedShell
                (
                    $"git commit -m \"New binaries for {name} on {RuntimeInformation.OSDescription}\""
                )
                .AssertWaitForExit();
            if (!commitCmd.Output.Any(x => x.Text.Contains("no changes added to commit", StringComparison.OrdinalIgnoreCase) || x.Text.Contains("nothing", StringComparison.OrdinalIgnoreCase)))
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
                            ("dotnet", "Silk.NET", new($"Update {name} binaries", newBranch, curBranch))
                        .GetAwaiter()
                        .GetResult();
                }
            }
        }
    }
}
