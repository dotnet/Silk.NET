// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='SSL_F12_EXTRA_CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="SSL_F12_EXTRA_CERT_CHAIN_POLICY_STATUS"]/*' />
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct SSL_F12_EXTRA_CERT_CHAIN_POLICY_STATUS
{
    /// <include file='SSL_F12_EXTRA_CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="SSL_F12_EXTRA_CERT_CHAIN_POLICY_STATUS.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SSL_F12_EXTRA_CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="SSL_F12_EXTRA_CERT_CHAIN_POLICY_STATUS.dwErrorLevel"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwErrorLevel;

    /// <include file='SSL_F12_EXTRA_CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="SSL_F12_EXTRA_CERT_CHAIN_POLICY_STATUS.dwErrorCategory"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwErrorCategory;

    /// <include file='SSL_F12_EXTRA_CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="SSL_F12_EXTRA_CERT_CHAIN_POLICY_STATUS.dwReserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved;

    /// <include file='SSL_F12_EXTRA_CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="SSL_F12_EXTRA_CERT_CHAIN_POLICY_STATUS.wszErrorText"]/*' />
    [NativeTypeName("WCHAR[256]")]
    public fixed ushort wszErrorText[256];
}
