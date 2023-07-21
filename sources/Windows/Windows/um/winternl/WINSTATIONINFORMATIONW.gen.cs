// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WINSTATIONINFORMATIONW.xml' path='doc/member[@name="WINSTATIONINFORMATIONW"]/*' />
public unsafe partial struct WINSTATIONINFORMATIONW
{
    /// <include file='WINSTATIONINFORMATIONW.xml' path='doc/member[@name="WINSTATIONINFORMATIONW.Reserved2"]/*' />
    [NativeTypeName("BYTE[70]")]
    public fixed byte Reserved2[70];

    /// <include file='WINSTATIONINFORMATIONW.xml' path='doc/member[@name="WINSTATIONINFORMATIONW.LogonId"]/*' />
    [NativeTypeName("ULONG")]
    public uint LogonId;

    /// <include file='WINSTATIONINFORMATIONW.xml' path='doc/member[@name="WINSTATIONINFORMATIONW.Reserved3"]/*' />
    [NativeTypeName("BYTE[1140]")]
    public fixed byte Reserved3[1140];
}
