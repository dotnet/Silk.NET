// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [Flags]
    [NativeName("Name", "WGPUColorWriteMask")]
    public enum ColorWriteMask : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "WGPUColorWriteMask_None")]
        ColorWriteMaskNone = 0x0,
        [Obsolete("Deprecated in favour of \"Red\"")]
        [NativeName("Name", "WGPUColorWriteMask_Red")]
        ColorWriteMaskRed = 0x1,
        [Obsolete("Deprecated in favour of \"Green\"")]
        [NativeName("Name", "WGPUColorWriteMask_Green")]
        ColorWriteMaskGreen = 0x2,
        [Obsolete("Deprecated in favour of \"Blue\"")]
        [NativeName("Name", "WGPUColorWriteMask_Blue")]
        ColorWriteMaskBlue = 0x4,
        [Obsolete("Deprecated in favour of \"Alpha\"")]
        [NativeName("Name", "WGPUColorWriteMask_Alpha")]
        ColorWriteMaskAlpha = 0x8,
        [Obsolete("Deprecated in favour of \"All\"")]
        [NativeName("Name", "WGPUColorWriteMask_All")]
        ColorWriteMaskAll = 0xF,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUColorWriteMask_Force32")]
        ColorWriteMaskForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPUColorWriteMask_None")]
        None = 0x0,
        [NativeName("Name", "WGPUColorWriteMask_Red")]
        Red = 0x1,
        [NativeName("Name", "WGPUColorWriteMask_Green")]
        Green = 0x2,
        [NativeName("Name", "WGPUColorWriteMask_Blue")]
        Blue = 0x4,
        [NativeName("Name", "WGPUColorWriteMask_Alpha")]
        Alpha = 0x8,
        [NativeName("Name", "WGPUColorWriteMask_All")]
        All = 0xF,
        [NativeName("Name", "WGPUColorWriteMask_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
