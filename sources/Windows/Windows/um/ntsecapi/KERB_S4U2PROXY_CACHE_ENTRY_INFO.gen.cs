// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='KERB_S4U2PROXY_CACHE_ENTRY_INFO.xml' path='doc/member[@name="KERB_S4U2PROXY_CACHE_ENTRY_INFO"]/*'/>
public partial struct KERB_S4U2PROXY_CACHE_ENTRY_INFO
{
    /// <include file='KERB_S4U2PROXY_CACHE_ENTRY_INFO.xml' path='doc/member[@name="KERB_S4U2PROXY_CACHE_ENTRY_INFO.ServerName"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING ServerName;
    /// <include file='KERB_S4U2PROXY_CACHE_ENTRY_INFO.xml' path='doc/member[@name="KERB_S4U2PROXY_CACHE_ENTRY_INFO.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
    /// <include file='KERB_S4U2PROXY_CACHE_ENTRY_INFO.xml' path='doc/member[@name="KERB_S4U2PROXY_CACHE_ENTRY_INFO.LastStatus"]/*'/>
    [NativeTypeName("NTSTATUS")]
    public int LastStatus;
    /// <include file='KERB_S4U2PROXY_CACHE_ENTRY_INFO.xml' path='doc/member[@name="KERB_S4U2PROXY_CACHE_ENTRY_INFO.Expiry"]/*'/>
    public LARGE_INTEGER Expiry;
}