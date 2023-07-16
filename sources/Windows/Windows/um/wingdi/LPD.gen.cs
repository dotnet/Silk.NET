// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class LPD
{
    [NativeTypeName("#define LPD_DOUBLEBUFFER 0x00000001")]
    public const int LPD_DOUBLEBUFFER = 0x00000001;
    [NativeTypeName("#define LPD_STEREO 0x00000002")]
    public const int LPD_STEREO = 0x00000002;
    [NativeTypeName("#define LPD_SUPPORT_GDI 0x00000010")]
    public const int LPD_SUPPORT_GDI = 0x00000010;
    [NativeTypeName("#define LPD_SUPPORT_OPENGL 0x00000020")]
    public const int LPD_SUPPORT_OPENGL = 0x00000020;
    [NativeTypeName("#define LPD_SHARE_DEPTH 0x00000040")]
    public const int LPD_SHARE_DEPTH = 0x00000040;
    [NativeTypeName("#define LPD_SHARE_STENCIL 0x00000080")]
    public const int LPD_SHARE_STENCIL = 0x00000080;
    [NativeTypeName("#define LPD_SHARE_ACCUM 0x00000100")]
    public const int LPD_SHARE_ACCUM = 0x00000100;
    [NativeTypeName("#define LPD_SWAP_EXCHANGE 0x00000200")]
    public const int LPD_SWAP_EXCHANGE = 0x00000200;
    [NativeTypeName("#define LPD_SWAP_COPY 0x00000400")]
    public const int LPD_SWAP_COPY = 0x00000400;
    [NativeTypeName("#define LPD_TRANSPARENT 0x00001000")]
    public const int LPD_TRANSPARENT = 0x00001000;
    [NativeTypeName("#define LPD_TYPE_RGBA 0")]
    public const int LPD_TYPE_RGBA = 0;
    [NativeTypeName("#define LPD_TYPE_COLORINDEX 1")]
    public const int LPD_TYPE_COLORINDEX = 1;
}