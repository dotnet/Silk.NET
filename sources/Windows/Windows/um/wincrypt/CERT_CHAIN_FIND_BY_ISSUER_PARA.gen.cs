// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_CHAIN_FIND_BY_ISSUER_PARA.xml' path='doc/member[@name="CERT_CHAIN_FIND_BY_ISSUER_PARA"]/*'/>
public unsafe partial struct CERT_CHAIN_FIND_BY_ISSUER_PARA
{
    /// <include file='CERT_CHAIN_FIND_BY_ISSUER_PARA.xml' path='doc/member[@name="CERT_CHAIN_FIND_BY_ISSUER_PARA.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CERT_CHAIN_FIND_BY_ISSUER_PARA.xml' path='doc/member[@name="CERT_CHAIN_FIND_BY_ISSUER_PARA.pszUsageIdentifier"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* pszUsageIdentifier;
    /// <include file='CERT_CHAIN_FIND_BY_ISSUER_PARA.xml' path='doc/member[@name="CERT_CHAIN_FIND_BY_ISSUER_PARA.dwKeySpec"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwKeySpec;
    /// <include file='CERT_CHAIN_FIND_BY_ISSUER_PARA.xml' path='doc/member[@name="CERT_CHAIN_FIND_BY_ISSUER_PARA.dwAcquirePrivateKeyFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAcquirePrivateKeyFlags;
    /// <include file='CERT_CHAIN_FIND_BY_ISSUER_PARA.xml' path='doc/member[@name="CERT_CHAIN_FIND_BY_ISSUER_PARA.cIssuer"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cIssuer;
    /// <include file='CERT_CHAIN_FIND_BY_ISSUER_PARA.xml' path='doc/member[@name="CERT_CHAIN_FIND_BY_ISSUER_PARA.rgIssuer"]/*'/>
    [NativeTypeName("CERT_NAME_BLOB *")]
    public CRYPT_DATA_BLOB* rgIssuer;
    /// <include file='CERT_CHAIN_FIND_BY_ISSUER_PARA.xml' path='doc/member[@name="CERT_CHAIN_FIND_BY_ISSUER_PARA.pfnFindCallback"]/*'/>
    [NativeTypeName("PFN_CERT_CHAIN_FIND_BY_ISSUER_CALLBACK")]
    public delegate* unmanaged<CERT_CONTEXT*, void*, BOOL> pfnFindCallback;
    /// <include file='CERT_CHAIN_FIND_BY_ISSUER_PARA.xml' path='doc/member[@name="CERT_CHAIN_FIND_BY_ISSUER_PARA.pvFindArg"]/*'/>
    public void* pvFindArg;
}