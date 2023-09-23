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
    [NativeName("Name", "WGPUSharedTextureMemoryDmaBufDescriptor")]
    public unsafe partial struct SharedTextureMemoryDmaBufDescriptor
    {
        public SharedTextureMemoryDmaBufDescriptor
        (
            ChainedStruct? chain = null,
            int? memoryFD = null,
            ulong? allocationSize = null,
            ulong? drmModifier = null,
            nuint? planeCount = null,
            ulong* planeOffsets = null,
            uint* planeStrides = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (memoryFD is not null)
            {
                MemoryFD = memoryFD.Value;
            }

            if (allocationSize is not null)
            {
                AllocationSize = allocationSize.Value;
            }

            if (drmModifier is not null)
            {
                DrmModifier = drmModifier.Value;
            }

            if (planeCount is not null)
            {
                PlaneCount = planeCount.Value;
            }

            if (planeOffsets is not null)
            {
                PlaneOffsets = planeOffsets;
            }

            if (planeStrides is not null)
            {
                PlaneStrides = planeStrides;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "memoryFD")]
        public int MemoryFD;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "allocationSize")]
        public ulong AllocationSize;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "drmModifier")]
        public ulong DrmModifier;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "planeCount")]
        public nuint PlaneCount;

        [NativeName("Type", "const uint64_t *")]
        [NativeName("Type.Name", "const uint64_t *")]
        [NativeName("Name", "planeOffsets")]
        public ulong* PlaneOffsets;

        [NativeName("Type", "const uint32_t *")]
        [NativeName("Type.Name", "const uint32_t *")]
        [NativeName("Name", "planeStrides")]
        public uint* PlaneStrides;
    }
}
