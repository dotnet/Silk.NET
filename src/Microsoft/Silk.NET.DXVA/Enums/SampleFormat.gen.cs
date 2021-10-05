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
        [NativeName("Name", "DXVA_SampleFormatMask")]
        SampleFormatMask = 0xFF,
        [NativeName("Name", "DXVA_SampleUnknown")]
        SampleUnknown = 0x0,
        [NativeName("Name", "DXVA_SamplePreviousFrame")]
        SamplePreviousFrame = 0x1,
        [NativeName("Name", "DXVA_SampleProgressiveFrame")]
        SampleProgressiveFrame = 0x2,
        [NativeName("Name", "DXVA_SampleFieldInterleavedEvenFirst")]
        SampleFieldInterleavedEvenFirst = 0x3,
        [NativeName("Name", "DXVA_SampleFieldInterleavedOddFirst")]
        SampleFieldInterleavedOddFirst = 0x4,
        [NativeName("Name", "DXVA_SampleFieldSingleEven")]
        SampleFieldSingleEven = 0x5,
        [NativeName("Name", "DXVA_SampleFieldSingleOdd")]
        SampleFieldSingleOdd = 0x6,
        [NativeName("Name", "DXVA_SampleSubStream")]
        SampleSubStream = 0x7,
    }
}
