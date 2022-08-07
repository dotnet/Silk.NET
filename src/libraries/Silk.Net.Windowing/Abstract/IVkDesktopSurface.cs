
namespace Silk.NET.Windowing
{
    public interface IVkSurface : ISurface
    {
        /// <summary>Enables Vulkan support for this surface.</summary>
        bool TryEnableVulkan();

        /// <summary>
        /// Create a Vulkan surface.
        /// </summary>
        /// <param name="instance">The Vulkan instance to create a surface for.</param>
        /// <param name="allocator">A custom Vulkan allocator. Can be omitted by passing null.</param>
        /// <returns>A handle to the Vulkan surface created</returns>
        unsafe ulong Create(nint instance, void* allocator)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the extensions required for Vulkan to work on this platform.
        /// </summary>
        /// <param name="count">The number of extensions in the returned array</param>
        /// <returns>An array of strings, containing names for all required extensions</returns>
        unsafe byte** GetRequiredExtensions(out uint count)
        {
            throw new NotImplementedException();
        }
    }
}