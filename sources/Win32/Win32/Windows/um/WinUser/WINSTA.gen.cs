// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class WINSTA
{
    [NativeTypeName("#define WINSTA_ENUMDESKTOPS 0x0001L")]
    public const int WINSTA_ENUMDESKTOPS = 0x0001;

    [NativeTypeName("#define WINSTA_READATTRIBUTES 0x0002L")]
    public const int WINSTA_READATTRIBUTES = 0x0002;

    [NativeTypeName("#define WINSTA_ACCESSCLIPBOARD 0x0004L")]
    public const int WINSTA_ACCESSCLIPBOARD = 0x0004;

    [NativeTypeName("#define WINSTA_CREATEDESKTOP 0x0008L")]
    public const int WINSTA_CREATEDESKTOP = 0x0008;

    [NativeTypeName("#define WINSTA_WRITEATTRIBUTES 0x0010L")]
    public const int WINSTA_WRITEATTRIBUTES = 0x0010;

    [NativeTypeName("#define WINSTA_ACCESSGLOBALATOMS 0x0020L")]
    public const int WINSTA_ACCESSGLOBALATOMS = 0x0020;

    [NativeTypeName("#define WINSTA_EXITWINDOWS 0x0040L")]
    public const int WINSTA_EXITWINDOWS = 0x0040;

    [NativeTypeName("#define WINSTA_ENUMERATE 0x0100L")]
    public const int WINSTA_ENUMERATE = 0x0100;

    [NativeTypeName("#define WINSTA_READSCREEN 0x0200L")]
    public const int WINSTA_READSCREEN = 0x0200;

    [NativeTypeName(
        "#define WINSTA_ALL_ACCESS (WINSTA_ENUMDESKTOPS  | WINSTA_READATTRIBUTES  | WINSTA_ACCESSCLIPBOARD | \\\r\n                                     WINSTA_CREATEDESKTOP | WINSTA_WRITEATTRIBUTES | WINSTA_ACCESSGLOBALATOMS | \\\r\n                                     WINSTA_EXITWINDOWS   | WINSTA_ENUMERATE       | WINSTA_READSCREEN)"
    )]
    public const int WINSTA_ALL_ACCESS = (
        0x0001 | 0x0002 | 0x0004 | 0x0008 | 0x0010 | 0x0020 | 0x0040 | 0x0100 | 0x0200
    );
}
