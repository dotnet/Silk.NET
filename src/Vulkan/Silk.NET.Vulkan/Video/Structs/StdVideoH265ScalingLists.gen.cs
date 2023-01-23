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
    [NativeName("Name", "StdVideoH265ScalingLists")]
    public unsafe partial struct StdVideoH265ScalingLists
    {
        [NativeName("Type", "uint8_t[6][16]")]
        [NativeName("Type.Name", "uint8_t[6][16]")]
        [NativeName("Name", "ScalingList4x4")]
        public fixed byte ScalingList4x4[96];
        [NativeName("Type", "uint8_t[6][64]")]
        [NativeName("Type.Name", "uint8_t[6][64]")]
        [NativeName("Name", "ScalingList8x8")]
        public fixed byte ScalingList8x8[384];
        [NativeName("Type", "uint8_t[6][64]")]
        [NativeName("Type.Name", "uint8_t[6][64]")]
        [NativeName("Name", "ScalingList16x16")]
        public fixed byte ScalingList16x16[384];
        [NativeName("Type", "uint8_t[2][64]")]
        [NativeName("Type.Name", "uint8_t[2][64]")]
        [NativeName("Name", "ScalingList32x32")]
        public fixed byte ScalingList32x32[128];
        [NativeName("Type", "uint8_t[6]")]
        [NativeName("Type.Name", "uint8_t[6]")]
        [NativeName("Name", "ScalingListDCCoef16x16")]
        public fixed byte ScalingListDCCoef16x16[6];
        [NativeName("Type", "uint8_t[2]")]
        [NativeName("Type.Name", "uint8_t[2]")]
        [NativeName("Name", "ScalingListDCCoef32x32")]
        public fixed byte ScalingListDCCoef32x32[2];
    }
}
