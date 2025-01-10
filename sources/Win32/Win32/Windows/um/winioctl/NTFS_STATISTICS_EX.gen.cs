// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0")]
public partial struct NTFS_STATISTICS_EX
{
    [NativeTypeName("DWORD")]
    public uint LogFileFullExceptions;

    [NativeTypeName("DWORD")]
    public uint OtherExceptions;

    [NativeTypeName("DWORDLONG")]
    public ulong MftReads;

    [NativeTypeName("DWORDLONG")]
    public ulong MftReadBytes;

    [NativeTypeName("DWORDLONG")]
    public ulong MftWrites;

    [NativeTypeName("DWORDLONG")]
    public ulong MftWriteBytes;

    [NativeTypeName("__AnonymousRecord_winioctl_L12391_C5")]
    public _MftWritesUserLevel_e__Struct MftWritesUserLevel;

    [NativeTypeName("DWORD")]
    public uint MftWritesFlushForLogFileFull;

    [NativeTypeName("DWORD")]
    public uint MftWritesLazyWriter;

    [NativeTypeName("DWORD")]
    public uint MftWritesUserRequest;

    [NativeTypeName("DWORDLONG")]
    public ulong Mft2Writes;

    [NativeTypeName("DWORDLONG")]
    public ulong Mft2WriteBytes;

    [NativeTypeName("__AnonymousRecord_winioctl_L12404_C5")]
    public _Mft2WritesUserLevel_e__Struct Mft2WritesUserLevel;

    [NativeTypeName("DWORD")]
    public uint Mft2WritesFlushForLogFileFull;

    [NativeTypeName("DWORD")]
    public uint Mft2WritesLazyWriter;

    [NativeTypeName("DWORD")]
    public uint Mft2WritesUserRequest;

    [NativeTypeName("DWORDLONG")]
    public ulong RootIndexReads;

    [NativeTypeName("DWORDLONG")]
    public ulong RootIndexReadBytes;

    [NativeTypeName("DWORDLONG")]
    public ulong RootIndexWrites;

    [NativeTypeName("DWORDLONG")]
    public ulong RootIndexWriteBytes;

    [NativeTypeName("DWORDLONG")]
    public ulong BitmapReads;

    [NativeTypeName("DWORDLONG")]
    public ulong BitmapReadBytes;

    [NativeTypeName("DWORDLONG")]
    public ulong BitmapWrites;

    [NativeTypeName("DWORDLONG")]
    public ulong BitmapWriteBytes;

    [NativeTypeName("DWORD")]
    public uint BitmapWritesFlushForLogFileFull;

    [NativeTypeName("DWORD")]
    public uint BitmapWritesLazyWriter;

    [NativeTypeName("DWORD")]
    public uint BitmapWritesUserRequest;

    [NativeTypeName("__AnonymousRecord_winioctl_L12429_C5")]
    public _BitmapWritesUserLevel_e__Struct BitmapWritesUserLevel;

    [NativeTypeName("DWORDLONG")]
    public ulong MftBitmapReads;

    [NativeTypeName("DWORDLONG")]
    public ulong MftBitmapReadBytes;

    [NativeTypeName("DWORDLONG")]
    public ulong MftBitmapWrites;

    [NativeTypeName("DWORDLONG")]
    public ulong MftBitmapWriteBytes;

    [NativeTypeName("DWORD")]
    public uint MftBitmapWritesFlushForLogFileFull;

    [NativeTypeName("DWORD")]
    public uint MftBitmapWritesLazyWriter;

    [NativeTypeName("DWORD")]
    public uint MftBitmapWritesUserRequest;

    [NativeTypeName("__AnonymousRecord_winioctl_L12445_C5")]
    public _MftBitmapWritesUserLevel_e__Struct MftBitmapWritesUserLevel;

    [NativeTypeName("DWORDLONG")]
    public ulong UserIndexReads;

    [NativeTypeName("DWORDLONG")]
    public ulong UserIndexReadBytes;

    [NativeTypeName("DWORDLONG")]
    public ulong UserIndexWrites;

    [NativeTypeName("DWORDLONG")]
    public ulong UserIndexWriteBytes;

    [NativeTypeName("DWORDLONG")]
    public ulong LogFileReads;

    [NativeTypeName("DWORDLONG")]
    public ulong LogFileReadBytes;

    [NativeTypeName("DWORDLONG")]
    public ulong LogFileWrites;

    [NativeTypeName("DWORDLONG")]
    public ulong LogFileWriteBytes;

    [NativeTypeName("__AnonymousRecord_winioctl_L12466_C5")]
    public _Allocate_e__Struct Allocate;

    [NativeTypeName("DWORD")]
    public uint DiskResourcesExhausted;

    [NativeTypeName("DWORDLONG")]
    public ulong VolumeTrimCount;

    [NativeTypeName("DWORDLONG")]
    public ulong VolumeTrimTime;

    [NativeTypeName("DWORDLONG")]
    public ulong VolumeTrimByteCount;

    [NativeTypeName("DWORDLONG")]
    public ulong FileLevelTrimCount;

    [NativeTypeName("DWORDLONG")]
    public ulong FileLevelTrimTime;

    [NativeTypeName("DWORDLONG")]
    public ulong FileLevelTrimByteCount;

    [NativeTypeName("DWORDLONG")]
    public ulong VolumeTrimSkippedCount;

    [NativeTypeName("DWORDLONG")]
    public ulong VolumeTrimSkippedByteCount;

    [NativeTypeName("DWORDLONG")]
    public ulong NtfsFillStatInfoFromMftRecordCalledCount;

    [NativeTypeName("DWORDLONG")]
    public ulong NtfsFillStatInfoFromMftRecordBailedBecauseOfAttributeListCount;

    [NativeTypeName("DWORDLONG")]
    public ulong NtfsFillStatInfoFromMftRecordBailedBecauseOfNonResReparsePointCount;

    public partial struct _MftWritesUserLevel_e__Struct
    {
        [NativeTypeName("DWORD")]
        public uint Write;

        [NativeTypeName("DWORD")]
        public uint Create;

        [NativeTypeName("DWORD")]
        public uint SetInfo;

        [NativeTypeName("DWORD")]
        public uint Flush;
    }

    public partial struct _Mft2WritesUserLevel_e__Struct
    {
        [NativeTypeName("DWORD")]
        public uint Write;

        [NativeTypeName("DWORD")]
        public uint Create;

        [NativeTypeName("DWORD")]
        public uint SetInfo;

        [NativeTypeName("DWORD")]
        public uint Flush;
    }

    public partial struct _BitmapWritesUserLevel_e__Struct
    {
        [NativeTypeName("DWORD")]
        public uint Write;

        [NativeTypeName("DWORD")]
        public uint Create;

        [NativeTypeName("DWORD")]
        public uint SetInfo;

        [NativeTypeName("DWORD")]
        public uint Flush;
    }

    public partial struct _MftBitmapWritesUserLevel_e__Struct
    {
        [NativeTypeName("DWORD")]
        public uint Write;

        [NativeTypeName("DWORD")]
        public uint Create;

        [NativeTypeName("DWORD")]
        public uint SetInfo;

        [NativeTypeName("DWORD")]
        public uint Flush;
    }

    public partial struct _Allocate_e__Struct
    {
        [NativeTypeName("DWORD")]
        public uint Calls;

        [NativeTypeName("DWORD")]
        public uint RunsReturned;

        [NativeTypeName("DWORD")]
        public uint Hints;

        [NativeTypeName("DWORD")]
        public uint HintsHonored;

        [NativeTypeName("DWORD")]
        public uint Cache;

        [NativeTypeName("DWORD")]
        public uint CacheMiss;

        [NativeTypeName("DWORDLONG")]
        public ulong Clusters;

        [NativeTypeName("DWORDLONG")]
        public ulong HintsClusters;

        [NativeTypeName("DWORDLONG")]
        public ulong CacheClusters;

        [NativeTypeName("DWORDLONG")]
        public ulong CacheMissClusters;
    }
}
