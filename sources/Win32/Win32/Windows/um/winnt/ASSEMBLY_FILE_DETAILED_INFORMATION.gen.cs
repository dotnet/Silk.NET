// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct ASSEMBLY_FILE_DETAILED_INFORMATION
{
    [NativeTypeName("DWORD")]
    public uint ulFlags;

    [NativeTypeName("DWORD")]
    public uint ulFilenameLength;

    [NativeTypeName("DWORD")]
    public uint ulPathLength;

    [NativeTypeName("PCWSTR")]
    public ushort* lpFileName;

    [NativeTypeName("PCWSTR")]
    public ushort* lpFilePath;
}
