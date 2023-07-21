// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CRYPT_URL_INFO.xml' path='doc/member[@name="CRYPT_URL_INFO"]/*' />
public unsafe partial struct CRYPT_URL_INFO
{
    /// <include file='CRYPT_URL_INFO.xml' path='doc/member[@name="CRYPT_URL_INFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CRYPT_URL_INFO.xml' path='doc/member[@name="CRYPT_URL_INFO.dwSyncDeltaTime"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSyncDeltaTime;

    /// <include file='CRYPT_URL_INFO.xml' path='doc/member[@name="CRYPT_URL_INFO.cGroup"]/*' />
    [NativeTypeName("DWORD")]
    public uint cGroup;

    /// <include file='CRYPT_URL_INFO.xml' path='doc/member[@name="CRYPT_URL_INFO.rgcGroupEntry"]/*' />
    [NativeTypeName("DWORD *")]
    public uint* rgcGroupEntry;
}
