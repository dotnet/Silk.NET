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
    [NativeName("Name", "WGPUSharedBufferMemoryProperties")]
    public unsafe partial struct SharedBufferMemoryProperties
    {
        public SharedBufferMemoryProperties
        (
            ChainedStructOut* nextInChain = null,
            Silk.NET.WebGPU.BufferUsage? usage = null,
            ulong? size = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (usage is not null)
            {
                Usage = usage.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStructOut *")]
        [NativeName("Type.Name", "WGPUChainedStructOut *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStructOut* NextInChain;

        [NativeName("Type", "WGPUBufferUsageFlags")]
        [NativeName("Type.Name", "WGPUBufferUsageFlags")]
        [NativeName("Name", "usage")]
        public Silk.NET.WebGPU.BufferUsage Usage;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "size")]
        public ulong Size;
    }
}
