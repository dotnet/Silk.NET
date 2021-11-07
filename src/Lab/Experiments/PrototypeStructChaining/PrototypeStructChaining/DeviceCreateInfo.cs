namespace Silk.Net.Vulkan;

public struct DeviceCreateInfo : IChainStart
{
    /// <summary></summary>
    public StructureType SType;

    /// <summary></summary>
    public unsafe void* PNext;

    /// <summary></summary>
    public uint Flags;

    // NOTE Truncated for example


    public unsafe DeviceCreateInfo
    (
        StructureType? sType = StructureType.DeviceCreateInfo,
        void* pNext = null,
        uint? flags = null
    )
        : this()
    {
        if (sType.HasValue)
        {
            SType = sType.Value;
        }

        if ((IntPtr) pNext != IntPtr.Zero)
        {
            PNext = pNext;
        }

        if (flags.HasValue)
        {
            Flags = flags.Value;
        }
        // NOTE Truncated for example
    }

    #region Chaining Support

    /// <summary>
    /// Convenience method to start a chain.
    /// </summary>
    /// <param name="capture">The newly created chain root</param>
    /// <returns>A reference to the newly created chain.</returns>
    public static unsafe ref DeviceCreateInfo Chain
    (
        out DeviceCreateInfo capture
    )
    {
        capture = new DeviceCreateInfo(StructureType.DeviceCreateInfo);
        return ref capture;
    }

    /// <inheritdoc />
    StructureType IStructuredType.StructureType()
    {
        return SType = StructureType.DeviceCreateInfo;
    }

    /// <inheritdoc />
    unsafe Chain* IChainable.PNext
    {
        get => (Chain*) PNext;
        set => PNext = value;
    }

    #endregion
}
