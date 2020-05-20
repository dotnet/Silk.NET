// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;

namespace Silk.NET.Vulkan
{
    internal readonly struct VkExtensionLoaderSource
    {
        private readonly Vk _vk;
        private readonly Dictionary<(IntPtr Instance, IntPtr Device), VkExtensionLoader> _cache;

        public VkExtensionLoaderSource(Vk vk)
        {
            _vk = vk;
            _cache = new Dictionary<(IntPtr Instance, IntPtr Device), VkExtensionLoader>();
        }

        private VkExtensionLoader Add(Instance? instance, Device? device)
        {
            VkExtensionLoader ret;
            _cache.Add
            (
                (instance?.Handle ?? IntPtr.Zero, device?.Handle ?? IntPtr.Zero),
                ret = new VkExtensionLoader(instance, device, _vk)
            );

            return ret;
        }

        public VkExtensionLoader Get(Instance? instance, Device? device) => _cache.TryGetValue
            ((instance?.Handle ?? IntPtr.Zero, device?.Handle ?? IntPtr.Zero), out var val)
            ? val
            : Add(instance, device);
    }
}
