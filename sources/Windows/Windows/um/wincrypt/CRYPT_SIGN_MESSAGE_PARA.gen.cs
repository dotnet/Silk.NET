// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CRYPT_SIGN_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_SIGN_MESSAGE_PARA"]/*'/>
public unsafe partial struct CRYPT_SIGN_MESSAGE_PARA
{
    /// <include file='CRYPT_SIGN_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_SIGN_MESSAGE_PARA.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CRYPT_SIGN_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_SIGN_MESSAGE_PARA.dwMsgEncodingType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMsgEncodingType;
    /// <include file='CRYPT_SIGN_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_SIGN_MESSAGE_PARA.pSigningCert"]/*'/>
    [NativeTypeName("PCCERT_CONTEXT")]
    public CERT_CONTEXT* pSigningCert;
    /// <include file='CRYPT_SIGN_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_SIGN_MESSAGE_PARA.HashAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;
    /// <include file='CRYPT_SIGN_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_SIGN_MESSAGE_PARA.pvHashAuxInfo"]/*'/>
    public void* pvHashAuxInfo;
    /// <include file='CRYPT_SIGN_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_SIGN_MESSAGE_PARA.cMsgCert"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cMsgCert;
    /// <include file='CRYPT_SIGN_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_SIGN_MESSAGE_PARA.rgpMsgCert"]/*'/>
    [NativeTypeName("PCCERT_CONTEXT *")]
    public CERT_CONTEXT** rgpMsgCert;
    /// <include file='CRYPT_SIGN_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_SIGN_MESSAGE_PARA.cMsgCrl"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cMsgCrl;
    /// <include file='CRYPT_SIGN_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_SIGN_MESSAGE_PARA.rgpMsgCrl"]/*'/>
    [NativeTypeName("PCCRL_CONTEXT *")]
    public CRL_CONTEXT** rgpMsgCrl;
    /// <include file='CRYPT_SIGN_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_SIGN_MESSAGE_PARA.cAuthAttr"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cAuthAttr;
    /// <include file='CRYPT_SIGN_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_SIGN_MESSAGE_PARA.rgAuthAttr"]/*'/>
    [NativeTypeName("PCRYPT_ATTRIBUTE")]
    public CRYPT_ATTRIBUTE* rgAuthAttr;
    /// <include file='CRYPT_SIGN_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_SIGN_MESSAGE_PARA.cUnauthAttr"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cUnauthAttr;
    /// <include file='CRYPT_SIGN_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_SIGN_MESSAGE_PARA.rgUnauthAttr"]/*'/>
    [NativeTypeName("PCRYPT_ATTRIBUTE")]
    public CRYPT_ATTRIBUTE* rgUnauthAttr;
    /// <include file='CRYPT_SIGN_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_SIGN_MESSAGE_PARA.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='CRYPT_SIGN_MESSAGE_PARA.xml' path='doc/member[@name="CRYPT_SIGN_MESSAGE_PARA.dwInnerContentType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInnerContentType;
}