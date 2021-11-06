namespace Silk.Net.Vulkan;

/// <summary>
/// Header struct of all chainable structs.
/// </summary>
public struct Chain : IChainable
{
    public StructureType SType;
    public unsafe Chain* PNext;

    /// <inheritdoc />
    /// <remarks>Note, this doesn't coerce the type.</remarks>
    StructureType IStructuredType.StructureType()
    {
        return SType;
    }
}