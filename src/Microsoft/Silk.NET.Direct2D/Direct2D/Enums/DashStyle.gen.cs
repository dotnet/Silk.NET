// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_DASH_STYLE")]
    public enum DashStyle : int
    {
        [NativeName("Name", "D2D1_DASH_STYLE_SOLID")]
        Solid = 0x0,
        [NativeName("Name", "D2D1_DASH_STYLE_DASH")]
        Dash = 0x1,
        [NativeName("Name", "D2D1_DASH_STYLE_DOT")]
        Dot = 0x2,
        [NativeName("Name", "D2D1_DASH_STYLE_DASH_DOT")]
        DashDot = 0x3,
        [NativeName("Name", "D2D1_DASH_STYLE_DASH_DOT_DOT")]
        DashDotDot = 0x4,
        [NativeName("Name", "D2D1_DASH_STYLE_CUSTOM")]
        Custom = 0x5,
        [NativeName("Name", "D2D1_DASH_STYLE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
