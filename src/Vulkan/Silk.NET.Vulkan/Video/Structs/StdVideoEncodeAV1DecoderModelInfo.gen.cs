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
    [NativeName("Name", "StdVideoEncodeAV1DecoderModelInfo")]
    public unsafe partial struct StdVideoEncodeAV1DecoderModelInfo
    {
        public StdVideoEncodeAV1DecoderModelInfo
        (
            byte? bufferDelayLengthMinus1 = null,
            byte? bufferRemovalTimeLengthMinus1 = null,
            byte? framePresentationTimeLengthMinus1 = null,
            byte? reserved1 = null,
            uint? numUnitsInDecodingTick = null
        ) : this()
        {
            if (bufferDelayLengthMinus1 is not null)
            {
                BufferDelayLengthMinus1 = bufferDelayLengthMinus1.Value;
            }

            if (bufferRemovalTimeLengthMinus1 is not null)
            {
                BufferRemovalTimeLengthMinus1 = bufferRemovalTimeLengthMinus1.Value;
            }

            if (framePresentationTimeLengthMinus1 is not null)
            {
                FramePresentationTimeLengthMinus1 = framePresentationTimeLengthMinus1.Value;
            }

            if (reserved1 is not null)
            {
                Reserved1 = reserved1.Value;
            }

            if (numUnitsInDecodingTick is not null)
            {
                NumUnitsInDecodingTick = numUnitsInDecodingTick.Value;
            }
        }


        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "buffer_delay_length_minus_1")]
        public byte BufferDelayLengthMinus1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "buffer_removal_time_length_minus_1")]
        public byte BufferRemovalTimeLengthMinus1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "frame_presentation_time_length_minus_1")]
        public byte FramePresentationTimeLengthMinus1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "reserved1")]
        public byte Reserved1;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "num_units_in_decoding_tick")]
        public uint NumUnitsInDecodingTick;
    }
}
