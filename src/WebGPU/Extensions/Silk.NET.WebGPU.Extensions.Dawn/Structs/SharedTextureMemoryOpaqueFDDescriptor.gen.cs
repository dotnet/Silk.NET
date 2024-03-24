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

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [NativeName("Name", "WGPUSharedTextureMemoryOpaqueFDDescriptor")]
    public unsafe partial struct SharedTextureMemoryOpaqueFDDescriptor
    {
        public SharedTextureMemoryOpaqueFDDescriptor
        (
            ChainedStruct? chain = null,
            void* vkImageCreateInfo = null,
            int? memoryFD = null,
            uint? memoryTypeIndex = null,
            ulong? allocationSize = null,
            Silk.NET.Core.Bool32? dedicatedAllocation = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (vkImageCreateInfo is not null)
            {
                VkImageCreateInfo = vkImageCreateInfo;
            }

            if (memoryFD is not null)
            {
                MemoryFD = memoryFD.Value;
            }

            if (memoryTypeIndex is not null)
            {
                MemoryTypeIndex = memoryTypeIndex.Value;
            }

            if (allocationSize is not null)
            {
                AllocationSize = allocationSize.Value;
            }

            if (dedicatedAllocation is not null)
            {
                DedicatedAllocation = dedicatedAllocation.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "const void *")]
        [NativeName("Type.Name", "const void *")]
        [NativeName("Name", "vkImageCreateInfo")]
        public void* VkImageCreateInfo;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "memoryFD")]
        public int MemoryFD;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "memoryTypeIndex")]
        public uint MemoryTypeIndex;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "allocationSize")]
        public ulong AllocationSize;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "dedicatedAllocation")]
        public Silk.NET.Core.Bool32 DedicatedAllocation;
    }
}
