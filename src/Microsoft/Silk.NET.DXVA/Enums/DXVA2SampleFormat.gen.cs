// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVA2_SampleFormat")]
    public enum DXVA2SampleFormat : int
    {
        [NativeName("Name", "DXVA2_SampleFormatMask")]
        DXVA2SampleFormatMask = 0xFF,
        [NativeName("Name", "DXVA2_SampleUnknown")]
        DXVA2SampleUnknown = 0x0,
        [NativeName("Name", "DXVA2_SampleProgressiveFrame")]
        DXVA2SampleProgressiveFrame = 0x2,
        [NativeName("Name", "DXVA2_SampleFieldInterleavedEvenFirst")]
        DXVA2SampleFieldInterleavedEvenFirst = 0x3,
        [NativeName("Name", "DXVA2_SampleFieldInterleavedOddFirst")]
        DXVA2SampleFieldInterleavedOddFirst = 0x4,
        [NativeName("Name", "DXVA2_SampleFieldSingleEven")]
        DXVA2SampleFieldSingleEven = 0x5,
        [NativeName("Name", "DXVA2_SampleFieldSingleOdd")]
        DXVA2SampleFieldSingleOdd = 0x6,
        [NativeName("Name", "DXVA2_SampleSubStream")]
        DXVA2SampleSubStream = 0x7,
    }
}
