// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "__MIDL___MIDL_itf_dxva2api_0000_0000_0009")]
    public enum MIDLMIDLItfDxva2api000000000009 : int
    {
        [NativeName("Name", "DXVA2_VPDev_HardwareDevice")]
        DXVA2VpdevHardwareDevice = 0x1,
        [NativeName("Name", "DXVA2_VPDev_EmulatedDXVA1")]
        DXVA2VpdevEmulatedDxva1 = 0x2,
        [NativeName("Name", "DXVA2_VPDev_SoftwareDevice")]
        DXVA2VpdevSoftwareDevice = 0x4,
        [NativeName("Name", "DXVA2_VPDev_Mask")]
        DXVA2VpdevMask = 0x7,
    }
}
