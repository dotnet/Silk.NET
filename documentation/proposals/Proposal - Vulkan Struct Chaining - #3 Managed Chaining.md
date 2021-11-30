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
structs onto the heap. This proposal provides a convenient `Chain` class, and multiple
descendent `Chain<TChain...>` (similar to the `System.Tuple<T1..>` classes) classes to safely fix the structures
in memory and prevent pointer bugs.

Whenever a structure is loaded into the `Chain` its `SType` and `PNext` are forced to be correct, preventing
errors. Structures can be replaced at any time, and will be inserted efficiently into the chain as an O(1) operation.

# Contributors

- [Craig Dean, DevDecoder](https://github.com/thargy)

# Current Status

- [x] Proposed
- [x] Discussed with API Review Board (ARB)
- [x] Approved
- [x] Implemented

# Design Decisions

- There are no requirements to extend `BuildTools`, or add any additional information to the `IChainable` structures.
- Although the `Chain<TChain...>` generic classes are auto-generated (for convenience) this is done using T4
  templating, an implementation of which is
  provided [in the labs](../../src/Lab/Experiments/PrototypeStructChaining/PrototypeStructChaining/Chain.gen.tt).
- For improved performance, the chain's structures are held in a single block of contiguous unmanaged memory, as the
  memory is unmanaged, the position of the structures remains fixed, even though the containing object can be safely
  moved around by the GC in the heap. Indeed a pointer to this block is the only data stored by an instance of any
  `ManageChain<TChain...>` object, despite all the functionality provided!
- The structure accessors return a copy of the structures, and always correct the `SType` and `PNext` on input. Even
  though the `PNext` values are exposed there is no way to modify them from outside the class, guaranteeing their
  safety.
- The managed chains implement `IEquatable<T>`, allowing two chains with identical content to be efficiently compared (
  ignoring the `PNext` pointers, but already being confident the `SType` and ordering is correct). They also implement
  the equality operator overloads, and `GetHashCode`.

Open questions:

- Should we expose 8, 16 or 32 `Chain<TChain...>` classes?
- Do we want to stick with `TChain chain, T1 item1`, or use `T1 item1, T2 item2` ala `Tuple`?
- Although the constructors used by `Chain.Create` and `Chain.Load` could be made `internal`, I don't
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
- `GetHasCode` current hashes the entire struct's data, except the `PNext` fields. However, a hashcode only needs to
  create reasonable separation so a 'sampling' method could be used for increased performance.
- Similar to `Add` and `Truncate` we could also add `Insert` and `Remove` methods, though slightly more complex, as
  we'd have to generate multiples of each, it is not difficult to do, for example:

```csharp
pubilc class Chain<TChain, T1, T2> ... {
    ...
    
    // There would be <length> of these methods (not too bad to be fair, the worst case would be maxsize -1 as we
    // wouldn't add these methods to the largest possible Chain)
    public Chain<TNew, TChain, T1, T2> InsertBeforeHead<TNew>(TChain newHead) {...}
    public Chain<TChain, TNew, T1, T2> InsertBeforeItem1<TNew>(TNew newValue) {...}
    public Chain<TChain, T1, TNew, T2> InsertBeforeItem2<TNew>(TNew newValue) {...}
    
    // There would be size-2 of these methods (so wouldn't exist on `Chain<TChain, T1>`)
    public Chain<TChain, T2> RemoveItem1(out T1 removedValue) {...}
    
    // This is pretty trivial to add (also wouldn't exist on `Chain<TChain>`)
    public Chain<TChain, T1> Truncate(out T2 removedValue) {...}
} 
```

# Usage

## The Any versions

As with unmanaged chains, the managed chains system includes `Any` versions of all methods. In fact,
the `Chain<THead...>` constraints are 'loose', that is they only require types to be `IChainable` rather than
requiring the stricter constraints that prevent unrelated chain elements being added, or used as the start of a chain.

With the exception of the setters on chain items, you cannot manipulate a chain save through the static methods, and the
preferred versions do include the tighter constraints.

## Instance-Based Methods

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

You can also use specify the generic types directly, e.g.:

```csharp
using var chain = Chain.Create<
    DeviceCreateInfo, 
    PhysicalDeviceFeatures2, 
    PhysicalDeviceDescriptorIndexingFeatures>();
```

### Modifying values (Head/Item# properties)

We can easily modify any value in the `Chain`, and it will maintain the pointers automatically. You do this using
the `Head` property, or one of the `Item#` properties (e.g. `Item1`), for example:

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

**Note** When we update any item in the chain it overwrites the existing memory, so the pointers remain fixed. It also
ensures the `PNext` value pointing to it is maintained.

## Extension Methods

### Adding to a chain (Add/AddAny)

You can call `Add` on a `Chain` (of length < 16) to efficiently create a new, larger, `Chain` with a
new item appended to the end, e.g:

```csharp
using var chain = Chain.Create<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures>(
    item1: new PhysicalDeviceDescriptorIndexingFeatures {ShaderInputAttachmentArrayDynamicIndexing = true});

// The new chain, will efficiently copy the old chain and append a new structure to the end
using var newChain = chain.Add<PhysicalDeviceAccelerationStructureFeaturesKHR>();
// You will usualy wish to dispose the old chain here, the two chains are now independent of each other.

// Check the flag from the first chain is still set in the new chain.
Assert.True(newChain.Item1.ShaderInputAttachmentArrayDynamicIndexing);        
```

**Note** As a `Chain` holds a block of unmanaged memory, it must be [disposed manually](#disposal) when it is
finished with, when using the `Add` method you will produce a new `Chain` and should not forget to dispose the
original if it is no longer needed.

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

### Duplication (Duplicate/DuplicateAny)

You can efficiently duplicate a managed chain by calling Duplicate on it:

```csharp
using var chain = new Chain.Create<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures,
    PhysicalDeviceAccelerationStructureFeaturesKHR>();
using var copy = chain.Duplicate();

// Test equality
Assert.Equal(chain, copy);
Assert.True(chain == copy);
```

**Note** The `copy` is 'equal' to the `chain` until you modify it's contents.

### Loading from an unmanaged chain (Load/LoadAny)

If you have created an unmanaged chain and would like to load that into a `Chain` you can use one of the
`Chain.Load<TChain...>` methods:

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
    Chain.Load<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures,
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
positions. Any structure type in the expected position will always be loaded into the new `Chain`.

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
    new Chain<
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

## Additional interfaces

### IReadOnlyList

All the fully generic `ManageChain<TChain...>` types extend `Chain` which implements `IDisposable`
and `IReadOnlyList<IChainable>`. The latter allowing for easy consumption of any `Chain`, e.g.:

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

### Equality (IEquatable&lt;T&gt;)

ll the fully generic `ManageChain<TChain...>` types implement the corresponding `IEquatable<Chain<TChain...>>`
interface, and equality operators. As well as `GetHashCode`.

### Deconstruction

Each `ManageChain<TChain...>` has a corresponding deconstructor for convenience, e.g.:

```csharp
using var chain = new Chain<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures,
    PhysicalDeviceAccelerationStructureFeaturesKHR>();

var (physicalDeviceFeatures2, indexingFeatures, accelerationStructureFeaturesKhr) = chain;

// Ensure all STypes set correctly
Assert.Equal(StructureType.PhysicalDeviceFeatures2, physicalDeviceFeatures2.SType);
Assert.Equal(StructureType.PhysicalDeviceDescriptorIndexingFeatures, indexingFeatures.SType);
Assert.Equal(StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr, accelerationStructureFeaturesKhr.SType);
```

### Disposal (IDisposable)

As each `Chain` holds the underlying structures in unmanaged memory (to prevent them being moved and their
pointers being invalidated), then it is critical you dispose them; either by calling `Dispose()` or by using a `using`
statement.

# Proposed API

## Abstract base class

The `Chain`, non-generic abstract base class provides an abstract implementation of `IReadOnlyList<IChainable>`,
and defines static `Create` and `Load` methods for each size of chain.

```csharp

/// <summary>
/// Base class for all <see cref="Chain{T}">Managed Chains</see>.
/// </summary>
public abstract unsafe class Chain : IReadOnlyList<IChainable>, IDisposable
{
    /// <summary>
    /// Gets a pointer to the current head.
    /// </summary>
    public abstract BaseInStructure* HeadPtr { get; }

    /// <summary>
    /// Gets the total size (in bytes) of the unmanaged memory, managed by this chain.
    /// </summary>
    public abstract int Size { get; }

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public override bool Equals(object obj)
    {
        return !ReferenceEquals(null, obj) && 
               (ReferenceEquals(this, obj) || obj.GetType() == this.GetType() && MemoryEquals((Chain) obj));
    }

    /// <summary>
    /// Compares the supplied memory block with this one.
    /// </summary>  
    protected abstract bool MemoryEquals(Chain other);

    /// <inheritdoc />
    public abstract void Dispose();

    /// <summary>
    /// Combines a hashcode with the first part of a slice.
    /// </summary>
    /// <param name="hashCode"></param>
    /// <param name="slice"></param>
    /// <returns></returns>
    protected static void CombineHash(ref int hashCode, ReadOnlySpan<byte> slice) =>
        hashCode = slice.Length switch
        {
            < 2 => HashCode.Combine(hashCode, slice[0]),
            < 4 => HashCode.Combine(hashCode, MemoryMarshal.Cast<byte, ushort>(slice)[0]),
            < 8 => HashCode.Combine(hashCode, MemoryMarshal.Cast<byte, uint>(slice)[0]),
            _ => HashCode.Combine(hashCode, MemoryMarshal.Cast<byte, ulong>(slice)[0])
        };

    // Skipping methods for `Chain{TChain}` to show more completed example
    ...

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
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        => new(head, item1);

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
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        => new(head, item1);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1}"/> with 2 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1}"/> with 2 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1> Load<TChain, T1>(TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        => LoadAny<TChain, T1>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1}"/> with 2 items from an existing unmanaged chain,
    /// ignoring any errors.
    /// </summary>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1}"/> with 2 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1}(TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1> LoadAny<TChain, T1>(TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        => LoadAny<TChain, T1>(out var _, chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1}"/> with 2 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1}"/> with 2 items.</returns>
    /// <seealso cref="LoadAny{TChain, T1}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1> Load<TChain, T1>(out string errors, TChain chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        => LoadAny<TChain, T1>(out errors, chain);

    /// <summary>
    /// Loads a new <see cref="Chain{TChain, T1}"/> with 2 items from an existing unmanaged chain.
    /// </summary>
    /// <param name="errors">Any errors loading the chain.</param>
    /// <param name="chain">The unmanaged chain to use as the basis of this chain.</param>
    /// <returns>A new <see cref="Chain{TChain, T1}"/> with 2 items.</returns>
    /// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para></remarks>
    /// <seealso cref="Load{TChain, T1}(out string, TChain)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1> LoadAny<TChain, T1>(out string errors, TChain chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
    {
        var size = Chain<TChain, T1>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        chain.StructureType();
        Marshal.StructureToPtr(chain, newHeadPtr, false);
        var errorBuilder = new StringBuilder();
        var existingPtr = (BaseInStructure*) Unsafe.AsPointer(ref chain);
        var newPtr = (BaseInStructure*) newHeadPtr;

        existingPtr = existingPtr->PNext;
        newPtr->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1>.Item1Offset);
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
        return new Chain<TChain, T1>(newHeadPtr);
    }
    
    // Only showing one example of Create/Load methods
    ...
}
```

## Concrete generic classes

A class is generated for each valid size of a chain, here is one example:

```csharp
/// <summary>
/// A <see cref="Chain{TChain, T1}"/> safely manages the pointers of a managed structure chain.
/// </summary>
/// <typeparam name="TChain">The chain type</typeparam>
/// <typeparam name="T1">Type of Item 1.</typeparam>
public unsafe sealed class Chain<TChain, T1> : Chain, IEquatable<Chain<TChain, T1>>
    where TChain : struct, IChainable
    where T1 : struct, IChainable
{
    /// <summary>
    /// Gets the size (in bytes) of the default structure header.
    /// </summary>
    public static readonly int HeaderSize = Marshal.SizeOf<BaseInStructure>();

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
        
    /// <inheritdoc/>
    public override int Size => MemorySize;

    private nint _headPtr;

    /// <inheritdoc/>
    public override BaseInStructure* HeadPtr => (BaseInStructure*) _headPtr;

    /// <summary>
    /// Gets or sets the head of the chain.
    /// </summary>
    public TChain Head
    {
        get => Unsafe.AsRef<TChain>((BaseInStructure*) _headPtr);
        set
        {
            value.StructureType();
            var ptr = (BaseInStructure*) _headPtr;
            var nextPtr = ptr->PNext;
            Marshal.StructureToPtr(value, _headPtr, true);
            ptr->PNext = nextPtr;
        }
    }

    /// <summary>
    /// Gets a pointer to the second item in the chain.
    /// </summary>
    public BaseInStructure* Item1Ptr => (BaseInStructure*) (_headPtr + Item1Offset);

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
    /// Creates a new <see cref="Chain{TChain, T1}"/> with 2 items from an existing memory block.
    /// </summary>
    /// <param name="headPtr">The pointer to the head of the chain.</param>
    /// <remarks>
    /// Callers are responsible for ensuring the size of the memory is correct.
    /// </remarks>
    internal Chain(nint headPtr)
    {
        _headPtr = headPtr;
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1}"/> with 2 items.
    /// </summary>
    /// <param name="head">The head of the chain.</param>
    /// <param name="item1">Item 1.</param>
    internal Chain(TChain head = default, T1 item1 = default)
        : this(Marshal.AllocHGlobal(MemorySize))
    {
        head.StructureType();
        Marshal.StructureToPtr(head, _headPtr, false);
        var itemPtr = Item1Ptr;
        item1.StructureType();
        Marshal.StructureToPtr(item1, (nint)itemPtr, false);
        HeadPtr->PNext = itemPtr;
        Item1Ptr->PNext = null;
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
    /// Compares the supplied memory block with this one, ignoring the structure headers.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    protected override bool MemoryEquals(Chain other)
    {
        var ptr = HeadPtr;
        var otherPtr = other.HeadPtr;
        if (ptr == otherPtr) {
            return true;
        }
        var span = new ReadOnlySpan<byte>((void*) ptr, MemorySize);
        var otherSpan = new ReadOnlySpan<byte>((void*) otherPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        if (sliceLength > 0 && 
            !span.Slice(start + HeaderSize, sliceLength)
                .SequenceEqual(otherSpan.Slice(start + HeaderSize, sliceLength)))
            return false;
        return true;
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var span = new ReadOnlySpan<byte>((void*)_headPtr, MemorySize);
        var start = 0;
        var length = HeadSize;
        var sliceLength = length - HeaderSize;
        var hashCode = 0;
        // Hash the structure type
        var sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);

        // Hash any payload
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));

        start += length;
        length = Item1Size;
        sliceLength = length - HeaderSize;
        sTYpe = ((BaseInStructure*) (_headPtr + start))->SType;
        hashCode = HashCode.Combine(hashCode, sTYpe);
        if (sliceLength >= 0)
            CombineHash(ref hashCode, span.Slice(start + HeaderSize, sliceLength));
        return hashCode;
    }
 
    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public bool Equals(Chain<TChain, T1> other)
        => !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || MemoryEquals(other));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator ==(Chain<TChain, T1> left, Chain<TChain, T1> right) => 
        ReferenceEquals(null, left)
        ? ReferenceEquals(null, right)
        : !ReferenceEquals(null, right) && (ReferenceEquals(left, right) || left.MemoryEquals(right));

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]  
    public static bool operator !=(Chain<TChain, T1> left, Chain<TChain, T1> right) => 
        ReferenceEquals(null, left)
        ? !ReferenceEquals(null, right)
        : ReferenceEquals(null, right) || (!ReferenceEquals(left, right) && !left.MemoryEquals(right));

    /// <inheritdoc />
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append((object) Head);        sb.Append(", ");
        sb.Append((object) Item1);
        sb.Append(")");
        return sb.ToString();
    }

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

## Extension methods

A static class is generated to hold the extension methods (showing one example set):

```csharp

/// <summary>
///  Static class providing extension methods for manipulating <see cref="Chain">managed chains</see>.
/// </summary>
/// <remarks><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
/// useful for situations where the specification does not indicate required chain constraints. You should generally
/// try to use the none `Any` version in preference.</para></remarks>
public static unsafe class ChainExtensions
{
    ...
    
    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1}"/> with 2 items, by appending <paramref name="item1"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item1">The item to append.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="AddAny{TChain, T1}(Chain{TChain}, T1)" />
    public static Chain<TChain, T1> Add<TChain, T1>(this Chain<TChain> chain, T1 item1 = default)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        => chain.AddAny(item1);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1}"/> with 2 items, by appending <paramref name="item1"/> to
    /// the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item1">The item to append.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Add{TChain, T1}(Chain{TChain}, T1)" />
    public static Chain<TChain, T1> AddAny<TChain, T1>(this Chain<TChain> chain, T1 item1 = default)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
    {
        var previousSize = Chain<TChain>.MemorySize;
        var newSize = Chain<TChain, T1>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, previousSize, previousSize);
        
        // Add item 0
        item1.StructureType();        
        Marshal.StructureToPtr(item1, newHeadPtr + previousSize, false);

        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1>.Item1Offset);
        ((BaseInStructure*)(newHeadPtr + previousSize))->PNext = null;
        return new Chain<TChain, T1>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1}"/> with 2 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="DuplicateAny{TChain, T1}(Chain{TChain, T1})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1> Duplicate<TChain, T1>(this Chain<TChain, T1> chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        => chain.DuplicateAny();
 
    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1}"/> with 2 by copying the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Duplicate{TChain, T1}(Chain{TChain, T1})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain, T1> DuplicateAny<TChain, T1>(this Chain<TChain, T1> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
    {
        var size = Chain<TChain, T1>.MemorySize;
        var newHeadPtr = Marshal.AllocHGlobal(size);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, size, size);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = (BaseInStructure*) (newHeadPtr + Chain<TChain, T1>.Item1Offset); 
        return new Chain<TChain, T1>(newHeadPtr);
    }

    /// <summary>
    /// Creates a new <see cref="Chain{TChain}"/> with 1 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="TruncateAny{TChain, T1}(Chain{TChain, T1})" />
    /// <seealso cref="Truncate{TChain, T1}(Chain{TChain, T1}, out T1)" />
    /// <seealso cref="TruncateAny{TChain, T1}(Chain{TChain, T1}, out T1)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain> Truncate<TChain, T1>(this Chain<TChain, T1> chain)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain}"/> with 1 items, by removing the last item
    /// from the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1}(Chain{TChain, T1})" />
    /// <seealso cref="Truncate{TChain, T1}(Chain{TChain, T1}, out T1)" />
    /// <seealso cref="TruncateAny{TChain, T1}(Chain{TChain, T1}, out T1)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain> TruncateAny<TChain, T1>(this Chain<TChain, T1> chain)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
        => chain.TruncateAny(out var _);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain, T1}"/> with 1 items, by removing 
    /// <paramref name="item1"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item1">The item removed from the <paramref name="chain"/>.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <remarks>
    /// Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1}(Chain{TChain, T1})" />
    /// <seealso cref="TruncateAny{TChain, T1}(Chain{TChain, T1})" />
    /// <seealso cref="TruncateAny{TChain, T1}(Chain{TChain, T1}, out T1)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Chain<TChain> Truncate<TChain, T1>(this Chain<TChain, T1> chain, out T1 item1)
        where TChain : struct, IChainStart
        where T1 : struct, IExtendsChain<TChain>
        => chain.TruncateAny(out item1);

    /// <summary>
    /// Creates a new <see cref="Chain{TChain}"/> with 1 items, by removing 
    /// <paramref name="item1"/> from the end of the <paramref name="chain"/>.
    /// </summary>
    /// <param name="chain">The chain.</param>
    /// <param name="item1">The item removed from the <paramref name="chain"/>.</param>
    /// <typeparam name="TChain">The chain type</typeparam>
    /// <typeparam name="T1">Type of Item 1.</typeparam>
    /// <remarks>
    /// <para>Do not forget to <see cref="IDisposable">dispose</see> this chain if you are no longer using it.
    /// </para><para>The `Any` versions of chain methods do not validate that items belong in the chain, this is
    /// useful for situations where the specification does not indicate required chain constraints. You should generally
    /// try to use the none `Any` version in preference.</para>
    /// </remarks>
    /// <seealso cref="Truncate{TChain, T1}(Chain{TChain, T1})" />
    /// <seealso cref="TruncateAny{TChain, T1}(Chain{TChain, T1})" />
    /// <seealso cref="Truncate{TChain, T1}(Chain{TChain, T1}, out T1)" />
    public static Chain<TChain> TruncateAny<TChain, T1>(this Chain<TChain, T1> chain, out T1 item1)
        where TChain : struct, IChainable
        where T1 : struct, IChainable
    {
        // Retrieve last item.
        item1 = chain.Item1;

        var newSize = Chain<TChain, T1>.MemorySize - Chain<TChain, T1>.Item1Size;
        var newHeadPtr = Marshal.AllocHGlobal(newSize);
        // Block copy original struct data for speed
        System.Buffer.MemoryCopy(chain.HeadPtr, (void*)newHeadPtr, newSize, newSize);
        // Update all pointers
        ((BaseInStructure*)newHeadPtr)->PNext = null;
        return new Chain<TChain>(newHeadPtr);
    }
    
    ...   
}
```