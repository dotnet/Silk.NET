// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkInstanceCreateInfo")]
    public unsafe partial struct InstanceCreateInfo
    {
        public InstanceCreateInfo
        (
            StructureType? sType = StructureType.InstanceCreateInfo,
            void* pNext = null,
            uint? flags = null,
            ApplicationInfo* pApplicationInfo = null,
            uint? enabledLayerCount = null,
            byte** ppEnabledLayerNames = null,
            uint? enabledExtensionCount = null,
            byte** ppEnabledExtensionNames = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (pApplicationInfo is not null)
            {
                PApplicationInfo = pApplicationInfo;
            }

            if (enabledLayerCount is not null)
            {
                EnabledLayerCount = enabledLayerCount.Value;
            }

            if (ppEnabledLayerNames is not null)
            {
                PpEnabledLayerNames = ppEnabledLayerNames;
            }

            if (enabledExtensionCount is not null)
            {
                EnabledExtensionCount = enabledExtensionCount.Value;
            }

            if (ppEnabledExtensionNames is not null)
            {
                PpEnabledExtensionNames = ppEnabledExtensionNames;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkInstanceCreateFlags")]
        [NativeName("Type.Name", "VkInstanceCreateFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkApplicationInfo*")]
        [NativeName("Type.Name", "VkApplicationInfo")]
        [NativeName("Name", "pApplicationInfo")]
        public ApplicationInfo* PApplicationInfo;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "enabledLayerCount")]
        public uint EnabledLayerCount;
/// <summary></summary>
        [NativeName("Type", "char**")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "ppEnabledLayerNames")]
        public byte** PpEnabledLayerNames;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "enabledExtensionCount")]
        public uint EnabledExtensionCount;
/// <summary></summary>
        [NativeName("Type", "char**")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "ppEnabledExtensionNames")]
        public byte** PpEnabledExtensionNames;
    }
}
