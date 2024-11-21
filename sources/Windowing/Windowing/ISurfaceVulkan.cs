namespace Silk.NET.Windowing;

/// <summary>
/// The Vulkan component of a <see cref="Surface" />.
/// </summary>
public interface ISurfaceVulkan
{
    /// <summary>
    /// Gets or sets a value indicating whether the Vulkan component is enabled for this surface.
    /// </summary>
    /// <remarks>
    /// This can only be set during the <see cref="ISurfaceApplication.Initialize{TSurface}" /> method.
    /// </remarks>
    bool IsEnabled { get; set; }

    /// <summary>
    /// Creates a <c>VkSurface</c> for this surface.
    /// </summary>
    /// <param name="instance">
    /// The <c>VkInstance</c> to use. Must have extensions specified in <see cref="GetRequiredExtensions" /> enabled.
    /// </param>
    /// <param name="allocator">The <c>VkAllocationCallbacks*</c> to use.</param>
    /// <remarks>
    /// This can only be executed once the <see cref="ISurfaceApplication.Initialize{TSurface}" /> method has returned.
    /// </remarks>
    /// <returns>The <c>VkSurface</c>.</returns>
    ulong CreateSurface(nint instance, Ptr allocator);

    /// <summary>
    /// Gets the instance extensions that are required to be enabled on instances used for <see cref="CreateSurface" />.
    /// </summary>
    /// <param name="count">The number of pointers in the return value.</param>
    /// <returns>
    /// The required extensions as a native pointer. The pointer is guaranteed to share the lifetime of the surface.
    /// </returns>
    Ptr2D<sbyte> GetRequiredExtensions(out uint count);
}
