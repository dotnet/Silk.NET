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
    [NativeName("Name", "WGPUBindGroupEntry")]
    public unsafe partial struct BindGroupEntry
    {
        public BindGroupEntry
        (
            ChainedStruct* nextInChain = null,
            uint? binding = null,
            Buffer* buffer = null,
            ulong? offset = null,
            ulong? size = null,
            Sampler* sampler = null,
            TextureView* textureView = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (binding is not null)
            {
                Binding = binding.Value;
            }

            if (buffer is not null)
            {
                Buffer = buffer;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (sampler is not null)
            {
                Sampler = sampler;
            }

            if (textureView is not null)
            {
                TextureView = textureView;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "binding")]
        public uint Binding;

        [NativeName("Type", "WGPUBuffer")]
        [NativeName("Type.Name", "WGPUBuffer")]
        [NativeName("Name", "buffer")]
        public Buffer* Buffer;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "offset")]
        public ulong Offset;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "size")]
        public ulong Size;

        [NativeName("Type", "WGPUSampler")]
        [NativeName("Type.Name", "WGPUSampler")]
        [NativeName("Name", "sampler")]
        public Sampler* Sampler;

        [NativeName("Type", "WGPUTextureView")]
        [NativeName("Type.Name", "WGPUTextureView")]
        [NativeName("Name", "textureView")]
        public TextureView* TextureView;
    }
}
