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
    [NativeName("Name", "WGPURenderBundleEncoderDescriptor")]
    public unsafe partial struct RenderBundleEncoderDescriptor
    {
        public RenderBundleEncoderDescriptor
        (
            ChainedStruct* nextInChain = null,
            byte* label = null,
            nuint? colorFormatCount = null,
            TextureFormat* colorFormats = null,
            TextureFormat? depthStencilFormat = null,
            uint? sampleCount = null,
            Silk.NET.Core.Bool32? depthReadOnly = null,
            Silk.NET.Core.Bool32? stencilReadOnly = null
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

            if (colorFormatCount is not null)
            {
                ColorFormatCount = colorFormatCount.Value;
            }

            if (colorFormats is not null)
            {
                ColorFormats = colorFormats;
            }

            if (depthStencilFormat is not null)
            {
                DepthStencilFormat = depthStencilFormat.Value;
            }

            if (sampleCount is not null)
            {
                SampleCount = sampleCount.Value;
            }

            if (depthReadOnly is not null)
            {
                DepthReadOnly = depthReadOnly.Value;
            }

            if (stencilReadOnly is not null)
            {
                StencilReadOnly = stencilReadOnly.Value;
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

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "colorFormatCount")]
        public nuint ColorFormatCount;

        [NativeName("Type", "const WGPUTextureFormat *")]
        [NativeName("Type.Name", "const WGPUTextureFormat *")]
        [NativeName("Name", "colorFormats")]
        public TextureFormat* ColorFormats;

        [NativeName("Type", "WGPUTextureFormat")]
        [NativeName("Type.Name", "WGPUTextureFormat")]
        [NativeName("Name", "depthStencilFormat")]
        public TextureFormat DepthStencilFormat;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sampleCount")]
        public uint SampleCount;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "depthReadOnly")]
        public Silk.NET.Core.Bool32 DepthReadOnly;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "stencilReadOnly")]
        public Silk.NET.Core.Bool32 StencilReadOnly;
    }
}
