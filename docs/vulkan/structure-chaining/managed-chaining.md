# Managed Chaining

[Table of Contents](overview.md#table-of-contents)

- [Introduction](managed-chaining.md#introduction)
    - [Type Constraints](managed-chaining.md#type-constraints)
    - [Disposal](managed-chaining.md#disposal)
    - ['Any' Overloads](managed-chaining.md#any-overloads)
    - [Equality](managed-chaining.md#equality)
    - [Casting to pointers](managed-chaining.md#casting-to-pointers)
- [Usage](managed-chaining.md#usage)
    - [Creation (Create/CreateAny)](managed-chaining.md#creation-createcreateany)
    - [Modifying values](managed-chaining.md#modifying-values)
    - [Duplication (Duplicate)](managed-chaining.md#duplication-duplicate)
    - [Loading from an unmanaged chain (Load/LoadAny)](managed-chaining.md#loading-from-an-unmanaged-chain-loadloadany)
    - [Adding to a chain (Add/AddAny)](managed-chaining.md#adding-to-a-chain-addaddany)
    - [Truncating (Truncate/TruncateAny)](managed-chaining.md#truncating-truncatetruncateany)
    - [Deconstruction](managed-chaining.md#deconstruction)
- [Chain Base Class](managed-chaining.md#chain-base-class)
    - [IReadOnlyList](managed-chaining.md#ireadonlylist)
    - [Clearing (Clear)](managed-chaining.md#clearing-clear)
- [Performance](managed-chaining.md#performance)

## Introduction

The managed chaining methodology use
the [`Silk.NET.Vulkan.Chain` abstract class](../../src/Vulkan/Silk.NET.Vulkan/Chain.cs) and its descendents. Similar to
the [`System.Tuple` class](https://docs.microsoft.com/en-us/dotnet/api/system.tuple?view=net-6.0), these are
[auto-generated](../../src/Vulkan/Silk.NET.Vulkan/Chain.gen.tt) and take the form `Chain<TChain>`, `Chain<TChain, T1>`
, `Chain<TChain, T1>`
, ..., `Chain<TChain, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>`; supporting chains of length 1
to 16 (including the head). The generated code can be seen [here](../../src/Vulkan/Silk.NET.Vulkan/Chain.gen.cs).

### Type Constraints

Each item type (including the head) is constrained to be `IChainable`, e.g.:

```csharp
public unsafe sealed class Chain<TChain, T1> : Chain, IEquatable<Chain<TChain, T1>>
    where TChain : unmanaged, IChainable
    where T1 : unmanaged,  IChainable
{ ... }
```

**NOTE**: Chains are not themselves 'tightly' constrained (that is insisting on `IChainStart`
and `IExtendsChain<TChain>`
types) as they need to support the `*Any` use case (see [below](#any-overloads)). However the various default static
method _do_ constrain the types more strictly, e.g.:

```csharp
/// <summary>
/// Creates a new <see cref="Chain{TChain, T1}"/> with 2 items.
/// </summary>
/// <param name="head">The head of the chain.</param>
/// <param name="item1">Item 1.</param>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <returns>A new <see cref="Chain{TChain, T1}"/> with 2 items.</returns>
/// <seealso cref="CreateAny{TChain, T1}(TChain, T1)" />
[MethodImpl(MethodImplOptions.AggressiveInlining)]
public static Chain<TChain, T1> Create<TChain, T1>(TChain head = default, T1 item1 = default)
    where TChain : unmanaged,  IChainStart
    where T1 : unmanaged, IExtendsChain<TChain>
    => new(head, item1);
```

as compared to:

```csharp
/// <summary>
/// Creates a new <see cref="Chain{TChain, T1}"/> with 2 items.
/// </summary>
/// <param name="head">The head of the chain.</param>
/// <param name="item1">Item 1.</param>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
/// <returns>A new <see cref="Chain{TChain, T1}"/> with 2 items.</returns>
/// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
/// useful for situations where the specification does not indicate required chain constraints. You should generally
/// try to use the none `Any` version in preference.</para></remarks>
/// <seealso cref="Create{TChain, T1}(TChain, T1)" />
[MethodImpl(MethodImplOptions.AggressiveInlining)]
public static Chain<TChain, T1> CreateAny<TChain, T1>(TChain head = default, T1 item1 = default)
where TChain : unmanaged, IChainable
where T1 : unmanaged,  IChainable
=> new(head, item1);
```

Note how `CreateAny` supports the looser constraints of `IChainable`, but the default `Create` method insists
on `TChain` implementing `IChainStart`, whilst all subsequent items must implement `IExtendsChain<TChain>`.

You may also note
the [`unmanaged` constraint](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-7.3/blittable)
, this is a tighter constraint than `struct` and is met by all the Vulkan API structures. Usefully, it ensures that we
are not being passed a structure which has pointers to managed memory (e.g. objects on the heap), this allows use to
'blit' the chain's items directly to/from memory safely.

### Disposal

It is useful to note, that although Chains offer a wealth of functionality, almost all of it is provided via statics or
properties, and in reality each instance only contains a single pointer field, which points to the start of a chain in
memory:

```csharp
private nint _headPtr`;
```

As this pointer points to an 'unmanaged' block of process memory, then it is vital that it is freed when the chain is no
longer used, to prevent memory leaks. As such, every `Chain` object implements `IDisposable` and you _must always
dispose it_ when you have finished with it. The easiest way, of course, is to use the C# `using` statement; however, if
you are storing a `Chain` within another object, you will usually implement `IDisposable` on the container and
call `Dispose` on the `Chain` when appropriate.

**WARNING**: Many of the chain manipulation methods listed will return a new instance of the chain. When using these
methods you should be extra careful and remember to dispose the original chain after modification, if it no longer being
used.

### 'Any' Overloads

[_(see also)_](vulkan.md#any-overloads)

The `Chain` classes include `*Any` versions of many methods. In fact, the `Chain<THead...>` type constraints are
themselves 'loose', that is they only require types to be `IChainable` rather than requiring the stricter constraints
that prevent unrelated chain elements being added, or used as the start of a chain.

You cannot create or change the length of a chain save through static methods, and the preferred versions do include the
tighter constraints. For conciseness we do only show the default methods below, but we indicate where an `*Any` overload
is available in the titles.

### Equality

All the fully generic `Chain<TChain...>` types implement the corresponding `IEquatable<Chain<TChain...>>`
interfaces, and equality operators, as well as `GetHashCode`. The base `Chain` also implements `IEquatable<Chain>` and
the equality operators.

Two separate instances of a `Chain` will hold separate blocks of unmanaged memory, however, they can be directly
compared, so long as the `PNext` locations are skipped as the pointers will point to different internal locations. As
such, two chains are considered equal if all their contents are equal, except their `PNext` pointers.

### Casting to pointers

Ultimately, the main use of many `Chain`s is to pass it to the VulkanAPI. To facilitate this, all chains implicitly cast
to `nint`, `void*`, `BaseInStructure*` and `THead*`. For example:

```csharp
using var chain = Chain.Create<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures,
    PhysicalDeviceAccelerationStructureFeaturesKHR>();

PhysicalDeviceFeatures2* p = chain;
Assert.Equal((nint)p, (nint)chain.HeadPtr);

BaseInStructure* b = chain;
Assert.Equal((nint)b, (nint)chain.HeadPtr);

void* v = chain;
Assert.Equal((nint)v, (nint)chain.HeadPtr);

nint n = chain;
Assert.Equal(n, (nint)chain.HeadPtr);

// We can pass a chain directly to many API calls
vk.GetPhysicalDeviceFeatures2(device, features2);
```

## Usage

### Creation (Create/CreateAny)

The following will create a chain starting with `PhysicalDeviceFeatures2`, pointing
to `PhysicalDeviceDescriptorIndexingFeatures` and finishing with a `PhysicalDeviceAccelerationStructureFeaturesKHR`
structure:

```csharp
using var chain = Chain.Create
        (
            default(PhysicalDeviceFeatures2),
            default(PhysicalDeviceDescriptorIndexingFeatures),
            default(PhysicalDeviceAccelerationStructureFeaturesKhr)
        );
        
// Ensure all STypes set correctly
Assert.Equal(StructureType.PhysicalDeviceFeatures2, chain.Head.SType);
Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, chain.Item1.SType);
Assert.Equal(StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr, chain.Item2.SType);

// Ensure pointers set correctly
Assert.Equal((nint) chain.Item1Ptr, (nint) chain.Head.PNext);
Assert.Equal((nint) chain.Item2Ptr, (nint) chain.Item1.PNext);
Assert.Equal((nint) 0, (nint) chain.Item2.PNext);
```

The structures are held in unmanaged memory, preventing movement by the GC, and ensuring that the pointers remain fixed.

You can also specify the generic types directly when initialising a chain with entirely default values, e.g.:

```csharp
using var chain = Chain.Create<
    DeviceCreateInfo, 
    PhysicalDeviceFeatures2, 
    PhysicalDeviceDescriptorIndexingFeatures>();
```

### Modifying values

We can easily modify any value in the `Chain`, and it will maintain the pointers automatically. You do this using
the `Head` property, or one of the `Item[#]` properties (e.g. `Item1`), for example:

```csharp
using var chain = Chain.Create<
    DeviceCreateInfo, 
    PhysicalDeviceFeatures2, 
    PhysicalDeviceDescriptorIndexingFeatures>();

// Ensure all STypes set correctly
Assert.Equal(StructureType.DeviceCreateInfo, chain.Head.SType);
Assert.Equal(StructureType.PhysicalDeviceFeatures2, chain.Item1.SType);
Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, chain.Item2.SType);

// Ensure pointers set correctly
Assert.Equal((nint) chain.Item1Ptr, (nint) chain.Head.PNext);
Assert.Equal((nint) chain.Item2Ptr, (nint) chain.Item1.PNext);
Assert.Equal((nint) 0, (nint) chain.Item2.PNext);

Assert.Equal(0U, chain.Head.Flags);

var headPtr = chain.HeadPtr;

// Get the current head (this is a copy)
var head = chain.Head;
// Update the flags
head.Flags = 1U;
// Update the chain
chain.Head = head;

Assert.Equal(1U, chain.Head.Flags);

// The head ptr should not change, as we overwrite the same memory location with the new value
Assert.Equal((nint) headPtr, (nint) chain.HeadPtr);
// But the next pointer should not change
Assert.Equal((nint) chain.Item1Ptr, (nint) chain.Head.PNext);
```

**Note**: When we update any item in the chain it overwrites the existing memory location, so any `PNext` value pointing
to it is maintained. The supplied value also has its `SType` and `PNext` correctly set before storing. As such,
overwriting any item in the chain is an O(1) operation and very quick as no lookup is required (item positions are
calculated only once per type).

**WARNING**: As the item value returned from a chain is a `struct` (i.e. a value-type like an `int`) modifying it _does
not modify the stored value in the chain_; we have to set the item's value back to the modified value to store it.

### Duplication (Duplicate)

You can efficiently duplicate a managed chain by calling Duplicate on it (this works even when the chain is held as
a `Chain` base class):

```csharp
using var chain = new Chain.Create<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures,
    PhysicalDeviceAccelerationStructureFeaturesKHR>();
using var copy = chain.Duplicate();

// Test equality
Assert.Equal(chain, copy);
Assert.True(chain == copy);
```

**WARNING**: The `Duplicate[Any]` methods return a new instance of a `Chain`, so you must remember
to [dispose](#disposal) the previous instance if no longer used. In the above sample, we correctly use the `using`
statements to do this for us.

**Note**: The `copy` is [equal](#equality) to the `chain` until you modify it's contents, as chains implement
the `IEquatable<T>`
interface, and overload the equality operators (and `GetHasHCode` method). However, both instances point to different
blocks of unmanaged memory, and the `PNext` pointers will therefore be different (and hence are not considered when
comparing chains for equality).

### Loading from an unmanaged chain (Load/LoadAny)

If you have created, or received an unmanaged chain (either by using [structure chaining](structure-chaining.md)
or [raw chaining](raw_chaining.md)) and would like to load that into a `Chain` you can use one of the
`Chain.Load<TChain...>` methods:

```csharp
// Create an unmanaged chain
var indexingFeatures = new PhysicalDeviceDescriptorIndexingFeatures
{
    ShaderInputAttachmentArrayDynamicIndexing = true
};
PhysicalDeviceFeatures2
.Chain(out var unmanagedChain)
.SetNext(ref indexingFeatures)
.AddNext(out PhysicalDeviceAccelerationStructureFeaturesKHR accelerationStructureFeaturesKhr);

// Loads a new managed chain from an unmanaged chain
using var managedChain =
    Chain.Load<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures,
        PhysicalDeviceAccelerationStructureFeaturesKHR>(unmanagedChain);

// Check the flag still set
Assert.True(managedChain.Item1.ShaderInputAttachmentArrayDynamicIndexing);
```

There are also versions of the `Load[Any]` methods that return an output parameter `errors` as their first parameter.
The `errors` parameter will be `string.Empty` if there are no errors, otherwise each line will contain a separate error
for each issue found during loading. There is also an overload that accepts a single argument `chain` for when you don't
care if there are any errors (e.g. in `Debug` builds). As these overloads allocate a `StringBuilder` under the hood,
then they should generally be avoided in production or where performance is more critical.

Either method always succeeds, even if the unmanaged chain doesn't match exactly - for example it is shorter or longer
than the chain being loaded, or if the managed chain has different structure types in any of the positions. Any
structure type in the expected position will always be loaded into the new `Chain`.

```csharp
var indexingFeatures = new PhysicalDeviceDescriptorIndexingFeatures
{
    ShaderInputAttachmentArrayDynamicIndexing = true
};
// Create an unmanaged chain
DeviceCreateInfo
    .Chain(out var unmanagedChain)
    .AddNext(out PhysicalDeviceFeatures2 features2)
    .SetNext(ref indexingFeatures)
    .AddNext(out PhysicalDeviceAccelerationStructureFeaturesKHR accelerationStructureFeaturesKhr);

// Loads a new managed chain from an unmanaged chain
using var managedChain =
    Chain.Load<
        DeviceCreateInfo,
        // Note we are supplied a PhysicalDeviceFeatures2 here from the unmanaged chain
        PhysicalDeviceAccelerationStructureFeaturesKHR,
        PhysicalDeviceDescriptorIndexingFeatures,
        PhysicalDeviceAccelerationStructureFeaturesKHR,
        // Note that the unmanaged chain did not supply a 5th entry
        PhysicalDeviceFeatures2>(out var errors, unmanagedChain);

// Check for errors
Assert.Equal(
@"The unmanaged chain has a structure type PhysicalDeviceFeatures2Khr at position 2; expected PhysicalDeviceAccelerationStructureFeaturesKhr
The unmanaged chain was length 4, expected length 5",
        errors);
        
// Despite the errors indexing features was at the right location so was loaded
Assert.True(managedChain.Item2.ShaderInputAttachmentArrayDynamicIndexing);
```

### Adding to a chain (Add/AddAny)

You can call `Add` on a `Chain` (of length < 16) to efficiently create a new, larger, `Chain` with a new item appended
to the end, e.g:

```csharp
using var chain = Chain.Create<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures>(
    item1: new PhysicalDeviceDescriptorIndexingFeatures {ShaderInputAttachmentArrayDynamicIndexing = true});

// The new chain, will efficiently copy the old chain and append a new structure to the end
using var newChain = chain.Add<PhysicalDeviceAccelerationStructureFeaturesKHR>();
// You will usualy wish to dispose the old chain here, the two chains are now independent of each other.

// Check the flag from the first chain is still set in the new chain.
Assert.True(newChain.Item1.ShaderInputAttachmentArrayDynamicIndexing);        
```

**Note** As a `Chain` holds a block of unmanaged memory, it must be [disposed](#disposal) when it is finished with. When
using the `Add` method you will produce a new `Chain` and should not forget to [dispose](#disposal) the original if it
is no longer needed. The above example uses the `using` statements to do this for us.

Only the `AddAny` method is available from the `Chain` base class as it does not know the concrete `Chain<TChain...>`'s
type. For a similar reason, it will throw an `InvalidOperationException` if the chain is already at the maximum length.

### Truncating (Truncate/TruncateAny)

Similarly, you can `Truncate` a chain (of length > 1) to get an instance of a smaller chain:

```csharp
using var chain = Chain.Create<PhysicalDeviceFeatures2>();
using var chain2 = chain.Add<PhysicalDeviceDescriptorIndexingFeatures>();
// Remove the indexing features we just added (note the out parameter is optional)
using var chain3 = chain2.Truncate(out var indexingFeatures);

Assert.Equal(1, chain.Count);
Assert.Equal(2, chain2.Count);
Assert.Equal(1, chain3.Count);
```

For convenience, there is also a `Truncate` method that does return the tail.

**Note** As a `Chain` holds a block of unmanaged memory, it must be [disposed](#disposal) when it is finished with. When
using the `Add` method you will produce a new `Chain` and should not forget to [dispose](#disposal) the original if it
is no longer needed. The above example uses the `using` statements to do this for us.

Only the `TruncateAny` method is available from the `Chain` base class as it does not know the
concrete `Chain<TChain...>`'s type. For a similar reason, it will throw an `InvalidOperationException` if the chain is
already at the minimum length.

### Deconstruction

Like `Tuple`s, each `Chain<TChain...>` has a
corresponding [deconstructor](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/functional/deconstruct) for
convenience, e.g.:

```csharp
using var chain = new Chain<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures,
    PhysicalDeviceAccelerationStructureFeaturesKHR>();

// Deconstruct
var (physicalDeviceFeatures2, indexingFeatures, accelerationStructureFeaturesKhr) = chain;

// Ensure all STypes set correctly
Assert.Equal(StructureType.PhysicalDeviceFeatures2, physicalDeviceFeatures2.SType);
Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, indexingFeatures.SType);
Assert.Equal(StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr, accelerationStructureFeaturesKhr.SType);
```

## Chain Base Class

The `Chain` base class is `abstract` and cannot be created directly, however, as all Chains descend from it directly, it
can be used to hold and manipulate a chain of indeterminate length, which can be prove very useful. To facilitate that,
all chains implement the following functionality.

### IReadOnlyList

All the fully generic `Chain<TChain...>` types extend `Chain` which implements `IReadOnlyList<IChainable>`. The latter
allowing for easy consumption of any `Chain`, e.g.:

```csharp        
using var chain = new Chain<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures,
    PhysicalDeviceAccelerationStructureFeaturesKHR>();

Assert.Equal(3, chain.Count);

// Ensure all STypes set correctly using indexer
Assert.Equal(StructureType.PhysicalDeviceFeatures2, chain[0].StructureType());
Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, chain[1].StructureType());
Assert.Equal(StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr, chain[2].StructureType());

Assert.Throws<IndexOutOfRangeException>(() => chain[3]);

// Get array using IEnumerable implementation
IChainable[] structures = chain.ToArray();

// Check concrete types
Assert.IsType<PhysicalDeviceFeatures2>(structures[0]);
Assert.IsType<PhysicalDeviceDescriptorIndexingFeatures>(structures[1]);
Assert.IsType<PhysicalDeviceAccelerationStructureFeaturesKHR>(structures[2]);
```

### Clearing (Clear)

The base class also provides a clear method, which will reset all items to their `default` values (except the `SType`
and `PNext` will be maintained correctly as always). The `Clear` method also optionally accepts an `includeHead`
parameter (which defaults to `true`), when `false` this will skip clearing the head. For example:

```csharp
using var chain = Chain.Create
(
    new PhysicalDeviceFeatures2 {Features = new PhysicalDeviceFeatures {AlphaToOne = true}},
    new PhysicalDeviceDescriptorIndexingFeatures {ShaderInputAttachmentArrayDynamicIndexing = true},
    new PhysicalDeviceAccelerationStructureFeaturesKHR {AccelerationStructure = true}
);

Assert.True(chain.Head.Features.AlphaToOne);
Assert.True(chain.Item1.ShaderInputAttachmentArrayDynamicIndexing);
Assert.True(chain.Item2.AccelerationStructure);

// Don't clear the head
chain.Clear(false);

Assert.True(chain.Head.Features.AlphaToOne);
Assert.False(chain.Item1.ShaderInputAttachmentArrayDynamicIndexing);
Assert.False(chain.Item2.AccelerationStructure);

// Clear the head as well this time
chain.Clear();

Assert.False(chain.Head.Features.AlphaToOne);
Assert.False(chain.Item1.ShaderInputAttachmentArrayDynamicIndexing);
Assert.False(chain.Item2.AccelerationStructure);
```

## Performance

Although the `Chain` instances are objects, and therefore held on the heap and subject to garbage collection, they are
very small. Many of the operations are optimised to manipulate memory blocks directly and blit values, as such they
should be suitable for most applications and are well worth using by default until an issue is identified.

In hot paths, you may want to consider to keeping the `Chain` objects cached, and `Clear`ing or overwriting them on each
use. However, you should always consider benchmarking solutions to find the optimal approach for each use case.