// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct FILESYSTEM_STATISTICS
{
    [NativeTypeName("WORD")]
    public ushort FileSystemType;

    [NativeTypeName("WORD")]
    public ushort Version;

    [NativeTypeName("DWORD")]
    public uint SizeOfCompleteStructure;

    [NativeTypeName("DWORD")]
    public uint UserFileReads;

    [NativeTypeName("DWORD")]
    public uint UserFileReadBytes;

    [NativeTypeName("DWORD")]
    public uint UserDiskReads;

    [NativeTypeName("DWORD")]
    public uint UserFileWrites;

    [NativeTypeName("DWORD")]
    public uint UserFileWriteBytes;

    [NativeTypeName("DWORD")]
    public uint UserDiskWrites;

    [NativeTypeName("DWORD")]
    public uint MetaDataReads;

    [NativeTypeName("DWORD")]
    public uint MetaDataReadBytes;

    [NativeTypeName("DWORD")]
    public uint MetaDataDiskReads;

    [NativeTypeName("DWORD")]
    public uint MetaDataWrites;

    [NativeTypeName("DWORD")]
    public uint MetaDataWriteBytes;

    [NativeTypeName("DWORD")]
    public uint MetaDataDiskWrites;
}
