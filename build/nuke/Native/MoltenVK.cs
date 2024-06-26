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

                        InheritedShell($"./fetchDependencies --all", MoltenVKPath).AssertZeroExitCode();
                        InheritedShell($"make", MoltenVKPath).AssertZeroExitCode();

                        var xcFrameworkDir = MoltenVKPath / "Package" / "Release" / "MoltenVK" / "static" / "MoltenVK.xcframework";

                        CopyFile(xcFrameworkDir / "ios-arm64" / "libMoltenVK.a", runtimes / "ios" / "native" / "libMoltenVK.a", FileExistsPolicy.Overwrite);
                        CopyFile(xcFrameworkDir / "ios-arm64_x86_64-simulator" / "libMoltenVK.a", runtimes / "iossimulator" / "native"  / "libMoltenVK.a", FileExistsPolicy.Overwrite);
                        CopyFile(xcFrameworkDir / "ios-arm64_x86_64-maccatalyst" / "libMoltenVK.a", runtimes / "maccatalyst" / "native" / "libMoltenVK.a", FileExistsPolicy.Overwrite);
                        CopyFile(xcFrameworkDir / "tvos-arm64_arm64e" / "libMoltenVK.a", runtimes / "tvos" / "native" / "libMoltenVK.a", FileExistsPolicy.Overwrite);
                        CopyFile(xcFrameworkDir / "tvos-arm64_x86_64-simulator" / "libMoltenVK.a", runtimes / "tvossimulator" / "native"  / "libMoltenVK.a", FileExistsPolicy.Overwrite);

                        var macOsDylib = runtimes / "osx" / "native" / "libMoltenVK.dylib";

                        CopyFile(MoltenVKPath / "Package" / "Release" / "MoltenVK" / "dynamic" / "dylib" / "macOS" / "libMoltenVK.dylib", macOsDylib, FileExistsPolicy.Overwrite);
                        CopyFile(MoltenVKPath / "Package" / "Release" / "MoltenVK" / "dynamic" / "dylib" / "macOS" / "MoltenVK_icd.json", runtimes / "osx" / "native" / "MoltenVK_icd.json", FileExistsPolicy.Overwrite);

                        // Only strip the macOS binary since stripping static libraries is too involved, and
                        // the final AOT'd binary can be stripped anyway.
                        InheritedShell($"strip -Sx -no_code_signature_warning {macOsDylib}").AssertZeroExitCode();

                        // Re-sign, as stripping a universal binary invalidates the signature.
                        InheritedShell($"codesign --remove-signature {macOsDylib}").AssertZeroExitCode();
                        InheritedShell($"codesign --sign - {macOsDylib}").AssertZeroExitCode();
                    }

                    PrUpdatedNativeBinary("MoltenVK");
                }
            )
    );
}
