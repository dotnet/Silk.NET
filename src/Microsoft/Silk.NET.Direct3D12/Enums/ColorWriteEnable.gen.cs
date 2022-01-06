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
        [NativeName("Name", "D3D12_COLOR_WRITE_ENABLE_RED")]
        ColorWriteEnableRed = 0x1,
        [NativeName("Name", "D3D12_COLOR_WRITE_ENABLE_GREEN")]
        ColorWriteEnableGreen = 0x2,
        [NativeName("Name", "D3D12_COLOR_WRITE_ENABLE_BLUE")]
        ColorWriteEnableBlue = 0x4,
        [NativeName("Name", "D3D12_COLOR_WRITE_ENABLE_ALPHA")]
        ColorWriteEnableAlpha = 0x8,
        [NativeName("Name", "D3D12_COLOR_WRITE_ENABLE_ALL")]
        ColorWriteEnableAll = 0xF,
    }
}
