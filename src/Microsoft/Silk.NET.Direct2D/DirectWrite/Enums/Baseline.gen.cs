// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_BASELINE")]
    public enum Baseline : int
    {
        [NativeName("Name", "DWRITE_BASELINE_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "DWRITE_BASELINE_ROMAN")]
        Roman = 0x1,
        [NativeName("Name", "DWRITE_BASELINE_CENTRAL")]
        Central = 0x2,
        [NativeName("Name", "DWRITE_BASELINE_MATH")]
        Math = 0x3,
        [NativeName("Name", "DWRITE_BASELINE_HANGING")]
        Hanging = 0x4,
        [NativeName("Name", "DWRITE_BASELINE_IDEOGRAPHIC_BOTTOM")]
        IdeographicBottom = 0x5,
        [NativeName("Name", "DWRITE_BASELINE_IDEOGRAPHIC_TOP")]
        IdeographicTop = 0x6,
        [NativeName("Name", "DWRITE_BASELINE_MINIMUM")]
        Minimum = 0x7,
        [NativeName("Name", "DWRITE_BASELINE_MAXIMUM")]
        Maximum = 0x8,
    }
}
