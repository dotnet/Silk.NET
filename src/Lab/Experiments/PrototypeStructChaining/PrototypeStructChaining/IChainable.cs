namespace Silk.Net.Vulkan;

/// <summary>
/// Base interface for any struct that has can set the next value.
/// </summary>
/// <remarks><para>Note that any structure marked <see cref="IChainable"/> must start with a
/// <see cref="StructureType"/> and a <c>void*</c> field. So that a pointer to it can be coerced
/// to a pointer to a <see cref="Chain"/>.</para></remarks>
public interface IChainable : IStructuredType
{
}