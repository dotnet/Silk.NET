namespace Silk.Net.Vulkan;

public struct PhysicalDeviceDescriptorIndexingFeatures : IExtendsDeviceCreateInfoChain,
    IExtendsPhysicalDeviceFeatures2Chain
{
    /// <summary></summary>
    public StructureType SType;

    /// <summary></summary>
    public unsafe void* PNext;

    /// <summary></summary>
    public Bool32 ShaderInputAttachmentArrayDynamicIndexing;

    // NOTE Truncated for example

    public unsafe PhysicalDeviceDescriptorIndexingFeatures(
        StructureType? sType = StructureType.PhysicalDeviceDescriptorIndexingFeaturesExt,
        void* pNext = null,
        Bool32? shaderInputAttachmentArrayDynamicIndexing = null)
        : this()
    {
        if (sType.HasValue)
            SType = sType.Value;
        if ((IntPtr) pNext != IntPtr.Zero)
            PNext = pNext;
        if (shaderInputAttachmentArrayDynamicIndexing.HasValue)
            ShaderInputAttachmentArrayDynamicIndexing = shaderInputAttachmentArrayDynamicIndexing.Value;

        // NOTE Truncated for example
    }

    #region Chaining Support
    public static unsafe ref PhysicalDeviceDescriptorIndexingFeatures Chain(out PhysicalDeviceDescriptorIndexingFeatures capture)
    {
        capture = new PhysicalDeviceDescriptorIndexingFeatures(StructureType.PhysicalDeviceDescriptorIndexingFeatures);
        return ref capture;
    }

    public void End() => SType = StructureType.PhysicalDeviceDescriptorIndexingFeatures;

    public unsafe ref T SetNext<T>(ref T capture) where T : struct, IExtendsPhysicalDeviceFeatures2Chain
    {
        SType = StructureType.PhysicalDeviceDescriptorIndexingFeatures;
        var reference = __makeref(capture);
        PNext = (void*) *(IntPtr*) &reference;
        return ref capture;
    }

    public unsafe ref T CreateNext<T>(out T capture) where T : struct, IExtendsPhysicalDeviceFeatures2Chain
    {
        SType = StructureType.PhysicalDeviceDescriptorIndexingFeatures;
        capture = default;
        var reference = __makeref(capture);
        PNext = (void*) *(IntPtr*) &reference;
        return ref capture;
    }

    #endregion
}