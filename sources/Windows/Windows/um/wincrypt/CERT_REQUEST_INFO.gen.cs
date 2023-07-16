// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_REQUEST_INFO.xml' path='doc/member[@name="CERT_REQUEST_INFO"]/*'/>
public unsafe partial struct CERT_REQUEST_INFO
{
    /// <include file='CERT_REQUEST_INFO.xml' path='doc/member[@name="CERT_REQUEST_INFO.dwVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVersion;
    /// <include file='CERT_REQUEST_INFO.xml' path='doc/member[@name="CERT_REQUEST_INFO.Subject"]/*'/>
    [NativeTypeName("CERT_NAME_BLOB")]
    public CRYPT_DATA_BLOB Subject;
    /// <include file='CERT_REQUEST_INFO.xml' path='doc/member[@name="CERT_REQUEST_INFO.SubjectPublicKeyInfo"]/*'/>
    public CERT_PUBLIC_KEY_INFO SubjectPublicKeyInfo;
    /// <include file='CERT_REQUEST_INFO.xml' path='doc/member[@name="CERT_REQUEST_INFO.cAttribute"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cAttribute;
    /// <include file='CERT_REQUEST_INFO.xml' path='doc/member[@name="CERT_REQUEST_INFO.rgAttribute"]/*'/>
    [NativeTypeName("PCRYPT_ATTRIBUTE")]
    public CRYPT_ATTRIBUTE* rgAttribute;
}