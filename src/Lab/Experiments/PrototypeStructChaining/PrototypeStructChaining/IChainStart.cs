namespace Silk.Net.Vulkan;

/// <summary>
/// Marks a <see cref="IChainable">chainable</see> struct as being allowed at the start of a chain.
/// </summary>
/// <remarks><para>Any <see cref="IChainStart"/> will have a corresponding static `Chain(out var chain)`
/// convenience method.</para></remarks>
public interface IChainStart : IChainable
{
}