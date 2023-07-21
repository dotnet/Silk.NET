// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='POWER_SESSION_TIMEOUTS.xml' path='doc/member[@name="POWER_SESSION_TIMEOUTS"]/*' />
public partial struct POWER_SESSION_TIMEOUTS
{
    /// <include file='POWER_SESSION_TIMEOUTS.xml' path='doc/member[@name="POWER_SESSION_TIMEOUTS.InputTimeout"]/*' />
    [NativeTypeName("DWORD")]
    public uint InputTimeout;

    /// <include file='POWER_SESSION_TIMEOUTS.xml' path='doc/member[@name="POWER_SESSION_TIMEOUTS.DisplayTimeout"]/*' />
    [NativeTypeName("DWORD")]
    public uint DisplayTimeout;
}
