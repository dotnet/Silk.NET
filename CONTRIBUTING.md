# Contributing

You can contribute to Silk.NET with issues and PRs. Simply filing issues for problems you encounter is a great way to contribute. Contributing code is also greatly appreciated.

## Considerations
The Silk.NET team will merge changes that improve the library significantly. We will not merge changes that have narrowly-defined benefits, or are breaking in some way. All contributions must also follow all other guidelines outlined in this document.

### The TLDR

Please:
- **DO** talk to us in #team-talk in the Discord or open a discussion about your contribution
- **DO** keep the discussions around contributions focused. If you have another matter to discuss, rather than creating a massive tangent in the current discussion, open up a new one.
- **DO** follow the code of conduct if discussing on GitHub and/or the Discord #rules if discussing on Discord.
- **DON'T** use AI to generate contributions for the project.
- **DON'T** make PRs that don't directly affect the end user, such as style changes. These are best done as part of a PR related to the area in question. Documentation is fine (and encouraged!), as this is useful to the end user.
- **DON'T** commit code you didn't write without following its license and following our guidelines for doing so in the Contributor License Agreement. If you are unable to license some code, don't commit it.
- **DON'T** surprise us with big pull requests or big API changes without talking to us first!
- **DON'T** make PRs for legal or administrative documents, such as the license, file headers, or code of conduct. If you see something off, let us know and we'll change it.
 
### Unannounced Contributions (including AI "drive-by" contributions)

You **MUST NOT** submit unannounced sizeable contributions without first discussing it with the Silk.NET team.

Silk.NET is vehemently against AI "drive-by" contributions (i.e. where a large amount of work has been submitted by someone unfamiliar to the team), and we will reject any PR where we suspect this is the case. The simple way to avoid this is to talk to us before contributing anything sizeable.

#### What is "sizeable"?

Sizeable means any of the following:
- Affects tens of files or over a thousand lines of code.
- Affects the public API surface in a way that has not been approved through the [proposals process](documentation/proposals/README.md) if applicable.

Generally speaking, a pull request that addresses an open issue (that, ideally, is marked as "help wanted", but we acknowledge that this might not always be the case) can be worked on without first consulting the Silk.NET team, provided it does not meet any of the above criteria.

#### What is "unannounced"

We would much rather you announce that you're working on something to us before you work on it (so we can plan maintainer workload and also guide you through any existing ideas that the team may have on what you're about to work on), but you **MUST** do so if it meets any of the above "sizeable" criteria. 

You **MUST** talk to us in #team-talk in the Discord, post an issue comment, and/or open a discussion issue if your contribution is sizeable (and **SHOULD** do so even if that isn't the case)

### Use of AI

It is the current view of the maintainers that AI **MUST NOT** be used to generate code for contributions to this project.
There is no appetite on the current maintainers team to review the contributions of or collaborate with AI-assisted developers.
This policy is based on an ongoing consensus on the maintainers team. Should the consensus of the maintainers team change, this policy will be updated. 

"AI" in this case means a Large Language Model ("LLM"), such as ChatGPT, Claude, Copilot, Grok, etc.

AI-generated code is based upon sources of unknown origins and may not be compatible with the MIT license, or may introduce conflicting license terms if they include code from other projects.

AI can be used to identify issues with contributions to this project, but the solutions to those issues should be authored by humans.

We have found that AI will frequently hallucinate issues that are not actually problems in practice, report incorrect information, and describe problems that are actually not issues at all. If AI identifies a problem with this codebase, please make sure you understand what it is saying and have independently confirmed that the issue exists before submitting a bug report or pull request.

Any pull request to this project will ask you to confirm that you are the author and that you are contributing your changes under the MIT license.

### Human Communication

As a general rule, we are still collaborating with you and your ideas, not that of any tools you may have used.

To this end, AI-generated descriptions, comments, or other forms of communication **MUST NOT** be used. If you have met the AI usage guideline, you don't need them.
AI-assisted translations or edits **MAY** be used in communication, but only where the original words prior to translation are your own. 

Silk.NET welcomes contributors with a diverse array of personalities, backgrounds, technical opinions/tastes, and way of working.
Effective self-expression is a key component of effective collaboration with us, we want to talk to a real human and that involves getting a feeling for your conduct/"voice".
This helps everyone understand where everyone's coming from, and helps establish middle-grounds in the event of differing opinions.

You **MUST** follow the [Code of Conduct](CODE_OF_CONDUCT.md) at all times.

You **SHOULD** communicate with the Silk.NET team using the #team-talk channel in our Discord, or via GitHub Discussions.

### Intellectual Property

You **MUST NOT** use third party code without declaring it as per our Contributor License Agreement and ensuring the license is compatible with ours.
If you are ever in doubt, you **MUST** discuss this with the Silk.NET team. The .NET Foundation owns Silk.NET's intellectual property, and is by extension the risk owner of any potential infringements.
We can liase with the Foundation as needed. 

#### Early Pull Requests
Silk.NET uses and encourages [Early Pull Requests](https://medium.com/practical-blend/pull-request-first-f6bb667a9b6). Please don't wait until you're done to open a PR!

1. Install [Git](https://git-scm.com/downloads) and the [.NET Core SDK](https://www.microsoft.com/net/download)
1. [Fork Silk.NET](https://github.com/dotnet/Silk.NET/fork)
1. Create a branch on your fork.
1. Add an empty commit to start your work off (and let you open a PR): `git commit --allow-empty -m "start of [thing you're working on]"`
1. Open a [**draft pull request**](https://github.blog/2019-02-14-introducing-draft-pull-requests/). Do this **before** you actually start working.
1. Make your commits in small, incremental steps with clear descriptions.
1. Tag a maintainer when you're done and ask for a review!

## Breaking changes
Contributions must maintain API signature and behavioral compatibility. Contributions that include breaking changes will be rejected. There are exceptions to this, such as if the contribution is made against a major/breaking version branch (such as `2.0` instead of `main`), however this is subject to the team's approval. At risk of sounding like a broken record, talk to us about your idea first!

### Generated bindings
Sometimes upstream specification changes happen while working on your contribution. Unfortunately, we are not in control of breaking changes created by the upstream spec sources, and if one happens while working on your contribution it is not a cause for concern.

If your contribution affects binder output, let us know by commenting on the pull request. If the change isn't as a result of your modifications to the BuildTools (if any), it is recommended that you don't commit the .gen.cs files and instead do this in a separate PR.

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
