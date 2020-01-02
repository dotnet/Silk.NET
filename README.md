# Silk.NET
[![NuGet Version](https://img.shields.io/nuget/v/Silk.NET)](https://nuget.org/packages/Silk.NET) [![Preview Feed](https://img.shields.io/badge/nuget-experimental%20feed-yellow)](https://dev.azure.com/UltzLimited/Silk.NET/_packaging?_a=feed&feed=Experimental) [![Build Status](https://dev.azure.com/UltzLimited/Silk.NET/_apis/build/status/Ultz.Silk.NET?branchName=master)](https://dev.azure.com/UltzLimited/Silk.NET/_build/latest?definitionId=2&branchName=master)

Silk.NET is a high-speed, advanced library, providing bindings to popular low-level APIs such as OpenGL and OpenAL. Use Silk.NET to add cross-platform 3D graphics, audio, compute and haptics to your C# application.

Silk.NET works on any .NET Standard 2.0 compliant platform. This includes Xamarin, .NET Framework 4.6.1+, and .NET Core 2.0+.

# Features
- **Performance**: We use lesser-known techniques for our native interop which makes our bindings blazing fast.
- **Up-to-date**: We've built Silk.NET around the latest versions of the Khronos specifications. This means that Silk.NET includes OpenGL 4.6 (and its **NVIDIA ray-tracing** extensions), OpenGLES 3.2.
- **High-level utilities**: We provide high-level abstractions around Windowing and Input APIs, which means you apps can run on any platform without changing a single line.
- **Game-ready**: Making games or game engines with Silk.NET is a breeze as you already have everything a game needs - Graphics, Audio, Input, and Windowing; all in one product!

# The team
We currently have 3 maintainers:
- [Dylan P.](https://github.com/Perksey) from [Ultz](https://github.com/Ultz)
- [Aaron P.](https://github.com/AzyIsCool) from [Ultz](https://github.com/Ultz)
- [Frederik A.](https://github.com/frederikja163) from the open-source community

As well as 2 community members who we consult with to influence Silk.NET's design:
- [Maximiliano L.](https://github.com/maxilevi) - developer of [Project Hedra](https://projecthedra.com/) using Silk.NET
- [Void](https://github.com/devvoid) - a contributor who basically wrote half the library

Silk.NET is governed by the Silk Working Group, made up of all 5 of the above members. Only 2 seats are occupied by members of Ultz, demonstrating and emphasising our commitment to open-source software.

# Building from source

- Make sure you have the .NET Core SDK installed
- Clone the repository
- Run `generator.bat` or `generator.sh` (to generate the bindings)
- Run `dotnet build`

# Contributing

Silk.NET uses and encourages [Early Pull Requests](https://medium.com/practical-blend/pull-request-first-f6bb667a9b6). Please don't wait until you're done to open a PR!

1. Install [Git](https://git-scm.com/downloads) and the [.NET Core SDK](https://www.microsoft.com/net/download)
1. [Fork Silk.NET](https://github.com/Ultz/Silk.NET/fork)
1. Create a branch on your fork.
1. Add an empty commit to start your work off (and let you open a PR): `git commit --allow-empty -m "start of [thing you're working on]"`
1. Open a Pull request with `[WIP]` in the title. Do this **before** you actually start working.
1. Make your commits in small, incremental steps with clear descriptions.
1. Tag a maintainer when you're done and ask for a review!

# Documentation

Nothing here yet, but don't worry - we're working on it.

# Join the conversation

Come chat with us on [Discord](https://discord.gg/DTHHXRt)!

# License
Silk.NET is distributed under the very permissive MIT/X11 license. Note that some third party libraries such as AdvancedDLSupport are compatible with the MIT license under one or more custom agreements, but have [additional conditions](https://github.com/Ultz/Silk.NET/blob/master/THIRD_PARTIES.md).
