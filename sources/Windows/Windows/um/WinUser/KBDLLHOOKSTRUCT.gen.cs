// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='KBDLLHOOKSTRUCT.xml' path='doc/member[@name="KBDLLHOOKSTRUCT"]/*' />
public partial struct KBDLLHOOKSTRUCT
{
    /// <include file='KBDLLHOOKSTRUCT.xml' path='doc/member[@name="KBDLLHOOKSTRUCT.vkCode"]/*' />
    [NativeTypeName("DWORD")]
    public uint vkCode;

    /// <include file='KBDLLHOOKSTRUCT.xml' path='doc/member[@name="KBDLLHOOKSTRUCT.scanCode"]/*' />
    [NativeTypeName("DWORD")]
    public uint scanCode;

    /// <include file='KBDLLHOOKSTRUCT.xml' path='doc/member[@name="KBDLLHOOKSTRUCT.flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint flags;

    /// <include file='KBDLLHOOKSTRUCT.xml' path='doc/member[@name="KBDLLHOOKSTRUCT.time"]/*' />
    [NativeTypeName("DWORD")]
    public uint time;

    /// <include file='KBDLLHOOKSTRUCT.xml' path='doc/member[@name="KBDLLHOOKSTRUCT.dwExtraInfo"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint dwExtraInfo;
}
