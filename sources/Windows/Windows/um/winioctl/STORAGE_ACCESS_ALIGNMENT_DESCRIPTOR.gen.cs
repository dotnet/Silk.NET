// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_ACCESS_ALIGNMENT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ACCESS_ALIGNMENT_DESCRIPTOR"]/*'/>
public partial struct STORAGE_ACCESS_ALIGNMENT_DESCRIPTOR
{
    /// <include file='STORAGE_ACCESS_ALIGNMENT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ACCESS_ALIGNMENT_DESCRIPTOR.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_ACCESS_ALIGNMENT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ACCESS_ALIGNMENT_DESCRIPTOR.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_ACCESS_ALIGNMENT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ACCESS_ALIGNMENT_DESCRIPTOR.BytesPerCacheLine"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BytesPerCacheLine;
    /// <include file='STORAGE_ACCESS_ALIGNMENT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ACCESS_ALIGNMENT_DESCRIPTOR.BytesOffsetForCacheAlignment"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BytesOffsetForCacheAlignment;
    /// <include file='STORAGE_ACCESS_ALIGNMENT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ACCESS_ALIGNMENT_DESCRIPTOR.BytesPerLogicalSector"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BytesPerLogicalSector;
    /// <include file='STORAGE_ACCESS_ALIGNMENT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ACCESS_ALIGNMENT_DESCRIPTOR.BytesPerPhysicalSector"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BytesPerPhysicalSector;
    /// <include file='STORAGE_ACCESS_ALIGNMENT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_ACCESS_ALIGNMENT_DESCRIPTOR.BytesOffsetForSectorAlignment"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BytesOffsetForSectorAlignment;
}