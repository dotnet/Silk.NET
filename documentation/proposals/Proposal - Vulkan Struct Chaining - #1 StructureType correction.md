# Summary

This proposal is a minimal enhancement to [`Silk.Net.Vulkan`](../../src/Vulkan/Silk.NET.Vulkan) to mark all structures
that contain a `StructureType SType` field as implementing the interface `IStructuredType`.

This is a tiny pre-requisite for
[Proposal - Vulkan Struct Chaining - #2 Unmanaged Chaining.md](Proposal%20-%20Vulkan%20Struct%20Chaining%20-%20%232%20Unmanaged%20Chaining.md)
and is of limited value otherwise. Its primary purpose is to mark any structure that requires it's `SType` field to be
correctly set when passing to Vulkan, and to provide a mechanism for doing so.

# Contributors

- [Craig Dean, DevDecoder](https://github.com/thargy)

# Current Status

- [x] Proposed
- [ ] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented

# Design Decisions

- The `IStructuredType` interface will usually not be implemented directly, instead `IChainable` (from
  the [unmanaged chaining proposal](Proposal%20-%20Vulkan%20Struct%20Chaining%20-%20%232%20Unmanaged%20Chaining.md))
  will extend this interface.
- The BuildTools should instead only add this interface to any structure that meets the above constraint (the structure
  has a `StructureType SType` field) that _doesn't_ already add the `IChainable` interface. Though I believe this
  scenario won't occur in the current Vulkan specification, we'd need to check all valid StructureType structures to
  confirm, and regardless, writing the code to add the interface in such scenarios will future proof it.
- Whenever the `IStructuredType` is added to an interface (either directly or indirectly) the
  corresponding `StructureType()` method should also be explicitly
  implemented ([see below](#istructuretype-implementation)).
- This proposed interface could easily be combined/merged with the `IChainable`
  interface which [is proposed](Proposal%20-%20Vulkan%20Struct%20Chaining%20-%20%232%20Unmanaged%20Chaining.md) as an
  extension. However, that interface marks a struct as having a second field `void* PNext`, as well as requiring
  that `StructureType sType` field is in the first position, which is not required by this proposal (but is allowed).
  Keeping the two concepts separate is good encapsulation and good for supporting future changes. The concept
  that an `SType` must be correct is somewhat different to the concept of a chain (implied by `void* PNext`).
- To be clear, this proposal does not need to guarantee that the `SType` field is in position 0 (i.e. first),
  that requirement is only necessary to implement the functionality
  [proposed by the unmanaged chaining system](Proposal%20-%20Vulkan%20Struct%20Chaining%20-%20%232%20Unmanaged%20Chaining.md)

# Implementation Notes

- BuildTools already contains enough information to determine whether the interface should be added to a structure, and
  already knows which `StructureType` the structure should use.
- A working example of such a struct can
  be [found in the labs.](../../src/Lab/Experiments/PrototypeStructChaining/PrototypeStructChaining/PhysicalDeviceFeatures2.cs)

# Proposed API

## StructureType structures

### IStructuredType

This proposal adds a single interface `IStructuredType`, the primary purpose of which is to mark any structure that
requires it's `SType` to be correctly set when passing to Vulkan. It adds a single
method `void IStructuredType.StructureType()`
which sets the `SType` correctly and returns it to the caller.

```csharp
namespace Silk.Net.Vulkan;

/// <summary>
/// Base interface for any struct that has a <see cref="StructureType"/> field called `SType`, that must be correctly
/// set when passing into the Vulkan API.
/// </summary>
public interface IStructuredType
{
    /// <summary>
    /// Gets the structured type's <see cref="Vulkan.StructureType"/> enum value.
    /// </summary>
    /// <remarks>
    /// Retrieving the <see cref="Vulkan.StructureType"/> also ensures it is set to the correct value.
    /// </remarks>
    StructureType StructureType();
}
```

### IStructureType implementation

Each struct generated that implements `IStructuredType` should also have the following code auto-generated, to
explicitly implement the interface. The method sets and returns the `SType` correctly for the current structure.

```csharp
/// <inheritdoc />
StructureType IStructuredType.StructureType()
{
    return SType = StructureType.<INSERT CORRECT TYPE HERE>;
}
```
