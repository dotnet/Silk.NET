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
    [NativeName("Name", "WGPUTextureViewDescriptor")]
    public unsafe partial struct TextureViewDescriptor
    {
        public TextureViewDescriptor
        (
            ChainedStruct* nextInChain = null,
            byte* label = null,
            TextureFormat? format = null,
            TextureViewDimension? dimension = null,
            uint? baseMipLevel = null,
            uint? mipLevelCount = null,
            uint? baseArrayLayer = null,
            uint? arrayLayerCount = null,
            TextureAspect? aspect = null
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

            if (format is not null)
            {
                Format = format.Value;
            }

            if (dimension is not null)
            {
                Dimension = dimension.Value;
            }

            if (baseMipLevel is not null)
            {
                BaseMipLevel = baseMipLevel.Value;
            }

            if (mipLevelCount is not null)
            {
                MipLevelCount = mipLevelCount.Value;
            }

            if (baseArrayLayer is not null)
            {
                BaseArrayLayer = baseArrayLayer.Value;
            }

            if (arrayLayerCount is not null)
            {
                ArrayLayerCount = arrayLayerCount.Value;
            }

            if (aspect is not null)
            {
                Aspect = aspect.Value;
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

        [NativeName("Type", "WGPUTextureFormat")]
        [NativeName("Type.Name", "WGPUTextureFormat")]
        [NativeName("Name", "format")]
        public TextureFormat Format;

        [NativeName("Type", "WGPUTextureViewDimension")]
        [NativeName("Type.Name", "WGPUTextureViewDimension")]
        [NativeName("Name", "dimension")]
        public TextureViewDimension Dimension;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "baseMipLevel")]
        public uint BaseMipLevel;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "mipLevelCount")]
        public uint MipLevelCount;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "baseArrayLayer")]
        public uint BaseArrayLayer;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "arrayLayerCount")]
        public uint ArrayLayerCount;

        [NativeName("Type", "WGPUTextureAspect")]
        [NativeName("Type.Name", "WGPUTextureAspect")]
        [NativeName("Name", "aspect")]
        public TextureAspect Aspect;
    }
}
