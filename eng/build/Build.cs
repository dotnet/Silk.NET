using System.IO;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Utilities;
using static Nuke.Common.Tools.DotNet.DotNetTasks;

partial class Build : NukeBuild
{
    Target Prerequisites => x => x.Executes(RemoveTemporaryFeeds);

    Target Clean =>
        CommonTarget(x =>
            x.Before(Compile)
                .Executes(
                    () =>
                        DotNetClean(x =>
                            x.SetConfiguration(Configuration)
                                .SetProperties(ProcessedMsbuildProperties)
                        )
                )
        );

    Target Compile =>
        CommonTarget(x =>
            x.Executes(
                () =>
                    DotNetBuild(x =>
                        x.SetConfiguration(Configuration).SetProperties(ProcessedMsbuildProperties)
                    )
            )
        );

    Target Pack =>
        CommonTarget(x =>
            x.Executes(() =>
            {
                OutputPackageDir.CreateOrCleanDirectory();
                return DotNetPack(x =>
                    x.SetConfiguration(Configuration).SetProperties(ProcessedMsbuildProperties)
                );
            })
        );

    [Parameter("Additional arguments to prepend to SilkTouch invocations.")]
    readonly string[]? SilkTouchAdditionalArgs;

    Target RegenerateBindings =>
        CommonTarget(x =>
            x.Executes(
                () =>
                    DotNetRun(x =>
                        x.SetProjectFile(Solution.GetProject("Silk.NET.SilkTouch"))
                            .SetConfiguration("Release") // don't want to run this with anything else tbh
                            .SetApplicationArguments(
                                [.. SilkTouchAdditionalArgs ?? [], RootDirectory / "generator.json"]
                            )
                    )
            )
        );

    Target DeclareApi =>
        CommonTarget(x =>
            x.Executes(
                () =>
                    DotNet(
                        $"format analyzers {Solution} --diagnostics=RS0016 -v=diag --include-generated"
                    )
            )
        );

    Target ShipApi =>
        CommonTarget(x => x.After(PushToNuGet).Executes(MoveUnshippedContentsToShipped));

    Target SignPackages =>
        CommonTarget(x => x.Before(PushToNuGet).After(Pack).Executes(CodesignAllPackageOutputs));

    Target PushToNuGet =>
        CommonTarget(x =>
            x.After(Pack, SignPackages)
                .Executes(async () =>
                {
                    AddTemporaryFeed();
                    try
                    {
                        await foreach (var pkg in GetPackagesToPublish())
                        {
                            DotNetNuGetPush(NuGetPushSettings.SetTargetPath(pkg));
                        }
                    }
                    finally
                    {
                        RemoveTemporaryFeeds();
                    }
                })
        );

    Target FinishRelease =>
        CommonTarget(x =>
            x.After(PushToNuGet)
                .DependsOn(ShipApi)
                .Executes(async () =>
                {
                    GetVersionInfo(
                        File.ReadAllText(RootDirectory / "docs" / "CHANGELOG.md"),
                        out var version,
                        out var versionSuffix,
                        out var releaseNotes
                    );
                    await CreateReleaseAsync(version, versionSuffix, releaseNotes);
                    CommitAfterShipping(version, versionSuffix);
                    await WaitForNuGetToUpdateAsync(version, versionSuffix);
                    await SendWebhookAsync(version, versionSuffix, releaseNotes);
                })
        );

    [Parameter(
        $"A list of platforms that {nameof(DisablePlatforms)} should exclude from MSBuild usages, both "
            + $"inside and outside of NUKE. This can be reset by running {nameof(DisablePlatforms)} with no platforms, "
            + $"or by deleting the excluded-platforms.txt file."
    )]
    readonly string[]? Platforms;

    Target DisablePlatforms =>
        CommonTarget(x =>
            x.Executes(
                () =>
                    File.WriteAllText(
                        RootDirectory / "excluded-platforms.txt",
                        (Platforms ?? []).Join(' ')
                    )
            )
        );

    Target Website => CommonTarget(x => x.Executes(FullBuildWebsiteAsync));
}
