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
    [NativeName("Name", "D3D12_DISPATCH_RAYS_DESC")]
    public unsafe partial struct DispatchRaysDesc
    {
        public DispatchRaysDesc
        (
            GpuVirtualAddressRange? rayGenerationShaderRecord = null,
            GpuVirtualAddressRangeAndStride? missShaderTable = null,
            GpuVirtualAddressRangeAndStride? hitGroupTable = null,
            GpuVirtualAddressRangeAndStride? callableShaderTable = null,
            uint? width = null,
            uint? height = null,
            uint? depth = null
        ) : this()
        {
            if (rayGenerationShaderRecord is not null)
            {
                RayGenerationShaderRecord = rayGenerationShaderRecord.Value;
            }

            if (missShaderTable is not null)
            {
                MissShaderTable = missShaderTable.Value;
            }

            if (hitGroupTable is not null)
            {
                HitGroupTable = hitGroupTable.Value;
            }

            if (callableShaderTable is not null)
            {
                CallableShaderTable = callableShaderTable.Value;
            }

            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (depth is not null)
            {
                Depth = depth.Value;
            }
        }


        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS_RANGE")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS_RANGE")]
        [NativeName("Name", "RayGenerationShaderRecord")]
        public GpuVirtualAddressRange RayGenerationShaderRecord;

        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE")]
        [NativeName("Name", "MissShaderTable")]
        public GpuVirtualAddressRangeAndStride MissShaderTable;

        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE")]
        [NativeName("Name", "HitGroupTable")]
        public GpuVirtualAddressRangeAndStride HitGroupTable;

        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE")]
        [NativeName("Name", "CallableShaderTable")]
        public GpuVirtualAddressRangeAndStride CallableShaderTable;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Width")]
        public uint Width;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Height")]
        public uint Height;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Depth")]
        public uint Depth;
    }
}
