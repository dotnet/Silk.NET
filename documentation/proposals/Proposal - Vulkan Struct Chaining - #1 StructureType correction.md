# Summary

This proposal is a minimal enhancement to [`Silk.Net.Vulkan`](../../src/Vulkan/Silk.NET.Vulkan) to mark all structures
that contain a `StructureType SType` field (in the first position) as implementing the interface `IStructuredType`.

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
- The BuildTools should instead only add this interface to any structure that meets the above constraints (the first
  field must be `StructureType SType`) that _doesn't_ already add the `IChainable` interface. Though I believe this
  scenario won't occur in the current Vulkan specification, I need to check all valid StructureType structures to
  confirm, and regardless, writing the code to add the interface in such scenarios will future proof it.
- Whenever the `IStructuredType` is added to an interface

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

public interface IStructuredType
{
    /// <summary>
    /// Gets the structured type's <see cref="Vulkan.StructureType"/> enum value.
    /// </summary>
    /// <remarks>
    /// Retrieving the <see cref="Vulkan.StructureType"/> also coerces it to the correct value.
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
