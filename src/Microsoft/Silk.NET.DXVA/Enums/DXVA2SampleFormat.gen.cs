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
        [Obsolete("Deprecated in favour of \"SampleFormatMask\"")]
        [NativeName("Name", "DXVA2_SampleFormatMask")]
        DXVA2SampleFormatMask = 0xFF,
        [Obsolete("Deprecated in favour of \"SampleUnknown\"")]
        [NativeName("Name", "DXVA2_SampleUnknown")]
        DXVA2SampleUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"SampleProgressiveFrame\"")]
        [NativeName("Name", "DXVA2_SampleProgressiveFrame")]
        DXVA2SampleProgressiveFrame = 0x2,
        [Obsolete("Deprecated in favour of \"SampleFieldInterleavedEvenFirst\"")]
        [NativeName("Name", "DXVA2_SampleFieldInterleavedEvenFirst")]
        DXVA2SampleFieldInterleavedEvenFirst = 0x3,
        [Obsolete("Deprecated in favour of \"SampleFieldInterleavedOddFirst\"")]
        [NativeName("Name", "DXVA2_SampleFieldInterleavedOddFirst")]
        DXVA2SampleFieldInterleavedOddFirst = 0x4,
        [Obsolete("Deprecated in favour of \"SampleFieldSingleEven\"")]
        [NativeName("Name", "DXVA2_SampleFieldSingleEven")]
        DXVA2SampleFieldSingleEven = 0x5,
        [Obsolete("Deprecated in favour of \"SampleFieldSingleOdd\"")]
        [NativeName("Name", "DXVA2_SampleFieldSingleOdd")]
        DXVA2SampleFieldSingleOdd = 0x6,
        [Obsolete("Deprecated in favour of \"SampleSubStream\"")]
        [NativeName("Name", "DXVA2_SampleSubStream")]
        DXVA2SampleSubStream = 0x7,
        [NativeName("Name", "DXVA2_SampleFormatMask")]
        SampleFormatMask = 0xFF,
        [NativeName("Name", "DXVA2_SampleUnknown")]
        SampleUnknown = 0x0,
        [NativeName("Name", "DXVA2_SampleProgressiveFrame")]
        SampleProgressiveFrame = 0x2,
        [NativeName("Name", "DXVA2_SampleFieldInterleavedEvenFirst")]
        SampleFieldInterleavedEvenFirst = 0x3,
        [NativeName("Name", "DXVA2_SampleFieldInterleavedOddFirst")]
        SampleFieldInterleavedOddFirst = 0x4,
        [NativeName("Name", "DXVA2_SampleFieldSingleEven")]
        SampleFieldSingleEven = 0x5,
        [NativeName("Name", "DXVA2_SampleFieldSingleOdd")]
        SampleFieldSingleOdd = 0x6,
        [NativeName("Name", "DXVA2_SampleSubStream")]
        SampleSubStream = 0x7,
    }
}
