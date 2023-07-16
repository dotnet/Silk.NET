// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class HCF
{
    [NativeTypeName("#define HCF_HIGHCONTRASTON 0x00000001")]
    public const int HCF_HIGHCONTRASTON = 0x00000001;
    [NativeTypeName("#define HCF_AVAILABLE 0x00000002")]
    public const int HCF_AVAILABLE = 0x00000002;
    [NativeTypeName("#define HCF_HOTKEYACTIVE 0x00000004")]
    public const int HCF_HOTKEYACTIVE = 0x00000004;
    [NativeTypeName("#define HCF_CONFIRMHOTKEY 0x00000008")]
    public const int HCF_CONFIRMHOTKEY = 0x00000008;
    [NativeTypeName("#define HCF_HOTKEYSOUND 0x00000010")]
    public const int HCF_HOTKEYSOUND = 0x00000010;
    [NativeTypeName("#define HCF_INDICATOR 0x00000020")]
    public const int HCF_INDICATOR = 0x00000020;
    [NativeTypeName("#define HCF_HOTKEYAVAILABLE 0x00000040")]
    public const int HCF_HOTKEYAVAILABLE = 0x00000040;
    [NativeTypeName("#define HCF_LOGONDESKTOP 0x00000100")]
    public const int HCF_LOGONDESKTOP = 0x00000100;
    [NativeTypeName("#define HCF_DEFAULTDESKTOP 0x00000200")]
    public const int HCF_DEFAULTDESKTOP = 0x00000200;
    [NativeTypeName("#define HCF_OPTION_NOTHEMECHANGE 0x00001000")]
    public const int HCF_OPTION_NOTHEMECHANGE = 0x00001000;
}