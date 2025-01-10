// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct FILE_STAT_LX_INFORMATION
{
    public LARGE_INTEGER FileId;
    public LARGE_INTEGER CreationTime;
    public LARGE_INTEGER LastAccessTime;
    public LARGE_INTEGER LastWriteTime;
    public LARGE_INTEGER ChangeTime;
    public LARGE_INTEGER AllocationSize;
    public LARGE_INTEGER EndOfFile;

    [NativeTypeName("DWORD")]
    public uint FileAttributes;

    [NativeTypeName("DWORD")]
    public uint ReparseTag;

    [NativeTypeName("DWORD")]
    public uint NumberOfLinks;

    [NativeTypeName("ACCESS_MASK")]
    public uint EffectiveAccess;

    [NativeTypeName("DWORD")]
    public uint LxFlags;

    [NativeTypeName("DWORD")]
    public uint LxUid;

    [NativeTypeName("DWORD")]
    public uint LxGid;

    [NativeTypeName("DWORD")]
    public uint LxMode;

    [NativeTypeName("DWORD")]
    public uint LxDeviceIdMajor;

    [NativeTypeName("DWORD")]
    public uint LxDeviceIdMinor;
}
