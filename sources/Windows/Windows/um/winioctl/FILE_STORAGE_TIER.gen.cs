// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='FILE_STORAGE_TIER.xml' path='doc/member[@name="FILE_STORAGE_TIER"]/*'/>
public unsafe partial struct FILE_STORAGE_TIER
{
    /// <include file='FILE_STORAGE_TIER.xml' path='doc/member[@name="FILE_STORAGE_TIER.Id"]/*'/>
    public Guid Id;
    /// <include file='FILE_STORAGE_TIER.xml' path='doc/member[@name="FILE_STORAGE_TIER.Name"]/*'/>
    [NativeTypeName("WCHAR[256]")]
    public fixed ushort Name[256];
    /// <include file='FILE_STORAGE_TIER.xml' path='doc/member[@name="FILE_STORAGE_TIER.Description"]/*'/>
    [NativeTypeName("WCHAR[256]")]
    public fixed ushort Description[256];
    /// <include file='FILE_STORAGE_TIER.xml' path='doc/member[@name="FILE_STORAGE_TIER.Flags"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong Flags;
    /// <include file='FILE_STORAGE_TIER.xml' path='doc/member[@name="FILE_STORAGE_TIER.ProvisionedCapacity"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong ProvisionedCapacity;
    /// <include file='FILE_STORAGE_TIER.xml' path='doc/member[@name="FILE_STORAGE_TIER.MediaType"]/*'/>
    public FILE_STORAGE_TIER_MEDIA_TYPE MediaType;
    /// <include file='FILE_STORAGE_TIER.xml' path='doc/member[@name="FILE_STORAGE_TIER.Class"]/*'/>
    public FILE_STORAGE_TIER_CLASS Class;
}