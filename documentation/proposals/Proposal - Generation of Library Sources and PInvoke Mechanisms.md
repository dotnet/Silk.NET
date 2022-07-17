# Summary
Proposal design for a platform invoke (P/Invoke) mechanism for Silk.NET 3.0.

# Contributors
- Dylan Perks (@Perksey)
- Kai Jellinghaus (@HurricanKai)

# Current Status
- [x] Proposed
- [x] Discussed with Working Group (WG)
- [x] Approved
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
The Emitter, one of the two final stages whose resources **MUST** be entirely independent of eachother, is responsible for generating the actual indirect calls for performing the P/Invoke.

The Emitter operates on partial methods, the behaviour of the implementations of which depending on the context in which it's used.

All attributes **MUST** be name matched only, to allow the user to define these themselves and not create a hard dependency on a specific Silk.NET library such as the Silk.NET Core. 

Candidate methods for implementation by the Emitter **MUST** be partial and not have an implementation part yet. Their containing types **MUST** also be partial.

The Emitter **MUST** be able to be invoked via the SilkTouch CLI and **MAY** be able to be invoked via an incremental Roslyn source generator.

### Call Styles

The Emitter's primary purpose is to load and use function pointers in a native library sourced from an operating system's kernel, though this doesn't necessarily have to be the case. This logic will be emitted by the Emitter itself, and will not require an external dependency like the Silk.NET Core. However, this logic will no longer be implicit.

#### Built-in: Dynamic-Link Library Call Style

Consider the following example:
```cs
[UseDynamicLibrary("glfw3.dll")]
public partial class Glfw
{
    public partial void glfwInit();
}
```

The `UseDynamicLibrary` attribute instructs the Emitter that it **MUST** use [`DllImport`](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.dllimportattribute?view=net-5.0) to access native functions. [`NativeLibrary`](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.nativelibrary?view=net-5.0) can be used to modify the libsuperrary loading process per other requirements defined below. For the entry point, the function name **MUST** be used unless a `NativeApi` attribute is provided, in which case the `EntryPoint` indicated by that attribute **MUST** be used.

Consider the following example:
```cs
[UseDynamicLibrary("glfw3.dll", "libglfw3.dylib")]
public partial class Glfw { /* ... */ }
```

`UseDynamicLibrary` **MUST** be able to be specified on either a function or type.

The Emitter **MUST** allow multiple candidate library names and cycle through each candidate until one loads successfully.

#### Built-in: Static-Link Library Call Style

Consider the following example:
```cs
[UseStaticLibrary]
public partial class Glfw
{
    public partial void glfwInit();
}
```

The `UseStaticLibrary` attribute instructs the Emitter that it **MUST** use [`DllImport`](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.dllimportattribute?view=net-5.0) to access native functions. `__Internal` **MUST** be used for the library name. For the entry point, the function name **MUST** be used unless a `NativeApi` attribute is provided, in which case the `EntryPoint` indicated by that attribute **MUST** be used.

`UseStaticLibrary` **MUST** be able to be specified on either a function or type.

Consider the following example:
```cs
#if __IOS__
[UseStaticLibrary]
#endif
[UseDynamicLibrary("glfw3.dll")]
public partial class Glfw
{
    public partial void glfwInit();
}
```

The Emitter **MUST** only generate code if all preprocessor directives guarding the `UseStaticLibrary` attribute evaluate to true. If the attribute is defined on both the function and the containing type, the preprocessor directives surrounding the function's attribute **MUST** be used instead of the preprocessor directives surrounding the type.

Note to the reader: Given preprocessor directives are processed at parse time in Roslyn, both of those last requirements are basically benign.

#### Custom Call Style: Procedure Address Expressions

Custom code may be used as a call style by providing a pointer to SilkTouch using a Procedure Address Expression. This is useful in scenarios such as COM interop.

Procedure Address Expressions are C# expressions that **MUST** evaluate to a `void*`, `nint`, or `IntPtr`. This is the actual address in memory of the function being invoked.

Consider the following example:
```cs
public partial struct IUnknown
{
    public void** LpVtbl;
    [UseExpression("LpVtbl[1]")]
    public partial uint AddRef();
}
```

`GetProcAddress` indicates that the C# code given **MUST** be used as the Procedure Address Expression to retrieve the function address to call. Any arbritrary code can be inserted into this attribute, so long as the result of the code once evaluated meets the Procedure Address Expression definition. For example, this is valid:
```cs
public partial struct IUnknownNullableContainer
{
    public IUnknownPtr? Value;
    [UseExpression("Value.GetValueOrDefault().InnerValue->LpVtbl[1]")]
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

Unless another call style is applicable, the Emitter **MUST** mandate that every function has a `UseExpression` (Procedure Address Expression) specified.

The Emitter **MUST** call the function pointer returned by the Procedure Address Expression as part of this call style.

#### Custom Call Style: Procedure Address Methods

A level more abstracted than Procedure Address Expressions, which allows any custom code to retrieve a function pointer; Procedure Address Methods work similarly to the native library call style from an API perspective, but function similarly to the Procedure Address Expressions call style.

The aim of this call style is to provide flexibility without comprimising code readability. Consider the following example:

```cs
[UseMethod(nameof(GetProcAddressShim))]
public partial class Glfw
{
    [UseDynamicLibrary("glfw3.dll")]
    public partial nint glfwGetProcAddress(byte* str);

    // shim to convert the string, which SilkTouch needs to use, to a byte pointer - THIS IS NOT A MODEL EXAMPLE!
    private nint GetProcAddressShim(string str) => glfwGetProcAddress((byte*) Marshal.StringToHGlobalAnsi(str));

    public partial void glBegin(uint mode);
}
```

Procedure Address Methods are method groups (or an otherwise callable expression) within the scope of the method that **MUST** return a `void*`, `nint`, or `IntPtr` when invoked. This is the actual address in memory of the function being invoked.

Procedure Address Methods **MUST** take one parameter of type `string`.

For the parameter passed into the callable specified in the attribute, the function name **MUST** be used unless the `EntryPoint` property in the `NativeApi` attribute is provided, in which case the `EntryPoint` indicated by the attribute **MUST** be used.

The Emitter **MUST** call the function pointer returned by the Procedure Address Method as part of this call style.

#### Call Style Priority

Consider the following example:

```cs
[UseDynamicLibrary("glfw3.dll")]
public partial class Glfw
{
    public partial nint glfwGetProcAddress(byte* str);
    [UseExpression("glfwGetProcAddress((byte*)Unsafe.AsPointer(ref Unsafe.AsRef(0x006e696765426c67)))")]
    public partial void glBegin(uint mode);
}
```

Here, a class using the Dynamic Library call style has a method which does not follow the call style defined at the class level, and is overridden using a `UseExpression` attribute.

If multiple call styles are applicable, the following order of preference **MUST** be respected:
- Procedure Address Expressions
- Procedure Address Methods
- Static-Link Library
- Dynamic-Link Library

Function-level attributes **MUST** be preferred over type-level ones, and follow the same order of preference.

### Native Calls
For the most part, the resultant native signature used by the Emitter is matched 1:1 with the method signature. However there are certain modifications you can apply. Namely, the `NativeApi` attribute will allow specification of specific calling conventions. For example:

```cs
[NativeApi(Conventions = new[]{typeof(CallConvMemberFunction), typeof(CallConvSuppressGCTransition)}]
public partial D3D12_HEAP_PROPERTIES GetCustomHeapProperties(uint nodeMask, D3D12_HEAP_TYPE heapType);
```


`Conventions` will be used as the primary mechanism for customizing the behaviour of generation, just as `NativeApi` will be used as the primary attribute for this as well. The behaviour of each bit will be described in documentation comments in the Proposed API section.

The Emitter does not do any marshalling. As such, the Emitter **MUST** mandate that every parameter and return type of every function fits the `unmanaged` constraint. For the readers benefit, this can be done using a property on `ITypeSymbol` in Roslyn.

## SilkTouch Overloader
The Overloader, one of the two final stages whose resources **MUST** be entirely independent of eachother, creates overloads of functions that expose a more user-friendly interface than the function it overloads, and do appropriate marshalling to lower the parameter types used down to the original function's types.

The Overloader **MUST** be able to be used on any function and not be tied to any of the Emitter's constraints.

The Overloader **MUST** be able to be invoked via the SilkTouch CLI and **MAY** be able to be invoked via an incremental Roslyn source generator.

The Overloader does not care about existing methods. If the Overloader generates an overload that also happens to exist manually, it is the user's repsonsibility to disable the relevant overloads for these cases.

However, if the Overloader thinks that the overload it's generating may conflict with another overload or the original function, it **SHOULD** output the overload as an extension method rather than a method within the containing type, unless the original method is static in which case it **MUST** discard the overload and generate a warning. It **SHOULD** also do this if the containing type is not partial.

The Silk.NET team does not wish to specify the functionality of the overloader at this time, and wishes to instead define this by experimenting with the overloader's functionality during development; with the understanding that the Silk.NET team must formalize a proposal with the working group before a "go live" release ships.

# Proposed API
- Here you do some code blocks, this is the heart and soul of the proposal. DON'T DO ANY IMPLEMENTATIONS! Just declarations.

## `UseDynamicLibrary`
```cs
namespace Silk.NET.Core
{
    [AttributeUsage(AttributeTargets.Function | AttributeTargets.Class)]
    public class UseDynamicLibraryAttribute : Attribute
    {
        public UseDynamicLibrary(string libraryName, params string[] alternativeNames);
        public string LibraryName { get; }
        public string[] AlternativeNames { get; }
    }
}
```

## `UseStaticLibrary`
```cs
namespace Silk.NET.Core
{
    [AttributeUsage(AttributeTargets.Function | AttributeTargets.Class)]
    public class UseStaticLibraryAttribute : Attribute
    {
    }
}
```

## `UseExpression`
```cs
namespace Silk.NET.Core
{
    [AttributeUsage(AttributeTargets.Function | AttributeTargets.Class)]
    public class UseExpressionAttribute : Attribute
    {
        public UseExpressionAttribute(string expr);
        public string Expression { get; }
    }
}
```

## `UseMethod`
```cs
namespace Silk.NET.Core
{
    [AttributeUsage(AttributeTargets.Function | AttributeTargets.Class)]
    public class UseMethodAttribute : Attribute
    {
        public UseMethodAttribute(string expr);
        public string Expression { get; }
    }
}
```

## `NativeApi`
```cs
namespace Silk.NET.Core
{
    public class NativeApiAttribute : Attribute
    {
        public string EntryPoint { get; set; }
        public Type[] Conventions { get; set; }
    }
}
```

# Meeting Notes

## 05/08/2021

- SilkTouch for 2.0 is very hard to use
- A lot of code
- Will explode the repo a lot, but will also improve compile times because everything's already there and no need to generate at compile time
- ClangSharp is used by win32metadata (official c#, rust bindings) and generally accurate for parsing header files
    - very correct, battle tested, more reliable than BuildTools 2.0
- Just use ReadOnlySpan<char> (implicit conversion from string)
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
- [ ] Report back to the Community our findings in experimenting with overloads
