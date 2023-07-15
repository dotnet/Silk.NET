// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class ARW
{
    [NativeTypeName("#define ARW_BOTTOMLEFT 0x0000L")]
    public const int ARW_BOTTOMLEFT = 0x0000;
    [NativeTypeName("#define ARW_BOTTOMRIGHT 0x0001L")]
    public const int ARW_BOTTOMRIGHT = 0x0001;
    [NativeTypeName("#define ARW_TOPLEFT 0x0002L")]
    public const int ARW_TOPLEFT = 0x0002;
    [NativeTypeName("#define ARW_TOPRIGHT 0x0003L")]
    public const int ARW_TOPRIGHT = 0x0003;
    [NativeTypeName("#define ARW_STARTMASK 0x0003L")]
    public const int ARW_STARTMASK = 0x0003;
    [NativeTypeName("#define ARW_STARTRIGHT 0x0001L")]
    public const int ARW_STARTRIGHT = 0x0001;
    [NativeTypeName("#define ARW_STARTTOP 0x0002L")]
    public const int ARW_STARTTOP = 0x0002;
    [NativeTypeName("#define ARW_LEFT 0x0000L")]
    public const int ARW_LEFT = 0x0000;
    [NativeTypeName("#define ARW_RIGHT 0x0000L")]
    public const int ARW_RIGHT = 0x0000;
    [NativeTypeName("#define ARW_UP 0x0004L")]
    public const int ARW_UP = 0x0004;
    [NativeTypeName("#define ARW_DOWN 0x0004L")]
    public const int ARW_DOWN = 0x0004;
    [NativeTypeName("#define ARW_HIDE 0x0008L")]
    public const int ARW_HIDE = 0x0008;
}