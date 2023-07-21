// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='AUTHENTICODE_EXTRA_CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="AUTHENTICODE_EXTRA_CERT_CHAIN_POLICY_STATUS"]/*' />
public partial struct AUTHENTICODE_EXTRA_CERT_CHAIN_POLICY_STATUS
{
    /// <include file='AUTHENTICODE_EXTRA_CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="AUTHENTICODE_EXTRA_CERT_CHAIN_POLICY_STATUS.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='AUTHENTICODE_EXTRA_CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="AUTHENTICODE_EXTRA_CERT_CHAIN_POLICY_STATUS.fCommercial"]/*' />
    public BOOL fCommercial;
}
