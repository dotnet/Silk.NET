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
    [NativeName("Name", "WGPUColorTargetState")]
    public unsafe partial struct ColorTargetState
    {
        public ColorTargetState
        (
            ChainedStruct* nextInChain = null,
            TextureFormat? format = null,
            BlendState* blend = null,
            Silk.NET.WebGPU.ColorWriteMask? writeMask = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (blend is not null)
            {
                Blend = blend;
            }

            if (writeMask is not null)
            {
                WriteMask = writeMask.Value;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUTextureFormat")]
        [NativeName("Type.Name", "WGPUTextureFormat")]
        [NativeName("Name", "format")]
        public TextureFormat Format;

        [NativeName("Type", "const WGPUBlendState *")]
        [NativeName("Type.Name", "const WGPUBlendState *")]
        [NativeName("Name", "blend")]
        public BlendState* Blend;

        [NativeName("Type", "WGPUColorWriteMaskFlags")]
        [NativeName("Type.Name", "WGPUColorWriteMaskFlags")]
        [NativeName("Name", "writeMask")]
        public Silk.NET.WebGPU.ColorWriteMask WriteMask;
    }
}
