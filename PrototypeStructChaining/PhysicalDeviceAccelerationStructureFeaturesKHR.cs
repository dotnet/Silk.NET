namespace Silk.Net.Vulkan;

public struct PhysicalDeviceAccelerationStructureFeaturesKHR : IExtendsDeviceCreateInfoChain,
    IExtendsPhysicalDeviceFeatures2Chain
{
    /// <summary></summary>
    public StructureType SType;

    /// <summary></summary>
    public unsafe void* PNext;

    /// <summary></summary>
    public Bool32 AccelerationStructure;

    // NOTE Truncated for example

    public unsafe PhysicalDeviceAccelerationStructureFeaturesKHR(
        StructureType? sType = StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr,
        void* pNext = null,
        Bool32? accelerationStructure = null)
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
    public static unsafe ref PhysicalDeviceAccelerationStructureFeaturesKHR Chain(out PhysicalDeviceAccelerationStructureFeaturesKHR capture)
    {
        capture = new PhysicalDeviceAccelerationStructureFeaturesKHR(StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr);
        return ref capture;
    }

    public void End() => SType = StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr;

    public unsafe ref T SetNext<T>(ref T capture) where T : struct, IExtendsPhysicalDeviceFeatures2Chain
    {
        SType = StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr;
        var reference = __makeref(capture);
        PNext = (void*) *(IntPtr*) &reference;
        return ref capture;
    }

    public unsafe ref T CreateNext<T>(out T capture) where T : struct, IExtendsPhysicalDeviceFeatures2Chain
    {
        SType = StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr;
        capture = default;
        var reference = __makeref(capture);
        PNext = (void*) *(IntPtr*) &reference;
        return ref capture;
    }

    #endregion
}