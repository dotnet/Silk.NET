// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='KERB_CERTIFICATE_INFO.xml' path='doc/member[@name="KERB_CERTIFICATE_INFO"]/*'/>
public partial struct KERB_CERTIFICATE_INFO
{
    /// <include file='KERB_CERTIFICATE_INFO.xml' path='doc/member[@name="KERB_CERTIFICATE_INFO.CertInfoSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint CertInfoSize;
    /// <include file='KERB_CERTIFICATE_INFO.xml' path='doc/member[@name="KERB_CERTIFICATE_INFO.InfoType"]/*'/>
    [NativeTypeName("ULONG")]
    public uint InfoType;
}