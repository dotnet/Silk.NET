// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CRYPT_ECC_CMS_SHARED_INFO.xml' path='doc/member[@name="CRYPT_ECC_CMS_SHARED_INFO"]/*' />
public unsafe partial struct CRYPT_ECC_CMS_SHARED_INFO
{
    /// <include file='CRYPT_ECC_CMS_SHARED_INFO.xml' path='doc/member[@name="CRYPT_ECC_CMS_SHARED_INFO.Algorithm"]/*' />
    public CRYPT_ALGORITHM_IDENTIFIER Algorithm;

    /// <include file='CRYPT_ECC_CMS_SHARED_INFO.xml' path='doc/member[@name="CRYPT_ECC_CMS_SHARED_INFO.EntityUInfo"]/*' />
    public CRYPT_DATA_BLOB EntityUInfo;

    /// <include file='CRYPT_ECC_CMS_SHARED_INFO.xml' path='doc/member[@name="CRYPT_ECC_CMS_SHARED_INFO.rgbSuppPubInfo"]/*' />
    [NativeTypeName("BYTE[4]")]
    public fixed byte rgbSuppPubInfo[4];
}
