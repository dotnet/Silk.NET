// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_COLOR_WRITE_ENABLE")]
    public enum ColorWriteEnable : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Red\"")]
        [NativeName("Name", "D3D12_COLOR_WRITE_ENABLE_RED")]
        ColorWriteEnableRed = 0x1,
        [Obsolete("Deprecated in favour of \"Green\"")]
        [NativeName("Name", "D3D12_COLOR_WRITE_ENABLE_GREEN")]
        ColorWriteEnableGreen = 0x2,
        [Obsolete("Deprecated in favour of \"Blue\"")]
        [NativeName("Name", "D3D12_COLOR_WRITE_ENABLE_BLUE")]
        ColorWriteEnableBlue = 0x4,
        [Obsolete("Deprecated in favour of \"Alpha\"")]
        [NativeName("Name", "D3D12_COLOR_WRITE_ENABLE_ALPHA")]
        ColorWriteEnableAlpha = 0x8,
        [Obsolete("Deprecated in favour of \"All\"")]
        [NativeName("Name", "D3D12_COLOR_WRITE_ENABLE_ALL")]
        ColorWriteEnableAll = 0xF,
        [NativeName("Name", "D3D12_COLOR_WRITE_ENABLE_RED")]
        Red = 0x1,
        [NativeName("Name", "D3D12_COLOR_WRITE_ENABLE_GREEN")]
        Green = 0x2,
        [NativeName("Name", "D3D12_COLOR_WRITE_ENABLE_BLUE")]
        Blue = 0x4,
        [NativeName("Name", "D3D12_COLOR_WRITE_ENABLE_ALPHA")]
        Alpha = 0x8,
        [NativeName("Name", "D3D12_COLOR_WRITE_ENABLE_ALL")]
        All = 0xF,
    }
}
