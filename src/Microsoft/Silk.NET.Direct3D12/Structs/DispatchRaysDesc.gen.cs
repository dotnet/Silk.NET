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
    [NativeName("Name", "D3D12_DISPATCH_RAYS_DESC")]
    public unsafe partial struct DispatchRaysDesc
    {
        public DispatchRaysDesc
        (
            GpuVirtualAddressRange rayGenerationShaderRecord = default,
            GpuVirtualAddressRangeAndStride missShaderTable = default,
            GpuVirtualAddressRangeAndStride hitGroupTable = default,
            GpuVirtualAddressRangeAndStride callableShaderTable = default,
            uint width = default,
            uint height = default,
            uint depth = default
        )
        {
            RayGenerationShaderRecord = rayGenerationShaderRecord;
            MissShaderTable = missShaderTable;
            HitGroupTable = hitGroupTable;
            CallableShaderTable = callableShaderTable;
            Width = width;
            Height = height;
            Depth = depth;
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
