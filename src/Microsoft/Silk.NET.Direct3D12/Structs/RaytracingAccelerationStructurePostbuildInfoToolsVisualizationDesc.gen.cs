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
    [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_TOOLS_VISUALIZATION_DESC")]
    public unsafe partial struct RaytracingAccelerationStructurePostbuildInfoToolsVisualizationDesc
    {
        public RaytracingAccelerationStructurePostbuildInfoToolsVisualizationDesc
        (
            ulong? decodedSizeInBytes = null
        ) : this()
        {
            if (decodedSizeInBytes is not null)
            {
                DecodedSizeInBytes = decodedSizeInBytes.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "DecodedSizeInBytes")]
        public ulong DecodedSizeInBytes;
    }
}
