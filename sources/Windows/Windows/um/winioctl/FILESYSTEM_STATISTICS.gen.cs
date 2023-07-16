// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FILESYSTEM_STATISTICS.xml' path='doc/member[@name="FILESYSTEM_STATISTICS"]/*'/>
public partial struct FILESYSTEM_STATISTICS
{
    /// <include file='FILESYSTEM_STATISTICS.xml' path='doc/member[@name="FILESYSTEM_STATISTICS.FileSystemType"]/*'/>
    [NativeTypeName("WORD")]
    public ushort FileSystemType;
    /// <include file='FILESYSTEM_STATISTICS.xml' path='doc/member[@name="FILESYSTEM_STATISTICS.Version"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Version;
    /// <include file='FILESYSTEM_STATISTICS.xml' path='doc/member[@name="FILESYSTEM_STATISTICS.SizeOfCompleteStructure"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeOfCompleteStructure;
    /// <include file='FILESYSTEM_STATISTICS.xml' path='doc/member[@name="FILESYSTEM_STATISTICS.UserFileReads"]/*'/>
    [NativeTypeName("DWORD")]
    public uint UserFileReads;
    /// <include file='FILESYSTEM_STATISTICS.xml' path='doc/member[@name="FILESYSTEM_STATISTICS.UserFileReadBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint UserFileReadBytes;
    /// <include file='FILESYSTEM_STATISTICS.xml' path='doc/member[@name="FILESYSTEM_STATISTICS.UserDiskReads"]/*'/>
    [NativeTypeName("DWORD")]
    public uint UserDiskReads;
    /// <include file='FILESYSTEM_STATISTICS.xml' path='doc/member[@name="FILESYSTEM_STATISTICS.UserFileWrites"]/*'/>
    [NativeTypeName("DWORD")]
    public uint UserFileWrites;
    /// <include file='FILESYSTEM_STATISTICS.xml' path='doc/member[@name="FILESYSTEM_STATISTICS.UserFileWriteBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint UserFileWriteBytes;
    /// <include file='FILESYSTEM_STATISTICS.xml' path='doc/member[@name="FILESYSTEM_STATISTICS.UserDiskWrites"]/*'/>
    [NativeTypeName("DWORD")]
    public uint UserDiskWrites;
    /// <include file='FILESYSTEM_STATISTICS.xml' path='doc/member[@name="FILESYSTEM_STATISTICS.MetaDataReads"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MetaDataReads;
    /// <include file='FILESYSTEM_STATISTICS.xml' path='doc/member[@name="FILESYSTEM_STATISTICS.MetaDataReadBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MetaDataReadBytes;
    /// <include file='FILESYSTEM_STATISTICS.xml' path='doc/member[@name="FILESYSTEM_STATISTICS.MetaDataDiskReads"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MetaDataDiskReads;
    /// <include file='FILESYSTEM_STATISTICS.xml' path='doc/member[@name="FILESYSTEM_STATISTICS.MetaDataWrites"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MetaDataWrites;
    /// <include file='FILESYSTEM_STATISTICS.xml' path='doc/member[@name="FILESYSTEM_STATISTICS.MetaDataWriteBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MetaDataWriteBytes;
    /// <include file='FILESYSTEM_STATISTICS.xml' path='doc/member[@name="FILESYSTEM_STATISTICS.MetaDataDiskWrites"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MetaDataDiskWrites;
}