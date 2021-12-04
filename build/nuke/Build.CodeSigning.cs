// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.IO;
using System.Linq;
using Nuke.Common;
using Nuke.Common.CI;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.SignClient;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.Tools.SignClient.SignClientTasks;

partial class Build
{
    [Parameter("Code-signing service username")] readonly string SignUsername;
    [Parameter("Code-signing service password")] readonly string SignPassword;
    bool CanCodeSign => !string.IsNullOrWhiteSpace(SignUsername) && !string.IsNullOrWhiteSpace(SignPassword);

    Target SignPackages => CommonTarget
    (
        x => x.Before(PushToNuGet)
            .After(Pack)
            .Produces("build/output_packages/*.nupkg")
            .Executes
            (
                () =>
                {
                    if (!CanCodeSign)
                    {
                        ControlFlow.Fail("SignClient username and/or password not specified.");
                    }

                    var outputs = Enumerable.Empty<Output>();
                    var basePath = RootDirectory / "build" / "codesigning";
                    var execPath = basePath / "tool" / (OperatingSystem.IsWindows() ? "SignClient.exe" : "SignClient");
                    if (!File.Exists(execPath))
                    {
                        outputs = outputs.Concat
                        (
                            DotNetToolInstall
                            (
                                s => s.SetToolInstallationPath(basePath / "tool")
                                    .SetPackageName("SignClient")
                            )
                        );
                    }

                    return Packages.Aggregate
                    (
                        outputs, (current, pkg) => current.Concat
                        (
                            SignClientSign
                            (
                                s => s.SetProcessToolPath(execPath)
                                    .SetBaseDirectory(PackageDirectory)
                                    .SetInput(pkg)
                                    .SetConfig(basePath / "config.json")
                                    .SetFileList(basePath / "filelist.txt")
                                    .SetUsername(SignUsername)
                                    .SetSecret(SignPassword)
                                    .SetName("Silk.NET")
                                    .SetDescription("Silk.NET")
                                    .SetDescriptionUrl("https://github.com/dotnet/Silk.NET")
                            )
                        )
                    );
                }
            )
    );
}
