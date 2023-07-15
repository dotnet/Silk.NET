// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CRL_ENTRY.xml' path='doc/member[@name="CRL_ENTRY"]/*'/>
public unsafe partial struct CRL_ENTRY
{
    /// <include file='CRL_ENTRY.xml' path='doc/member[@name="CRL_ENTRY.SerialNumber"]/*'/>
    [NativeTypeName("CRYPT_INTEGER_BLOB")]
    public CRYPT_DATA_BLOB SerialNumber;
    /// <include file='CRL_ENTRY.xml' path='doc/member[@name="CRL_ENTRY.RevocationDate"]/*'/>
    public FILETIME RevocationDate;
    /// <include file='CRL_ENTRY.xml' path='doc/member[@name="CRL_ENTRY.cExtension"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cExtension;
    /// <include file='CRL_ENTRY.xml' path='doc/member[@name="CRL_ENTRY.rgExtension"]/*'/>
    [NativeTypeName("PCERT_EXTENSION")]
    public CERT_EXTENSION* rgExtension;
}