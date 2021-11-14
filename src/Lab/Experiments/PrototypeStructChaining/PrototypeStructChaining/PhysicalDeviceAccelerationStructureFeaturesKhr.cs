namespace Silk.NET.Vulkan;

public struct PhysicalDeviceAccelerationStructureFeaturesKhr :
    IExtendsChain<PhysicalDeviceFeatures2>,
    IExtendsChain<DeviceCreateInfo>
{
    /// <summary></summary>
    public StructureType SType;

    /// <summary></summary>
    public unsafe void* PNext;

    /// <summary></summary>
    public bool AccelerationStructure;

    // NOTE Truncated for example

    public unsafe PhysicalDeviceAccelerationStructureFeaturesKhr(
        StructureType? sType = StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr,
        void* pNext = null,
        bool? accelerationStructure = null)
        : this()
    {
        if (sType.HasValue)
            SType = sType.Value;
        if ((IntPtr) pNext != IntPtr.Zero)
            PNext = pNext;
        if (accelerationStructure.HasValue)
            AccelerationStructure = accelerationStructure.Value;

        // NOTE Truncated for example
    }

    #region Chaining Support

    /// <inheritdoc />
    StructureType IStructuredType.StructureType()
    {
        return SType = StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr;
    }

    /// <inheritdoc />
    unsafe BaseInStructure* IChainable.PNext
    {
        get => (BaseInStructure*) PNext;
        set => PNext = value;
    }

    #endregion
}