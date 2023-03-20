// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_HISTOGRAM_PROP")]
    public enum HistogramProp : int
    {
        [NativeName("Name", "D2D1_HISTOGRAM_PROP_NUM_BINS")]
        NumBins = 0x0,
        [NativeName("Name", "D2D1_HISTOGRAM_PROP_CHANNEL_SELECT")]
        ChannelSelect = 0x1,
        [NativeName("Name", "D2D1_HISTOGRAM_PROP_HISTOGRAM_OUTPUT")]
        HistogramOutput = 0x2,
        [NativeName("Name", "D2D1_HISTOGRAM_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
