// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EV_EXTRA_CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="EV_EXTRA_CERT_CHAIN_POLICY_STATUS"]/*'/>
public partial struct EV_EXTRA_CERT_CHAIN_POLICY_STATUS
{
    /// <include file='EV_EXTRA_CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="EV_EXTRA_CERT_CHAIN_POLICY_STATUS.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='EV_EXTRA_CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="EV_EXTRA_CERT_CHAIN_POLICY_STATUS.dwQualifiers"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwQualifiers;
    /// <include file='EV_EXTRA_CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="EV_EXTRA_CERT_CHAIN_POLICY_STATUS.dwIssuanceUsageIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwIssuanceUsageIndex;
}