// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='SCM_REGION.xml' path='doc/member[@name="SCM_REGION"]/*'/>
public partial struct SCM_REGION
{
    /// <include file='SCM_REGION.xml' path='doc/member[@name="SCM_REGION.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='SCM_REGION.xml' path='doc/member[@name="SCM_REGION.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='SCM_REGION.xml' path='doc/member[@name="SCM_REGION.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='SCM_REGION.xml' path='doc/member[@name="SCM_REGION.NfitHandle"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NfitHandle;
    /// <include file='SCM_REGION.xml' path='doc/member[@name="SCM_REGION.LogicalDeviceGuid"]/*'/>
    public Guid LogicalDeviceGuid;
    /// <include file='SCM_REGION.xml' path='doc/member[@name="SCM_REGION.AddressRangeType"]/*'/>
    public Guid AddressRangeType;
    /// <include file='SCM_REGION.xml' path='doc/member[@name="SCM_REGION.AssociatedId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint AssociatedId;
    /// <include file='SCM_REGION.xml' path='doc/member[@name="SCM_REGION.Length"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong Length;
    /// <include file='SCM_REGION.xml' path='doc/member[@name="SCM_REGION.StartingDPA"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong StartingDPA;
    /// <include file='SCM_REGION.xml' path='doc/member[@name="SCM_REGION.BaseSPA"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong BaseSPA;
    /// <include file='SCM_REGION.xml' path='doc/member[@name="SCM_REGION.SPAOffset"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong SPAOffset;
    /// <include file='SCM_REGION.xml' path='doc/member[@name="SCM_REGION.RegionOffset"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong RegionOffset;
}