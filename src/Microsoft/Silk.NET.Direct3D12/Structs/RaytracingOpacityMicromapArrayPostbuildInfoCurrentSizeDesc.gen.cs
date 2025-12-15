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
    [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_CURRENT_SIZE_DESC")]
    public unsafe partial struct RaytracingOpacityMicromapArrayPostbuildInfoCurrentSizeDesc
    {
        public RaytracingOpacityMicromapArrayPostbuildInfoCurrentSizeDesc
        (
            ulong? currentSizeInBytes = null
        ) : this()
        {
            if (currentSizeInBytes is not null)
            {
                CurrentSizeInBytes = currentSizeInBytes.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "CurrentSizeInBytes")]
        public ulong CurrentSizeInBytes;
    }
}
