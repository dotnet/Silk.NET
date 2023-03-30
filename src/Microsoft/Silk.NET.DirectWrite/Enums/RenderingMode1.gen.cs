// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_RENDERING_MODE1")]
    public enum RenderingMode1 : int
    {
        [NativeName("Name", "DWRITE_RENDERING_MODE1_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "DWRITE_RENDERING_MODE1_ALIASED")]
        Aliased = 0x1,
        [NativeName("Name", "DWRITE_RENDERING_MODE1_GDI_CLASSIC")]
        GdiClassic = 0x2,
        [NativeName("Name", "DWRITE_RENDERING_MODE1_GDI_NATURAL")]
        GdiNatural = 0x3,
        [NativeName("Name", "DWRITE_RENDERING_MODE1_NATURAL")]
        Natural = 0x4,
        [NativeName("Name", "DWRITE_RENDERING_MODE1_NATURAL_SYMMETRIC")]
        NaturalSymmetric = 0x5,
        [NativeName("Name", "DWRITE_RENDERING_MODE1_OUTLINE")]
        Outline = 0x6,
        [NativeName("Name", "DWRITE_RENDERING_MODE1_NATURAL_SYMMETRIC_DOWNSAMPLED")]
        NaturalSymmetricDownsampled = 0x7,
    }
}
