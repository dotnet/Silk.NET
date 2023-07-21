// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ENHMETARECORD.xml' path='doc/member[@name="ENHMETARECORD"]/*' />
public unsafe partial struct ENHMETARECORD
{
    /// <include file='ENHMETARECORD.xml' path='doc/member[@name="ENHMETARECORD.iType"]/*' />
    [NativeTypeName("DWORD")]
    public uint iType;

    /// <include file='ENHMETARECORD.xml' path='doc/member[@name="ENHMETARECORD.nSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint nSize;

    /// <include file='ENHMETARECORD.xml' path='doc/member[@name="ENHMETARECORD.dParm"]/*' />
    [NativeTypeName("DWORD[1]")]
    public fixed uint dParm[1];
}
