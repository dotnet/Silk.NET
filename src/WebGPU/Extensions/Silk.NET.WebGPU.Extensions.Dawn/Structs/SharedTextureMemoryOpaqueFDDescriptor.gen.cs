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
            int? memoryFD = null,
            ulong? allocationSize = null
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
    }
}
