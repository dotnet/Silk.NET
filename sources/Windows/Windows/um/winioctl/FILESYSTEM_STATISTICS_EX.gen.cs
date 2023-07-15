// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='FILESYSTEM_STATISTICS_EX.xml' path='doc/member[@name="FILESYSTEM_STATISTICS_EX"]/*'/>
[SupportedOSPlatform("windows10.0")]
public partial struct FILESYSTEM_STATISTICS_EX
{
    /// <include file='FILESYSTEM_STATISTICS_EX.xml' path='doc/member[@name="FILESYSTEM_STATISTICS_EX.FileSystemType"]/*'/>
    [NativeTypeName("WORD")]
    public ushort FileSystemType;
    /// <include file='FILESYSTEM_STATISTICS_EX.xml' path='doc/member[@name="FILESYSTEM_STATISTICS_EX.Version"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Version;
    /// <include file='FILESYSTEM_STATISTICS_EX.xml' path='doc/member[@name="FILESYSTEM_STATISTICS_EX.SizeOfCompleteStructure"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeOfCompleteStructure;
    /// <include file='FILESYSTEM_STATISTICS_EX.xml' path='doc/member[@name="FILESYSTEM_STATISTICS_EX.UserFileReads"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong UserFileReads;
    /// <include file='FILESYSTEM_STATISTICS_EX.xml' path='doc/member[@name="FILESYSTEM_STATISTICS_EX.UserFileReadBytes"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong UserFileReadBytes;
    /// <include file='FILESYSTEM_STATISTICS_EX.xml' path='doc/member[@name="FILESYSTEM_STATISTICS_EX.UserDiskReads"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong UserDiskReads;
    /// <include file='FILESYSTEM_STATISTICS_EX.xml' path='doc/member[@name="FILESYSTEM_STATISTICS_EX.UserFileWrites"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong UserFileWrites;
    /// <include file='FILESYSTEM_STATISTICS_EX.xml' path='doc/member[@name="FILESYSTEM_STATISTICS_EX.UserFileWriteBytes"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong UserFileWriteBytes;
    /// <include file='FILESYSTEM_STATISTICS_EX.xml' path='doc/member[@name="FILESYSTEM_STATISTICS_EX.UserDiskWrites"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong UserDiskWrites;
    /// <include file='FILESYSTEM_STATISTICS_EX.xml' path='doc/member[@name="FILESYSTEM_STATISTICS_EX.MetaDataReads"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong MetaDataReads;
    /// <include file='FILESYSTEM_STATISTICS_EX.xml' path='doc/member[@name="FILESYSTEM_STATISTICS_EX.MetaDataReadBytes"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong MetaDataReadBytes;
    /// <include file='FILESYSTEM_STATISTICS_EX.xml' path='doc/member[@name="FILESYSTEM_STATISTICS_EX.MetaDataDiskReads"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong MetaDataDiskReads;
    /// <include file='FILESYSTEM_STATISTICS_EX.xml' path='doc/member[@name="FILESYSTEM_STATISTICS_EX.MetaDataWrites"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong MetaDataWrites;
    /// <include file='FILESYSTEM_STATISTICS_EX.xml' path='doc/member[@name="FILESYSTEM_STATISTICS_EX.MetaDataWriteBytes"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong MetaDataWriteBytes;
    /// <include file='FILESYSTEM_STATISTICS_EX.xml' path='doc/member[@name="FILESYSTEM_STATISTICS_EX.MetaDataDiskWrites"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong MetaDataDiskWrites;
}