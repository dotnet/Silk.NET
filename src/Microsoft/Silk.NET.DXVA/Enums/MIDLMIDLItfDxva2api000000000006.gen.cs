// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "__MIDL___MIDL_itf_dxva2api_0000_0000_0006")]
    public enum MIDLMIDLItfDxva2api000000000006 : int
    {
        [NativeName("Name", "DXVA2_DetailFilterTech_Unsupported")]
        DXVA2DetailFilterTechUnsupported = 0x0,
        [NativeName("Name", "DXVA2_DetailFilterTech_Unknown")]
        DXVA2DetailFilterTechUnknown = 0x1,
        [NativeName("Name", "DXVA2_DetailFilterTech_Edge")]
        DXVA2DetailFilterTechEdge = 0x2,
        [NativeName("Name", "DXVA2_DetailFilterTech_Sharpening")]
        DXVA2DetailFilterTechSharpening = 0x4,
        [NativeName("Name", "DXVA2_DetailFilterTech_Mask")]
        DXVA2DetailFilterTechMask = 0x7,
    }
}
