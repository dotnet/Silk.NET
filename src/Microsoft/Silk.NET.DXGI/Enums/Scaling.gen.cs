// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_SCALING")]
    public enum Scaling : int
    {
        [Obsolete("Deprecated in favour of \"Stretch\"")]
        [NativeName("Name", "DXGI_SCALING_STRETCH")]
        ScalingStretch = 0x0,
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "DXGI_SCALING_NONE")]
        ScalingNone = 0x1,
        [Obsolete("Deprecated in favour of \"AspectRatioStretch\"")]
        [NativeName("Name", "DXGI_SCALING_ASPECT_RATIO_STRETCH")]
        ScalingAspectRatioStretch = 0x2,
        [NativeName("Name", "DXGI_SCALING_STRETCH")]
        Stretch = 0x0,
        [NativeName("Name", "DXGI_SCALING_NONE")]
        None = 0x1,
        [NativeName("Name", "DXGI_SCALING_ASPECT_RATIO_STRETCH")]
        AspectRatioStretch = 0x2,
    }
}
