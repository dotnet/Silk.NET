// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='RAWINPUTDEVICE.xml' path='doc/member[@name="RAWINPUTDEVICE"]/*' />
public partial struct RAWINPUTDEVICE
{
    /// <include file='RAWINPUTDEVICE.xml' path='doc/member[@name="RAWINPUTDEVICE.usUsagePage"]/*' />
    public ushort usUsagePage;

    /// <include file='RAWINPUTDEVICE.xml' path='doc/member[@name="RAWINPUTDEVICE.usUsage"]/*' />
    public ushort usUsage;

    /// <include file='RAWINPUTDEVICE.xml' path='doc/member[@name="RAWINPUTDEVICE.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='RAWINPUTDEVICE.xml' path='doc/member[@name="RAWINPUTDEVICE.hwndTarget"]/*' />
    public HWND hwndTarget;
}
