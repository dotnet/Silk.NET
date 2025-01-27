# Summary

Proposal for maintenance reform to encourage wider applicability of Silk.NET by encouraging community responsibility for a more diverse portfolio of bindings.

# Contributors

- Dylan P, Silk.NET 3.0 Cabal

# Current Status
- [x] Proposed
- [x] Discussed with Working Group
- [x] Approved
- [x] Implemented

# Conventions

Within this proposal, the key words **must**, **required**, **shall**, **should**, **recommended**, **may**,
**could**, and **optional** are to be interpreted as described in RFC 2199 [1]. The additional key word **optionally**
is an alternate form of **optional**, for use where grammatically appropriate. These key words are highlighted in the
proposal for clarity.

# Proposal

## Problem Statement

Silk.NET currently has a very high bar for bindings to be created under the Silk.NET umbrella. This is problematic because, although not for lack of trying [2], BuildTools was designed too heavily in tandem with Silk.NET (and to a small extent its predecessor OpenTK 4.0 for the period in which Silk.NET maintainers were responsible for its development) and did not scale well to non-Khronos and/or out-of-tree bindings. Despite the efforts in establishing the Silk.NET Community Program [3], obtaining bindings to other tangentially-related libraries that currently do not meet the Silk.NET team's criteria for inclusion under the Silk.NET umbrella remains problematic for users that are looking for the same level of reliability and/or trust vested in the Silk.NET brand as an extension of it being under the .NET Foundation umbrella. To this end, this proposal aims to:

1. Define our current criteria as best as we can.
2. Create an ownership and maintenance model that allows for expansion of our criteria for inclusion.
3. Codify the new criteria against the 3.0 development plan [4].

## Today's Criteria

We never formally wrote down the criteria for inclusion in Silk.NET prior to 3.0 (the "Current Criteria") so this criteria is based on the bindings portfolio as of 2.20.0 and the current consensus on the maintenance team with regards to our perception of what such criteria would look like and what we have rejected in the past.

In order for a binding to be included in the then-currently maintained version of Silk.NET prior to 3.0, all of the following criteria **must** be met:

1. The C API being bound to **must** have open-source headers that do not preclude the automated transformation to C# bindings without undue licensing provisions inflicted on users of such transformations. 
2. The C API being bound to **must** have at least one open-source implementation that is usable for the vast majority of use cases of that binding.
    - The Silk.NET team has in the past allowed implementations with copyleft restrictions (namely with regards to static linking a la LGPL) that don't apply on desktop but would apply on mobile.
3. The C API **must** be a recognised industry standard multimedia or compute API, aid in the creation of applications making use of such APIs, and/or used to implement a Silk.NET High Level Utility.
    - The "recognised industry standard multimedia or compute API" covers all Khronos APIs, OpenAL, and the 2.X portfolio of DirectX bindings.
    - The "aid in the creation of applications making use of such APIs" covers Assimp and Shaderc.
    - The "used to implement a Silk.NET High Level Utility" covers GLFW and SDL.

## Creating New Criteria

The guiding tenets for 3.0 are portability, maintainability, usability, and performance [4]. For the purposes of this proposal, we are focusing on maintainability and usability. Given the above derivation of requirements from the project's past operations, and the caveats justifying the derived wording, let's analyse problems faced:
- The Silk.NET team have in the past shied away from creating bindings where there are more than one well-known option for a given use case. An example is the Silk.NET team refusing to add bindings to Harfbuzz, with Kai J succinctly summarising this as "we don't really want to just bind to 25 text libraries in the hopes one of them works for everyone" [[discord](https://discord.com/channels/521092042781229087/521092043288608781/881085012869517312)]. The existence of multiple well-known options has limited our ability to determine a single distinct industry standard, and there is question on whether we should be trying to do that in the first place.
- The "recognised industry standard multimedia or compute API" has been the caveat referenced most in determining the inclusion of a given API, and often been used to justify the exclusion of very well-known libraries (e.g. bgfx [[discord](https://discord.com/channels/521092042781229087/607634593201520651/1152065639360495636)]) in the multimedia space. However, this has not precluded the inclusion of Assimp (which unfortunately, as with a lot of decisions made in the 1.X-2.0 development and transition period, went unquestioned meaning we can't gain any insight into the decision-making process).
- The "aid in the creation of applications making use of such APIs" caveat is the least applied caveat of the above. Given the previous point, we can conclude that this caveat was only utilised when the desire to stick with distinct industry standards exclusively was overcome by the usefulness as perceived by the maintainer(s) at that time. Ideally the new criteria would not be subject to such point-in-time opinionated decisions.

Fundamentally, Silk.NET's mission has always been to be the one-stop-shop for all multimedia needs. This has always been a key part of our project's brand, with wording such as "one-stop-shop" or "all in one product" being used in its README for the entirety of its lifetime, and is reflected in the usability tenet for 3.0. Yet depsite this, there are a few bindings to libraries that a significant proportion of the Silk.NET userbase all seek out, such as bindings for FreeType. Such bindings may not carry the same level of quality or flexibility in their implementation, and/or trust or reliability in their governance/maintenance. Further to the analysis of existing requirements above, the justification for not addressing these gaps may have been arbitrary and/or opinionated. We want to create a framework under which more bindings can be contributed by the community into Silk.NET itself to address ever-evolving user needs in more use cases than what we cover today, and streamline the inclusion and maintenance of such bindings.

## Code Ownership

There is no doubt that adding more bindings under the current governance structure will lead to an absurd and insurmountable quantity of significant maintenance burden on the Silk.NET maintenance team, which threatens the ongoing quality of such inclusions in addition to the existing portfolio of bindings. Therefore, the governance structure must also change with the change in criteria. To address this, a new role of "Bindings Owner" is proposed. To understand its relationship with the project going forward, we must also propose an amended definition of the existing project roles going forward.

A maintainer **shall** be responsible for all changes to project governance and directly responsible for all governance not explicitly delegated to any other party as part of this proposal prior to its supersession. They **should** review any incoming pull request to the Silk.NET monorepo affecting core functionality, core bindings, or other areas not delegated as part of this proposal. The maintainer is, of course, welcome to review other pull requests that don't fall under this definition, as with any community member.

A maintainer **must not** approve and/or merge any pull request that contains breaking changes that have not been justified under the guidance in the SDP [4]. A maintainer **must not** allow or make any substantial changes to the High Level Utilities (HLUs) available to users without a proposal approved by the Working Group. A maintainer also **must not** allow or make any changes that fundamentally affect how larger portions of the library are developed and/or used without a proposal approved by the Working Group. For the purposes of this proposal, a HLU is defined as a C#-friendly API that eases the usage of bindings provided by Silk.NET that either deviates noticeably from the original API on which the API is based or that is targeting wider applicability outside of the context of a single binding.

The addition or removal of a maintainer **must** be approved by a majority of all existing maintainers. There is no defined process for conflict resolution in the event of a vote failing to form a conclusive answer, but it is **recommended** that the maintainers communicate with the Working Group in these cases.

For all other governance or project direction topics, the maintainers **must** obtain approval from the Working Group, ideally through a proposal.

For the avoidance of doubt, Silk.NET.Core is not a HLU but a maintainer **should not** allow any functionality that is not applicable to more than one Silk.NET project to be included in this project.

Maintainers **must** ensure that all .NET Foundation project guidance is being followed. Maintainers **must** ensure that the project contains a contribution guide representative of current processes. Any responsibilities not explicitly defined in this proposal **shall** vest in the maintainers.

The maintainers **shall** carry these responsibilities until their resignation or until they are changed, where changes **must** be approved by both the maintainers and the Working Group (e.g. in proposals such as this one).

A contributor **may** submit changes to the Silk.NET project for inclusion as a contribution as defined in the contribution guide provided by the maintainers, requesting approval as necessary. A maintainer **should** be an active contributor. For any code changes that a maintainer can't approve without a proposal as defined in the role of the maintainer, the contributor **should** provide a proposal (ideally before implementing such code changes). A contributor **must** follow all guidance outlined in the contribution guide.

The .NET Foundation **shall** be responsible for continuity of the project beyond any one maintainer, and **should** allow a .NET community member to gain access to all project resources and become a maintainer should all maintainers be uncontactable, unavailable, and/or otherwise unable to perform their duties as defined in this proposal. The .NET Foundation **must** follow any processes and/or guidelines defined by the .NET Foundation Projects Committee for determining how and when to act in its role defined here.

The .NET Foundation **may** provide additional project resources in line with the resources available to its Project Committee and the support provided to other .NET Foundation projects, following processes and guidelines defined by the Projects Committee. The .NET Foundation **must** provide a process for requesting project support. Maintainers **must** ensure that .NET Foundation operators have access to all resources created in the project's name.

The .NET Foundation **must** ensure all maintainers are part of the [dotnet/silk-dotnet](https://github.com/orgs/dotnet/teams/silk-dotnet) team or otherwise have administrative access to all GitHub resources, and **must** allow existing maintainers to elect new maintainers as defined in this proposal. All copyright **shall** vest in the .NET Foundation, and the .NET Foundation **shall** carry any legal responsibilities conveyed by the project's license.

The Silk.NET Working Group **shall** consist of anyone who would like to be involved in conversations shaping the future of Silk.NET, typically indicated by participation in Working Group meetings or expressing interest in doing so. A Working Group member **should** discuss incoming proposals on topics defined in this proposal in meetings initiated by maintainers. A Working Group member **may** voice objections to such proposals and cast votes on maintainer-initiated votes.

Lacking any objections to a proposal from any Working Group member or, where there are objections, justification by the majority of participants in the Working Group at that time; a proposal **shall** be deemed approved. In the case of objections, the Working Group **must** give detailed feedback rather than being an unelaborated rejection of a proposal. Maintainers and contributors submitting proposals **should** reissue the proposal with that feedback taken into consideration if it is not withdrawn.

Given the above definitions, we can identify the following key points:

1. The problem space for a maintainer vests primarily in core functionality and core bindings, but we have not defined what this is and what lies beyond this yet.
2. Nothing changes with how we operate the proposal process today, namely HLUs or larger scale changes can't make it in without a proposal.
3. Through uses of words of "substantial" and "noticeably," maintainers do not have to require a proposal as has been the case in the past with Silk.NET, obviously trusting maintainers to make those calls. It has always been our intention to allow benign additions without bureaucracy to ensure the library improves at a steady pace and that contributors remain undeterred for trivial contributions.
4. The HLU defintion intentionally allows for C#-friendly APIs to be created around bindings without misrepresenting the underlying bindings' concepts without Working Group approval.

### Core Bindings

Expanding on point 1, this is where the existing criteria comes into play. In this section we will discuss how we should modify the current criteria to draw the line for maintenance burden if we proceed with this proposal.

A "core binding" **shall** be defined as follows:
1. The API being bound to **must** be two or more of the following as determined by the maintainers team:
    1. An API existing in the multimedia and/or compute space, or aiding in the creation of applications making use of such APIs.
    2. Used as a dependency by a Working Group approved HLU, Silk.NET core functionality, or a Silk.NET core binding.
    3. An API developed by a multi-vendor standards team/body, or an API with notable industry presence otherwise implemented by multiple vendors and/or developed in collaboration with those vendors. 
2. The C API being bound to **must** have headers licensed such that the automated transformation to C# bindings is allowed without undue licensing provisions inflicted on users of such transformations.

A Core Binding **shall** retain its Core Binding status for the entire lifetime of a major version cycle as defined in [4].

All Khronos and DirectX APIs meet both requirements 1.1 and 1.3. OpenAL also meets this requirement based on its historical development. GLFW and SDL both meet these requirements today given that the Windowing HLU requires both of them in 2.X, their continued status as "core binding" is dependent on what the final implementation of the Windowing 3.0 proposal [5] uses. 

Based on these definitions, Assimp and Shaderc would no longer carry "core binding" status.

### Additional Bindings & Bindings Owners 

We have now narrowed the scope for the maintainers team sufficiently to keep maintenance load bareable, however we still have not yet expanded the scope of the library as a whole. To achieve this proposal's goals, we can define a new role in the Silk.NET governance structure: the Bindings Owner.

A Bindings Owner **shall** be responsible for all changes to and ongoing maintenance of the Additional Bindings they are assigned to. An Additional Binding **shall** be defined as a binding that does not meet the Core Binding definition but has been approved for inclusion in the Silk.NET library by a maintainer. Contributors contributing entire bindings **must** acknowledge the Additional Binding definition in this proposal prior to their contribution being approved by a maintainer, and **must** agree to become the Bindings Owner of the binding if they are the first contributor of that Additional Binding. Bindings Owners **may** nominate further Bindings Owners to share the responsibilities pertaining to the Additional Binding as defined in this proposal, provided they acknowldge these undertakings, by contacting the Silk.NET maintainers.

Additional Bindings to retain their eligibility as Additional Bindings **shall** be governed by the maintainers team using the governance structure of the Silk.NET Community Program also operated by the Silk.NET maintainers team. For the purposes of this proposal, this is defined as follows:
1. An Additional Binding **must** use Silk.NET low-level interoperation technology (i.e. SilkTouch), and remain consistent with the practices of the wider Silk.NET library.
2. An Additional Binding **must** remain stable enough to be served to the Silk.NET userbase in a good enough state that our userbase can start integrating the Additional Binding into their work.
    - Betas and pre-releases are okay (but these **must** be coordinated with the maintainers team), so long as the primary advertised functionality works (i.e. it "does what it says on the tin") 
3. An Additional Binding **must** serve a use case which the Silk.NET maintainers team recognises as best served with a Silk.NET binding, and they believe that the Additional Binding is useful when building libraries and applications that use Silk.NET.
4. The Bindings Owners meets the requirements for Silk.NET Community Project Maintainers as defined by the Silk.NET Community Program.
5. Both the Bindings Owners and Additional Binding **shall** be subject to any other Silk.NET Community Program requirements not listed here [6].

Where Additional Bindings are not fully classed as stable, as agreed by the Bindings Owners and the Silk.NET Maintainers, Additional Bindings packages should use a version suffix to indicate this. This should not impact other unrelated Silk.NET packages i.e. the version suffix is only applied to the Additional Bindings.

The Silk.NET maintainers **must** ensure that Additional Bindings and Bindings Owners are in compliance with these requirements on an ongoing basis and, if arrangements cannot be made to bring the Additional Binding into compliance with these requirements, the Additional Binding **must** be excluded as a Silk.NET artifact as published to NuGet. An Additional Binding that is not compliant **should** only be removed from the repository if it poses a maintenance concern for the maintainers. 

Additional Bindings **may** define additional APIs that do not deviate noticeably from the API being bound to or that do not target wider applicability outside of the context of that specific Additional Binding. This could include C#-friendly wrappers for instance, provided these do not attempt to abstract the original API in any noticeable way (small utility functions are acceptable however). If compliance with this requirement is in doubt, a Bindings Owner **should** contact the Silk.NET maintainers team. Bindings Owners **may** introduce larger-scale HLUs (i.e. that abstract away the original API or target wider applicability beyond the scope of the Additional Binding), but such APIs **must** be held to the same standard of scrutiny as all other APIs approved by the Working Group and use a review process similar to the Working Group's policy. Namely, such reviews **must**:
1. Require proposal documents to be submitted to the main GitHub repository
2. Be hosted in a public forum (Discord and/or YouTube)
3. Accept comments from anyone as per the Working Group meetings
4. Be recorded so prior decisionmaking can be readily accessed for influencing future decisionmaking
5. Require a majority approval from Bindings Owners of the Additional Binding in question, no unaddressed objections from any participants in the review process (an objection may be deemed irrelevant by a Bindings Owner majority, but this must be formally addressed, documented, and agreed by the original objector), and one Silk.NET Maintainer approval _only_ to attest that proper process has been followed.

In addition, if the proposed HLU overlaps with another Additional Binding's problem space, Bindings Owners of such bindings must also approve proposals using the above process. If the proposed HLU overlaps with a Core Binding, then the HLU must undergo the same scrutiny as core HLUs such as Windowing, Input, and Maths i.e. through the project-wide Working Group.

Silk.NET Maintainers **shall not** raise any objections outside of a Community Meeting/API Review for an Additional Binding (as defined above) - maintainers are an equal participant in such meetings and do not have special veto rights. Provided the process defined above is followed, such vetos would not be required.

Bindings Owners **shall** review and merge pull requests to their assigned Additional Bindings. Bindings Owners **shall** be granted limited write access to the Silk.NET repo, and given a branch prefix they can use by the maintainers. The maintainers **shall** maintain a CODEOWNERS file and branch protection rules to allow Bindings Owners to merge pull requests independently of the Silk.NET maintainers.

Bindings Owners are expected to be aware of the monthly shipping schedule. Additional Bindings **must not** hold up library updates, and any changes that are in the `main` branch at the time the library update is released **shall** be released as is at that time. Bindings Owners are expected to keep incomplete changes on a separate branch using their branch prefix.

Bindings Owners **must not** approve and/or merge any pull request that contains breaking changes that have not been justified under the guidance in the SDP [4]. If compliance with this requirement is in doubt, a Bindings Owner **should** contact the Silk.NET maintainers team.

Additional Bindings **must not** adversely affect other parts of the library (including other bindings). Wider-scale changes that reach beyond the scope of the Additional Binding are subject to the usual contribution rules as if it were core functionality or a core binding.

Maintainers **shall** be responsible for ensuring Bindings Owners and Additional Bindings are able to operate under these requirements.

# References

- [1] S. Bradner, “RFC 2119 - Key words for use in RFCs to Indicate Requirement Levels,” Mar-1997. [Online]. Available: https://www.ietf.org/rfc/rfc2119.txt.
- [2] B. Thomas, "JackCS," Feb-2023. [Online]. Available: https://github.com/SilkCommunity/JackCS.
- [3] D. Perks, "Announcing the Silk.NET Community program," Jan-2022. [Online]. Available: https://dotnet.github.io/Silk.NET/blog/jan-2022/silkcommunity.html
- [4] D. Perks et al, "3.0 & 3.X Software Development Plan," Nov-2023. [Online]. Available: https://github.com/dotnet/Silk.NET/blob/main/documentation/proposals/Proposal%20-%203.0%20%26%203.X%20Software%20Development%20Plan.md
- [5] D. Perks et al, "Windowing 3.0," Aug-2022. [Online]. Available: https://github.com/dotnet/Silk.NET/blob/main/documentation/proposals/Proposal%20-%20Windowing%203.0.md
- [6] D. Perks et al, "Silk.NET Community," Sep-2021. [Online]. Available: https://github.com/SilkCommunity/SilkCommunity

# Meeting Notes
## 26/01/2025

[Video](https://www.youtube.com/live/jNIAH2raTMY)

- Approved subject to these comments.
- Version suffixes should be used for betas, specifically for bindings that are not quite stable but still meet the requirements. Those suffixes apply only to those additional binding nuget packages.

