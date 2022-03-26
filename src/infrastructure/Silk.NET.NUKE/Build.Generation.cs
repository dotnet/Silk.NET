// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.IO;
using Nuke.Common;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Serilog;
using static Nuke.Common.Tools.DotNet.DotNetTasks;

partial class Build
{
    Target RegenerateBindings => CommonTarget
    (
        x => x.After(Clean)
            .DependsOn(Restore)
            .Executes
            (
                () =>
                {
                    var project = OriginalSolution.NotNull()!.GetProject("SilkTouch");
                    if (project == default)
                    {
                        Log.Error("Couldn't find SilkTouch in the solution file.");
                        return;
                    }

                    DotNetRun
                    (
                        s => s.SetProjectFile(project)
                            .SetConfiguration("Release")
                            .SetProcessWorkingDirectory(RootDirectory)
                    );
                }
            )
    );

}
