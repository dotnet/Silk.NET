// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CERT_CREATE_CONTEXT_PARA.xml' path='doc/member[@name="CERT_CREATE_CONTEXT_PARA"]/*' />
public unsafe partial struct CERT_CREATE_CONTEXT_PARA
{
    /// <include file='CERT_CREATE_CONTEXT_PARA.xml' path='doc/member[@name="CERT_CREATE_CONTEXT_PARA.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CERT_CREATE_CONTEXT_PARA.xml' path='doc/member[@name="CERT_CREATE_CONTEXT_PARA.pfnFree"]/*' />
    [NativeTypeName("PFN_CRYPT_FREE")]
    public delegate* unmanaged<void*, void> pfnFree;

    /// <include file='CERT_CREATE_CONTEXT_PARA.xml' path='doc/member[@name="CERT_CREATE_CONTEXT_PARA.pvFree"]/*' />
    public void* pvFree;

    /// <include file='CERT_CREATE_CONTEXT_PARA.xml' path='doc/member[@name="CERT_CREATE_CONTEXT_PARA.pfnSort"]/*' />
    [NativeTypeName("PFN_CERT_CREATE_CONTEXT_SORT_FUNC")]
    public delegate* unmanaged<uint, uint, uint, void*, BOOL> pfnSort;

    /// <include file='CERT_CREATE_CONTEXT_PARA.xml' path='doc/member[@name="CERT_CREATE_CONTEXT_PARA.pvSort"]/*' />
    public void* pvSort;
}
