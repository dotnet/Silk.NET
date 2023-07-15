// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CRYPT_VERIFY_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_VERIFY_MESSAGE_PARA"]/*'/>
public unsafe partial struct CRYPT_VERIFY_MESSAGE_PARA
{
    /// <include file='CRYPT_VERIFY_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_VERIFY_MESSAGE_PARA.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CRYPT_VERIFY_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_VERIFY_MESSAGE_PARA.dwMsgAndCertEncodingType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMsgAndCertEncodingType;
    /// <include file='CRYPT_VERIFY_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_VERIFY_MESSAGE_PARA.hCryptProv"]/*'/>
    public HCRYPTPROV_LEGACY hCryptProv;
    /// <include file='CRYPT_VERIFY_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_VERIFY_MESSAGE_PARA.pfnGetSignerCertificate"]/*'/>
    [NativeTypeName("PFN_CRYPT_GET_SIGNER_CERTIFICATE")]
    public delegate* unmanaged<void*, uint, CERT_INFO*, HCERTSTORE, CERT_CONTEXT*> pfnGetSignerCertificate;
    /// <include file='CRYPT_VERIFY_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_VERIFY_MESSAGE_PARA.pvGetArg"]/*'/>
    public void* pvGetArg;
}