using System.Runtime.InteropServices;

namespace Silk.Net.Vulkan;

public struct PhysicalDeviceFeatures2 : IExtendsDeviceCreateInfoChain
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

    public void End() => SType = StructureType.PhysicalDeviceFeatures2;

    public unsafe ref T SetNext<T>(ref T capture) where T : struct, IExtendsPhysicalDeviceFeatures2Chain
    {
        SType = StructureType.PhysicalDeviceFeatures2;
        var reference = __makeref(capture);
        PNext = (void*) *(IntPtr*) &reference;
        return ref capture;
    }

    public unsafe ref T CreateNext<T>(out T capture) where T : struct, IExtendsPhysicalDeviceFeatures2Chain
    {
        SType = StructureType.PhysicalDeviceFeatures2;
        capture = default;
        var reference = __makeref(capture);
        PNext = (void*) *(IntPtr*) &reference;
        return ref capture;
    }

    #endregion
}