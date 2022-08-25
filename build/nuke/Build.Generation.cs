// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.IO;
using Nuke.Common;
using Nuke.Common.Tools.DotNet;
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
                    var project = OriginalSolution.GetProject("Silk.NET.BuildTools");
                    if (project == default)
                    {
                        Logger.Error("Couldn't find BuildTools in the solution file.");
                        return;
                    }

                    DotNetRun
                    (
                        s => s.SetProjectFile(project)
                            .SetConfiguration("Release")
                            .SetApplicationArguments(Path.Combine(RootDirectory, "generator.json"))
                    );
                }
            )
            .Executes
            (
                () => 
                {
                    var project = OriginalSolution.GetProject("ReSharperPlugin.SilkDotNet.DataGenerator");
                    if (project == default) 
                    {
                        Logger.Error("Couldnt find the Resharper plugin data generator in the solution file.");
                        return;
                    }

                    DotNetRun
                    (
                        s => s.SetProjectFile(project)
                            .SetConfiguration("Release")
                    );
                }
            )
    );

}
