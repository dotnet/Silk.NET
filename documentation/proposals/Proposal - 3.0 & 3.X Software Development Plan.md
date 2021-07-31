# Summary

3.0 software development plan & ongoing monthly update, breaking change, and support policy for 3.X.

# Contributors
- Dylan P (@Perksey)

# Current Status
- [x] Proposed
- [ ] Discussed with Working Group
- [ ] Approved
- [ ] Implemented

# Silk.NET 3.0

## Goals of 3.0

The key tenets of 3.0 are **portability**, **maintainability**, **usability**, and **performance**. To this end, the following objectives have been identified:
- Use .NET 6 - the first version of modern .NET to run on the majority of our desired target platforms
    - (tenet: portability) 
- Allow Silk.NET's rich abstractions to be integrated into other frameworks rather than being completely standalone.
    - WPF, WinForms, MAUI, Avalonia (tenet: usability) 
- Rewrite windowing to be more portable and facilitate true write-once-run-everywhere.
    - For more information, see [the Windowing 3.0 proposal](Proposal - Windowing 3.0.md). (tenet: portability)
- Remove the bulk of our bindings generation code in favour of more mature alternatives
    - For more information, see [the SilkTouch 3.0 proposal](Proposal - Generation of Library Sources and PInvoke Mechanisms.md). (tenet: maintainability)
- Accelerate our maths library using SIMD hardware intrinsics
    - For more information, see [the Vectorization SIMD proposal](Proposal - Vectorization - SIMD.md). (tenet: performance)
- Enhance our input library to add more functionality and future-proof it against future functionality additions.
    - For more information, see [the Enhanced Input Events proposal](Proposal - Enhanced Input Events.md). (tenet: maintainability)
- Refactor our input library to work in multiple scenarios and environments
    - For more information, see [the Multi-Backend Input proposal](Proposal - Multi-Backend Input.md). (tenet: usability)

Silk.NET 3.0 presents us with an opportunity to rethink the entire library taking into account everything we've learnt over the past 2 years of the project's development.

## Development Roadmap

Note that this development roadmap does not take into account unit tests, only functional tests such as experiments. The team should of course stride to add as many tests as possible where possible.

### 3.0 Preview 1

Before we can do anything, we need to get our brand new generators up and running. In this version:
- The Scraper works as a minimum viable product. It has minimal support for adding extra attributes for invoking overloaders.
    - The Khronos APIs in particular will likely be incomplete compared to 2.X in this version. 
- The Emitter works completely as intended.
- The Overloader works as a minimum viable product. It doesn't necessarily implement all overloads specified yet.
- Windowing and Input are implemented for desktop platforms, and have received initial testing.
- No development on Maths for this preview.
- Exclusive support for .NET 6

3.0 Preview 1 is not a production-ready preview and is very experimental. This preview should aim to release in early September.

### 3.0 Preview 2

Now that we've got an initial preview out to show what our aims are, we can start refining everything. In this version:
- Bugfixes from 3.0 Preview 1
- The Scraper has near-complete support for adding extra attributes for invoking overloaders.
- The Overloader has more overloads implemented. All generic overloads should be implemented by now, but some API-specific overloads may not be implemented.
- Android support has been restored for Windowing and Input, and have received initial testing on this platform.
- No development on Maths for this preview.

3.0 Preview 2 is not a production-ready preview and is very experimental. This preview should aim to release in late September.

### 3.0 Preview 3

By this preview, the groundwork has been established for 3.0 and we should ensure that all of our goals have ample progress towards the end product. In this version:
- Bugfixes from 3.0 Preview 2
- The Scraper is complete.
- The Overloader is complete.
- iOS support has been added for Windowing and Input, and have received initial testing on this platform.
- If time permits, a start has been made on the SIMD APIs in Maths. No work has been done on integrating it into the other Maths types.

3.0 Preview 3 is not a production-ready preview and is very experimental. This preview should aim to release in early October.

### 3.0 Preview 4

This is the first "production-ready" preview and we want users to start integrating into their workloads, so we need to make sure good progress has been made to all goals for the 3.0 update and as many forseeable breaking changes as possible done. In this version:
- Bugfixes from 3.0 Preview 3
- Windowing integrations for WPF and WinForms have been developed and have at least basic OpenGL support. The support may not be the most high performance possible at this time.
- SIMD APIs in Maths have been complete, and work has started to integrate them into the other Maths types in the most common cases.
- Ample work has been done to migrate 2.0 code to 3.0 code to evaluate differences in public API, fixing them where we deem necessary.

3.0 Preview 4 is a production-ready preview and users are encouraged to start integrating this preview into their code. This preview should aim to release in late October.

### 3.0 Preview 5

This is the last preview and is primarily a bugfix release. All breaking changes should've been done in previous previews, but if this is not the case all forseeable breaking must be 100% done in this preview. In this version:
- Bugfixes from 3.0 Preview 4
- A windowing integration for MAUI has been developed and has at least basic OpenGL(ES) support in a state that is as high-performance and as smoothed-out as possible.
- If time permits, a windowing integration for Avalonia has been developed and has at least basic OpenGL(ES) support. If there is not enough time, this can be pushed to 3.X.
- SIMD APIs should be integrated into Maths in as many common cases as possible. Ongoing performance improvements may be done in 3.X. This preview should aim to release in early November.

## Problems identified in past development

- We have severely lacking documentation
    - The intention is that all developers of large amounts of code write implementation documentation and/or "orientation guides" for their codebases informing readers of all major things there is to know in their code.
    - We should also write documentation containing examples on using as many features of the surface APIs as possible \[for high level utilities\]
    - We will enforce XML documentation in all manually-written utilities and as much as possible in bindings.
    - If time permits, we should productionize our website powered by Raisin.
- There's not a lot of planning
    - We have solved this in the form of the proposal you are reading and all linked proposals: getting all the design done now and documented now, to prevent design debates later down the line. This should reduce friction when actually working on the library.
    - We have been keeping the working group and key stakeholders in the loop with the 3.0 kickoff (again, see this proposal you are reading)
    - The team are trying to communicate with eachother and figure out how to distribute work among themselves depending on individual circumstances and free time
        - Codeowners have been established
- Barrier to entry for external contributors is very high
    - Documentation should help with this.
    - We should at least consider introducing something like stylecop to ensure code is readable and easy to navigate.
    - We should look to make a general repo "orientation guide" teaching prospective contributors where they can find to expect what codebases.
    - Hopefully we can pick up some external contributors along the way so _they_ can tell _us_ how to improve?
- Our level of correctness is inconsistent
    - We should use .NET 5 enhanced warnings to help combat this.
    - Our adoption of C# 8 nullability should be at a much greater extent than it is today, and not using nullability should require great justification.

# Silk.NET 3.X

## Monthly Updates

Silk.NET has been proven to excel at binding to OpenGL with games and applications such as [Project Hedra](https://projecthedra.com), a game made by @maxilevi; and [a clone of The Settlers](https://github.com/Pyrdacor/Freeserf.Net) made by @Pyrdacor.

One thing we want to place an emphasis on is our commitment to actually keeping Silk.NET up-to-date. The schedule will be that on the **first Friday of the month**: The working group will evaluate recent changes with the Silk.NET codebase and related upstream resources. If the working group warrants that a patch fix is needed, a patch will be pushed to NuGet on this day.

We have a lot of bindings by now and the libraries we bind to change all the time. As such, monthly updates are critical to ensure our bindings are regenerated and are as up-to-date as possible. Bugfixes found over the month will be swept up in these monthly updates.

### Emergency Patches

If a bug is determined (agreed upon by the majority of maintainers) to be causing massive disruption to the point where the library is borderline unusable in some or all use cases of the library with a considerable proportion of the userbase affected, an out-of-cycle "emergency patch" may be issued on any other Friday between updates.

### Versioning

Any post-3.0, pre-4.0 release will be versioned as follows:
- The major version will always be 3
- The minor version will be the number of the monthly update cycle i.e. the first monthly update will be versioned 3.1, the second 3.2, etc...
- The patch version will always be 0, unless it is an emergency patch in which case it'll be the number of the emergency patch i.e. if an emergency patch is required after the first monthly update the version will be 3.1.1, if another one is required (heaven forbid) in this same cycle it'll be 3.1.2 etc...
- The revision version will always be 0.

Users are expected to keep all of the versions of all Silk.NET packages they are using in-sync. We could write a Roslyn analyser or MSBuild target to help push users to this.

### Breaking Changes

If an API is determined (agreed upon by the majority of maintainers to be causing massive disruption or widespread confusion among a considerable proportion of the userbase, the Silk.NET team may reserve the right to make a breaking change in a post-3.0, pre-4.0 update as part of a monthly update cycle. This class of breaking changes shouldn't be done in an emergency patch unless the API issue in question was introduced in the then-current monthly update cycle (e.g. we need to quickly remove an API because it's super problematic for lots of people)

Breaking changes in generated sources caused by changes in a third-party/external source the generated sources are generated from are allowed.

ABI breaks may be allowed, but should be deferred unless absolutely necessary, so long as they are not source breaking - benign given all versions are in-sync, the only scenarios which could be affect is reflection.

Additive changes which introduce a break are forbidden in a post-3.0, pre-4.0 update.

### Support

There are currently no plans to officially support anything but the latest monthly update i.e. the end-of-life date of a particular update is as soon as the next monthly update is released. Users are expected to be aware or made aware of the monthly update schedule and plan their work and/or support needs accordingly.

Individual developers on the team may diverge from this, but they will be responsible for any support they give outside of this notice. If this changes and the Silk.NET team opt to introduce another support option, this proposal (or a future proposal which supersedes this one) will be updated accordingly and discussed with the Working Group.
