namespace Silk.Net.Vulkan;

/// <summary>
/// Base interface for any struct that has a <see cref="StructureType"/> field called `SType`, that must be correctly
/// set when passing into the Vulkan API.
/// </summary>
public interface IStructuredType
{
    /// <summary>
    /// Gets the structured type's <see cref="Vulkan.StructureType"/> enum value.
    /// </summary>
    /// <remarks>
    /// Retrieving the <see cref="Vulkan.StructureType"/> also ensures it is set to the correct value.
    /// </remarks>
    StructureType StructureType();
}
