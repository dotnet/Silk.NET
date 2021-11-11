namespace Silk.NET.Vulkan;

/// <summary>
/// Header struct of all <see cref="IChainable"/> structs.
/// </summary>
/// <remarks>
/// <para>Any pointer to a structure marked as <see cref="IChainable"/> can safely be cast to a pointer to this type.</para>
/// <para>In particular, this means that the <c>void* PNext</c> field can always be safely cast to <c>BaseInStructure*</c>, providing
/// access to the `SType` and `PNext` fields.
/// </para>
/// </remarks>
public struct BaseInStructure : IChainable
{
    /// <summary>
    /// The structure type.
    /// </summary>
    public StructureType SType;

    /// <summary>
    /// The next <see cref="IChainable"/> struct in the chain, if any; otherwise <see langword="null"/>.
    /// </summary>
    public unsafe BaseInStructure* PNext;

    /// <inheritdoc />
    /// <remarks>Note, this cannot coerce the type as 'guaranteed by the `IStructuredType` interface.</remarks>
    StructureType IStructuredType.StructureType()
    {
        return SType;
    }

    /// <inheritdoc />
    unsafe BaseInStructure* IChainable.PNext
    {
        get => (BaseInStructure*) PNext;
        set => PNext = value;
    }
}
