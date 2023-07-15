// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='KERB_S4U2PROXY_CRED.xml' path='doc/member[@name="KERB_S4U2PROXY_CRED"]/*'/>
public unsafe partial struct KERB_S4U2PROXY_CRED
{
    /// <include file='KERB_S4U2PROXY_CRED.xml' path='doc/member[@name="KERB_S4U2PROXY_CRED.UserName"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING UserName;
    /// <include file='KERB_S4U2PROXY_CRED.xml' path='doc/member[@name="KERB_S4U2PROXY_CRED.DomainName"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING DomainName;
    /// <include file='KERB_S4U2PROXY_CRED.xml' path='doc/member[@name="KERB_S4U2PROXY_CRED.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
    /// <include file='KERB_S4U2PROXY_CRED.xml' path='doc/member[@name="KERB_S4U2PROXY_CRED.LastStatus"]/*'/>
    [NativeTypeName("NTSTATUS")]
    public int LastStatus;
    /// <include file='KERB_S4U2PROXY_CRED.xml' path='doc/member[@name="KERB_S4U2PROXY_CRED.Expiry"]/*'/>
    public LARGE_INTEGER Expiry;
    /// <include file='KERB_S4U2PROXY_CRED.xml' path='doc/member[@name="KERB_S4U2PROXY_CRED.CountOfEntries"]/*'/>
    [NativeTypeName("ULONG")]
    public uint CountOfEntries;
    /// <include file='KERB_S4U2PROXY_CRED.xml' path='doc/member[@name="KERB_S4U2PROXY_CRED.Entries"]/*'/>
    [NativeTypeName("PKERB_S4U2PROXY_CACHE_ENTRY_INFO")]
    public KERB_S4U2PROXY_CACHE_ENTRY_INFO* Entries;
}