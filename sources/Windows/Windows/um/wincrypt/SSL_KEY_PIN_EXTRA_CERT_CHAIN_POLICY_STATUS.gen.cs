// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SSL_KEY_PIN_EXTRA_CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="SSL_KEY_PIN_EXTRA_CERT_CHAIN_POLICY_STATUS"]/*'/>
public unsafe partial struct SSL_KEY_PIN_EXTRA_CERT_CHAIN_POLICY_STATUS
{
    /// <include file='SSL_KEY_PIN_EXTRA_CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="SSL_KEY_PIN_EXTRA_CERT_CHAIN_POLICY_STATUS.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='SSL_KEY_PIN_EXTRA_CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="SSL_KEY_PIN_EXTRA_CERT_CHAIN_POLICY_STATUS.lError"]/*'/>
    [NativeTypeName("LONG")]
    public int lError;
    /// <include file='SSL_KEY_PIN_EXTRA_CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="SSL_KEY_PIN_EXTRA_CERT_CHAIN_POLICY_STATUS.wszErrorText"]/*'/>
    [NativeTypeName("WCHAR[512]")]
    public fixed ushort wszErrorText[512];
}