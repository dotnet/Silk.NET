# Structure Chaining

[Table of Contents](overview.md#table-of-contents)

- [Introduction](structure-chaining.md#introduction)
- [Usage](structure-chaining.md#usage)
    - [Creation (Chain)](structure-chaining.md#creation-chain)
        - [Understanding the Chain method's return value](structure-chaining.md#understanding-the-chain-methods-return-value)
    - ['Any' Overloads](structure-chaining.md#any-overloads)
    - [Extending the chain](structure-chaining.md#extending-the-chain)
        - [Adding (AddNext/AddNextAny)](structure-chaining.md#adding-addnextaddnextany)
        - [Try adding (TryAddNext/TryAddNextAny)](structure-chaining.md#try-adding-tryaddnexttryaddnextany)
        - [Setting or Replacing (SetNext/SetNextAny)](structure-chaining.md#setting-or-replacing-setnextsetnextany)
    - [Indexing (IndexOf/IndexOfAny)](structure-chaining.md#indexing-indexofindexofany)
- [Performance](structure-chaining.md#performance)

## Introduction

The Structure Chaining methodology logically sits between the [Managed Chaining methodology](managed-chaining.md) and
the [Raw Chaining methodology](raw_chaining.md). In a very real sense, it can either be seen as having the best elements
of both, or of being a compromise that isn't as good as either alternative!

Notwithstanding, the methodology makes use of a set of well documented extension methods, found
in [`ChainExtensions`](../../src/Vulkan/Silk.NET.Vulkan/ChainExtensions.cs) to allow the type-safe manipulation
of `IChainable` structures efficiently; with the exception of the `ref Chain(out)` instance convenience method which we
cover [below](#creation-chain), that is implemented automatically on any structure that implements `IChainStart`.

## Usage

### Creation (Chain)

You can happily create the start of a chain as you would with [Raw Chaining](raw_chaining.md), by declaring a variable
of the chain's head first. Indeed it is necessary to do so if you wish to specify non-default values for the head
structure (though you can also make use of `SetNext`s replace functionality). You also need to use this approach when
starting a chain which is not explicitly defined as a [chain start](vulkan.md#ichainstart) by the specification. If you
do start a chain with such a structure, you will have to use the [`*Any` overloads](#any-overloads) of the extension
methods below to continue manipulating it.

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

In many cases, we only want to create a default structure for population by the API. To do so, we can make use of the
static `ref Chain(out)` convenience method like so:

```csharp
PhysicalDeviceFeatures2.Chain(out var features2)
```

This has several advantages:

- The method is only available for structures that are valid at the start of a chain; providing compile-time validation.
- The structure's `SType` will be correctly set immediately.
- The syntax is fluent, and creates more readable code when used with the other chaining methods (
  see [below](#adding-addnextaddnextany)).

#### Understanding the Chain method's return value

All the chaining methods return the current start of the chain by reference (including `ref Chain(out)`). This allows
each method to scan the entire chain. More importantly, it allows the Type constraints to be checked during compile time
to ensure that a type actually can extend the chain (unless you are using the [`*Any` overloads](#any-overloads) which
define looser constraints). One side effect of this approach is that `ref Chain(out)` outputs the newly created chain _
and_ returns a reference to it. This can cause confusion to less experienced C# devs, for example:

```csharp
// TL;DR Never do this assignment
var a = ChainStart.Chain(out var b).AddNext(out ChainExtension c);
```

Both `a` and `b` will appear to be identical structures; however 'a' is actually a copy of 'b', _being separate
locations on the current stack frame_. In most cases, that is really no problem at all (though there is a performance
impact due to the copy) as the copy occurs at the end of the statement (during the assignment operation) so both `a`
and `b` are a copy of the _start_ of the chain that point to the same next item. However, if further modifications are
made to the head of either `a` or `b`, they will not be reflected in the other. None of this is undefined behaviour, but
as it is generally poorly understood none of the examples ever recommend assigning the output of a chain, and it should
be avoided.

The `ref Chain(out)` method is a static method that is only implemented automatically on `IChainStart` structures, the
remaining methods are actually extension methods.

### 'Any' Overloads

[_(see also)_](vulkan.md#any-overloads)

The methods ending with `Any` can be used with any `IChainable` structure, but they do not constrain the entries, or the
head of the chain to being structures explicitly mentioned by the specification. The non-`Any` methods are more
restrictive, and should usually be used in preference.

### Extending the chain

#### Adding (AddNext/AddNextAny)

The most common use case is to add an empty structure to the end of a chain for it to be populated by the Vulkan API,
this can be done using the `AddNext` method like so:

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

#### Try adding (TryAddNext/TryAddNextAny)

You may only want to add a structure if it doesn't already exist in the chain, this can be done with `TryAddNext`, e.g.:

```csharp
PhysicalDeviceFeatures2
    .Chain(out var features2)
    .AddNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures)
    // As there is already a PhysicalDeviceDescriptorIndexingFeatures structure the following
    // will not add anything to the chain and `added` will be `false`.
    .TryAddNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures2, out bool added);
```

#### Setting or Replacing (SetNext/SetNextAny)

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

### Indexing (IndexOf/IndexOfAny)

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

## Performance

Structure chaining has the advantage that it avoids the heap entirely, and encourages you to pass the structures around
as references (avoiding copies). Note though, it can't stop you from sticking something on the heap or doing an
unnecessary copy, but it doesn't encourage the behaviour.

However, every action begins at the chain's head, so extending the chain is always an O(n) operation. Technically, it
should still be faster than [extending a Managed Chain](managed-chaining.md#adding-to-a-chain-addaddany) which needs to
copy the entire chain so is also O(n), as it merely skips from pointer to pointer, whilst coercing the `SType` field.
However [Raw Chaining](raw_chaining.md) can extend a chain quickly if it keeps track of the tail.

The pay off is a compact syntax that works well with IDE tools and compile time checking, due to the type constraint
system, whilst encouraging good practice. As such, it should be compared to [Raw Chaining](raw_chaining.md) when trying
to optimise a hot path.