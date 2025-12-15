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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_DELTA_CONFIG")]
    public unsafe partial struct VideoEncoderCodecAV1LoopFilterDeltaConfig
    {
        public VideoEncoderCodecAV1LoopFilterDeltaConfig
        (
            ulong? deltaLFPresent = null,
            ulong? deltaLFMulti = null,
            ulong? deltaLFRes = null
        ) : this()
        {
            if (deltaLFPresent is not null)
            {
                DeltaLFPresent = deltaLFPresent.Value;
            }

            if (deltaLFMulti is not null)
            {
                DeltaLFMulti = deltaLFMulti.Value;
            }

            if (deltaLFRes is not null)
            {
                DeltaLFRes = deltaLFRes.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "DeltaLFPresent")]
        public ulong DeltaLFPresent;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "DeltaLFMulti")]
        public ulong DeltaLFMulti;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "DeltaLFRes")]
        public ulong DeltaLFRes;
    }
}
