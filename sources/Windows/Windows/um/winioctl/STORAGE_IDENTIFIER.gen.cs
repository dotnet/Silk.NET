// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='STORAGE_IDENTIFIER.xml' path='doc/member[@name="STORAGE_IDENTIFIER"]/*' />
public unsafe partial struct STORAGE_IDENTIFIER
{
    /// <include file='STORAGE_IDENTIFIER.xml' path='doc/member[@name="STORAGE_IDENTIFIER.CodeSet"]/*' />
    public STORAGE_IDENTIFIER_CODE_SET CodeSet;

    /// <include file='STORAGE_IDENTIFIER.xml' path='doc/member[@name="STORAGE_IDENTIFIER.Type"]/*' />
    public STORAGE_IDENTIFIER_TYPE Type;

    /// <include file='STORAGE_IDENTIFIER.xml' path='doc/member[@name="STORAGE_IDENTIFIER.IdentifierSize"]/*' />
    [NativeTypeName("WORD")]
    public ushort IdentifierSize;

    /// <include file='STORAGE_IDENTIFIER.xml' path='doc/member[@name="STORAGE_IDENTIFIER.NextOffset"]/*' />
    [NativeTypeName("WORD")]
    public ushort NextOffset;

    /// <include file='STORAGE_IDENTIFIER.xml' path='doc/member[@name="STORAGE_IDENTIFIER.Association"]/*' />
    public STORAGE_ASSOCIATION_TYPE Association;

    /// <include file='STORAGE_IDENTIFIER.xml' path='doc/member[@name="STORAGE_IDENTIFIER.Identifier"]/*' />
    [NativeTypeName("BYTE[1]")]
    public fixed byte Identifier[1];
}
