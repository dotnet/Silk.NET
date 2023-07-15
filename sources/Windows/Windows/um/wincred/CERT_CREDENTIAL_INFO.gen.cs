// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CERT_CREDENTIAL_INFO.xml' path='doc/member[@name="CERT_CREDENTIAL_INFO"]/*'/>
public unsafe partial struct CERT_CREDENTIAL_INFO
{
    /// <include file='CERT_CREDENTIAL_INFO.xml' path='doc/member[@name="CERT_CREDENTIAL_INFO.cbSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cbSize;
    /// <include file='CERT_CREDENTIAL_INFO.xml' path='doc/member[@name="CERT_CREDENTIAL_INFO.rgbHashOfCert"]/*'/>
    [NativeTypeName("UCHAR[20]")]
    public fixed byte rgbHashOfCert[20];
}