// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class BI
{
    [NativeTypeName("#define BI_RGB 0L")]
    public const int BI_RGB = 0;

    [NativeTypeName("#define BI_RLE8 1L")]
    public const int BI_RLE8 = 1;

    [NativeTypeName("#define BI_RLE4 2L")]
    public const int BI_RLE4 = 2;

    [NativeTypeName("#define BI_BITFIELDS 3L")]
    public const int BI_BITFIELDS = 3;

    [NativeTypeName("#define BI_JPEG 4L")]
    public const int BI_JPEG = 4;

    [NativeTypeName("#define BI_PNG 5L")]
    public const int BI_PNG = 5;
}
