// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_OVERLAY_COLOR_SPACE_SUPPORT_FLAG")]
    public enum OverlayColorSpaceSupportFlag : int
    {
        [NativeName("Name", "DXGI_OVERLAY_COLOR_SPACE_SUPPORT_FLAG_PRESENT")]
        OverlayColorSpaceSupportFlagPresent = 0x1,
    }
}
