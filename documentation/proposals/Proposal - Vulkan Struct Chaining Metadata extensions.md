# Summary

Having extended `BuildTools` to make use of the `structextends` attribute, as part of
the [unmanaged chaining proposal](Proposal%20-%20Vulkan%20Struct%20Chaining%20-%20%232%20Unmanaged%20Chaining.md)
it is possible to supply that metadata in a ready form for use by consumers of the library, without them needing to
resort to reflection.

There are a number of potential use cases, most specifically validating that a supply `IChainable` structure is valid
for a given chain, at runtime. To facilitate the most common scenario 4 extension methods are also added.

# Contributors

- [Craig Dean, DevDecoder](https://github.com/thargy)

# Current Status

- [x] Proposed
- [x] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented

# Design Decisions

- It is possible to get the same information presented statically by this proposal by creative use of reflection,
  however, it is non-trivial and costly to do so.
- The above functionality makes handling of non-generic chains at runtime significantly easier, which is great for
  library writers.
- Though 4 collections are proposed, they are grouped in pairs, providing two-way mapping. It is possible to only
  provide one of each pair, and leave the reversal to the consumer, though that would make the extension methods
  impractical.
- As .Net Standard 2.0 does not support `IReadOnlySet<T>` we make use of the `IReadOnlyCollection<T>` interface.

# Proposed API

## Auto-generated Metadata Structures

The `Extensions` dictionary is added to the [`ChainExtensions`](../../src/Vulkan/Silk.NET.Vulkan/ChainExtensions.cs)
extensions class for discoverability. It is a direct mapping of the `structextends` attribute, and is therefore trivial
to generate. Below is a cut down example to illustrate what will be generated:

```csharp
public static class ChainExtensions : IChainable
{
    ...
    /// <summary>
    /// Provides a set of all the <see cref="StructureType"/>s that can be extended by a <see cref="StructureType"/>.
    /// </summary>
    public static readonly IReadOnlyDictionary<StructureType, IReadOnlyCollection<StructureType>> Extensions =
        new Dictionary<StructureType, IReadOnlyCollection<StructureType>>
        {
            [StructureType.PhysicalDeviceFeatures2] = new HashSet<StructureType>
            {
                StructureType.DeviceCreateInfo
            },
            [StructureType.PhysicalDeviceDescriptorIndexingFeatures] = new HashSet<StructureType>
            {
                StructureType.PhysicalDeviceFeatures2,
                StructureType.DeviceCreateInfo
            },
            [StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr] = new HashSet<StructureType>
            {
                StructureType.PhysicalDeviceFeatures2,
                StructureType.DeviceCreateInfo
            },
            ...
        };
}
```

## Extenders (Optional)

By contrast the `Extenders` dictionary, it the reverse mapping of the `Extensions` dictionary, providing quick reverse
lookup. As this is slightly more complex to generate, it could be left to the consumer (who can generate it easily
from `Extensions` when needed).

```csharp
public struct Chain : IChainable
{
    ...
    /// <summary>
    /// Provides a set of all the <see cref="StructureType"/>s that can extend a <see cref="StructureType"/>.
    /// </summary>
    public static readonly IReadOnlyDictionary<StructureType, IReadOnlyCollection<StructureType>> Extenders =
        new Dictionary<StructureType, IReadOnlyCollection<StructureType>>
        {
            [StructureType.DeviceCreateInfo] = new HashSet<StructureType>
            {
                StructureType.PhysicalDeviceFeatures2, StructureType.PhysicalDeviceDescriptorIndexingFeatures,
                StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr
            },
            [StructureType.PhysicalDeviceFeatures2] = new HashSet<StructureType>
            {
                StructureType.PhysicalDeviceDescriptorIndexingFeatures,
                StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr
            }, 
            ...
        };
}
```

### ClrTypes

The `ClrTypes` dictionary provides a `ClrType` for each `StructureType`, it is trivial to generate with existing
information:

```csharp
public struct Chain : IChainable
{
    ...
    /// <summary>
    /// Provides a mapping from the <see cref="StructureType"/> to the corresponding <see cref="Type"/>.
    /// </summary>
    public static readonly IReadOnlyDictionary<StructureType, Type> ClrTypes =
        new Dictionary<StructureType, Type>
        {
            [StructureType.DeviceCreateInfo] = typeof(DeviceCreateInfo),
            [StructureType.PhysicalDeviceFeatures2] = typeof(PhysicalDeviceFeatures2),
            [StructureType.PhysicalDeviceDescriptorIndexingFeatures]= typeof(PhysicalDeviceDescriptorIndexingFeatures),
            [StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr] = typeof(PhysicalDeviceAccelerationStructureFeaturesKhr),
            ...            
        };
}
```

### StructureTypes (Optional)

The `StructureTypes` is the reverse mapping of `ClrTypes` and is likewise trivial to generate.

```csharp
public struct Chain : IChainable
{
    ...
    /// <summary>
    /// Provides a mapping from the <see cref="Type"/> to the corresponding <see cref="StructureType"/>.
    /// </summary>
    public static readonly IReadOnlyDictionary<Type, StructureType> StructureTypes =
        new Dictionary<Type, StructureType>
        {
            [typeof(DeviceCreateInfo)] = StructureType.DeviceCreateInfo,
            [typeof(PhysicalDeviceFeatures2)] = StructureType.PhysicalDeviceFeatures2,
            [typeof(PhysicalDeviceDescriptorIndexingFeatures)]= StructureType.PhysicalDeviceDescriptorIndexingFeatures,
            [typeof(PhysicalDeviceAccelerationStructureFeaturesKhr)] = StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr
            ...
        };
}
```

## Extension Methods

The following extension methods are not auto-generated and so can be added simply.

### ClrType()

Gets the corresponding `ClrType` for a `StructureTYpe`.

```csharp
public static class Chain
{
    ...
    /// <summary>
    /// Gets the corresponding <see cref="StructureType"/> for a <see cref="Type"/>, if any.
    /// </summary>
    /// <param name="structureType">The structure type.</param>
    /// <returns> The corresponding <see cref="StructureType"/> for <paramref name="structureType"/>, if any; otherwise,
    /// <see langword="null"/>.</returns>
    public static Type ClrType(this StructureType structureType)
    {
        return Chain.ClrTypes[structureType];
    }
}
```

Usage:

```csharp
Assert.Equal(typeof(DeviceCreateInfo), StructureType.DeviceCreateInfo.ClrType());
```

### StructureType() (Optional)

Gets the corresponding `ClrType` for a `StructureTYpe`.

```csharp
public static class Chain
{
    ...
    /// <summary>
    /// Gets the corresponding <see cref="StructureType"/> for a <see cref="Type"/>, if any.
    /// </summary>
    /// <param name="type">The CLR type.</param>
    /// <returns> The corresponding <see cref="StructureType"/> for <paramref name="type"/>, if any; otherwise,
    /// <see langword="null"/>.</returns>
    public static StructureType? StructureType(this Type type)
    {
        return Chain.StructureTypes.TryGetValue(type, out var structureType) ? structureType : null;
    }
}
```

Usage:

```csharp
Assert.Equal(StructureType.DeviceCreateInfo, typeof(DeviceCreateInfo).StructureType());
Assert.Null(typeof(PhysicalDeviceFeatures).StructureType());
```

### IsChainStart()

Tests whether the `StructureType` or `Type` can be used at the start of a chain:

```csharp
public static class Chain
{
    ...
    /// <summary>
    /// Whether the <see cref="StructureType"/> can start a chain.
    /// </summary>
    /// <param name="type">The <see cref="StructureType"/> to test.</param>
    /// <returns><see langword="true"/> if the <see cref="StructureType"/> can start a chain; otherwise
    /// <see langword="false"/>.</returns>
    public static bool IsChainStart(this StructureType type)
    {
        return Chain.Extenders.ContainsKey(type);
    }
    
    /// <summary>
    /// Whether the <see cref="Type"/> can start a chain.
    /// </summary>
    /// <param name="type">The <see cref="Type"/> to test.</param>
    /// <returns><see langword="true"/> if the <see cref="Type"/> can start a chain; otherwise
    /// <see langword="false"/>.</returns>
    public static bool IsChainStart(this Type type)
    {
        return Chain.StructureTypes.TryGetValue(type, out var structureType) &&
               Chain.Extenders.ContainsKey(structureType);
    }
}
```

Usage:

```csharp
Assert.True(StructureType.DeviceCreateInfo.IsChainStart());
Assert.True(typeof(DeviceCreateInfo).IsChainStart());
Assert.False(StructureType.PhysicalDeviceDescriptorIndexingFeatures.IsChainStart());
Assert.False(typeof(PhysicalDeviceDescriptorIndexingFeatures).IsChainStart());
```

### IsChainable()

Tests whether the `StructureType` or `Type` can be used in a chain:

```csharp
public static class Chain
{
    ...
    /// <summary>
    /// Whether the <see cref="StructureType"/> is chainable.
    /// </summary>
    /// <param name="type">The <see cref="StructureType"/> to test.</param>
    /// <returns><see langword="true"/> if the <see cref="StructureType"/> can start a chain; otherwise
    /// <see langword="false"/>.</returns>
    public static bool IsChainable(this StructureType type)
    {
        return Chain.Extenders.ContainsKey(type) ||
               Chain.Extensions.ContainsKey(type);
    }
    
    /// <summary>
    /// Whether the <see cref="Type"/> is chainable.
    /// </summary>
    /// <param name="type">The <see cref="Type"/> to test.</param>
    /// <returns><see langword="true"/> if the <see cref="Type"/> can start a chain; otherwise
    /// <see langword="false"/>.</returns>
    public static bool IsChainable(this Type type)
    {
        return Chain.StructureTypes.TryGetValue(type, out var structureType) &&
               (Chain.Extenders.ContainsKey(structureType) ||  Chain.Extensions.ContainsKey(structureType));
    }
}
```

Usage:

```csharp
Assert.True(StructureType.DeviceCreateInfo.IsChainable());
Assert.True(typeof(DeviceCreateInfo).IsChainable());
Assert.True(StructureType.PhysicalDeviceDescriptorIndexingFeatures.IsChainable());
Assert.True(typeof(PhysicalDeviceDescriptorIndexingFeatures).IsChainable());
```

### CanExtend()

Tests whether the `StructureType` or `Type` can extend the corresponding type:

```csharp
public static class Chain
{
    ...

    /// <summary>
    /// Whether the current <see cref="StructureType"/> can extend the <paramref name="chain"/>.
    /// </summary>
    /// <param name="next">The <see cref="StructureType"/> to test.</param>
    /// <param name="chain">The <see cref="StructureType"/> of the chain.</param>
    /// <returns><see langword="true"/> if the <see cref="StructureType"/> can extend the <paramref name="chain"/>; otherwise, false.</returns>
    /// <seealso cref="CanBeExtendedBy(Silk.Net.Vulkan.StructureType,Silk.Net.Vulkan.StructureType)"/>
    public static bool CanExtend(this StructureType next, StructureType chain)
    {
        return Chain.Extensions.TryGetValue(next, out var extensions) && extensions.Contains(chain);
    }

    /// <summary>
    /// Whether the current <see cref="Type"/> can extend the <paramref name="chain"/>.
    /// </summary>
    /// <param name="next">The <see cref="Type"/> to test.</param>
    /// <param name="chain">The <see cref="Type"/> of the chain.</param>
    /// <returns><see langword="true"/> if the <see cref="Type"/> can extend the <paramref name="chain"/>; otherwise, false.</returns>
    /// <seealso cref="CanBeExtendedBy(System.Type,System.Type)"/>
    public static bool CanExtend(this Type next, Type chain)
    {
        return 
            Chain.StructureTypes.TryGetValue(next, out var nextType) &&
            Chain.StructureTypes.TryGetValue(chain, out var chainType) &&
            Chain.Extensions.TryGetValue(nextType, out var extensions) &&
            extensions.Contains(chainType);
    }
}
```

Usage:

```csharp
Assert.True(StructureType.PhysicalDeviceFeatures2.CanExtend(StructureType.DeviceCreateInfo));
Assert.False(StructureType.DeviceCreateInfo.CanExtend(StructureType.PhysicalDeviceFeatures2));
Assert.True(typeof(PhysicalDeviceFeatures2).CanExtend(typeof(DeviceCreateInfo)));
Assert.False(typeof(DeviceCreateInfo).CanExtend(typeof(PhysicalDeviceFeatures2)));
```

### CanBeExtendedBy()

Tests whether the `StructureType` or `Type` can be extended by the corresponding type:

```csharp
public static class Chain
{
    ...

    /// <summary>
    /// Whether the current <paramref name="chain"/> can be extended by the <paramref name="next"/> <see cref="StructureType"/>.
    /// </summary>
    /// <param name="chain">The <see cref="StructureType"/> of the chain.</param>
    /// <param name="next">The <see cref="StructureType"/> to test.</param>
    /// <returns><see langword="true"/> if the <paramref name="chain"/> can be extended the <paramref name="chain"/>; otherwise, false.</returns>
    /// <seealso cref="CanExtend(Silk.Net.Vulkan.StructureType,Silk.Net.Vulkan.StructureType)"/>
    public static bool CanBeExtendedBy(this StructureType chain, StructureType next)
    {
        return Chain.Extenders.TryGetValue(chain, out var extenders) && extenders.Contains(next);
    }

    /// <summary>
    /// Whether the current <paramref name="chain"/> can be extended by the <paramref name="next"/> <see cref="Type"/>.
    /// </summary>
    /// <param name="chain">The <see cref="Type"/> of the chain.</param>
    /// <param name="next">The <see cref="Type"/> to test.</param>
    /// <returns><see langword="true"/> if the <see cref="Type"/> can extend the <paramref name="chain"/>; otherwise, false.</returns>
    /// <seealso cref="CanExtend(Type, Type)"/>
    public static bool CanBeExtendedBy(this Type chain, Type next)
    {
        return 
            Chain.StructureTypes.TryGetValue(next, out var nextType) &&
            Chain.StructureTypes.TryGetValue(chain, out var chainType) &&
            Chain.Extenders.TryGetValue(chainType, out var extenders) && 
            extenders.Contains(nextType);
    }
}
```

Usage:

```csharp
Assert.False(StructureType.PhysicalDeviceFeatures2.CanBeExtendedBy(StructureType.DeviceCreateInfo));
Assert.True(StructureType.DeviceCreateInfo.CanBeExtendedBy(StructureType.PhysicalDeviceFeatures2));
Assert.False(typeof(PhysicalDeviceFeatures2).CanBeExtendedBy(typeof(DeviceCreateInfo)));
Assert.True(typeof(DeviceCreateInfo).CanBeExtendedBy(typeof(PhysicalDeviceFeatures2)));
```