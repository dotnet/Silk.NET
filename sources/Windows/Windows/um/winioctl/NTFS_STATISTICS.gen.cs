// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS"]/*'/>
public partial struct NTFS_STATISTICS
{
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.LogFileFullExceptions"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LogFileFullExceptions;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.OtherExceptions"]/*'/>
    [NativeTypeName("DWORD")]
    public uint OtherExceptions;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.MftReads"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MftReads;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.MftReadBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MftReadBytes;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.MftWrites"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MftWrites;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.MftWriteBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MftWriteBytes;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.MftWritesUserLevel"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L11947_C5")]
    public _MftWritesUserLevel_e__Struct MftWritesUserLevel;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.MftWritesFlushForLogFileFull"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MftWritesFlushForLogFileFull;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.MftWritesLazyWriter"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MftWritesLazyWriter;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.MftWritesUserRequest"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MftWritesUserRequest;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.Mft2Writes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Mft2Writes;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.Mft2WriteBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Mft2WriteBytes;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.Mft2WritesUserLevel"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L11960_C5")]
    public _Mft2WritesUserLevel_e__Struct Mft2WritesUserLevel;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.Mft2WritesFlushForLogFileFull"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Mft2WritesFlushForLogFileFull;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.Mft2WritesLazyWriter"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Mft2WritesLazyWriter;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.Mft2WritesUserRequest"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Mft2WritesUserRequest;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.RootIndexReads"]/*'/>
    [NativeTypeName("DWORD")]
    public uint RootIndexReads;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.RootIndexReadBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint RootIndexReadBytes;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.RootIndexWrites"]/*'/>
    [NativeTypeName("DWORD")]
    public uint RootIndexWrites;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.RootIndexWriteBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint RootIndexWriteBytes;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.BitmapReads"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BitmapReads;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.BitmapReadBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BitmapReadBytes;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.BitmapWrites"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BitmapWrites;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.BitmapWriteBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BitmapWriteBytes;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.BitmapWritesFlushForLogFileFull"]/*'/>
    [NativeTypeName("WORD")]
    public ushort BitmapWritesFlushForLogFileFull;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.BitmapWritesLazyWriter"]/*'/>
    [NativeTypeName("WORD")]
    public ushort BitmapWritesLazyWriter;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.BitmapWritesUserRequest"]/*'/>
    [NativeTypeName("WORD")]
    public ushort BitmapWritesUserRequest;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.BitmapWritesUserLevel"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L11985_C5")]
    public _BitmapWritesUserLevel_e__Struct BitmapWritesUserLevel;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.MftBitmapReads"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MftBitmapReads;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.MftBitmapReadBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MftBitmapReadBytes;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.MftBitmapWrites"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MftBitmapWrites;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.MftBitmapWriteBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MftBitmapWriteBytes;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.MftBitmapWritesFlushForLogFileFull"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MftBitmapWritesFlushForLogFileFull;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.MftBitmapWritesLazyWriter"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MftBitmapWritesLazyWriter;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.MftBitmapWritesUserRequest"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MftBitmapWritesUserRequest;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.MftBitmapWritesUserLevel"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L12000_C5")]
    public _MftBitmapWritesUserLevel_e__Struct MftBitmapWritesUserLevel;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.UserIndexReads"]/*'/>
    [NativeTypeName("DWORD")]
    public uint UserIndexReads;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.UserIndexReadBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint UserIndexReadBytes;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.UserIndexWrites"]/*'/>
    [NativeTypeName("DWORD")]
    public uint UserIndexWrites;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.UserIndexWriteBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint UserIndexWriteBytes;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.LogFileReads"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LogFileReads;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.LogFileReadBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LogFileReadBytes;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.LogFileWrites"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LogFileWrites;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.LogFileWriteBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LogFileWriteBytes;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.Allocate"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L12021_C5")]
    public _Allocate_e__Struct Allocate;
    /// <include file='NTFS_STATISTICS.xml' path='doc/member[@name="NTFS_STATISTICS.DiskResourcesExhausted"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DiskResourcesExhausted;
    /// <include file='_MftWritesUserLevel_e__Struct.xml' path='doc/member[@name="_MftWritesUserLevel_e__Struct"]/*'/>
    public partial struct _MftWritesUserLevel_e__Struct
    {
        /// <include file='_MftWritesUserLevel_e__Struct.xml' path='doc/member[@name="_MftWritesUserLevel_e__Struct.Write"]/*'/>
        [NativeTypeName("WORD")]
        public ushort Write;
        /// <include file='_MftWritesUserLevel_e__Struct.xml' path='doc/member[@name="_MftWritesUserLevel_e__Struct.Create"]/*'/>
        [NativeTypeName("WORD")]
        public ushort Create;
        /// <include file='_MftWritesUserLevel_e__Struct.xml' path='doc/member[@name="_MftWritesUserLevel_e__Struct.SetInfo"]/*'/>
        [NativeTypeName("WORD")]
        public ushort SetInfo;
        /// <include file='_MftWritesUserLevel_e__Struct.xml' path='doc/member[@name="_MftWritesUserLevel_e__Struct.Flush"]/*'/>
        [NativeTypeName("WORD")]
        public ushort Flush;
    }

    /// <include file='_Mft2WritesUserLevel_e__Struct.xml' path='doc/member[@name="_Mft2WritesUserLevel_e__Struct"]/*'/>
    public partial struct _Mft2WritesUserLevel_e__Struct
    {
        /// <include file='_Mft2WritesUserLevel_e__Struct.xml' path='doc/member[@name="_Mft2WritesUserLevel_e__Struct.Write"]/*'/>
        [NativeTypeName("WORD")]
        public ushort Write;
        /// <include file='_Mft2WritesUserLevel_e__Struct.xml' path='doc/member[@name="_Mft2WritesUserLevel_e__Struct.Create"]/*'/>
        [NativeTypeName("WORD")]
        public ushort Create;
        /// <include file='_Mft2WritesUserLevel_e__Struct.xml' path='doc/member[@name="_Mft2WritesUserLevel_e__Struct.SetInfo"]/*'/>
        [NativeTypeName("WORD")]
        public ushort SetInfo;
        /// <include file='_Mft2WritesUserLevel_e__Struct.xml' path='doc/member[@name="_Mft2WritesUserLevel_e__Struct.Flush"]/*'/>
        [NativeTypeName("WORD")]
        public ushort Flush;
    }

    /// <include file='_BitmapWritesUserLevel_e__Struct.xml' path='doc/member[@name="_BitmapWritesUserLevel_e__Struct"]/*'/>
    public partial struct _BitmapWritesUserLevel_e__Struct
    {
        /// <include file='_BitmapWritesUserLevel_e__Struct.xml' path='doc/member[@name="_BitmapWritesUserLevel_e__Struct.Write"]/*'/>
        [NativeTypeName("WORD")]
        public ushort Write;
        /// <include file='_BitmapWritesUserLevel_e__Struct.xml' path='doc/member[@name="_BitmapWritesUserLevel_e__Struct.Create"]/*'/>
        [NativeTypeName("WORD")]
        public ushort Create;
        /// <include file='_BitmapWritesUserLevel_e__Struct.xml' path='doc/member[@name="_BitmapWritesUserLevel_e__Struct.SetInfo"]/*'/>
        [NativeTypeName("WORD")]
        public ushort SetInfo;
    }

    /// <include file='_MftBitmapWritesUserLevel_e__Struct.xml' path='doc/member[@name="_MftBitmapWritesUserLevel_e__Struct"]/*'/>
    public partial struct _MftBitmapWritesUserLevel_e__Struct
    {
        /// <include file='_MftBitmapWritesUserLevel_e__Struct.xml' path='doc/member[@name="_MftBitmapWritesUserLevel_e__Struct.Write"]/*'/>
        [NativeTypeName("WORD")]
        public ushort Write;
        /// <include file='_MftBitmapWritesUserLevel_e__Struct.xml' path='doc/member[@name="_MftBitmapWritesUserLevel_e__Struct.Create"]/*'/>
        [NativeTypeName("WORD")]
        public ushort Create;
        /// <include file='_MftBitmapWritesUserLevel_e__Struct.xml' path='doc/member[@name="_MftBitmapWritesUserLevel_e__Struct.SetInfo"]/*'/>
        [NativeTypeName("WORD")]
        public ushort SetInfo;
        /// <include file='_MftBitmapWritesUserLevel_e__Struct.xml' path='doc/member[@name="_MftBitmapWritesUserLevel_e__Struct.Flush"]/*'/>
        [NativeTypeName("WORD")]
        public ushort Flush;
    }

    /// <include file='_Allocate_e__Struct.xml' path='doc/member[@name="_Allocate_e__Struct"]/*'/>
    public partial struct _Allocate_e__Struct
    {
        /// <include file='_Allocate_e__Struct.xml' path='doc/member[@name="_Allocate_e__Struct.Calls"]/*'/>
        [NativeTypeName("DWORD")]
        public uint Calls;
        /// <include file='_Allocate_e__Struct.xml' path='doc/member[@name="_Allocate_e__Struct.Clusters"]/*'/>
        [NativeTypeName("DWORD")]
        public uint Clusters;
        /// <include file='_Allocate_e__Struct.xml' path='doc/member[@name="_Allocate_e__Struct.Hints"]/*'/>
        [NativeTypeName("DWORD")]
        public uint Hints;
        /// <include file='_Allocate_e__Struct.xml' path='doc/member[@name="_Allocate_e__Struct.RunsReturned"]/*'/>
        [NativeTypeName("DWORD")]
        public uint RunsReturned;
        /// <include file='_Allocate_e__Struct.xml' path='doc/member[@name="_Allocate_e__Struct.HintsHonored"]/*'/>
        [NativeTypeName("DWORD")]
        public uint HintsHonored;
        /// <include file='_Allocate_e__Struct.xml' path='doc/member[@name="_Allocate_e__Struct.HintsClusters"]/*'/>
        [NativeTypeName("DWORD")]
        public uint HintsClusters;
        /// <include file='_Allocate_e__Struct.xml' path='doc/member[@name="_Allocate_e__Struct.Cache"]/*'/>
        [NativeTypeName("DWORD")]
        public uint Cache;
        /// <include file='_Allocate_e__Struct.xml' path='doc/member[@name="_Allocate_e__Struct.CacheClusters"]/*'/>
        [NativeTypeName("DWORD")]
        public uint CacheClusters;
        /// <include file='_Allocate_e__Struct.xml' path='doc/member[@name="_Allocate_e__Struct.CacheMiss"]/*'/>
        [NativeTypeName("DWORD")]
        public uint CacheMiss;
        /// <include file='_Allocate_e__Struct.xml' path='doc/member[@name="_Allocate_e__Struct.CacheMissClusters"]/*'/>
        [NativeTypeName("DWORD")]
        public uint CacheMissClusters;
    }
}