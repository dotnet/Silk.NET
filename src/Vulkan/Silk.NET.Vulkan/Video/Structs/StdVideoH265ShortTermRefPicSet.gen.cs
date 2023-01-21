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
    [NativeName("Name", "StdVideoH265ShortTermRefPicSet")]
    public unsafe partial struct StdVideoH265ShortTermRefPicSet
    {
        public StdVideoH265ShortTermRefPicSet
        (
            StdVideoH265ShortTermRefPicSetFlags? flags = null,
            uint? deltaIdxMinus1 = null,
            ushort? useDeltaFlag = null,
            ushort? absDeltaRpsMinus1 = null,
            ushort? usedByCurrPicFlag = null,
            ushort? usedByCurrPicS0Flag = null,
            ushort? usedByCurrPicS1Flag = null,
            ushort? reserved1 = null,
            byte? reserved2 = null,
            byte? reserved3 = null,
            byte? numNegativePics = null,
            byte? numPositivePics = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (deltaIdxMinus1 is not null)
            {
                DeltaIdxMinus1 = deltaIdxMinus1.Value;
            }

            if (useDeltaFlag is not null)
            {
                UseDeltaFlag = useDeltaFlag.Value;
            }

            if (absDeltaRpsMinus1 is not null)
            {
                AbsDeltaRpsMinus1 = absDeltaRpsMinus1.Value;
            }

            if (usedByCurrPicFlag is not null)
            {
                UsedByCurrPicFlag = usedByCurrPicFlag.Value;
            }

            if (usedByCurrPicS0Flag is not null)
            {
                UsedByCurrPicS0Flag = usedByCurrPicS0Flag.Value;
            }

            if (usedByCurrPicS1Flag is not null)
            {
                UsedByCurrPicS1Flag = usedByCurrPicS1Flag.Value;
            }

            if (reserved1 is not null)
            {
                Reserved1 = reserved1.Value;
            }

            if (reserved2 is not null)
            {
                Reserved2 = reserved2.Value;
            }

            if (reserved3 is not null)
            {
                Reserved3 = reserved3.Value;
            }

            if (numNegativePics is not null)
            {
                NumNegativePics = numNegativePics.Value;
            }

            if (numPositivePics is not null)
            {
                NumPositivePics = numPositivePics.Value;
            }
        }


        [NativeName("Type", "StdVideoH265ShortTermRefPicSetFlags")]
        [NativeName("Type.Name", "StdVideoH265ShortTermRefPicSetFlags")]
        [NativeName("Name", "flags")]
        public StdVideoH265ShortTermRefPicSetFlags Flags;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "delta_idx_minus1")]
        public uint DeltaIdxMinus1;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "use_delta_flag")]
        public ushort UseDeltaFlag;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "abs_delta_rps_minus1")]
        public ushort AbsDeltaRpsMinus1;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "used_by_curr_pic_flag")]
        public ushort UsedByCurrPicFlag;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "used_by_curr_pic_s0_flag")]
        public ushort UsedByCurrPicS0Flag;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "used_by_curr_pic_s1_flag")]
        public ushort UsedByCurrPicS1Flag;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "reserved1")]
        public ushort Reserved1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "reserved2")]
        public byte Reserved2;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "reserved3")]
        public byte Reserved3;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_negative_pics")]
        public byte NumNegativePics;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "num_positive_pics")]
        public byte NumPositivePics;
        [NativeName("Type", "uint16_t[16]")]
        [NativeName("Type.Name", "uint16_t[16]")]
        [NativeName("Name", "delta_poc_s0_minus1")]
        public fixed ushort DeltaPocS0Minus1[16];
        [NativeName("Type", "uint16_t[16]")]
        [NativeName("Type.Name", "uint16_t[16]")]
        [NativeName("Name", "delta_poc_s1_minus1")]
        public fixed ushort DeltaPocS1Minus1[16];
    }
}
