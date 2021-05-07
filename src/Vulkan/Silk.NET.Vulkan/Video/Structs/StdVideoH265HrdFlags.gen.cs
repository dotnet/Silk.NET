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
    [NativeName("Name", "StdVideoH265HrdFlags")]
    public unsafe partial struct StdVideoH265HrdFlags
    {
        public StdVideoH265HrdFlags
        (
            uint? nalHrdParametersPresentFlag = null,
            uint? vclHrdParametersPresentFlag = null,
            uint? subPicHrdParamsPresentFlag = null,
            uint? subPicCpbParamsInPicTimingSeiFlag = null,
            byte? fixedPicRateGeneralFlag = null,
            byte? fixedPicRateWithinCvsFlag = null,
            byte? lowDelayHrdFlag = null
        ) : this()
        {
            if (nalHrdParametersPresentFlag is not null)
            {
                NalHrdParametersPresentFlag = nalHrdParametersPresentFlag.Value;
            }

            if (vclHrdParametersPresentFlag is not null)
            {
                VclHrdParametersPresentFlag = vclHrdParametersPresentFlag.Value;
            }

            if (subPicHrdParamsPresentFlag is not null)
            {
                SubPicHrdParamsPresentFlag = subPicHrdParamsPresentFlag.Value;
            }

            if (subPicCpbParamsInPicTimingSeiFlag is not null)
            {
                SubPicCpbParamsInPicTimingSeiFlag = subPicCpbParamsInPicTimingSeiFlag.Value;
            }

            if (fixedPicRateGeneralFlag is not null)
            {
                FixedPicRateGeneralFlag = fixedPicRateGeneralFlag.Value;
            }

            if (fixedPicRateWithinCvsFlag is not null)
            {
                FixedPicRateWithinCvsFlag = fixedPicRateWithinCvsFlag.Value;
            }

            if (lowDelayHrdFlag is not null)
            {
                LowDelayHrdFlag = lowDelayHrdFlag.Value;
            }
        }


        private uint _bitfield1;

        public uint NalHrdParametersPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint VclHrdParametersPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
        }

        public uint SubPicHrdParamsPresentFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 2) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 2)) | (uint)(((uint)(value) & 0x1u) << 2));
        }

        public uint SubPicCpbParamsInPicTimingSeiFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 3) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 3)) | (uint)(((uint)(value) & 0x1u) << 3));
        }

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "fixed_pic_rate_general_flag")]
        public byte FixedPicRateGeneralFlag;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "fixed_pic_rate_within_cvs_flag")]
        public byte FixedPicRateWithinCvsFlag;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "low_delay_hrd_flag")]
        public byte LowDelayHrdFlag;
    }
}
