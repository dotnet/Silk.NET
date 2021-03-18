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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RAYTRACING_PIPELINE_CONFIG")]
    public unsafe partial struct RaytracingPipelineConfig
    {
        public RaytracingPipelineConfig
        (
            uint? maxTraceRecursionDepth = null
        ) : this()
        {
            if (maxTraceRecursionDepth is not null)
            {
                MaxTraceRecursionDepth = maxTraceRecursionDepth.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxTraceRecursionDepth")]
        public uint MaxTraceRecursionDepth;
    }
}
