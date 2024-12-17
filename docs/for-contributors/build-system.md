# Build System

Silk.NET strives to use vanilla `dotnet build` as much as possible, and that is the case for building Silk.NET itself.
There are a few noteworthy aspects of our usable of MSBuild though, and also some actions outside of building the
library itself that are provided by a auxiliary build system implemented using the NUKE build automation framework.

## MSBuild Usage

### Package READMEs

NuGet has recently added functionality to include a "README" rendered from Markdown on the front page of a package in
the NuGet Gallery. To ease maintenance, this is derived from the main README.md file for the repository but with some
deviations to account for NuGet's extremely limited Markdown renderer. To differentiate these contents, the following
markers are added to the README file.

| Marker Text                                 | Replacement for NuGet |
|---------------------------------------------|-----------------------|
| `<!-- Begin exclude from NuGet readme. -->` | `<!--`                |
| `<!-- End exclude from NuGet readme. -->`   | `-->`                 |
| `<!-- Begin include in NuGet readme.`       | (removed)             |
| `End include in NuGet readme. -->`          | (removed)             |

Obviously they markers are as-is when served on NuGet, and represent the NuGet content being commented out.

In addition, it is encouraged that all packages set the `SilkDescription` and `SilkExtendedDescription` properties to
add more information about the package. `SilkDescription` is prepended to the `PackageDescription`. Both
`SilkDescription` and `SilkExtendedDescription` (in that order) are added to the README file beneath an
`# About This Package` header, replacing the text `<!-- Package description inserted here automatically. -->` in
README.md.

The additional text replacements made for NuGet Markdown compatibility, along with the rest of this logic, can be seen
in `Directory.Build.targets`.

### Versioning

We determine the Silk.NET version number automatically from the [CHANGELOG.md](../CHANGELOG.md) file, specifically
the first second-level heading in that file. In order to do that, `Directory.Build.targets` contains a
`SilkGetVersionInfoTask` inline task that outputs the `Version` and `VersionSuffix` when used in `SilkShippingControl`.
Additionally, `SilkShippingControl` is declared a dependency for the version and package version in
`Directory.Build.props`. See [CONTRIBUTING.md](../CONTRIBUTING.md) for more info on the CHANGELOG file.

### Public API

High Level Utilities (HLUs) must be subject to Public API tracking. This is to prevent undue breaking changes. To enable
it for a project, simply add the following to a project:

```xml
<Project>
  <!-- Public API Tracking -->
  <PropertyGroup>
    <SilkTrackPublicAPI>true</SilkTrackPublicAPI>
  </PropertyGroup>
  <ItemGroup Condition="'$(TargetFramework)' != ''">
    <AdditionalFiles Include="PublicAPI/$(TargetFramework)/PublicAPI.Shipped.txt" />
    <AdditionalFiles Include="PublicAPI/$(TargetFramework)/PublicAPI.Unshipped.txt" />
  </ItemGroup>
</Project>
```

The `ItemGroup` is an unfortunate deficiency with `Directory.Build.targets`. While putting it in this file would be
sufficient for build, it does not make for a pleasant development experience as IDEs do not pick it up from those files.
The empty public API files are automatically generated on first resolve.

### Central Package Management

We manage all the versions for our dependencies in Directory.Packages.props. Learn more about Central Package Management
[here](https://learn.microsoft.com/en-us/nuget/consume-packages/central-package-management).

### Metapackages

In 2.X, we introduced the concept of "metapackages" which were facade NuGet packages that contained no libraries or
anything that tangibly influences the build process, and simply declared dependencies to other packages. This came in
handy when pulling in e.g. an abstractions package and an implementation package all from a top-level package (e.g.
`Silk.NET.Windowing` pulling in `Silk.NET.Windowing.Common` and `Silk.NET.Windowing.Glfw`). Now that the top-level
packages include both abstractions and a reference implementation (using trimming instead where the implementation is
not used), only the top-level `Silk.NET` metapackage remains. The goal of this package has been to include _every single
non-extension Silk.NET package in existence_, but we did forget to update this a little bit as we added more packages,
so it ended up just being OpenGL and Vulkan mostly. We always argued that you probably don't want this package, but it
is undeniable that it provides non-zero benefit in scenarios where a quick bring-up is desired (e.g. scratchpads,
scripting/REPL, etc). As such, we decided to make this package more robust by having it automatically reference core
packages as we add them. Today, this is every `sources/A/A/Silk.NET.A.csproj` file where `A` represents a name of a
top-level directory in `sources`. It is highly likely that we'll want to amend this in the future. Note that we exclude
SilkTouch from this as this is unlikely to be useful to an end user. This is done using cursed MSBuild patterns that I
recommend just squinting at for ages until they click.

## NUKE

NUKE is used to provide an easy interface into both MSBuild and our other non-C# or otherwise auxiliary build tasks.
`dotnet build` works fine for building Silk.NET itself, and it's quite rare that you'll have to interact with NUKE.
However, if you have to build native packages or do anything that involves more than just a C# MSBuild runthrough then
NUKE serves this purpose.

All tasks can be seen in `eng/build/Build.cs`. They can be executed using the `build` scripts (in the repo root) or
using the `NUKE.GlobalTool` `dotnet tool`. If you don't specify a task, `Compile` is used, which just runs
`dotnet build`.

### CI/CD/Release Processes

NUKE is heavily used in the CI/CD process to automate releases to the maximum extent possible. Historically, the
Silk.NET release process has looked like the following:
1. Updating the release notes and version number
2. Create a GitHub release with the package version used as a tag prepended with the letter `v`
3. GitHub Actions then proceeded to pack and upload the project to NuGet
4. Once NuGet had updated, a maintainer would then format & paste the release notes into the Discord announcements
   channel.
5. Finally, a maintainer would move the unshipped public API to the shipped file (not once have we remembered to do
   this in 2.X...)

In 3.0 we have sought to massively improve this to minimise the amount of time it takes to release an update, continuing
the theme of massively optimising Silk.NET 3.0 for maintainability.

First, the release notes are expected to be updated as PRs happen (as explained in
[CONTRIBUTING.md](../CONTRIBUTING.md)). This already takes away a massive time sink in writing nicely-formatted release
notes, as this can be reviewed as we review the PR making the change. Secondly, the version in the changelog is
automatically updated at the end of a release workflow (a guesstimate based on the version we've just released) so we
immediately start shipping experimental packages with _a_ new version, even if that isn't the final version number we
ultimately go with. This is done in the `CommitAfterShipping` method referenced by the `FinishRelease` NUKE target.
This target will run after `SignPackages` if applicable and will always run `ShipApi` first.

For the remainder of the release process that has not been moved to PR review time, a dedicated job as part of the
standard CI/CD workflow is used. For the avoidance of doubt, the best source of documentation for building and releasing
Silk.NET is likely going to be the [dotnet workflow](../../.github/workflows/dotnet.yml). The `Release` job only runs
if:
- The build was manually initiated and not initiated by a push, pull request, or anything else.
- The `Release to NuGet` checkbox was selected when initiating that build.

As such, to release a new version of Silk.NET simply just go to the GitHub Actions page for the `.NET` workflow and
press the `Run workflow` button. Target the workflow at the branch containing the version you want to release.
Alternatively, this GitHub CLI command can be used: `gh workflow run .NET --ref branch-name-goes-here -f release=true`.
Note that the `Release` job runs within the `Release` environment which contains the announcement Discord webhook URL
and an SSH deploy key (the `SILK_ACTIONS_DEPLOY_KEY` secret) that will bypass the restrictions that prevent a tag from
being made or a protected branch being directly pushed to (we pass this to the checkout action which will set this up
for us). **This environment requires approval before running the `Release` job, from a maintainer other than the one who
triggered the job!** This approval is done on the build page (the one that shows the workflow job graph and the current
progress within that graph).

**TODO**: Should we move the NuGet token to this environment eventually as well? Don't forget we also need to make it so
there's a shared account on NuGet such that we can all recreate the NuGet token - right now this is tied to @Perksey's
account which isn't good given that it expires every year and @Perksey may disappear.

The `Release` job represents steps 2 onwards of the old process. Namely, this job calls the
`SignPackages PushToNuGet FinishRelease` tasks which will:
1. Codesign the packages previously packed as part of the standard workflow (this is great as we're reusing the
   workflow, rather than having two separate workflows we need to update in tandem whenever the build process changes!).
   The `sign` tool is used for this, which is the .NET Foundation's preferred code-signing mechanism at time of writing.
   Note that there are murmurs of this changing to use Azure Trusted Signing in the future but this is yet to come to
   fruition. This is implemented in the `SignPackages` target and the `CodesignAllPackageOutputs` method referenced by
   it.
2. Push the signed packages to NuGet. This makes use of the `NUGET_TOKEN` GitHub Actions secret, and is implemented in
   the `PushToNuGet` target and more notably the `GetPackagesToPublish` method it references. Note that to prevent
   `nuget.config` shenanigans, we add a temporary feed for this job using `AddTemporaryFeed` called `Silk-PushPackages`.
   This is mostly a relic of 2.X, but was added for good reason as wielding many different feeds - some using
   traditional username/password authentication, some using API keys, and some using both - has proved problematic in
   the past and not easy to automate any other way. This temporary feed is removed using `RemoveTemporaryFeeds` at the
   end of the target, and in case that doesn't work (e.g. the build crashed) then every subsequent NUKE build thereafter
   removes this feed in the `Prerequisites` target, which is made a dependency of every target using the `CommonTarget`
   helper.
3. Create & push a tag and release for the fresh version. This, like everything else versioning related, is determined
   by the [CHANGELOG.md](../CHANGELOG.md) file. The tag name is retrieved in the same way as the package version but
   with a `v` prepended at the start (as is tradition/standard/expected). The tag is created on the branch the workflow
   was targeted at, at the latest commit at the time the workflow started. The release is created using the top line
   ("headline" as referred to by [CONTRIBUTING.md](../CONTRIBUTING.md)) of the changelog used as the title but with
   `Silk.NET` removed - for no reason other than we seem to have always done this in Silk.NET's history, and why break
   tradition? The release body is the same as the NuGet package release notes, which is described in
   [CHANGELOG.md](../CHANGELOG.md). A GitHub Discussion in the `General` category is automatically created with the
   release. All of this is done in the `FinishRelease` target and the `CreateReleaseAsync` method referenced therein.
4. Update the shipped APIs and changelog. The updating of the shipped APIs actually happens before the previous step,
   but I didn't want to give off an impression that the tagged commit includes those changes - the tag is intended to
   capture the state at the time the release workflow began. These API updates happen in the `ShipApi` target, which can
   be executed on a local machine without invoking the rest of the release flow, and this target is denoted as a
   dependency of `FinishRelease`. This is literally just a dumb "move the unshipped lines to the shipped file"
   implemented in the `MoveUnshippedContentsToShipped` method referenced by the `ShipApi` target. After the `ShipApi`
   target has executed, the `FinishRelease` target begins by coming up with a guesstimate of the next package version
   (i.e. `3.0.0` is likely to be followed by `3.1.0`, `3.0.0-preview` is likely to be followed by `3.0.0-preview2`,
   `3.0.0-preview2` is likely to be followed by `3.0.0-preview3` etc) and adding this to the top of the
   [CHANGELOG.md](../CHANGELOG.md) file as described by that file. A placeholder headline is also generated to go below
   the newly-added second-level heading (e.g. `Silk.NET 3.1` or `Silk.NET 3.0 Preview 2` etc). This is then expected to
   be updated over time as per the standard changelog processes discussed. Next, `FinishRelease` will commit both the
   updated public API files and the updated changelog to the branch the workflow was targeted at. The changelog updating
   and the committing is implemented in the `CommitAfterShipping` method referenced by the `FinishRelease` target.
5. Send the Discord announcement to say that the update has been release. Note that we actually wait for up to an hour
   for NuGet to publish the release publicly, to ensure the embed in the announcement reflects the new version. This
   waiting is done in the `WaitForNuGetToUpdateAsync` method referenced by the `FinishRelease` target and basically just
   polls the `v3-flatcontainer` index for the `Silk.NET` metapackage, waiting for the new version to pop up there. After
   the update has appeared, we execute the webhook to send the announcement message. The message consists of the version
   headline followed by the version number in parentheses, all in bold underline. This is followed by a mention of the
   `SilkNews` role, followed by two new lines and
   `Get it on NuGet: https://nuget.org/packages/Silk.NET/version-goes-here` where `version-goes-here` is replaced
   with the package version. This is so the NuGet preview is added as an embed to the message, but without disrupting
   the flow of the rest of the announcement (or in other words, this is also just tradition). This is again followed by
   two new lines, with all lines included after the headline in the [CHANGELOG.md](../CHANGELOG.md) file included as-is,
   albeit with soft line breaks removed as these are actually hard breaks when sent to Discord - we do this using
   Markdig's Normalize renderer with some modifications. We also stop other links embedding as part of this processing.
   Finally, two more new lines are added and we conclude the message with `**__Get headline on NuGet__**` where
   `headline` is replaced with the same text as used on the first line of the announcement (modulo the role mention).
   When rendered by a Discord client, this underlined text is placed directly above the link embed, so basically it's
   just another traditional style choice. The webhook is executed using Discord's REST API (i.e. not a `/slack` webhook)
   with the URL being included in the `Release` environment in the `DISCORD_ANNOUNCEMENT_WEBHOOK`. This is done in the
   `SendWebhookAsync` method referenced by the `FinishRelease` target.
