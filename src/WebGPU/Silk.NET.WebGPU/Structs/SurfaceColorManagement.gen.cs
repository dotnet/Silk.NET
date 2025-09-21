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
    [NativeName("Name", "WGPUSurfaceColorManagement")]
    public unsafe partial struct SurfaceColorManagement
    {
        public SurfaceColorManagement
        (
            ChainedStruct? chain = null,
            PredefinedColorSpace? colorSpace = null,
            ToneMappingMode? toneMappingMode = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (colorSpace is not null)
            {
                ColorSpace = colorSpace.Value;
            }

            if (toneMappingMode is not null)
            {
                ToneMappingMode = toneMappingMode.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "WGPUPredefinedColorSpace")]
        [NativeName("Type.Name", "WGPUPredefinedColorSpace")]
        [NativeName("Name", "colorSpace")]
        public PredefinedColorSpace ColorSpace;

        [NativeName("Type", "WGPUToneMappingMode")]
        [NativeName("Type.Name", "WGPUToneMappingMode")]
        [NativeName("Name", "toneMappingMode")]
        public ToneMappingMode ToneMappingMode;
    }
}
