namespace Silk.Net.Vulkan;

/// <summary>
/// Header struct of all <see cref="IChainable"/> structs.
/// </summary>
/// <remarks>
/// <para>Any pointer to a structure marked as <see cref="IChainable"/> can safely be cast to a pointer to this type.</para>
/// <para>In particular, this means that the <c>void* PNext</c> field can always be safely cast to <c>Chain*</c>, providing
/// access to the `SType` and `PNext` fields.
/// </para>
/// </remarks>
public struct Chain : IChainable
{
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
            }
        };
    
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
            }
        };

    /// <summary>
    /// Provides a mapping from the <see cref="StructureType"/> to the corresponding <see cref="Type"/>.
    /// </summary>
    public static readonly IReadOnlyDictionary<StructureType, Type> ClrTypes =
        new Dictionary<StructureType, Type>
        {
            [StructureType.DeviceCreateInfo] = typeof(DeviceCreateInfo),
            [StructureType.PhysicalDeviceFeatures2] = typeof(PhysicalDeviceFeatures2),
            [StructureType.PhysicalDeviceDescriptorIndexingFeatures]= typeof(PhysicalDeviceDescriptorIndexingFeatures),
            [StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr] = typeof(PhysicalDeviceAccelerationStructureFeaturesKhr)
        };

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
        };

    /// <summary>
    /// The structure type.
    /// </summary>
    public StructureType SType;

    /// <summary>
    /// The next <see cref="IChainable"/> struct in the chain, if any; otherwise <see langword="null"/>.
    /// </summary>
    public unsafe Chain* PNext;

    /// <inheritdoc />
    /// <remarks>Note, this cannot coerce the type as 'guaranteed by the `IStructuredType` interface.</remarks>
    StructureType IStructuredType.StructureType()
    {
        return SType;
    }

    /// <inheritdoc />
    unsafe Chain* IChainable.PNext
    {
        get => (Chain*) PNext;
        set => PNext = value;
    }
}
