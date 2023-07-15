// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class WH
{
    [NativeTypeName("#define WH_MIN (-1)")]
    public const int WH_MIN = (-1);
    [NativeTypeName("#define WH_MSGFILTER (-1)")]
    public const int WH_MSGFILTER = (-1);
    [NativeTypeName("#define WH_JOURNALRECORD 0")]
    public const int WH_JOURNALRECORD = 0;
    [NativeTypeName("#define WH_JOURNALPLAYBACK 1")]
    public const int WH_JOURNALPLAYBACK = 1;
    [NativeTypeName("#define WH_KEYBOARD 2")]
    public const int WH_KEYBOARD = 2;
    [NativeTypeName("#define WH_GETMESSAGE 3")]
    public const int WH_GETMESSAGE = 3;
    [NativeTypeName("#define WH_CALLWNDPROC 4")]
    public const int WH_CALLWNDPROC = 4;
    [NativeTypeName("#define WH_CBT 5")]
    public const int WH_CBT = 5;
    [NativeTypeName("#define WH_SYSMSGFILTER 6")]
    public const int WH_SYSMSGFILTER = 6;
    [NativeTypeName("#define WH_MOUSE 7")]
    public const int WH_MOUSE = 7;
    [NativeTypeName("#define WH_DEBUG 9")]
    public const int WH_DEBUG = 9;
    [NativeTypeName("#define WH_SHELL 10")]
    public const int WH_SHELL = 10;
    [NativeTypeName("#define WH_FOREGROUNDIDLE 11")]
    public const int WH_FOREGROUNDIDLE = 11;
    [NativeTypeName("#define WH_CALLWNDPROCRET 12")]
    public const int WH_CALLWNDPROCRET = 12;
    [NativeTypeName("#define WH_KEYBOARD_LL 13")]
    public const int WH_KEYBOARD_LL = 13;
    [NativeTypeName("#define WH_MOUSE_LL 14")]
    public const int WH_MOUSE_LL = 14;
    [NativeTypeName("#define WH_MAX 14")]
    public const int WH_MAX = 14;
    [NativeTypeName("#define WH_MINHOOK WH_MIN")]
    public const int WH_MINHOOK = (-1);
    [NativeTypeName("#define WH_MAXHOOK WH_MAX")]
    public const int WH_MAXHOOK = 14;
}