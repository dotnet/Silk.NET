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
    [NativeName("Name", "D3D12_QUERY_DATA_VIDEO_DECODE_STATISTICS")]
    public unsafe partial struct QueryDataVideoDecodeStatistics
    {
        public QueryDataVideoDecodeStatistics
        (
            ulong? status = null,
            ulong? numMacroblocksAffected = null,
            Silk.NET.DXGI.Rational? frameRate = null,
            uint? bitRate = null
        ) : this()
        {
            if (status is not null)
            {
                Status = status.Value;
            }

            if (numMacroblocksAffected is not null)
            {
                NumMacroblocksAffected = numMacroblocksAffected.Value;
            }

            if (frameRate is not null)
            {
                FrameRate = frameRate.Value;
            }

            if (bitRate is not null)
            {
                BitRate = bitRate.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Status")]
        public ulong Status;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "NumMacroblocksAffected")]
        public ulong NumMacroblocksAffected;

        [NativeName("Type", "DXGI_RATIONAL")]
        [NativeName("Type.Name", "DXGI_RATIONAL")]
        [NativeName("Name", "FrameRate")]
        public Silk.NET.DXGI.Rational FrameRate;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BitRate")]
        public uint BitRate;
    }
}
