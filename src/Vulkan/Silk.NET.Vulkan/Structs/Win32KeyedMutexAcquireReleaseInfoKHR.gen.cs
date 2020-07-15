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
    [NativeName("Name", "VkWin32KeyedMutexAcquireReleaseInfoKHR")]
    public unsafe partial struct Win32KeyedMutexAcquireReleaseInfoKHR
    {
        public Win32KeyedMutexAcquireReleaseInfoKHR
        (
            StructureType sType = StructureType.Win32KeyedMutexAcquireReleaseInfoKhr,
            void* pNext = default,
            uint acquireCount = default,
            DeviceMemory* pAcquireSyncs = default,
            ulong* pAcquireKeys = default,
            uint* pAcquireTimeouts = default,
            uint releaseCount = default,
            DeviceMemory* pReleaseSyncs = default,
            ulong* pReleaseKeys = default
        )
        {
            SType = sType;
            PNext = pNext;
            AcquireCount = acquireCount;
            PAcquireSyncs = pAcquireSyncs;
            PAcquireKeys = pAcquireKeys;
            PAcquireTimeouts = pAcquireTimeouts;
            ReleaseCount = releaseCount;
            PReleaseSyncs = pReleaseSyncs;
            PReleaseKeys = pReleaseKeys;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "acquireCount")]
        public uint AcquireCount;
/// <summary></summary>
        [NativeName("Type", "VkDeviceMemory*")]
        [NativeName("Type.Name", "VkDeviceMemory")]
        [NativeName("Name", "pAcquireSyncs")]
        public DeviceMemory* PAcquireSyncs;
/// <summary></summary>
        [NativeName("Type", "uint64_t*")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "pAcquireKeys")]
        public ulong* PAcquireKeys;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pAcquireTimeouts")]
        public uint* PAcquireTimeouts;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "releaseCount")]
        public uint ReleaseCount;
/// <summary></summary>
        [NativeName("Type", "VkDeviceMemory*")]
        [NativeName("Type.Name", "VkDeviceMemory")]
        [NativeName("Name", "pReleaseSyncs")]
        public DeviceMemory* PReleaseSyncs;
/// <summary></summary>
        [NativeName("Type", "uint64_t*")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "pReleaseKeys")]
        public ulong* PReleaseKeys;
    }
}
