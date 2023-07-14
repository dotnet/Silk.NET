// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVA_SampleFormat")]
    public enum SampleFormat : int
    {
        [Obsolete("Deprecated in favour of \"FormatMask\"")]
        [NativeName("Name", "DXVA_SampleFormatMask")]
        SampleFormatMask = 0xFF,
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "DXVA_SampleUnknown")]
        SampleUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"PreviousFrame\"")]
        [NativeName("Name", "DXVA_SamplePreviousFrame")]
        SamplePreviousFrame = 0x1,
        [Obsolete("Deprecated in favour of \"ProgressiveFrame\"")]
        [NativeName("Name", "DXVA_SampleProgressiveFrame")]
        SampleProgressiveFrame = 0x2,
        [Obsolete("Deprecated in favour of \"FieldInterleavedEvenFirst\"")]
        [NativeName("Name", "DXVA_SampleFieldInterleavedEvenFirst")]
        SampleFieldInterleavedEvenFirst = 0x3,
        [Obsolete("Deprecated in favour of \"FieldInterleavedOddFirst\"")]
        [NativeName("Name", "DXVA_SampleFieldInterleavedOddFirst")]
        SampleFieldInterleavedOddFirst = 0x4,
        [Obsolete("Deprecated in favour of \"FieldSingleEven\"")]
        [NativeName("Name", "DXVA_SampleFieldSingleEven")]
        SampleFieldSingleEven = 0x5,
        [Obsolete("Deprecated in favour of \"FieldSingleOdd\"")]
        [NativeName("Name", "DXVA_SampleFieldSingleOdd")]
        SampleFieldSingleOdd = 0x6,
        [Obsolete("Deprecated in favour of \"SubStream\"")]
        [NativeName("Name", "DXVA_SampleSubStream")]
        SampleSubStream = 0x7,
        [NativeName("Name", "DXVA_SampleFormatMask")]
        FormatMask = 0xFF,
        [NativeName("Name", "DXVA_SampleUnknown")]
        Unknown = 0x0,
        [NativeName("Name", "DXVA_SamplePreviousFrame")]
        PreviousFrame = 0x1,
        [NativeName("Name", "DXVA_SampleProgressiveFrame")]
        ProgressiveFrame = 0x2,
        [NativeName("Name", "DXVA_SampleFieldInterleavedEvenFirst")]
        FieldInterleavedEvenFirst = 0x3,
        [NativeName("Name", "DXVA_SampleFieldInterleavedOddFirst")]
        FieldInterleavedOddFirst = 0x4,
        [NativeName("Name", "DXVA_SampleFieldSingleEven")]
        FieldSingleEven = 0x5,
        [NativeName("Name", "DXVA_SampleFieldSingleOdd")]
        FieldSingleOdd = 0x6,
        [NativeName("Name", "DXVA_SampleSubStream")]
        SubStream = 0x7,
    }
}
