// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='BLOB.xml' path='doc/member[@name="BLOB"]/*' />
public unsafe partial struct BLOB
{
    /// <include file='BLOB.xml' path='doc/member[@name="BLOB.cbSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint cbSize;

    /// <include file='BLOB.xml' path='doc/member[@name="BLOB.pBlobData"]/*' />
    public byte* pBlobData;
}
