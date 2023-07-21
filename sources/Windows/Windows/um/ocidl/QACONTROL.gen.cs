// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='QACONTROL.xml' path='doc/member[@name="QACONTROL"]/*' />
public partial struct QACONTROL
{
    /// <include file='QACONTROL.xml' path='doc/member[@name="QACONTROL.cbSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint cbSize;

    /// <include file='QACONTROL.xml' path='doc/member[@name="QACONTROL.dwMiscStatus"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMiscStatus;

    /// <include file='QACONTROL.xml' path='doc/member[@name="QACONTROL.dwViewStatus"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwViewStatus;

    /// <include file='QACONTROL.xml' path='doc/member[@name="QACONTROL.dwEventCookie"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwEventCookie;

    /// <include file='QACONTROL.xml' path='doc/member[@name="QACONTROL.dwPropNotifyCookie"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPropNotifyCookie;

    /// <include file='QACONTROL.xml' path='doc/member[@name="QACONTROL.dwPointerActivationPolicy"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPointerActivationPolicy;
}
