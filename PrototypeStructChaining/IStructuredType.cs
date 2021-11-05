namespace Silk.Net.Vulkan;

public interface IStructuredType
{
    /// <summary>
    /// Gets the structured type's <see cref="Vulkan.StructureType"/> enum value.
    /// </summary>
    /// <remarks>
    /// Retrieving the <see cref="Vulkan.StructureType"/> also coerces it to the correct value.
    /// </remarks>
    StructureType StructureType();
}