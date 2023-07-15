// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TRUSTED_DOMAIN_INFORMATION_EX2.xml' path='doc/member[@name="TRUSTED_DOMAIN_INFORMATION_EX2"]/*'/>
public unsafe partial struct TRUSTED_DOMAIN_INFORMATION_EX2
{
    /// <include file='TRUSTED_DOMAIN_INFORMATION_EX2.xml' path='doc/member[@name="TRUSTED_DOMAIN_INFORMATION_EX2.Name"]/*'/>
    public LSA_UNICODE_STRING Name;
    /// <include file='TRUSTED_DOMAIN_INFORMATION_EX2.xml' path='doc/member[@name="TRUSTED_DOMAIN_INFORMATION_EX2.FlatName"]/*'/>
    public LSA_UNICODE_STRING FlatName;
    /// <include file='TRUSTED_DOMAIN_INFORMATION_EX2.xml' path='doc/member[@name="TRUSTED_DOMAIN_INFORMATION_EX2.Sid"]/*'/>
    [NativeTypeName("PSID")]
    public void* Sid;
    /// <include file='TRUSTED_DOMAIN_INFORMATION_EX2.xml' path='doc/member[@name="TRUSTED_DOMAIN_INFORMATION_EX2.TrustDirection"]/*'/>
    [NativeTypeName("ULONG")]
    public uint TrustDirection;
    /// <include file='TRUSTED_DOMAIN_INFORMATION_EX2.xml' path='doc/member[@name="TRUSTED_DOMAIN_INFORMATION_EX2.TrustType"]/*'/>
    [NativeTypeName("ULONG")]
    public uint TrustType;
    /// <include file='TRUSTED_DOMAIN_INFORMATION_EX2.xml' path='doc/member[@name="TRUSTED_DOMAIN_INFORMATION_EX2.TrustAttributes"]/*'/>
    [NativeTypeName("ULONG")]
    public uint TrustAttributes;
    /// <include file='TRUSTED_DOMAIN_INFORMATION_EX2.xml' path='doc/member[@name="TRUSTED_DOMAIN_INFORMATION_EX2.ForestTrustLength"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ForestTrustLength;
    /// <include file='TRUSTED_DOMAIN_INFORMATION_EX2.xml' path='doc/member[@name="TRUSTED_DOMAIN_INFORMATION_EX2.ForestTrustInfo"]/*'/>
    [NativeTypeName("PUCHAR")]
    public byte* ForestTrustInfo;
}