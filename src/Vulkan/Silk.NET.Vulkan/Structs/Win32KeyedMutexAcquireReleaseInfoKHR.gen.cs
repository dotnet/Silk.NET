// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkWin32KeyedMutexAcquireReleaseInfoKHR")]
    public unsafe partial struct Win32KeyedMutexAcquireReleaseInfoKHR : IExtendsChain<SubmitInfo>, IExtendsChain<SubmitInfo2KHR>
    {
        public Win32KeyedMutexAcquireReleaseInfoKHR
        (
            StructureType? sType = StructureType.Win32KeyedMutexAcquireReleaseInfoKhr,
            void* pNext = null,
            uint? acquireCount = null,
            DeviceMemory* pAcquireSyncs = null,
            ulong* pAcquireKeys = null,
            uint* pAcquireTimeouts = null,
            uint? releaseCount = null,
            DeviceMemory* pReleaseSyncs = null,
            ulong* pReleaseKeys = null
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

            if (acquireCount is not null)
            {
                AcquireCount = acquireCount.Value;
            }

            if (pAcquireSyncs is not null)
            {
                PAcquireSyncs = pAcquireSyncs;
            }

            if (pAcquireKeys is not null)
            {
                PAcquireKeys = pAcquireKeys;
            }

            if (pAcquireTimeouts is not null)
            {
                PAcquireTimeouts = pAcquireTimeouts;
            }

            if (releaseCount is not null)
            {
                ReleaseCount = releaseCount.Value;
            }

            if (pReleaseSyncs is not null)
            {
                PReleaseSyncs = pReleaseSyncs;
            }

            if (pReleaseKeys is not null)
            {
                PReleaseKeys = pReleaseKeys;
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.Win32KeyedMutexAcquireReleaseInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
