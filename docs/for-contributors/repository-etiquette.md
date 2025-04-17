# Repository Etiquette

## Branching

Do not create any branches that are uncategorised e.g. always make a `feature/` branch or a `hotfix/` branch (or
literally any other category except those reserved below so long as there is a category). The current major version of
Silk.NET will always be developed on `main`, and the next major version of Silk.NET will always be developed on
`develop/X.0` where `X` is the next major version. There shall only at most one `develop/X.0` branch at a time i.e. we
won't be working on two future major versions in parallel. These assumptions are relied upon as part of the
[Website building process](Website/README.md).

**FUTURE IMPROVEMENT**: Note that there are impending changes here from the [Project Governance, Bindings Expansion and Ownership](https://github.com/dotnet/Silk.NET/blob/cd66e218ee891502d05070e356d514ed1197a541/documentation/proposals/Proposal%20-%20Project%20Governance%2C%20Bindings%20Expansion%20and%20Ownership.md)
proposal that has been approved by the working group. The restrictions laid out here apply, but there are further
restrictions for some specific scenarios that are yet to be realised that need to be pulled into this document. Note
that this proposal is a good resource for anything not mentioned in the for-contributors docs that details *how* we
work.
