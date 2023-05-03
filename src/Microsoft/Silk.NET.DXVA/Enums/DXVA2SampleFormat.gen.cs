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
        [Obsolete("Deprecated in favour of \"FormatMask\"")]
        [NativeName("Name", "DXVA2_SampleFormatMask")]
        DXVA2SampleFormatMask = 0xFF,
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "DXVA2_SampleUnknown")]
        DXVA2SampleUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"ProgressiveFrame\"")]
        [NativeName("Name", "DXVA2_SampleProgressiveFrame")]
        DXVA2SampleProgressiveFrame = 0x2,
        [Obsolete("Deprecated in favour of \"FieldInterleavedEvenFirst\"")]
        [NativeName("Name", "DXVA2_SampleFieldInterleavedEvenFirst")]
        DXVA2SampleFieldInterleavedEvenFirst = 0x3,
        [Obsolete("Deprecated in favour of \"FieldInterleavedOddFirst\"")]
        [NativeName("Name", "DXVA2_SampleFieldInterleavedOddFirst")]
        DXVA2SampleFieldInterleavedOddFirst = 0x4,
        [Obsolete("Deprecated in favour of \"FieldSingleEven\"")]
        [NativeName("Name", "DXVA2_SampleFieldSingleEven")]
        DXVA2SampleFieldSingleEven = 0x5,
        [Obsolete("Deprecated in favour of \"FieldSingleOdd\"")]
        [NativeName("Name", "DXVA2_SampleFieldSingleOdd")]
        DXVA2SampleFieldSingleOdd = 0x6,
        [Obsolete("Deprecated in favour of \"SubStream\"")]
        [NativeName("Name", "DXVA2_SampleSubStream")]
        DXVA2SampleSubStream = 0x7,
        [NativeName("Name", "DXVA2_SampleFormatMask")]
        FormatMask = 0xFF,
        [NativeName("Name", "DXVA2_SampleUnknown")]
        Unknown = 0x0,
        [NativeName("Name", "DXVA2_SampleProgressiveFrame")]
        ProgressiveFrame = 0x2,
        [NativeName("Name", "DXVA2_SampleFieldInterleavedEvenFirst")]
        FieldInterleavedEvenFirst = 0x3,
        [NativeName("Name", "DXVA2_SampleFieldInterleavedOddFirst")]
        FieldInterleavedOddFirst = 0x4,
        [NativeName("Name", "DXVA2_SampleFieldSingleEven")]
        FieldSingleEven = 0x5,
        [NativeName("Name", "DXVA2_SampleFieldSingleOdd")]
        FieldSingleOdd = 0x6,
        [NativeName("Name", "DXVA2_SampleSubStream")]
        SubStream = 0x7,
        [Obsolete("Deprecated in favour of \"FormatMask\"")]
        [NativeName("Name", "DXVA2_SampleFormatMask")]
        SampleFormatMask = 0xFF,
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "DXVA2_SampleUnknown")]
        SampleUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"ProgressiveFrame\"")]
        [NativeName("Name", "DXVA2_SampleProgressiveFrame")]
        SampleProgressiveFrame = 0x2,
        [Obsolete("Deprecated in favour of \"FieldInterleavedEvenFirst\"")]
        [NativeName("Name", "DXVA2_SampleFieldInterleavedEvenFirst")]
        SampleFieldInterleavedEvenFirst = 0x3,
        [Obsolete("Deprecated in favour of \"FieldInterleavedOddFirst\"")]
        [NativeName("Name", "DXVA2_SampleFieldInterleavedOddFirst")]
        SampleFieldInterleavedOddFirst = 0x4,
        [Obsolete("Deprecated in favour of \"FieldSingleEven\"")]
        [NativeName("Name", "DXVA2_SampleFieldSingleEven")]
        SampleFieldSingleEven = 0x5,
        [Obsolete("Deprecated in favour of \"FieldSingleOdd\"")]
        [NativeName("Name", "DXVA2_SampleFieldSingleOdd")]
        SampleFieldSingleOdd = 0x6,
        [Obsolete("Deprecated in favour of \"SubStream\"")]
        [NativeName("Name", "DXVA2_SampleSubStream")]
        SampleSubStream = 0x7,
    }
}
