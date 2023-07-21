// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CERT_TRUST_LIST_INFO.xml' path='doc/member[@name="CERT_TRUST_LIST_INFO"]/*' />
public unsafe partial struct CERT_TRUST_LIST_INFO
{
    /// <include file='CERT_TRUST_LIST_INFO.xml' path='doc/member[@name="CERT_TRUST_LIST_INFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CERT_TRUST_LIST_INFO.xml' path='doc/member[@name="CERT_TRUST_LIST_INFO.pCtlEntry"]/*' />
    [NativeTypeName("PCTL_ENTRY")]
    public CTL_ENTRY* pCtlEntry;

    /// <include file='CERT_TRUST_LIST_INFO.xml' path='doc/member[@name="CERT_TRUST_LIST_INFO.pCtlContext"]/*' />
    [NativeTypeName("PCCTL_CONTEXT")]
    public CTL_CONTEXT* pCtlContext;
}
