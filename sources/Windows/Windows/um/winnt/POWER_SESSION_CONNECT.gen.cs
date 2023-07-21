// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='POWER_SESSION_CONNECT.xml' path='doc/member[@name="POWER_SESSION_CONNECT"]/*' />
public partial struct POWER_SESSION_CONNECT
{
    /// <include file='POWER_SESSION_CONNECT.xml' path='doc/member[@name="POWER_SESSION_CONNECT.Connected"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte Connected;

    /// <include file='POWER_SESSION_CONNECT.xml' path='doc/member[@name="POWER_SESSION_CONNECT.Console"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte Console;
}
