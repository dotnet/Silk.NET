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
    [NativeName("Name", "StdVideoEncodeH264WeightTable")]
    public unsafe partial struct StdVideoEncodeH264WeightTable
    {
        public StdVideoEncodeH264WeightTable
        (
            StdVideoEncodeH264WeightTableFlags? flags = null,
            byte? lumaLog2WeightDenom = null,
            byte? chromaLog2WeightDenom = null
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

            if (chromaLog2WeightDenom is not null)
            {
                ChromaLog2WeightDenom = chromaLog2WeightDenom.Value;
            }
        }


        [NativeName("Type", "StdVideoEncodeH264WeightTableFlags")]
        [NativeName("Type.Name", "StdVideoEncodeH264WeightTableFlags")]
        [NativeName("Name", "flags")]
        public StdVideoEncodeH264WeightTableFlags Flags;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "luma_log2_weight_denom")]
        public byte LumaLog2WeightDenom;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "chroma_log2_weight_denom")]
        public byte ChromaLog2WeightDenom;
        [NativeName("Type", "int8_t[32]")]
        [NativeName("Type.Name", "int8_t[32]")]
        [NativeName("Name", "luma_weight_l0")]
        public fixed byte LumaWeightL0[32];
        [NativeName("Type", "int8_t[32]")]
        [NativeName("Type.Name", "int8_t[32]")]
        [NativeName("Name", "luma_offset_l0")]
        public fixed byte LumaOffsetL0[32];
        [NativeName("Type", "int8_t[32][2]")]
        [NativeName("Type.Name", "int8_t[32][2]")]
        [NativeName("Name", "chroma_weight_l0")]
        public fixed byte ChromaWeightL0[64];
        [NativeName("Type", "int8_t[32][2]")]
        [NativeName("Type.Name", "int8_t[32][2]")]
        [NativeName("Name", "chroma_offset_l0")]
        public fixed byte ChromaOffsetL0[64];
        [NativeName("Type", "int8_t[32]")]
        [NativeName("Type.Name", "int8_t[32]")]
        [NativeName("Name", "luma_weight_l1")]
        public fixed byte LumaWeightL1[32];
        [NativeName("Type", "int8_t[32]")]
        [NativeName("Type.Name", "int8_t[32]")]
        [NativeName("Name", "luma_offset_l1")]
        public fixed byte LumaOffsetL1[32];
        [NativeName("Type", "int8_t[32][2]")]
        [NativeName("Type.Name", "int8_t[32][2]")]
        [NativeName("Name", "chroma_weight_l1")]
        public fixed byte ChromaWeightL1[64];
        [NativeName("Type", "int8_t[32][2]")]
        [NativeName("Type.Name", "int8_t[32][2]")]
        [NativeName("Name", "chroma_offset_l1")]
        public fixed byte ChromaOffsetL1[64];
    }
}
