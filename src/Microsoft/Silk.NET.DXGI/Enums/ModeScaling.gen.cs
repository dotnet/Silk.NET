// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_MODE_SCALING")]
    public enum ModeScaling : int
    {
        [Obsolete("Deprecated in favour of \"Unspecified\"")]
        [NativeName("Name", "DXGI_MODE_SCALING_UNSPECIFIED")]
        ModeScalingUnspecified = 0x0,
        [Obsolete("Deprecated in favour of \"Centered\"")]
        [NativeName("Name", "DXGI_MODE_SCALING_CENTERED")]
        ModeScalingCentered = 0x1,
        [Obsolete("Deprecated in favour of \"Stretched\"")]
        [NativeName("Name", "DXGI_MODE_SCALING_STRETCHED")]
        ModeScalingStretched = 0x2,
        [NativeName("Name", "DXGI_MODE_SCALING_UNSPECIFIED")]
        Unspecified = 0x0,
        [NativeName("Name", "DXGI_MODE_SCALING_CENTERED")]
        Centered = 0x1,
        [NativeName("Name", "DXGI_MODE_SCALING_STRETCHED")]
        Stretched = 0x2,
    }
}
