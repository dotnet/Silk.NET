// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.xml' path='doc/member[@name="FILE_QUERY_ON_DISK_VOL_INFO_BUFFER"]/*' />
public unsafe partial struct FILE_QUERY_ON_DISK_VOL_INFO_BUFFER
{
    /// <include file='FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.xml' path='doc/member[@name="FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.DirectoryCount"]/*' />
    public LARGE_INTEGER DirectoryCount;

    /// <include file='FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.xml' path='doc/member[@name="FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.FileCount"]/*' />
    public LARGE_INTEGER FileCount;

    /// <include file='FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.xml' path='doc/member[@name="FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.FsFormatMajVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort FsFormatMajVersion;

    /// <include file='FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.xml' path='doc/member[@name="FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.FsFormatMinVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort FsFormatMinVersion;

    /// <include file='FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.xml' path='doc/member[@name="FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.FsFormatName"]/*' />
    [NativeTypeName("WCHAR[12]")]
    public fixed ushort FsFormatName[12];

    /// <include file='FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.xml' path='doc/member[@name="FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.FormatTime"]/*' />
    public LARGE_INTEGER FormatTime;

    /// <include file='FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.xml' path='doc/member[@name="FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.LastUpdateTime"]/*' />
    public LARGE_INTEGER LastUpdateTime;

    /// <include file='FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.xml' path='doc/member[@name="FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.CopyrightInfo"]/*' />
    [NativeTypeName("WCHAR[34]")]
    public fixed ushort CopyrightInfo[34];

    /// <include file='FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.xml' path='doc/member[@name="FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.AbstractInfo"]/*' />
    [NativeTypeName("WCHAR[34]")]
    public fixed ushort AbstractInfo[34];

    /// <include file='FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.xml' path='doc/member[@name="FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.FormattingImplementationInfo"]/*' />
    [NativeTypeName("WCHAR[34]")]
    public fixed ushort FormattingImplementationInfo[34];

    /// <include file='FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.xml' path='doc/member[@name="FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.LastModifyingImplementationInfo"]/*' />
    [NativeTypeName("WCHAR[34]")]
    public fixed ushort LastModifyingImplementationInfo[34];
}
