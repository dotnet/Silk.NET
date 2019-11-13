// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using AdvancedDLSupport.Loaders;

namespace Silk.NET.Vulkan
{
    public class VkLoader : ISymbolLoader
    {
        public bool IsExtensionLoader { get; }
        public Vk Vulkan { get; internal set; }
        public ISymbolLoader BaseLoader { get; }
        public VkLoader(Vk vk, ISymbolLoader baseLoader)
        {
            IsExtensionLoader = true;
            BaseLoader = baseLoader;
            Vulkan = vk;
        }

        public VkLoader(ISymbolLoader defaultLoader)
        {
            IsExtensionLoader = false;
            BaseLoader = defaultLoader;
            Vulkan = null;
        }

        public IntPtr LoadSymbol(IntPtr library, string symbolName)
        {
            IntPtr sym;
            try
            {
                sym = BaseLoader.LoadSymbol(library, symbolName);
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
            
            throw new EntryPointNotFoundException();
        }
    }
}
