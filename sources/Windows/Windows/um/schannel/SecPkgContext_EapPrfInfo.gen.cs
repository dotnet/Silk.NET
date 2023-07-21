// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SecPkgContext_EapPrfInfo.xml' path='doc/member[@name="SecPkgContext_EapPrfInfo"]/*' />
public unsafe partial struct SecPkgContext_EapPrfInfo
{
    /// <include file='SecPkgContext_EapPrfInfo.xml' path='doc/member[@name="SecPkgContext_EapPrfInfo.dwVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVersion;

    /// <include file='SecPkgContext_EapPrfInfo.xml' path='doc/member[@name="SecPkgContext_EapPrfInfo.cbPrfData"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbPrfData;

    /// <include file='SecPkgContext_EapPrfInfo.xml' path='doc/member[@name="SecPkgContext_EapPrfInfo.pbPrfData"]/*' />
    [NativeTypeName("PBYTE")]
    public byte* pbPrfData;
}
