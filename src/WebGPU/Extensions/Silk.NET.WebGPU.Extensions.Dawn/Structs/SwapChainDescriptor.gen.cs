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
    [NativeName("Name", "WGPUSwapChainDescriptor")]
    public unsafe partial struct SwapChainDescriptor
    {
        public SwapChainDescriptor
        (
            ChainedStruct* nextInChain = null,
            byte* label = null,
            Silk.NET.WebGPU.TextureUsage? usage = null,
            TextureFormat? format = null,
            uint? width = null,
            uint? height = null,
            PresentMode? presentMode = null
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

            if (format is not null)
            {
                Format = format.Value;
            }

            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (presentMode is not null)
            {
                PresentMode = presentMode.Value;
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

        [NativeName("Type", "WGPUTextureFormat")]
        [NativeName("Type.Name", "WGPUTextureFormat")]
        [NativeName("Name", "format")]
        public TextureFormat Format;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "width")]
        public uint Width;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "height")]
        public uint Height;

        [NativeName("Type", "WGPUPresentMode")]
        [NativeName("Type.Name", "WGPUPresentMode")]
        [NativeName("Name", "presentMode")]
        public PresentMode PresentMode;
    }
}
