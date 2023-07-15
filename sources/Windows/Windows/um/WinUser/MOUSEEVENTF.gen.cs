// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class MOUSEEVENTF
{
    [NativeTypeName("#define MOUSEEVENTF_MOVE 0x0001")]
    public const int MOUSEEVENTF_MOVE = 0x0001;
    [NativeTypeName("#define MOUSEEVENTF_LEFTDOWN 0x0002")]
    public const int MOUSEEVENTF_LEFTDOWN = 0x0002;
    [NativeTypeName("#define MOUSEEVENTF_LEFTUP 0x0004")]
    public const int MOUSEEVENTF_LEFTUP = 0x0004;
    [NativeTypeName("#define MOUSEEVENTF_RIGHTDOWN 0x0008")]
    public const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
    [NativeTypeName("#define MOUSEEVENTF_RIGHTUP 0x0010")]
    public const int MOUSEEVENTF_RIGHTUP = 0x0010;
    [NativeTypeName("#define MOUSEEVENTF_MIDDLEDOWN 0x0020")]
    public const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
    [NativeTypeName("#define MOUSEEVENTF_MIDDLEUP 0x0040")]
    public const int MOUSEEVENTF_MIDDLEUP = 0x0040;
    [NativeTypeName("#define MOUSEEVENTF_XDOWN 0x0080")]
    public const int MOUSEEVENTF_XDOWN = 0x0080;
    [NativeTypeName("#define MOUSEEVENTF_XUP 0x0100")]
    public const int MOUSEEVENTF_XUP = 0x0100;
    [NativeTypeName("#define MOUSEEVENTF_WHEEL 0x0800")]
    public const int MOUSEEVENTF_WHEEL = 0x0800;
    [NativeTypeName("#define MOUSEEVENTF_HWHEEL 0x01000")]
    public const int MOUSEEVENTF_HWHEEL = 0x01000;
    [NativeTypeName("#define MOUSEEVENTF_MOVE_NOCOALESCE 0x2000")]
    public const int MOUSEEVENTF_MOVE_NOCOALESCE = 0x2000;
    [NativeTypeName("#define MOUSEEVENTF_VIRTUALDESK 0x4000")]
    public const int MOUSEEVENTF_VIRTUALDESK = 0x4000;
    [NativeTypeName("#define MOUSEEVENTF_ABSOLUTE 0x8000")]
    public const int MOUSEEVENTF_ABSOLUTE = 0x8000;
}