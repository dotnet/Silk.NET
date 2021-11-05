namespace Silk.Net.Vulkan;

/// <summary>
/// Generic interface indicating which chain this type can be added to.
/// </summary>
/// <typeparam name="TChain">A chain start structure.</typeparam>
public interface IExtendsChain<out TChain> : IChainable
    where TChain : IChainable
{
}