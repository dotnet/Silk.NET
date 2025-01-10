// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0")]
public partial struct FILESYSTEM_STATISTICS_EX
{
    [NativeTypeName("WORD")]
    public ushort FileSystemType;

    [NativeTypeName("WORD")]
    public ushort Version;

    [NativeTypeName("DWORD")]
    public uint SizeOfCompleteStructure;

    [NativeTypeName("DWORDLONG")]
    public ulong UserFileReads;

    [NativeTypeName("DWORDLONG")]
    public ulong UserFileReadBytes;

    [NativeTypeName("DWORDLONG")]
    public ulong UserDiskReads;

    [NativeTypeName("DWORDLONG")]
    public ulong UserFileWrites;

    [NativeTypeName("DWORDLONG")]
    public ulong UserFileWriteBytes;

    [NativeTypeName("DWORDLONG")]
    public ulong UserDiskWrites;

    [NativeTypeName("DWORDLONG")]
    public ulong MetaDataReads;

    [NativeTypeName("DWORDLONG")]
    public ulong MetaDataReadBytes;

    [NativeTypeName("DWORDLONG")]
    public ulong MetaDataDiskReads;

    [NativeTypeName("DWORDLONG")]
    public ulong MetaDataWrites;

    [NativeTypeName("DWORDLONG")]
    public ulong MetaDataWriteBytes;

    [NativeTypeName("DWORDLONG")]
    public ulong MetaDataDiskWrites;
}
