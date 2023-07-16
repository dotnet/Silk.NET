// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_ZONE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ZONE_DESCRIPTOR"]/*'/>
public unsafe partial struct STORAGE_ZONE_DESCRIPTOR
{
    /// <include file='STORAGE_ZONE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ZONE_DESCRIPTOR.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_ZONE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ZONE_DESCRIPTOR.ZoneType"]/*'/>
    public STORAGE_ZONE_TYPES ZoneType;
    /// <include file='STORAGE_ZONE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ZONE_DESCRIPTOR.ZoneCondition"]/*'/>
    public STORAGE_ZONE_CONDITION ZoneCondition;
    /// <include file='STORAGE_ZONE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ZONE_DESCRIPTOR.ResetWritePointerRecommend"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte ResetWritePointerRecommend;
    /// <include file='STORAGE_ZONE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ZONE_DESCRIPTOR.Reserved0"]/*'/>
    [NativeTypeName("BYTE[3]")]
    public fixed byte Reserved0[3];
    /// <include file='STORAGE_ZONE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ZONE_DESCRIPTOR.ZoneSize"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong ZoneSize;
    /// <include file='STORAGE_ZONE_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ZONE_DESCRIPTOR.WritePointerOffset"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong WritePointerOffset;
}