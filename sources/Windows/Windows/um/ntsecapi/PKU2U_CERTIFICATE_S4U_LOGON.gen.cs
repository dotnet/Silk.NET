// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PKU2U_CERTIFICATE_S4U_LOGON.xml' path='doc/member[@name="PKU2U_CERTIFICATE_S4U_LOGON"]/*'/>
public unsafe partial struct PKU2U_CERTIFICATE_S4U_LOGON
{
    /// <include file='PKU2U_CERTIFICATE_S4U_LOGON.xml' path='doc/member[@name="PKU2U_CERTIFICATE_S4U_LOGON.MessageType"]/*'/>
    public PKU2U_LOGON_SUBMIT_TYPE MessageType;
    /// <include file='PKU2U_CERTIFICATE_S4U_LOGON.xml' path='doc/member[@name="PKU2U_CERTIFICATE_S4U_LOGON.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
    /// <include file='PKU2U_CERTIFICATE_S4U_LOGON.xml' path='doc/member[@name="PKU2U_CERTIFICATE_S4U_LOGON.UserPrincipalName"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING UserPrincipalName;
    /// <include file='PKU2U_CERTIFICATE_S4U_LOGON.xml' path='doc/member[@name="PKU2U_CERTIFICATE_S4U_LOGON.DomainName"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING DomainName;
    /// <include file='PKU2U_CERTIFICATE_S4U_LOGON.xml' path='doc/member[@name="PKU2U_CERTIFICATE_S4U_LOGON.CertificateLength"]/*'/>
    [NativeTypeName("ULONG")]
    public uint CertificateLength;
    /// <include file='PKU2U_CERTIFICATE_S4U_LOGON.xml' path='doc/member[@name="PKU2U_CERTIFICATE_S4U_LOGON.Certificate"]/*'/>
    [NativeTypeName("PUCHAR")]
    public byte* Certificate;
}