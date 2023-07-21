// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='OCSP_REQUEST_INFO.xml' path='doc/member[@name="OCSP_REQUEST_INFO"]/*' />
public unsafe partial struct OCSP_REQUEST_INFO
{
    /// <include file='OCSP_REQUEST_INFO.xml' path='doc/member[@name="OCSP_REQUEST_INFO.dwVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVersion;

    /// <include file='OCSP_REQUEST_INFO.xml' path='doc/member[@name="OCSP_REQUEST_INFO.pRequestorName"]/*' />
    [NativeTypeName("PCERT_ALT_NAME_ENTRY")]
    public CERT_ALT_NAME_ENTRY* pRequestorName;

    /// <include file='OCSP_REQUEST_INFO.xml' path='doc/member[@name="OCSP_REQUEST_INFO.cRequestEntry"]/*' />
    [NativeTypeName("DWORD")]
    public uint cRequestEntry;

    /// <include file='OCSP_REQUEST_INFO.xml' path='doc/member[@name="OCSP_REQUEST_INFO.rgRequestEntry"]/*' />
    [NativeTypeName("POCSP_REQUEST_ENTRY")]
    public OCSP_REQUEST_ENTRY* rgRequestEntry;

    /// <include file='OCSP_REQUEST_INFO.xml' path='doc/member[@name="OCSP_REQUEST_INFO.cExtension"]/*' />
    [NativeTypeName("DWORD")]
    public uint cExtension;

    /// <include file='OCSP_REQUEST_INFO.xml' path='doc/member[@name="OCSP_REQUEST_INFO.rgExtension"]/*' />
    [NativeTypeName("PCERT_EXTENSION")]
    public CERT_EXTENSION* rgExtension;
}
