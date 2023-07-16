// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CRL_CONTEXT.xml' path='doc/member[@name="CRL_CONTEXT"]/*'/>
public unsafe partial struct CRL_CONTEXT
{
    /// <include file='CRL_CONTEXT.xml' path='doc/member[@name="CRL_CONTEXT.dwCertEncodingType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCertEncodingType;
    /// <include file='CRL_CONTEXT.xml' path='doc/member[@name="CRL_CONTEXT.pbCrlEncoded"]/*'/>
    public byte* pbCrlEncoded;
    /// <include file='CRL_CONTEXT.xml' path='doc/member[@name="CRL_CONTEXT.cbCrlEncoded"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbCrlEncoded;
    /// <include file='CRL_CONTEXT.xml' path='doc/member[@name="CRL_CONTEXT.pCrlInfo"]/*'/>
    [NativeTypeName("PCRL_INFO")]
    public CRL_INFO* pCrlInfo;
    /// <include file='CRL_CONTEXT.xml' path='doc/member[@name="CRL_CONTEXT.hCertStore"]/*'/>
    public HCERTSTORE hCertStore;
}