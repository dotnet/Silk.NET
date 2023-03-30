// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_OPACITY_MASK_CONTENT")]
    public enum OpacityMaskContent : int
    {
        [NativeName("Name", "D2D1_OPACITY_MASK_CONTENT_GRAPHICS")]
        Graphics = 0x0,
        [NativeName("Name", "D2D1_OPACITY_MASK_CONTENT_TEXT_NATURAL")]
        TextNatural = 0x1,
        [NativeName("Name", "D2D1_OPACITY_MASK_CONTENT_TEXT_GDI_COMPATIBLE")]
        TextGdiCompatible = 0x2,
        [NativeName("Name", "D2D1_OPACITY_MASK_CONTENT_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
