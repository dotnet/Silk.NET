// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.IO;
using System.Linq;
using Nuke.Common;
using Nuke.Common.IO;

partial class Build
{
    // ReSharper disable once RedundantEmptyObjectOrCollectionInitializer
    readonly HashSet<string> AllowedExclusions = new()
    {
    };

    Target ValidateSolution => CommonTarget
    (
        x => x.Executes
        (
            () =>
            {
                var files = SourceDirectory.GlobFiles("**/*.csproj").ToArray();
                Logger.Info($"Found {files.Length} csproj files in \"{SourceDirectory}\"");
                var missedOut = new List<string>();
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
                        Logger.Error
                        (
                            "A project has not been included in the solution and will not be shipped! " +
                            $"\"{file}\" if this is acceptable please add the project name (excluding the path and " +
                            "extension) to the AllowedExclusions array in the NUKE Build.CI.AutoReview.cs file."
                        );

                        missedOut.Add(Path.GetRelativePath(RootDirectory, file).Replace('\\', '/'));
                    }
                }

                if (missedOut.Any())
                {
                    Logger.Warn("Commands to add these for your convenience:");
                    foreach (var file in missedOut)
                    {
                        Logger.Warn($"dotnet sln \"{Path.GetFileName(OriginalSolution.FileName)}\" add \"{file}\"");
                    }

                    ControlFlow.Fail("Action required.");
                }
            }
        )
    );
}
