// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D2D1_CONVOLVEMATRIX_PROP
{
    D2D1_CONVOLVEMATRIX_PROP_KERNEL_UNIT_LENGTH = 0,
    D2D1_CONVOLVEMATRIX_PROP_SCALE_MODE = 1,
    D2D1_CONVOLVEMATRIX_PROP_KERNEL_SIZE_X = 2,
    D2D1_CONVOLVEMATRIX_PROP_KERNEL_SIZE_Y = 3,
    D2D1_CONVOLVEMATRIX_PROP_KERNEL_MATRIX = 4,
    D2D1_CONVOLVEMATRIX_PROP_DIVISOR = 5,
    D2D1_CONVOLVEMATRIX_PROP_BIAS = 6,
    D2D1_CONVOLVEMATRIX_PROP_KERNEL_OFFSET = 7,
    D2D1_CONVOLVEMATRIX_PROP_PRESERVE_ALPHA = 8,
    D2D1_CONVOLVEMATRIX_PROP_BORDER_MODE = 9,
    D2D1_CONVOLVEMATRIX_PROP_CLAMP_OUTPUT = 10,
    D2D1_CONVOLVEMATRIX_PROP_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
