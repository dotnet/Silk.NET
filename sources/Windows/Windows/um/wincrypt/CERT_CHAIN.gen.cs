// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_CHAIN.xml' path='doc/member[@name="CERT_CHAIN"]/*'/>
public unsafe partial struct CERT_CHAIN
{
    /// <include file='CERT_CHAIN.xml' path='doc/member[@name="CERT_CHAIN.cCerts"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cCerts;
    /// <include file='CERT_CHAIN.xml' path='doc/member[@name="CERT_CHAIN.certs"]/*'/>
    [NativeTypeName("PCERT_BLOB")]
    public CRYPT_DATA_BLOB* certs;
    /// <include file='CERT_CHAIN.xml' path='doc/member[@name="CERT_CHAIN.keyLocatorInfo"]/*'/>
    public CRYPT_KEY_PROV_INFO keyLocatorInfo;
}