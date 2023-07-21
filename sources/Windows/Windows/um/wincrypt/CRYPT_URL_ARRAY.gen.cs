// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CRYPT_URL_ARRAY.xml' path='doc/member[@name="CRYPT_URL_ARRAY"]/*' />
public unsafe partial struct CRYPT_URL_ARRAY
{
    /// <include file='CRYPT_URL_ARRAY.xml' path='doc/member[@name="CRYPT_URL_ARRAY.cUrl"]/*' />
    [NativeTypeName("DWORD")]
    public uint cUrl;

    /// <include file='CRYPT_URL_ARRAY.xml' path='doc/member[@name="CRYPT_URL_ARRAY.rgwszUrl"]/*' />
    [NativeTypeName("LPWSTR *")]
    public ushort** rgwszUrl;
}
