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
    [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_COMPACTED_SIZE_DESC")]
    public unsafe partial struct RaytracingAccelerationStructurePostbuildInfoCompactedSizeDesc
    {
        public RaytracingAccelerationStructurePostbuildInfoCompactedSizeDesc
        (
            ulong? compactedSizeInBytes = null
        ) : this()
        {
            if (compactedSizeInBytes is not null)
            {
                CompactedSizeInBytes = compactedSizeInBytes.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "CompactedSizeInBytes")]
        public ulong CompactedSizeInBytes;
    }
}
