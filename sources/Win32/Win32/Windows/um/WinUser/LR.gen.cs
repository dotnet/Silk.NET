// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class LR
{
    [NativeTypeName("#define LR_DEFAULTCOLOR 0x00000000")]
    public const int LR_DEFAULTCOLOR = 0x00000000;

    [NativeTypeName("#define LR_MONOCHROME 0x00000001")]
    public const int LR_MONOCHROME = 0x00000001;

    [NativeTypeName("#define LR_COLOR 0x00000002")]
    public const int LR_COLOR = 0x00000002;

    [NativeTypeName("#define LR_COPYRETURNORG 0x00000004")]
    public const int LR_COPYRETURNORG = 0x00000004;

    [NativeTypeName("#define LR_COPYDELETEORG 0x00000008")]
    public const int LR_COPYDELETEORG = 0x00000008;

    [NativeTypeName("#define LR_LOADFROMFILE 0x00000010")]
    public const int LR_LOADFROMFILE = 0x00000010;

    [NativeTypeName("#define LR_LOADTRANSPARENT 0x00000020")]
    public const int LR_LOADTRANSPARENT = 0x00000020;

    [NativeTypeName("#define LR_DEFAULTSIZE 0x00000040")]
    public const int LR_DEFAULTSIZE = 0x00000040;

    [NativeTypeName("#define LR_VGACOLOR 0x00000080")]
    public const int LR_VGACOLOR = 0x00000080;

    [NativeTypeName("#define LR_LOADMAP3DCOLORS 0x00001000")]
    public const int LR_LOADMAP3DCOLORS = 0x00001000;

    [NativeTypeName("#define LR_CREATEDIBSECTION 0x00002000")]
    public const int LR_CREATEDIBSECTION = 0x00002000;

    [NativeTypeName("#define LR_COPYFROMRESOURCE 0x00004000")]
    public const int LR_COPYFROMRESOURCE = 0x00004000;

    [NativeTypeName("#define LR_SHARED 0x00008000")]
    public const int LR_SHARED = 0x00008000;
}
