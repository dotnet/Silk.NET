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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR1")]
    public unsafe partial struct VideoEncoderRateControlQvbr1
    {
        public VideoEncoderRateControlQvbr1
        (
            uint? initialQP = null,
            uint? minQP = null,
            uint? maxQP = null,
            ulong? maxFrameBitSize = null,
            ulong? targetAvgBitRate = null,
            ulong? peakBitRate = null,
            uint? constantQualityTarget = null,
            ulong? vBVCapacity = null,
            ulong? initialVBVFullness = null,
            uint? qualityVsSpeed = null
        ) : this()
        {
            if (initialQP is not null)
            {
                InitialQP = initialQP.Value;
            }

            if (minQP is not null)
            {
                MinQP = minQP.Value;
            }

            if (maxQP is not null)
            {
                MaxQP = maxQP.Value;
            }

            if (maxFrameBitSize is not null)
            {
                MaxFrameBitSize = maxFrameBitSize.Value;
            }

            if (targetAvgBitRate is not null)
            {
                TargetAvgBitRate = targetAvgBitRate.Value;
            }

            if (peakBitRate is not null)
            {
                PeakBitRate = peakBitRate.Value;
            }

            if (constantQualityTarget is not null)
            {
                ConstantQualityTarget = constantQualityTarget.Value;
            }

            if (vBVCapacity is not null)
            {
                VBVCapacity = vBVCapacity.Value;
            }

            if (initialVBVFullness is not null)
            {
                InitialVBVFullness = initialVBVFullness.Value;
            }

            if (qualityVsSpeed is not null)
            {
                QualityVsSpeed = qualityVsSpeed.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InitialQP")]
        public uint InitialQP;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MinQP")]
        public uint MinQP;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxQP")]
        public uint MaxQP;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "MaxFrameBitSize")]
        public ulong MaxFrameBitSize;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "TargetAvgBitRate")]
        public ulong TargetAvgBitRate;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "PeakBitRate")]
        public ulong PeakBitRate;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ConstantQualityTarget")]
        public uint ConstantQualityTarget;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "VBVCapacity")]
        public ulong VBVCapacity;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "InitialVBVFullness")]
        public ulong InitialVBVFullness;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "QualityVsSpeed")]
        public uint QualityVsSpeed;
    }
}
