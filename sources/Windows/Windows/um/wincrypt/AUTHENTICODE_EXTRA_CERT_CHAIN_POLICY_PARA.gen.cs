// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='AUTHENTICODE_EXTRA_CERT_CHAIN_POLICY_PARA.xml' path='doc/member[@name="AUTHENTICODE_EXTRA_CERT_CHAIN_POLICY_PARA"]/*'/>
public unsafe partial struct AUTHENTICODE_EXTRA_CERT_CHAIN_POLICY_PARA
{
    /// <include file='AUTHENTICODE_EXTRA_CERT_CHAIN_POLICY_PARA.xml' path='doc/member[@name="AUTHENTICODE_EXTRA_CERT_CHAIN_POLICY_PARA.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='AUTHENTICODE_EXTRA_CERT_CHAIN_POLICY_PARA.xml' path='doc/member[@name="AUTHENTICODE_EXTRA_CERT_CHAIN_POLICY_PARA.dwRegPolicySettings"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRegPolicySettings;
    /// <include file='AUTHENTICODE_EXTRA_CERT_CHAIN_POLICY_PARA.xml' path='doc/member[@name="AUTHENTICODE_EXTRA_CERT_CHAIN_POLICY_PARA.pSignerInfo"]/*'/>
    [NativeTypeName("PCMSG_SIGNER_INFO")]
    public CMSG_SIGNER_INFO* pSignerInfo;
}