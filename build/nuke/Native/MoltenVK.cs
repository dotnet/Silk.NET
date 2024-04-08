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

                        InheritedShell($"./fetchDependencies --ios --iossim --maccat --macos", MoltenVKPath).AssertZeroExitCode();
                        InheritedShell($"make ios iossim maccat macos", MoltenVKPath).AssertZeroExitCode();

                        var xcFrameworkDir = MoltenVKPath / "Package" / "Release" / "MoltenVK" / "static" / "MoltenVK.xcframework";

                        CopyFile(xcFrameworkDir / "ios-arm64" / "libMoltenVK.a", runtimes / "ios" / "native" / "libMoltenVK.a", FileExistsPolicy.Overwrite);
                        CopyFile(xcFrameworkDir / "ios-arm64_x86_64-simulator" / "libMoltenVK.a", runtimes / "iossimulator" / "native"  / "libMoltenVK.a", FileExistsPolicy.Overwrite);
                        CopyFile(xcFrameworkDir / "ios-arm64_x86_64-maccatalyst" / "libMoltenVK.a", runtimes / "maccatalyst" / "native" / "libMoltenVK.a", FileExistsPolicy.Overwrite);
                        CopyFile(MoltenVKPath / "Package" / "Release" / "MoltenVK" / "dynamic" / "dylib" / "macOS" / "libMoltenVK.dylib", runtimes / "osx" / "native" / "libMoltenVK.dylib", FileExistsPolicy.Overwrite);
                        CopyFile(MoltenVKPath / "Package" / "Release" / "MoltenVK" / "dynamic" / "dylib" / "macOS" / "MoltenVK_icd.json", runtimes / "osx" / "native" / "MoltenVK_icd.json", FileExistsPolicy.Overwrite);
                    }

                    PrUpdatedNativeBinary("MoltenVK");
                }
            )
    );
}
