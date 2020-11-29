// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_TOOLS_VISUALIZATION_HEADER")]
    public unsafe partial struct BuildRaytracingAccelerationStructureToolsVisualizationHeader
    {
        public BuildRaytracingAccelerationStructureToolsVisualizationHeader
        (
            RaytracingAccelerationStructureType? type = null,
            uint? numDescs = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (numDescs is not null)
            {
                NumDescs = numDescs.Value;
            }
        }


        [NativeName("Type", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE")]
        [NativeName("Type.Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE")]
        [NativeName("Name", "Type")]
        public RaytracingAccelerationStructureType Type;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumDescs")]
        public uint NumDescs;
    }
}
