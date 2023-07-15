// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='KERB_BINDING_CACHE_ENTRY_DATA.xml' path='doc/member[@name="KERB_BINDING_CACHE_ENTRY_DATA"]/*'/>
public partial struct KERB_BINDING_CACHE_ENTRY_DATA
{
    /// <include file='KERB_BINDING_CACHE_ENTRY_DATA.xml' path='doc/member[@name="KERB_BINDING_CACHE_ENTRY_DATA.DiscoveryTime"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong DiscoveryTime;
    /// <include file='KERB_BINDING_CACHE_ENTRY_DATA.xml' path='doc/member[@name="KERB_BINDING_CACHE_ENTRY_DATA.RealmName"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING RealmName;
    /// <include file='KERB_BINDING_CACHE_ENTRY_DATA.xml' path='doc/member[@name="KERB_BINDING_CACHE_ENTRY_DATA.KdcAddress"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING KdcAddress;
    /// <include file='KERB_BINDING_CACHE_ENTRY_DATA.xml' path='doc/member[@name="KERB_BINDING_CACHE_ENTRY_DATA.AddressType"]/*'/>
    [NativeTypeName("ULONG")]
    public uint AddressType;
    /// <include file='KERB_BINDING_CACHE_ENTRY_DATA.xml' path='doc/member[@name="KERB_BINDING_CACHE_ENTRY_DATA.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
    /// <include file='KERB_BINDING_CACHE_ENTRY_DATA.xml' path='doc/member[@name="KERB_BINDING_CACHE_ENTRY_DATA.DcFlags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint DcFlags;
    /// <include file='KERB_BINDING_CACHE_ENTRY_DATA.xml' path='doc/member[@name="KERB_BINDING_CACHE_ENTRY_DATA.CacheFlags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint CacheFlags;
    /// <include file='KERB_BINDING_CACHE_ENTRY_DATA.xml' path='doc/member[@name="KERB_BINDING_CACHE_ENTRY_DATA.KdcName"]/*'/>
    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING KdcName;
}