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
    [NativeName("Name", "StdVideoEncodeH265LongTermRefPics")]
    public unsafe partial struct StdVideoEncodeH265LongTermRefPics
    {
        public StdVideoEncodeH265LongTermRefPics
        (
            byte? numLongTermSps = null,
            byte? numLongTermPics = null,
            ushort? usedByCurrPicLtFlag = null
        ) : this()
        {
            if (numLongTermSps is not null)
            {
                NumLongTermSps = numLongTermSps.Value;
            }

            if (numLongTermPics is not null)
            {
                NumLongTermPics = numLongTermPics.Value;
            }

            if (usedByCurrPicLtFlag is not null)
            {
                UsedByCurrPicLtFlag = usedByCurrPicLtFlag.Value;
            }
        }


        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_long_term_sps")]
        public byte NumLongTermSps;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_long_term_pics")]
        public byte NumLongTermPics;
        [NativeName("Type", "uint8_t[32]")]
        [NativeName("Type.Name", "uint8_t[32]")]
        [NativeName("Name", "lt_idx_sps")]
        public fixed byte LtIdxSps[32];
        [NativeName("Type", "uint8_t[16]")]
        [NativeName("Type.Name", "uint8_t[16]")]
        [NativeName("Name", "poc_lsb_lt")]
        public fixed byte PocLsbLt[16];

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "used_by_curr_pic_lt_flag")]
        public ushort UsedByCurrPicLtFlag;
        [NativeName("Type", "uint8_t[48]")]
        [NativeName("Type.Name", "uint8_t[48]")]
        [NativeName("Name", "delta_poc_msb_present_flag")]
        public fixed byte DeltaPocMsbPresentFlag[48];
        [NativeName("Type", "uint8_t[48]")]
        [NativeName("Type.Name", "uint8_t[48]")]
        [NativeName("Name", "delta_poc_msb_cycle_lt")]
        public fixed byte DeltaPocMsbCycleLt[48];
    }
}
