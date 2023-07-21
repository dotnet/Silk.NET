// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='OCSP_RESPONSE_INFO.xml' path='doc/member[@name="OCSP_RESPONSE_INFO"]/*' />
public unsafe partial struct OCSP_RESPONSE_INFO
{
    /// <include file='OCSP_RESPONSE_INFO.xml' path='doc/member[@name="OCSP_RESPONSE_INFO.dwStatus"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStatus;

    /// <include file='OCSP_RESPONSE_INFO.xml' path='doc/member[@name="OCSP_RESPONSE_INFO.pszObjId"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pszObjId;

    /// <include file='OCSP_RESPONSE_INFO.xml' path='doc/member[@name="OCSP_RESPONSE_INFO.Value"]/*' />
    [NativeTypeName("CRYPT_OBJID_BLOB")]
    public CRYPT_DATA_BLOB Value;
}
