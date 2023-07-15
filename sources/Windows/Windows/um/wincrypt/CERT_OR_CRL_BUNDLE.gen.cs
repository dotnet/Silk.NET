// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CERT_OR_CRL_BUNDLE.xml' path='doc/member[@name="CERT_OR_CRL_BUNDLE"]/*'/>
public unsafe partial struct CERT_OR_CRL_BUNDLE
{
    /// <include file='CERT_OR_CRL_BUNDLE.xml' path='doc/member[@name="CERT_OR_CRL_BUNDLE.cItem"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cItem;
    /// <include file='CERT_OR_CRL_BUNDLE.xml' path='doc/member[@name="CERT_OR_CRL_BUNDLE.rgItem"]/*'/>
    [NativeTypeName("PCERT_OR_CRL_BLOB")]
    public CERT_OR_CRL_BLOB* rgItem;
}