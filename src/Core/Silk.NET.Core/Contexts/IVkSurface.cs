// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Native;

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
        unsafe VkNonDispatchableHandle Create<T>(VkHandle instance, T* allocator) where T : unmanaged;

        /// <summary>
        /// Get the extensions required for Vulkan to work on this platform.
        /// </summary>
        /// <param name="count">The number of extensions in the returned array</param>
        /// <returns>An array of strings, containing names for all required extensions</returns>
        unsafe byte** GetRequiredExtensions(out uint count);
    }
}
