# Contributing

You can contribute to Silk.NET with issues and PRs. Simply filing issues for problems you encounter is a great way to contribute. Contributing code is also greatly appreciated.

## Considerations
The Silk.NET team will merge changes that improve the library significantly. We will not merge changes that have narrowly-defined benefits, or are breaking in some way. All contributions must also follow all other guidelines outlined in this document.

## DOs and DON'Ts
Please:
- **DO** talk to us in #team-talk in the Discord or open a discussion issue if your contribution is sizeable.
- **DO** keep the discussions around contributions focused. If you have another matter to discuss, rather than creating a massive tangent in the current discussion, open up a new one.
- **DO** follow the code of conduct if discussing on GitHub and/or the Discord #rules if discussing on Discord.
- **DON'T** make PRs that don't directly affect the end user, such as style changes. These are best done as part of a PR related to the area in question. Documentation is fine (and encouraged!), as this is useful to the end user.
- **DON'T** commit code you didn't write without following its license and following our guidelines for doing so in the Contributor License Agreement. If you are unable to license some code, don't commit it.
- **DON'T** surprise us with big pull requests or big API changes without talking to us first!
- **DON'T** make PRs for legal or administrative documents, such as the license, file headers, or code of conduct. If you see something off, let us know and we'll change it.

## Breaking changes
Contributions must maintain API signature and behavioral compatibility. Contributions that include breaking changes will be rejected. There are exceptions to this, such as if the contribution is made against a major/breaking version branch (such as `2.0` instead of `master`), however this is subject to the team's approval. At risk of sounding like a broken record, talk to us about your idea first!

### Generated bindings
Sometimes upstream specification changes happen while working on your contribution. Unfortunately, we are not in control of breaking changes created by the upstream spec sources, and if one happens while working on your contribution it is not a cause for concern.

If your contribution affects binder output, let us know by commenting on the pull request. If the change isn't as a result of your modifications to the BuildTools (if any), it is recommended that you don't commit the .gen.cs files and instead do this in a separate PR.

## Suggested workflow
Silk.NET uses and encourages [Early Pull Requests](https://medium.com/practical-blend/pull-request-first-f6bb667a9b6). Please don't wait until you're done to open a PR!

1. Install [Git](https://git-scm.com/downloads) and the [.NET Core SDK](https://www.microsoft.com/net/download)
1. [Fork Silk.NET](https://github.com/dotnet/Silk.NET/fork)
1. Create a branch on your fork.
1. Add an empty commit to start your work off (and let you open a PR): `git commit --allow-empty -m "start of [thing you're working on]"`
1. Open a [**draft pull request**](https://github.blog/2019-02-14-introducing-draft-pull-requests/). Do this **before** you actually start working.
1. Make your commits in small, incremental steps with clear descriptions.
1. Tag a maintainer when you're done and ask for a review!

## Working with our large solution

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

## "Help wanted" & "Good first issue"
If the core team are unable to champion an issue, they will mark it with a "help wanted" label. This indicates that any external contributor may pick up on this issue and implement it as part of a contribution. However, some "help wanted" issues may require intermediate knowledge of the codebase, area, and/or ecosystem; or may have uncertainty surrounding implementation details (if this is the case talk to us in the Discord or in a discussion issue). Because of this, we also mark some issues with the label "good first issue" which indicates that an issue is straightforward, and is a good place to start if you're interested in contributing but new to the codebase.

## Contributor License Agreement
You must sign a Contributor License Agreement (CLA) before your PR will be merged. This is a one-time requirement for all .NET Foundation projects, and you'll only have to do this once. You can read more about [Contribution License Agreements (CLAs) on Wikipedia](https://en.wikipedia.org/wiki/Contributor_License_Agreement).

You don't have to do this up-front. You can simply clone, fork, and submit your pull-request as usual. When your pull-request is created, you'll be notified by the CLA bot of further instructions if necessary.

## File Headers
The following file header is used for Silk.NET. Please use it for new files.
```cs
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
```

## Pull requests
### Continuous Integration
Our GitHub Actions Continuous Integration (CI) system will automatically perform the required builds, tests, and in some cases changes for Pull Requests (PRs).

If the CI build fails for any reason, you can view the logs to find out what the problem is. In some cases, GitHub Actions will highlight the errors inline on the "File Changes" tabs.

### Feedback
Team and community members will provide feedback on your change. Community feedback is highly valued. You will often see the absence of team feedback if the community has already provided good review feedback.

One or more team members will review every PR prior to merge.

There are lots of thoughts and approaches for how to efficiently discuss changes. It is best to be clear and explicit with your feedback. Please be patient with people who might not understand the finer details about your approach to feedback.
