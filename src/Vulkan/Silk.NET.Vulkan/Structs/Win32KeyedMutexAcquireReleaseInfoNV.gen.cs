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
    public unsafe struct Win32KeyedMutexAcquireReleaseInfoNV
    {
        public Win32KeyedMutexAcquireReleaseInfoNV
        (
            StructureType sType = StructureType.Win32KeyedMutexAcquireReleaseInfoNV,
            void* pNext = default,
            uint acquireCount = default,
            DeviceMemory* pAcquireSyncs = default,
            ulong* pAcquireKeys = default,
            uint* pAcquireTimeoutMilliseconds = default,
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
           PAcquireTimeoutMilliseconds = pAcquireTimeoutMilliseconds;
           ReleaseCount = releaseCount;
           PReleaseSyncs = pReleaseSyncs;
           PReleaseKeys = pReleaseKeys;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint AcquireCount;
/// <summary></summary>
        public DeviceMemory* PAcquireSyncs;
/// <summary></summary>
        public ulong* PAcquireKeys;
/// <summary></summary>
        public uint* PAcquireTimeoutMilliseconds;
/// <summary></summary>
        public uint ReleaseCount;
/// <summary></summary>
        public DeviceMemory* PReleaseSyncs;
/// <summary></summary>
        public ulong* PReleaseKeys;
    }
}
