// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CERT_CONTEXT.xml' path='doc/member[@name="CERT_CONTEXT"]/*'/>
public unsafe partial struct CERT_CONTEXT
{
    /// <include file='CERT_CONTEXT.xml' path='doc/member[@name="CERT_CONTEXT.dwCertEncodingType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCertEncodingType;
    /// <include file='CERT_CONTEXT.xml' path='doc/member[@name="CERT_CONTEXT.pbCertEncoded"]/*'/>
    public byte* pbCertEncoded;
    /// <include file='CERT_CONTEXT.xml' path='doc/member[@name="CERT_CONTEXT.cbCertEncoded"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbCertEncoded;
    /// <include file='CERT_CONTEXT.xml' path='doc/member[@name="CERT_CONTEXT.pCertInfo"]/*'/>
    [NativeTypeName("PCERT_INFO")]
    public CERT_INFO* pCertInfo;
    /// <include file='CERT_CONTEXT.xml' path='doc/member[@name="CERT_CONTEXT.hCertStore"]/*'/>
    public HCERTSTORE hCertStore;
}