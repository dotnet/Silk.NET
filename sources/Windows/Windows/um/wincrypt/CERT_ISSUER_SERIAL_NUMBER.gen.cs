// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_ISSUER_SERIAL_NUMBER.xml' path='doc/member[@name="CERT_ISSUER_SERIAL_NUMBER"]/*'/>
public partial struct CERT_ISSUER_SERIAL_NUMBER
{
    /// <include file='CERT_ISSUER_SERIAL_NUMBER.xml' path='doc/member[@name="CERT_ISSUER_SERIAL_NUMBER.Issuer"]/*'/>
    [NativeTypeName("CERT_NAME_BLOB")]
    public CRYPT_DATA_BLOB Issuer;
    /// <include file='CERT_ISSUER_SERIAL_NUMBER.xml' path='doc/member[@name="CERT_ISSUER_SERIAL_NUMBER.SerialNumber"]/*'/>
    [NativeTypeName("CRYPT_INTEGER_BLOB")]
    public CRYPT_DATA_BLOB SerialNumber;
}