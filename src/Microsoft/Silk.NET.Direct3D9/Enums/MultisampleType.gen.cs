// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DMULTISAMPLE_TYPE")]
    public enum MultisampleType : int
    {
        [NativeName("Name", "D3DMULTISAMPLE_NONE")]
        MultisampleNone = 0x0,
        [NativeName("Name", "D3DMULTISAMPLE_NONMASKABLE")]
        MultisampleNonmaskable = 0x1,
        [NativeName("Name", "D3DMULTISAMPLE_2_SAMPLES")]
        Multisample2Samples = 0x2,
        [NativeName("Name", "D3DMULTISAMPLE_3_SAMPLES")]
        Multisample3Samples = 0x3,
        [NativeName("Name", "D3DMULTISAMPLE_4_SAMPLES")]
        Multisample4Samples = 0x4,
        [NativeName("Name", "D3DMULTISAMPLE_5_SAMPLES")]
        Multisample5Samples = 0x5,
        [NativeName("Name", "D3DMULTISAMPLE_6_SAMPLES")]
        Multisample6Samples = 0x6,
        [NativeName("Name", "D3DMULTISAMPLE_7_SAMPLES")]
        Multisample7Samples = 0x7,
        [NativeName("Name", "D3DMULTISAMPLE_8_SAMPLES")]
        Multisample8Samples = 0x8,
        [NativeName("Name", "D3DMULTISAMPLE_9_SAMPLES")]
        Multisample9Samples = 0x9,
        [NativeName("Name", "D3DMULTISAMPLE_10_SAMPLES")]
        Multisample10Samples = 0xA,
        [NativeName("Name", "D3DMULTISAMPLE_11_SAMPLES")]
        Multisample11Samples = 0xB,
        [NativeName("Name", "D3DMULTISAMPLE_12_SAMPLES")]
        Multisample12Samples = 0xC,
        [NativeName("Name", "D3DMULTISAMPLE_13_SAMPLES")]
        Multisample13Samples = 0xD,
        [NativeName("Name", "D3DMULTISAMPLE_14_SAMPLES")]
        Multisample14Samples = 0xE,
        [NativeName("Name", "D3DMULTISAMPLE_15_SAMPLES")]
        Multisample15Samples = 0xF,
        [NativeName("Name", "D3DMULTISAMPLE_16_SAMPLES")]
        Multisample16Samples = 0x10,
        [NativeName("Name", "D3DMULTISAMPLE_FORCE_DWORD")]
        MultisampleForceDword = 0x7FFFFFFF,
    }
}
