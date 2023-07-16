// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CRL_INFO.xml' path='doc/member[@name="CRL_INFO"]/*'/>
public unsafe partial struct CRL_INFO
{
    /// <include file='CRL_INFO.xml' path='doc/member[@name="CRL_INFO.dwVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVersion;
    /// <include file='CRL_INFO.xml' path='doc/member[@name="CRL_INFO.SignatureAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER SignatureAlgorithm;
    /// <include file='CRL_INFO.xml' path='doc/member[@name="CRL_INFO.Issuer"]/*'/>
    [NativeTypeName("CERT_NAME_BLOB")]
    public CRYPT_DATA_BLOB Issuer;
    /// <include file='CRL_INFO.xml' path='doc/member[@name="CRL_INFO.ThisUpdate"]/*'/>
    public FILETIME ThisUpdate;
    /// <include file='CRL_INFO.xml' path='doc/member[@name="CRL_INFO.NextUpdate"]/*'/>
    public FILETIME NextUpdate;
    /// <include file='CRL_INFO.xml' path='doc/member[@name="CRL_INFO.cCRLEntry"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cCRLEntry;
    /// <include file='CRL_INFO.xml' path='doc/member[@name="CRL_INFO.rgCRLEntry"]/*'/>
    [NativeTypeName("PCRL_ENTRY")]
    public CRL_ENTRY* rgCRLEntry;
    /// <include file='CRL_INFO.xml' path='doc/member[@name="CRL_INFO.cExtension"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cExtension;
    /// <include file='CRL_INFO.xml' path='doc/member[@name="CRL_INFO.rgExtension"]/*'/>
    [NativeTypeName("PCERT_EXTENSION")]
    public CERT_EXTENSION* rgExtension;
}