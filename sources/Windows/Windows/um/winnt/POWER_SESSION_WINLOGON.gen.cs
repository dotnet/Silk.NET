// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='POWER_SESSION_WINLOGON.xml' path='doc/member[@name="POWER_SESSION_WINLOGON"]/*' />
public partial struct POWER_SESSION_WINLOGON
{
    /// <include file='POWER_SESSION_WINLOGON.xml' path='doc/member[@name="POWER_SESSION_WINLOGON.SessionId"]/*' />
    [NativeTypeName("DWORD")]
    public uint SessionId;

    /// <include file='POWER_SESSION_WINLOGON.xml' path='doc/member[@name="POWER_SESSION_WINLOGON.Console"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte Console;

    /// <include file='POWER_SESSION_WINLOGON.xml' path='doc/member[@name="POWER_SESSION_WINLOGON.Locked"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte Locked;
}
