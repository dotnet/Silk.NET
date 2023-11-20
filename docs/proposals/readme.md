# Proposals
Similar to the C# team, we use API proposal documents to discuss the surface API of Silk.NET. We only do this for **new modules and subsystems**, however (you won't need to make a proposal for *just one function*)

# Workflow
Our API proposals go through this process:
- Proposed
- Discussed with Code Owners
- Revision (if applicable)
- Approved/Rejected
- Implementation in the library itself

# What's the point
We use API proposals as a way for ironing out the Silk.NET API before actually implementing it in the library. This reduces fuss come reviewing the library PR, and allows another contributor to pick up where another left off, should an implementation PR become stale/inactive.

# New Proposals
Here's the template new proposals should follow: [template-proposal.md](template-proposal.md)
