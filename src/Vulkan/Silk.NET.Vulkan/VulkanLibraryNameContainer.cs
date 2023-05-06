// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;

namespace Silk.NET.Vulkan
{
    /// <summary>
    /// Contains the library name of Vulkan.
    /// </summary>
    internal class VulkanLibraryNameContainer : SearchPathContainer
    {
        /// <inheritdoc />
        public override string[] Linux => new[] { "libvulkan.so.1" };

        /// <inheritdoc />
        public override string[] MacOS => new[] { "libvulkan.dylib", "libMoltenVK.dylib" };

        /// <inheritdoc />
        public override string[] Android => new[] { "libvulkan.so" };

        /// <inheritdoc />
        public override string[] IOS => new[] { "__Internal" };

        /// <inheritdoc />
        public override string[] Windows64 => new[] { "vulkan-1.dll" };

        /// <inheritdoc />
        public override string[] Windows86 => new[] { "vulkan-1.dll" };
    }
}
