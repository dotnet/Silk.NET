// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class MB
{
    [NativeTypeName("#define MB_OK 0x00000000L")]
    public const int MB_OK = 0x00000000;

    [NativeTypeName("#define MB_OKCANCEL 0x00000001L")]
    public const int MB_OKCANCEL = 0x00000001;

    [NativeTypeName("#define MB_ABORTRETRYIGNORE 0x00000002L")]
    public const int MB_ABORTRETRYIGNORE = 0x00000002;

    [NativeTypeName("#define MB_YESNOCANCEL 0x00000003L")]
    public const int MB_YESNOCANCEL = 0x00000003;

    [NativeTypeName("#define MB_YESNO 0x00000004L")]
    public const int MB_YESNO = 0x00000004;

    [NativeTypeName("#define MB_RETRYCANCEL 0x00000005L")]
    public const int MB_RETRYCANCEL = 0x00000005;

    [NativeTypeName("#define MB_CANCELTRYCONTINUE 0x00000006L")]
    public const int MB_CANCELTRYCONTINUE = 0x00000006;

    [NativeTypeName("#define MB_ICONHAND 0x00000010L")]
    public const int MB_ICONHAND = 0x00000010;

    [NativeTypeName("#define MB_ICONQUESTION 0x00000020L")]
    public const int MB_ICONQUESTION = 0x00000020;

    [NativeTypeName("#define MB_ICONEXCLAMATION 0x00000030L")]
    public const int MB_ICONEXCLAMATION = 0x00000030;

    [NativeTypeName("#define MB_ICONASTERISK 0x00000040L")]
    public const int MB_ICONASTERISK = 0x00000040;

    [NativeTypeName("#define MB_USERICON 0x00000080L")]
    public const int MB_USERICON = 0x00000080;

    [NativeTypeName("#define MB_ICONWARNING MB_ICONEXCLAMATION")]
    public const int MB_ICONWARNING = 0x00000030;

    [NativeTypeName("#define MB_ICONERROR MB_ICONHAND")]
    public const int MB_ICONERROR = 0x00000010;

    [NativeTypeName("#define MB_ICONINFORMATION MB_ICONASTERISK")]
    public const int MB_ICONINFORMATION = 0x00000040;

    [NativeTypeName("#define MB_ICONSTOP MB_ICONHAND")]
    public const int MB_ICONSTOP = 0x00000010;

    [NativeTypeName("#define MB_DEFBUTTON1 0x00000000L")]
    public const int MB_DEFBUTTON1 = 0x00000000;

    [NativeTypeName("#define MB_DEFBUTTON2 0x00000100L")]
    public const int MB_DEFBUTTON2 = 0x00000100;

    [NativeTypeName("#define MB_DEFBUTTON3 0x00000200L")]
    public const int MB_DEFBUTTON3 = 0x00000200;

    [NativeTypeName("#define MB_DEFBUTTON4 0x00000300L")]
    public const int MB_DEFBUTTON4 = 0x00000300;

    [NativeTypeName("#define MB_APPLMODAL 0x00000000L")]
    public const int MB_APPLMODAL = 0x00000000;

    [NativeTypeName("#define MB_SYSTEMMODAL 0x00001000L")]
    public const int MB_SYSTEMMODAL = 0x00001000;

    [NativeTypeName("#define MB_TASKMODAL 0x00002000L")]
    public const int MB_TASKMODAL = 0x00002000;

    [NativeTypeName("#define MB_HELP 0x00004000L")]
    public const int MB_HELP = 0x00004000;

    [NativeTypeName("#define MB_NOFOCUS 0x00008000L")]
    public const int MB_NOFOCUS = 0x00008000;

    [NativeTypeName("#define MB_SETFOREGROUND 0x00010000L")]
    public const int MB_SETFOREGROUND = 0x00010000;

    [NativeTypeName("#define MB_DEFAULT_DESKTOP_ONLY 0x00020000L")]
    public const int MB_DEFAULT_DESKTOP_ONLY = 0x00020000;

    [NativeTypeName("#define MB_TOPMOST 0x00040000L")]
    public const int MB_TOPMOST = 0x00040000;

    [NativeTypeName("#define MB_RIGHT 0x00080000L")]
    public const int MB_RIGHT = 0x00080000;

    [NativeTypeName("#define MB_RTLREADING 0x00100000L")]
    public const int MB_RTLREADING = 0x00100000;

    [NativeTypeName("#define MB_SERVICE_NOTIFICATION 0x00200000L")]
    public const int MB_SERVICE_NOTIFICATION = 0x00200000;

    [NativeTypeName("#define MB_SERVICE_NOTIFICATION_NT3X 0x00040000L")]
    public const int MB_SERVICE_NOTIFICATION_NT3X = 0x00040000;

    [NativeTypeName("#define MB_TYPEMASK 0x0000000FL")]
    public const int MB_TYPEMASK = 0x0000000F;

    [NativeTypeName("#define MB_ICONMASK 0x000000F0L")]
    public const int MB_ICONMASK = 0x000000F0;

    [NativeTypeName("#define MB_DEFMASK 0x00000F00L")]
    public const int MB_DEFMASK = 0x00000F00;

    [NativeTypeName("#define MB_MODEMASK 0x00003000L")]
    public const int MB_MODEMASK = 0x00003000;

    [NativeTypeName("#define MB_MISCMASK 0x0000C000L")]
    public const int MB_MISCMASK = 0x0000C000;
}
