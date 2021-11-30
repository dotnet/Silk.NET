using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

public static class ChainExtensionsMetadata
{
    /// <summary>
    /// Provides a set of all the <see cref="StructureType"/>s that can be extended by a <see cref="StructureType"/>.
    /// </summary>
    public static readonly IReadOnlyDictionary<StructureType, IReadOnlyCollection<StructureType>> Extensions =
        new Dictionary<StructureType, IReadOnlyCollection<StructureType>>
        {
            [Vulkan.StructureType.PhysicalDeviceFeatures2] = new HashSet<StructureType>
            {
                Vulkan.StructureType.DeviceCreateInfo
            },
            [Vulkan.StructureType.PhysicalDeviceDescriptorIndexingFeatures] = new HashSet<StructureType>
            {
                Vulkan.StructureType.PhysicalDeviceFeatures2,
                Vulkan.StructureType.DeviceCreateInfo
            },
            [Vulkan.StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr] = new HashSet<StructureType>
            {
                Vulkan.StructureType.PhysicalDeviceFeatures2,
                Vulkan.StructureType.DeviceCreateInfo
            }
        };

    /// <summary>
    /// Provides a set of all the <see cref="StructureType"/>s that can extend a <see cref="StructureType"/>.
    /// </summary>
    public static readonly IReadOnlyDictionary<StructureType, IReadOnlyCollection<StructureType>> Extenders =
        new Dictionary<StructureType, IReadOnlyCollection<StructureType>>
        {
            [Vulkan.StructureType.DeviceCreateInfo] = new HashSet<StructureType>
            {
                Vulkan.StructureType.PhysicalDeviceFeatures2,
                Vulkan.StructureType.PhysicalDeviceDescriptorIndexingFeatures,
                Vulkan.StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr
            },
            [Vulkan.StructureType.PhysicalDeviceFeatures2] = new HashSet<StructureType>
            {
                Vulkan.StructureType.PhysicalDeviceDescriptorIndexingFeatures,
                Vulkan.StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr
            }
        };

    /// <summary>
    /// Provides a mapping from the <see cref="StructureType"/> to the corresponding <see cref="Type"/>.
    /// </summary>
    public static readonly IReadOnlyDictionary<StructureType, Type> ClrTypes =
        new Dictionary<StructureType, Type>
        {
            [Vulkan.StructureType.DeviceCreateInfo] = typeof(DeviceCreateInfo),
            [Vulkan.StructureType.PhysicalDeviceFeatures2] = typeof(PhysicalDeviceFeatures2),
            [Vulkan.StructureType.PhysicalDeviceDescriptorIndexingFeatures] =
                typeof(PhysicalDeviceDescriptorIndexingFeatures),
            [Vulkan.StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr] =
                typeof(PhysicalDeviceAccelerationStructureFeaturesKHR)
        };

    /// <summary>
    /// Provides a mapping from the <see cref="Type"/> to the corresponding <see cref="StructureType"/>.
    /// </summary>
    public static readonly IReadOnlyDictionary<Type, StructureType> StructureTypes =
        new Dictionary<Type, StructureType>
        {
            [typeof(DeviceCreateInfo)] = Vulkan.StructureType.DeviceCreateInfo,
            [typeof(PhysicalDeviceFeatures2)] = Vulkan.StructureType.PhysicalDeviceFeatures2,
            [typeof(PhysicalDeviceDescriptorIndexingFeatures)] =
                Vulkan.StructureType.PhysicalDeviceDescriptorIndexingFeatures,
            [typeof(PhysicalDeviceAccelerationStructureFeaturesKHR)] =
                Vulkan.StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr
        };

    /// <summary>
    /// Gets the corresponding <see cref="StructureType"/> for a <see cref="Type"/>, if any.
    /// </summary>
    /// <param name="structureType">The structure type.</param>
    /// <returns> The corresponding <see cref="StructureType"/> for <paramref name="structureType"/>, if any; otherwise,
    /// <see langword="null"/>.</returns>
    public static Type ClrType(this StructureType structureType)
    {
        return ClrTypes[structureType];
    }

    /// <summary>
    /// Gets the corresponding <see cref="StructureType"/> for a <see cref="Type"/>, if any.
    /// </summary>
    /// <param name="type">The CLR type.</param>
    /// <returns>The corresponding <see cref="StructureType"/> for <paramref name="type"/>, if any; otherwise,
    /// <see langword="null"/>.</returns>
    public static StructureType? StructureType(this Type type)
    {
        return StructureTypes.TryGetValue(type, out var structureType) ? structureType : null;
    }

    /// <summary>
    /// Whether the <see cref="StructureType"/> can start a chain.
    /// </summary>
    /// <param name="type">The <see cref="StructureType"/> to test.</param>
    /// <returns><see langword="true"/> if the <see cref="StructureType"/> can start a chain; otherwise
    /// <see langword="false"/>.</returns>
    public static bool IsChainStart(this StructureType type)
    {
        return Extenders.ContainsKey(type);
    }

    /// <summary>
    /// Whether the <see cref="Type"/> can start a chain.
    /// </summary>
    /// <param name="type">The <see cref="Type"/> to test.</param>
    /// <returns><see langword="true"/> if the <see cref="Type"/> can start a chain; otherwise
    /// <see langword="false"/>.</returns>
    public static bool IsChainStart(this Type type)
    {
        return StructureTypes.TryGetValue(type, out var structureType) &&
               Extenders.ContainsKey(structureType);
    }

    /// <summary>
    /// Whether the <see cref="StructureType"/> is chainable.
    /// </summary>
    /// <param name="type">The <see cref="StructureType"/> to test.</param>
    /// <returns><see langword="true"/> if the <see cref="StructureType"/> can start a chain; otherwise
    /// <see langword="false"/>.</returns>
    public static bool IsChainable(this StructureType type)
    {
        return Extenders.ContainsKey(type) ||
               Extensions.ContainsKey(type);
    }

    /// <summary>
    /// Whether the <see cref="Type"/> is chainable.
    /// </summary>
    /// <param name="type">The <see cref="Type"/> to test.</param>
    /// <returns><see langword="true"/> if the <see cref="Type"/> can start a chain; otherwise
    /// <see langword="false"/>.</returns>
    public static bool IsChainable(this Type type)
    {
        return StructureTypes.TryGetValue(type, out var structureType) &&
               (Extenders.ContainsKey(structureType) || Extensions.ContainsKey(structureType));
    }

    /// <summary>
    /// Whether the current <see cref="StructureType"/> can extend the <paramref name="chain"/>.
    /// </summary>
    /// <param name="next">The <see cref="StructureType"/> to test.</param>
    /// <param name="chain">The <see cref="StructureType"/> of the chain.</param>
    /// <returns><see langword="true"/> if the <see cref="StructureType"/> can extend the <paramref name="chain"/>; otherwise, false.</returns>
    /// <seealso cref="CanBeExtendedBy(Silk.Net.Vulkan.StructureType,Silk.Net.Vulkan.StructureType)"/>
    public static bool CanExtend(this StructureType next, StructureType chain)
    {
        return Extensions.TryGetValue(next, out var extensions) && extensions.Contains(chain);
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
            StructureTypes.TryGetValue(next, out var nextType) &&
            StructureTypes.TryGetValue(chain, out var chainType) &&
            Extensions.TryGetValue(nextType, out var extensions) &&
            extensions.Contains(chainType);
    }

    /// <summary>
    /// Whether the current <paramref name="chain"/> can be extended by the <paramref name="next"/> <see cref="StructureType"/>.
    /// </summary>
    /// <param name="chain">The <see cref="StructureType"/> of the chain.</param>
    /// <param name="next">The <see cref="StructureType"/> to test.</param>
    /// <returns><see langword="true"/> if the <paramref name="chain"/> can be extended the <paramref name="chain"/>; otherwise, false.</returns>
    /// <seealso cref="CanExtend(Silk.Net.Vulkan.StructureType,Silk.Net.Vulkan.StructureType)"/>
    public static bool CanBeExtendedBy(this StructureType chain, StructureType next)
    {
        return Extenders.TryGetValue(chain, out var extenders) && extenders.Contains(next);
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
            StructureTypes.TryGetValue(next, out var nextType) &&
            StructureTypes.TryGetValue(chain, out var chainType) &&
            Extenders.TryGetValue(chainType, out var extenders) &&
            extenders.Contains(nextType);
    }
}
