// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_RDN.xml' path='doc/member[@name="CERT_RDN"]/*'/>
public unsafe partial struct CERT_RDN
{
    /// <include file='CERT_RDN.xml' path='doc/member[@name="CERT_RDN.cRDNAttr"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cRDNAttr;
    /// <include file='CERT_RDN.xml' path='doc/member[@name="CERT_RDN.rgRDNAttr"]/*'/>
    [NativeTypeName("PCERT_RDN_ATTR")]
    public CERT_RDN_ATTR* rgRDNAttr;
}