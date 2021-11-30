# Summary

**_This proposal is dependent
on [Proposal - Vulkan Struct Chaining - #1 StructureType correction](Proposal%20-%20Vulkan%20Struct%20Chaining%20-%20%231%20StructureType%20correction.md)
._**

This proposal presents a lightweight mechanism for fluently building Vulkan Structure Chains. You may wish to start with
the [Usage section below](#Usage) to aid understanding. There is also a fully working prototype
[in Pull Request 683](https://github.com/dotnet/Silk.NET/pull/683).

To do so it marks any structure that meets the following requirements as being `IChainable`:

* Is a struct.
* Has a `StructureType SType` field in position 0 (first field)
* Has a `void* PNext` field in position 1 (second field)

The `IChainable` interface extends the `IStructuredType` interface
from [Proposal - Vulkan Struct Chaining - #1 StructureType correction](Proposal%20-%20Vulkan%20Struct%20Chaining%20-%20%231%20StructureType%20correction.md)
and so the explicit implementation of `IChainable.StructureType()` from
[that proposal](Proposal%20-%20Vulkan%20Struct%20Chaining%20-%20%231%20StructureType%20correction.md#istructuretype-implementation)
is triggerred for the structure, providing a mechanism for ensuring the `SType` is correctly set. It then exposes
a `BaseInStructure* PNext { get; set; }` property for easy access to the next item in the chain.

The presence of the `IChainable` interface, also acts as a **guarantee** that it is safe to cast any pointer of a struct
implementing it to a pointer to a `BaseInStructure` struct, which is a struct which has just the `SType` and `PNext`
fields present. Therefore it is always possible to cast `void* PNext` of an `IChainable` struct to `BaseInStructure*`.
It is this guarantee that requires the position of the fields to be fixed (which they are in practice). However, by
ensuring we validate the constraints at build time (when choosing to add the interface), we can prevent downstream bugs
occurring at run time.

**Note** that the `IChainable` interface adds the additional constraint that the `StructureType SType` field must be at
offset 0, i.e. in the first position to facilitate this functionality - which is not a constraint of `IStructuredType`.

However, rather than extending `IChainable` directly, where
the [Vulkan Specification](https://raw.githubusercontent.com/KhronosGroup/Vulkan-Headers/master/registry/vk.xml))
specifies chaining constraints, via the presence of the `structextends` attribute, `BuildTools` chooses one
of `IChainStart` or `IExtendsChain<TChain>` (both of which extend `IChainable`). The specification has nearly 100 chains
defined in this manner, and many of the >700 structures form part of these chains. However, over 200 structures are not
curretnly defined as part of a chain, and as such, all the utilities proposed have a 'looser' mechanism for working
with `IChainable` directly when it is necessary to do so.

For example, if `struct B` extends `struct A`, then `struct B` will be marked with `IExtendsChain<A>` and `struct A`
will be marked with `IChainStart`. A struct may only extend `IChainStart` once (even though it may appear in
the `structextends` attribute of many structs), but is may implement multiple `IExtendsChain<TChain>` interfaces. It is
also feasible for a struct to implement both (i.e. be able to extend other chains, as well as being a chain start), a
real example of this can be seen
[in the labs](../../src/Lab/Experiments/PrototypeStructChaining/PrototypeStructChaining/PhysicalDeviceFeatures2.cs).

As a result, `IChainable` will not usually be directly implemented (just as it is unlikely to see `IStructuredType`
[implemented directly]((Proposal%20-%20Vulkan%20Struct%20Chaining%20-%20%231%20StructureType%20correction.md))).
However, if
the [Vulkan Specification](https://raw.githubusercontent.com/KhronosGroup/Vulkan-Headers/master/registry/vk.xml) ever
includes a struct that meets the above constraints, but doesn't have, or appear in, a `structsextend` attribute, then it
will be explicitly marked as `IChainable`.

Whenever a struct is marked as `IChainStart` a static `ref [StructType] Chain(out [StructType]) capture);` method is
also added, providing an easy form of starting a chain with default values. As `IChainStart` also
implements `IChainable`, which implements `IStructuredType`, then a chain start will have three additional methods
generated (the static `Chain(out)` method and the explicit `IStructuredType.StructureType()` and `IChainable.PNext`
implementation); as compared to all other `IChainable` structs, which will only have the
explicit `IStructuredType.StructureType()` implementation from
[Proposal - Vulkan Struct Chaining - #1 StructureType correction](Proposal%20-%20Vulkan%20Struct%20Chaining%20-%20%231%20StructureType%20correction.md)
and the explicit `BaseInStructure* IChainable.PNext { get; set;}` property from this proposal.

The remaining functionality is provided entirely by the following new extension methods:

```csharp        
public static unsafe ref TChain SetNext<TChain, TNext>(this ref TChain chain, ref TNext value,
    bool alwaysAdd = false)
    where TChain : struct, IChainStart
    where TNext : struct, IExtendsChain<TChain> {...}
    
public static unsafe ref TChain SetNextAny<TChain, TNext>(this ref TChain chain, ref TNext value,
    where TChain : struct, IChainable
    where TNext : struct, IChainable {...}
    
public static unsafe ref TChain AddNext<TChain, TNext>(this ref TChain chain, out TNext next)
    where TChain : struct, IChainStart
    where TNext : struct, IExtendsChain<TChain> {...}
    
public static unsafe ref TChain AddNextAny<TChain, TNext>(this ref TChain chain, out TNext next)
    where TChain : struct, IChainable
    where TNext : struct, IChainable {...}

public static unsafe ref TChain TryAddNext<TChain, TNext>(this ref TChain chain, out TNext next, out bool added)
    where TChain : struct, IChainStart
    where TNext : struct, IExtendsChain<TChain> {...}

public static unsafe ref TChain TryAddNextAny<TChain, TNext>(this ref TChain chain, out TNext next, out bool added)
    where TChain : struct, IChainable
    where TNext : struct, IChainable {...}

public static unsafe int IndexOf<TChain, TNext>(this ref TChain chain, ref TNext value)
    where TChain : struct, IChainStart
    where TNext : struct, IExtendsChain<TChain> {...}

public static unsafe int IndexOfAny<TChain, TNext>(this ref TChain chain, ref TNext value)
    where TChain : struct, IChainable
    where TNext : struct, IChainable {...}
```

An implementation can be found [in Pull Request 683](https://github.com/dotnet/Silk.NET/pull/683) and their use is
detailed below.

# Contributors

- [Craig Dean, DevDecoder](https://github.com/thargy)

# Current Status

- [x] Proposed
- [x] Discussed with API Review Board (ARB)
- [x] Approved
- [x] Implemented

# Design Decisions

The following requirements are achieved by this proposal:

- **Backward compatibility** - the chaining system should not modify the existing structs, but add functionality.
- **Minimal bloat** - the minimum amount of new generated code was sought.
- **Discoverability** - it should be as easy as possible for a new user to discover.
- **Compile-time Validation** - it should prevent chaining invalid structures (as much as possible) during compilation.
- **SType coercion** - it should always set the `SType` of chained structures.
- **Pointer management** - it should handle setting the `PNext` pointer of structures.
- **Compact usage** - it should reduce copy-pasta code.
- **Avoids the heap** - boxing should be avoided.
- **Well Tested** - tests were added to ensure pointers are correctly set, and compilation failures occur.

What this proposal does not do (some of these _are_ addressed
in [Proposal - Vulkan Struct Chaining - #3 Managed Chaining](Proposal%20-%20Vulkan%20Struct%20Chaining%20-%20%233%20Managed%20Chaining.md))
is manage pointers of structures that find themselves on the heap. Any supplied structures should be held on the stack,
once moved to the heap their `PNext` values can no longer be trusted as the GC is free to move structures in heap
memory. The proposed extension methods make it difficult to use with heap objects, but it is not impossible. The
presence of the `ManagedChain` classes
from [the proposal for managed chains](Proposal%20-%20Vulkan%20Struct%20Chaining%20-%20%233%20Managed%20Chaining.md),
along with a well documented API should highlight the danger of such practices.

Indeed, it is important to remember that such dangers are already part of the existing implementation and are a feature
of using unmanaged pointers in .NET rather than a limitation of this proposal.

To be discussed:

- Whether to include [specific chain interfaces](#chain-interfaces-optional).

# Usage

The proposal provides for the following usages. Note that where an `Any` extension method is mentioned, it is identical
to the non-`Any` version (e.g. `AddNext` and `AddNextAny` are equivalent), save that the `Any` version does not
constrain the types to those associated with a defined chain, instead types only need to be `IChainable`.

### Chain Building

You can happily create the start of a chain as usual, by declaring a variable first. Indeed it is necessary to do so if
you wish to specify non-default values (though you can also make use of `SetNext`s replace functionality). You also need
to use this approach when starting a chain which is not explicitly defined as a chain start by the specification. If you
do start a chain with such a structure, you will have to use the `Any` versions of the extension methods below to
continue manipulating it.

Regardless, the `SType` and `PNext` will be overwritten whenever you start manipulating the chain, so you should never
set them manually. For example:

```csharp
var createInfo = new DeviceCreateInfo
{
    Flags = 1U
};
// When you call any chaining method it will set the chain's SType automatically.
createinfo.AddNext...
```

In many cases, we only want to create a default structure for population by the API. To do so, we use the
static `BaseInStructure` method like so:

```csharp
PhysicalDeviceFeatures2.Chain(out var features2)
```

This has several advantages:

- The method is only available for structures that are valid at the start of a chain; providing compile-time validation.
- The structure's `SType` will be correctly set immediately.
- The syntax is fluent, and creates more readable code when used with the other chaining methods (see below).

**Note** All the chaining methods return the current start of the chain by reference (including `BaseInStructure`). This
allows each method to scan the entire chain. More importantly, it allows the Type constraints to be checked during
compile time to ensure that a type actually can extend the chain. One side effect is that `ref Chain(out)` outputs the
newly created chain _and_ returns a reference to it. This can cause confusion to less experienced C# devs, for example:

```csharp
// Don't do this, it is harmless but unnecessary and confusing!
var a = ChainStart.Chain(out var b).AddNext(out ChainExtension c);
```

Both `a` and `b` will appear to be identical structures; however 'a' is actually a copy of 'b', being separate locations
on the current stack frame. In most cases, that is really no problem at all as both point to the _start_ of a chain, and
so there are no unmanaged pointers pointing _to them_, therefore using _either_ is fine (though completely unnecessary).

However, for deeper understanding the chain extension methods actually _take a reference_ to `this`, so `AddNext`
actually updates the `PNext` of variable `b`. Once the chain is built the final assignment _to_ `a` _copies_ `b`
into `a`. None of this is undefined behaviour, but as it is generally poorly understood so none of the examples ever
recommend assigning the output of a chain.

The `Chain` method is a static method implemented on `IChainStart` structures, the remaining methods are actually
extension methods. The methods ending with `Any` can be used with any `IChainable` structure, but they do not constrain
the entries, or the head of the chain to being structures explicitly mentioned by the specification. The non-`Any`
methods are more restrictive, and should usually be used in preference.

### AddNext / AddNextAny

The most common use case is to add an empty structure to the end of a chain for it to be populated by the Vulkan API,
this can now be done like so:

```csharp
PhysicalDeviceFeatures2
    .Chain(out var features2)
    // CreateNext will create an empty struct, with the correct SType (as well as ensuring the
    // chain's SType is set correctly).
    .AddNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures)
    .AddNext(out PhysicalDeviceAccelerationStructureFeaturesKHR accelerationStructureFeaturesKhr);
```

Each method `out` puts a struct into the local stack frame for querying once populated, and the pointers point to this
local variable. Despite generics and interfaces being used, the chain methods avoid the heap entirely.

### TryAddNext / TryAddNextAny

You may only want to add a structure if it doesn't already exist in the chain, this can be done with `TryAddNext`, e.g.:

```csharp
PhysicalDeviceFeatures2
    .Chain(out var features2)
    .AddNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures)
    // As there is already a PhysicalDeviceDescriptorIndexingFeatures structure the following
    // will not add anything to the chain and `added` will be `false`.
    .TryAddNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures2, out bool added);
```

### SetNext / SetNextAny

Sometimes we may wish to set the initial state of a structure, or replace any existing item within the structure that
has the same `StructureType` we can do this with `SetNext`:

```csharp
var indexingFeatures = new PhysicalDeviceDescriptorIndexingFeatures
{
    ShaderInputAttachmentArrayDynamicIndexing = true
};

// Unlike AddNext, SetNext will only add the structure if isn't already present, otherwise it will overwrite it.
// So we can provide a default to SetNext like so:
var accelerationStructureFeaturesKhr = default(PhysicalDeviceAccelerationStructureFeaturesKHR);

PhysicalDeviceFeatures2
    .Chain(out var features2)
    // SetNext accepts an existing struct, note, it will coerce the SType and blank the PNext
    .SetNext(ref indexingFeatures)
    .SetNext(ref default(PhysicalDeviceAccelerationStructureFeaturesKHR));
```

*NOTE* you can mix and match `AddNext` and `SetNext` (and any chaining method) in the same method chain.

By default, `SetNext` will _replace_ any item in the chain with a matching `SType`, this behaviour can be changed by
setting the optional `alwaysAdd` parameter to `true`;

```csharp
var indexingFeatures = new PhysicalDeviceDescriptorIndexingFeatures
{
    ShaderInputAttachmentArrayDynamicIndexing = true
};
var indexingFeatures2 = new PhysicalDeviceDescriptorIndexingFeatures
{
    ShaderInputAttachmentArrayDynamicIndexing = false
};
var accelerationStructureFeaturesKhr = new PhysicalDeviceAccelerationStructureFeaturesKHR
{
    AccelerationStructure = true
};

PhysicalDeviceFeatures2
    .Chain(out var features2)
    .SetNext(ref indexingFeatures)
    // This will add the second 'indexingFeatures' struct, even though one is already present in the chain.
    .SetNext(ref indexingFeatures2, true);
```

### IndexOf / IndexOfAny

Sometimes it's useful to know if a structure you previously supplied is still in a chain, this can be done
with `IndexOf`, which returns a non-negative index (zero-indexed) if the structure is found, eg.:

```csharp
PhysicalDeviceFeatures2
    .Chain(out var features2)
    .AddNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures)
    .AddNext(out PhysicalDeviceAccelerationStructureFeaturesKHR accelerationStructureFeaturesKhr);

// Check indices
Assert.Equal(1, features2.IndexOf(ref indexingFeatures));
Assert.Equal(2, features2.IndexOf(ref accelerationStructureFeaturesKhr));
```

### Validation

Due to the generic constraints, all the chain extensions are only valid on a struct that implements `IChainStart` and
only accept struct that implement `IExtends<TChain>` where `TChain` is the chain type. This means that it is impossible
to add invalid structs to a chain with these methods. Further, using any of the chain extension methods guarantees that
the chain, and the supplied item have the correct `SType`, **and** that the `PNext` pointers along the chain are valid.

# Proposed API

## Chaining interfaces

### IChainable

The base interface of chaining interfaces:

```csharp
namespace Silk.Net.Vulkan;

/// <summary>
/// Base interface for any struct that has can set the next value.
/// </summary>
/// <remarks><para>Note that any structure marked <see cref="IChainable"/> must start with a
/// <see cref="StructureType"/> and a <c>void*</c> field, in that order. This is so that a pointer to it can be coerced
/// to a pointer to a <see cref="Chain"/>.</para></remarks>
public interface IChainable : IStructuredType
{
    /// <summary>
    /// Points to the next <see cref="IChainable"/> in this chain, if any; otherwise <see langword="null"/>.
    /// </summary>
    unsafe BaseInStructure* PNext { get; set; }
}

```

### IChainStart

Implemented by any struct that can be used as the start of a chain:

```csharp
namespace Silk.Net.Vulkan;

/// <summary>
/// Marks a <see cref="IChainable">chainable</see> struct as being allowed at the start of a chain.
/// </summary>
/// <remarks><para>Any <see cref="IChainStart"/> will have a corresponding static `Chain(out var chain)`
/// convenience method.</para></remarks>
public interface IChainStart : IChainable
{
}
```

### IExtendsChain<TChain>

Implemented by any struct that can be added to a chain.

```csharp
namespace Silk.Net.Vulkan;

/// <summary>
/// Marks a <see cref="IChainable">chainable</see> struct indicating which <see cref="IChainStart">chain</see> this type
/// extends.
/// </summary>
/// <typeparam name="TChain">A chain start structure.</typeparam>
public interface IExtendsChain<out TChain> : IChainable
    where TChain : IChainable
{
}
```

### Chain Extension Methods

Provides the struct chaining functionality, the full implementation can be
found [in the labs](../../src/Lab/Experiments/PrototypeStructChaining/PrototypeStructChaining/ChainExtensions.cs):

```csharp
namespace Silk.NET.Vulkan;

/// <summary>
/// Extension methods and utilities for building unmanaged structure chains.
/// </summary>
public static class Chain
{
    /// <summary>
    /// Replaces a structure in the chain (if present, and <paramref name="alwaysAdd"/> is false), or adds it to the end.
    /// </summary>
    /// <param name="chain">The current chain</param>
    /// <param name="value">A reference to the structure to update</param>
    /// <param name="alwaysAdd">Always adds to the end of the chain, even if an equivalent structure is present.</param>
    /// <typeparam name="TChain">The type of the current chain</typeparam>
    /// <typeparam name="TNext">The type of the value</typeparam>
    /// <returns>A reference to the value value in the chain</returns>
    /// <remarks>
    /// <para>Note that both the supplied chain, and the supplied value will have their `SType` correctly set.  Further,
    /// the supplied structure's <see cref="IChainable.PNext"/> will be overwritten.</para>
    /// <para>To use</para>
    /// <code>
    /// var indexingFeatures = new PhysicalDeviceDescriptorIndexingFeatures
    /// {
    ///     ShaderInputAttachmentArrayDynamicIndexing = true
    /// };
    /// var accelerationStructureFeaturesKhr = new PhysicalDeviceAccelerationStructureFeaturesKhr
    /// {
    ///     AccelerationStructure = true
    /// };
    /// 
    /// PhysicalDeviceFeatures2
    ///     .BaseInStructure(out var features2)
    ///     .SetNext(ref indexingFeatures)
    ///     .SetNext(ref accelerationStructureFeaturesKhr);
    /// </code>
    /// </remarks>
    /// <seealso cref="SetNextAny{TChain,TNext}"/>
    /// <seealso cref="AddNext{TChain,TNext}"/>
    /// <seealso cref="AddNextAny{TChain,TNext}"/>
    /// <seealso cref="TryAddNext{TChain,TNext}"/>
    /// <seealso cref="TryAddNextAny{TChain,TNext}"/>
    /// <seealso cref="IndexOf{TChain,TNext}"/>
    /// <seealso cref="IndexOfAny{TChain,TNext}"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref TChain SetNext<TChain, TNext>
    (
        this ref TChain chain,
        ref TNext value,
        bool alwaysAdd = false
    )
        where TChain : struct, IChainStart
        where TNext : struct, IExtendsChain<TChain>
        => ref SetNextAny(ref chain, ref value, alwaysAdd);

    /// <summary>
    /// Replaces a structure in the chain (if present, and <paramref name="alwaysAdd"/> is false), or adds it to the end.
    /// </summary>
    /// <param name="chain">The current chain</param>
    /// <param name="value">A reference to the structure to update</param>
    /// <param name="alwaysAdd">Always adds to the end of the chain, even if an equivalent structure is present.</param>
    /// <typeparam name="TChain">The type of the current chain</typeparam>
    /// <typeparam name="TNext">The type of the value</typeparam>
    /// <returns>A reference to the value value in the chain</returns>
    /// <remarks>
    /// <para>Note that both the supplied chain, and the supplied value will have their `SType` correctly set.  Further,
    /// the supplied structure's <see cref="IChainable.PNext"/> will be overwritten.</para>
    /// <para>To use</para>
    /// <code>
    /// var indexingFeatures = new PhysicalDeviceDescriptorIndexingFeatures
    /// {
    ///     ShaderInputAttachmentArrayDynamicIndexing = true
    /// };
    /// var accelerationStructureFeaturesKhr = new PhysicalDeviceAccelerationStructureFeaturesKhr
    /// {
    ///     AccelerationStructure = true
    /// };
    /// 
    /// PhysicalDeviceFeatures2
    ///     .BaseInStructure(out var features2)
    ///     .SetNext(ref indexingFeatures)
    ///     .SetNext(ref accelerationStructureFeaturesKhr);
    /// </code>
    /// </remarks>
    /// <seealso cref="SetNext{TChain,TNext}"/>
    /// <seealso cref="SetNextAny{TChain,TNext}"/>
    /// <seealso cref="AddNext{TChain,TNext}"/>
    /// <seealso cref="AddNextAny{TChain,TNext}"/>
    /// <seealso cref="TryAddNext{TChain,TNext}"/>
    /// <seealso cref="TryAddNextAny{TChain,TNext}"/>
    /// <seealso cref="IndexOf{TChain,TNext}"/>
    /// <seealso cref="IndexOfAny{TChain,TNext}"/>
    public static unsafe ref TChain SetNextAny<TChain, TNext>
    (
        this ref TChain chain,
        ref TNext value,
        bool alwaysAdd = false
    )
        where TChain : struct, IChainable
        where TNext : struct, IChainable
    {...}

    /// <summary>
    /// Adds a structure to the end of the chain.
    /// </summary>
    /// <param name="chain">The current chain</param>
    /// <param name="next">The structure added to the end of the chain</param>
    /// <typeparam name="TChain">The type of the current chain</typeparam>
    /// <typeparam name="TNext">The type of the structure to add</typeparam>
    /// <returns>The reference to the chain.</returns>
    /// <remarks>
    /// <para>Note that both the supplied chain, and the added structure will have their `SType` correctly set</para>
    /// <para>To use specify the output type required, e.g.:</para>
    /// <code>
    /// PhysicalDeviceFeatures2
    ///     .BaseInStructure(out var features2)
    ///     .AddNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures)
    ///     .AddNext(out PhysicalDeviceAccelerationStructureFeaturesKhr accelerationStructureFeaturesKhr);
    /// </code>
    /// <para>Note, the value is always added, even if an equivalent value is added in the chain already.  Use
    /// <see cref="TryAddNext{TChain,TNext}"/> to only add if not already present.</para>
    /// </remarks>
    /// <seealso cref="SetNext{TChain,TNext}"/>
    /// <seealso cref="SetNextAny{TChain,TNext}"/>
    /// <seealso cref="AddNextAny{TChain,TNext}"/>
    /// <seealso cref="TryAddNext{TChain,TNext}"/>
    /// <seealso cref="TryAddNextAny{TChain,TNext}"/>
    /// <seealso cref="IndexOf{TChain,TNext}"/>
    /// <seealso cref="IndexOfAny{TChain,TNext}"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref TChain AddNext<TChain, TNext>(this ref TChain chain, out TNext next)
        where TChain : struct, IChainStart
        where TNext : struct, IExtendsChain<TChain>
        => ref AddNextAny(ref chain, out next);

    /// <summary>
    /// Adds a structure to the end of the chain.
    /// </summary>
    /// <param name="chain">The current chain</param>
    /// <param name="next">The structure added to the end of the chain</param>
    /// <typeparam name="TChain">The type of the current chain</typeparam>
    /// <typeparam name="TNext">The type of the structure to add</typeparam>
    /// <returns>The reference to the chain.</returns>
    /// <remarks>
    /// <para>Note that both the supplied chain, and the added structure will have their `SType` correctly set</para>
    /// <para>To use specify the output type required, e.g.:</para>
    /// <code>
    /// PhysicalDeviceFeatures2
    ///     .BaseInStructure(out var features2)
    ///     .AddNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures)
    ///     .AddNext(out PhysicalDeviceAccelerationStructureFeaturesKhr accelerationStructureFeaturesKhr);
    /// </code>
    /// <para>Note, the value is always added, even if an equivalent value is added in the chain already.  Use
    /// <see cref="TryAddNext{TChain,TNext}"/> to only add if not already present.</para>
    /// </remarks>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="SetNext{TChain,TNext}"/>
    /// <seealso cref="SetNextAny{TChain,TNext}"/>
    /// <seealso cref="AddNext{TChain,TNext}"/>
    /// <seealso cref="TryAddNext{TChain,TNext}"/>
    /// <seealso cref="TryAddNextAny{TChain,TNext}"/>
    /// <seealso cref="IndexOf{TChain,TNext}"/>
    /// <seealso cref="IndexOfAny{TChain,TNext}"/>
    public static unsafe ref TChain AddNextAny<TChain, TNext>(this ref TChain chain, out TNext next)
        where TChain : struct, IChainable
        where TNext : struct, IChainable
    {...}

    /// <summary>
    /// Tries to add a structure to the end of the chain.
    /// </summary>
    /// <param name="chain">The current chain</param>
    /// <param name="next">The structure added to the end of the chain</param>
    /// <param name="added">Whether the structure was actually added</param>
    /// <typeparam name="TChain">The type of the current chain</typeparam>
    /// <typeparam name="TNext">The type of the structure to add</typeparam>
    /// <returns>The reference to the chain.</returns>
    /// <remarks>
    /// <para>Note that both the supplied chain, and the added structure will have their `SType` correctly set</para>
    /// <para>To use specify the output type required, e.g.:</para>
    /// <code>
    /// PhysicalDeviceFeatures2
    ///     .BaseInStructure(out var features2)
    ///     .TryAddNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures, out var added);
    /// </code>
    /// </remarks>
    /// <seealso cref="SetNext{TChain,TNext}"/>
    /// <seealso cref="SetNextAny{TChain,TNext}"/>
    /// <seealso cref="AddNext{TChain,TNext}"/>
    /// <seealso cref="AddNextAny{TChain,TNext}"/>
    /// <seealso cref="TryAddNextAny{TChain,TNext}"/>
    /// <seealso cref="IndexOf{TChain,TNext}"/>
    /// <seealso cref="IndexOfAny{TChain,TNext}"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref TChain TryAddNext<TChain, TNext>(this ref TChain chain, out TNext next, out bool added)
        where TChain : struct, IChainStart
        where TNext : struct, IExtendsChain<TChain>
        => ref TryAddNextAny(ref chain, out next, out added);

    /// <summary>
    /// Tries to add a structure to the end of the chain.
    /// </summary>
    /// <param name="chain">The current chain</param>
    /// <param name="next">The structure added to the end of the chain</param>
    /// <param name="added">Whether the structure was actually added</param>
    /// <typeparam name="TChain">The type of the current chain</typeparam>
    /// <typeparam name="TNext">The type of the structure to add</typeparam>
    /// <returns>The reference to the chain.</returns>
    /// <remarks>
    /// <para>Note that both the supplied chain, and the added structure will have their `SType` correctly set</para>
    /// <para>To use specify the output type required, e.g.:</para>
    /// <code>
    /// PhysicalDeviceFeatures2
    ///     .BaseInStructure(out var features2)
    ///     .TryAddNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures, out var added);
    /// </code>
    /// </remarks>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="SetNext{TChain,TNext}"/>
    /// <seealso cref="SetNextAny{TChain,TNext}"/>
    /// <seealso cref="AddNext{TChain,TNext}"/>
    /// <seealso cref="AddNextAny{TChain,TNext}"/>
    /// <seealso cref="TryAddNext{TChain,TNext}"/>
    /// <seealso cref="IndexOf{TChain,TNext}"/>
    /// <seealso cref="IndexOfAny{TChain,TNext}"/>
    public static unsafe ref TChain TryAddNextAny<TChain, TNext>(this ref TChain chain, out TNext next, out bool added)
        where TChain : struct, IChainable
        where TNext : struct, IChainable
    {...}

    /// <summary>
    /// Returns the index of the <paramref name="value"/> in the <paramref name="chain"/>, if present.
    /// </summary>
    /// <param name="chain">The chain</param>
    /// <param name="value">The structure value</param>
    /// <typeparam name="TChain">The type of the current chain</typeparam>
    /// <typeparam name="TNext">The type of the value</typeparam>
    /// <returns>The zero-indexed index if found; otherwise -1.</returns>
    /// <seealso cref="SetNext{TChain,TNext}"/>
    /// <seealso cref="SetNextAny{TChain,TNext}"/>
    /// <seealso cref="AddNext{TChain,TNext}"/>
    /// <seealso cref="AddNextAny{TChain,TNext}"/>
    /// <seealso cref="TryAddNext{TChain,TNext}"/>
    /// <seealso cref="TryAddNextAny{TChain,TNext}"/>
    /// <seealso cref="IndexOfAny{TChain,TNext}"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IndexOf<TChain, TNext>(this ref TChain chain, ref TNext value)
        where TChain : struct, IChainStart
        where TNext : struct, IExtendsChain<TChain>
        => IndexOfAny(ref chain, ref value);

    /// <summary>
    /// Returns the index of the <paramref name="value"/> in the <paramref name="chain"/>, if present.
    /// </summary>
    /// <param name="chain">The chain</param>
    /// <param name="value">The structure value</param>
    /// <typeparam name="TChain">The type of the current chain</typeparam>
    /// <typeparam name="TNext">The type of the value</typeparam>
    /// <returns>The zero-indexed index if found; otherwise -1.</returns>
    /// <seealso cref="IndexOf{TChain,TNext}"/>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="SetNext{TChain,TNext}"/>
    /// <seealso cref="SetNextAny{TChain,TNext}"/>
    /// <seealso cref="AddNext{TChain,TNext}"/>
    /// <seealso cref="AddNextAny{TChain,TNext}"/>
    /// <seealso cref="TryAddNext{TChain,TNext}"/>
    /// <seealso cref="TryAddNextAny{TChain,TNext}"/>
    /// <seealso cref="IndexOf{TChain,TNext}"/>
    public static unsafe int IndexOfAny<TChain, TNext>(this ref TChain chain, ref TNext value)
        where TChain : struct, IChainable
        where TNext : struct, IChainable
    {...}
}
```

### Chain Structure

The `BaseInStructure` struct makes it easy to access the `SType` and `PNext` of a structure pointed to by `void* PNext`,
although it is used internally, it is useful for consumers of Silk.Net to have access to use in their own scenarios,
that is because the `IChainable` interface does not directly expose the underlying `SType` and `PNext` fields; as they
are fields (not properties), and this proposal aims to avoid boxing (so we try not to use the interface directly
unnecessarily).

```csharp
namespace Silk.Net.Vulkan;

/// <summary>
/// Header struct of all <see cref="IChainable"/> structs.
/// </summary>
/// <remarks>
/// <para>Any pointer to a structure marked as <see cref="IChainable"/> can safely be cast to a pointer to this type.</para>
/// <para>In particular, this means that the <c>void* PNext</c> field can always be safely cast to <c>BaseInStructure*</c>, providing
/// access to the `SType` and `PNext` fields.
/// </para>
/// </remarks>
public struct Chain : IChainable
{
    /// <summary>
    /// The structure type.
    /// </summary>
    public StructureType SType;
    /// <summary>
    /// The next <see cref="IChainable"/> struct in the chain, if any; otherwise <see langword="null"/>.
    /// </summary>
    public unsafe BaseInStructure* PNext;

    /// <inheritdoc />
    /// <remarks>Note, this cannot coerce the type as 'guaranteed by the `IStructuredType` interface.</remarks>
    StructureType IStructuredType.StructureType()
    {
        return SType;
    }
}
```

### Static Chain implementation

Whenever the `IChainStart` interface is added to an `IChainable` struct, the following static convenience methods is
also added:

```csharp
/// <summary>
/// Convenience method to start a chain.
/// </summary>
/// <param name="capture">The newly created chain root</param>
/// <returns>A reference to the newly created chain.</returns>
public static unsafe ref [StrucType] Chain(
    out [StructType] capture)
{
    capture = new [StructType](StructureType.[StructureType]);
    return ref capture;
}
```

### Chain interfaces (Optional)

As a useful optional extra, whenever an `IChainStart` struct is found, a corresponding `I[StructName]Chain` is created,
that extends from `IChainable`, e.g.:

```csharp
namespace Silk.Net.Vulkan;

/// <summary>
/// Marks a <see cref="IChainable">chainable</see> struct as being part of the `DeviceCreateInfo` chain.
/// </summary>
public interface IDeviceCreateInfoChain : IChainable
{
}
```

This interface is then added to the corresponding `IChainStart` _and_ any struct that implements the
corresponding `IExtendsChain<TChain>`. The primary benefit of this approach is to make it significantly easier to write
code that accepts any part of a specific chain (including the head).