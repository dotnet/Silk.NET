// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX"]/*'/>
[SupportedOSPlatform("windows10.0")]
public partial struct NTFS_STATISTICS_EX
{
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.LogFileFullExceptions"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LogFileFullExceptions;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.OtherExceptions"]/*'/>
    [NativeTypeName("DWORD")]
    public uint OtherExceptions;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.MftReads"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong MftReads;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.MftReadBytes"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong MftReadBytes;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.MftWrites"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong MftWrites;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.MftWriteBytes"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong MftWriteBytes;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.MftWritesUserLevel"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L12088_C5")]
    public _MftWritesUserLevel_e__Struct MftWritesUserLevel;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.MftWritesFlushForLogFileFull"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MftWritesFlushForLogFileFull;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.MftWritesLazyWriter"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MftWritesLazyWriter;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.MftWritesUserRequest"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MftWritesUserRequest;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.Mft2Writes"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong Mft2Writes;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.Mft2WriteBytes"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong Mft2WriteBytes;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.Mft2WritesUserLevel"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L12101_C5")]
    public _Mft2WritesUserLevel_e__Struct Mft2WritesUserLevel;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.Mft2WritesFlushForLogFileFull"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Mft2WritesFlushForLogFileFull;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.Mft2WritesLazyWriter"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Mft2WritesLazyWriter;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.Mft2WritesUserRequest"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Mft2WritesUserRequest;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.RootIndexReads"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong RootIndexReads;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.RootIndexReadBytes"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong RootIndexReadBytes;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.RootIndexWrites"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong RootIndexWrites;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.RootIndexWriteBytes"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong RootIndexWriteBytes;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.BitmapReads"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong BitmapReads;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.BitmapReadBytes"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong BitmapReadBytes;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.BitmapWrites"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong BitmapWrites;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.BitmapWriteBytes"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong BitmapWriteBytes;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.BitmapWritesFlushForLogFileFull"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BitmapWritesFlushForLogFileFull;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.BitmapWritesLazyWriter"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BitmapWritesLazyWriter;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.BitmapWritesUserRequest"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BitmapWritesUserRequest;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.BitmapWritesUserLevel"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L12126_C5")]
    public _BitmapWritesUserLevel_e__Struct BitmapWritesUserLevel;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.MftBitmapReads"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong MftBitmapReads;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.MftBitmapReadBytes"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong MftBitmapReadBytes;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.MftBitmapWrites"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong MftBitmapWrites;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.MftBitmapWriteBytes"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong MftBitmapWriteBytes;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.MftBitmapWritesFlushForLogFileFull"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MftBitmapWritesFlushForLogFileFull;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.MftBitmapWritesLazyWriter"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MftBitmapWritesLazyWriter;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.MftBitmapWritesUserRequest"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MftBitmapWritesUserRequest;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.MftBitmapWritesUserLevel"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L12142_C5")]
    public _MftBitmapWritesUserLevel_e__Struct MftBitmapWritesUserLevel;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.UserIndexReads"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong UserIndexReads;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.UserIndexReadBytes"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong UserIndexReadBytes;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.UserIndexWrites"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong UserIndexWrites;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.UserIndexWriteBytes"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong UserIndexWriteBytes;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.LogFileReads"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong LogFileReads;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.LogFileReadBytes"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong LogFileReadBytes;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.LogFileWrites"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong LogFileWrites;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.LogFileWriteBytes"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong LogFileWriteBytes;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.Allocate"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L12163_C5")]
    public _Allocate_e__Struct Allocate;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.DiskResourcesExhausted"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DiskResourcesExhausted;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.VolumeTrimCount"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong VolumeTrimCount;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.VolumeTrimTime"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong VolumeTrimTime;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.VolumeTrimByteCount"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong VolumeTrimByteCount;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.FileLevelTrimCount"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong FileLevelTrimCount;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.FileLevelTrimTime"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong FileLevelTrimTime;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.FileLevelTrimByteCount"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong FileLevelTrimByteCount;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.VolumeTrimSkippedCount"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong VolumeTrimSkippedCount;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.VolumeTrimSkippedByteCount"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong VolumeTrimSkippedByteCount;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.NtfsFillStatInfoFromMftRecordCalledCount"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong NtfsFillStatInfoFromMftRecordCalledCount;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.NtfsFillStatInfoFromMftRecordBailedBecauseOfAttributeListCount"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong NtfsFillStatInfoFromMftRecordBailedBecauseOfAttributeListCount;
    /// <include file='NTFS_STATISTICS_EX.xml' path='doc/member[@name="NTFS_STATISTICS_EX.NtfsFillStatInfoFromMftRecordBailedBecauseOfNonResReparsePointCount"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong NtfsFillStatInfoFromMftRecordBailedBecauseOfNonResReparsePointCount;
    /// <include file='_MftWritesUserLevel_e__Struct.xml' path='doc/member[@name="_MftWritesUserLevel_e__Struct"]/*'/>
    public partial struct _MftWritesUserLevel_e__Struct
    {
        /// <include file='_MftWritesUserLevel_e__Struct.xml' path='doc/member[@name="_MftWritesUserLevel_e__Struct.Write"]/*'/>
        [NativeTypeName("DWORD")]
        public uint Write;
        /// <include file='_MftWritesUserLevel_e__Struct.xml' path='doc/member[@name="_MftWritesUserLevel_e__Struct.Create"]/*'/>
        [NativeTypeName("DWORD")]
        public uint Create;
        /// <include file='_MftWritesUserLevel_e__Struct.xml' path='doc/member[@name="_MftWritesUserLevel_e__Struct.SetInfo"]/*'/>
        [NativeTypeName("DWORD")]
        public uint SetInfo;
        /// <include file='_MftWritesUserLevel_e__Struct.xml' path='doc/member[@name="_MftWritesUserLevel_e__Struct.Flush"]/*'/>
        [NativeTypeName("DWORD")]
        public uint Flush;
    }

    /// <include file='_Mft2WritesUserLevel_e__Struct.xml' path='doc/member[@name="_Mft2WritesUserLevel_e__Struct"]/*'/>
    public partial struct _Mft2WritesUserLevel_e__Struct
    {
        /// <include file='_Mft2WritesUserLevel_e__Struct.xml' path='doc/member[@name="_Mft2WritesUserLevel_e__Struct.Write"]/*'/>
        [NativeTypeName("DWORD")]
        public uint Write;
        /// <include file='_Mft2WritesUserLevel_e__Struct.xml' path='doc/member[@name="_Mft2WritesUserLevel_e__Struct.Create"]/*'/>
        [NativeTypeName("DWORD")]
        public uint Create;
        /// <include file='_Mft2WritesUserLevel_e__Struct.xml' path='doc/member[@name="_Mft2WritesUserLevel_e__Struct.SetInfo"]/*'/>
        [NativeTypeName("DWORD")]
        public uint SetInfo;
        /// <include file='_Mft2WritesUserLevel_e__Struct.xml' path='doc/member[@name="_Mft2WritesUserLevel_e__Struct.Flush"]/*'/>
        [NativeTypeName("DWORD")]
        public uint Flush;
    }

    /// <include file='_BitmapWritesUserLevel_e__Struct.xml' path='doc/member[@name="_BitmapWritesUserLevel_e__Struct"]/*'/>
    public partial struct _BitmapWritesUserLevel_e__Struct
    {
        /// <include file='_BitmapWritesUserLevel_e__Struct.xml' path='doc/member[@name="_BitmapWritesUserLevel_e__Struct.Write"]/*'/>
        [NativeTypeName("DWORD")]
        public uint Write;
        /// <include file='_BitmapWritesUserLevel_e__Struct.xml' path='doc/member[@name="_BitmapWritesUserLevel_e__Struct.Create"]/*'/>
        [NativeTypeName("DWORD")]
        public uint Create;
        /// <include file='_BitmapWritesUserLevel_e__Struct.xml' path='doc/member[@name="_BitmapWritesUserLevel_e__Struct.SetInfo"]/*'/>
        [NativeTypeName("DWORD")]
        public uint SetInfo;
        /// <include file='_BitmapWritesUserLevel_e__Struct.xml' path='doc/member[@name="_BitmapWritesUserLevel_e__Struct.Flush"]/*'/>
        [NativeTypeName("DWORD")]
        public uint Flush;
    }

    /// <include file='_MftBitmapWritesUserLevel_e__Struct.xml' path='doc/member[@name="_MftBitmapWritesUserLevel_e__Struct"]/*'/>
    public partial struct _MftBitmapWritesUserLevel_e__Struct
    {
        /// <include file='_MftBitmapWritesUserLevel_e__Struct.xml' path='doc/member[@name="_MftBitmapWritesUserLevel_e__Struct.Write"]/*'/>
        [NativeTypeName("DWORD")]
        public uint Write;
        /// <include file='_MftBitmapWritesUserLevel_e__Struct.xml' path='doc/member[@name="_MftBitmapWritesUserLevel_e__Struct.Create"]/*'/>
        [NativeTypeName("DWORD")]
        public uint Create;
        /// <include file='_MftBitmapWritesUserLevel_e__Struct.xml' path='doc/member[@name="_MftBitmapWritesUserLevel_e__Struct.SetInfo"]/*'/>
        [NativeTypeName("DWORD")]
        public uint SetInfo;
        /// <include file='_MftBitmapWritesUserLevel_e__Struct.xml' path='doc/member[@name="_MftBitmapWritesUserLevel_e__Struct.Flush"]/*'/>
        [NativeTypeName("DWORD")]
        public uint Flush;
    }

    /// <include file='_Allocate_e__Struct.xml' path='doc/member[@name="_Allocate_e__Struct"]/*'/>
    public partial struct _Allocate_e__Struct
    {
        /// <include file='_Allocate_e__Struct.xml' path='doc/member[@name="_Allocate_e__Struct.Calls"]/*'/>
        [NativeTypeName("DWORD")]
        public uint Calls;
        /// <include file='_Allocate_e__Struct.xml' path='doc/member[@name="_Allocate_e__Struct.RunsReturned"]/*'/>
        [NativeTypeName("DWORD")]
        public uint RunsReturned;
        /// <include file='_Allocate_e__Struct.xml' path='doc/member[@name="_Allocate_e__Struct.Hints"]/*'/>
        [NativeTypeName("DWORD")]
        public uint Hints;
        /// <include file='_Allocate_e__Struct.xml' path='doc/member[@name="_Allocate_e__Struct.HintsHonored"]/*'/>
        [NativeTypeName("DWORD")]
        public uint HintsHonored;
        /// <include file='_Allocate_e__Struct.xml' path='doc/member[@name="_Allocate_e__Struct.Cache"]/*'/>
        [NativeTypeName("DWORD")]
        public uint Cache;
        /// <include file='_Allocate_e__Struct.xml' path='doc/member[@name="_Allocate_e__Struct.CacheMiss"]/*'/>
        [NativeTypeName("DWORD")]
        public uint CacheMiss;
        /// <include file='_Allocate_e__Struct.xml' path='doc/member[@name="_Allocate_e__Struct.Clusters"]/*'/>
        [NativeTypeName("DWORDLONG")]
        public ulong Clusters;
        /// <include file='_Allocate_e__Struct.xml' path='doc/member[@name="_Allocate_e__Struct.HintsClusters"]/*'/>
        [NativeTypeName("DWORDLONG")]
        public ulong HintsClusters;
        /// <include file='_Allocate_e__Struct.xml' path='doc/member[@name="_Allocate_e__Struct.CacheClusters"]/*'/>
        [NativeTypeName("DWORDLONG")]
        public ulong CacheClusters;
        /// <include file='_Allocate_e__Struct.xml' path='doc/member[@name="_Allocate_e__Struct.CacheMissClusters"]/*'/>
        [NativeTypeName("DWORDLONG")]
        public ulong CacheMissClusters;
    }
}