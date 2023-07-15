// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='KERB_QUERY_DOMAIN_EXTENDED_POLICIES_RESPONSE.xml' path='doc/member[@name="KERB_QUERY_DOMAIN_EXTENDED_POLICIES_RESPONSE"]/*'/>
public partial struct KERB_QUERY_DOMAIN_EXTENDED_POLICIES_RESPONSE
{
    /// <include file='KERB_QUERY_DOMAIN_EXTENDED_POLICIES_RESPONSE.xml' path='doc/member[@name="KERB_QUERY_DOMAIN_EXTENDED_POLICIES_RESPONSE.MessageType"]/*'/>
    public KERB_PROTOCOL_MESSAGE_TYPE MessageType;
    /// <include file='KERB_QUERY_DOMAIN_EXTENDED_POLICIES_RESPONSE.xml' path='doc/member[@name="KERB_QUERY_DOMAIN_EXTENDED_POLICIES_RESPONSE.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
    /// <include file='KERB_QUERY_DOMAIN_EXTENDED_POLICIES_RESPONSE.xml' path='doc/member[@name="KERB_QUERY_DOMAIN_EXTENDED_POLICIES_RESPONSE.ExtendedPolicies"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ExtendedPolicies;
    /// <include file='KERB_QUERY_DOMAIN_EXTENDED_POLICIES_RESPONSE.xml' path='doc/member[@name="KERB_QUERY_DOMAIN_EXTENDED_POLICIES_RESPONSE.DsFlags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint DsFlags;
}