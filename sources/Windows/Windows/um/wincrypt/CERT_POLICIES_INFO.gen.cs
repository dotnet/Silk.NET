// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_POLICIES_INFO.xml' path='doc/member[@name="CERT_POLICIES_INFO"]/*'/>
public unsafe partial struct CERT_POLICIES_INFO
{
    /// <include file='CERT_POLICIES_INFO.xml' path='doc/member[@name="CERT_POLICIES_INFO.cPolicyInfo"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cPolicyInfo;
    /// <include file='CERT_POLICIES_INFO.xml' path='doc/member[@name="CERT_POLICIES_INFO.rgPolicyInfo"]/*'/>
    public CERT_POLICY_INFO* rgPolicyInfo;
}