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
    [NativeName("Name", "WGPUDepthStencilState")]
    public unsafe partial struct DepthStencilState
    {
        public DepthStencilState
        (
            ChainedStruct* nextInChain = null,
            TextureFormat? format = null,
            Silk.NET.Core.Bool32? depthWriteEnabled = null,
            CompareFunction? depthCompare = null,
            StencilFaceState? stencilFront = null,
            StencilFaceState? stencilBack = null,
            uint? stencilReadMask = null,
            uint? stencilWriteMask = null,
            int? depthBias = null,
            float? depthBiasSlopeScale = null,
            float? depthBiasClamp = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (depthWriteEnabled is not null)
            {
                DepthWriteEnabled = depthWriteEnabled.Value;
            }

            if (depthCompare is not null)
            {
                DepthCompare = depthCompare.Value;
            }

            if (stencilFront is not null)
            {
                StencilFront = stencilFront.Value;
            }

            if (stencilBack is not null)
            {
                StencilBack = stencilBack.Value;
            }

            if (stencilReadMask is not null)
            {
                StencilReadMask = stencilReadMask.Value;
            }

            if (stencilWriteMask is not null)
            {
                StencilWriteMask = stencilWriteMask.Value;
            }

            if (depthBias is not null)
            {
                DepthBias = depthBias.Value;
            }

            if (depthBiasSlopeScale is not null)
            {
                DepthBiasSlopeScale = depthBiasSlopeScale.Value;
            }

            if (depthBiasClamp is not null)
            {
                DepthBiasClamp = depthBiasClamp.Value;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUTextureFormat")]
        [NativeName("Type.Name", "WGPUTextureFormat")]
        [NativeName("Name", "format")]
        public TextureFormat Format;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "depthWriteEnabled")]
        public Silk.NET.Core.Bool32 DepthWriteEnabled;

        [NativeName("Type", "WGPUCompareFunction")]
        [NativeName("Type.Name", "WGPUCompareFunction")]
        [NativeName("Name", "depthCompare")]
        public CompareFunction DepthCompare;

        [NativeName("Type", "WGPUStencilFaceState")]
        [NativeName("Type.Name", "WGPUStencilFaceState")]
        [NativeName("Name", "stencilFront")]
        public StencilFaceState StencilFront;

        [NativeName("Type", "WGPUStencilFaceState")]
        [NativeName("Type.Name", "WGPUStencilFaceState")]
        [NativeName("Name", "stencilBack")]
        public StencilFaceState StencilBack;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "stencilReadMask")]
        public uint StencilReadMask;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "stencilWriteMask")]
        public uint StencilWriteMask;

        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "depthBias")]
        public int DepthBias;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "depthBiasSlopeScale")]
        public float DepthBiasSlopeScale;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "depthBiasClamp")]
        public float DepthBiasClamp;
    }
}
