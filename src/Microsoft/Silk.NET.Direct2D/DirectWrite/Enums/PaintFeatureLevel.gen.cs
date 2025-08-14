// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PAINT_FEATURE_LEVEL")]
    public enum PaintFeatureLevel : int
    {
        [NativeName("Name", "DWRITE_PAINT_FEATURE_LEVEL_NONE")]
        None = 0x0,
        [NativeName("Name", "DWRITE_PAINT_FEATURE_LEVEL_COLR_V0")]
        ColrV0 = 0x1,
        [NativeName("Name", "DWRITE_PAINT_FEATURE_LEVEL_COLR_V1")]
        ColrV1 = 0x2,
    }
}
