// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CERT_KEYGEN_REQUEST_INFO.xml' path='doc/member[@name="CERT_KEYGEN_REQUEST_INFO"]/*'/>
public unsafe partial struct CERT_KEYGEN_REQUEST_INFO
{
    /// <include file='CERT_KEYGEN_REQUEST_INFO.xml' path='doc/member[@name="CERT_KEYGEN_REQUEST_INFO.dwVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVersion;
    /// <include file='CERT_KEYGEN_REQUEST_INFO.xml' path='doc/member[@name="CERT_KEYGEN_REQUEST_INFO.SubjectPublicKeyInfo"]/*'/>
    public CERT_PUBLIC_KEY_INFO SubjectPublicKeyInfo;
    /// <include file='CERT_KEYGEN_REQUEST_INFO.xml' path='doc/member[@name="CERT_KEYGEN_REQUEST_INFO.pwszChallengeString"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pwszChallengeString;
}