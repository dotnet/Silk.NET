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
    [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO")]
    public unsafe partial struct RaytracingAccelerationStructurePrebuildInfo
    {
        public RaytracingAccelerationStructurePrebuildInfo
        (
            ulong? resultDataMaxSizeInBytes = null,
            ulong? scratchDataSizeInBytes = null,
            ulong? updateScratchDataSizeInBytes = null
        ) : this()
        {
            if (resultDataMaxSizeInBytes is not null)
            {
                ResultDataMaxSizeInBytes = resultDataMaxSizeInBytes.Value;
            }

            if (scratchDataSizeInBytes is not null)
            {
                ScratchDataSizeInBytes = scratchDataSizeInBytes.Value;
            }

            if (updateScratchDataSizeInBytes is not null)
            {
                UpdateScratchDataSizeInBytes = updateScratchDataSizeInBytes.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "ResultDataMaxSizeInBytes")]
        public ulong ResultDataMaxSizeInBytes;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "ScratchDataSizeInBytes")]
        public ulong ScratchDataSizeInBytes;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "UpdateScratchDataSizeInBytes")]
        public ulong UpdateScratchDataSizeInBytes;
    }
}
