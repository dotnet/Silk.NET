// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "DWRITE_MEASURING_MODE")]
    public enum DwriteMeasuringMode : int
    {
        [NativeName("Name", "DWRITE_MEASURING_MODE_NATURAL")]
        Natural = 0x0,
        [NativeName("Name", "DWRITE_MEASURING_MODE_GDI_CLASSIC")]
        GdiClassic = 0x1,
        [NativeName("Name", "DWRITE_MEASURING_MODE_GDI_NATURAL")]
        GdiNatural = 0x2,
    }
}
