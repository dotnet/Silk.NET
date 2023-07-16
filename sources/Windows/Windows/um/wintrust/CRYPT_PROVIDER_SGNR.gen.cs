// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CRYPT_PROVIDER_SGNR.xml' path='doc/member[@name="CRYPT_PROVIDER_SGNR"]/*'/>
public unsafe partial struct CRYPT_PROVIDER_SGNR
{
    /// <include file='CRYPT_PROVIDER_SGNR.xml' path='doc/member[@name="CRYPT_PROVIDER_SGNR.cbStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbStruct;
    /// <include file='CRYPT_PROVIDER_SGNR.xml' path='doc/member[@name="CRYPT_PROVIDER_SGNR.sftVerifyAsOf"]/*'/>
    public FILETIME sftVerifyAsOf;
    /// <include file='CRYPT_PROVIDER_SGNR.xml' path='doc/member[@name="CRYPT_PROVIDER_SGNR.csCertChain"]/*'/>
    [NativeTypeName("DWORD")]
    public uint csCertChain;
    /// <include file='CRYPT_PROVIDER_SGNR.xml' path='doc/member[@name="CRYPT_PROVIDER_SGNR.pasCertChain"]/*'/>
    [NativeTypeName("struct _CRYPT_PROVIDER_CERT *")]
    public CRYPT_PROVIDER_CERT* pasCertChain;
    /// <include file='CRYPT_PROVIDER_SGNR.xml' path='doc/member[@name="CRYPT_PROVIDER_SGNR.dwSignerType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSignerType;
    /// <include file='CRYPT_PROVIDER_SGNR.xml' path='doc/member[@name="CRYPT_PROVIDER_SGNR.psSigner"]/*'/>
    public CMSG_SIGNER_INFO* psSigner;
    /// <include file='CRYPT_PROVIDER_SGNR.xml' path='doc/member[@name="CRYPT_PROVIDER_SGNR.dwError"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwError;
    /// <include file='CRYPT_PROVIDER_SGNR.xml' path='doc/member[@name="CRYPT_PROVIDER_SGNR.csCounterSigners"]/*'/>
    [NativeTypeName("DWORD")]
    public uint csCounterSigners;
    /// <include file='CRYPT_PROVIDER_SGNR.xml' path='doc/member[@name="CRYPT_PROVIDER_SGNR.pasCounterSigners"]/*'/>
    [NativeTypeName("struct _CRYPT_PROVIDER_SGNR *")]
    public CRYPT_PROVIDER_SGNR* pasCounterSigners;
    /// <include file='CRYPT_PROVIDER_SGNR.xml' path='doc/member[@name="CRYPT_PROVIDER_SGNR.pChainContext"]/*'/>
    [NativeTypeName("PCCERT_CHAIN_CONTEXT")]
    public CERT_CHAIN_CONTEXT* pChainContext;
}