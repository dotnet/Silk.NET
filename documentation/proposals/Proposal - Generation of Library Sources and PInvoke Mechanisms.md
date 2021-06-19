# Summary
Proposal design for a platform invoke (P/Invoke) mechanism for Silk.NET 3.0.

# Contributors
- Dylan Perks (@Perksey)

# Current Status
- [x] Proposed
- [ ] Discussed with Working Group (WG)
- [ ] Approved
- [ ] Implemented

# Design Decisions
- This proposal builds on the foundations laid out by Silk.NET's move to source generators in 2.0, and the introduction of the SilkTouch source generator as a result of this.
- This proposal assumes no knowledge of Silk.NET 2.0. 
- This takes the knowledge and insight gained during development of SilkTouch, and uses it to create a new set of generators which incorporate lessons learnt.
- This proposal breaks down the generator process into three distinct stages:

## SilkTouch Scraper

The Scraper is responsible for creating partial classes from some input source. It is a drop-in replacement for what BuildTools does today. Instead of doing all the parsing and interpretation of the input source ourselves, the proposed Scraper will instead use only C headers and have a "preburner" for gathering minimal metadata to feed into the generation process.

The generation process of the proposed Scraper will be entirely different. Silk.NET will no longer do any parsing and interpretation of C headers or XML of C headers, instead we will delegate this to the ClangSharp P/Invoke Generator in the form of a "subagent" (a separate process spun up by the Scraper), adding appropriate modifications to ClangSharp P/Invoke Generator as necessary. This means that we will no longer be using the Khronos XML registries for generating bindings. Instead, we'll use the preburner stage to use the XML registry only to gather minimal metadata instructing the ClangSharp subagent to add metadata attributes to certain functions, parameters, or types; which will then be picked up on by the later stages of SilkTouch. An example of such metadata would be parsing the flow and len XML attributes to add appropriate C# attributes to influence overload generation.

This also naturally makes us entirely dependent on an external dependency, but I propose we work with Microsoft as much as possible to add the functionality we need in the least breaking way possible, and in a way that satisfies both us and Microsoft. All designs for such modifications will be formalized in the ClangSharp repo. Should we fail to do this, we'll maintain a fork so we can still benefit from improvements made upstream, while giving ourselves the freedom to add the functionality we need.

Microsoft have already stated that they're happy to work with us to get Silk.NET using ClangSharp, one maintainer even saying they're happy to add a CI test stage into the ClangSharp repo to ensure no incoming changes break Silk.NET's generation process. 

## SilkTouch Emitter
The Emitter, one of the two final stages which should run in parallel and be entirely independent of eachother, is responsible for generating the actual indirect calls for performing the P/Invoke. This will use C# 9's Function Pointer system.

The Emitter operates on partial methods, the behaviour of the implementations of which depending on the context in which it's used.

### Function Tables (FTables)

The Emitter's primary purpose is to load and use function pointers in a native library sourced from an operating system's kernel. This logic will be emitted by the Emitter itself, and will not require an external dependency like the Silk.NET Core. However, this logic will no longer be implicit.

The Emitter requires a field on the containing type which can be indexed using an `int` and returns a `void*` upon being indexed. This field may be added by the Emitter, but is not implicitly added. You must tell the Emitter about the field, or whether the Emitter should add it.

Consider the following example:
```cs
[UseNativeLibrary("glfw3.dll")]
public class Glfw
{
}
```

# Proposed API
- Here you do some code blocks, this is the heart and soul of the proposal. DON'T DO ANY IMPLEMENTATIONS! Just declarations.

```cs
/// <summary>
/// Represents a grenade.
/// </summary>
public class SilkGrenade
{
    /// <summary>
    /// What does this do?!?
    /// </summary>
    public void RedButton();
    /// <summary>
    /// Detonates the grenade.
    /// </summary>
    protected void Kaboom();
    /// <summary>
    /// Gets or sets whether this grenade is disarmed or not.
    /// </summary>
    public bool Disarmed { get; set; }
}
```
