// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='LSA_FOREST_TRUST_SCANNER_INFO.xml' path='doc/member[@name="LSA_FOREST_TRUST_SCANNER_INFO"]/*'/>
public unsafe partial struct LSA_FOREST_TRUST_SCANNER_INFO
{
    /// <include file='LSA_FOREST_TRUST_SCANNER_INFO.xml' path='doc/member[@name="LSA_FOREST_TRUST_SCANNER_INFO.DomainSid"]/*'/>
    [NativeTypeName("PSID")]
    public void* DomainSid;
    /// <include file='LSA_FOREST_TRUST_SCANNER_INFO.xml' path='doc/member[@name="LSA_FOREST_TRUST_SCANNER_INFO.DnsName"]/*'/>
    public LSA_UNICODE_STRING DnsName;
    /// <include file='LSA_FOREST_TRUST_SCANNER_INFO.xml' path='doc/member[@name="LSA_FOREST_TRUST_SCANNER_INFO.NetbiosName"]/*'/>
    public LSA_UNICODE_STRING NetbiosName;
}