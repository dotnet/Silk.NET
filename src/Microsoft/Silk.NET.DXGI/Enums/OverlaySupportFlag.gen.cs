// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_OVERLAY_SUPPORT_FLAG")]
    public enum OverlaySupportFlag : int
    {
        [Obsolete("Deprecated in favour of \"Direct\"")]
        [NativeName("Name", "DXGI_OVERLAY_SUPPORT_FLAG_DIRECT")]
        OverlaySupportFlagDirect = 0x1,
        [Obsolete("Deprecated in favour of \"Scaling\"")]
        [NativeName("Name", "DXGI_OVERLAY_SUPPORT_FLAG_SCALING")]
        OverlaySupportFlagScaling = 0x2,
        [NativeName("Name", "DXGI_OVERLAY_SUPPORT_FLAG_DIRECT")]
        Direct = 0x1,
        [NativeName("Name", "DXGI_OVERLAY_SUPPORT_FLAG_SCALING")]
        Scaling = 0x2,
    }
}
