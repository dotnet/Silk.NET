# Summary

**_This proposal is dependent
on [Proposal - Vulkan Struct Chaining - #2 Unmanaged Chaining](Proposal%20-%20Vulkan%20Struct%20Chaining%20-%20%232%20Unmanaged%20Chaining.md)
._**

This proposal presents a _managed_ mechanism for safely building, and storing, Vulkan Structure Chains. You may wish to
start with the [previous proposal](Proposal%20-%20Vulkan%20Struct%20Chaining%20-%20%232%20Unmanaged%20Chaining.md),
followed by the [Usage section below](#Usage) to aid understanding. There is also a fully working prototype
[in the labs](../../src/Lab/Experiments/PrototypeStructChaining/PrototypeStructChaining/).

The [previous proposal](Proposal%20-%20Vulkan%20Struct%20Chaining%20-%20%232%20Unmanaged%20Chaining.md) provided a
lightweight mechanism for building structure chains, but the responsibility for ensuring that the provided structures
did not move remained with the consumer. This provided a useful mechanism for reducing bugs (through compile time and
run time validation of `SType` and `PNext`) and making more readable and compact code, whilst not sacrificing
performance.

However, many consumers are uncomfortable with pointers, and are especially prone to introducing bugs when placing
structs onto the heap. This proposal provides a convenient `ManagedChain` class, and multiple
descendent `ManagedChain<TChain, T1...>` classes to safely fix the structures in memory and prevent pointer bugs.

Whenever a structure is loaded into the `ManagedChain` it's `SType` and `PNext` are forced to be correct, preventing
errors. Structures can be replaced at any time, and we be inserted efficiently into the chain as an O(1) operation.

# Contributors

- [Craig Dean, DevDecoder](https://github.com/thargy)

# Current Status

- [x] Proposed
- [ ] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented

# Design Decisions

- There are no requirements to extend `BuildTools`, or add any additional information to the `IChainable` structures.
- Although the `ManagedChain<TChain, T1...>` generic classes are auto-generated (for convenience) this is done using T4
  templating, an implementation of which is
  provided [in the labs](../../src/Lab/Experiments/PrototypeStructChaining/PrototypeStructChaining/ManagedChain.gen.tt).

Open questions:

- Should we expose 8, 16 or 32 `ManagedChain<TChain, T1...>` classes?
- Do we want to stick with `TChain chain, T1 item1`, or use `T1 item1, T2 item2` ala `Tuple`?
- Although the constructors used by `ManagedChain.Create` and `ManagedChain.Load` could be made `internal`, I don't
  propose we do so. Primarily, the main benefit of the static methods is type inference, but, as chain building is
  frequently done with defaults then direct constructor access does not have a disadvantage, and can take advantage of
  implicit typing when assigning to an already typed field/property. Having both forms available is therefore
  convenient.
- Currently `ManagedChain<TChain, T1>` is the smallest chain, there is a strong case to be made for
  a `ManagedChain<TChain>`.
- The current `Load` methods expect an unmanaged chain that matches the supplied type constraints, and is of the same
  length. This is useful, as coders will normally expect a particular chain. We could additionally add more lax `Import`
  methods that will import an unmanaged chain into a managed chain by populating any positions with structure types
  found in the unmanaged chain, no matter at what position they are found. This is not entirely unreasonable as the
  order of chains (after the start) is not fixed in Vulkan, and it will allow importing existing chains where the order
  doesn't matter.
- Similar to `Append` do we want a `Truncate` method to trim the end of a chain?
- Similar to `Append` and `Truncate` we could also add `Insert` and `Remove` methods, however this is more complex, as
  we'd have to generate multiples of each, for example:

```csharp
pubilc class ManagedCache<TChain, T1, T2> ... {
    // There would <length> of these methods (not too bad to be fair, the worst case would be maxsize -1 as we
    // wouldn't add these methods to the largest possible ManagedCache)
    public ManagedCache<TNew, TChain, T1, T2> InsertBeforeHead<TNew>(TChain newHead) {...}
    public ManagedCache<TChain, TNew, T1, T2> InsertBeforeItem1<TNew>(TNew newValue) {...}
    public ManagedCache<TChain, T1, TNew, T2> InsertBeforeItem2<TNew>(TNew newValue) {...}
    
    // There would be size-2 of these methods (so wouldn't exist on `ManagedCache<TChain, T1>`)
    public ManagedCache<TChain, T2> RemoveItem1(out T1 removedValue) {...}
    
    // This is pretty trivial to add (also wouldn't exist on `ManagedCache<TChain>`)
    public ManagedCache<TChain, T1> Truncate(out T2 removedValue) {...}
} 
```

# Usage

### Creation

For example:

```csharp
using var chain = new ManagedChain<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures,
    PhysicalDeviceAccelerationStructureFeaturesKHR>();

// Ensure all STypes set correctly
Assert.Equal(StructureType.PhysicalDeviceFeatures2, chain.Head.SType);
Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, chain.Item1.SType);
Assert.Equal(StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr, chain.Item2.SType);

// Ensure pointers set correctly
Assert.Equal((nint) chain.Item1Ptr, (nint) chain.Head.PNext);
Assert.Equal((nint) chain.Item2Ptr, (nint) chain.Item1.PNext);
Assert.Equal((nint) 0, (nint) chain.Item2.PNext);
```

The structures are held in unmanaged memory, preventing movement by the GC, and ensuring that the ptrs remain fixed.

You can also use the `ManagedChain.Create(...)` static methods to create `ManagedChain`s.

### Modifying values

We can easily modify any value in the `ManagedChain`, and it will maintain the ptrs automatically, e.g.:

```csharp
using var chain = new ManagedChain<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures,
    PhysicalDeviceAccelerationStructureFeaturesKHR>(item1: new PhysicalDeviceDescriptorIndexingFeatures
{
    // We can set any non-default values, note we do not need to set SType or PNext
    // indeed they will be overwritten.
    ShaderInputAttachmentArrayDynamicIndexing = true
});

// Ensure all STypes set correctly
Assert.Equal(StructureType.PhysicalDeviceFeatures2, chain.Head.SType);
Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, chain.Item1.SType);
Assert.Equal(StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr, chain.Item2.SType);

// Ensure pointers set correctly
Assert.Equal((nint) chain.Item1Ptr, (nint) chain.Head.PNext);
Assert.Equal((nint) chain.Item2Ptr, (nint) chain.Item1.PNext);
Assert.Equal((nint) 0, (nint) chain.Item2.PNext);

// Check our value was set
Assert.True(chain.Item1.ShaderInputAttachmentArrayDynamicIndexing);

var item1Ptr = chain.Item1Ptr;

// Overwrite Item1
chain.Item1 = new PhysicalDeviceDescriptorIndexingFeatures
{
    // Again we do not need to set SType or PNext, which will be set to the correct values
    ShaderInputAttachmentArrayDynamicIndexing = false
};

// Check our value was cleared
Assert.False(chain.Item1.ShaderInputAttachmentArrayDynamicIndexing);

// Note all the pointers are still correct (and have not changed)
Assert.Equal((nint) chain.Item1Ptr, (nint) chain.Head.PNext);
Assert.Equal((nint) chain.Item2Ptr, (nint) chain.Item1.PNext);
Assert.Equal((nint) 0, (nint) chain.Item2.PNext);

// As is the SType
Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, chain.Item1.SType);
```

**Note** When we update any item in the chain it overwrites the existing memory, so the ptrs remain fixed. It also
ensures the PNext value is maintained.

### Appending to a chain

You can call `Append` on a `ManagedChain` to efficiently create a new, larger, `ManagedChain` with a new item appended
to the end, e.g:

```csharp
using var chain = new ManagedChain<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures>(
    item1: new PhysicalDeviceDescriptorIndexingFeatures {ShaderInputAttachmentArrayDynamicIndexing = true});

// The new chain, will efficiently copy the old chain and append a new structure to the end
using var newChain = chain.Append<PhysicalDeviceAccelerationStructureFeaturesKHR>();
// You will usualy wish to dispose the old chain here, the two chains are now independent of each other.

// Check the flag from the first chain is still set in the new chain.
Assert.True(newChain.Item1.ShaderInputAttachmentArrayDynamicIndexing);        
```

### Loading from an unmanaged chain

If you have created an unmanaged chain and would like to load that into a `ManagedChain` you can use one of the
`ManagedChain.Load<TChain, T1...>` methods:

```csharp
// Load an unmanaged chain
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
    ManagedChain.Load<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures,
        PhysicalDeviceAccelerationStructureFeaturesKHR>(unmanagedChain, out var errors);

// Check we had no loading errors
Assert.Equal("", errors);

// Check the flag still set
Assert.True(managedChain.Item1.ShaderInputAttachmentArrayDynamicIndexing);
```

The full version of the `Load` method returns an output parameter `errors` as it's first parameter. The `errors`
parameter will be `string.Empty` if there are no errors, otherwise each line will contain a separate error for each
issue found during loading. There is also an overload that accepts a single argument `chain` for when you don't care if
there are any errors. Either method always succeeds, even if the unmanaged chain doesn't match exactly - for example it
is shorter or longer than the chain being loaded, or if the managed chain has different structure types in any of the
positions. Any structure type in the expected position will always be loaded into the new `ManagedChain`.

```csharp
var indexingFeatures = new PhysicalDeviceDescriptorIndexingFeatures
{
    ShaderInputAttachmentArrayDynamicIndexing = true
};
// Load an unmanaged chain
DeviceCreateInfo
    .Chain(out var unmanagedChain)
    .AddNext(out PhysicalDeviceFeatures2 features2)
    .SetNext(ref indexingFeatures)
    .AddNext(out PhysicalDeviceAccelerationStructureFeaturesKHR accelerationStructureFeaturesKhr);

// Loads a new managed chain from an unmanaged chain
using var managedChain =
    new ManagedChain<
        DeviceCreateInfo,
        // Note we are supplied a PhysicalDeviceFeatures2 here from the unmanaged chain
        PhysicalDeviceAccelerationStructureFeaturesKHR,
        PhysicalDeviceDescriptorIndexingFeatures,
        PhysicalDeviceAccelerationStructureFeaturesKHR,
        // Note that the unmanaged chain did not supply a 5th entry
        PhysicalDeviceFeatures2>(unmanagedChain, out var errors);

// Check for errors
Assert.Equal(
@"The unmanaged chain has a structure type PhysicalDeviceFeatures2Khr at position 2; expected PhysicalDeviceAccelerationStructureFeaturesKhr
The unmanaged chain was length 4, expected length 5",
        errors);
        
// Despite the errors indexing features was at the right location so was loaded
Assert.True(managedChain.Item2.ShaderInputAttachmentArrayDynamicIndexing);
```

Notice that the above form use the constructor as an alternative.

### IReadOnlyList

All the fully generic `ManageChain<TChain, T1 ...>` types extend `ManagedChain` which implements `IDisposable`
and `IReadOnlyList<IChainable>`. The latter allowing for easy consumption of any `ManagedChain`, e.g.:

```csharp        
using var chain = new ManagedChain<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures,
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

### Deconstruction

Each `ManageChain<TChain, T1 ...>` has a corresponding deconstructor for convenience, e.g.:

```csharp
using var chain = new ManagedChain<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures,
    PhysicalDeviceAccelerationStructureFeaturesKHR>();

var (physicalDeviceFeatures2, indexingFeatures, accelerationStructureFeaturesKhr) = chain;

// Ensure all STypes set correctly
Assert.Equal(StructureType.PhysicalDeviceFeatures2, physicalDeviceFeatures2.SType);
Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, indexingFeatures.SType);
Assert.Equal(StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr, accelerationStructureFeaturesKhr.SType);
```

### Disposal

As each `ManagedChain` holds the underlying structures in unmanaged memory (to prevent them being moved and their
pointers being invalidated), then it is critical you dispose them; either by calling `Dispose()` or by using a `using`
statement.

# Proposed API

TODO