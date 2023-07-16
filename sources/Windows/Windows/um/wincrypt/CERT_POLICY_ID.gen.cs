// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_POLICY_ID.xml' path='doc/member[@name="CERT_POLICY_ID"]/*'/>
public unsafe partial struct CERT_POLICY_ID
{
    /// <include file='CERT_POLICY_ID.xml' path='doc/member[@name="CERT_POLICY_ID.cCertPolicyElementId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cCertPolicyElementId;
    /// <include file='CERT_POLICY_ID.xml' path='doc/member[@name="CERT_POLICY_ID.rgpszCertPolicyElementId"]/*'/>
    [NativeTypeName("LPSTR *")]
    public sbyte** rgpszCertPolicyElementId;
}