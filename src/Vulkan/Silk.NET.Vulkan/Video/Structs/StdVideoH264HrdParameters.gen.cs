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
    [NativeName("Name", "StdVideoH264HrdParameters")]
    public unsafe partial struct StdVideoH264HrdParameters
    {
        public StdVideoH264HrdParameters
        (
            byte? cpbCntMinus1 = null,
            byte? bitRateScale = null,
            byte? cpbSizeScale = null,
            byte? reserved1 = null,
            uint? initialCpbRemovalDelayLengthMinus1 = null,
            uint? cpbRemovalDelayLengthMinus1 = null,
            uint? dpbOutputDelayLengthMinus1 = null,
            uint? timeOffsetLength = null
        ) : this()
        {
            if (cpbCntMinus1 is not null)
            {
                CpbCntMinus1 = cpbCntMinus1.Value;
            }

            if (bitRateScale is not null)
            {
                BitRateScale = bitRateScale.Value;
            }

            if (cpbSizeScale is not null)
            {
                CpbSizeScale = cpbSizeScale.Value;
            }

            if (reserved1 is not null)
            {
                Reserved1 = reserved1.Value;
            }

            if (initialCpbRemovalDelayLengthMinus1 is not null)
            {
                InitialCpbRemovalDelayLengthMinus1 = initialCpbRemovalDelayLengthMinus1.Value;
            }

            if (cpbRemovalDelayLengthMinus1 is not null)
            {
                CpbRemovalDelayLengthMinus1 = cpbRemovalDelayLengthMinus1.Value;
            }

            if (dpbOutputDelayLengthMinus1 is not null)
            {
                DpbOutputDelayLengthMinus1 = dpbOutputDelayLengthMinus1.Value;
            }

            if (timeOffsetLength is not null)
            {
                TimeOffsetLength = timeOffsetLength.Value;
            }
        }


        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "cpb_cnt_minus1")]
        public byte CpbCntMinus1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "bit_rate_scale")]
        public byte BitRateScale;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "cpb_size_scale")]
        public byte CpbSizeScale;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "reserved1")]
        public byte Reserved1;
        [NativeName("Type", "uint32_t[32]")]
        [NativeName("Type.Name", "uint32_t[32]")]
        [NativeName("Name", "bit_rate_value_minus1")]
        public fixed uint BitRateValueMinus1[32];
        [NativeName("Type", "uint32_t[32]")]
        [NativeName("Type.Name", "uint32_t[32]")]
        [NativeName("Name", "cpb_size_value_minus1")]
        public fixed uint CpbSizeValueMinus1[32];
        [NativeName("Type", "uint8_t[32]")]
        [NativeName("Type.Name", "uint8_t[32]")]
        [NativeName("Name", "cbr_flag")]
        public fixed byte CbrFlag[32];

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "initial_cpb_removal_delay_length_minus1")]
        public uint InitialCpbRemovalDelayLengthMinus1;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "cpb_removal_delay_length_minus1")]
        public uint CpbRemovalDelayLengthMinus1;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "dpb_output_delay_length_minus1")]
        public uint DpbOutputDelayLengthMinus1;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "time_offset_length")]
        public uint TimeOffsetLength;
    }
}
