# Managed Structure Chain Revisions for 3.0

## Summary
An overhaul of the managed wrappers and helpers for the use of
Vulkan structure chains.

# Contributors
- [Khitiara](https://github.com/Khitiara)

# Current Status
- [x] Proposed
- [x] Discussed with API Review Board (ARB)
- [x] Approved
- [ ] Implemented

## Background

### The Underlying Vulkan API
Ubiquitous in Vulkan are the use of "structure chains," a system
whereby many Vulkan structs can form a singly linked list. This 
is used by the Vulkan API primarily to support extending core
function calls with additional functionality, e.g. an 
`ImageCreateInfo` used to create a GPU-side image object may 
be extended with an `ImageFormatListCreateInfo` used to specify 
additional image formats, the latter type having been originally
defined as `ImageFormatListCreateInfoKHR` in an extension before 
being promoted to core api surface. To implement this system,
Vulkan structs which participate in the structure chaining 
system have some additional fields, presented here with C#
pseudo-code.

```csharp
public enum StructureType : int {
    // ...
    ImageCreateInfo = 14,
    // ...
    ImageFormatListCreateInfo = 1000147000
    // ...
}

public struct ImageCreateInfo {
    [FieldOffset(0)]
    public StructureType SType = StructureType.ImageCreateInfo;
    [FieldOffset(4)]
    public void*         PNext;
    // ...
}
```

This system also includes two bare-bones additional structures,
`BaseInStructure` and `BaseOutStructure`, both containing only
the `SType` and `PNext` members at the same offsets. Any `PNext`
in a chain may be reinterpreted to one of those two types,
`SType`inspected to determine the actual value type, and then
the pointer reinterpreted to the appropriate complete structure
type. The existence of both `BaseInStructure` and `BaseOutStructure`
seems to exist to distinguish structs meant to be passed to or
from vulkan, though no consistent guideline on which struct to
use could be easily found leading the author of this proposal to
surmise that the distinction may exist primarily as an
implementation detail nonetheless exposed publicly.

### The Situation in Silk.NET 2.X

In Silk.NET 2.X, a number of utility types and methods are
available to facilitate easier use of these structure chain
types from managed C# code, where normal use would require
an absurd amount of `fixed` statements or the use of unsafe
bcl APIs. The available utility functionality in Silk.NET 2.X
is broadly divisible into two distinct systems: a set of
convenient wrappers over the unsafe ref-manipulation bcl
APIs for common chain operations, and a set of managed
`Chain<...>` types which perform manual memory allocation
in a single unmanaged memory block where the structs are
stored using `unsafe` pointer reinterpreting, and exposing
properties and methods which allow the structure instances
in a chain to be manipulated while keeping the chain of
`PNext` pointers intact. These two systems are both built
on a set of marker interfaces which are implemented on
vulkan structure types by SilkTouch.

The wrapper functions over ref-manipulation, comprised mostly
of extension methods on `ref T`, are unaffected by this
current proposal, as the motivating issues are primarily
design choices for the managed heap-safe `Chain<...>` types
and for the marker interfaces which were made early in 
Silk.NET 2.X and are either not possible to change within
the 2.X cycle due to the Silk.NET breaking change policy or
which could be augmented by features in newer .NET versions
which cannot be relied on by Silk.NET 2.X, such as static
abstracts on interfaces. As Silk.NET 3.0 will target .NET 8
and permits breaking changes for the major version rollover
only, a number of improvements, both breaking and nonbreaking,
may be made for this upcoming major version release.

## Prior Proposals
- [Chain Polymorphism Proposal](https://github.com/dotnet/Silk.NET/blob/e8c0026fd2ebbc382b89b923b9bcaffc3ba1ede3/documentation/proposals/Proposal%20-%20Chain%20Polymorphism.md),
proposed in [#1145](https://github.com/dotnet/Silk.NET/pull/1145).
- [Addition of ref properties in #1420](https://github.com/dotnet/Silk.NET/pull/1420),
amended in [#1423](https://github.com/dotnet/Silk.NET/pull/1423) due to errors in
ref semantics.

## Proposed API Changes from 2.X
~~Apologies for the lack of C# syntax highlighting, as
highlighting the differences has been prioritized~~

```diff
 public interface IStructuredType
 {
+    public static abstract StructureType StructureType { get; }
+
-    public StructureType StructureType();
+    public StructureType FixStructureType();
 }
```
The existing `IStructuredType.StructureType()` method sets the
struct's `SType` field to be the correct value for the particular
struct type and then returns it. It is proposed that the .NET 7+
static abstracts in interfaces feature be used to force the
presence of a static property to return the correct enum value
for that type in a static context, and that the `StructureType()`
method be renamed to suggest its updated purpose of correcting
the `SType` field on the struct. The return behavior of the
method is left as-is to permit ease of implementing the changes
as much of the existing implementation relies on this behavior
for concise implementation.

```diff
 public class Chain<TChain, T1, ...> : Chain
 {
     // ...
-    public unsafe BaseInStructure* Item1Ptr { get; }
+    public unsafe T1* Item1Ptr { get; }
     // ...
 }
```
This change has been proposed previously but was rejected at the
time as source-breaking changes during the 2.X cycle were not
permitted. As Silk.NET 3.0 permits breaking changes from 2.X
the change can now be made. Having readily accessible type-safe
pointers helps a lot with much of how the `Chain<...>` types
are commonly used.

This design also renames the non-generic `Chain` instead and gives it
the head structure type `TChain` as a generic argument.
```diff
 public abstract class BaseChain<TChain>
 {
     // ...
-    public abstract unsafe BaseInStructure* HeadPtr { get; }
+    public abstract unsafe TChain* HeadPtr { get; }
     // ...
 }

 public class Chain<TChain, ...> : BaseChain<TChain>
 {
     // ...
-    public override unsafe BaseInStructure* HeadPtr { get; }
+    public override unsafe TChain* HeadPtr { get; }
     // ...
 }
```

The reason for separating `BaseChain<TChain>` from `Chain<TChain>`, 
the chain of one element, in this design is that the latter
performs management of unmanaged memory sized to hold the singular
`TChain` object whereas the former is the base type of all chains
starting with `TChain`, which is to say all chains before generic
specialization, and has no inherent knowledge of the size of
the allocated unmanaged memory.

```diff
 public class Chain<TChain, ...> : Chain
 {
     // ...
+    public ref TChain GetPinnableReference();
     // ...
 }
```
Adding `GetPinnableReference()` with that precise name permits the use
of the following relatively convenient syntax for converting a full
`Chain<...>` to a pointer; providing this method is a common
convention for memory-holding types in modern C# that this method
should be provided despite the `Chain<...>` object already holding
a reference to unmanaged memory and thus not needing to be pinned
by the garbage collector.
```csharp
Chain<ImageCreateInfo> chain = ...;
fixed(ImageCreateInfo* ptr = chain) {
    _vk.CreateImage(device, ptr, null, &image);
}
```

```diff
 public interface IChain<TChain, T1, ...>
 {
     // ...
+    public unsafe TChain* HeadPtr { get; }
     // ...
 }
```
The `IChain` interfaces permit polymorphism of managed chain objects and were
introduced by the [Chain Polymorphism Proposal](https://github.com/dotnet/Silk.NET/blob/e8c0026fd2ebbc382b89b923b9bcaffc3ba1ede3/documentation/proposals/Proposal%20-%20Chain%20Polymorphism.md),
proposed in [#1145](https://github.com/dotnet/Silk.NET/pull/1145).
Adding typed pointer members to the `IChain` interfaces may be done
without regard to the design chosen for the type of `HeadPtr` in the
concrete chain types thanks to explicit interface implementation in the
case no change is made to that member, and is easily implemented in any
case no matter if the concrete `ItemNPtr` members are changed to type-safe
through the same mechanism of explicit interface implementation.

# Meeting Notes

## 19/11/2023

[Video](https://www.youtube.com/live/yXNDZDE3AHE?feature=shared&t=1221)

- We believe that the chain abstractions break down significantly anyway when used as an output with layers that can possibly inject additional PNexts that aren't reflected in these abstractions.
- As a result, this chain abstraction only really works with inputs in every case.
- UntypedHeadPtr being changed from BaseInStructure is contrary to this assumption.
- Why is it IStructuredType instead of ITypedStructure? Changing this doesn't affect too much, but leaving it as is doesn't affect too much either.
- 3.0 is the opportunity to fix long-standing issues like this as it's already massively breaking, so we can do silly changes like this.
- IStructuredType is already broken with this proposal, so let's just rename it anyway.
- We believe that IBaseStructure is probably the most sensible name given how Vulkan names this.
- Everything else looks fine, approved notwithstanding the above.
