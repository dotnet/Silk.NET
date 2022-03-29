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
    [NativeName("Name", "StdVideoEncodeH265WeightTableFlags")]
    public unsafe partial struct StdVideoEncodeH265WeightTableFlags
    {
        public StdVideoEncodeH265WeightTableFlags
        (
            ushort? lumaWeightL0Flag = null,
            ushort? chromaWeightL0Flag = null,
            ushort? lumaWeightL1Flag = null,
            ushort? chromaWeightL1Flag = null
        ) : this()
        {
            if (lumaWeightL0Flag is not null)
            {
                LumaWeightL0Flag = lumaWeightL0Flag.Value;
            }

            if (chromaWeightL0Flag is not null)
            {
                ChromaWeightL0Flag = chromaWeightL0Flag.Value;
            }

            if (lumaWeightL1Flag is not null)
            {
                LumaWeightL1Flag = lumaWeightL1Flag.Value;
            }

            if (chromaWeightL1Flag is not null)
            {
                ChromaWeightL1Flag = chromaWeightL1Flag.Value;
            }
        }


        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "luma_weight_l0_flag")]
        public ushort LumaWeightL0Flag;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "chroma_weight_l0_flag")]
        public ushort ChromaWeightL0Flag;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "luma_weight_l1_flag")]
        public ushort LumaWeightL1Flag;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "chroma_weight_l1_flag")]
        public ushort ChromaWeightL1Flag;
    }
}
