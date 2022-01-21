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
    [NativeName("Name", "StdVideoH265HrdParameters")]
    public unsafe partial struct StdVideoH265HrdParameters
    {
        public StdVideoH265HrdParameters
        (
            byte? tickDivisorMinus2 = null,
            byte? duCpbRemovalDelayIncrementLengthMinus1 = null,
            byte? dpbOutputDelayDuLengthMinus1 = null,
            byte? bitRateScale = null,
            byte? cpbSizeScale = null,
            byte? cpbSizeDuScale = null,
            byte? initialCpbRemovalDelayLengthMinus1 = null,
            byte? auCpbRemovalDelayLengthMinus1 = null,
            byte? dpbOutputDelayLengthMinus1 = null,
            StdVideoH265HrdFlags? flags = null
        ) : this()
        {
            if (tickDivisorMinus2 is not null)
            {
                TickDivisorMinus2 = tickDivisorMinus2.Value;
            }

            if (duCpbRemovalDelayIncrementLengthMinus1 is not null)
            {
                DuCpbRemovalDelayIncrementLengthMinus1 = duCpbRemovalDelayIncrementLengthMinus1.Value;
            }

            if (dpbOutputDelayDuLengthMinus1 is not null)
            {
                DpbOutputDelayDuLengthMinus1 = dpbOutputDelayDuLengthMinus1.Value;
            }

            if (bitRateScale is not null)
            {
                BitRateScale = bitRateScale.Value;
            }

            if (cpbSizeScale is not null)
            {
                CpbSizeScale = cpbSizeScale.Value;
            }

            if (cpbSizeDuScale is not null)
            {
                CpbSizeDuScale = cpbSizeDuScale.Value;
            }

            if (initialCpbRemovalDelayLengthMinus1 is not null)
            {
                InitialCpbRemovalDelayLengthMinus1 = initialCpbRemovalDelayLengthMinus1.Value;
            }

            if (auCpbRemovalDelayLengthMinus1 is not null)
            {
                AuCpbRemovalDelayLengthMinus1 = auCpbRemovalDelayLengthMinus1.Value;
            }

            if (dpbOutputDelayLengthMinus1 is not null)
            {
                DpbOutputDelayLengthMinus1 = dpbOutputDelayLengthMinus1.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "tick_divisor_minus2")]
        public byte TickDivisorMinus2;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "du_cpb_removal_delay_increment_length_minus1")]
        public byte DuCpbRemovalDelayIncrementLengthMinus1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "dpb_output_delay_du_length_minus1")]
        public byte DpbOutputDelayDuLengthMinus1;

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
        [NativeName("Name", "cpb_size_du_scale")]
        public byte CpbSizeDuScale;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "initial_cpb_removal_delay_length_minus1")]
        public byte InitialCpbRemovalDelayLengthMinus1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "au_cpb_removal_delay_length_minus1")]
        public byte AuCpbRemovalDelayLengthMinus1;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "dpb_output_delay_length_minus1")]
        public byte DpbOutputDelayLengthMinus1;
        [NativeName("Type", "uint8_t [7]")]
        [NativeName("Type.Name", "uint8_t [7]")]
        [NativeName("Name", "cpb_cnt_minus1")]
        public fixed byte CpbCntMinus1[7];
        [NativeName("Type", "uint16_t [7]")]
        [NativeName("Type.Name", "uint16_t [7]")]
        [NativeName("Name", "elemental_duration_in_tc_minus1")]
        public fixed ushort ElementalDurationInTcMinus1[7];
        
        [NativeName("Type", "StdVideoH265SubLayerHrdParameters *[7]")]
        [NativeName("Type.Name", "StdVideoH265SubLayerHrdParameters *[7]")]
        [NativeName("Name", "pSubLayerHrdParametersNal")]
        public PSubLayerHrdParametersNalBuffer PSubLayerHrdParametersNal;

        public struct PSubLayerHrdParametersNalBuffer
        {
            public StdVideoH265SubLayerHrdParameters* Element0;
            public StdVideoH265SubLayerHrdParameters* Element1;
            public StdVideoH265SubLayerHrdParameters* Element2;
            public StdVideoH265SubLayerHrdParameters* Element3;
            public StdVideoH265SubLayerHrdParameters* Element4;
            public StdVideoH265SubLayerHrdParameters* Element5;
            public StdVideoH265SubLayerHrdParameters* Element6;
            public ref StdVideoH265SubLayerHrdParameters* this[int index]
            {
                get
                {
                    if (index > 6 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (StdVideoH265SubLayerHrdParameters** ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }
        }

        
        [NativeName("Type", "StdVideoH265SubLayerHrdParameters *[7]")]
        [NativeName("Type.Name", "StdVideoH265SubLayerHrdParameters *[7]")]
        [NativeName("Name", "pSubLayerHrdParametersVcl")]
        public PSubLayerHrdParametersVclBuffer PSubLayerHrdParametersVcl;

        public struct PSubLayerHrdParametersVclBuffer
        {
            public StdVideoH265SubLayerHrdParameters* Element0;
            public StdVideoH265SubLayerHrdParameters* Element1;
            public StdVideoH265SubLayerHrdParameters* Element2;
            public StdVideoH265SubLayerHrdParameters* Element3;
            public StdVideoH265SubLayerHrdParameters* Element4;
            public StdVideoH265SubLayerHrdParameters* Element5;
            public StdVideoH265SubLayerHrdParameters* Element6;
            public ref StdVideoH265SubLayerHrdParameters* this[int index]
            {
                get
                {
                    if (index > 6 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (StdVideoH265SubLayerHrdParameters** ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }
        }


        [NativeName("Type", "StdVideoH265HrdFlags")]
        [NativeName("Type.Name", "StdVideoH265HrdFlags")]
        [NativeName("Name", "flags")]
        public StdVideoH265HrdFlags Flags;
    }
}
