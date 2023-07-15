// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="CERT_CHAIN_POLICY_STATUS"]/*'/>
public unsafe partial struct CERT_CHAIN_POLICY_STATUS
{
    /// <include file='CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="CERT_CHAIN_POLICY_STATUS.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="CERT_CHAIN_POLICY_STATUS.dwError"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwError;
    /// <include file='CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="CERT_CHAIN_POLICY_STATUS.lChainIndex"]/*'/>
    [NativeTypeName("LONG")]
    public int lChainIndex;
    /// <include file='CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="CERT_CHAIN_POLICY_STATUS.lElementIndex"]/*'/>
    [NativeTypeName("LONG")]
    public int lElementIndex;
    /// <include file='CERT_CHAIN_POLICY_STATUS.xml' path='doc/member[@name="CERT_CHAIN_POLICY_STATUS.pvExtraPolicyStatus"]/*'/>
    public void* pvExtraPolicyStatus;
}