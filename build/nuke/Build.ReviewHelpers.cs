// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.IO;
using System.Linq;
using Nuke.Common;
using Nuke.Common.IO;
using Serilog;

partial class Build
{
    // ReSharper disable once RedundantEmptyObjectOrCollectionInitializer
    readonly HashSet<string> AllowedExclusions = new()
    {
		"silkwindow",
		"silkgl",
		"silkgltriangle",
        "DotZLib"
    };

    Target ValidateSolution => CommonTarget
    (
        x => x.Executes
        (
            () =>
            {
                var missedOut = GetNewProjects();
                if (missedOut.Any())
                {
                    Log.Warning("Commands to add these for your convenience:");
                    foreach (var file in missedOut)
                    {
                        Log.Warning($"dotnet sln \"{Path.GetFileName(OriginalSolution.FileName)}\" add \"{file}\"");
                    }

                    Assert.Fail("Action required.");
                }
            }
        )
    );

    List<string> GetNewProjects()
    {
        var missedOut = new List<string>();
        var files = RootDirectory.GlobFiles("**\\*.csproj")
            .Concat(RootDirectory.GlobFiles("**/*.csproj"))
            .Where(x => !x.ToString().Contains("submodules"))
            .ToArray();
        Log.Information($"Found {files.Length} csproj files in \"{RootDirectory}\"");
        foreach (var file in files)
        {
            var found = false;
            foreach (var project in OriginalSolution.GetProjects("*"))
            {
                if (new FileInfo(file).FullName.Equals(new FileInfo(project.Path).FullName))
                {
                    found = true;
                    break;
                }
            }

            if (!found && !AllowedExclusions.Contains(Path.GetFileNameWithoutExtension(file)))
            {
                Log.Error
                (
                    "A project has not been included in the solution and will not be shipped! " +
                    $"\"{file}\" if this is acceptable please add the project name (excluding the path and " +
                    "extension) to the AllowedExclusions array in the NUKE Build.ReviewHelpers.cs file."
                );

                missedOut.Add(Path.GetRelativePath(RootDirectory, file).Replace('\\', '/'));
            }
        }

        return missedOut;
    }
}
