// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class SW
{
    [NativeTypeName("#define SW_HIDE 0")]
    public const int SW_HIDE = 0;
    [NativeTypeName("#define SW_SHOWNORMAL 1")]
    public const int SW_SHOWNORMAL = 1;
    [NativeTypeName("#define SW_NORMAL 1")]
    public const int SW_NORMAL = 1;
    [NativeTypeName("#define SW_SHOWMINIMIZED 2")]
    public const int SW_SHOWMINIMIZED = 2;
    [NativeTypeName("#define SW_SHOWMAXIMIZED 3")]
    public const int SW_SHOWMAXIMIZED = 3;
    [NativeTypeName("#define SW_MAXIMIZE 3")]
    public const int SW_MAXIMIZE = 3;
    [NativeTypeName("#define SW_SHOWNOACTIVATE 4")]
    public const int SW_SHOWNOACTIVATE = 4;
    [NativeTypeName("#define SW_SHOW 5")]
    public const int SW_SHOW = 5;
    [NativeTypeName("#define SW_MINIMIZE 6")]
    public const int SW_MINIMIZE = 6;
    [NativeTypeName("#define SW_SHOWMINNOACTIVE 7")]
    public const int SW_SHOWMINNOACTIVE = 7;
    [NativeTypeName("#define SW_SHOWNA 8")]
    public const int SW_SHOWNA = 8;
    [NativeTypeName("#define SW_RESTORE 9")]
    public const int SW_RESTORE = 9;
    [NativeTypeName("#define SW_SHOWDEFAULT 10")]
    public const int SW_SHOWDEFAULT = 10;
    [NativeTypeName("#define SW_FORCEMINIMIZE 11")]
    public const int SW_FORCEMINIMIZE = 11;
    [NativeTypeName("#define SW_MAX 11")]
    public const int SW_MAX = 11;
    [NativeTypeName("#define SW_PARENTCLOSING 1")]
    public const int SW_PARENTCLOSING = 1;
    [NativeTypeName("#define SW_OTHERZOOM 2")]
    public const int SW_OTHERZOOM = 2;
    [NativeTypeName("#define SW_PARENTOPENING 3")]
    public const int SW_PARENTOPENING = 3;
    [NativeTypeName("#define SW_OTHERUNZOOM 4")]
    public const int SW_OTHERUNZOOM = 4;
    [NativeTypeName("#define SW_SCROLLCHILDREN 0x0001")]
    public const int SW_SCROLLCHILDREN = 0x0001;
    [NativeTypeName("#define SW_INVALIDATE 0x0002")]
    public const int SW_INVALIDATE = 0x0002;
    [NativeTypeName("#define SW_ERASE 0x0004")]
    public const int SW_ERASE = 0x0004;
    [NativeTypeName("#define SW_SMOOTHSCROLL 0x0010")]
    public const int SW_SMOOTHSCROLL = 0x0010;
}