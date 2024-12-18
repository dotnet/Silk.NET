# Contributing

You can contribute to Silk.NET with issues and PRs. Simply filing issues for problems you encounter is a great way to contribute. Contributing code is also greatly appreciated.

## Considerations
The Silk.NET team will merge changes that improve the library significantly. We will not merge changes that have narrowly-defined benefits, or are breaking in some way. All contributions must also follow all other guidelines outlined in this document.

## DOs and DON'Ts
Please:
- **DO** talk to us in #team-talk in the Discord or open a discussion issue if your contribution is sizeable.
- **DO** keep the discussions around contributions focused. If you have another matter to discuss, rather than creating a massive tangent in the current discussion, open up a new one.
- **DO** follow the code of conduct if discussing on GitHub and/or the Discord #rules if discussing on Discord.
- **DO** update the release notes, unless your change only affects the repository experience, examples, internals (without user-facing behavioural changes), or otherwise isn't user-facing.
- **DON'T** make PRs that don't directly affect the end user, such as style changes. These are best done as part of a PR related to the area in question. Documentation is fine (and encouraged!), as this is useful to the end user.
- **DON'T** commit code you didn't write without following its license and following our guidelines for doing so in the Contributor License Agreement. If you are unable to license some code, don't commit it.
- **DON'T** surprise us with big pull requests or big API changes without talking to us first!
- **DON'T** make PRs for legal or administrative documents, such as the license, file headers, or code of conduct. If you see something off, let us know and we'll change it.

## Updating Release Notes

Silk.NET has excessive attention to detail when it comes to its most user-facing documentation, as these are seen as
promotional opportunities to shape user opinion of the library. For instance, a user is much more likely to favour a
library with a very clear README that clearly states what the project does, and why the user should use it. This is why
README changes are some of the most deliberated changes made to this project. We see release notes in this category too,
as release notes present an opportunity to show off and focus on all the great stuff we've been working on for our users
to paint the library in an even more positive light. This is also why we handwrite release notes rather than
autogenerate them as most libraries do these days.

To this end, our release notes follow a very particular format. Namely:
- A headline/title. For example `Silk.NET April 2024 Update` or `Silk.NET 3.0 Preview 1`.
- A blank line.
- A bullet list of changes.
    - Each list element must start with the word `Added`, `Updated`, `Improved`, `Removed`, `Deprecated` or
      `Fixed` and list elements should be in that order. That is, all the `Added` elements should come first, followed by
      all of the `Updated` items, etc. For example, `Added OpenGL bindings`,
      `Fixed window not resizing correctly when -1 is passed`, etc. Note that beyond this first word rule, the ordering
      is completely arbitrary. Maintainers will likely reorder the changelist to highlight the most impactful changes
      first upon release, so don't worry about where you put your change in this list.
    - The list element can be followed by `(thanks @name)` if you would like to thank an non-maintainer/external
      contributor (or yourself, if you are an external contributor), where `name` is replaced with a GitHub username.
      Maintainers or other contributors that have an ongoing association/relationship with the project team can also do
      this but please be aware that this can seem like blowing your own trumpet. Feel free to comma-delimit multiple
      names as well e.g. `(thanks @Perksey, @curin)`.
- A blank line.
- Additional information about the release if necessary, denoted by a blank line if provided.

We encourage all contributors to add a change list element _as they're doing the change_. This is so maintainers don't
have to spend lots of time creating a conclusive changelog before releasing an update. This also means that the release
notes for next update _should_ already be started in `CHANGELOG.md` before the update is actually released. That is, a
second-level heading for the assumed next version should exist, ideally with a heading/title (or a placeholder). If this
isn't the case, please create one. This usually happens if you're working on the first thing after a release! For
example, if the latest release was `3.0.0`, you can likely assume that the next release is `3.1.0` (and we'll change
this later if it's not the case), resulting in a template like:

```
## 3.1.0

Silk.NET 3.1 Update

- Added <my release note here>.

```

Violations of these guidelines will be evaluated on a case-by-case basis, with maintainer approval. This is typically to
highlight overwhelmingly extravagant changes.

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
