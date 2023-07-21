// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CRYPT_X942_OTHER_INFO.xml' path='doc/member[@name="CRYPT_X942_OTHER_INFO"]/*' />
public unsafe partial struct CRYPT_X942_OTHER_INFO
{
    /// <include file='CRYPT_X942_OTHER_INFO.xml' path='doc/member[@name="CRYPT_X942_OTHER_INFO.pszContentEncryptionObjId"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pszContentEncryptionObjId;

    /// <include file='CRYPT_X942_OTHER_INFO.xml' path='doc/member[@name="CRYPT_X942_OTHER_INFO.rgbCounter"]/*' />
    [NativeTypeName("BYTE[4]")]
    public fixed byte rgbCounter[4];

    /// <include file='CRYPT_X942_OTHER_INFO.xml' path='doc/member[@name="CRYPT_X942_OTHER_INFO.rgbKeyLength"]/*' />
    [NativeTypeName("BYTE[4]")]
    public fixed byte rgbKeyLength[4];

    /// <include file='CRYPT_X942_OTHER_INFO.xml' path='doc/member[@name="CRYPT_X942_OTHER_INFO.PubInfo"]/*' />
    public CRYPT_DATA_BLOB PubInfo;
}
