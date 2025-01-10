// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class WMSZ
{
    [NativeTypeName("#define WMSZ_LEFT 1")]
    public const int WMSZ_LEFT = 1;

    [NativeTypeName("#define WMSZ_RIGHT 2")]
    public const int WMSZ_RIGHT = 2;

    [NativeTypeName("#define WMSZ_TOP 3")]
    public const int WMSZ_TOP = 3;

    [NativeTypeName("#define WMSZ_TOPLEFT 4")]
    public const int WMSZ_TOPLEFT = 4;

    [NativeTypeName("#define WMSZ_TOPRIGHT 5")]
    public const int WMSZ_TOPRIGHT = 5;

    [NativeTypeName("#define WMSZ_BOTTOM 6")]
    public const int WMSZ_BOTTOM = 6;

    [NativeTypeName("#define WMSZ_BOTTOMLEFT 7")]
    public const int WMSZ_BOTTOMLEFT = 7;

    [NativeTypeName("#define WMSZ_BOTTOMRIGHT 8")]
    public const int WMSZ_BOTTOMRIGHT = 8;
}
