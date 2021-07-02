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
The Emitter, one of the two final stages which **SHOULD** run in parallel where possible and **MUST** be entirely independent of eachother, is responsible for generating the actual indirect calls for performing the P/Invoke.

The Emitter operates on partial methods, the behaviour of the implementations of which depending on the context in which it's used.

All attributes **MUST** be name matched only, to allow the user to define these themselves and not create a hard dependency on a specific Silk.NET library such as the Silk.NET Core. 

Candidate methods for implementation by the Emitter **MUST** be partial and not have an implementation part yet. Their containing types **MUST** also be partial.

The Emitter **MUST** be able to be invoked via the SilkTouch CLI and **MAY** be able to be invoked via an incremental Roslyn source generator.

### Call Styles

The Emitter's primary purpose is to load and use function pointers in a native library sourced from an operating system's kernel, though this doesn't necessarily have to be the case. This logic will be emitted by the Emitter itself, and will not require an external dependency like the Silk.NET Core. However, this logic will no longer be implicit.

#### Built-in: Native Library Call Style

Consider the following example:
```cs
[UseNativeLibrary("glfw3.dll")]
public partial class Glfw
{
    public partial void glfwInit();
}
```

The `UseNativeLibrary` attribute instructs the Emitter that it **MUST** use [`DllImport`](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.dllimportattribute?view=net-5.0) to access native functions. [`NativeLibrary`](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.nativelibrary?view=net-5.0) can be used to modify the libsuperrary loading process per other requirements defined below. For the entry point, the function name **MUST** be used unless a `NativeApi` attribute is provided, in which case the `EntryPoint` indicated by that attribute **MUST** be used.

`UseNativeLibrary` **MUST** allow multiple usages, because a user **MUST** be able to use it to specify a library name to use if there's a preprocessor constant defined or if we're on a specific operating system.

Consider the following example:
```cs
[UseNativeLibrary(OperatingSystemName.MacOS, "libglfw3.dylib")]
[UseNativeLibrary("IOS", "__Internal")]
[UseNativeLibrary(OperatingSystemName.MacOS, "MY_COOL_PREPROCESSOR_DEFINE", "__Internal")]
[UseNativeLibrary("glfw3.dll")]
public partial class Glfw { /* ... */ }
```

The order of evaluation of these attributes **MUST** be in the order of most specific to the least. This means that:
- MacOS and MY_COOL_PREPROCESSOR_DEFINE is tested first
- then MacOS and libglfw3.dylib
- then IOS and \_\_Internal
- then glfw3.dll

If there are two attributes with the same level of specificity, the order in which the attributes are specified **SHOULD** be respected.

The `__Internal` library name **MUST** be paired with a preprocessor constraint and **MUST NOT** use an operating system constraint.

The Emitter **MUST** allow multiple candidate library names and cycle through each candidate until one loads successfully, unless `__Internal` is used in which case this **MUST** be the only candidate name in use.

All preprocessor conditions **MUST** be applied to the generated `DllImport` methods.

Unlike the Procedure Address Method call style, this call style always requires attributes on the containing type and this is by design: there's no way we can specify operating system dependent or preprocessor dependent library names within a single attribute and it actually look good. 

#### Custom Call Style: Procedure Address Expressions

Custom code may be used as a call style by providing a pointer to SilkTouch using a Procedure Address Expression. This is useful in scenarios such as COM interop.

Procedure Address Expressions are C# expressions that **MUST** evaluate to a `void*`, `nint`, or `IntPtr`. This is the actual address in memory of the function being invoked.

Consider the following example:
```cs
public partial struct IUnknown
{
    public void** LpVtbl;
    [NativeApi(GetProcAddress = "LpVtbl[1]")]
    public partial uint AddRef();
}
```

`GetProcAddress` indicates that the C# code `LpVtbl[1]` **MUST** be used as the Procedure Address Expression to retrieve the function address to call. Any arbritrary code can be inserted into this attribute, so long as the result of the code once evaluated meets the Procedure Address Expression definition. For example, this is valid:
```cs
public partial struct IUnknownNullableContainer
{
    public IUnknownPtr? Value;
    [NativeApi(GetProcAddress = "Value.GetValueOrDefault().InnerValue->LpVtbl[1]")]
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

Unless another call style is applicable, the Emitter **MUST** mandate that every function has a `NativeApi` attribute with an explicit `GetProcAddress` (Procedure Address Expression) specified.

If there are no `UseNativeLibrary` attributes specified at the type-level, this call style **MUST NOT** be used even if requested in a function-level `NativeApi` attribute.

The Emitter **MUST** call the function pointer returned by the Procedure Address Expression as part of this call style.

#### Overriding Call Styles

Consider the following example:

```cs
[UseNativeLibrary("glfw3.dll")]
public partial class Glfw
{
    public partial nint glfwGetProcAddress(byte* str);
    [NativeApi(GetProcAddress = "glfwGetProcAddress((byte*)Unsafe.AsPointer(ref Unsafe.AsRef(0x006e696765426c67)))")]
    public partial void glBegin(uint mode);
}
```

Here, a class using the Native Library call style has a method which does not follow the call style defined at the class level, and is overridden using a `NativeApi` attribute.

If a `NativeApi` attribute is present with `GetProcAddress` specified, the Procedure Address Expressions call style **MUST** be used instead of any other call style defined herein.

#### Custom Call Style: Procedure Address Methods

A level more abstracted than Procedure Address Expressions, which allows any custom code to retrieve a function pointer; Procedure Address Methods work similarly to the native library call style from an API perspective, but function similarly to the Procedure Address Expressions call style.

The aim of this call style is to provide flexibility without comprimising code readability. Consider the following example:

```cs
[UseNativeLibrary("glfw3.dll")]
[UseMethod(nameof(GetProcAddressShim))]
public partial class Glfw
{
    [NativeApi(CallStyle = CallStyles.NativeLibrary)]
    public partial nint glfwGetProcAddress(byte* str);

    // shim to convert the string, which SilkTouch needs to use, to a byte pointer - THIS IS NOT A MODEL EXAMPLE!
    private nint GetProcAddressShim(string str) => glfwGetProcAddress((byte*) Marshal.StringToHGlobalAnsi(str));

    public partial void glBegin(uint mode);
}
```

Procedure Address Methods are C# methods that **MUST** return a `void*`, `nint`, or `IntPtr`. This is the actual address in memory of the function being invoked.

This call style, if multiple call styles can be used for a given type, **MUST** be preferred over Native Library unless explicitly specified otherwise by the `NativeApi`'s `CallStyle` property, in which case the specified call style **MUST** be used. `NativeApi`'s `GetProcAddress` continues to be preferred over anything in any case as previously defined.

If there are no `UseMethod` attributes specified at the type-level, this call style **MUST NOT** be used even if requested in a function-level `NativeApi` attribute unless that attribute also specifies the `Method` property. Once again, as previously defined prefer `GetProcAddress` over `Method` if both are specified on the `NativeApi` attribute.   

For the parameter passed into the method referenced by the attribute, the function name **MUST** be used unless the `EntryPoint` property in the `NativeApi` attribute is provided, in which case the `EntryPoint` indicated by the attribute **MUST** be used.

The Emitter **MUST** call the function pointer returned by the Procedure Address Method as part of this call style.

### Native Calls
For the most part, the resultant native signature used by the Emitter is matched 1:1 with the method signature. However there are certain modifications you can apply. Namely, the `NativeApi` attribute will allow specification of specific calling conventions. For example:

```cs
[NativeApi(Modifiers = CallModifiers.MemberFunction | CallModifiers.SuppressGCTransition | CallModifiers.WinapiConvention)]
public partial D3D12_HEAP_PROPERTIES GetCustomHeapProperties(uint nodeMask, D3D12_HEAP_TYPE heapType);
```

- CallModifiers **MUST** be a bitmask with each modifier having its own unique bit.
- **MemberFunction**: If this modifier is specified, the Emitter **MUST** modify the function pointer call to use the Windows C++ instance member function calling style.
- **SuppressGCTransition**: If this modifier is specified, the Emitter **SHOULD** prevent the .NET garbage collector from transitioning between co-operative and pre-emptive mode during the call.
- **WinapiConvention**: If this modifier is specified, the Emitter **MUST** use the platform default calling convention. This convention **MUST** also be used if no other calling convention bits are set.
- **CdeclConvention**: If this modifier is specified, the Emitter **MUST** use the C `__cdecl` calling convention.
- **StdcallConvention**: If this modifier is specified, the Emitter **MUST** use the C `__stdcall` calling convention.
- **FastcallConvention**: If this modifier is specified, the Emitter **MUST** use the C `__fastcall` calling convention.
- **ThiscallConvention**: If this modifier is specified, the Emitter **MUST** use the C `__thiscall` calling convention.

`CallModifiers` will be used as the primary bitmask for customizing the behaviour of generation, just as `NativeApi` will be used as the primary attribute for this as well. The behaviour of each bit will be described in documentation comments in the Proposed API section.

The Emitter does not do any marshalling. As such, the Emitter **MUST** mandate that every parameter and return type of every function fits the `unmanaged` constraint. For the readers benefit, this can be done using a property on `ITypeSymbol` in Roslyn.

## SilkTouch Overloader
The Overloader, one of the two final stages which **MUST** be entirely independent of eachother, creates overloads of functions that expose a more user-friendly interface than the function it overloads, and do appropriate marshalling to lower the parameter types used down to the original function's types.

The Overloader **MUST** be activated using an `OverloadAttribute` applied to the assembly, type, and/or function contianing the method.

The Overloader **MUST** be able to be used on any function and not be tied to any of the Emitter's constraints.

The Overloader **MUST** be able to be invoked via the SilkTouch CLI and **MAY** be able to be invoked via an incremental Roslyn source generator.

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
