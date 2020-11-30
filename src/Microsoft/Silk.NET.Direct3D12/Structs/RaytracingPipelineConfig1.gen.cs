// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "D3D12_RAYTRACING_PIPELINE_CONFIG1")]
    public unsafe partial struct RaytracingPipelineConfig1
    {
        public RaytracingPipelineConfig1
        (
            uint? maxTraceRecursionDepth = null,
            RaytracingPipelineFlags? flags = null
        ) : this()
        {
            if (maxTraceRecursionDepth is not null)
            {
                MaxTraceRecursionDepth = maxTraceRecursionDepth.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxTraceRecursionDepth")]
        public uint MaxTraceRecursionDepth;

        [NativeName("Type", "D3D12_RAYTRACING_PIPELINE_FLAGS")]
        [NativeName("Type.Name", "D3D12_RAYTRACING_PIPELINE_FLAGS")]
        [NativeName("Name", "Flags")]
        public RaytracingPipelineFlags Flags;
    }
}
