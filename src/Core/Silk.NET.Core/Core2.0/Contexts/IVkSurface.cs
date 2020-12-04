// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.GLFW;

namespace Silk.NET.Core.Contexts
{
    public interface IVkSurface
    {
        /// <summary>
        /// Create a Vulkan surface.
        /// </summary>
        /// <param name="instance">The Vulkan instance to create a surface for.</param>
        /// <param name="allocator">A custom Vulkan allocator. Can be omitted by passing null.</param>
        /// <typeparam name="T">Allocator type</typeparam>
        /// <returns>A handle to the Vulkan surface created</returns>
        unsafe VkHandle Create<T>(VkHandle instance, T* allocator) where T : unmanaged;

        /// <summary>
        /// Get the extensions required for Vulkan to work on this platform.
        /// </summary>
        /// <param name="count">The number of extensions in the returned array</param>
        /// <returns>An array of strings, containing names for all required extensions</returns>
        unsafe char** GetRequiredExtensions(out uint count);
    }
}
