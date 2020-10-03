// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Ultz.SuperInvoke.Loader;

namespace Silk.NET.Vulkan
{
    /// <summary>
    /// Library loader for the Vulkan API.
    /// </summary>
    public class VkLoader : LibraryLoader
    {
        /// <summary>
        /// The Vulkan instance.
        /// </summary>
        public Vk Vulkan { get; internal set; }

        /// <summary>
        /// The base library loader.
        /// </summary>
        public LibraryLoader BaseLoader { get; }

        /// <summary>
        /// Create a new Vulkan loader.
        /// </summary>
        /// <param name="defaultLoader">The default loader to use.</param>
        public VkLoader(LibraryLoader defaultLoader)
        {
            BaseLoader = defaultLoader;
            Vulkan = null;
        }

        /// <inheritdoc />
        protected override IntPtr CoreLoadNativeLibrary(string name) => BaseLoader.LoadNativeLibrary(name);

        /// <inheritdoc />
        protected override void CoreFreeNativeLibrary(IntPtr handle) => BaseLoader.FreeNativeLibrary(handle);

        /// <inheritdoc />
        protected override IntPtr CoreLoadFunctionPointer(IntPtr library, string symbolName)
        {
            IntPtr sym;
            try
            {
                sym = BaseLoader.LoadFunctionPointer(library, symbolName);
                if (sym != IntPtr.Zero)
                {
                    return sym;
                }
            }
            catch
            {
                // do nothing, just move on.
            }

            sym = Vulkan.GetInstanceProcAddr(default, symbolName).Value;
            if (sym != IntPtr.Zero)
            {
                return sym;
            }

            if (Vulkan.CurrentInstance.HasValue)
            {
                sym = Vulkan.GetInstanceProcAddr(Vulkan.CurrentInstance.Value, symbolName).Value;
                if (sym != IntPtr.Zero)
                {
                    return sym;
                }
            }

            if (Vulkan.CurrentDevice.HasValue)
            {
                sym = Vulkan.GetDeviceProcAddr(Vulkan.CurrentDevice.Value, symbolName).Value;
                if (sym != IntPtr.Zero)
                {
                    return sym;
                }
            }

            throw new EntryPointNotFoundException
            (
                $"Entry point \"{symbolName}\" not found. Note that instance extensions must be enabled in order to " +
                "load symbols correctly."
            );
        }
    }
}
