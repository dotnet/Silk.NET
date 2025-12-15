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
    [NativeName("Name", "WGPUTextureBindingLayout")]
    public unsafe partial struct TextureBindingLayout
    {
        public TextureBindingLayout
        (
            ChainedStruct* nextInChain = null,
            TextureSampleType? sampleType = null,
            TextureViewDimension? viewDimension = null,
            Silk.NET.Core.Bool32? multisampled = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (sampleType is not null)
            {
                SampleType = sampleType.Value;
            }

            if (viewDimension is not null)
            {
                ViewDimension = viewDimension.Value;
            }

            if (multisampled is not null)
            {
                Multisampled = multisampled.Value;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUTextureSampleType")]
        [NativeName("Type.Name", "WGPUTextureSampleType")]
        [NativeName("Name", "sampleType")]
        public TextureSampleType SampleType;

        [NativeName("Type", "WGPUTextureViewDimension")]
        [NativeName("Type.Name", "WGPUTextureViewDimension")]
        [NativeName("Name", "viewDimension")]
        public TextureViewDimension ViewDimension;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "multisampled")]
        public Silk.NET.Core.Bool32 Multisampled;
    }
}
