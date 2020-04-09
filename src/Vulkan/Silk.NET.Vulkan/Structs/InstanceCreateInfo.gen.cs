// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Flags;
/// <summary></summary>
        public ApplicationInfo* PApplicationInfo;
/// <summary></summary>
        public uint EnabledLayerCount;
/// <summary></summary>
        public byte** PpEnabledLayerNames;
/// <summary></summary>
        public uint EnabledExtensionCount;
/// <summary></summary>
        public byte** PpEnabledExtensionNames;
    }
}
