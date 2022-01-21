// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [Flags]
    [NativeName("Name", "DXGI_MODE_SCALING")]
    public enum ModeScaling : int
    {
        [NativeName("Name", "DXGI_MODE_SCALING_UNSPECIFIED")]
        ModeScalingUnspecified = 0x0,
        [NativeName("Name", "DXGI_MODE_SCALING_CENTERED")]
        ModeScalingCentered = 0x1,
        [NativeName("Name", "DXGI_MODE_SCALING_STRETCHED")]
        ModeScalingStretched = 0x2,
    }
}
