using System.Runtime.InteropServices;

namespace Silk.Net.Vulkan;

public struct PhysicalDeviceFeatures2 :
    IChainable<PhysicalDeviceDescriptorIndexingFeatures>,
    IChainable<PhysicalDeviceAccelerationStructureFeaturesKHR>
{
    public StructureType SType;
    public unsafe void* PNext;
    public PhysicalDeviceFeatures Features;

    public unsafe PhysicalDeviceFeatures2(
        StructureType? sType = StructureType.PhysicalDeviceFeatures2Khr,
        void* pNext = null,
        PhysicalDeviceFeatures? features = null)
        : this()
    {
        if (sType.HasValue)
            SType = sType.Value;
        if ((IntPtr) pNext != IntPtr.Zero)
            PNext = pNext;
        if (!features.HasValue)
            return;
        Features = features.Value;
    }

    #region Chaining Support

    public static unsafe ref PhysicalDeviceFeatures2 Chain(out PhysicalDeviceFeatures2 capture)
    {
        capture = new PhysicalDeviceFeatures2(StructureType.PhysicalDeviceFeatures2);
        return ref capture;
    }

    public unsafe void SetNext(void* next = default)
    {
        SType = StructureType.PhysicalDeviceFeatures2;
        PNext = next;
    }

    #endregion
}