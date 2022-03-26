// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Nuke.Common;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Serilog;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.Tooling.ProcessTasks;

partial class Build
{
    [Parameter("If specified, when using the clean target removes the generated solution and stops.", Name = "Sln")]
    readonly bool CleanSln;

    Target Clean => CommonTarget
    (
        x => x.Before(Restore)
            .Executes
            (
                () =>
                {
                    if (CleanSln)
                    {
                        DeleteFile(RootDirectory / "Silk.NET.gen.sln");
                        return Enumerable.Empty<Output>();
                    }

                    var outputs = Enumerable.Empty<Output>();
                    outputs = outputs.Concat
                    (
                        DotNetClean
                        (
                            s => s.SetProject(Solution)
                                .SetProperties(ProcessedMsbuildProperties)
                        )
                    );

                    if (Directory.Exists(RootDirectory / "build" / "output_packages"))
                    {
                        Directory.Delete(RootDirectory / "build" / "output_packages", true);
                    }

                    Directory.CreateDirectory(RootDirectory / "build" / "output_packages");

                    if (Native)
                    {
                        outputs = outputs.Concat
                        (
                            StartShell($".{Path.PathSeparator}gradlew clean", SourceDirectory / "Windowing" / "SilkDroid")
                                .AssertZeroExitCode()
                                .Output
                        );
                    }
                    else
                    {
                        Log.Warning("Skipping gradlew clean as the \"native\" feature-set has not been specified.");
                    }

                    return outputs;
                }
            )
    );

    Target Restore => CommonTarget
    (
        x => x.After(Clean)
            .Executes
            (
                () => DotNetRestore
                (
                    s => s.SetProjectFile(Solution)
                        .SetProperties(ProcessedMsbuildProperties)
                )
            )
    );

    Target Compile => CommonTarget
    (
        x => x.DependsOn(Restore)
            .After(Clean)
            .Executes
            (
                () => ErrorsOnly<DotNetBuildSettings>
                (
                    s => s.SetProjectFile(Solution)
                        .SetConfiguration(Configuration)
                        .EnableNoRestore()
                        .SetProperties(ProcessedMsbuildProperties)
                )
            )
    );

    Target Test => CommonTarget
    (
        x => x.After(Compile)
            .Executes
            (
                () =>
                {
                    foreach (var project in Solution.GetProjects("*"))
                    {
                        if (project.Name.EndsWith(".Tests"))
                        {
                            DotNetTest(s => s.SetProjectFile(project));
                        }
                    }
                }
            )
    );
}
