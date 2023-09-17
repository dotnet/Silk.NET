// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Nuke.Common;
using Nuke.Common.CI;
using Nuke.Common.Tools.DotNet;
using static Nuke.Common.Tools.DotNet.DotNetTasks;

partial class Build
{
    Target Pack => CommonTarget
    (
        x => x.DependsOn(Restore)
            .After(Clean, RegenerateBindings, BuildLibSilkDroid)
            .Produces("build/output_packages/*.nupkg", "build/output_packages/*.snupkg")
            .Executes
            (
                () => ErrorsOnly<DotNetPackSettings>
                (
                    s => s.SetProject(Solution)
                        .SetConfiguration(Configuration)
                        .EnableNoRestore()
                        .SetProperties(ProcessedMsbuildProperties)
                )
            )
    );
}
