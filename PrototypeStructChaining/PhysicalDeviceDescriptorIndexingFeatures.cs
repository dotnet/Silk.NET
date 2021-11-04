namespace Silk.Net.Vulkan;

public struct PhysicalDeviceDescriptorIndexingFeatures :
    IChainable<PhysicalDeviceAccelerationStructureFeaturesKHR>
{
    /// <summary></summary>
    public StructureType SType;

    /// <summary></summary>
    public unsafe void* PNext;

    /// <summary></summary>
    public bool ShaderInputAttachmentArrayDynamicIndexing;

    // NOTE Truncated for example

    public unsafe PhysicalDeviceDescriptorIndexingFeatures(
        StructureType? sType = StructureType.PhysicalDeviceDescriptorIndexingFeaturesExt,
        void* pNext = null,
        bool? shaderInputAttachmentArrayDynamicIndexing = null)
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

    public static unsafe ref PhysicalDeviceDescriptorIndexingFeatures Chain(
        out PhysicalDeviceDescriptorIndexingFeatures capture)
    {
        capture = new PhysicalDeviceDescriptorIndexingFeatures(
            StructureType.PhysicalDeviceDescriptorIndexingFeaturesExt);
        return ref capture;
    }

    public unsafe void SetNext(void* next = default)
    {
        SType = StructureType.PhysicalDeviceDescriptorIndexingFeaturesExt;
        PNext = next;
    }

    #endregion
}