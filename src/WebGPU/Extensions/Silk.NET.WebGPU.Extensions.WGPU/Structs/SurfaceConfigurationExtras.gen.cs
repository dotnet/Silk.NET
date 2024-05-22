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
    [NativeName("Name", "WGPUSurfaceConfigurationExtras")]
    public unsafe partial struct SurfaceConfigurationExtras
    {
        public SurfaceConfigurationExtras
        (
            ChainedStruct? chain = null,
            Silk.NET.Core.Bool32? desiredMaximumFrameLatency = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (desiredMaximumFrameLatency is not null)
            {
                DesiredMaximumFrameLatency = desiredMaximumFrameLatency.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "desiredMaximumFrameLatency")]
        public Silk.NET.Core.Bool32 DesiredMaximumFrameLatency;
    }
}
