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
    [NativeName("Name", "WGPUSurfaceConfiguration")]
    public unsafe partial struct SurfaceConfiguration
    {
        public SurfaceConfiguration
        (
            ChainedStruct* nextInChain = null,
            Device* device = null,
            TextureFormat? format = null,
            Silk.NET.WebGPU.TextureUsage? usage = null,
            nuint? viewFormatCount = null,
            TextureFormat* viewFormats = null,
            CompositeAlphaMode? alphaMode = null,
            uint? width = null,
            uint? height = null,
            PresentMode? presentMode = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (device is not null)
            {
                Device = device;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (usage is not null)
            {
                Usage = usage.Value;
            }

            if (viewFormatCount is not null)
            {
                ViewFormatCount = viewFormatCount.Value;
            }

            if (viewFormats is not null)
            {
                ViewFormats = viewFormats;
            }

            if (alphaMode is not null)
            {
                AlphaMode = alphaMode.Value;
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

        [NativeName("Type", "WGPUDevice")]
        [NativeName("Type.Name", "WGPUDevice")]
        [NativeName("Name", "device")]
        public Device* Device;

        [NativeName("Type", "WGPUTextureFormat")]
        [NativeName("Type.Name", "WGPUTextureFormat")]
        [NativeName("Name", "format")]
        public TextureFormat Format;

        [NativeName("Type", "WGPUTextureUsageFlags")]
        [NativeName("Type.Name", "WGPUTextureUsageFlags")]
        [NativeName("Name", "usage")]
        public Silk.NET.WebGPU.TextureUsage Usage;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "viewFormatCount")]
        public nuint ViewFormatCount;

        [NativeName("Type", "const WGPUTextureFormat *")]
        [NativeName("Type.Name", "const WGPUTextureFormat *")]
        [NativeName("Name", "viewFormats")]
        public TextureFormat* ViewFormats;

        [NativeName("Type", "WGPUCompositeAlphaMode")]
        [NativeName("Type.Name", "WGPUCompositeAlphaMode")]
        [NativeName("Name", "alphaMode")]
        public CompositeAlphaMode AlphaMode;

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
