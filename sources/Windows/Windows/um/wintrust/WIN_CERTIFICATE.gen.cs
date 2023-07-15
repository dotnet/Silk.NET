// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WIN_CERTIFICATE.xml' path='doc/member[@name="WIN_CERTIFICATE"]/*'/>
public unsafe partial struct WIN_CERTIFICATE
{
    /// <include file='WIN_CERTIFICATE.xml' path='doc/member[@name="WIN_CERTIFICATE.dwLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwLength;
    /// <include file='WIN_CERTIFICATE.xml' path='doc/member[@name="WIN_CERTIFICATE.wRevision"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wRevision;
    /// <include file='WIN_CERTIFICATE.xml' path='doc/member[@name="WIN_CERTIFICATE.wCertificateType"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wCertificateType;
    /// <include file='WIN_CERTIFICATE.xml' path='doc/member[@name="WIN_CERTIFICATE.bCertificate"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte bCertificate[1];
}