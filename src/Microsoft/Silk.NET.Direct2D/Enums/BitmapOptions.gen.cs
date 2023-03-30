// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_BITMAP_OPTIONS")]
    public enum BitmapOptions : int
    {
        [NativeName("Name", "D2D1_BITMAP_OPTIONS_NONE")]
        None = 0x0,
        [NativeName("Name", "D2D1_BITMAP_OPTIONS_TARGET")]
        Target = 0x1,
        [NativeName("Name", "D2D1_BITMAP_OPTIONS_CANNOT_DRAW")]
        CannotDraw = 0x2,
        [NativeName("Name", "D2D1_BITMAP_OPTIONS_CPU_READ")]
        CpuRead = 0x4,
        [NativeName("Name", "D2D1_BITMAP_OPTIONS_GDI_COMPATIBLE")]
        GdiCompatible = 0x8,
        [NativeName("Name", "D2D1_BITMAP_OPTIONS_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
