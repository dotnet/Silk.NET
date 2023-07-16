// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_OTHER_NAME.xml' path='doc/member[@name="CERT_OTHER_NAME"]/*'/>
public unsafe partial struct CERT_OTHER_NAME
{
    /// <include file='CERT_OTHER_NAME.xml' path='doc/member[@name="CERT_OTHER_NAME.pszObjId"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszObjId;
    /// <include file='CERT_OTHER_NAME.xml' path='doc/member[@name="CERT_OTHER_NAME.Value"]/*'/>
    [NativeTypeName("CRYPT_OBJID_BLOB")]
    public CRYPT_DATA_BLOB Value;
}