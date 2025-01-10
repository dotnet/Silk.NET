// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct FILE_LAYOUT_ENTRY
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint NextFileOffset;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint FileAttributes;

    [NativeTypeName("DWORDLONG")]
    public ulong FileReferenceNumber;

    [NativeTypeName("DWORD")]
    public uint FirstNameOffset;

    [NativeTypeName("DWORD")]
    public uint FirstStreamOffset;

    [NativeTypeName("DWORD")]
    public uint ExtraInfoOffset;

    [NativeTypeName("DWORD")]
    public uint ExtraInfoLength;
}
