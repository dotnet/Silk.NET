// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SPRECORESULTTIMES.xml' path='doc/member[@name="SPRECORESULTTIMES"]/*' />
public partial struct SPRECORESULTTIMES
{
    /// <include file='SPRECORESULTTIMES.xml' path='doc/member[@name="SPRECORESULTTIMES.ftStreamTime"]/*' />
    public FILETIME ftStreamTime;

    /// <include file='SPRECORESULTTIMES.xml' path='doc/member[@name="SPRECORESULTTIMES.ullLength"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ullLength;

    /// <include file='SPRECORESULTTIMES.xml' path='doc/member[@name="SPRECORESULTTIMES.dwTickCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwTickCount;

    /// <include file='SPRECORESULTTIMES.xml' path='doc/member[@name="SPRECORESULTTIMES.ullStart"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ullStart;
}
