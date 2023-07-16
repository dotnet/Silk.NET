// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='OCSP_REQUEST_ENTRY.xml' path='doc/member[@name="OCSP_REQUEST_ENTRY"]/*'/>
public unsafe partial struct OCSP_REQUEST_ENTRY
{
    /// <include file='OCSP_REQUEST_ENTRY.xml' path='doc/member[@name="OCSP_REQUEST_ENTRY.CertId"]/*'/>
    public OCSP_CERT_ID CertId;
    /// <include file='OCSP_REQUEST_ENTRY.xml' path='doc/member[@name="OCSP_REQUEST_ENTRY.cExtension"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cExtension;
    /// <include file='OCSP_REQUEST_ENTRY.xml' path='doc/member[@name="OCSP_REQUEST_ENTRY.rgExtension"]/*'/>
    [NativeTypeName("PCERT_EXTENSION")]
    public CERT_EXTENSION* rgExtension;
}