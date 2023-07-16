// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY"]/*'/>
public partial struct STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY
{
    /// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.EntryLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint EntryLength;
    /// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.DependencyTypeFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DependencyTypeFlags;
    /// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.ProviderSpecificFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ProviderSpecificFlags;
    /// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.VirtualStorageType"]/*'/>
    public VIRTUAL_STORAGE_TYPE VirtualStorageType;
    /// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.AncestorLevel"]/*'/>
    [NativeTypeName("DWORD")]
    public uint AncestorLevel;
    /// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.HostVolumeNameOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint HostVolumeNameOffset;
    /// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.HostVolumeNameSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint HostVolumeNameSize;
    /// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.DependentVolumeNameOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DependentVolumeNameOffset;
    /// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.DependentVolumeNameSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DependentVolumeNameSize;
    /// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.RelativePathOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint RelativePathOffset;
    /// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.RelativePathSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint RelativePathSize;
    /// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.DependentDeviceNameOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DependentDeviceNameOffset;
    /// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_LEV2_ENTRY.DependentDeviceNameSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DependentDeviceNameSize;
}