// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/LsaLookup.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='LSA_REFERENCED_DOMAIN_LIST.xml' path='doc/member[@name="LSA_REFERENCED_DOMAIN_LIST"]/*'/>
public unsafe partial struct LSA_REFERENCED_DOMAIN_LIST
{
    /// <include file='LSA_REFERENCED_DOMAIN_LIST.xml' path='doc/member[@name="LSA_REFERENCED_DOMAIN_LIST.Entries"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Entries;
    /// <include file='LSA_REFERENCED_DOMAIN_LIST.xml' path='doc/member[@name="LSA_REFERENCED_DOMAIN_LIST.Domains"]/*'/>
    [NativeTypeName("PLSA_TRUST_INFORMATION")]
    public LSA_TRUST_INFORMATION* Domains;
}