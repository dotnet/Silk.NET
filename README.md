<!-- Begin exclude from NuGet readme. -->
<h1 align="center">
    <a href="#"><img align="center" src="documentation/readme/silkdotnet_v3_horizontal_96.svg"></a>
    <br />
</h1>
<div align="center">

[![NuGet Version](https://img.shields.io/nuget/v/Silk.NET)](https://nuget.org/packages/Silk.NET)
[![Preview Feed](https://img.shields.io/badge/nuget-experimental%20feed-yellow)](https://dev.azure.com/UltzOS/Silk.NET/_packaging?_a=feed&feed=Experimental)
[![CI Build](https://github.com/Ultz/Silk.NET/workflows/CI%20Build/badge.svg)](https://github.com/dotnet/Silk.NET/actions/workflows/build.yml)
[![Join our Discord](https://img.shields.io/badge/chat%20on-discord-7289DA)](https://discord.gg/DTHHXRt)

</div>

<div> 
<!-- End exclude from NuGet readme. -->
<!-- Begin include in NuGet readme.
![Silk.NET Logo](https://raw.githubusercontent.com/dotnet/Silk.NET/main/documentation/readme/silkdotnet_v3_horizontal_96.svg)
End include in NuGet readme. -->

Silk.NET is your one-stop-shop for high-speed .NET multimedia, graphics, and compute; providing bindings to popular low-level APIs such as OpenGL, OpenCL, OpenAL, OpenXR, GLFW, SDL, Vulkan, Assimp, and DirectX.

Use Silk.NET to spruce up applications with cross-platform 3D graphics, audio, compute and haptics!

Silk.NET works on any .NET Standard 2.0 compliant platform, including .NET 6.0, Xamarin, .NET Framework 4.6.1+, and .NET Core 2.0+.

</div>
<br />
<div>
<!-- Begin exclude from NuGet readme. -->
<a href="https://dotnetfoundation.org" align="right"><img src="https://dotnetfoundation.org/img/logo_v4.svg" alt=".NET Foundation" class="logo-footer" width="72" align="left">
<!-- End exclude from NuGet readme. -->
<!-- Begin include in NuGet readme.
![.NET Foundation](https://raw.githubusercontent.com/dotnet/Silk.NET/main/documentation/readme/dotnetfoundation_v4_horizontal_64.svg)
End include in NuGet readme. -->
</a>
<br />

Proud to be an official project under the benevolent [.NET Foundation](https://dotnetfoundation.org) umbrella.

</div>

<!-- Package description inserted here automatically. -->

<h1 align="center">Features</h1>

### Performance
Having poured lots of hours into examining generated C# code and its JIT assembly, you can count on us to deliver blazing fast bindings with negligible overhead induced by Silk.NET!

### Up-to-date
With an efficient bindings regeneration mechanism, we are committed to ensuring our bindings reflect the latest specifications with monthly updates generated straight from the upstream sources.

### High-level utilities
In addition to providing high-speed, direct, and transparent bindings, we provide high-level utilities and wrappers to maximise productivity in common workloads such as platform-agnostic abstractions around Windowing and Input, bringing your apps to a vast number of platforms without changing a single line!

### Good-to-go
Silk.NET caters for anything you could need in swift development of multimedia, graphics, compute applications. Silk.NET is an all-in-one solution, complete with Graphics, Compute, Audio, Input, and Windowing.

<!-- Begin exclude from NuGet readme. -->

<h1 align="center">The team</h1>

We currently have the following maintainers:
- [Dylan Perks](https://github.com/Perksey) [<img src="https://about.twitter.com/etc/designs/about2-twitter/public/img/favicon.ico" alt="Follow Dylan Perks on Twitter" width="16" />](https://twitter.com/intent/follow?screen_name=Dylan_Perks)
- [Kai Jellinghaus](https://github.com/HurricanKai) [<img src="https://about.twitter.com/etc/designs/about2-twitter/public/img/favicon.ico" alt="Follow Dylan Perks on Twitter" width="16" />](https://twitter.com/intent/follow?screen_name=KJellinghaus)
- [Thomas Mizrahi](https://github.com/ThomasMiz)

In addition, the Silk.NET working group help drive larger user-facing changes providing key consultation from the perspective of dedicated users and professionals.

<h1 align="center">Building from source</h1>

Prerequisites
- **Must**: .NET 6 SDK
- **Should**: Android (w/ AOT), iOS, and MAUI .NET 6 workloads (use `dotnet workload install android android-aot ios maui` to install them)
- **Should**: Android SDK version 30 with NDK tools installed. On Windows, for best results this should be installed into `C:\ProgramData\Android\android-sdk`.
- **Could**: Java JDK (for gradle)
- **Could**: Visual Studio 2019 Community version 16.10 or later

Instructions
- Clone the repository (recursively)
- Run build.sh, build.cmd, build.ps1, or `nuke compile`.
- Use the DLLs. To get nupkgs you can use with NuGet instead, use `nuke pack`.

There are more advanced build actions you can do too, such as FullBuild, Pack, FullPack, among others which you can view by doing `nuke --plan`.

Note: Some .NET 6 workloads are only supported on Windows and macOS today.

<h1 align="center">Contributing</h1>

Silk.NET uses and encourages [Early Pull Requests](https://medium.com/practical-blend/pull-request-first-f6bb667a9b6). Please don't wait until you're done to open a PR!

1. [Fork Silk.NET](https://github.com/dotnet/Silk.NET/fork)
2. Add an empty commit to a new branch to start your work off: `git commit --allow-empty -m "start of [thing you're working on]"`
3. Once you've pushed a commit, open a [**draft pull request**](https://github.blog/2019-02-14-introducing-draft-pull-requests/). Do this **before** you actually start working.
4. Make your commits in small, incremental steps with clear descriptions.
5. Tag a maintainer when you're done and ask for a review!

The Silk.NET solution is **very large**. As such, to generate a solution that only has the projects you care about for your contribution, use the following command:
`nuke sln --projects project1 project2...`. `<projects>` can be substitued for:
- A name of an individual project. The Silk.NET prefix can be omitted provided there is no matching subfolder.
- A name of a subfolder in the repo root, `src/`, or `examples/CSharp`

Example: `nuke sln --projects opengl silk.net.vulkan core.win32extras "opengl tutorials" build`. This:
- matches `opengl` to `src/OpenGL`
- matches `silk.net.vulkan` to `src/Vulkan/Silk.NET.Vulkan`
- matches `core.win32extras` to `src/Core/Silk.NET.Core.Win32Extras`
- matches `"opengl tutorials"` to `examples/CSharp/OpenGL Tutorials`
- matches `build` to `build/`

The generated solution is: `Silk.NET.gen.sln`

<!-- End exclude from NuGet readme. -->

<h2 align="center">Funding</h2>
Silk.NET requires significant effort to maintain, as such we greatly appreciate any financial support you are able to provide!

This helps ensure Silk.NET's long term viability, and to help support the developers who maintain Silk.NET in their free time. [Dylan](https://github.com/sponsors/Perksey) and [Kai](https://github.com/sponsors/HurricanKai) are accepting GitHub Sponsorships.

<h1 align="center">Further resources</h1>

- Several examples can be found in the [examples folder](https://github.com/dotnet/Silk.NET/tree/master/examples)
- Come chat with us on [Discord](https://discord.gg/DTHHXRt)!

<h1 align="center">Licensing and governance</h1>

Silk.NET is distributed under the very permissive MIT/X11 license and all dependencies are distributed under MIT-compatible licenses.

Silk.NET is a [.NET Foundation](https://www.dotnetfoundation.org/projects) project, and has adopted the code of conduct defined by the [Contributor Covenant](http://contributor-covenant.org/) to clarify expected behavior in our community. For more information, see the [.NET Foundation Code of Conduct](http://www.dotnetfoundation.org/code-of-conduct).

<!-- Begin exclude from NuGet readme. -->

---

<div>
    <a href="https://www.jetbrains.com/?from=Silk.NET" align="right"><img src="https://raw.githubusercontent.com/dotnet/Silk.NET/main/documentation/readme/jetbrains.svg" alt="JetBrains" class="logo-footer" width="72" align="left">
    <a><br/>
        
Special thanks to [JetBrains](https://www.jetbrains.com/?from=Silk.NET) for supporting us with open-source licenses for their IDEs. </a>
</div>

<!-- End exclude from NuGet readme. -->

