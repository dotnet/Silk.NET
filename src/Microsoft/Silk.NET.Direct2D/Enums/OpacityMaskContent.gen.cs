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
        [Obsolete("Deprecated in favour of \"Graphics\"")]
        [NativeName("Name", "D2D1_OPACITY_MASK_CONTENT_GRAPHICS")]
        OpacityMaskContentGraphics = 0x0,
        [Obsolete("Deprecated in favour of \"TextNatural\"")]
        [NativeName("Name", "D2D1_OPACITY_MASK_CONTENT_TEXT_NATURAL")]
        OpacityMaskContentTextNatural = 0x1,
        [Obsolete("Deprecated in favour of \"TextGdiCompatible\"")]
        [NativeName("Name", "D2D1_OPACITY_MASK_CONTENT_TEXT_GDI_COMPATIBLE")]
        OpacityMaskContentTextGdiCompatible = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_OPACITY_MASK_CONTENT_FORCE_DWORD")]
        OpacityMaskContentForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
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
