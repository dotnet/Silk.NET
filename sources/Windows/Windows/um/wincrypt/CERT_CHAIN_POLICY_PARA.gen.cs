// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_CHAIN_POLICY_PARA.xml' path='doc/member[@name="CERT_CHAIN_POLICY_PARA"]/*'/>
public unsafe partial struct CERT_CHAIN_POLICY_PARA
{
    /// <include file='CERT_CHAIN_POLICY_PARA.xml' path='doc/member[@name="CERT_CHAIN_POLICY_PARA.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CERT_CHAIN_POLICY_PARA.xml' path='doc/member[@name="CERT_CHAIN_POLICY_PARA.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='CERT_CHAIN_POLICY_PARA.xml' path='doc/member[@name="CERT_CHAIN_POLICY_PARA.pvExtraPolicyPara"]/*'/>
    public void* pvExtraPolicyPara;
}