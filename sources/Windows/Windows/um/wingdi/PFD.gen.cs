// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class PFD
{
    [NativeTypeName("#define PFD_TYPE_RGBA 0")]
    public const int PFD_TYPE_RGBA = 0;

    [NativeTypeName("#define PFD_TYPE_COLORINDEX 1")]
    public const int PFD_TYPE_COLORINDEX = 1;

    [NativeTypeName("#define PFD_MAIN_PLANE 0")]
    public const int PFD_MAIN_PLANE = 0;

    [NativeTypeName("#define PFD_OVERLAY_PLANE 1")]
    public const int PFD_OVERLAY_PLANE = 1;

    [NativeTypeName("#define PFD_UNDERLAY_PLANE (-1)")]
    public const int PFD_UNDERLAY_PLANE = (-1);

    [NativeTypeName("#define PFD_DOUBLEBUFFER 0x00000001")]
    public const int PFD_DOUBLEBUFFER = 0x00000001;

    [NativeTypeName("#define PFD_STEREO 0x00000002")]
    public const int PFD_STEREO = 0x00000002;

    [NativeTypeName("#define PFD_DRAW_TO_WINDOW 0x00000004")]
    public const int PFD_DRAW_TO_WINDOW = 0x00000004;

    [NativeTypeName("#define PFD_DRAW_TO_BITMAP 0x00000008")]
    public const int PFD_DRAW_TO_BITMAP = 0x00000008;

    [NativeTypeName("#define PFD_SUPPORT_GDI 0x00000010")]
    public const int PFD_SUPPORT_GDI = 0x00000010;

    [NativeTypeName("#define PFD_SUPPORT_OPENGL 0x00000020")]
    public const int PFD_SUPPORT_OPENGL = 0x00000020;

    [NativeTypeName("#define PFD_GENERIC_FORMAT 0x00000040")]
    public const int PFD_GENERIC_FORMAT = 0x00000040;

    [NativeTypeName("#define PFD_NEED_PALETTE 0x00000080")]
    public const int PFD_NEED_PALETTE = 0x00000080;

    [NativeTypeName("#define PFD_NEED_SYSTEM_PALETTE 0x00000100")]
    public const int PFD_NEED_SYSTEM_PALETTE = 0x00000100;

    [NativeTypeName("#define PFD_SWAP_EXCHANGE 0x00000200")]
    public const int PFD_SWAP_EXCHANGE = 0x00000200;

    [NativeTypeName("#define PFD_SWAP_COPY 0x00000400")]
    public const int PFD_SWAP_COPY = 0x00000400;

    [NativeTypeName("#define PFD_SWAP_LAYER_BUFFERS 0x00000800")]
    public const int PFD_SWAP_LAYER_BUFFERS = 0x00000800;

    [NativeTypeName("#define PFD_GENERIC_ACCELERATED 0x00001000")]
    public const int PFD_GENERIC_ACCELERATED = 0x00001000;

    [NativeTypeName("#define PFD_SUPPORT_DIRECTDRAW 0x00002000")]
    public const int PFD_SUPPORT_DIRECTDRAW = 0x00002000;

    [NativeTypeName("#define PFD_DIRECT3D_ACCELERATED 0x00004000")]
    public const int PFD_DIRECT3D_ACCELERATED = 0x00004000;

    [NativeTypeName("#define PFD_SUPPORT_COMPOSITION 0x00008000")]
    public const int PFD_SUPPORT_COMPOSITION = 0x00008000;

    [NativeTypeName("#define PFD_DEPTH_DONTCARE 0x20000000")]
    public const int PFD_DEPTH_DONTCARE = 0x20000000;

    [NativeTypeName("#define PFD_DOUBLEBUFFER_DONTCARE 0x40000000")]
    public const int PFD_DOUBLEBUFFER_DONTCARE = 0x40000000;

    [NativeTypeName("#define PFD_STEREO_DONTCARE 0x80000000")]
    public const uint PFD_STEREO_DONTCARE = 0x80000000;
}
