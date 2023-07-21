// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class ILC
{
    [NativeTypeName("#define ILC_MASK 0x00000001")]
    public const int ILC_MASK = 0x00000001;

    [NativeTypeName("#define ILC_COLOR 0x00000000")]
    public const int ILC_COLOR = 0x00000000;

    [NativeTypeName("#define ILC_COLORDDB 0x000000FE")]
    public const int ILC_COLORDDB = 0x000000FE;

    [NativeTypeName("#define ILC_COLOR4 0x00000004")]
    public const int ILC_COLOR4 = 0x00000004;

    [NativeTypeName("#define ILC_COLOR8 0x00000008")]
    public const int ILC_COLOR8 = 0x00000008;

    [NativeTypeName("#define ILC_COLOR16 0x00000010")]
    public const int ILC_COLOR16 = 0x00000010;

    [NativeTypeName("#define ILC_COLOR24 0x00000018")]
    public const int ILC_COLOR24 = 0x00000018;

    [NativeTypeName("#define ILC_COLOR32 0x00000020")]
    public const int ILC_COLOR32 = 0x00000020;

    [NativeTypeName("#define ILC_PALETTE 0x00000800")]
    public const int ILC_PALETTE = 0x00000800;

    [NativeTypeName("#define ILC_MIRROR 0x00002000")]
    public const int ILC_MIRROR = 0x00002000;

    [NativeTypeName("#define ILC_PERITEMMIRROR 0x00008000")]
    public const int ILC_PERITEMMIRROR = 0x00008000;

    [NativeTypeName("#define ILC_ORIGINALSIZE 0x00010000")]
    public const int ILC_ORIGINALSIZE = 0x00010000;

    [NativeTypeName("#define ILC_HIGHQUALITYSCALE 0x00020000")]
    public const int ILC_HIGHQUALITYSCALE = 0x00020000;
}
