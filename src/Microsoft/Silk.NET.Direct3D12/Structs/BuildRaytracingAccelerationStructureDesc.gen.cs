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
    [NativeName("Name", "D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC")]
    public unsafe partial struct BuildRaytracingAccelerationStructureDesc
    {
        public BuildRaytracingAccelerationStructureDesc
        (
            ulong? destAccelerationStructureData = null,
            BuildRaytracingAccelerationStructureInputs? inputs = null,
            ulong? sourceAccelerationStructureData = null,
            ulong? scratchAccelerationStructureData = null
        ) : this()
        {
            if (destAccelerationStructureData is not null)
            {
                DestAccelerationStructureData = destAccelerationStructureData.Value;
            }

            if (inputs is not null)
            {
                Inputs = inputs.Value;
            }

            if (sourceAccelerationStructureData is not null)
            {
                SourceAccelerationStructureData = sourceAccelerationStructureData.Value;
            }

            if (scratchAccelerationStructureData is not null)
            {
                ScratchAccelerationStructureData = scratchAccelerationStructureData.Value;
            }
        }


        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Name", "DestAccelerationStructureData")]
        public ulong DestAccelerationStructureData;

        [NativeName("Type", "D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS")]
        [NativeName("Type.Name", "D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS")]
        [NativeName("Name", "Inputs")]
        public BuildRaytracingAccelerationStructureInputs Inputs;

        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Name", "SourceAccelerationStructureData")]
        public ulong SourceAccelerationStructureData;

        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Name", "ScratchAccelerationStructureData")]
        public ulong ScratchAccelerationStructureData;
    }
}
