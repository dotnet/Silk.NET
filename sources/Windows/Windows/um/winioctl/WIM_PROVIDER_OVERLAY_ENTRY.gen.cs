// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='WIM_PROVIDER_OVERLAY_ENTRY.xml' path='doc/member[@name="WIM_PROVIDER_OVERLAY_ENTRY"]/*'/>
public partial struct WIM_PROVIDER_OVERLAY_ENTRY
{
    /// <include file='WIM_PROVIDER_OVERLAY_ENTRY.xml' path='doc/member[@name="WIM_PROVIDER_OVERLAY_ENTRY.NextEntryOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NextEntryOffset;
    /// <include file='WIM_PROVIDER_OVERLAY_ENTRY.xml' path='doc/member[@name="WIM_PROVIDER_OVERLAY_ENTRY.DataSourceId"]/*'/>
    public LARGE_INTEGER DataSourceId;
    /// <include file='WIM_PROVIDER_OVERLAY_ENTRY.xml' path='doc/member[@name="WIM_PROVIDER_OVERLAY_ENTRY.WimGuid"]/*'/>
    public Guid WimGuid;
    /// <include file='WIM_PROVIDER_OVERLAY_ENTRY.xml' path='doc/member[@name="WIM_PROVIDER_OVERLAY_ENTRY.WimFileNameOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint WimFileNameOffset;
    /// <include file='WIM_PROVIDER_OVERLAY_ENTRY.xml' path='doc/member[@name="WIM_PROVIDER_OVERLAY_ENTRY.WimType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint WimType;
    /// <include file='WIM_PROVIDER_OVERLAY_ENTRY.xml' path='doc/member[@name="WIM_PROVIDER_OVERLAY_ENTRY.WimIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint WimIndex;
    /// <include file='WIM_PROVIDER_OVERLAY_ENTRY.xml' path='doc/member[@name="WIM_PROVIDER_OVERLAY_ENTRY.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
}