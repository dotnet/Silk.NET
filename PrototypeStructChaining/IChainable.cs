namespace Silk.Net.Vulkan;

/// <summary>
/// Base interface for any struct that has can set the next value.
/// </summary>
public interface IChainable
{
    unsafe void SetNext(void* next = default);
}

/// <summary>
/// Generic interface indicating which structs can be set in the `PNext` value.
/// </summary>
/// <typeparam name="TNext">A valid next structure</typeparam>
public interface IChainable<out TNext> : IChainable
    where TNext : IChainable
{
}