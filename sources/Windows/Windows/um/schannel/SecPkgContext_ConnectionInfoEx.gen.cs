// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SecPkgContext_ConnectionInfoEx.xml' path='doc/member[@name="SecPkgContext_ConnectionInfoEx"]/*' />
public unsafe partial struct SecPkgContext_ConnectionInfoEx
{
    /// <include file='SecPkgContext_ConnectionInfoEx.xml' path='doc/member[@name="SecPkgContext_ConnectionInfoEx.dwVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVersion;

    /// <include file='SecPkgContext_ConnectionInfoEx.xml' path='doc/member[@name="SecPkgContext_ConnectionInfoEx.dwProtocol"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwProtocol;

    /// <include file='SecPkgContext_ConnectionInfoEx.xml' path='doc/member[@name="SecPkgContext_ConnectionInfoEx.szCipher"]/*' />
    [NativeTypeName("WCHAR[64]")]
    public fixed ushort szCipher[64];

    /// <include file='SecPkgContext_ConnectionInfoEx.xml' path='doc/member[@name="SecPkgContext_ConnectionInfoEx.dwCipherStrength"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCipherStrength;

    /// <include file='SecPkgContext_ConnectionInfoEx.xml' path='doc/member[@name="SecPkgContext_ConnectionInfoEx.szHash"]/*' />
    [NativeTypeName("WCHAR[64]")]
    public fixed ushort szHash[64];

    /// <include file='SecPkgContext_ConnectionInfoEx.xml' path='doc/member[@name="SecPkgContext_ConnectionInfoEx.dwHashStrength"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwHashStrength;

    /// <include file='SecPkgContext_ConnectionInfoEx.xml' path='doc/member[@name="SecPkgContext_ConnectionInfoEx.szExchange"]/*' />
    [NativeTypeName("WCHAR[64]")]
    public fixed ushort szExchange[64];

    /// <include file='SecPkgContext_ConnectionInfoEx.xml' path='doc/member[@name="SecPkgContext_ConnectionInfoEx.dwExchStrength"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwExchStrength;
}
