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
    [NativeName("Name", "StdVideoH265SubLayerHrdParameters")]
    public unsafe partial struct StdVideoH265SubLayerHrdParameters
    {
        public StdVideoH265SubLayerHrdParameters
        (
            uint? cbrFlag = null
        ) : this()
        {
            if (cbrFlag is not null)
            {
                CbrFlag = cbrFlag.Value;
            }
        }

        [NativeName("Type", "uint32_t[32]")]
        [NativeName("Type.Name", "uint32_t[32]")]
        [NativeName("Name", "bit_rate_value_minus1")]
        public fixed uint BitRateValueMinus1[32];
        [NativeName("Type", "uint32_t[32]")]
        [NativeName("Type.Name", "uint32_t[32]")]
        [NativeName("Name", "cpb_size_value_minus1")]
        public fixed uint CpbSizeValueMinus1[32];
        [NativeName("Type", "uint32_t[32]")]
        [NativeName("Type.Name", "uint32_t[32]")]
        [NativeName("Name", "cpb_size_du_value_minus1")]
        public fixed uint CpbSizeDuValueMinus1[32];
        [NativeName("Type", "uint32_t[32]")]
        [NativeName("Type.Name", "uint32_t[32]")]
        [NativeName("Name", "bit_rate_du_value_minus1")]
        public fixed uint BitRateDuValueMinus1[32];

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "cbr_flag")]
        public uint CbrFlag;
    }
}
