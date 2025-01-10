// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class AMDDS
{
    [NativeTypeName("#define AMDDS_NONE 0x00")]
    public const int AMDDS_NONE = 0x00;

    [NativeTypeName("#define AMDDS_DCIPS 0x01")]
    public const int AMDDS_DCIPS = 0x01;

    [NativeTypeName("#define AMDDS_PS 0x02")]
    public const int AMDDS_PS = 0x02;

    [NativeTypeName("#define AMDDS_RGBOVR 0x04")]
    public const int AMDDS_RGBOVR = 0x04;

    [NativeTypeName("#define AMDDS_YUVOVR 0x08")]
    public const int AMDDS_YUVOVR = 0x08;

    [NativeTypeName("#define AMDDS_RGBOFF 0x10")]
    public const int AMDDS_RGBOFF = 0x10;

    [NativeTypeName("#define AMDDS_YUVOFF 0x20")]
    public const int AMDDS_YUVOFF = 0x20;

    [NativeTypeName("#define AMDDS_RGBFLP 0x40")]
    public const int AMDDS_RGBFLP = 0x40;

    [NativeTypeName("#define AMDDS_YUVFLP 0x80")]
    public const int AMDDS_YUVFLP = 0x80;

    [NativeTypeName("#define AMDDS_ALL 0xFF")]
    public const int AMDDS_ALL = 0xFF;

    [NativeTypeName("#define AMDDS_DEFAULT AMDDS_ALL")]
    public const int AMDDS_DEFAULT = 0xFF;

    [NativeTypeName("#define AMDDS_YUV (AMDDS_YUVOFF | AMDDS_YUVOVR | AMDDS_YUVFLP)")]
    public const int AMDDS_YUV = (0x20 | 0x08 | 0x80);

    [NativeTypeName("#define AMDDS_RGB (AMDDS_RGBOFF | AMDDS_RGBOVR | AMDDS_RGBFLP)")]
    public const int AMDDS_RGB = (0x10 | 0x04 | 0x40);

    [NativeTypeName("#define AMDDS_PRIMARY (AMDDS_DCIPS | AMDDS_PS)")]
    public const int AMDDS_PRIMARY = (0x01 | 0x02);
}
