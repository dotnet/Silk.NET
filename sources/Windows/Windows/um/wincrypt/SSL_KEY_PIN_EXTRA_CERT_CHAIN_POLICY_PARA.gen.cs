// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SSL_KEY_PIN_EXTRA_CERT_CHAIN_POLICY_PARA.xml' path='doc/member[@name="SSL_KEY_PIN_EXTRA_CERT_CHAIN_POLICY_PARA"]/*' />
public unsafe partial struct SSL_KEY_PIN_EXTRA_CERT_CHAIN_POLICY_PARA
{
    /// <include file='SSL_KEY_PIN_EXTRA_CERT_CHAIN_POLICY_PARA.xml' path='doc/member[@name="SSL_KEY_PIN_EXTRA_CERT_CHAIN_POLICY_PARA.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SSL_KEY_PIN_EXTRA_CERT_CHAIN_POLICY_PARA.xml' path='doc/member[@name="SSL_KEY_PIN_EXTRA_CERT_CHAIN_POLICY_PARA.dwReserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved;

    /// <include file='SSL_KEY_PIN_EXTRA_CERT_CHAIN_POLICY_PARA.xml' path='doc/member[@name="SSL_KEY_PIN_EXTRA_CERT_CHAIN_POLICY_PARA.pwszServerName"]/*' />
    [NativeTypeName("PCWSTR")]
    public ushort* pwszServerName;
}
