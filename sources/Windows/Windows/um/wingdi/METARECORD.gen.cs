// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='METARECORD.xml' path='doc/member[@name="METARECORD"]/*' />
public unsafe partial struct METARECORD
{
    /// <include file='METARECORD.xml' path='doc/member[@name="METARECORD.rdSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint rdSize;

    /// <include file='METARECORD.xml' path='doc/member[@name="METARECORD.rdFunction"]/*' />
    [NativeTypeName("WORD")]
    public ushort rdFunction;

    /// <include file='METARECORD.xml' path='doc/member[@name="METARECORD.rdParm"]/*' />
    [NativeTypeName("WORD[1]")]
    public fixed ushort rdParm[1];
}
