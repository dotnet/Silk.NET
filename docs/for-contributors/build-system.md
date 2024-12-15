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

## NUKE

NUKE is used to provide an easy interface into both MSBuild and our other non-C# or otherwise auxiliary build tasks.
`dotnet build` works fine for building Silk.NET itself, and it's quite rare that you'll have to interact with NUKE.
However, if you have to build native packages or do anything that involves more than just a C# MSBuild runthrough then
NUKE serves this purpose.

All tasks can be seen in `eng/build/Build.cs`. They can be executed using the `build` scripts (in the repo root) or
using the `NUKE.GlobalTool` `dotnet tool`. If you don't specify a task, `Compile` is used, which just runs
`dotnet build`.
