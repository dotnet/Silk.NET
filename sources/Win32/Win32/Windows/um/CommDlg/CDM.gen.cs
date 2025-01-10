// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class CDM
{
    [NativeTypeName("#define CDM_FIRST (WM_USER + 100)")]
    public const int CDM_FIRST = (0x0400 + 100);

    [NativeTypeName("#define CDM_LAST (WM_USER + 200)")]
    public const int CDM_LAST = (0x0400 + 200);

    [NativeTypeName("#define CDM_GETSPEC (CDM_FIRST + 0x0000)")]
    public const int CDM_GETSPEC = ((0x0400 + 100) + 0x0000);

    [NativeTypeName("#define CDM_GETFILEPATH (CDM_FIRST + 0x0001)")]
    public const int CDM_GETFILEPATH = ((0x0400 + 100) + 0x0001);

    [NativeTypeName("#define CDM_GETFOLDERPATH (CDM_FIRST + 0x0002)")]
    public const int CDM_GETFOLDERPATH = ((0x0400 + 100) + 0x0002);

    [NativeTypeName("#define CDM_GETFOLDERIDLIST (CDM_FIRST + 0x0003)")]
    public const int CDM_GETFOLDERIDLIST = ((0x0400 + 100) + 0x0003);

    [NativeTypeName("#define CDM_SETCONTROLTEXT (CDM_FIRST + 0x0004)")]
    public const int CDM_SETCONTROLTEXT = ((0x0400 + 100) + 0x0004);

    [NativeTypeName("#define CDM_HIDECONTROL (CDM_FIRST + 0x0005)")]
    public const int CDM_HIDECONTROL = ((0x0400 + 100) + 0x0005);

    [NativeTypeName("#define CDM_SETDEFEXT (CDM_FIRST + 0x0006)")]
    public const int CDM_SETDEFEXT = ((0x0400 + 100) + 0x0006);
}
