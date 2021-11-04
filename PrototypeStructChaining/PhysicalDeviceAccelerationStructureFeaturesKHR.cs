namespace Silk.Net.Vulkan;

public struct PhysicalDeviceAccelerationStructureFeaturesKHR :
    IChainable<PhysicalDeviceDescriptorIndexingFeatures>
{
    /// <summary></summary>
    public StructureType SType;

    /// <summary></summary>
    public unsafe void* PNext;

    /// <summary></summary>
    public bool AccelerationStructure;

    // NOTE Truncated for example

    public unsafe PhysicalDeviceAccelerationStructureFeaturesKHR(
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

    public static unsafe ref PhysicalDeviceAccelerationStructureFeaturesKHR Chain(
        out PhysicalDeviceAccelerationStructureFeaturesKHR capture)
    {
        capture = new PhysicalDeviceAccelerationStructureFeaturesKHR(StructureType
            .PhysicalDeviceAccelerationStructureFeaturesKhr);
        return ref capture;
    }

    public unsafe void SetNext(void* next = default)
    {
        SType = StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr;
        PNext = next;
    }

    #endregion
}