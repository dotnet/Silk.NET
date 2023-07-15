// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_LEV1_ENTRY.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_LEV1_ENTRY"]/*'/>
public partial struct STORAGE_QUERY_DEPENDENT_VOLUME_LEV1_ENTRY
{
    /// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_LEV1_ENTRY.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_LEV1_ENTRY.EntryLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint EntryLength;
    /// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_LEV1_ENTRY.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_LEV1_ENTRY.DependencyTypeFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DependencyTypeFlags;
    /// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_LEV1_ENTRY.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_LEV1_ENTRY.ProviderSpecificFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ProviderSpecificFlags;
    /// <include file='STORAGE_QUERY_DEPENDENT_VOLUME_LEV1_ENTRY.xml' path='doc/member[@name="STORAGE_QUERY_DEPENDENT_VOLUME_LEV1_ENTRY.VirtualStorageType"]/*'/>
    public VIRTUAL_STORAGE_TYPE VirtualStorageType;
}