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
    [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_HISTOGRAM_ENTRY")]
    public unsafe partial struct RaytracingOpacityMicromapHistogramEntry
    {
        public RaytracingOpacityMicromapHistogramEntry
        (
            uint? count = null,
            uint? subdivisionLevel = null,
            RaytracingOpacityMicromapFormat? format = null
        ) : this()
        {
            if (count is not null)
            {
                Count = count.Value;
            }

            if (subdivisionLevel is not null)
            {
                SubdivisionLevel = subdivisionLevel.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Count")]
        public uint Count;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SubdivisionLevel")]
        public uint SubdivisionLevel;

        [NativeName("Type", "D3D12_RAYTRACING_OPACITY_MICROMAP_FORMAT")]
        [NativeName("Type.Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_FORMAT")]
        [NativeName("Name", "Format")]
        public RaytracingOpacityMicromapFormat Format;
    }
}
