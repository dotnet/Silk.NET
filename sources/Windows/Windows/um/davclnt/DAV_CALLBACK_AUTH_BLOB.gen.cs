// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/davclnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DAV_CALLBACK_AUTH_BLOB.xml' path='doc/member[@name="DAV_CALLBACK_AUTH_BLOB"]/*' />
public unsafe partial struct DAV_CALLBACK_AUTH_BLOB
{
    /// <include file='DAV_CALLBACK_AUTH_BLOB.xml' path='doc/member[@name="DAV_CALLBACK_AUTH_BLOB.pBuffer"]/*' />
    [NativeTypeName("PVOID")]
    public void* pBuffer;

    /// <include file='DAV_CALLBACK_AUTH_BLOB.xml' path='doc/member[@name="DAV_CALLBACK_AUTH_BLOB.ulSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulSize;

    /// <include file='DAV_CALLBACK_AUTH_BLOB.xml' path='doc/member[@name="DAV_CALLBACK_AUTH_BLOB.ulType"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulType;
}
