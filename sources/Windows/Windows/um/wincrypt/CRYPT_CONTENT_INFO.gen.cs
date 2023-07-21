// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CRYPT_CONTENT_INFO.xml' path='doc/member[@name="CRYPT_CONTENT_INFO"]/*' />
public unsafe partial struct CRYPT_CONTENT_INFO
{
    /// <include file='CRYPT_CONTENT_INFO.xml' path='doc/member[@name="CRYPT_CONTENT_INFO.pszObjId"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pszObjId;

    /// <include file='CRYPT_CONTENT_INFO.xml' path='doc/member[@name="CRYPT_CONTENT_INFO.Content"]/*' />
    [NativeTypeName("CRYPT_DER_BLOB")]
    public CRYPT_DATA_BLOB Content;
}
