# Infrastructure

This folder contains the plumbing and infrastructure for building and running Silk.NET.

This consists of:

## Silk.NET.NUKE

We use [NUKE](https://nuke.build) to automate our builds and provide other build-related utilities for use in GitHub Actions, and other CI/CD scenarios.

## Silk.NET.*.Native

The native packages contain NuGet distributions of the binaries for the various libraries we bind to. Previously, this had its
own repository, but was coalesced into this repository to be reunited with the rest of Silk.NET.

Each binary distribution inherits the license from the library contained within it, and you should check it for
compatibility with the rest of your solution:

- Silk.NET.Assimp.Native: BSD-3-Clause
- Silk.NET.GLFW.Native: Zlib
- Silk.NET.OpenAL.Soft.Native: LGPL-2.0-or-later
