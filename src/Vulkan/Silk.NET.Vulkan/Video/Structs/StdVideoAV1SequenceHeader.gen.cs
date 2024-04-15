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
    [NativeName("Name", "StdVideoAV1SequenceHeader")]
    public unsafe partial struct StdVideoAV1SequenceHeader
    {
        public StdVideoAV1SequenceHeader
        (
            StdVideoAV1SequenceHeaderFlags? flags = null,
            StdVideoAV1Profile? seqProfile = null,
            byte? frameWidthBitsMinus1 = null,
            byte? frameHeightBitsMinus1 = null,
            ushort? maxFrameWidthMinus1 = null,
            ushort? maxFrameHeightMinus1 = null,
            byte? deltaFrameIdLengthMinus2 = null,
            byte? additionalFrameIdLengthMinus1 = null,
            byte? orderHintBitsMinus1 = null,
            byte? seqForceIntegerMv = null,
            byte? seqForceScreenContentTools = null,
            StdVideoAV1ColorConfig* pColorConfig = null,
            StdVideoAV1TimingInfo* pTimingInfo = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (seqProfile is not null)
            {
                SeqProfile = seqProfile.Value;
            }

            if (frameWidthBitsMinus1 is not null)
            {
                FrameWidthBitsMinus1 = frameWidthBitsMinus1.Value;
            }

            if (frameHeightBitsMinus1 is not null)
            {
                FrameHeightBitsMinus1 = frameHeightBitsMinus1.Value;
            }

            if (maxFrameWidthMinus1 is not null)
            {
                MaxFrameWidthMinus1 = maxFrameWidthMinus1.Value;
            }

            if (maxFrameHeightMinus1 is not null)
            {
                MaxFrameHeightMinus1 = maxFrameHeightMinus1.Value;
            }

            if (deltaFrameIdLengthMinus2 is not null)
            {
                DeltaFrameIdLengthMinus2 = deltaFrameIdLengthMinus2.Value;
            }

            if (additionalFrameIdLengthMinus1 is not null)
            {
                AdditionalFrameIdLengthMinus1 = additionalFrameIdLengthMinus1.Value;
            }

            if (orderHintBitsMinus1 is not null)
            {
                OrderHintBitsMinus1 = orderHintBitsMinus1.Value;
            }

            if (seqForceIntegerMv is not null)
            {
                SeqForceIntegerMv = seqForceIntegerMv.Value;
            }

            if (seqForceScreenContentTools is not null)
            {
                SeqForceScreenContentTools = seqForceScreenContentTools.Value;
            }

            if (pColorConfig is not null)
            {
                PColorConfig = pColorConfig;
            }

            if (pTimingInfo is not null)
            {
                PTimingInfo = pTimingInfo;
            }
        }


        [NativeName("Type", "StdVideoAV1SequenceHeaderFlags")]
        [NativeName("Type.Name", "StdVideoAV1SequenceHeaderFlags")]
        [NativeName("Name", "flags")]
        public StdVideoAV1SequenceHeaderFlags Flags;

        [NativeName("Type", "StdVideoAV1Profile")]
        [NativeName("Type.Name", "StdVideoAV1Profile")]
        [NativeName("Name", "seq_profile")]
        public StdVideoAV1Profile SeqProfile;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "frame_width_bits_minus_1")]
        public byte FrameWidthBitsMinus1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "frame_height_bits_minus_1")]
        public byte FrameHeightBitsMinus1;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "max_frame_width_minus_1")]
        public ushort MaxFrameWidthMinus1;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "max_frame_height_minus_1")]
        public ushort MaxFrameHeightMinus1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "delta_frame_id_length_minus_2")]
        public byte DeltaFrameIdLengthMinus2;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "additional_frame_id_length_minus_1")]
        public byte AdditionalFrameIdLengthMinus1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "order_hint_bits_minus_1")]
        public byte OrderHintBitsMinus1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "seq_force_integer_mv")]
        public byte SeqForceIntegerMv;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "seq_force_screen_content_tools")]
        public byte SeqForceScreenContentTools;
        [NativeName("Type", "uint8_t[5]")]
        [NativeName("Type.Name", "uint8_t[5]")]
        [NativeName("Name", "reserved1")]
        public fixed byte Reserved1[5];

        [NativeName("Type", "const StdVideoAV1ColorConfig *")]
        [NativeName("Type.Name", "const StdVideoAV1ColorConfig *")]
        [NativeName("Name", "pColorConfig")]
        public StdVideoAV1ColorConfig* PColorConfig;

        [NativeName("Type", "const StdVideoAV1TimingInfo *")]
        [NativeName("Type.Name", "const StdVideoAV1TimingInfo *")]
        [NativeName("Name", "pTimingInfo")]
        public StdVideoAV1TimingInfo* PTimingInfo;
    }
}
