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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_DELTA_CONFIG")]
    public unsafe partial struct VideoEncoderCodecAV1QuantizationDeltaConfig
    {
        public VideoEncoderCodecAV1QuantizationDeltaConfig
        (
            ulong? deltaQPresent = null,
            ulong? deltaQRes = null
        ) : this()
        {
            if (deltaQPresent is not null)
            {
                DeltaQPresent = deltaQPresent.Value;
            }

            if (deltaQRes is not null)
            {
                DeltaQRes = deltaQRes.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "DeltaQPresent")]
        public ulong DeltaQPresent;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "DeltaQRes")]
        public ulong DeltaQRes;
    }
}
