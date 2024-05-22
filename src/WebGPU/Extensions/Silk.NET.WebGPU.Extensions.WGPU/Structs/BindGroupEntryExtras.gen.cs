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

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUBindGroupEntryExtras")]
    public unsafe partial struct BindGroupEntryExtras
    {
        public BindGroupEntryExtras
        (
            ChainedStruct? chain = null,
            Buffer** buffers = null,
            nuint? bufferCount = null,
            Sampler** samplers = null,
            nuint? samplerCount = null,
            TextureView** textureViews = null,
            nuint? textureViewCount = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (buffers is not null)
            {
                Buffers = buffers;
            }

            if (bufferCount is not null)
            {
                BufferCount = bufferCount.Value;
            }

            if (samplers is not null)
            {
                Samplers = samplers;
            }

            if (samplerCount is not null)
            {
                SamplerCount = samplerCount.Value;
            }

            if (textureViews is not null)
            {
                TextureViews = textureViews;
            }

            if (textureViewCount is not null)
            {
                TextureViewCount = textureViewCount.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "const WGPUBuffer *")]
        [NativeName("Type.Name", "const WGPUBuffer *")]
        [NativeName("Name", "buffers")]
        public Buffer** Buffers;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "bufferCount")]
        public nuint BufferCount;

        [NativeName("Type", "const WGPUSampler *")]
        [NativeName("Type.Name", "const WGPUSampler *")]
        [NativeName("Name", "samplers")]
        public Sampler** Samplers;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "samplerCount")]
        public nuint SamplerCount;

        [NativeName("Type", "const WGPUTextureView *")]
        [NativeName("Type.Name", "const WGPUTextureView *")]
        [NativeName("Name", "textureViews")]
        public TextureView** TextureViews;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "textureViewCount")]
        public nuint TextureViewCount;
    }
}
