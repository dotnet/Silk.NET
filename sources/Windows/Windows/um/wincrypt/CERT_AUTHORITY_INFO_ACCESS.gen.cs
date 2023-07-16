// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_AUTHORITY_INFO_ACCESS.xml' path='doc/member[@name="CERT_AUTHORITY_INFO_ACCESS"]/*'/>
public unsafe partial struct CERT_AUTHORITY_INFO_ACCESS
{
    /// <include file='CERT_AUTHORITY_INFO_ACCESS.xml' path='doc/member[@name="CERT_AUTHORITY_INFO_ACCESS.cAccDescr"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cAccDescr;
    /// <include file='CERT_AUTHORITY_INFO_ACCESS.xml' path='doc/member[@name="CERT_AUTHORITY_INFO_ACCESS.rgAccDescr"]/*'/>
    [NativeTypeName("PCERT_ACCESS_DESCRIPTION")]
    public CERT_ACCESS_DESCRIPTION* rgAccDescr;
}