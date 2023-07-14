// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_COLOR_SPACE")]
    public enum ColorSpace : int
    {
        [NativeName("Name", "D2D1_COLOR_SPACE_CUSTOM")]
        Custom = 0x0,
        [NativeName("Name", "D2D1_COLOR_SPACE_SRGB")]
        Srgb = 0x1,
        [NativeName("Name", "D2D1_COLOR_SPACE_SCRGB")]
        Scrgb = 0x2,
        [NativeName("Name", "D2D1_COLOR_SPACE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
