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

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoEncodeAV1OperatingPointInfo")]
    public unsafe partial struct StdVideoEncodeAV1OperatingPointInfo
    {
        public StdVideoEncodeAV1OperatingPointInfo
        (
            StdVideoEncodeAV1OperatingPointInfoFlags? flags = null,
            ushort? operatingPointIdc = null,
            byte? seqLevelIdx = null,
            byte? seqTier = null,
            uint? decoderBufferDelay = null,
            uint? encoderBufferDelay = null,
            byte? initialDisplayDelayMinus1 = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (operatingPointIdc is not null)
            {
                OperatingPointIdc = operatingPointIdc.Value;
            }

            if (seqLevelIdx is not null)
            {
                SeqLevelIdx = seqLevelIdx.Value;
            }

            if (seqTier is not null)
            {
                SeqTier = seqTier.Value;
            }

            if (decoderBufferDelay is not null)
            {
                DecoderBufferDelay = decoderBufferDelay.Value;
            }

            if (encoderBufferDelay is not null)
            {
                EncoderBufferDelay = encoderBufferDelay.Value;
            }

            if (initialDisplayDelayMinus1 is not null)
            {
                InitialDisplayDelayMinus1 = initialDisplayDelayMinus1.Value;
            }
        }


        [NativeName("Type", "StdVideoEncodeAV1OperatingPointInfoFlags")]
        [NativeName("Type.Name", "StdVideoEncodeAV1OperatingPointInfoFlags")]
        [NativeName("Name", "flags")]
        public StdVideoEncodeAV1OperatingPointInfoFlags Flags;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "operating_point_idc")]
        public ushort OperatingPointIdc;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "seq_level_idx")]
        public byte SeqLevelIdx;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "seq_tier")]
        public byte SeqTier;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "decoder_buffer_delay")]
        public uint DecoderBufferDelay;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "encoder_buffer_delay")]
        public uint EncoderBufferDelay;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "initial_display_delay_minus_1")]
        public byte InitialDisplayDelayMinus1;
    }
}
