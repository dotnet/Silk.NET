// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class CS
{
    [NativeTypeName("#define CS_VREDRAW 0x0001")]
    public const int CS_VREDRAW = 0x0001;
    [NativeTypeName("#define CS_HREDRAW 0x0002")]
    public const int CS_HREDRAW = 0x0002;
    [NativeTypeName("#define CS_DBLCLKS 0x0008")]
    public const int CS_DBLCLKS = 0x0008;
    [NativeTypeName("#define CS_OWNDC 0x0020")]
    public const int CS_OWNDC = 0x0020;
    [NativeTypeName("#define CS_CLASSDC 0x0040")]
    public const int CS_CLASSDC = 0x0040;
    [NativeTypeName("#define CS_PARENTDC 0x0080")]
    public const int CS_PARENTDC = 0x0080;
    [NativeTypeName("#define CS_NOCLOSE 0x0200")]
    public const int CS_NOCLOSE = 0x0200;
    [NativeTypeName("#define CS_SAVEBITS 0x0800")]
    public const int CS_SAVEBITS = 0x0800;
    [NativeTypeName("#define CS_BYTEALIGNCLIENT 0x1000")]
    public const int CS_BYTEALIGNCLIENT = 0x1000;
    [NativeTypeName("#define CS_BYTEALIGNWINDOW 0x2000")]
    public const int CS_BYTEALIGNWINDOW = 0x2000;
    [NativeTypeName("#define CS_GLOBALCLASS 0x4000")]
    public const int CS_GLOBALCLASS = 0x4000;
    [NativeTypeName("#define CS_IME 0x00010000")]
    public const int CS_IME = 0x00010000;
    [NativeTypeName("#define CS_DROPSHADOW 0x00020000")]
    public const int CS_DROPSHADOW = 0x00020000;
}