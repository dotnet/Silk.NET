// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='EVENTLOG_FULL_INFORMATION.xml' path='doc/member[@name="EVENTLOG_FULL_INFORMATION"]/*' />
public partial struct EVENTLOG_FULL_INFORMATION
{
    /// <include file='EVENTLOG_FULL_INFORMATION.xml' path='doc/member[@name="EVENTLOG_FULL_INFORMATION.dwFull"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFull;
}
