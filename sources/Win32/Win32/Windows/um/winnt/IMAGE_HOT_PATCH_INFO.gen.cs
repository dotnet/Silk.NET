// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IMAGE_HOT_PATCH_INFO
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("DWORD")]
    public uint SequenceNumber;

    [NativeTypeName("DWORD")]
    public uint BaseImageList;

    [NativeTypeName("DWORD")]
    public uint BaseImageCount;

    [NativeTypeName("DWORD")]
    public uint BufferOffset;

    [NativeTypeName("DWORD")]
    public uint ExtraPatchSize;

    [NativeTypeName("DWORD")]
    public uint MinSequenceNumber;

    [NativeTypeName("DWORD")]
    public uint Flags;
}
