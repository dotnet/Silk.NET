using System.Runtime.CompilerServices;

namespace Silk.Net.Vulkan;

public static class ChainExtensions
{
    /// <summary>
    /// Sets the next structure in a chain.
    /// </summary>
    /// <param name="chain">The current chain</param>
    /// <param name="capture">The next value in the chain</param>
    /// <typeparam name="TChain">The type of the current chain</typeparam>
    /// <typeparam name="TNext">The type of the next value</typeparam>
    /// <returns>A reference to the next value in the chain</returns>
    /// <remarks>
    /// <para>WARNING: The supplied value will  have it's own next ptr nulled.</para>
    /// <para>Note that both the supplied chain, and the next value will have their `SType` correctly set.</para>
    /// <para>To use</para>
    /// <code>
    /// var indexingFeatures = new PhysicalDeviceDescriptorIndexingFeatures
    /// {
    ///     ShaderInputAttachmentArrayDynamicIndexing = true
    /// };
    /// var accelerationStructureFeaturesKhr = new PhysicalDeviceAccelerationStructureFeaturesKHR
    /// {
    ///     AccelerationStructure = true
    /// };
    /// 
    /// PhysicalDeviceFeatures2
    ///     .Chain(out var features2)
    ///     .SetNext(ref indexingFeatures)
    ///     .SetNext(ref accelerationStructureFeaturesKhr);
    /// </code>
    /// </remarks>
    public static unsafe ref TNext SetNext<TChain, TNext>(this ref TChain chain, ref TNext capture)
        where TChain : struct, IChainable<TNext>
        where TNext : struct, IChainable
    {
        capture.SetNext();
        var reference = Unsafe.AsPointer(ref capture);
        chain.SetNext((void*) *(IntPtr*) &reference);
        return ref capture;
    }

    /// <summary>
    /// Creates the next structure in a chain.
    /// </summary>
    /// <param name="chain">The current chain</param>
    /// <param name="capture">The next value created in the chain</param>
    /// <typeparam name="TChain">The type of the current chain</typeparam>
    /// <typeparam name="TNext">The type of the next value</typeparam>
    /// <returns>A reference to the newly created next value in the chain</returns>
    /// <remarks>
    /// <para>Note that both the supplied chain, and the newly created next value will have their `SType` correctly set</para>
    /// <para>To use specify the output type required, e.g.:</para>
    /// <code>
    /// PhysicalDeviceFeatures2
    ///     .Chain(out var features2)
    ///     .CreateNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures)
    ///     .CreateNext(out PhysicalDeviceAccelerationStructureFeaturesKHR accelerationStructureFeaturesKhr);
    /// </code>
    /// </remarks>
    public static unsafe ref TNext CreateNext<TChain, TNext>(this ref TChain chain, out TNext capture)
        where TChain : struct, IChainable<TNext>
        where TNext : struct, IChainable
    {
        capture = default;
        capture.SetNext();
        var reference = Unsafe.AsPointer(ref capture);
        chain.SetNext((void*) *(IntPtr*) &reference);
        return ref capture;
    }
}