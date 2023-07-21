// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='KEYBDINPUT.xml' path='doc/member[@name="KEYBDINPUT"]/*' />
public partial struct KEYBDINPUT
{
    /// <include file='KEYBDINPUT.xml' path='doc/member[@name="KEYBDINPUT.wVk"]/*' />
    [NativeTypeName("WORD")]
    public ushort wVk;

    /// <include file='KEYBDINPUT.xml' path='doc/member[@name="KEYBDINPUT.wScan"]/*' />
    [NativeTypeName("WORD")]
    public ushort wScan;

    /// <include file='KEYBDINPUT.xml' path='doc/member[@name="KEYBDINPUT.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='KEYBDINPUT.xml' path='doc/member[@name="KEYBDINPUT.time"]/*' />
    [NativeTypeName("DWORD")]
    public uint time;

    /// <include file='KEYBDINPUT.xml' path='doc/member[@name="KEYBDINPUT.dwExtraInfo"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint dwExtraInfo;
}
