// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Nuke.Common;
using Nuke.Common.IO;
using static Nuke.Common.Tools.Git.GitTasks;
using static Nuke.Common.Tools.Npm.NpmTasks;

partial class Build
{
    void FullBuildWebsite()
    {
        if (!GitHasCleanWorkingCopy())
        {
            Assert.Fail("Working directory is not clean.");
        }
        (RootDirectory / "docs").CreateOrCleanDirectory();
        (RootDirectory / "eng" / "submodules" / "silk.net-2.x" / "documentation").Copy(
            RootDirectory / "docs",
            ExistsPolicy.DirectoryMerge
        );
        (RootDirectory / "docs" / "images").CreateOrCleanDirectory();
        Npm($"npm run docusaurus docs:version v2", RootDirectory / "sources" / "Website");
        (RootDirectory / "docs").CreateOrCleanDirectory();
        Git($"checkout HEAD {RootDirectory / "docs"}");
    }
}
