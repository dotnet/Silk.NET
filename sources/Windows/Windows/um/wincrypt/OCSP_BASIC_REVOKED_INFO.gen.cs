// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='OCSP_BASIC_REVOKED_INFO.xml' path='doc/member[@name="OCSP_BASIC_REVOKED_INFO"]/*'/>
public partial struct OCSP_BASIC_REVOKED_INFO
{
    /// <include file='OCSP_BASIC_REVOKED_INFO.xml' path='doc/member[@name="OCSP_BASIC_REVOKED_INFO.RevocationDate"]/*'/>
    public FILETIME RevocationDate;
    /// <include file='OCSP_BASIC_REVOKED_INFO.xml' path='doc/member[@name="OCSP_BASIC_REVOKED_INFO.dwCrlReasonCode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCrlReasonCode;
}