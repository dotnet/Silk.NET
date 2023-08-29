// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using static Nuke.Common.IO.FileSystemTasks;

partial class Build {
    AbsolutePath MoltenVKPath => RootDirectory / "build" / "submodules" / "MoltenVK";

    Target MoltenVK => CommonTarget
    (
        x => x.Before(Compile)
            .After(Clean)
            .Executes
            (
                () =>
                {
                    if (OperatingSystem.IsMacOS())
                    {
                        var runtimes = RootDirectory / "src" / "Native" / "Silk.NET.MoltenVK.Native" / "runtimes";

                        InheritedShell($"./fetchDependencies --ios --iossim --maccat", MoltenVKPath).AssertZeroExitCode();
                        InheritedShell($"make ios iossim maccat", MoltenVKPath).AssertZeroExitCode();

                        var xcFrameworkDir = MoltenVKPath / "Package" / "Release" / "MoltenVK" / "MoltenVK.xcframework";
                        const string iosDir = "ios-arm64";
                        const string simulatorDir = "ios-arm64_x86_64-simulator";
                        const string macCatalystDir = "ios-arm64_x86_64-maccatalyst";
                        
                        CopyFile(xcFrameworkDir / iosDir / "libMoltenVK.a", runtimes / iosDir / "libMoltenVK.a", FileExistsPolicy.Overwrite);
                        CopyFile(xcFrameworkDir / simulatorDir / "libMoltenVK.a", runtimes / simulatorDir / "libMoltenVK.a", FileExistsPolicy.Overwrite);
                        CopyFile(xcFrameworkDir / macCatalystDir / "libMoltenVK.a", runtimes / macCatalystDir / "libMoltenVK.a", FileExistsPolicy.Overwrite);
                    }

                    PrUpdatedNativeBinary("MoltenVK");
                }
            )
    );
}
