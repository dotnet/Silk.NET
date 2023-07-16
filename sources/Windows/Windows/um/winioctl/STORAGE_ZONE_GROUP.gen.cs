// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_ZONE_GROUP.xml' path='doc/member[@name="STORAGE_ZONE_GROUP"]/*'/>
public partial struct STORAGE_ZONE_GROUP
{
    /// <include file='STORAGE_ZONE_GROUP.xml' path='doc/member[@name="STORAGE_ZONE_GROUP.ZoneCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ZoneCount;
    /// <include file='STORAGE_ZONE_GROUP.xml' path='doc/member[@name="STORAGE_ZONE_GROUP.ZoneType"]/*'/>
    public STORAGE_ZONE_TYPES ZoneType;
    /// <include file='STORAGE_ZONE_GROUP.xml' path='doc/member[@name="STORAGE_ZONE_GROUP.ZoneSize"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong ZoneSize;
}