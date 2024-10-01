<!-- Begin exclude from NuGet readme. -->
<h1 align="center">
    <a href="#"><img align="center" src="documentation/readme/silkdotnet_v3_horizontal_96.svg"></a>
    <br />
</h1>
<div align="center">

[![NuGet Version](https://img.shields.io/nuget/v/Silk.NET)](https://nuget.org/packages/Silk.NET)
[![Preview Feed](https://img.shields.io/badge/nuget-experimental%20feed-yellow)](https://gitlab.com/silkdotnet/Silk.NET/-/packages)
[![CI Build](https://github.com/Ultz/Silk.NET/workflows/CI%20Build/badge.svg)](https://github.com/dotnet/Silk.NET/actions/workflows/build.yml)
[![Join our Discord](https://img.shields.io/badge/chat%20on-discord-7289DA)](https://discord.gg/DTHHXRt)

</div>

<div>

<h1 align="center">🚧 Silk.NET 3.0 is coming... 🚧</h1>

We are currently hard at work on Silk.NET 3.0 - the latest and greatest Silk.NET, laser-focused on addressing pain points and reimagining how C# bindings libraries can be done.

Because of this, Silk.NET 2.X investment is currently limited by the Silk.NET team, who consist entirely of volunteers working in their free time. Silk.NET 2.X updates are now released ad-hoc when development effort is justified and available.

**If you're reading this and would like to step up to keep Silk.NET 2.X going, be that as a contributor or a maintainer, please do not hesitate to reach out to the Silk.NET team in our official Discord server!**

Learn more about Silk.NET 3.0:
- [Silk.NET 3.0 Plan](https://github.com/dotnet/Silk.NET/blob/14ee3f16a1c1b7c5f561c307b956f769c5e89474/documentation/proposals/Proposal%20-%203.0%20%26%203.X%20Software%20Development%20Plan.md)
- [Silk.NET 3.0 Bindings Design](https://github.com/dotnet/Silk.NET/blob/main/documentation/proposals/Proposal%20-%20Generation%20of%20Library%20Sources%20and%20PInvoke%20Mechanisms.md)
- [Silk.NET 3.0 Meeting 1](https://www.youtube.com/watch?v=dac3t0oh3VU)
- [Silk.NET 3.0 Meeting 2](https://www.youtube.com/watch?v=yXNDZDE3AHE)
- [SilkX (Silk.NET 3.0) Design Discussion](https://www.youtube.com/live/N7qcETE4X_I?t=1799)

<h1 align="center">About Silk.NET 2.X</h1>

<!-- End exclude from NuGet readme. -->
<!-- Begin include in NuGet readme.
![Silk.NET Logo](https://raw.githubusercontent.com/dotnet/Silk.NET/main/documentation/readme/silkdotnet_v3_horizontal_96.svg)
End include in NuGet readme. -->

Silk.NET is your one-stop-shop for high-speed .NET multimedia, graphics, and compute; providing bindings to popular low-level APIs such as OpenGL, OpenCL, OpenAL, OpenXR, GLFW, SDL, Vulkan, Assimp, WebGPU, and DirectX.

Use Silk.NET to spruce up applications with cross-platform 3D graphics, audio, compute and haptics!

Silk.NET works on any .NET Standard 2.0 compliant platform, including .NET 6.0, Xamarin, .NET Framework 4.6.1+, and .NET Core 2.0+.

</div>
<br />
<div>
<!-- Begin exclude from NuGet readme. -->
<a href="https://dotnetfoundation.org" align="right"><img src="https://github.com/dotnet-foundation/swag/blob/main/logo/dotnetfoundation_v4.svg" alt=".NET Foundation" class="logo-footer" width="72" align="left">
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

With an efficient bindings regeneration mechanism, we are committed to ensuring our bindings reflect the latest specifications with frequent updates generated straight from the upstream sources.

### High-level utilities

In addition to providing high-speed, direct, and transparent bindings, we provide high-level utilities and wrappers to maximise productivity in common workloads such as platform-agnostic abstractions around Windowing and Input, bringing your apps to a vast number of platforms without changing a single line!

### Good-to-go

Silk.NET caters for anything you could need in swift development of multimedia, graphics, compute applications. Silk.NET is an all-in-one solution, complete with Graphics, Compute, Audio, Input, and Windowing.

<!-- Begin exclude from NuGet readme. -->

<h1 align="center">The team</h1>

We currently have the following maintainers:
- [Kai Jellinghaus](https://github.com/HurricanKai) [<img src="https://about.twitter.com/etc/designs/about2-twitter/public/img/favicon.ico" alt="Follow Kai on Twitter" width="16" />](https://twitter.com/intent/follow?screen_name=KJellinghaus)
- [Thomas Mizrahi](https://github.com/ThomasMiz)
- [Beyley Thomas](https://github.com/Beyley)

In addition, the Silk.NET working group help drive larger user-facing changes providing key consultation from the perspective of dedicated users and professionals.

<h1 align="center">Building from source</h1>

**Prerequisites**

- .NET 6 SDK and .NET 7 SDK
- Android, iOS, and Mac Catalyst workloads (use `dotnet workload install android ios maccatalyst` to install them)
    - On Linux, `ios` and `maccatalyst` should be omitted as they are not available
- Android SDK versions 31, 33, and 34 with NDK tools installed
    - On Windows, for best results, this should be installed into `C:\ProgramData\Android\android-sdk`
- Java JDK 11+
- Visual Studio 2022 Community version 17.0 or later (optional)

**Instructions**

- Clone the repository
    - Note: Avoid performing a recursive clone as the submodules are not necessary for a normal build
- Run `build.sh`, `build.cmd`, `build.ps1`, or `nuke compile`
    - On Linux, you may need to pass `--msbuild-properties AndroidSdkDirectory=/path/to/android/sdk`
- Use the built assemblies
    - To get `.nupkg`s that you can use with NuGet instead, use `nuke pack`

There are more advanced build actions you can do too, such as `FullBuild`, `Pack`, `FullPack`, among others which you can view by doing `nuke --plan`.

<h1 align="center">Contributing</h1>

Silk.NET uses and encourages [Early Pull Requests](https://medium.com/practical-blend/pull-request-first-f6bb667a9b6). Please don't wait until you're done to open a PR!

1. [Fork Silk.NET](https://github.com/dotnet/Silk.NET/fork)
2. Add an empty commit to a new branch to start your work off: `git commit --allow-empty -m "start of [thing you're working on]"`
3. Once you've pushed a commit, open a [**draft pull request**](https://github.blog/2019-02-14-introducing-draft-pull-requests/). Do this **before** you actually start working.
4. Make your commits in small, incremental steps with clear descriptions.
5. Tag a maintainer when you're done and ask for a review!

The Silk.NET solution is **very large**. Learn about how you can combat this using our build process in [CONTRIBUTING.md](CONTRIBUTING.md).

<!-- End exclude from NuGet readme. -->

<h2 align="center">Funding</h2>
Silk.NET requires significant effort to maintain, as such we greatly appreciate any financial support you are able to provide!

This helps ensure Silk.NET's long term viability, and to help support the developers who maintain Silk.NET in their free time. [Kai](https://github.com/sponsors/HurricanKai) is accepting GitHub Sponsorships.

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

