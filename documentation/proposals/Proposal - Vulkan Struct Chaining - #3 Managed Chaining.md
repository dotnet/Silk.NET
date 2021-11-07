# Summary

**_This proposal is dependent
on [Proposal - Vulkan Struct Chaining - #2 Unmanaged Chaining](Proposal%20-%20Vulkan%20Struct%20Chaining%20-%20%232%20Unmanaged%20Chaining.md)
._**

This proposal presents a _managed_ mechanism for safely building, and storing, Vulkan Structure Chains. You may wish to
start with the [previous proposal](Proposal%20-%20Vulkan%20Struct%20Chaining%20-%20%232%20Unmanaged%20Chaining.md),
followed by the [Usage section below](#Usage) to aid understanding. There is also a fully working prototype
[in the labs](../../src/Lab/Experiments/PrototypeStructChaining/PrototypeStructChaining).

The [previous proposal](Proposal%20-%20Vulkan%20Struct%20Chaining%20-%20%232%20Unmanaged%20Chaining.md) provided a
lightweight mechanism for building structure chains, but the responsibility for ensuring that the provided structures
did not move remained with the consumer. This provided a useful mechanism for reducing bugs (through compile time and
run time validation of `SType` and `PNext`) and making more readable and compact code, whilst not sacrificing
performance.

However, many consumers are uncomfortable with pointers, and are especially prone to introducing bugs when placing
structs onto the heap. This proposal provides a convenient `ManagedChain` class, and multiple
descendent `ManagedChain<TChain...>` classes to safely fix the structures in memory and prevent pointer bugs.

Whenever a structure is loaded into the `ManagedChain` its `SType` and `PNext` are forced to be correct, preventing
errors. Structures can be replaced at any time, and will be inserted efficiently into the chain as an O(1) operation.

# Contributors

- [Craig Dean, DevDecoder](https://github.com/thargy)

# Current Status

- [x] Proposed
- [ ] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented

# Design Decisions

- There are no requirements to extend `BuildTools`, or add any additional information to the `IChainable` structures.
- Although the `ManagedChain<TChain...>` generic classes are auto-generated (for convenience) this is done using T4
  templating, an implementation of which is
  provided [in the labs](../../src/Lab/Experiments/PrototypeStructChaining/PrototypeStructChaining/ManagedChain.gen.tt).
- For improved performance, the chain's structures are held in a single block of contiguous unmanaged memory, as the
  memory is unmanaged, the position of the structures remains fixed, even though the containing object can be safely
  moved around by the GC in the heap. Indeed a pointer to this block is the only data stored by an instance of any
  `ManageChain<TChain...>` object, despite all the functionality provided!
- The structure accessors return a copy of the structures, and always correct the `SType` and `PNext` on input. Even
  though the `PNext` values are exposed there is no way to modify them from outside the class, guaranteeing their
  safety.

Open questions:

- Should we expose 8, 16 or 32 `ManagedChain<TChain...>` classes?
- Do we want to stick with `TChain chain, T1 item1`, or use `T1 item1, T2 item2` ala `Tuple`?
- Although the constructors used by `ManagedChain.Create` and `ManagedChain.Load` could be made `internal`, I don't
  propose we do so. Primarily, the main benefit of the static methods is type inference, but, as chain building is
  frequently done with defaults then direct constructor access does not have a disadvantage, and can take advantage of
  implicit typing when assigning to an already typed field/property. Having both forms available is therefore
  convenient.
- The current `Load` methods expect an unmanaged chain that matches the supplied type constraints, and is of the same
  length. This is useful, as coders will normally expect a particular chain. We could additionally add more lax `Import`
  methods that will import an unmanaged chain into a managed chain by populating any positions with structure types
  found in the unmanaged chain, no matter at what position they are found. This is not entirely unreasonable as the
  order of chains (after the start) is not fixed in Vulkan, and it will allow importing existing chains where the order
  doesn't matter.
- Similar to `Append` and `Truncate` we could also add `Insert` and `Remove` methods, though slightly more complex, as
  we'd have to generate multiples of each, it is not difficult to do, for example:

```csharp
pubilc class ManagedCache<TChain, T1, T2> ... {
    ...
    
    // There would be <length> of these methods (not too bad to be fair, the worst case would be maxsize -1 as we
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

The following will create a chain starting with `PhysicalDeviceFeatures2`, pointing
to `PhysicalDeviceDescriptorIndexingFeatures` and finishing with a `PhysicalDeviceAccelerationStructureFeaturesKHR`
structure:

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

The structures are held in unmanaged memory, preventing movement by the GC, and ensuring that the pointers remain fixed.

You can also use the `ManagedChain.Create(...)` static methods to create `ManagedChain`s, e.g.:

```csharp
using var chain = ManagedChain.Create<
    DeviceCreateInfo, 
    PhysicalDeviceFeatures2, 
    PhysicalDeviceDescriptorIndexingFeatures>();
```

or, using generic type inference:

```csharp
using var chain = ManagedChain.Create(
    new DeviceCreateInfo { Flags = 1U },
    default(PhysicalDeviceFeatures2),
    default(PhysicalDeviceDescriptorIndexingFeatures)
);
```

### Modifying values

We can easily modify any value in the `ManagedChain`, and it will maintain the pointers automatically, e.g.:

```csharp
using var chain = ManagedChain.Create<
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

**Note** When we update any item in the chain it overwrites the existing memory, so the pointers remain fixed. It also
ensures the `PNext` value pointing to it is maintained.

### Appending to a chain

You can call `Append` on a `ManagedChain` (of length < 16) to efficiently create a new, larger, `ManagedChain` with a
new item appended to the end, e.g:

```csharp
using var chain = new ManagedChain<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures>(
    item1: new PhysicalDeviceDescriptorIndexingFeatures {ShaderInputAttachmentArrayDynamicIndexing = true});

// The new chain, will efficiently copy the old chain and append a new structure to the end
using var newChain = chain.Append<PhysicalDeviceAccelerationStructureFeaturesKHR>();
// You will usualy wish to dispose the old chain here, the two chains are now independent of each other.

// Check the flag from the first chain is still set in the new chain.
Assert.True(newChain.Item1.ShaderInputAttachmentArrayDynamicIndexing);        
```

**Note** As a `ManagedChain` holds a block of unmanaged memory, it must be [disposed manually](#disposal) when it is
finished with, when using the `Append` method you will produce a new `ManagedChain` and should not forget to dispose the
original if it is no longer needed.

### Truncate

Similarly, you can `Truncate` a chain (of length > 1) to get an instance of a smaller chain:
```csharp
using var chain = ManagedChain.Create<PhysicalDeviceFeatures2>();
using var chain2 = chain.Append<PhysicalDeviceDescriptorIndexingFeatures>();
// Remove the indexing features we just added (note the out parameter is optional)
using var chain3 = chain2.Truncate(out var indexingFeatures);

Assert.Equal(1, chain.Count);
Assert.Equal(2, chain2.Count);
Assert.Equal(1, chain3.Count);
```

### Duplicate

You can efficiently duplicate a managed chain by calling Duplicate on it:
```csharp
using var chain = new ManagedChain<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures,
    PhysicalDeviceAccelerationStructureFeaturesKHR>();
using var copy = chain.Duplicate();
```

### Loading from an unmanaged chain

If you have created an unmanaged chain and would like to load that into a `ManagedChain` you can use one of the
`ManagedChain.Load<TChain...>` methods:

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
        PhysicalDeviceAccelerationStructureFeaturesKHR>(out var errors, unmanagedChain);

// Check we had no loading errors
Assert.Equal(string.Empty, errors);

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
        PhysicalDeviceFeatures2>(out var errors, unmanagedChain );

// Check for errors
Assert.Equal(
@"The unmanaged chain has a structure type PhysicalDeviceFeatures2Khr at position 2; expected PhysicalDeviceAccelerationStructureFeaturesKhr
The unmanaged chain was length 4, expected length 5",
        errors);
        
// Despite the errors indexing features was at the right location so was loaded
Assert.True(managedChain.Item2.ShaderInputAttachmentArrayDynamicIndexing);
```

Notice that the above form uses the equivalent constructor as an alternative to the `Load` method. There is no
equivalent constructor to `Load(TChain)` as that would be ambiguous.

### IReadOnlyList

All the fully generic `ManageChain<TChain...>` types extend `ManagedChain` which implements `IDisposable`
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

Each `ManageChain<TChain...>` has a corresponding deconstructor for convenience, e.g.:

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

## Abstract base class

The `ManagedChain`, non-generic abstract base class provides an abstract implementation of `IReadOnlyList<IChainable>`,
and defines static `Create` and `Load` methods for each size of chain.

```csharp
public abstract class ManagedChain : IReadOnlyList<IChainable>, IDisposable
{
    /// <inheritdoc />
    public abstract IEnumerator<IChainable> GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <inheritdoc />
    public abstract int Count { get; }
    
    /// <inheritdoc />
    public abstract IChainable this[int index] { get; }

    /// <inheritdoc />
    public abstract void Dispose();

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <returns>A new <see cref="ManagedChain{TChain, T1}"/> with 2 items.</returns>
    public static ManagedChain<TChain, T1> Create<TChain, T1>(TChain head = default, T1 item1 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
    {
        return new(head, item1);
    }

    /// <summary>
    /// Loads a new <see cref="ManagedChain{TChain, T1}"/> with 2 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="ManagedChain{TChain, T1}"/> with 2 items.</returns>
    public static ManagedChain<TChain, T1> Load<TChain, T1>(out string errors, TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
    {
        return new(out errors, chain);
    }
    
    // Only showing one example of Create/Load methods
    ...
}
```

## Concrete generic classes

A class is generated for each valid size of a chain, here is one example:

```csharp

/// <summary>
/// A <see cref="ManagedChain{TChain, T1}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
public unsafe class ManagedChain<TChain, T1> : ManagedChain
    where TChain : struct, IChainStart
    where T1 : struct, IExtendsChain<TChain>
{
    /// <summary>
    /// Gets the size (in bytes) of the head structure.
    /// </summary>
    public static readonly int HeadSize = Marshal.SizeOf<TChain>();

    /// <summary>
    /// Gets the offset to the start of <see cref="Item1"/>.
    /// </summary>
    public static readonly int Item1Offset = HeadSize;

    /// <summary>
    /// Gets the size (in bytes) of the Item 1.
    /// </summary>
    public static readonly int Item1Size = Marshal.SizeOf<T1>();

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public static readonly int MemorySize = Item1Offset + Item1Size;
    
    private nint _headPtr;

    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public Chain* HeadPtr => (Chain*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((Chain*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (Chain*) _headPtr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public Chain* Item1Ptr => (Chain*) (_headPtr + Item1Offset);

    /// <summary>
    /// Gets or sets item #1 in the chain.
    /// </summary>
    public T1 Item1
    {
        get => Unsafe.AsRef<T1>(Item1Ptr);
        set
        {
            value.StructureType();
            var ptr = Item1Ptr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, (nint)ptr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain..</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal ManagedChain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    public ManagedChain(TChain head = default, T1 item1 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        Chain* itemPtr = Item1Ptr;
        item1.StructureType();
        Marshal.StructureToPtr(item1, (nint)itemPtr, false);
        HeadPtr->PNext = itemPtr;
        Item1Ptr->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    public ManagedChain(out string errors, TChain chain)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        chain.StructureType();
        Marshal.StructureToPtr(chain, _headPtr, false);
        StringBuilder errorBuilder = new StringBuilder();
        var existingPtr = (Chain*) Unsafe.AsPointer(ref chain);
        var newPtr = (Chain*) _headPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (Chain*) (_headPtr + Item1Offset);
        newPtr = newPtr->PNext;

        T1 item1 = default;
        var expectedStructureType = item1.StructureType();
        if (existingPtr is null) {
            errorBuilder.AppendLine("The unmanaged chain was length 1, expected length 2");
        } else {
            if (existingPtr->SType != expectedStructureType) {
                errorBuilder.Append("The unmanaged chain has a structure type ")
                    .Append(existingPtr->SType)
                    .Append(" at position 2; expected ")
                    .Append(expectedStructureType)
                    .AppendLine();
            } else {
                if (existingPtr->PNext is not null) {
                    errorBuilder.AppendLine("The unmanaged chain was longer than the expected length 2");
                    existingPtr->PNext = null;
                }
                item1 = Unsafe.AsRef<T1>(existingPtr);
            }
        }
        Marshal.StructureToPtr(item1, (nint) newPtr, false);

        // Create string of errors
        errors = errorBuilder.ToString().Trim();
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 by copying this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1> Duplicate() 
    {
        var newHeadPtr = Marshal.AllocHGlobal(MemorySize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, MemorySize, MemorySize);
        // Update all pointers
        ((Chain*)newHeadPtr)->PNext = (Chain*) (newHeadPtr + Item1Offset); 
        return new ManagedChain<TChain, T1>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1}"/> with 2 items, by appending 
    /// <paramref name="item1"/> to the end of this chain.
    /// </summary>
    /// <param name="previous">The chain to append to.</param>
    /// <param name="item1">Item 1.</param>
    /// <remarks>
    /// Do not forget to dispose the <paramref name="previous"/> chain if you are no longer using it.
    /// </remarks>
    public ManagedChain(ManagedChain<TChain> previous, T1 item1 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        var previousSize = MemorySize - Item1Size;
        // Block copy original struct data for speed
        Buffer.MemoryCopy(previous.HeadPtr, (void*)_headPtr, previousSize, previousSize);
        
        // Append item 1
        item1.StructureType();        
        Marshal.StructureToPtr(item1, _headPtr + previousSize, false);

        // Update all pointers
        ((Chain*)_headPtr)->PNext = (Chain*) (_headPtr + Item1Offset);
        ((Chain*)(_headPtr + previousSize))->PNext = null;
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain}"/> with 1 items, by removing the last item
    /// from this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain> Truncate()
    {
        return Truncate(out var _);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain}"/> with 1 items, by removing 
    /// <paramref name="item1"/> from the end of this chain.
    /// </summary>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain> Truncate(out T1 item1)
    {
        item1 = Item1;

        var newSize = MemorySize - Item1Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        Buffer.MemoryCopy((void*)_headPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((Chain*)newHeadPtr)->PNext = null;
        return new ManagedChain<TChain>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="ManagedChain{TChain, T1, T2}"/> with 3 items, by appending <paramref name="item2"/> to
    /// the end of this chain.
    /// </summary>
    /// <param name="item2">Item 2.</param>
    /// <typeparam name="T2">Type of Item 2</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    public ManagedChain<TChain, T1, T2> Append<T2>(T2 item2 = default)
        where T2: struct, IExtendsChain<TChain>
    {
        return new ManagedChain<TChain, T1, T2>(this, item2);
    }

    /// <inheritdoc />
    public override IEnumerator<IChainable> GetEnumerator()
    {
        yield return Head;
        yield return Item1;
    }

    /// <inheritdoc />
    public override int Count => 2;

    /// <inheritdoc />
    public override IChainable this[int index]
        => index switch 
        {
            0 => Head,
            1 => Item1,
            _ => throw new IndexOutOfRangeException()
        };

    /// <summary>
    /// Deconstructs this chain.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    public void Deconstruct(out TChain head, out T1 item1)
    {
            head = Head;
            item1 = Item1;
    }  

    /// <inheritdoc />
    public override void Dispose()
    {
        var headPtr = Interlocked.Exchange(ref _headPtr, (nint)0);
        if (headPtr == (nint)0) { 
            return;
        }

        // Destroy all structures
        Marshal.DestroyStructure<TChain>(headPtr);
        Marshal.DestroyStructure<T1>(headPtr + Item1Offset);

        // Free memory block
        Marshal.FreeHGlobal(headPtr);
    }
}
```