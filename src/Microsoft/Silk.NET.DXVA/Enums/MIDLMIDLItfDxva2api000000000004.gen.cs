// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "__MIDL___MIDL_itf_dxva2api_0000_0000_0004")]
    public enum MIDLMIDLItfDxva2api000000000004 : int
    {
        [NativeName("Name", "DXVA2_NoiseFilterLumaLevel")]
        DXVA2NoiseFilterLumaLevel = 0x1,
        [NativeName("Name", "DXVA2_NoiseFilterLumaThreshold")]
        DXVA2NoiseFilterLumaThreshold = 0x2,
        [NativeName("Name", "DXVA2_NoiseFilterLumaRadius")]
        DXVA2NoiseFilterLumaRadius = 0x3,
        [NativeName("Name", "DXVA2_NoiseFilterChromaLevel")]
        DXVA2NoiseFilterChromaLevel = 0x4,
        [NativeName("Name", "DXVA2_NoiseFilterChromaThreshold")]
        DXVA2NoiseFilterChromaThreshold = 0x5,
        [NativeName("Name", "DXVA2_NoiseFilterChromaRadius")]
        DXVA2NoiseFilterChromaRadius = 0x6,
        [NativeName("Name", "DXVA2_DetailFilterLumaLevel")]
        DXVA2DetailFilterLumaLevel = 0x7,
        [NativeName("Name", "DXVA2_DetailFilterLumaThreshold")]
        DXVA2DetailFilterLumaThreshold = 0x8,
        [NativeName("Name", "DXVA2_DetailFilterLumaRadius")]
        DXVA2DetailFilterLumaRadius = 0x9,
        [NativeName("Name", "DXVA2_DetailFilterChromaLevel")]
        DXVA2DetailFilterChromaLevel = 0xA,
        [NativeName("Name", "DXVA2_DetailFilterChromaThreshold")]
        DXVA2DetailFilterChromaThreshold = 0xB,
        [NativeName("Name", "DXVA2_DetailFilterChromaRadius")]
        DXVA2DetailFilterChromaRadius = 0xC,
    }
}
