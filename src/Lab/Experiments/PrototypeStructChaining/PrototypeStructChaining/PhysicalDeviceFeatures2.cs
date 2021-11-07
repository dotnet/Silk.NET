namespace Silk.Net.Vulkan;

public struct PhysicalDeviceFeatures2 :
    IChainStart,
    IExtendsChain<DeviceCreateInfo>
{
    public StructureType SType;
    public unsafe void* PNext;
    public PhysicalDeviceFeatures Features;

    public unsafe PhysicalDeviceFeatures2(
        StructureType? sType = StructureType.PhysicalDeviceFeatures2,
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

    /// <summary>
    /// Convenience method to start a chain.
    /// </summary>
    /// <param name="capture">The newly created chain root</param>
    /// <returns>A reference to the newly created chain.</returns>
    public static unsafe ref PhysicalDeviceFeatures2 Chain(
        out PhysicalDeviceFeatures2 capture)
    {
        capture = new PhysicalDeviceFeatures2(StructureType.PhysicalDeviceFeatures2);
        return ref capture;
    }

    /// <inheritdoc />
    StructureType IStructuredType.StructureType()
    {
        return SType = StructureType.PhysicalDeviceFeatures2;
    }

    #endregion
}