// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WINHTTP_CERTIFICATE_INFO.xml' path='doc/member[@name="WINHTTP_CERTIFICATE_INFO"]/*'/>
public unsafe partial struct WINHTTP_CERTIFICATE_INFO
{
    /// <include file='WINHTTP_CERTIFICATE_INFO.xml' path='doc/member[@name="WINHTTP_CERTIFICATE_INFO.ftExpiry"]/*'/>
    public FILETIME ftExpiry;
    /// <include file='WINHTTP_CERTIFICATE_INFO.xml' path='doc/member[@name="WINHTTP_CERTIFICATE_INFO.ftStart"]/*'/>
    public FILETIME ftStart;
    /// <include file='WINHTTP_CERTIFICATE_INFO.xml' path='doc/member[@name="WINHTTP_CERTIFICATE_INFO.lpszSubjectInfo"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpszSubjectInfo;
    /// <include file='WINHTTP_CERTIFICATE_INFO.xml' path='doc/member[@name="WINHTTP_CERTIFICATE_INFO.lpszIssuerInfo"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpszIssuerInfo;
    /// <include file='WINHTTP_CERTIFICATE_INFO.xml' path='doc/member[@name="WINHTTP_CERTIFICATE_INFO.lpszProtocolName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpszProtocolName;
    /// <include file='WINHTTP_CERTIFICATE_INFO.xml' path='doc/member[@name="WINHTTP_CERTIFICATE_INFO.lpszSignatureAlgName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpszSignatureAlgName;
    /// <include file='WINHTTP_CERTIFICATE_INFO.xml' path='doc/member[@name="WINHTTP_CERTIFICATE_INFO.lpszEncryptionAlgName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpszEncryptionAlgName;
    /// <include file='WINHTTP_CERTIFICATE_INFO.xml' path='doc/member[@name="WINHTTP_CERTIFICATE_INFO.dwKeySize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwKeySize;
}