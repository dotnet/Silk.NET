// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RAYTRACING_INSTANCE_DESC")]
    public unsafe partial struct RaytracingInstanceDesc
    {
        public RaytracingInstanceDesc
        (
            uint instanceID = default,
            uint instanceMask = default,
            uint instanceContributionToHitGroupIndex = default,
            uint flags = default,
            ulong accelerationStructure = default
        )
        {
            InstanceID = instanceID;
            InstanceMask = instanceMask;
            InstanceContributionToHitGroupIndex = instanceContributionToHitGroupIndex;
            Flags = flags;
            AccelerationStructure = accelerationStructure;
        }

        [NativeName("Type", "FLOAT [3][4]")]
        [NativeName("Type.Name", "FLOAT [3][4]")]
        [NativeName("Name", "Transform")]
        public fixed float Transform[12];

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InstanceID")]
        public uint InstanceID;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InstanceMask")]
        public uint InstanceMask;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InstanceContributionToHitGroupIndex")]
        public uint InstanceContributionToHitGroupIndex;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Flags")]
        public uint Flags;

        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Name", "AccelerationStructure")]
        public ulong AccelerationStructure;
    }
}
