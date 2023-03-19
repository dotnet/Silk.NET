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
    [NativeName("Name", "WGPUSwapChainDescriptorExtras")]
    public unsafe partial struct SwapChainDescriptorExtras
    {
        public SwapChainDescriptorExtras
        (
            ChainedStruct? chain = null,
            CompositeAlphaMode? alphaMode = null,
            nuint? viewFormatCount = null,
            TextureFormat* viewFormats = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (alphaMode is not null)
            {
                AlphaMode = alphaMode.Value;
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


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "WGPUCompositeAlphaMode")]
        [NativeName("Type.Name", "WGPUCompositeAlphaMode")]
        [NativeName("Name", "alphaMode")]
        public CompositeAlphaMode AlphaMode;

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
