// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FLAGGED_BYTE_BLOB.xml' path='doc/member[@name="FLAGGED_BYTE_BLOB"]/*' />
public unsafe partial struct FLAGGED_BYTE_BLOB
{
    /// <include file='FLAGGED_BYTE_BLOB.xml' path='doc/member[@name="FLAGGED_BYTE_BLOB.fFlags"]/*' />
    [NativeTypeName("ULONG")]
    public uint fFlags;

    /// <include file='FLAGGED_BYTE_BLOB.xml' path='doc/member[@name="FLAGGED_BYTE_BLOB.clSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint clSize;

    /// <include file='FLAGGED_BYTE_BLOB.xml' path='doc/member[@name="FLAGGED_BYTE_BLOB.abData"]/*' />
    [NativeTypeName("byte[1]")]
    public fixed byte abData[1];
}
