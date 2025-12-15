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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG")]
    public unsafe partial struct VideoEncoderCodecAV1QuantizationConfig
    {
        public VideoEncoderCodecAV1QuantizationConfig
        (
            ulong? baseQIndex = null,
            long? yDCDeltaQ = null,
            long? uDCDeltaQ = null,
            long? uACDeltaQ = null,
            long? vDCDeltaQ = null,
            long? vACDeltaQ = null,
            ulong? usingQMatrix = null,
            ulong? qMY = null,
            ulong? qMU = null,
            ulong? qMV = null
        ) : this()
        {
            if (baseQIndex is not null)
            {
                BaseQIndex = baseQIndex.Value;
            }

            if (yDCDeltaQ is not null)
            {
                YDCDeltaQ = yDCDeltaQ.Value;
            }

            if (uDCDeltaQ is not null)
            {
                UDCDeltaQ = uDCDeltaQ.Value;
            }

            if (uACDeltaQ is not null)
            {
                UACDeltaQ = uACDeltaQ.Value;
            }

            if (vDCDeltaQ is not null)
            {
                VDCDeltaQ = vDCDeltaQ.Value;
            }

            if (vACDeltaQ is not null)
            {
                VACDeltaQ = vACDeltaQ.Value;
            }

            if (usingQMatrix is not null)
            {
                UsingQMatrix = usingQMatrix.Value;
            }

            if (qMY is not null)
            {
                QMY = qMY.Value;
            }

            if (qMU is not null)
            {
                QMU = qMU.Value;
            }

            if (qMV is not null)
            {
                QMV = qMV.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "BaseQIndex")]
        public ulong BaseQIndex;

        [NativeName("Type", "INT64")]
        [NativeName("Type.Name", "INT64")]
        [NativeName("Name", "YDCDeltaQ")]
        public long YDCDeltaQ;

        [NativeName("Type", "INT64")]
        [NativeName("Type.Name", "INT64")]
        [NativeName("Name", "UDCDeltaQ")]
        public long UDCDeltaQ;

        [NativeName("Type", "INT64")]
        [NativeName("Type.Name", "INT64")]
        [NativeName("Name", "UACDeltaQ")]
        public long UACDeltaQ;

        [NativeName("Type", "INT64")]
        [NativeName("Type.Name", "INT64")]
        [NativeName("Name", "VDCDeltaQ")]
        public long VDCDeltaQ;

        [NativeName("Type", "INT64")]
        [NativeName("Type.Name", "INT64")]
        [NativeName("Name", "VACDeltaQ")]
        public long VACDeltaQ;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "UsingQMatrix")]
        public ulong UsingQMatrix;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "QMY")]
        public ulong QMY;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "QMU")]
        public ulong QMU;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "QMV")]
        public ulong QMV;
    }
}
