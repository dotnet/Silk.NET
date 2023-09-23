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
    [NativeName("Name", "WGPUSharedTextureMemoryProperties")]
    public unsafe partial struct SharedTextureMemoryProperties
    {
        public SharedTextureMemoryProperties
        (
            ChainedStructOut* nextInChain = null,
            Silk.NET.WebGPU.TextureUsage? usage = null,
            Extent3D? size = null,
            TextureFormat? format = null
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

            if (format is not null)
            {
                Format = format.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStructOut *")]
        [NativeName("Type.Name", "WGPUChainedStructOut *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStructOut* NextInChain;

        [NativeName("Type", "WGPUTextureUsageFlags")]
        [NativeName("Type.Name", "WGPUTextureUsageFlags")]
        [NativeName("Name", "usage")]
        public Silk.NET.WebGPU.TextureUsage Usage;

        [NativeName("Type", "WGPUExtent3D")]
        [NativeName("Type.Name", "WGPUExtent3D")]
        [NativeName("Name", "size")]
        public Extent3D Size;

        [NativeName("Type", "WGPUTextureFormat")]
        [NativeName("Type.Name", "WGPUTextureFormat")]
        [NativeName("Name", "format")]
        public TextureFormat Format;
    }
}
