# Summary
Proposal design for a platform invoke (P/Invoke) mechanism for Silk.NET 3.0.

# Contributors
- Dylan Perks (@Perksey)
- Kai Jellinghaus (@HurricanKai)
- Andrew Davis (@Curin)

# Current Status
- [x] Proposed
- [x] Discussed with Working Group (WG)
- [x] Approved
- [ ] Implemented

# Design Decisions
- This proposal builds on the foundations laid out by Silk.NET's move to source generators in 2.0, and the introduction of the SilkTouch source generator as a result of this.
- This proposal assumes no knowledge of Silk.NET 2.0's SilkTouch. 
- This takes the knowledge and insight gained during development of SilkTouch, and uses it to create a new set of generators which incorporate lessons learnt.
- Text herein marked **INFORMATIVE** does not form a normative part of this proposal, and is for background only.
- Within this proposal, the key words **must**, **required**, **shall**, **should**, **recommended**, **may**, **could**, and **optional** are to be interpreted as described in [RFC 2119 - Key words for use in RFCs to Indicate Requirement Levels](https://www.ietf.org/rfc/rfc2119.txt). The additional key word **optionally** is an alternate form of **optional**, for use where grammatically appropriate. These key words are highlighted in the proposal for clarity.

# INFORMATIVE: Points of Contention in 2.X

## API Objects

In Silk.NET 1.0 Previews 1-3, AdvancedDLSupport was used which used System.Reflection.Emit to generate function pointer calls at runtime. It did this by implementing abstract methods, and therefore an API object was required. In 1.0 Preview 4 Ultz's SuperInvoke library was used instead, which was an MIT-licensed clean-room implementation of AdvancedDLSupport produced in response to community confusion over the license grant that made Silk.NET users exempt from AdvancedDLSupport's LGPL license. It used the same abstract method mechanism.

In Silk.NET 2.X, a source generator was used instead, which became SilkTouch. SilkTouch was developed when source generators and function pointers were still in heavy development and not even in preview yet, and as a result they were not well understood at time of development. In this respect SilkTouch was too bleeding-edge, as its usage of source generators have been realised to be less than ideal and somewhat abusive of what source generators were meant to do. This was first acknowledged by Kai, SilkTouch's creator, in his [November 2020 blog post](https://dotnet.github.io/Silk.NET/blog/nov-2020/silktouch-invokes-marshalling.html) on SilkTouch. In addition, because its development had completed and was effectively on maintenance mode by the time 2.0 was in full release, innovations that came after this point were rarely wielded, such as the incremental source generator API.

One of the mistakes in hindsight that 2.X made was stick to the 1.X model of API objects, which was already disliked by a small subset of the Silk.NET community. There wasn't really any discussion around this decision, it was just naturally made during SilkTouch's initial tasking: "replace `abstract` with `partial`, and Bob's your uncle". This decision was felt the most when the Clang backend of BuildTools came online, and bindings to traditional C/C++ libraries that objectively should be static methods were instead using the same API object mechanism designed for the Khronos bindings.

## BuildTools Portability

Before Silk.NET started development, Dylan Perks (@Perksey) and Jarl Gullberg (@Nihlus) were maintainers of the OpenTK project focusing on developing the OpenTK 4.0 rewrite project. The majority of their work focused around rewriting the various generators that OpenTK was using to generate its OpenGL bindings (namely [Generator.Bind](https://github.com/opentk/opentk/tree/70c36adba8ccad34f15584e75cabc0e0f5aebb2f/src/Generators/Generator.Bind) and [Generator.Convert](https://github.com/opentk/opentk/tree/70c36adba8ccad34f15584e75cabc0e0f5aebb2f/src/Generators/Generator.Convert)), although significant work on the [OpenAL bindings](https://github.com/opentk/opentk/tree/70c36adba8ccad34f15584e75cabc0e0f5aebb2f/src/OpenAL) was also done by Jarl to act as a demonstration of what the generator's bindings infrastructure should look like. Upon their departure from Silk.NET, OpenTK 4.0 was unwinded back to a form that looked more familiar with OpenTK 3.0, and Dylan founded Silk.NET and contacted Jarl for permission to include the OpenAL bindings verbatim into Silk.NET - to this day these bindings remain for the most part unchanged from their original form in their version of OpenTK 4.0. In addition, Dylan brought forward the rewritten generators, and merged them into a single generator called BuildTools.

This history is important to illustrate just how intertwined OpenGL and BuildTools were, and how easily issues arose when future tasking let to more advanced bindings generation mechanisms being retro-fitted into a bindings model that fundamentally was not built for it. BuildTools has multiple backends, but it still all boils down to the same object model and generation mechanisms, which did not prove extensible especially for the later Clang-based bindings (e.g. the COM-based Windows SDK). This, combined with the the API object concept, meant using these bindings felt completely foreign to use compared to other alternatives such as the .NET Foundation's TerraFX library.

## Excessive Overloads

One of the areas of BuildTools that has gone through the largest number of iterations is the overloader. OpenTK was (in)famous for the concessions it made in API accuracy for the sake of usability. For instance, `IntPtr` often was given an `int` overload, for CLS compliance unsigned numbers were replaced with signed ones, and there were a slew of other overloads which made OpenTK very usable but did not match the 1:1 ethos of Silk.NET. Because of this, the overloader was rewritten to provide some overloads of similar usability as well as some original overloads too.

1.0 Preview 1 was shipped with array (including generic arrays) and ref overloads, along with function-transforming overloads such as the overloaders that handled `glDelete`, `glGen`, etc. The later previews and releases expanded on this. However, a consistent item of feedback throughout the entirety of 1.X's lifecycle is that the overloads did not feel sufficient or were inconsistently applied (e.g. if you had one parameter using an overloaded variant, the other parameters would not be overloaded). This resulted in a lot of tradeoffs in user code in where to use `unsafe` code, and most users just ended up using the unsafe variants always.

This was [attempted to be addressed](https://github.com/dotnet/Silk.NET/pull/275) in 2.0 Preview 2 (back when the only Clang-based bindings were SDL and Assimp), and for the most part our users are a lot more satisfied with the overload situation in 2.X from a code-cleanliness perspective. The new overloader would generate every single permutation of overloaded parameters to allay complaints of inconsistency from users. However, this had another unintended side-effect in that the IDE experience was now terrible due to the shear quantity of overloads produced. In the early days of Silk.NET 2.0's development cycle this was acceptable, and the Silk.NET developers (both on the Silk.NET team and in the community) clearly grew comfortable enough with it such that this mechanism was never questioned again before Silk.NET 2.0's initial release.

Later on in 2.X's cycle, this mechanism became more and more called into question, given that as more overloaders were added the problem was compounded. The most famous examples came  when we were adding new bindings with all the overloads in place, such as Direct2D which had a 16-parameter function that resulted in 65565 overloads being generated.

# Previous Iterations of This Proposal

The general theme behind these points of contention is the generation mechanisms and infrastructure put in place for Silk.NET were very much designed for OpenGL and other similar Khronos APIs, with the later non-Khronos bindings not being specifically designed for, instead the tasking was "how can we fit these other non-Khronos bindings to fit our existing bindings infrastructure built for OpenGL?".

The Working Group approved an earlier version of this proposal on 25th February 2022, whereby a hybrid source generator/AOT generator solution was used. The solution looked and felt a lot like Silk.NET 2.X, and had a similar overloading mechanism (just different mechanisms of invocation). However, given that Silk.NET 2.X was again built without these points of contentions in mind and without non-Khronos bindings in mind, we ran the risk of running into similar issues.

However, the approved version of this proposal has a lot of great points as well. One of the most pertinent points in the approved proposal is the ability to have the overloader applied to user-defined and/or non-generated functions. Another pertinent point was the ability to have a very stable foundation for the native signatures, as Silk.NET 2.X underwent a lot of massively-breaking updates due to the signatures/types already present in the shipped version of the library were fundamentally wrong due to generator error.

Since the creation of that proposal, the [SilkX](https://github.com/Perksey/SilkX) project (led by Dylan Perks/@Perksey) has been pioneering the underlying concepts of the approved proposal but using mechanisms that provide the least contention for the generator users (primarily the Silk.NET maintainers). This proposal is based on the conclusion of that project, and if this proposal is approved SilkX shall be merged into the main Silk.NET repo and become the official Silk.NET 3.0 implementation.

The Working Group should note that Kai did make some progress with the original implementation of Silk.NET 3.0 as approved by the Working Group, however the SilkX project was spawned from the realisation that the proposed solution was too large in scope given the time constraints of the primary Silk.NET developers. This work still lives in the develop/3.0 branch until this proposal is approved.

# ClangSharp Generation

As in the previously approved version of this proposal, the generation process of the proposed generator will be entirely different to BuildTools. Silk.NET will no longer do any parsing and interpretation of C headers or XML of C headers, instead we will delegate this to the ClangSharp P/Invoke Generator library, adding appropriate modifications to inputs/outputs as necessary. This means that we will no longer be using the Khronos XML registries for generating bindings directly.

Instead, we'll use a "mod" system to use the XML registry and other metadata sources to influence the various stages of the generator cycle. Each mod is initialised (which in turn may do HTTP requests, XML parsing, etc) and **shall** be given the ClangSharp input response files. Once the modifications (if any) have been applied to those inputs, ClangSharp **shall** be run with each of those inputs, and the C# syntax trees saved. Those syntax trees **shall** then be fed back into the mod, and the syntax modifications (if any) will be applied. Finally, the syntax trees **shall** be added to the MSBuild workspace where the mods **shall** have one final opportunity to enact workspace-wide modifications. The details of this system is implementation-defined.

This naturally makes us entirely dependent on an external dependency, but I propose we work with Tanner Gooding (the ClangSharp project lead) as much as possible to add the functionality we need in the least breaking way possible, and in a way that satisfies both us and ClangSharp. All designs for such modifications will be formalized in the ClangSharp repo. Should we fail to do this, we'll maintain a fork so we can still benefit from improvements made upstream, while giving ourselves the freedom to add the functionality we need.

Tanner has already stated that they're happy to work with us to get Silk.NET using ClangSharp, even saying they're happy to add a CI test stage into the ClangSharp repo to ensure no incoming changes break Silk.NET's generation process.

# Implicit Cast-Based Overloading

The pivotal proposal around which the SilkX experiment revolves is solving the excessive overload problem by having no overloads at all. Namely, Silk.NET.Core will have a set of "pointer-like" types that can be implicitly casted to by a multitude of different types. This gives the user the same flexibility as having all different permutations of overloaded parameters generated without having to do so, and thereby alleviates the requirement of having overloads at all.

A `Ref` `ref struct` **shall** be defined wrapping a `ref`. A `Ptr` `struct` **shall** be defined wrapping a native pointer. These types **shall** have generic and non-generic variants. This shall be repeated up to 3 pointer dimensions. This means that there will be 6 top-level generic structs and 6 top-level non-generic structs. IL weaving **may** be required for `Ref2D` and `Ref3D`.

Unless deemed inappropriate, inapplicable, and/or infeasible by the Silk.NET team (the team reserved the right to do so without Working Group approval), the `Ref` types **should** have the following characteristics:
- An instance **must** be constructable from a `ref T` where `T` is either the generic type (or `byte` for non-generic variants), a "pointer-like" type of the lower dimension of type being constructed.
- An indexer **must** be present accepting a `nuint` for the index, returning a `ref T` where `T` is either the generic type (or `byte` for non-generic variants), a "pointer-like" type of the lower dimension (i.e. a `Ref2D<T>`'s indexer will return a `Ref<T>`) of type being indexed.
- A `GetPinnableReference` **must** be present taking no parameters and returning a `ref T` where `T` is the native raw pointer representation of the lower dimension.
- For single-dimension pointers, an `AsSpan` method **must** be present taking an `int` length argument (due to historical reasons in the .NET BCL) returning a `Span<T>` where `T` the pointee type. For non-generic pointer-like types, a generic argument **may** be used to specify the type of the span.
- An array of the same jagged dimension **must** be implicitly convertible to the type.
- For single-dimension pointers, a multi-dimensional array (up to 3 dimensions) **must** be implicitly convertible to the type.
- A raw pointer of the same dimensions **must** be implicitly convertible to the type.
- `NullPtr` **must** be implicitly convertible to the type, and the returned pointer must represent a null reference.
- An explicit operator **must** be present to unsafely convert the reference represented by the pointer to a raw pointer without the user using `fixed`/`GetPinnableReference`.
- An explicit operator **must** be present to unsafely convert the reference represented by the pointer to a void pointer without the user using `fixed`/`GetPinnableReference`.
- For generic pointer types, an explicit operator **must** be present to convert the pointer type to a `string` (or an array of strings of the inner dimension's jaggedness i.e. `Ref3D<byte>` becomes `string[][]`). The explicit cast **may** throw an exception if the pointee type is not a string pointee type. This is because we can't constrain the type used on explicit operators on generic types.
- An `==` and `!=` operator **must** be present to check equality with another pointer of the same type.
- An `==` and `!=` operator **must** be present to check equality with `NullPtr` i.e. check whether the pointer is null.
- For generic pointer types to a string pointee type, a `string` (or an array of strings of the inner dimension's jaggedness i.e. `Ref3D<byte>` becomes `string[][]`) **must** be implicitly convertible to the pointer type. The implicit cast **may** throw an exception if the pointee type is not a string pointee type. This is because we can't constrain the type used on implicit operators on generic types.
- For single dimension generic pointer types, `Span<T>` and `ReadOnlySpan<T>`  **must** be implicitly convertible to the pointer type.
    - For `ReadOnlySpan<char>`, it is conceivable that the span we're casting represents a string slice. Therefore, the operator **must** implicitly copy the span to a new array that is suffixed with a trailing zero char to ensure it is still usable as such, and `ref` that array instead.

Unless deemed inappropriate, inapplicable, and/or infeasible by the Silk.NET team (the team reserved the right to do so without Working Group approval), the `Ptr` types **should** have the following characteristics:
- An instance **must** be constructable from a `T*` where `T` is either the generic type (or `void*` for non-generic variants), a "pointer-like" type of the lower dimension of type being constructed.
- An indexer **must** be present accepting a `nuint` for the index, returning a `ref T` where `T` is either the generic type (or `byte` for non-generic variants), a "pointer-like" type of the lower dimension (i.e. a `Ptr2D<T>`'s indexer will return a `Ptr<T>`) of type being indexed.
- A `GetPinnableReference` **must** be present taking no parameters and returning a `T` where `T` is the native raw pointer representation of the lower dimension.
- For single-dimension pointers, an `AsSpan` method **must** be present taking an `int` length argument (due to historical reasons in the .NET BCL) returning a `Span<T>` where `T` is the pointee type. For non-generic pointer-like types, a generic argument **may** be used to specify the type of the span.
- For single-dimension pointers, a `ToArray` method **must** be present taking an `int` length argument (due to historical reasons in the .NET BCL) returning a `T[]` where `T` is the pointee type. For non-generic pointer-like types, a generic argument **may** be used to specify the type of the span.
- A raw pointer of the same dimensions **must** be implicitly convertible to the type.
- For multi-dimensional pointers, a `ToArray` method **must** be present taking an `int` length arguments (due to historical reasons in the .NET BCL) returning a jagged array of `T` of the same dimensionality where `T` is the pointee type. For non-generic pointer-like types, a generic argument **may** be used to specify the type of the span.
- `NullPtr` **must** be implicitly convertible to the type, and the returned pointer must represent a null reference.
- An implicit operator **must** be present to convert to a raw pointer.
- An implicit operator **must** be present to convert to a void pointer.
- For generic pointer types, an explicit operator **must** be present to convert the pointer type to a `string` (or an array of strings of the inner dimension's jaggedness i.e. `Ptr3D<byte>` becomes `string[][]`). The explicit cast **may** throw an exception if the pointee type is not a string pointee type. This is because we can't constrain the type used on explicit operators on generic types.
- An `==` and `!=` operator **must** be present to check equality with another pointer of the same type.
- An `==` and `!=` operator **must** be present to check equality with `NullPtr` i.e. check whether the pointer is null.

Our goal with this implicitness it to make the experience of using pointers as similar to C as possible without feeling completely alien in a high-level language. This is the logic behind the string casting as well. The public API surface for our bindings **shall** use these wrapper types.

For the avoidance of doubt, a string pointee type **shall** be defined as one of: `byte`, `sbyte`, `char`, `short`, `ushort`, `int`, `uint`. For single-byte string pointee types, UTF-8 **shall** be used. For 2-byte string pointee types, UTF-16 **shall** be used. For 4-byte string pointee types, UTF-32 **shall** be used. 

**INFORMATIVE:** This implementation was discussed informally in the discord #team-chat [here](https://discord.com/channels/521092042781229087/587346162802229298/1166427977060450415) and [here](https://discord.com/channels/521092042781229087/587346162802229298/1167076268316045352). The purpose of this implementation was to simplify the naming scheme so that it was easily understandable. Const correctness was discarded in favor of simplicity.

**INFORMATIVE:** This is in contrast to the previous proposal which was discussed informally by the Working Group in a Coffee & Code Catchup. The recording for this catchup can be found on the .NET Foundation YouTube channel [here](https://www.youtube.com/watch?v=N7qcETE4X_I). The most pertinent points were regarding ease of use and discoverability - unless the user reads the documentation (which will exist per the Working Group approved Software Development Plan), they won't know what all of these `Ptr` types mean and how to use them. Which while a short document could summarize, it was fekt this implementation was lacking in clarity. There was also some desire to revisit the 1.X style of overloading, but the Silk.NET team were hesitant to do so to avoid history repeating itself. This is not an invalid suggestion however, given that TerraFX exists and can be treated as an equal now due to .NET Foundation membership, and their focus is exclusively unsafe so users that want unsafe can just use TerraFX. However, Silk.NET still wants to be as flexible as possible thus we have persisted in this model for this proposal.

**INFORMATIVE:** The Working Group previously expressed concerns for implicit casting for the trivial case of `string` to `ReadOnlySpan<char>` in the 2021 meeting regarding the previous version of this proposal (see Meeting Notes).

# API Objects & Static Methods

One of the most common complaints throughout the entirety of Silk.NET's lifetime was the lack of static functions. We have argued that this is required for the sake of validity, and this is completely true *for the Khronos bindings*. This should have never been the case for the non-Khronos bindings. However, there are some users that do indeed prefer the API object mechanism and it does provide undeniable flexibility and control versus the alternative of static state that often does not lend itself to multi-context and/or multi-backend solutions. We still want to keep that flexibility, however we recognise that not all users need it.

This is why the solution proposed includes both static functions and API objects, with one being a wrapper over the other where most appropriate.

Each binding **shall** have a "V-Table" interface generated like so:

```cs
public interface IMyStringLibrary
{
    public interface Static
    {
        static abstract byte* ToLower(byte* str);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static virtual Ptr<byte> ToLower(Ptr<byte> str)
        {
            fixed (byte* nStr = str)
            {
                return ToLower(nStr);
            }
        }
        static abstract void FreeResult(byte* str);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static virtual FreeResult(Ptr<byte> str)
        {
            fixed (byte* nStr = str)
            {
                FreeResult(nStr);
            }
        }
    }
    byte* ToLower(byte* str);
    Ptr<byte> ToLower(Ptr<byte> str)
    {
        fixed (byte* nStr = str)
        {
            return ToLower(nStr);
        }
    }
    void FreeResult(byte* str);
    void FreeResult(Ptr<byte> str)
    {
        fixed (byte* nStr = str)
        {
            FreeResult(nStr);
        }
    }
}
```

The Silk.NET team reserves the right to define the behaviour for when the `static abstract` and `static virtual` or DIM and non-DIM conflict by return types only. This will be worked out during development, but **may** require removing the native representations and duplicating the marshalling logic for each of the implementations.

Each library being bound to **shall** have an interface generated, named using the class name provided by the generator user prefixed with `I`.

This interface **shall** contain a subinterface named `Static`.

The `Static` subinterface **shall** contain a `static abstract` or `static virtual` (depending on the conflict outcome above) function representing the native signature using the wrapper types for each function exposed by the library.

The `Static` subinterface **should** contain a `static abstract` function representing the native, raw, and blittable signature for each function exposed by the library.

The top-level interface **shall** contain a function representing the native signature using the wrapper types for each function exposed by the library. This **should** be implemented using a Default Interface Method.

The top-level interface **should** contain a function representing the native, raw, and blittable signature for each function exposed by the library.

This contains both a static and a non-static variant. An implementation **shall** be created as follows:

```cs
public class MyStringLibrary : IMyStringLibrary
{
    public static class DllImport : IMyStringLibrary.Static
    {
        [DllImportAttribute("mystringlib")]
        public static extern byte* ToLower(byte* str);
        [DllImportAttribute("mystringlib")]
        public static extern void FreeResult(byte* str);
    }
    public class StaticWrapper<T> : IMyStringLibrary where T: IMyStringLibrary.Static
    {
        public StaticWrapper();
        public byte* ToLower(byte* str) => T.ToLower(str);
        public void FreeResult(byte* str) => T.FreeResult(str);
    }
    public class ThreadLocal : IMyStringLibrary.Static
    {
        private static ThreadLocal<IMyStringLibrary> _current = new();
        public static void MakeCurrent(IMyStringLibrary current) => _current.Value = current;
        public static byte* ToLower(byte* str) => _current.Value.ToLower(str);
        public static void FreeResult(byte* str) => _current.Value.FreeResult(str);
        public static Ptr<byte> ToLower(Ptr<byte> str) => _current.Value.ToLower(str);
        public static void FreeResult(Ptr<byte> str) => _current.Value.FreeResult(str);
    }

    // Non-Static Interface
    private INativeContext _ctx;
    byte* IMyStringLibrary.ToLower(byte* str)
    {
        var ptr = _ctx.LoadFunction("ToLower");
        if (ptr is 0) throw new("some symbol loading exception...");
        return ((delegate* unmanaged<byte*, byte*>)ptr)(str);
    }
    
    void IMyStringLibrary.FreeResult(byte* str)
    {
        var ptr = _ctx.LoadFunction("FreeResult");
        if (ptr is 0) throw new("some symbol loading exception...");
        return ((delegate* unmanaged<byte*, void>)ptr)(str);
    }

    public static IMyStringLibrary Create() => new StaticWrapper<DllImport>();
    public static IMyStringLibrary Create(INativeContext ctx) => new MyStringLibrary { _ctx = ctx };

    // Static Interface
    public static byte* ToLower(byte* str) => DllImport.ToLower(str);
    public static Ptr<byte> ToLower(Ptr<byte> str) => DllImport.ToLower(str);
    public static void FreeResult(byte* str) => DllImport.FreeResult(str);
    public static void FreeResult(Ptr<byte> str) => DllImport.FreeResult(str);
}
```

There exist requirements for all of the following:
- A native function retrieved using a thread-specific "native context" can be called using a static function (for OpenGL)
- A native function retrieved using a custom "native context" delegate can be called using a static function (for Vulkan, OpenCL, OpenXR).
- A native function retrieved using the platform-default mechanism can be called using a static function (for literally everything else).

**INFORMATIVE:** `Create` replaces `GetApi`.

While this somewhat balloons the API surface, this provides the most flexibility and most entry points into the bindings without adding lots of API-specific code into SilkTouch.

Each bindings **shall** have a class generated to match the generated interface. The name of this class **shall** be the same as the interface without the leading `I` prefix.

Within each binding class a `static class` **shall** be generated for each `DllImport` look-up name provided by the generator user. If there are multiple, this class **shall** carry the pascal case version of the look-up name provided. If there is only one, this class **shall** be named `DllImport`.

**INFORMATIVE:** This does not mean platform-specific name, we still have the NativeLibrary callbacks after all. This is referring to OpenAL Soft vs OpenAL for example, though even that could be implemented using NativeLibrary.

Within each binding class a `class` **shall** be generated implementing the top-level interface over a generic type parameter implementing the static subinterface. This allows users to construct API objects over `DllImport`ed libraries. This **shall** be named `StaticWrapper`.

Within each binding class a `static class` **shall** be generated implementing the static subinterface using a `ThreadLocal` containing an instance of the top-level interface. This allows users to call stateful native libraries (like OpenGL) using a static function.

`ThreadLocal` implementations **shall** implement a `MakeCurrent` method taking an instance of the top-level interface as the parameter. On the thread on which this method is called, all subsequent static method calls on `ThreadLocal` will use the given API object.

The binding class **shall** expose a `static` `Create` method with no parameters returning an instance of the top-level interface. This **should** use `StaticWrapper<T>` where `T` is the generator user's configured *static default*.

**INFORMATIVE:** The Silk.NET team looks back very fondly on the API-as-interfaces scheme present in only the earliest Silk.NET 1.0 previews. The backstory is that AdvancedDLSupport originally required interfaces in order to implement the abstract class, so we added interfaces just for that, but they were removed once they became unnecessary. However, these interfaces are obviously very useful in the advent of C# having advanced mainstream dependency injection. While this is never an explicit target for a low-level, high-speed interoperability library such as Silk.NET, we take pleasure in being able to cater for this use case.

Unless `ThreadLocal` is itself the *static default* configured by the generator user, the thread-local value within `ThreadLocal` should be instantiated with a value factory calling the `Create` method. If `ThreadLocal` is the *static default*, then no value factory is provided and the user must set the value using `MakeCurrent`.

The binding class **shall** expose a `static` `Create` method with a `Func<string, nint>` parameter returning an instance of the top-level interface. This **shall** use an instance of the binding class itself.

**INFORMATIVE:** It is undecided whether we want SilkTouch to output the `Create` methods itself or whether we want it in a non-generated partial.

The binding class **shall** itself implement the top-level interface, using the `INativeContext` stored from the `Create` method to implement the native calls using a direct function pointer call.

The binding class **shall** also contain shorthand functions for calling the static functions contained within the static subinterface using the *static default*.

The binding class **shall** implement the static subinterface (i.e. to proxy calls to the *static default* for ease of use).

**INFORMATIVE:** Do we want to make a MakeCurrent shorthand as well? This may cause confusion for OpenGL users because it doesn't make the underlying context (WGL/EGL/GLX) current, it just makes it the current source of function pointers.

**INFORMATIVE:** The `DllImport` and `StaticWrapper` names need bikeshedding if performance-aware users are expected to use them directly. Perhaps `DllImport` could be called `Exports`?

# Khronos Extension Handling

**TODO:** Once the preceding document contents have been implemented in SilkX, describe how we're going to handle extensions. I personally think we should just do a "hint" rather than anything hard, like `SupportedOSPlatform`.

# Safety in Structs

**TODO:** Once the preceding document contents have been implemented in SilkX, describe the impact the wrapper types have on structs, which are currently uncatered for and always lacking overloads. @Perksey already has ideas here though.

# Meeting Notes

## 05/08/2021

- SilkTouch for 2.0 is very hard to use
- A lot of code
- Will explode the repo a lot, but will also improve compile times because everything's already there and no need to generate at compile time
- ClangSharp is used by win32metadata (official c#, rust bindings) and generally accurate for parsing header files
    - very correct, battle tested, more reliable than BuildTools 2.0
- Just use ReadOnlySpan\<char\> (implicit conversion from string)
    - does our userbase know this?
- Too many overloads could cause confusion/lack of visibility
    - promote "best practice"
    - include exposed native api
- Only overload what we determine as "best practice", discourage per-parameter overloading
    - One permutation per "overload style"? i.e. one function with all spans 
    - Special "intermediary" types don't really make sense as it loses compile-time safety and has other compiler-level issues
- Establish a baseline of overloads
    - Scrap ArrayOverloads
    - Scrap RefOverloads
- Group? i.e. only create overloads based on a particular style
- **Overloader needs more review/work, postpone to another meeting**
    - number of overloads is a big concern right now

## 25/02/2022

[Video](https://youtu.be/dac3t0oh3VU?t=7616)

- Approved (call conv modifier discussion notwithstanding), but we must come back to the overloader - it's a bit too early to decide on something solid as there's no perfect rule that we know of to generate them at this time - we can only get this through experimentation!
- Why use an enum and custom attribute rather than reusing UnmanagedCallConv and the typeof(CallConv*) types that C#/.NET have standardized on for moving forward?
    - We don't really have control over those types.
    - For \[contrived\] example, what if we want a JavaScript calling convention?
    - We can't just hack up a "calling convention" the runtime doesn't support, `MemberFunction` for example was just something that _happened_ to work on the Windows ABI
    - We could use CallModifiers to, for example, influence codegen to call into IJsInProcessRuntime and call JavaScript code - this isn't necessarily _just_ an ABI-based concept. It could support other scenarios.
    - It makes more sense to separate these, as these are sort of associated with DllImport and that side of the calling process, and a "JavaScript" convention concept (as discussed before).
    - It's difficult to represent right now, because we have the native API attribute
    - **We could/should change this to use the CallConv types instead**
    - Direct advantages
        - As the runtime versions in the future, it will continue to add CallConv types. These types are the official way moving forward to represent any calling convention information for the rutnime going forward.
        - SilkTouch has to go out of this way to map this and understand this anyway, unless we just have the types then we can specify them as-is - SilkTouch doesn't even need to understand these.
        - "\[DllImport\] is effectively magic" - @tannergooding
        - **Just change Modifiers to a CallConv type array**
- The overload problem does need to be solved in some way. Some functions have absurd amounts of overloads (particularly in assimp)
    - We want to scrap a bunch of overloads as well. A lot of this is only generating a bunch of "important" overloads.
    - Was there consideration for a source generator approach to opt-in to the friendliest variant that they want?
        - Yes, kind of. We don't have a formal proposal as we only just thought of this today.
        - We need to bake the most basic overloads into the assembly itself.
        - We'd like to have a source generator.
        - We want SilkTouch to be productized, and find a way to remap types per their liking and use overloads etc. 
        - We should experiment with this and report back in a future community meeting. 

**ACTIONS**
- [x] Change `Modifiers` to a CallConv\* `Type` array

**FUTURE**
- [x] Report back to the Community our findings in experimenting with overloads

## 19/11/2023

[Video](https://www.youtube.com/live/yXNDZDE3AHE?feature=shared&t=3326)

- We discussed a particular problematic case where RegisterClassEx returns an atom which is later reinterpreted to be a pointer - a debugger will explode when inspecting this pointer as it is not necessarily 
- Where ReadOnlySpan\<char\> represents a string and we don't just want to pass the ref as-is (i.e. we want to add the null terminator like we do for string).
- Generally we think that providing a tool that works 90% of the time is fine, the unsafe overloads are always there, but we'd worry about users making incorrect assumptions and we can probably do implicit behaviour for that final 10%.
- Require that users manually encoding strings add that null terminator and document this. Our implicit ones do the right thing.
- Don't allow ref types to throw an error when being handed something that isn't a valid pointer.
- Approved provided that we:
    - make unsafe available
    - special case ROSpan\<char\> as above
- Future discussions need to be had on Vulkan implementation intricacies (getProcAddr) and also the addition of "complex" overloads.
