// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_TURBULENCE_PROP")]
    public enum TurbulenceProp : int
    {
        [NativeName("Name", "D2D1_TURBULENCE_PROP_OFFSET")]
        Offset = 0x0,
        [NativeName("Name", "D2D1_TURBULENCE_PROP_SIZE")]
        Size = 0x1,
        [NativeName("Name", "D2D1_TURBULENCE_PROP_BASE_FREQUENCY")]
        BaseFrequency = 0x2,
        [NativeName("Name", "D2D1_TURBULENCE_PROP_NUM_OCTAVES")]
        NumOctaves = 0x3,
        [NativeName("Name", "D2D1_TURBULENCE_PROP_SEED")]
        Seed = 0x4,
        [NativeName("Name", "D2D1_TURBULENCE_PROP_NOISE")]
        Noise = 0x5,
        [NativeName("Name", "D2D1_TURBULENCE_PROP_STITCHABLE")]
        Stitchable = 0x6,
        [NativeName("Name", "D2D1_TURBULENCE_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
