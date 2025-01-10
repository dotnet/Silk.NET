// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class ILD
{
    [NativeTypeName("#define ILD_NORMAL 0x00000000")]
    public const int ILD_NORMAL = 0x00000000;

    [NativeTypeName("#define ILD_TRANSPARENT 0x00000001")]
    public const int ILD_TRANSPARENT = 0x00000001;

    [NativeTypeName("#define ILD_MASK 0x00000010")]
    public const int ILD_MASK = 0x00000010;

    [NativeTypeName("#define ILD_IMAGE 0x00000020")]
    public const int ILD_IMAGE = 0x00000020;

    [NativeTypeName("#define ILD_ROP 0x00000040")]
    public const int ILD_ROP = 0x00000040;

    [NativeTypeName("#define ILD_BLEND25 0x00000002")]
    public const int ILD_BLEND25 = 0x00000002;

    [NativeTypeName("#define ILD_BLEND50 0x00000004")]
    public const int ILD_BLEND50 = 0x00000004;

    [NativeTypeName("#define ILD_OVERLAYMASK 0x00000F00")]
    public const int ILD_OVERLAYMASK = 0x00000F00;

    [NativeTypeName("#define ILD_PRESERVEALPHA 0x00001000")]
    public const int ILD_PRESERVEALPHA = 0x00001000;

    [NativeTypeName("#define ILD_SCALE 0x00002000")]
    public const int ILD_SCALE = 0x00002000;

    [NativeTypeName("#define ILD_DPISCALE 0x00004000")]
    public const int ILD_DPISCALE = 0x00004000;

    [NativeTypeName("#define ILD_ASYNC 0x00008000")]
    public const int ILD_ASYNC = 0x00008000;

    [NativeTypeName("#define ILD_SELECTED ILD_BLEND50")]
    public const int ILD_SELECTED = 0x00000004;

    [NativeTypeName("#define ILD_FOCUS ILD_BLEND25")]
    public const int ILD_FOCUS = 0x00000002;

    [NativeTypeName("#define ILD_BLEND ILD_BLEND50")]
    public const int ILD_BLEND = 0x00000004;
}
