// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class OUT
{
    [NativeTypeName("#define OUT_DEFAULT_PRECIS 0")]
    public const int OUT_DEFAULT_PRECIS = 0;
    [NativeTypeName("#define OUT_STRING_PRECIS 1")]
    public const int OUT_STRING_PRECIS = 1;
    [NativeTypeName("#define OUT_CHARACTER_PRECIS 2")]
    public const int OUT_CHARACTER_PRECIS = 2;
    [NativeTypeName("#define OUT_STROKE_PRECIS 3")]
    public const int OUT_STROKE_PRECIS = 3;
    [NativeTypeName("#define OUT_TT_PRECIS 4")]
    public const int OUT_TT_PRECIS = 4;
    [NativeTypeName("#define OUT_DEVICE_PRECIS 5")]
    public const int OUT_DEVICE_PRECIS = 5;
    [NativeTypeName("#define OUT_RASTER_PRECIS 6")]
    public const int OUT_RASTER_PRECIS = 6;
    [NativeTypeName("#define OUT_TT_ONLY_PRECIS 7")]
    public const int OUT_TT_ONLY_PRECIS = 7;
    [NativeTypeName("#define OUT_OUTLINE_PRECIS 8")]
    public const int OUT_OUTLINE_PRECIS = 8;
    [NativeTypeName("#define OUT_SCREEN_OUTLINE_PRECIS 9")]
    public const int OUT_SCREEN_OUTLINE_PRECIS = 9;
    [NativeTypeName("#define OUT_PS_ONLY_PRECIS 10")]
    public const int OUT_PS_ONLY_PRECIS = 10;
}