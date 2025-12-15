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
    [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_DESC")]
    public unsafe partial struct RaytracingOpacityMicromapArrayPostbuildInfoDesc
    {
        public RaytracingOpacityMicromapArrayPostbuildInfoDesc
        (
            ulong? destBuffer = null,
            RaytracingOpacityMicromapArrayPostbuildInfoType? infoType = null
        ) : this()
        {
            if (destBuffer is not null)
            {
                DestBuffer = destBuffer.Value;
            }

            if (infoType is not null)
            {
                InfoType = infoType.Value;
            }
        }


        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Name", "DestBuffer")]
        public ulong DestBuffer;

        [NativeName("Type", "D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_TYPE")]
        [NativeName("Type.Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_TYPE")]
        [NativeName("Name", "InfoType")]
        public RaytracingOpacityMicromapArrayPostbuildInfoType InfoType;
    }
}
