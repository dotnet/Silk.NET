// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='FILE_STORAGE_INFO.xml' path='doc/member[@name="FILE_STORAGE_INFO"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct FILE_STORAGE_INFO
{
    /// <include file='FILE_STORAGE_INFO.xml' path='doc/member[@name="FILE_STORAGE_INFO.LogicalBytesPerSector"]/*'/>
    [NativeTypeName("ULONG")]
    public uint LogicalBytesPerSector;
    /// <include file='FILE_STORAGE_INFO.xml' path='doc/member[@name="FILE_STORAGE_INFO.PhysicalBytesPerSectorForAtomicity"]/*'/>
    [NativeTypeName("ULONG")]
    public uint PhysicalBytesPerSectorForAtomicity;
    /// <include file='FILE_STORAGE_INFO.xml' path='doc/member[@name="FILE_STORAGE_INFO.PhysicalBytesPerSectorForPerformance"]/*'/>
    [NativeTypeName("ULONG")]
    public uint PhysicalBytesPerSectorForPerformance;
    /// <include file='FILE_STORAGE_INFO.xml' path='doc/member[@name="FILE_STORAGE_INFO.FileSystemEffectivePhysicalBytesPerSectorForAtomicity"]/*'/>
    [NativeTypeName("ULONG")]
    public uint FileSystemEffectivePhysicalBytesPerSectorForAtomicity;
    /// <include file='FILE_STORAGE_INFO.xml' path='doc/member[@name="FILE_STORAGE_INFO.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
    /// <include file='FILE_STORAGE_INFO.xml' path='doc/member[@name="FILE_STORAGE_INFO.ByteOffsetForSectorAlignment"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ByteOffsetForSectorAlignment;
    /// <include file='FILE_STORAGE_INFO.xml' path='doc/member[@name="FILE_STORAGE_INFO.ByteOffsetForPartitionAlignment"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ByteOffsetForPartitionAlignment;
}