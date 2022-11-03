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
    [NativeName("Name", "WGPUBindGroupLayoutEntry")]
    public unsafe partial struct BindGroupLayoutEntry
    {
        public BindGroupLayoutEntry
        (
            ChainedStruct* nextInChain = null,
            uint? binding = null,
            Silk.NET.WebGPU.ShaderStage? visibility = null,
            BufferBindingLayout? buffer = null,
            SamplerBindingLayout? sampler = null,
            TextureBindingLayout? texture = null,
            StorageTextureBindingLayout? storageTexture = null
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

            if (visibility is not null)
            {
                Visibility = visibility.Value;
            }

            if (buffer is not null)
            {
                Buffer = buffer.Value;
            }

            if (sampler is not null)
            {
                Sampler = sampler.Value;
            }

            if (texture is not null)
            {
                Texture = texture.Value;
            }

            if (storageTexture is not null)
            {
                StorageTexture = storageTexture.Value;
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

        [NativeName("Type", "WGPUShaderStageFlags")]
        [NativeName("Type.Name", "WGPUShaderStageFlags")]
        [NativeName("Name", "visibility")]
        public Silk.NET.WebGPU.ShaderStage Visibility;

        [NativeName("Type", "WGPUBufferBindingLayout")]
        [NativeName("Type.Name", "WGPUBufferBindingLayout")]
        [NativeName("Name", "buffer")]
        public BufferBindingLayout Buffer;

        [NativeName("Type", "WGPUSamplerBindingLayout")]
        [NativeName("Type.Name", "WGPUSamplerBindingLayout")]
        [NativeName("Name", "sampler")]
        public SamplerBindingLayout Sampler;

        [NativeName("Type", "WGPUTextureBindingLayout")]
        [NativeName("Type.Name", "WGPUTextureBindingLayout")]
        [NativeName("Name", "texture")]
        public TextureBindingLayout Texture;

        [NativeName("Type", "WGPUStorageTextureBindingLayout")]
        [NativeName("Type.Name", "WGPUStorageTextureBindingLayout")]
        [NativeName("Name", "storageTexture")]
        public StorageTextureBindingLayout StorageTexture;
    }
}
