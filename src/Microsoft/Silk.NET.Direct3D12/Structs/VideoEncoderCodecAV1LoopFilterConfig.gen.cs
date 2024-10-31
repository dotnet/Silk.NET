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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG")]
    public unsafe partial struct VideoEncoderCodecAV1LoopFilterConfig
    {
        public VideoEncoderCodecAV1LoopFilterConfig
        (
            ulong? loopFilterLevelU = null,
            ulong? loopFilterLevelV = null,
            ulong? loopFilterSharpnessLevel = null,
            ulong? loopFilterDeltaEnabled = null,
            ulong? updateRefDelta = null,
            ulong? updateModeDelta = null
        ) : this()
        {
            if (loopFilterLevelU is not null)
            {
                LoopFilterLevelU = loopFilterLevelU.Value;
            }

            if (loopFilterLevelV is not null)
            {
                LoopFilterLevelV = loopFilterLevelV.Value;
            }

            if (loopFilterSharpnessLevel is not null)
            {
                LoopFilterSharpnessLevel = loopFilterSharpnessLevel.Value;
            }

            if (loopFilterDeltaEnabled is not null)
            {
                LoopFilterDeltaEnabled = loopFilterDeltaEnabled.Value;
            }

            if (updateRefDelta is not null)
            {
                UpdateRefDelta = updateRefDelta.Value;
            }

            if (updateModeDelta is not null)
            {
                UpdateModeDelta = updateModeDelta.Value;
            }
        }

        [NativeName("Type", "UINT64[2]")]
        [NativeName("Type.Name", "UINT64[2]")]
        [NativeName("Name", "LoopFilterLevel")]
        public fixed ulong LoopFilterLevel[2];

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "LoopFilterLevelU")]
        public ulong LoopFilterLevelU;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "LoopFilterLevelV")]
        public ulong LoopFilterLevelV;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "LoopFilterSharpnessLevel")]
        public ulong LoopFilterSharpnessLevel;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "LoopFilterDeltaEnabled")]
        public ulong LoopFilterDeltaEnabled;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "UpdateRefDelta")]
        public ulong UpdateRefDelta;
        [NativeName("Type", "INT64[8]")]
        [NativeName("Type.Name", "INT64[8]")]
        [NativeName("Name", "RefDeltas")]
        public fixed long RefDeltas[8];

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "UpdateModeDelta")]
        public ulong UpdateModeDelta;
        [NativeName("Type", "INT64[2]")]
        [NativeName("Type.Name", "INT64[2]")]
        [NativeName("Name", "ModeDeltas")]
        public fixed long ModeDeltas[2];
    }
}
