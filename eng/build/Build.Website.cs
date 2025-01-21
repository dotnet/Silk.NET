// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using static Nuke.Common.Tools.Git.GitTasks;
using static Nuke.Common.Tools.Npm.NpmTasks;

partial class Build
{
    readonly record struct VersionDescription(
        AbsolutePath Path,
        AbsolutePath StaticPath,
        string Name,
        bool IsSilk2
    );

    // From oldest to newest. Last one is current.
    VersionDescription[] Versions =>
        [
            new(
                RootDirectory / "eng" / "submodules" / "silk.net-2.x" / "documentation",
                RootDirectory / "eng" / "submodules" / "silk.net-2.x" / "documentation" / "images",
                "v2",
                true
            ),
            new(
                RootDirectory / "docs",
                RootDirectory / "sources" / "Website" / "static" / "img",
                "v3",
                false
            ),
        ];

    readonly record struct JsonVersion(
        string Label,
        [property: JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)] string? Path
    );

    void FullBuildWebsite()
    {
        // Copy the current docs directory to a temporary directory, as we'll be making a lot of changes to this.
        (TemporaryDirectory / "docs").CreateOrCleanDirectory();
        (RootDirectory / "docs").Copy(
            TemporaryDirectory / "docs",
            ExistsPolicy.MergeAndOverwriteIfNewer
        );
        (TemporaryDirectory / "website").CreateOrCleanDirectory();
        (RootDirectory / "sources" / "Website").Copy(
            TemporaryDirectory / "website",
            ExistsPolicy.MergeAndOverwriteIfNewer
        );
        try
        {
            var versions = Versions;
            var jsonVersions = new Dictionary<string, JsonVersion>(versions.Length);
            for (var i = 0; i < versions.Length; i++)
            {
                var version = versions[i];
                (RootDirectory / "docs").CreateOrCleanDirectory();
                (
                    version.Path == RootDirectory / "docs"
                        ? TemporaryDirectory / "docs"
                        : version.Path
                ).Copy(RootDirectory / "docs", ExistsPolicy.MergeAndOverwriteIfNewer);
                if (i != versions.Length - 1)
                {
                    version.StaticPath.CopyToDirectory(
                        RootDirectory / "sources" / "Website" / "static",
                        ExistsPolicy.MergeAndOverwriteIfNewer
                    );

                    Npm(
                        $"run docusaurus docs:version {version.Name}",
                        RootDirectory / "sources" / "Website"
                    );
                }

                jsonVersions[i == versions.Length - 1 ? "current" : version.Name] = new JsonVersion(
                    Git($"describe --tags --abbrev=0", version.Path)
                        .First(x => x.Type == OutputType.Std)
                        .Text.Trim(),
                    version.Name
                );
            }

            (RootDirectory / "artifacts" / "docs").CreateOrCleanDirectory();
            File.WriteAllText(
                RootDirectory / "sources" / "Website" / "silkversions.json",
                JsonSerializer.Serialize(jsonVersions)
            );
            Npm($"run build -- --out-dir {RootDirectory / "artifacts" / "docs"}");
        }
        finally
        {
            File.Delete(RootDirectory / "sources" / "Website" / "silkversions.json");
            (RootDirectory / "docs").CreateOrCleanDirectory();
            (TemporaryDirectory / "docs").Copy(
                RootDirectory / "docs",
                ExistsPolicy.MergeAndOverwriteIfNewer
            );
            (TemporaryDirectory / "docs").CreateOrCleanDirectory();
            (RootDirectory / "sources" / "Website").CreateOrCleanDirectory();
            (TemporaryDirectory / "website").Copy(
                RootDirectory / "sources" / "Website",
                ExistsPolicy.MergeAndOverwriteIfNewer
            );
            (TemporaryDirectory / "website").CreateOrCleanDirectory();
        }
    }
}
