// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("unsigned int")]
public enum VirtualKeyModifiers : uint
{
    VirtualKeyModifiers_None = 0,
    VirtualKeyModifiers_Control = 0x1,
    VirtualKeyModifiers_Menu = 0x2,
    VirtualKeyModifiers_Shift = 0x4,
    VirtualKeyModifiers_Windows = 0x8,
}
