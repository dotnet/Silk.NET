// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='STORAGE_TIER.xml' path='doc/member[@name="STORAGE_TIER"]/*'/>
public unsafe partial struct STORAGE_TIER
{
    /// <include file='STORAGE_TIER.xml' path='doc/member[@name="STORAGE_TIER.Id"]/*'/>
    public Guid Id;
    /// <include file='STORAGE_TIER.xml' path='doc/member[@name="STORAGE_TIER.Name"]/*'/>
    [NativeTypeName("WCHAR[256]")]
    public fixed ushort Name[256];
    /// <include file='STORAGE_TIER.xml' path='doc/member[@name="STORAGE_TIER.Description"]/*'/>
    [NativeTypeName("WCHAR[256]")]
    public fixed ushort Description[256];
    /// <include file='STORAGE_TIER.xml' path='doc/member[@name="STORAGE_TIER.Flags"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong Flags;
    /// <include file='STORAGE_TIER.xml' path='doc/member[@name="STORAGE_TIER.ProvisionedCapacity"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong ProvisionedCapacity;
    /// <include file='STORAGE_TIER.xml' path='doc/member[@name="STORAGE_TIER.MediaType"]/*'/>
    public STORAGE_TIER_MEDIA_TYPE MediaType;
    /// <include file='STORAGE_TIER.xml' path='doc/member[@name="STORAGE_TIER.Class"]/*'/>
    public STORAGE_TIER_CLASS Class;
}