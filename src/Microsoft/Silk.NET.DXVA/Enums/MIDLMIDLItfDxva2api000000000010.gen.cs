// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "__MIDL___MIDL_itf_dxva2api_0000_0000_0010")]
    public enum MIDLMIDLItfDxva2api000000000010 : int
    {
        [NativeName("Name", "DXVA2_SampleData_RFF")]
        DXVA2SampleDataRff = 0x1,
        [NativeName("Name", "DXVA2_SampleData_TFF")]
        DXVA2SampleDataTff = 0x2,
        [NativeName("Name", "DXVA2_SampleData_RFF_TFF_Present")]
        DXVA2SampleDataRffTffPresent = 0x4,
        [NativeName("Name", "DXVA2_SampleData_Mask")]
        DXVA2SampleDataMask = 0xFFFF,
    }
}
