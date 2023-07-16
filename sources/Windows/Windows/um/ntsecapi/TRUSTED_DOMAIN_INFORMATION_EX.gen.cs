// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TRUSTED_DOMAIN_INFORMATION_EX.xml' path='doc/member[@name="TRUSTED_DOMAIN_INFORMATION_EX"]/*'/>
public unsafe partial struct TRUSTED_DOMAIN_INFORMATION_EX
{
    /// <include file='TRUSTED_DOMAIN_INFORMATION_EX.xml' path='doc/member[@name="TRUSTED_DOMAIN_INFORMATION_EX.Name"]/*'/>
    public LSA_UNICODE_STRING Name;
    /// <include file='TRUSTED_DOMAIN_INFORMATION_EX.xml' path='doc/member[@name="TRUSTED_DOMAIN_INFORMATION_EX.FlatName"]/*'/>
    public LSA_UNICODE_STRING FlatName;
    /// <include file='TRUSTED_DOMAIN_INFORMATION_EX.xml' path='doc/member[@name="TRUSTED_DOMAIN_INFORMATION_EX.Sid"]/*'/>
    [NativeTypeName("PSID")]
    public void* Sid;
    /// <include file='TRUSTED_DOMAIN_INFORMATION_EX.xml' path='doc/member[@name="TRUSTED_DOMAIN_INFORMATION_EX.TrustDirection"]/*'/>
    [NativeTypeName("ULONG")]
    public uint TrustDirection;
    /// <include file='TRUSTED_DOMAIN_INFORMATION_EX.xml' path='doc/member[@name="TRUSTED_DOMAIN_INFORMATION_EX.TrustType"]/*'/>
    [NativeTypeName("ULONG")]
    public uint TrustType;
    /// <include file='TRUSTED_DOMAIN_INFORMATION_EX.xml' path='doc/member[@name="TRUSTED_DOMAIN_INFORMATION_EX.TrustAttributes"]/*'/>
    [NativeTypeName("ULONG")]
    public uint TrustAttributes;
}