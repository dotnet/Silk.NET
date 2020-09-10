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
    [NativeName("Name", "D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS")]
    public unsafe partial struct BuildRaytracingAccelerationStructureInputs
    {
        public BuildRaytracingAccelerationStructureInputs
        (
            RaytracingAccelerationStructureType type = default,
            RaytracingAccelerationStructureBuildFlags flags = default,
            uint numDescs = default,
            ElementsLayout descsLayout = default
        )
        {
            Type = type;
            Flags = flags;
            NumDescs = numDescs;
            DescsLayout = descsLayout;
        }


        [NativeName("Type", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE")]
        [NativeName("Type.Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE")]
        [NativeName("Name", "Type")]
        public RaytracingAccelerationStructureType Type;

        [NativeName("Type", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAGS")]
        [NativeName("Type.Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAGS")]
        [NativeName("Name", "Flags")]
        public RaytracingAccelerationStructureBuildFlags Flags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumDescs")]
        public uint NumDescs;

        [NativeName("Type", "D3D12_ELEMENTS_LAYOUT")]
        [NativeName("Type.Name", "D3D12_ELEMENTS_LAYOUT")]
        [NativeName("Name", "DescsLayout")]
        public ElementsLayout DescsLayout;
    }
}
