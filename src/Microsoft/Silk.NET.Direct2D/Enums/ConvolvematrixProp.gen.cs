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
        [Obsolete("Deprecated in favour of \"KernelUnitLength\"")]
        [NativeName("Name", "D2D1_CONVOLVEMATRIX_PROP_KERNEL_UNIT_LENGTH")]
        ConvolvematrixPropKernelUnitLength = 0x0,
        [Obsolete("Deprecated in favour of \"ScaleMode\"")]
        [NativeName("Name", "D2D1_CONVOLVEMATRIX_PROP_SCALE_MODE")]
        ConvolvematrixPropScaleMode = 0x1,
        [Obsolete("Deprecated in favour of \"KernelSizeX\"")]
        [NativeName("Name", "D2D1_CONVOLVEMATRIX_PROP_KERNEL_SIZE_X")]
        ConvolvematrixPropKernelSizeX = 0x2,
        [Obsolete("Deprecated in favour of \"KernelSizeY\"")]
        [NativeName("Name", "D2D1_CONVOLVEMATRIX_PROP_KERNEL_SIZE_Y")]
        ConvolvematrixPropKernelSizeY = 0x3,
        [Obsolete("Deprecated in favour of \"KernelMatrix\"")]
        [NativeName("Name", "D2D1_CONVOLVEMATRIX_PROP_KERNEL_MATRIX")]
        ConvolvematrixPropKernelMatrix = 0x4,
        [Obsolete("Deprecated in favour of \"Divisor\"")]
        [NativeName("Name", "D2D1_CONVOLVEMATRIX_PROP_DIVISOR")]
        ConvolvematrixPropDivisor = 0x5,
        [Obsolete("Deprecated in favour of \"Bias\"")]
        [NativeName("Name", "D2D1_CONVOLVEMATRIX_PROP_BIAS")]
        ConvolvematrixPropBias = 0x6,
        [Obsolete("Deprecated in favour of \"KernelOffset\"")]
        [NativeName("Name", "D2D1_CONVOLVEMATRIX_PROP_KERNEL_OFFSET")]
        ConvolvematrixPropKernelOffset = 0x7,
        [Obsolete("Deprecated in favour of \"PreserveAlpha\"")]
        [NativeName("Name", "D2D1_CONVOLVEMATRIX_PROP_PRESERVE_ALPHA")]
        ConvolvematrixPropPreserveAlpha = 0x8,
        [Obsolete("Deprecated in favour of \"BorderMode\"")]
        [NativeName("Name", "D2D1_CONVOLVEMATRIX_PROP_BORDER_MODE")]
        ConvolvematrixPropBorderMode = 0x9,
        [Obsolete("Deprecated in favour of \"ClampOutput\"")]
        [NativeName("Name", "D2D1_CONVOLVEMATRIX_PROP_CLAMP_OUTPUT")]
        ConvolvematrixPropClampOutput = 0xA,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_CONVOLVEMATRIX_PROP_FORCE_DWORD")]
        ConvolvematrixPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
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
