namespace Silk.Net.Vulkan;

public struct DeviceCreateInfo :
    IChainable<PhysicalDeviceFeatures2>,
    IChainable<PhysicalDeviceDescriptorIndexingFeatures>,
    IChainable<PhysicalDeviceAccelerationStructureFeaturesKHR>
{
    /// <summary></summary>
    public StructureType SType;

    /// <summary></summary>
    public unsafe void* PNext;

    /// <summary></summary>
    public uint Flags;

    // NOTE Truncated for example


    public unsafe DeviceCreateInfo(
        StructureType? sType = StructureType.DeviceCreateInfo,
        void* pNext = null,
        uint? flags = null)
        : this()
    {
        if (sType.HasValue)
            SType = sType.Value;
        if ((IntPtr) pNext != IntPtr.Zero)
            PNext = pNext;
        if (flags.HasValue)
            Flags = flags.Value;
        // NOTE Truncated for example
    }


    #region Chaining Support

    public static unsafe ref DeviceCreateInfo Chain(out DeviceCreateInfo capture)
    {
        capture = new DeviceCreateInfo(StructureType.DeviceCreateInfo);
        return ref capture;
    }

    public unsafe void SetNext(void* next = default)
    {
        SType = StructureType.DeviceCreateInfo;
        PNext = next;
    }

    #endregion
}