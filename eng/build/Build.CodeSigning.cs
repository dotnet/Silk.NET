// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using static Nuke.Common.Tooling.ProcessTasks;
using static Nuke.Common.Tools.DotNet.DotNetTasks;

partial class Build
{
    [Parameter("Code-signing service Azure Key Vault certificate")]
    readonly string? AkvCertificate;

    [Parameter("Code-signing service Azure Key Vault client ID")]
    readonly string? AkvClientId;

    [Parameter("Code-signing service Azure Key Vault client secret")]
    readonly string? AkvClientSecret;

    [Parameter("Code-signing service Azure Key Vault tenant ID")]
    readonly string? AkvTenant;

    [Parameter("Code-signing service Azure Key Vault URL")]
    readonly string? AkvVaultUrl;

    [MemberNotNullWhen(
        true,
        nameof(AkvCertificate),
        nameof(AkvClientId),
        nameof(AkvClientSecret),
        nameof(AkvTenant),
        nameof(AkvVaultUrl)
    )]
    bool CanCodeSign =>
        !string.IsNullOrWhiteSpace(AkvCertificate)
        && !string.IsNullOrWhiteSpace(AkvClientId)
        && !string.IsNullOrWhiteSpace(AkvClientSecret)
        && !string.IsNullOrWhiteSpace(AkvTenant)
        && !string.IsNullOrWhiteSpace(AkvVaultUrl);

    AbsolutePath PackageDirectory => RootDirectory / "artifacts" / "pkg";

    IEnumerable<AbsolutePath> Packages => PackageDirectory.GlobFiles("**/*.nupkg", "**/*.snupkg");

    IEnumerable<Output> CodesignAllPackageOutputs()
    {
        if (!CanCodeSign)
        {
            Assert.Fail("SignClient username and/or password not specified.");
        }

        var outputs = Enumerable.Empty<Output>();
        var basePath = RootDirectory / "eng" / "codesigning";
        var execPath = basePath / "tool" / (OperatingSystem.IsWindows() ? "sign.exe" : "sign");
        if (!File.Exists(execPath))
        {
            outputs = outputs.Concat(
                DotNetToolInstall(s =>
                    s.SetToolInstallationPath(basePath / "tool")
                        .SetPackageName("sign")
                        .SetVersion("0.9.0-beta.23063.3")
                )
            );
        }

        return Packages.Aggregate(
            outputs,
            (current, pkg) =>
                current.Concat(
                    StartProcess(
                            execPath,
                            $"sign code azure-key-vault \"{pkg}\" "
                                + "--timestamp-url http://timestamp.digicert.com "
                                + $"--base-directory \"{PackageDirectory}\" "
                                + $"--file-list \"{basePath / "filelist.txt"}\" "
                                + "--publisher-name \".NET Foundation\" "
                                + "--description \"Silk.NET\" "
                                + "--description-url \"https://github.com/dotnet/Silk.NET\" "
                                + $"--azure-key-vault-certificate \"{AkvCertificate}\" "
                                + $"--azure-key-vault-client-id \"{AkvClientId}\" "
                                + $"--azure-key-vault-client-secret \"{AkvClientSecret}\" "
                                + $"--azure-key-vault-tenant-id \"{AkvTenant}\" "
                                + $"--azure-key-vault-url \"{AkvVaultUrl}\" "
                        )
                        .AssertZeroExitCode()
                        .Output
                )
        );
    }
}