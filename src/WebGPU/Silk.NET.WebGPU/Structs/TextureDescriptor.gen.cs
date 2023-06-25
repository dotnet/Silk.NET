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
    [NativeName("Name", "WGPUTextureDescriptor")]
    public unsafe partial struct TextureDescriptor
    {
        public TextureDescriptor
        (
            ChainedStruct* nextInChain = null,
            byte* label = null,
            Silk.NET.WebGPU.TextureUsage? usage = null,
            TextureDimension? dimension = null,
            Extent3D? size = null,
            TextureFormat? format = null,
            uint? mipLevelCount = null,
            uint? sampleCount = null,
            nuint? viewFormatCount = null,
            TextureFormat* viewFormats = null
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

            if (dimension is not null)
            {
                Dimension = dimension.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (mipLevelCount is not null)
            {
                MipLevelCount = mipLevelCount.Value;
            }

            if (sampleCount is not null)
            {
                SampleCount = sampleCount.Value;
            }

            if (viewFormatCount is not null)
            {
                ViewFormatCount = viewFormatCount.Value;
            }

            if (viewFormats is not null)
            {
                ViewFormats = viewFormats;
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

        [NativeName("Type", "WGPUTextureUsageFlags")]
        [NativeName("Type.Name", "WGPUTextureUsageFlags")]
        [NativeName("Name", "usage")]
        public Silk.NET.WebGPU.TextureUsage Usage;

        [NativeName("Type", "WGPUTextureDimension")]
        [NativeName("Type.Name", "WGPUTextureDimension")]
        [NativeName("Name", "dimension")]
        public TextureDimension Dimension;

        [NativeName("Type", "WGPUExtent3D")]
        [NativeName("Type.Name", "WGPUExtent3D")]
        [NativeName("Name", "size")]
        public Extent3D Size;

        [NativeName("Type", "WGPUTextureFormat")]
        [NativeName("Type.Name", "WGPUTextureFormat")]
        [NativeName("Name", "format")]
        public TextureFormat Format;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "mipLevelCount")]
        public uint MipLevelCount;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sampleCount")]
        public uint SampleCount;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "viewFormatCount")]
        public nuint ViewFormatCount;

        [NativeName("Type", "const WGPUTextureFormat *")]
        [NativeName("Type.Name", "const WGPUTextureFormat *")]
        [NativeName("Name", "viewFormats")]
        public TextureFormat* ViewFormats;
    }
}
