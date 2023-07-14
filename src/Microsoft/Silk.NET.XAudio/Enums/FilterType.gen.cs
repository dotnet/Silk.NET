// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.XAudio
{
    [NativeName("Name", "XAUDIO2_FILTER_TYPE")]
    public enum FilterType : int
    {
        [NativeName("Name", "LowPassFilter")]
        LowPassFilter = 0x0,
        [NativeName("Name", "BandPassFilter")]
        BandPassFilter = 0x1,
        [NativeName("Name", "HighPassFilter")]
        HighPassFilter = 0x2,
        [NativeName("Name", "NotchFilter")]
        NotchFilter = 0x3,
        [NativeName("Name", "LowPassOnePoleFilter")]
        LowPassOnePoleFilter = 0x4,
        [NativeName("Name", "HighPassOnePoleFilter")]
        HighPassOnePoleFilter = 0x5,
    }
}
