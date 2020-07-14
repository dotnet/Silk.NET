// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;

namespace Silk.NET.OpenXR
{
    internal readonly struct XrExtensionLoaderSource
    {
        private readonly XR _vk;
        private readonly Dictionary<ulong, XrExtensionLoader> _cache;

        public XrExtensionLoaderSource(XR vk)
        {
            _vk = vk;
            _cache = new Dictionary<ulong, XrExtensionLoader>();
        }

        private XrExtensionLoader Add(Instance? instance)
        {
            XrExtensionLoader ret;
            _cache.Add
            (
                instance?.Handle ?? 0,
                ret = new XrExtensionLoader(instance, _vk)
            );

            return ret;
        }

        public XrExtensionLoader Get(Instance? instance) => _cache.TryGetValue
            (instance?.Handle ?? 0, out var val)
            ? val
            : Add(instance);
    }
}
