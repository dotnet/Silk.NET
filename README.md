# Silk.NET
[![NuGet Version](https://img.shields.io/nuget/v/Silk.NET)](https://nuget.org/packages/Silk.NET) [![Preview Feed](https://img.shields.io/badge/nuget-experimental%20feed-yellow)](https://dev.azure.com/UltzOS/Silk.NET/_packaging?_a=feed&feed=Experimental) [![CI Build](https://github.com/Ultz/Silk.NET/workflows/CI%20Build/badge.svg)](https://dev.azure.com/UltzOS/Silk.NET/_build/latest?definitionId=2&branchName=master) [![Join our Discord](https://img.shields.io/badge/chat%20on-discord-7289DA)](https://discord.gg/DTHHXRt)

Silk.NET is a high-speed, advanced library, providing bindings to popular low-level APIs such as OpenGL and OpenAL. Use Silk.NET to add cross-platform 3D graphics, audio, compute and haptics to your C# application.

Silk.NET works on any .NET Standard 2.0 compliant platform. This includes Xamarin, .NET Framework 4.6.1+, and .NET Core 2.0+.

# Features
- **Performance**: We use lesser-known techniques for our native interop which makes our bindings blazing fast.
- **Up-to-date**: We've built Silk.NET around the latest versions of the Khronos specifications. This means that Silk.NET includes OpenGL 4.6, OpenGLES 3.2, Vulkan 1.2 (and its **NVIDIA and KHR ray-tracing** extensions), and more.
- **High-level utilities**: We provide high-level abstractions around Windowing and Input APIs, which means your apps can run on any platform without changing a single line.
- **Game-ready**: Making games or game engines with Silk.NET is a breeze as you already have everything a game needs - Graphics, Audio, Input, and Windowing; all in one product!

# The team
We currently have the following maintainers:
- [Dylan P.](https://github.com/Perksey) from [Ultz](https://github.com/Ultz)
- [Kai J.](https://github.com/HurricanKai) from the open-source community

As well as some helpers from the community:
- [Vivian J.](https://github.com/devvoid) - a community member who basically wrote half the library.
- [Maximiliano L.](https://github.com/maxilevi) - developer of [Project Hedra](https://projecthedra.com/) using Silk.NET.
- [Aaron P.](https://github.com/AzyIsCool) - director at [Ultz](https://github.com/Ultz).
- [Frederik A.](https://github.com/frederikja163) - imparting knowledge on those using Silk.NET.
- [Robert S.](https://github.com/Pyrdacor) - developer of [freeserf.net](https://github.com/Pyrdacor/freeserf.net) and lead developer of [Silk UI](https://github.com/Ultz/SilkUI)

# Building from source

- Make sure you have at least the .NET 5 SDK installed, preferably with Visual Studio's .NET Framework and Xamarin workloads too.
- Clone the repository
- Run build.sh, build.cmd, build.ps1, or `nuke build`. To build for iOS and Android, add the `--feature-sets ios android` arguments.

# Contributing

Silk.NET uses and encourages [Early Pull Requests](https://medium.com/practical-blend/pull-request-first-f6bb667a9b6). Please don't wait until you're done to open a PR!

1. Install [Git](https://git-scm.com/downloads) and the [.NET Core SDK](https://www.microsoft.com/net/download)
1. [Fork Silk.NET](https://github.com/Ultz/Silk.NET/fork)
1. Create a branch on your fork.
1. Add an empty commit to start your work off (and let you open a PR): `git commit --allow-empty -m "start of [thing you're working on]"`
1. Open a Pull request with `[WIP]` in the title. Do this **before** you actually start working.
1. Make your commits in small, incremental steps with clear descriptions.
1. Tag a maintainer when you're done and ask for a review!

Some projects may not build properly without being configured to use Desktop MSBuild (i.e. the MSBuild shipped with Visual Studio). As a result, you will ideally need to be on Windows and have Visual Studio 2019 Community (or greater) installed with .NET Core and Xamarin workloads. If you don't have this (i.e. because you're on Linux or Mac), you can still develop Silk.NET in a limited capacity but you will not be able to work on mobile workloads.

# Documentation

Nothing here yet, but don't worry - we're working on it.

Several examples can be found in the `examples` folder.

You can find the Lab in the `src/Lab` folder. While many of these projects demonstrate functionality of Silk, these are intended more as experiments and tests for the library itself, and often demonstrate bad programming practices. Use with caution!

# Join the conversation

Come chat with us on [Discord](https://discord.gg/DTHHXRt)!

# License
Silk.NET is distributed under the very permissive MIT/X11 license and all dependencies are distributed under MIT-compatible licenses.
