// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CERT_REVOCATION_STATUS.xml' path='doc/member[@name="CERT_REVOCATION_STATUS"]/*'/>
public partial struct CERT_REVOCATION_STATUS
{
    /// <include file='CERT_REVOCATION_STATUS.xml' path='doc/member[@name="CERT_REVOCATION_STATUS.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CERT_REVOCATION_STATUS.xml' path='doc/member[@name="CERT_REVOCATION_STATUS.dwIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwIndex;
    /// <include file='CERT_REVOCATION_STATUS.xml' path='doc/member[@name="CERT_REVOCATION_STATUS.dwError"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwError;
    /// <include file='CERT_REVOCATION_STATUS.xml' path='doc/member[@name="CERT_REVOCATION_STATUS.dwReason"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReason;
    /// <include file='CERT_REVOCATION_STATUS.xml' path='doc/member[@name="CERT_REVOCATION_STATUS.fHasFreshnessTime"]/*'/>
    public BOOL fHasFreshnessTime;
    /// <include file='CERT_REVOCATION_STATUS.xml' path='doc/member[@name="CERT_REVOCATION_STATUS.dwFreshnessTime"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFreshnessTime;
}