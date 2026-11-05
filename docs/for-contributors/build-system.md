# Build System

Silk.NET strives to use vanilla `dotnet build` as much as possible, and that is the case for building Silk.NET itself.
There are a few noteworthy aspects of our usable of MSBuild though, and also some actions outside of building the
library itself that are provided by a auxiliary build system implemented using the NUKE build automation framework.

## MSBuild Usage

### Target Frameworks

It is our goal to always target the latest LTS .NET release, and optionally multi-targeting to the next non-LTS version
thereafter. We also make use of the mobile frameworks e.g. `net8.0-android`, `net8.0-ios`, but these shall always be
guarded using properties such as `SilkAndroidDisabled`, `SilkiOSDisabled`, etc which are set in `Directory.Build.props`,
which in turn check whether a file named `excluded-platforms.txt` exists and contains the target platform identifier.
This can be quickly modified by using the NUKE target `nuke disable-platforms`, which just writes to this file the
values provided for `--platforms`.

### Package READMEs

NuGet recently added functionality to include a "README" rendered from Markdown on the front page of a package in
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

### Native Packaging

Native packaging is one of the most frustratingly difficult aspect of packaging a library such as Silk.NET in an
effective, elegant way. Silk.NET 2.X had a fairly easy-to-maintain system, but there were some small issues we decided
to factor into the rewrite.

The primary goals in the native packaging system used for Silk.NET 3.0 are:
- As in 2.X, ensuring our native binaries come from a trusted source (CI), and that executing these builds is as simple
  as possible.
- Making it as easy as possible to add a new native binary build.
- Ensuring that the native binary builds are maximally low-maintenance, in-keeping with the native library author's
  intent, and resistant to breakage when we update the native library version used.

There are two parts to this: the GitHub Actions workflow and the MSBuild Usage. Since this is the MSBuild Usage section,
we'll discuss the latter here.

NuGet's native packaging scheme in the simple case is fairly obvious - the native binaries are placed into the
`runtimes/rid/native` directory of the package where `rid` is replaced with the appropriate runtime identifier. For fat
binaries, we omit the architecture suffix. We automatically do this in the `SilkShippingControl` target (which is really
just a kitchen sink of MSBuild fluff) in `Directory.Build.targets`, where all of the binaries are added as `None` items
that are packed into the `runtimes` directory. The binaries are picked up from the project directory in the same
`runtimes` directory structure as that which is added to the package.

To create a new native package, first create a csproj with the following contents:
```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFrameworks>net8.0</TargetFrameworks>
    <SilkDescription>Native binaries for LIBRARY_NAME_HERE.</SilkDescription>
    <SilkNativePackage>true</SilkNativePackage>
  </PropertyGroup>
</Project>
```

After that, create a `version.txt` that contains the `PackageVersion` for the native binary. Ideally you should create
an `update.sh` script that will automatically update the submodule to the latest upstream release, and update the
`version.txt` to contain that version. If your native library doesn't really have a versioning scheme (we've experienced
this with some of the Google libraries e.g. ANGLE, SwiftShader, etc), then it's recommended that the version be set to
a date-style version `YYYY.MM.DD` where the date used is the date of the commit the submodule is currently checked out
to.

Android is a bit of a unique case, as we not only have native binaries, we also have Java JARs in some cases. These need
to be exposed to the .NET for Android toolchain to ensure these JARs are accessible. This toolchain produces an `aar`
file which is added to the NuGet package, which incidentally includes both the JAR and the native binaries. Therefore,
we exclude the android binaries from the `runtimes` directory in this case. If you have JARs, add the following to the
native package csproj:
```diff
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
-   <TargetFrameworks>net8.0</TargetFrameworks>
+   <TargetFrameworks>net8.0;net8.0-android</TargetFrameworks>
+   <SilkNativeHasAndroidJars>true</SilkNativeHasAndroidJars>
+   <EnableDefaultAndroidItems>false</EnableDefaultAndroidItems>
  </PropertyGroup>
</Project>
```

The JARs, Proguard configurations, and XML transforms (for the .NET for Android generator) will be picked up from an
`android` subdirectory of the project folder. Native binaries will be picked up from `runtimes/android*/native` as
usual, but obviously merged into the `aar` as above.

iOS on the other hand is a lot simpler, however we still have some iOS-specific handling. Specifically, we inject a
`targets` file that is pulled in by downstream packages to add the `NativeReference` with the appropriate flags. We have
seen anecdotal evidence that modern .NET for iOS toolchains pull in `runtimes` `.a` files as `NativeReference`s
automatically, however in some cases there are specific linker flags required which are not picked up automatically. The
`.targets` file adds this. If these linker flags are required, add something similar to the following:
```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <SilkNativeiOSLinkerFlags>-framework AudioToolbox -framework AVFoundation -framework CoreAudio -framework CoreBluetooth -framework CoreFoundation -framework CoreGraphics -framework CoreHaptics -framework CoreMotion -framework CoreVideo -framework GameController -framework IOKit -framework Metal -framework OpenGLES -framework QuartzCore -framework UIKit -framework Foundation</SilkNativeiOSLinkerFlags>
  </PropertyGroup>
</Project>
```

The `.targets` injected can be seen at `eng/native/nuget/NativeNuGetPackage.targets` with the `TO_BE_REPLACED`
placeholders replaced in `Directory.Build.targets`.

Obviously, the native packages only work when consumed as a NuGet. However, we have a "best effort" attempt to copy the
appropriate native binary to the output directory for projects that `ProjectReference` a native binary, whether directly
or transitively. To make this work however, projects must include this:
```xml
<Project>
  <PropertyGroup>
    <RuntimeIdentifier Condition="'$(RuntimeIdentifier)' == ''">$(NETCoreSdkRuntimeIdentifier)</RuntimeIdentifier>
  </PropertyGroup>
</Project>
```

This logic is defined in the `SilkProjectReferenceNatives` target in `Directory.Build.targets`.

We currently have not explored doing this for static linking (i.e. iOS) builds.

## Native Build and Bindings Regeneration Workflows

All native binaries and bindings are built in CI to ensure that the come from a consistent and trusted source.

In order to ensure that we do not forget to update native builds and bindings, CI checks every PR for changes that
affect the native builds and bindings. When these changes are detected, CI will post a reminder comment containing
either a `/native` command or a `/bindings` command. This command can be commented by someone with **push privileges**
to trigger a rebuild or regeneration.

This is in contrast to 2.x where changes automatically triggered rebuilds and opened separate PRs requesting for the
changes to be merged, which was very noisy and annoying.

### Adding new native build and bindings regeneration jobs

All CI jobs related to native build and bindings regeneration are defined in
[build.json](../../eng/workflows/builds.json).

This file contains two main sections: `native` and `bindings`, each with a `jobs` property. These properties are used
by CI to figure out information such what jobs are available, which GitHub Actions runners to use, and which paths each
job depends on.

The below is an example `builds.json` config.

```json
{
  "native": {
    // Array of globs specifying dependencies shared by all native jobs
    "sharedDependencies": [],
    "jobs": {
      "SDL": {
        // Path to the output csproj folder
        "path": "sources/SDL/Native",
        // Submodule paths required by this job. Also treated as a dependency.
        "submodules": [
          "eng/submodules/sdl"
        ],
        // Runtime ID and which GitHub Actions runner to use
        // The Runtime ID is used to determine which script to call
        "builds": {
          "android": "ubuntu-latest",
          "ios": "macos-latest",
          "iossimulator": "macos-latest",
          "linux-arm64": "ubuntu-latest",
          "linux-arm": "ubuntu-latest",
          "linux-x64": "ubuntu-latest",
          "osx": "macos-latest",
          "tvos": "macos-latest",
          "tvossimulator": "macos-latest",
          "win-arm64": "windows-latest",
          "win-x64": "windows-latest"
        },
        // Optional array of globs specifying any additional dependencies
        "dependencies": []
      }
    }
  },
  "bindings": {
    // Array of globs specifying dependencies shared by all bindings jobs
    "sharedDependencies": [
      "sources/SilkTouch/**"
    ],
    "jobs": {
      "SDL": {
        // Submodule paths required by this job. Also treated as a dependency.
        "submodules": [
          "eng/submodules/sdl"
        ],
        // Lists the cache files that will be generated by each GitHub Actions runner.
        // This is to handle platform-specific scraping before a final
        // ubuntu-latest runner regenerates the full set of bindings.
        "caches": {
          "windows-latest": [
            "sdl-clangsharp.stout"
          ]
        },
        // Optional array of globs specifying any additional dependencies
        "dependencies": [
          "eng/silktouch/sdl/**"
        ]
      }
    }
  }
}
```

For more information on how each property is used, please refer to the workflow scripts in
[`eng/workflows`](../../eng/workflows) and the GitHub Actions workflows.

### Creating new native projects

Create the native package csproj as described in the MSBuild Usage section and add `build-rid.ext` scripts where `rid`
is replaced with a runtime identifier and `ext` is replaced with `sh` or `cmd` if the build is running on Windows.

Also ensure that this new project is registered both to [`Silk.NET.slnx`](../../Silk.NET.slnx) and to
[`builds.json`](../../eng/workflows/builds.json).

Note that for Linux we strive to have compatibility with glibc 2.17 and above, which in our experience from 2.X is a
happy medium in terms of wide compatibility and feature set in most cases. It's not easy to build for a specific glibc
target on Linux, which is why we use `zig cc` for these targets. For CMake targets, this is easy as we include the
relevant toolchain files all ready to use at `eng/native/cmake`. For the build scripts themselves, we include a
`eng/native/buildsystem/download-zig.py` script which will download the zig toolchain to `eng/native/buildsystem/zig`,
which should then be added to the `PATH`. This often looks similar to the following:

```bash
if [[ ! -z ${GITHUB_ACTIONS+x} ]]; then
    ../../../eng/native/buildsystem/download-zig.py
    export PATH="$PATH:$(readlink -f "../../../eng/native/buildsystem/zig")"
fi
```

Note that there are no prerequisite actions run before the native build occurs in the Build job, so these need to be
integrated into the build scripts, using the `GITHUB_ACTIONS` environment variable as appropriate. Other cases where
this is used beyond downloading Zig is installing `apt` dependencies, installing Android toolchains using `sdkmanager`,
etc.

### Creating new bindings projects

Please follow the steps explained in the [Using the Generator](Generator/using-the-generator.md) docs.

Also ensure that this new project is registered both to [`Silk.NET.slnx`](../../Silk.NET.slnx) and to
[`builds.json`](../../eng/workflows/builds.json).

### PowerShell Scripts

PowerShell is chosen since it is a cross-platform scripting solution that also happens to use .NET technology.

These scripts can currently be found in the [`eng/workflows`](../../eng/workflows) folder and embedded in each
GitHub Actions workflow.

Note: We began switching to PowerShell recently, so not all scripts use PowerShell yet. This mainly applies to the
individual `.sh`/`.cmd` build scripts found in each native csproj folder.

### `eng/workflows` scripts

These scripts do the bulk of the work when it comes to parsing the `builds.json` file.

The `native` and `bindings` variants of the scripts are very similar similar and cover the following responsibilities:

- `prerequisites.ps1` - Ensures that simple prerequisites are applied. This mainly involves initializing submodules
  required by the job. Initialization not required by all jobs should be handled elsewhere.

- `dependencies.ps1` - Constructs arrays of globs corresponding to the dependencies of each job. These are
  used by the `dorny/paths-filter` action in the `check-affected.yml` workflow to determine which jobs are affected
  by a PR's changes.

- `reminder.ps1` - Given the JSON array returned by `dorny/paths-filter` and an optional existing PR comment
  ID, this script generates a reminder message to be posted as a PR comment.

- `parse.ps1` - Given a PR comment, this script parses the comment and identifies which jobs need to be ran.
  The output of this is passed into `matrix.ps1`.

- `matrix.ps1` - Given a set of chosen jobs, this script generates a GitHub Actions matrix corresponding to
  the GitHub Actions runners needed to execute those jobs. For bindings regeneration, the script generates two sets of
  matrices because cache generation and bindings regeneration happen in two separate jobs.

For more information on how each script is called, please refer to the test scripts and test snapshots located in the
[`eng/workflows`](../../eng/workflows) folder. One easy way to work on these scripts is to edit the script, run the
`test.ps1` script, and see how the snapshot changes in a Git diff viewer.

### GitHub Actions workflows used

The GitHub Actions workflows are where things get a bit complex. This is due to how GitHub Actions triggers work, how
those triggers affect permissions, and the need to split untrusted and trusted work between different jobs.

To clarify some terminology, workflows refer to the entire `.yml` file, jobs refer to the individual jobs within each
workflow, and steps refer to the individual steps within each job.

These are the current workflows in use for Silk 3 native builds and bindings regeneration:

Silk 3 - `develop/3.0` branch:

- `check-affected.yml`: Triggered using `pull_request: synchronize`, this identifies what jobs are affected by changes
  within the PR.

Silk 2 - `main` branch:

- `silk3-affected-comment.yml`: Triggered using `workflow_run` when `check-affected.yml` completes. This workflow's
  sole purpose is to post the PR comment written by `check-affected.yml`. This is because `check-affected.yml` does not
  have any permissions when triggered by a PR from a fork.

- `silk3-native.yml`: Triggered using `issue_comment`, this parses the issue comment, builds the requested native
  binaries, and pushes them back to the PR the comment was posted on.

- `silk3-bindings-regeneration.yml`: Same as `silk3.native.yml`, but for bindings.

Workflows start off a trigger, which is an event like `issue_comment` or `pull_request: synchronize`. The key thing to
know is that this also defines the set of permissions that a workflow has and which branch the workflow file is read
from. GitHub does this for security purposes, but it means that we have to split what might otherwise be one workflow
into multiple parts. We also do something similar with individual jobs to isolate untrusted code.

For example, `issue_comment` always uses the default branch, which currently is the `main` branch used for Silk 2.x.
However, `pull_request: synchronize` uses the base branch of the PR, which usually is the `develop/3.0` branch used for
Silk 3. This is why our Silk 3 workflow definitions are split between `main` and `develop/3.0`.

Similarly, because `pull_request: synchronize` is unprivileged when triggered by a PR from a fork, in order for us to
post a PR comment during `check-affected.yml`, `check-affected.yml` must generate the comment and upload it as an
artifact for the privileged `silk3-affected-comment.yml` workflow to post.

Note that care is required when downloading and using artifacts generated by untrusted workflows and jobs. This is
because the artifact itself may contain malicious code. For example, comment text files are passed in through env vars
to avoid escape characters and validated to ensure that they contain the expected content. Another example is that we
have an untrusted job do the dangerous job of committing files and generating a Git bundle. This Git bundle is then
downloaded by a trusted job and committed into a bare repository. This is to ensure that Git hooks are never executed
in a privileged environment.

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
the theme of optimising Silk.NET 3.0 for maintainability.

First, the release notes are expected to be updated as PRs happen (as explained in
[CONTRIBUTING.md](../CONTRIBUTING.md)). This removes a massive time sink in writing nicely-formatted release
notes, as these can be reviewed as we review the corresponding PR. Secondly, the version in the changelog is
automatically updated at the end of a release workflow (a guesstimate based on the version we've just released) so we
immediately start shipping experimental packages with _a_ new version, even if that isn't the final version number we
ultimately go with. This is done in the `CommitAfterShipping` method referenced by the `FinishRelease` NUKE target.
This target will run after `SignPackages` if applicable and will always run `ShipApi` first.

For the remainder of the release process not moved to PR review time, a dedicated job as part of the
standard CI/CD workflow is used. For avoidance of doubt, the best source of documentation for building and releasing
Silk.NET is likely going to be the [dotnet workflow](../../.github/workflows/dotnet.yml). The `Release` job only runs
if:

- The build was manually initiated and not initiated by a push, pull request, or anything else.
- The `Release to NuGet` checkbox was selected when initiating that build.

As such, to release a new version of Silk.NET, go to the GitHub Actions page for the `.NET` workflow and
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

5. Send the Discord announcement to say that the update has been released. Note that we actually wait for up to an hour
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
