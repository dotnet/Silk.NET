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
    [NativeName("Name", "WGPUBufferBindingLayout")]
    public unsafe partial struct BufferBindingLayout
    {
        public BufferBindingLayout
        (
            ChainedStruct* nextInChain = null,
            BufferBindingType? type = null,
            Silk.NET.Core.Bool32? hasDynamicOffset = null,
            ulong? minBindingSize = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (type is not null)
            {
                Type = type.Value;
            }

            if (hasDynamicOffset is not null)
            {
                HasDynamicOffset = hasDynamicOffset.Value;
            }

            if (minBindingSize is not null)
            {
                MinBindingSize = minBindingSize.Value;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUBufferBindingType")]
        [NativeName("Type.Name", "WGPUBufferBindingType")]
        [NativeName("Name", "type")]
        public BufferBindingType Type;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "hasDynamicOffset")]
        public Silk.NET.Core.Bool32 HasDynamicOffset;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "minBindingSize")]
        public ulong MinBindingSize;
    }
}
