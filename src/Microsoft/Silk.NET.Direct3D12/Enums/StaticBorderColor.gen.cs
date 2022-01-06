// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_STATIC_BORDER_COLOR")]
    public enum StaticBorderColor : int
    {
        [NativeName("Name", "D3D12_STATIC_BORDER_COLOR_TRANSPARENT_BLACK")]
        StaticBorderColorTransparentBlack = 0x0,
        [NativeName("Name", "D3D12_STATIC_BORDER_COLOR_OPAQUE_BLACK")]
        StaticBorderColorOpaqueBlack = 0x1,
        [NativeName("Name", "D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE")]
        StaticBorderColorOpaqueWhite = 0x2,
    }
}
