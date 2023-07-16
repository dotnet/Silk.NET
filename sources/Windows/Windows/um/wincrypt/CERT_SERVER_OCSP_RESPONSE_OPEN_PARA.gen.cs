// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_SERVER_OCSP_RESPONSE_OPEN_PARA.xml' path='doc/member[@name="CERT_SERVER_OCSP_RESPONSE_OPEN_PARA"]/*'/>
public unsafe partial struct CERT_SERVER_OCSP_RESPONSE_OPEN_PARA
{
    /// <include file='CERT_SERVER_OCSP_RESPONSE_OPEN_PARA.xml' path='doc/member[@name="CERT_SERVER_OCSP_RESPONSE_OPEN_PARA.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CERT_SERVER_OCSP_RESPONSE_OPEN_PARA.xml' path='doc/member[@name="CERT_SERVER_OCSP_RESPONSE_OPEN_PARA.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='CERT_SERVER_OCSP_RESPONSE_OPEN_PARA.xml' path='doc/member[@name="CERT_SERVER_OCSP_RESPONSE_OPEN_PARA.pcbUsedSize"]/*'/>
    [NativeTypeName("DWORD *")]
    public uint* pcbUsedSize;
    /// <include file='CERT_SERVER_OCSP_RESPONSE_OPEN_PARA.xml' path='doc/member[@name="CERT_SERVER_OCSP_RESPONSE_OPEN_PARA.pwszOcspDirectory"]/*'/>
    [NativeTypeName("PWSTR")]
    public ushort* pwszOcspDirectory;
    /// <include file='CERT_SERVER_OCSP_RESPONSE_OPEN_PARA.xml' path='doc/member[@name="CERT_SERVER_OCSP_RESPONSE_OPEN_PARA.pfnUpdateCallback"]/*'/>
    [NativeTypeName("PFN_CERT_SERVER_OCSP_RESPONSE_UPDATE_CALLBACK")]
    public delegate* unmanaged<CERT_CHAIN_CONTEXT*, CERT_SERVER_OCSP_RESPONSE_CONTEXT*, CRL_CONTEXT*, CRL_CONTEXT*, void*, uint, void> pfnUpdateCallback;
    /// <include file='CERT_SERVER_OCSP_RESPONSE_OPEN_PARA.xml' path='doc/member[@name="CERT_SERVER_OCSP_RESPONSE_OPEN_PARA.pvUpdateCallbackArg"]/*'/>
    [NativeTypeName("PVOID")]
    public void* pvUpdateCallbackArg;
}