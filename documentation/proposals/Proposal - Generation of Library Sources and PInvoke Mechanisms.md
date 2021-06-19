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
- This proposal assumes no knowledge of Silk.NET 2.0's SilkTouch. 
- This takes the knowledge and insight gained during development of SilkTouch, and uses it to create a new set of generators which incorporate lessons learnt.
- This proposal breaks down the generator process into three distinct stages:

## SilkTouch Scraper

The Scraper is responsible for creating partial classes from some input source. It is a drop-in replacement for what BuildTools does today. Instead of doing all the parsing and interpretation of the input source ourselves, the proposed Scraper will instead use only C headers and have a "preburner" for gathering minimal metadata to feed into the generation process.

The generation process of the proposed Scraper will be entirely different. Silk.NET will no longer do any parsing and interpretation of C headers or XML of C headers, instead we will delegate this to the ClangSharp P/Invoke Generator in the form of a "subagent" (a separate process spun up by the Scraper), adding appropriate modifications to ClangSharp P/Invoke Generator as necessary. This means that we will no longer be using the Khronos XML registries for generating bindings. Instead, we'll use the preburner stage to use the XML registry only to gather minimal metadata instructing the ClangSharp subagent to add metadata attributes to certain functions, parameters, or types; which will then be picked up on by the later stages of SilkTouch. An example of such metadata would be parsing the flow and len XML attributes to add appropriate C# attributes to influence overload generation.

This also naturally makes us entirely dependent on an external dependency, but I propose we work with Microsoft as much as possible to add the functionality we need in the least breaking way possible, and in a way that satisfies both us and Microsoft. All designs for such modifications will be formalized in the ClangSharp repo. Should we fail to do this, we'll maintain a fork so we can still benefit from improvements made upstream, while giving ourselves the freedom to add the functionality we need.

Microsoft have already stated that they're happy to work with us to get Silk.NET using ClangSharp, one maintainer even saying they're happy to add a CI test stage into the ClangSharp repo to ensure no incoming changes break Silk.NET's generation process.

There is no required behaviour for the Scraper (due to a lot of unknowns at the moment) other than it **MUST** invoke ClangSharp to generate C# Emitter-compatible classes, and it **MUST** add appropriate attributes to invoke the Overloader stage according to any metadata available from Khronos XML if applicable.

## SilkTouch Emitter
The Emitter, one of the two final stages which **SHOULD** run in parallel where possible and **MUST** be entirely independent of eachother, is responsible for generating the actual indirect calls for performing the P/Invoke. This will use C# 9's Function Pointer system.

The Emitter operates on partial methods, the behaviour of the implementations of which depending on the context in which it's used.

All attributes **MUST** be name matched only, to allow the user to define these themselves and not create a hard dependency on a specific Silk.NET library such as the Silk.NET Core. 

Candidate methods for implementation by the Emitter **MUST** be partial and not have an implementation part yet. Their containing types **MUST** also be partial and have at least one FTable source specified.

The Emitter **MUST** be able to be invoked as either a Roslyn Source Generator, which runs embedded in the Roslyn compiler; or via the SilkTouch CLI, which runs outside of the usual compilation process. If invoked as a Roslyn Source Generator, it **MUST** run in parallel with other SilkTouch source generators.

### Function Tables (FTables)

The Emitter's primary purpose is to load and use function pointers in a native library sourced from an operating system's kernel. This logic will be emitted by the Emitter itself, and will not require an external dependency like the Silk.NET Core. However, this logic will no longer be implicit.

The Emitter **MUST** require a field on the containing type which can be indexed using an `int` and returns a `void*` upon being indexed. This field may be added by the Emitter, but is not implicitly added. You must tell the Emitter about the field, or whether the Emitter should add it. This field will be referred to as the "FTable source" herein.

Multiple FTable sources **MUST NOT** be allowed i.e. don't allow pairing of `UseNativeLibrary` and `UseAsFunctionTable`

#### Indices

Indices (formerly known as "slots") give each method a specific ID. These may be assigned by the Emitter in an undefined way, or may be overridden using an attribute:
```cs
[NativeApi(Index = 1)]
public partial void Init();
```

#### Built-in FTable Source: Native Library

Consider the following example:
```cs
[UseNativeLibrary("glfw3.dll")]
public class Glfw
{
    public partial void Init();
}
```

The `UseNativeLibrary` attribute instructs the Emitter that it:
- **MUST** add a field with an undefined name of an undefined type to the class
- **MUST** use this field as the FTable source, and implement the required indexer.

For `UseNativeLibrary`, the field's indexer **MUST** use [**NativeLibrary**](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.nativelibrary) and enact appropriate loading logic for each function's index. For the entry point, the function **MUST** be used unless an `NativeApi` attribute is provided, in which case the entrypoint indicated by that attribute **MUST** be used.

Given `UseNativeLibrary` instructs the Emitter to add a field, it **MUST** only be used on a `class`.

`UseNativeLibrary` **MUST** allow multiple usages, because a user **MUST** be able to use it to specify a library name to use if there's a preprocessor constant defined or if we're on a specific operating system.

Consider the following example:
```cs
[UseNativeLibrary(OperatingSystemName.MacOS, "libglfw3.dylib")]
[UseNativeLibrary("IOS", "__Internal")]
[UseNativeLibrary(OperatingSystemName.MacOS, "MY_COOL_PREPROCESSOR_DEFINE", "__Internal")]
[UseNativeLibrary("glfw3.dll")]
public class Glfw { /* ... */ }
```

The order of evaluation of these attributes **MUST** be in the order of most specific to the least. This means that:
- MacOS and MY_COOL_PREPROCESSOR_DEFINE is tested first
- then MacOS and libglfw3.dylib
- then IOS and \_\_Internal
- then glfw3.dll

If there are two attributes with the same level of specificity, the order in which the attributes are specified **SHOULD** be respected.

If `__Internal` is used as a library name, the Emitter **MUST** use `DllImport` to load the functions instead. The `DllImport` functions generated by the Emitter to facilitate this **MUST** inherit any preprocessor constraints indicated by the `UseNativeLibrary` attribute.

The `__Internal` library name **MUST** be paired with a preprocessor constraint and **MUST NOT** use an operating system constraint.

No other library names are defined to use `DllImport` at this time, as this shouldn't be required given we're using NativeLibrary now.

#### Custom FTable Source
Custom code may be used to get a FTable source. This is useful in scenarios such as COM interop.

Consider the following example:
```cs
[UseAsFunctionTable("LpVtbl")]
public struct IUnknown
{
    [NativeApi(Index = 1)]
    public partial uint AddRef();
}
```

`UseAsFunctionTable` indicates that the C# code `LpVtbl` **MUST** preceded any indexer operations generated. Any arbritrary code can be inserted into this attribute, so long as the result of the code evaluates to something that can be indexed as described above. For example, this is valid:
```cs
[UseAsFunctionTable("Value.GetValueOrDefault().InnerValue->LpVtbl")]
public struct IUnknownNullableContainer
{
    public IUnknownPtr? Value;
    [NativeApi(Index = 1)]
    public partial uint AddRef();
}

public struct IUnknownPtr
{
    public IUnknown* InnerValue;
}

public struct IUnknown
{
    public void** LpVtbl;
}
```

The Emitter **SHOULD** implicitly parenthesise the expression given in the attribute.

If a custom FTable source is used, the Emitter **SHOULD** mandate that every function has a `NativeApi` attribute with an explicit `Index` specified for safety.

### Function pointers
For the most part, the function pointer signature used by the Emitter is matched 1:1 with the method signature. For example:
```cs
public partial int MyThing(int a);
```

will generate an implementation similar to:
```cs
public partial int MyThing(int a) => ((delegate* unmanaged<int, int>) (<ftable access expression>)[<index>])(a);
```

However there are certain modifications you can apply. Namely, the `NativeApi` attribute will allow specification of specific calling conventions. For example:

```cs
[NativeApi(Modifiers = CallModifiers.MemberFunction)]
public partial D3D12_HEAP_PROPERTIES GetCustomHeapProperties(uint nodeMask, D3D12_HEAP_TYPE heapType);
```

This will generate:
```cs
public partial D3D12_HEAP_PROPERTIES GetCustomHeapProperties(uint nodeMask, D3D12_HEAP_TYPE heapType) => ((delegate* unmanaged[MemberFunction]<uint, D3D12_HEAP_TYPE, D3D12_HEAP_PROPERTIES>) (<ftable access expression>)[<index>])(a);
```

`CallModifiers` will be used as the primary bitmask for customizing the behaviour of generation, just as `NativeApi` will be used as the primary attribute for this as well. The behaviour of each bit will be described in documentation comments in the Proposed API section.

The Emitter does not do any marshalling. As such, the Emitter **MUST** mandate that every parameter and return type of every function fits the `unmanaged` constraint. For the readers benefit, this can be done using a property on `ITypeSymbol` in Roslyn.

## SilkTouch Overloader
The Overloader, one of the two final stages which **SHOULD** run in parallel where possible and **MUST** be entirely independent of eachother, creates overloads of functions that expose a more user-friendly interface than the function it overloads, and do appropriate marshalling to lower the parameter types used down to the original function's types.

The Overloader **MUST** be activated using an `OverloadAttribute` applied to the assembly, type, and/or function contianing the method.

The Overloader **MUST** be able to be used on any function and not be tied to any of the Emitter's constraints.

The Overloader **MUST** be able to be invoked as either a Roslyn Source Generator, which runs embedded in the Roslyn compiler; or via the SilkTouch CLI, which runs outside of the usual compilation process. If invoked as a Roslyn Source Generator, it **MUST** run in parallel with other SilkTouch source generators.

The Overloader **MUST** generate all possible permutations of overloads.

The Overloader does not care about existing methods. If the Overloader generates an overload that also happens to exist manually, it is the user's repsonsibility to disable the relevant overloads for these cases.

However, if the Overloader thinks that the overload it's generating may conflict with another overload or the original function, it **SHOULD** output the overload as an extension method rather than a method within the containing type, unless the original method is static in which case it **MUST** discard the overload and generate a warning. It **SHOULD** also do this if the containing type is not partial.

### Overloads
#### StringOverloader
#### StringReadOnlyListOverloader
#### StringSpanOverloader
#### AlternativeTypeOverloader
#### RefOverloader
#### SpanOverloader
#### ImplicitCountSpanOverloader
#### OpenGLDeleteOverloader
#### OpenGLObjectCreationOverloader

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
