// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class FOF
{
    [NativeTypeName("#define FOF_MULTIDESTFILES 0x0001")]
    public const int FOF_MULTIDESTFILES = 0x0001;

    [NativeTypeName("#define FOF_CONFIRMMOUSE 0x0002")]
    public const int FOF_CONFIRMMOUSE = 0x0002;

    [NativeTypeName("#define FOF_SILENT 0x0004")]
    public const int FOF_SILENT = 0x0004;

    [NativeTypeName("#define FOF_RENAMEONCOLLISION 0x0008")]
    public const int FOF_RENAMEONCOLLISION = 0x0008;

    [NativeTypeName("#define FOF_NOCONFIRMATION 0x0010")]
    public const int FOF_NOCONFIRMATION = 0x0010;

    [NativeTypeName("#define FOF_WANTMAPPINGHANDLE 0x0020")]
    public const int FOF_WANTMAPPINGHANDLE = 0x0020;

    [NativeTypeName("#define FOF_ALLOWUNDO 0x0040")]
    public const int FOF_ALLOWUNDO = 0x0040;

    [NativeTypeName("#define FOF_FILESONLY 0x0080")]
    public const int FOF_FILESONLY = 0x0080;

    [NativeTypeName("#define FOF_SIMPLEPROGRESS 0x0100")]
    public const int FOF_SIMPLEPROGRESS = 0x0100;

    [NativeTypeName("#define FOF_NOCONFIRMMKDIR 0x0200")]
    public const int FOF_NOCONFIRMMKDIR = 0x0200;

    [NativeTypeName("#define FOF_NOERRORUI 0x0400")]
    public const int FOF_NOERRORUI = 0x0400;

    [NativeTypeName("#define FOF_NOCOPYSECURITYATTRIBS 0x0800")]
    public const int FOF_NOCOPYSECURITYATTRIBS = 0x0800;

    [NativeTypeName("#define FOF_NORECURSION 0x1000")]
    public const int FOF_NORECURSION = 0x1000;

    [NativeTypeName("#define FOF_NO_CONNECTED_ELEMENTS 0x2000")]
    public const int FOF_NO_CONNECTED_ELEMENTS = 0x2000;

    [NativeTypeName("#define FOF_WANTNUKEWARNING 0x4000")]
    public const int FOF_WANTNUKEWARNING = 0x4000;

    [NativeTypeName("#define FOF_NORECURSEREPARSE 0x8000")]
    public const int FOF_NORECURSEREPARSE = 0x8000;

    [NativeTypeName(
        "#define FOF_NO_UI (FOF_SILENT | FOF_NOCONFIRMATION | FOF_NOERRORUI | FOF_NOCONFIRMMKDIR)"
    )]
    public const int FOF_NO_UI = (0x0004 | 0x0010 | 0x0400 | 0x0200);
}
