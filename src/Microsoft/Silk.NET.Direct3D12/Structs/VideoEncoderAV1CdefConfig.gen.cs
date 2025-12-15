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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG")]
    public unsafe partial struct VideoEncoderAV1CdefConfig
    {
        public VideoEncoderAV1CdefConfig
        (
            ulong? cdefBits = null,
            ulong? cdefDampingMinus3 = null
        ) : this()
        {
            if (cdefBits is not null)
            {
                CdefBits = cdefBits.Value;
            }

            if (cdefDampingMinus3 is not null)
            {
                CdefDampingMinus3 = cdefDampingMinus3.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "CdefBits")]
        public ulong CdefBits;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "CdefDampingMinus3")]
        public ulong CdefDampingMinus3;
        [NativeName("Type", "UINT64[8]")]
        [NativeName("Type.Name", "UINT64[8]")]
        [NativeName("Name", "CdefYPriStrength")]
        public fixed ulong CdefYPriStrength[8];
        [NativeName("Type", "UINT64[8]")]
        [NativeName("Type.Name", "UINT64[8]")]
        [NativeName("Name", "CdefUVPriStrength")]
        public fixed ulong CdefUVPriStrength[8];
        [NativeName("Type", "UINT64[8]")]
        [NativeName("Type.Name", "UINT64[8]")]
        [NativeName("Name", "CdefYSecStrength")]
        public fixed ulong CdefYSecStrength[8];
        [NativeName("Type", "UINT64[8]")]
        [NativeName("Type.Name", "UINT64[8]")]
        [NativeName("Name", "CdefUVSecStrength")]
        public fixed ulong CdefUVSecStrength[8];
    }
}
