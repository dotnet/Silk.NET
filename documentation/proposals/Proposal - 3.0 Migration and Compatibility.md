# Summary

Proposal strategy for achieving some ABI compatibility with Silk.NET 2.X in Silk.NET 3.0

# Contributors
- Dylan P (@Perksey)

# Current Status
- [x] Proposed
- [x] Discussed in Community Meeting
- [x] Approved
- [ ] Implemented

# Introduction

Since the release of Silk.NET 2.0, several high-profile projects such as Uno Platform and the Stride game engine have
taken a dependency on Silk.NET. Both of these examples can be considered "developer platforms" - a framework that is
pulled in by an end developer, who in turn pulls in Silk.NET. We have no control over what version the end developer
ultimately pulls in when Silk.NET is pulled in as a transitive dependency. As a result, the current fully-breaking
Silk.NET has the following options:
- The developer platform can upgrade to Silk.NET 3.0. When the end developer updates the developer platform, all end
  developer code making use of Silk.NET (e.g. as a UI control in the case of Uno Platform) will require updating before
  the end developer's application can be compiled again. 
- The developer platform can stay on Silk.NET 2.X. The end developer will be unable to pull in any Silk.NET 3.0 assembly
  due to the ABI incompatibility, meaning we ultimately have entire classes of users stuck on Silk.NET 2.X.

Neither option is particularly great, and both are likely to cause irreparable reputational harm to Silk.NET. Notably,
projects such as Avalonia have hesitated taking Silk.NET on as a dependency from the very start because of these
concerns. By proceeding with 3.0 development as it currently stands, we risk encouraging our largest users removing
Silk.NET from their dependencies because, from their perspective, they have absolutely no idea when another Silk.NET
update is going to completely break that platform.

However, we must recognise that sweeping breaking changes are key to Silk.NET 3.0's success. The current Silk.NET, while
usable and seemingly appreciated by users, has major flaws that massively impact the practicality of some of its
bindings. The largest (but not only) example of this is the DirectX bindings, where the extension method strategy
introduced in 2.17 massively improved usability of the `ComPtr` constructs but severely at the cost of IDE performance.
3.0 necessarily reworks the Windows SDK/COM bindings model entirely, and has resulted in a much nicer user experience.
However, if the existing API is reintroduced for compatibility reasons, all of those improvements are rendered moot
because we haven't solved the actual underlying problem that led to that terrible IDE performance: the unnecessarily
exhaustive API provided in the name of usability (but ultimately led to the exact opposite in a not-insignificant number
of cases).

To recap, we are unable to have a clean break from the 2.X API because doing so would alienate a lot of users and cause
a lot of problems with users trying to make use of resources that have emerged that make use of 2.X, and we are also
unable to keep the 2.X API because doing so would completely negate the entire 3.0 effort. So what do we do? The
solution: ABI compatibility only. This proposal discusses a mechanism for retaining ABI compatibility without API
compatibility, so existing code compiled against Silk.NET 2.X will continue to function but any code that is
intentionally compiled against Silk.NET 3.0 has only the 3.0 API available to it.

# Proposed Design

Each Silk.NET 3.0 assembly that has a matching 2.X counterpart shall use the ABI compatibility mechanism.

The ABI compatibility mechanism involves implementing all APIs declared in the compiled 2.X assembly in terms of newer
3.0 APIs. For bindings, this is likely to be achieved through a generation step. For HLUs (including Silk.NET.Core),
this will unfortunately be a manual process. ABI compatibility will be tracked and is expected to incrementally improve
over the course of the preview cycle.

An API that exclusively exists for the purposes of ABI compatibility shall be marked with `[Shadow]`, be guarded with a
`ABI2_COMPATIBILITY` preprocessor guard, and ideally live in a separate `partial` in a dedicated `Abi2` directory of
that project. This is to improve the Silk.NET contributor experience.

If a 2.X instance method conflicts with a 3.0 static method, a separate class will be created suffixed with `Shadow` and
that class will have a `[Shadow<T>]` attribute where `T` is the original class. This is not a conflict from the
runtime's perspective (it is valid to have an instance method and a static method with the same parameters), rather the
language's perspective.

An application will be created that ingests a **reference assembly** and a **compiled DLL** (referred to herein as the
"rewriter"), and this will be integrated into our MSBuild targets. The rewriter will remove all member APIs that are
marked with `[Shadow]` from the **reference assembly**, however it will retain the types to ensure that IDEs do not get
confused when trying to resolve a type reference from code compiled against 2.X. It is expected that types that only
exist for ABI compatibility reasons will also have an `Obsolete` attribute with an appropriate message, and ideally a
mechanism for extracting the corresponding 3.0 functionality (if applicable) from that type (i.e. so 3.0 code can still
make use of external libraries that were compiled against 2.X in terms of the 3.0 API set). Any types marked with
`[Shadow<T>]` will be removed from the **reference assembly**, and any member APIs of such a type will be moved to
`T` in the **compiled DLL**. 

**NOTE**: Reflection compatibility is not a scenario we care about for the purposes of this proposal - it is an explicit
non-goal.

# Migration Story

With this design, IDEs that pull in a Silk.NET 3.0 assembly and a library compiled against a Silk.NET 2.X assembly will
still be functional as all 2.X APIs exposed in the library's signatures will be resolvable (as they have not been
removed from the **reference assembly**) and at runtime all APIs will be resolvable in the **compiled DLL** (but the IDE
won't see them and therefore we won't discourage use of new APIs, inhibit IDE performance, or otherwise do anything to
negate the 3.0 effort). When using that library, low cost conversions to/from 3.0 types will be used to ensure the
functionality the library provides can actually be used.

**NOTE**: To reuse the Uno Platform example, it is still the case that when they upgrade to 3.0 their users will need to
upgrade as well if they're making use of Silk.NET in their code, but the important thing is that this is in control of
the developers of those platforms and them choosing not to upgrade doesn't prevent the end developer manually pulling in
3.0, whereas this would not be possible without ABI compatibility.

Notably, this ABI compatibility mechanism also presents a nice migration story from 2.X to 3.0 for direct users of
Silk.NET, in that such migrations can be incremental by simply having one project that references 2.X, and one project
that references 3.0 and the project that makes use of 2.X. We will still need to provide migration documentation that
described this, but this reduces the burden in having to explain every change between 2.X and 3.0 for the purposes of
having a migration story. It also alleviates the need to maintain 2.X and 3.X in parallel for those that don't want to
migrate fully.
