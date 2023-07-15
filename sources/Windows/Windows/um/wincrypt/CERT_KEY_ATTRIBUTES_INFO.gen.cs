// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CERT_KEY_ATTRIBUTES_INFO.xml' path='doc/member[@name="CERT_KEY_ATTRIBUTES_INFO"]/*'/>
public unsafe partial struct CERT_KEY_ATTRIBUTES_INFO
{
    /// <include file='CERT_KEY_ATTRIBUTES_INFO.xml' path='doc/member[@name="CERT_KEY_ATTRIBUTES_INFO.KeyId"]/*'/>
    public CRYPT_DATA_BLOB KeyId;
    /// <include file='CERT_KEY_ATTRIBUTES_INFO.xml' path='doc/member[@name="CERT_KEY_ATTRIBUTES_INFO.IntendedKeyUsage"]/*'/>
    public CRYPT_BIT_BLOB IntendedKeyUsage;
    /// <include file='CERT_KEY_ATTRIBUTES_INFO.xml' path='doc/member[@name="CERT_KEY_ATTRIBUTES_INFO.pPrivateKeyUsagePeriod"]/*'/>
    [NativeTypeName("PCERT_PRIVATE_KEY_VALIDITY")]
    public CERT_PRIVATE_KEY_VALIDITY* pPrivateKeyUsagePeriod;
}