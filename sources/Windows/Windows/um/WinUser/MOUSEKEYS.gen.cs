// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MOUSEKEYS.xml' path='doc/member[@name="MOUSEKEYS"]/*' />
public partial struct MOUSEKEYS
{
    /// <include file='MOUSEKEYS.xml' path='doc/member[@name="MOUSEKEYS.cbSize"]/*' />
    public uint cbSize;

    /// <include file='MOUSEKEYS.xml' path='doc/member[@name="MOUSEKEYS.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='MOUSEKEYS.xml' path='doc/member[@name="MOUSEKEYS.iMaxSpeed"]/*' />
    [NativeTypeName("DWORD")]
    public uint iMaxSpeed;

    /// <include file='MOUSEKEYS.xml' path='doc/member[@name="MOUSEKEYS.iTimeToMaxSpeed"]/*' />
    [NativeTypeName("DWORD")]
    public uint iTimeToMaxSpeed;

    /// <include file='MOUSEKEYS.xml' path='doc/member[@name="MOUSEKEYS.iCtrlSpeed"]/*' />
    [NativeTypeName("DWORD")]
    public uint iCtrlSpeed;

    /// <include file='MOUSEKEYS.xml' path='doc/member[@name="MOUSEKEYS.dwReserved1"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved1;

    /// <include file='MOUSEKEYS.xml' path='doc/member[@name="MOUSEKEYS.dwReserved2"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved2;
}
