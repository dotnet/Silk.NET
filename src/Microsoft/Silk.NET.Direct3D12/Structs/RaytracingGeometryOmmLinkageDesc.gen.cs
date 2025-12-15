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
    [NativeName("Name", "D3D12_RAYTRACING_GEOMETRY_OMM_LINKAGE_DESC")]
    public unsafe partial struct RaytracingGeometryOmmLinkageDesc
    {
        public RaytracingGeometryOmmLinkageDesc
        (
            GpuVirtualAddressAndStride? opacityMicromapIndexBuffer = null,
            Silk.NET.DXGI.Format? opacityMicromapIndexFormat = null,
            uint? opacityMicromapBaseLocation = null,
            ulong? opacityMicromapArray = null
        ) : this()
        {
            if (opacityMicromapIndexBuffer is not null)
            {
                OpacityMicromapIndexBuffer = opacityMicromapIndexBuffer.Value;
            }

            if (opacityMicromapIndexFormat is not null)
            {
                OpacityMicromapIndexFormat = opacityMicromapIndexFormat.Value;
            }

            if (opacityMicromapBaseLocation is not null)
            {
                OpacityMicromapBaseLocation = opacityMicromapBaseLocation.Value;
            }

            if (opacityMicromapArray is not null)
            {
                OpacityMicromapArray = opacityMicromapArray.Value;
            }
        }


        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE")]
        [NativeName("Name", "OpacityMicromapIndexBuffer")]
        public GpuVirtualAddressAndStride OpacityMicromapIndexBuffer;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "OpacityMicromapIndexFormat")]
        public Silk.NET.DXGI.Format OpacityMicromapIndexFormat;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "OpacityMicromapBaseLocation")]
        public uint OpacityMicromapBaseLocation;

        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Name", "OpacityMicromapArray")]
        public ulong OpacityMicromapArray;
    }
}
