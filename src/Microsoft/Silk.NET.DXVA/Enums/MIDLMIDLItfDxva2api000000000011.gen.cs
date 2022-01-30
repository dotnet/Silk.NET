// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "__MIDL___MIDL_itf_dxva2api_0000_0000_0011")]
    public enum MIDLMIDLItfDxva2api000000000011 : int
    {
        [NativeName("Name", "DXVA2_DestData_RFF")]
        DXVA2DestDataRff = 0x1,
        [NativeName("Name", "DXVA2_DestData_TFF")]
        DXVA2DestDataTff = 0x2,
        [NativeName("Name", "DXVA2_DestData_RFF_TFF_Present")]
        DXVA2DestDataRffTffPresent = 0x4,
        [NativeName("Name", "DXVA2_DestData_Mask")]
        DXVA2DestDataMask = 0xFFFF,
    }
}
