// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_CONVOLVEMATRIX_PROP")]
    public enum ConvolvematrixProp : int
    {
        [NativeName("Name", "D2D1_CONVOLVEMATRIX_PROP_KERNEL_UNIT_LENGTH")]
        KernelUnitLength = 0x0,
        [NativeName("Name", "D2D1_CONVOLVEMATRIX_PROP_SCALE_MODE")]
        ScaleMode = 0x1,
        [NativeName("Name", "D2D1_CONVOLVEMATRIX_PROP_KERNEL_SIZE_X")]
        KernelSizeX = 0x2,
        [NativeName("Name", "D2D1_CONVOLVEMATRIX_PROP_KERNEL_SIZE_Y")]
        KernelSizeY = 0x3,
        [NativeName("Name", "D2D1_CONVOLVEMATRIX_PROP_KERNEL_MATRIX")]
        KernelMatrix = 0x4,
        [NativeName("Name", "D2D1_CONVOLVEMATRIX_PROP_DIVISOR")]
        Divisor = 0x5,
        [NativeName("Name", "D2D1_CONVOLVEMATRIX_PROP_BIAS")]
        Bias = 0x6,
        [NativeName("Name", "D2D1_CONVOLVEMATRIX_PROP_KERNEL_OFFSET")]
        KernelOffset = 0x7,
        [NativeName("Name", "D2D1_CONVOLVEMATRIX_PROP_PRESERVE_ALPHA")]
        PreserveAlpha = 0x8,
        [NativeName("Name", "D2D1_CONVOLVEMATRIX_PROP_BORDER_MODE")]
        BorderMode = 0x9,
        [NativeName("Name", "D2D1_CONVOLVEMATRIX_PROP_CLAMP_OUTPUT")]
        ClampOutput = 0xA,
        [NativeName("Name", "D2D1_CONVOLVEMATRIX_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
