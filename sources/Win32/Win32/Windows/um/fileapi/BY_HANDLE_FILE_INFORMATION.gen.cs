// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/fileapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct BY_HANDLE_FILE_INFORMATION
{
    [NativeTypeName("DWORD")]
    public uint dwFileAttributes;
    public FILETIME ftCreationTime;
    public FILETIME ftLastAccessTime;
    public FILETIME ftLastWriteTime;

    [NativeTypeName("DWORD")]
    public uint dwVolumeSerialNumber;

    [NativeTypeName("DWORD")]
    public uint nFileSizeHigh;

    [NativeTypeName("DWORD")]
    public uint nFileSizeLow;

    [NativeTypeName("DWORD")]
    public uint nNumberOfLinks;

    [NativeTypeName("DWORD")]
    public uint nFileIndexHigh;

    [NativeTypeName("DWORD")]
    public uint nFileIndexLow;
}
