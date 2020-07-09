// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkInstanceCreateInfo")]
    public unsafe struct InstanceCreateInfo
    {
        public InstanceCreateInfo
        (
            StructureType sType = StructureType.InstanceCreateInfo,
            void* pNext = default,
            uint flags = default,
            ApplicationInfo* pApplicationInfo = default,
            uint enabledLayerCount = default,
            byte** ppEnabledLayerNames = default,
            uint enabledExtensionCount = default,
            byte** ppEnabledExtensionNames = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           PApplicationInfo = pApplicationInfo;
           EnabledLayerCount = enabledLayerCount;
           PpEnabledLayerNames = ppEnabledLayerNames;
           EnabledExtensionCount = enabledExtensionCount;
           PpEnabledExtensionNames = ppEnabledExtensionNames;
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
