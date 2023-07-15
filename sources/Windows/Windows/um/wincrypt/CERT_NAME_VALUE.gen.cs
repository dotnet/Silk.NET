// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CERT_NAME_VALUE.xml' path='doc/member[@name="CERT_NAME_VALUE"]/*'/>
public partial struct CERT_NAME_VALUE
{
    /// <include file='CERT_NAME_VALUE.xml' path='doc/member[@name="CERT_NAME_VALUE.dwValueType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwValueType;
    /// <include file='CERT_NAME_VALUE.xml' path='doc/member[@name="CERT_NAME_VALUE.Value"]/*'/>
    [NativeTypeName("CERT_RDN_VALUE_BLOB")]
    public CRYPT_DATA_BLOB Value;
}