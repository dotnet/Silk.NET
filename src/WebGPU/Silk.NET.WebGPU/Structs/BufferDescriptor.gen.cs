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

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUBufferDescriptor")]
    public unsafe partial struct BufferDescriptor
    {
        public BufferDescriptor
        (
            ChainedStruct* nextInChain = null,
            byte* label = null,
            Silk.NET.WebGPU.BufferUsage? usage = null,
            ulong? size = null,
            Silk.NET.Core.Bool32? mappedAtCreation = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (label is not null)
            {
                Label = label;
            }

            if (usage is not null)
            {
                Usage = usage.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (mappedAtCreation is not null)
            {
                MappedAtCreation = mappedAtCreation.Value;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "label")]
        public byte* Label;

        [NativeName("Type", "WGPUBufferUsageFlags")]
        [NativeName("Type.Name", "WGPUBufferUsageFlags")]
        [NativeName("Name", "usage")]
        public Silk.NET.WebGPU.BufferUsage Usage;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "size")]
        public ulong Size;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "mappedAtCreation")]
        public Silk.NET.Core.Bool32 MappedAtCreation;
    }
}
