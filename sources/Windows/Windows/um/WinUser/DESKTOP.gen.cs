// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class DESKTOP
{
    [NativeTypeName("#define DESKTOP_READOBJECTS 0x0001L")]
    public const int DESKTOP_READOBJECTS = 0x0001;
    [NativeTypeName("#define DESKTOP_CREATEWINDOW 0x0002L")]
    public const int DESKTOP_CREATEWINDOW = 0x0002;
    [NativeTypeName("#define DESKTOP_CREATEMENU 0x0004L")]
    public const int DESKTOP_CREATEMENU = 0x0004;
    [NativeTypeName("#define DESKTOP_HOOKCONTROL 0x0008L")]
    public const int DESKTOP_HOOKCONTROL = 0x0008;
    [NativeTypeName("#define DESKTOP_JOURNALRECORD 0x0010L")]
    public const int DESKTOP_JOURNALRECORD = 0x0010;
    [NativeTypeName("#define DESKTOP_JOURNALPLAYBACK 0x0020L")]
    public const int DESKTOP_JOURNALPLAYBACK = 0x0020;
    [NativeTypeName("#define DESKTOP_ENUMERATE 0x0040L")]
    public const int DESKTOP_ENUMERATE = 0x0040;
    [NativeTypeName("#define DESKTOP_WRITEOBJECTS 0x0080L")]
    public const int DESKTOP_WRITEOBJECTS = 0x0080;
    [NativeTypeName("#define DESKTOP_SWITCHDESKTOP 0x0100L")]
    public const int DESKTOP_SWITCHDESKTOP = 0x0100;
}