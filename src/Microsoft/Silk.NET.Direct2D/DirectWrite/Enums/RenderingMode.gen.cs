// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [Flags]
    [NativeName("Name", "DWRITE_RENDERING_MODE")]
    public enum RenderingMode : int
    {
        [NativeName("Name", "DWRITE_RENDERING_MODE_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "DWRITE_RENDERING_MODE_ALIASED")]
        Aliased = 0x1,
        [NativeName("Name", "DWRITE_RENDERING_MODE_GDI_CLASSIC")]
        GdiClassic = 0x2,
        [NativeName("Name", "DWRITE_RENDERING_MODE_GDI_NATURAL")]
        GdiNatural = 0x3,
        [NativeName("Name", "DWRITE_RENDERING_MODE_NATURAL")]
        Natural = 0x4,
        [NativeName("Name", "DWRITE_RENDERING_MODE_NATURAL_SYMMETRIC")]
        NaturalSymmetric = 0x5,
        [NativeName("Name", "DWRITE_RENDERING_MODE_OUTLINE")]
        Outline = 0x6,
        [NativeName("Name", "DWRITE_RENDERING_MODE_CLEARTYPE_GDI_CLASSIC")]
        CleartypeGdiClassic = 0x2,
        [NativeName("Name", "DWRITE_RENDERING_MODE_CLEARTYPE_GDI_NATURAL")]
        CleartypeGdiNatural = 0x3,
        [NativeName("Name", "DWRITE_RENDERING_MODE_CLEARTYPE_NATURAL")]
        CleartypeNatural = 0x4,
        [NativeName("Name", "DWRITE_RENDERING_MODE_CLEARTYPE_NATURAL_SYMMETRIC")]
        CleartypeNaturalSymmetric = 0x5,
    }
}
