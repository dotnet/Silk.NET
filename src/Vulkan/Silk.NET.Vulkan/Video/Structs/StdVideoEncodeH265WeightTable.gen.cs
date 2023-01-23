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
    [NativeName("Name", "StdVideoEncodeH265WeightTable")]
    public unsafe partial struct StdVideoEncodeH265WeightTable
    {
        public StdVideoEncodeH265WeightTable
        (
            StdVideoEncodeH265WeightTableFlags? flags = null,
            byte? lumaLog2WeightDenom = null,
            byte? deltaChromaLog2WeightDenom = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (lumaLog2WeightDenom is not null)
            {
                LumaLog2WeightDenom = lumaLog2WeightDenom.Value;
            }

            if (deltaChromaLog2WeightDenom is not null)
            {
                DeltaChromaLog2WeightDenom = deltaChromaLog2WeightDenom.Value;
            }
        }


        [NativeName("Type", "StdVideoEncodeH265WeightTableFlags")]
        [NativeName("Type.Name", "StdVideoEncodeH265WeightTableFlags")]
        [NativeName("Name", "flags")]
        public StdVideoEncodeH265WeightTableFlags Flags;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "luma_log2_weight_denom")]
        public byte LumaLog2WeightDenom;

        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "delta_chroma_log2_weight_denom")]
        public byte DeltaChromaLog2WeightDenom;
        [NativeName("Type", "int8_t[15]")]
        [NativeName("Type.Name", "int8_t[15]")]
        [NativeName("Name", "delta_luma_weight_l0")]
        public fixed byte DeltaLumaWeightL0[15];
        [NativeName("Type", "int8_t[15]")]
        [NativeName("Type.Name", "int8_t[15]")]
        [NativeName("Name", "luma_offset_l0")]
        public fixed byte LumaOffsetL0[15];
        [NativeName("Type", "int8_t[15][2]")]
        [NativeName("Type.Name", "int8_t[15][2]")]
        [NativeName("Name", "delta_chroma_weight_l0")]
        public fixed byte DeltaChromaWeightL0[30];
        [NativeName("Type", "int8_t[15][2]")]
        [NativeName("Type.Name", "int8_t[15][2]")]
        [NativeName("Name", "delta_chroma_offset_l0")]
        public fixed byte DeltaChromaOffsetL0[30];
        [NativeName("Type", "int8_t[15]")]
        [NativeName("Type.Name", "int8_t[15]")]
        [NativeName("Name", "delta_luma_weight_l1")]
        public fixed byte DeltaLumaWeightL1[15];
        [NativeName("Type", "int8_t[15]")]
        [NativeName("Type.Name", "int8_t[15]")]
        [NativeName("Name", "luma_offset_l1")]
        public fixed byte LumaOffsetL1[15];
        [NativeName("Type", "int8_t[15][2]")]
        [NativeName("Type.Name", "int8_t[15][2]")]
        [NativeName("Name", "delta_chroma_weight_l1")]
        public fixed byte DeltaChromaWeightL1[30];
        [NativeName("Type", "int8_t[15][2]")]
        [NativeName("Type.Name", "int8_t[15][2]")]
        [NativeName("Name", "delta_chroma_offset_l1")]
        public fixed byte DeltaChromaOffsetL1[30];
    }
}
