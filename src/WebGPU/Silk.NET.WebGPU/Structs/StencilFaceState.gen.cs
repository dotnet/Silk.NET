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
    [NativeName("Name", "WGPUStencilFaceState")]
    public unsafe partial struct StencilFaceState
    {
        public StencilFaceState
        (
            CompareFunction? compare = null,
            StencilOperation? failOp = null,
            StencilOperation? depthFailOp = null,
            StencilOperation? passOp = null
        ) : this()
        {
            if (compare is not null)
            {
                Compare = compare.Value;
            }

            if (failOp is not null)
            {
                FailOp = failOp.Value;
            }

            if (depthFailOp is not null)
            {
                DepthFailOp = depthFailOp.Value;
            }

            if (passOp is not null)
            {
                PassOp = passOp.Value;
            }
        }


        [NativeName("Type", "WGPUCompareFunction")]
        [NativeName("Type.Name", "WGPUCompareFunction")]
        [NativeName("Name", "compare")]
        public CompareFunction Compare;

        [NativeName("Type", "WGPUStencilOperation")]
        [NativeName("Type.Name", "WGPUStencilOperation")]
        [NativeName("Name", "failOp")]
        public StencilOperation FailOp;

        [NativeName("Type", "WGPUStencilOperation")]
        [NativeName("Type.Name", "WGPUStencilOperation")]
        [NativeName("Name", "depthFailOp")]
        public StencilOperation DepthFailOp;

        [NativeName("Type", "WGPUStencilOperation")]
        [NativeName("Type.Name", "WGPUStencilOperation")]
        [NativeName("Name", "passOp")]
        public StencilOperation PassOp;
    }
}
