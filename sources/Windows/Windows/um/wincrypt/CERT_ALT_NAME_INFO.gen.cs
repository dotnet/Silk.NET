// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_ALT_NAME_INFO.xml' path='doc/member[@name="CERT_ALT_NAME_INFO"]/*'/>
public unsafe partial struct CERT_ALT_NAME_INFO
{
    /// <include file='CERT_ALT_NAME_INFO.xml' path='doc/member[@name="CERT_ALT_NAME_INFO.cAltEntry"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cAltEntry;
    /// <include file='CERT_ALT_NAME_INFO.xml' path='doc/member[@name="CERT_ALT_NAME_INFO.rgAltEntry"]/*'/>
    [NativeTypeName("PCERT_ALT_NAME_ENTRY")]
    public CERT_ALT_NAME_ENTRY* rgAltEntry;
}