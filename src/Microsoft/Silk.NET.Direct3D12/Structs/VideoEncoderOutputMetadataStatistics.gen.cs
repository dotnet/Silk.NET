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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS")]
    public unsafe partial struct VideoEncoderOutputMetadataStatistics
    {
        public VideoEncoderOutputMetadataStatistics
        (
            ulong? averageQP = null,
            ulong? intraCodingUnitsCount = null,
            ulong? interCodingUnitsCount = null,
            ulong? skipCodingUnitsCount = null,
            ulong? averageMotionEstimationXDirection = null,
            ulong? averageMotionEstimationYDirection = null
        ) : this()
        {
            if (averageQP is not null)
            {
                AverageQP = averageQP.Value;
            }

            if (intraCodingUnitsCount is not null)
            {
                IntraCodingUnitsCount = intraCodingUnitsCount.Value;
            }

            if (interCodingUnitsCount is not null)
            {
                InterCodingUnitsCount = interCodingUnitsCount.Value;
            }

            if (skipCodingUnitsCount is not null)
            {
                SkipCodingUnitsCount = skipCodingUnitsCount.Value;
            }

            if (averageMotionEstimationXDirection is not null)
            {
                AverageMotionEstimationXDirection = averageMotionEstimationXDirection.Value;
            }

            if (averageMotionEstimationYDirection is not null)
            {
                AverageMotionEstimationYDirection = averageMotionEstimationYDirection.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "AverageQP")]
        public ulong AverageQP;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "IntraCodingUnitsCount")]
        public ulong IntraCodingUnitsCount;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "InterCodingUnitsCount")]
        public ulong InterCodingUnitsCount;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "SkipCodingUnitsCount")]
        public ulong SkipCodingUnitsCount;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "AverageMotionEstimationXDirection")]
        public ulong AverageMotionEstimationXDirection;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "AverageMotionEstimationYDirection")]
        public ulong AverageMotionEstimationYDirection;
    }
}
