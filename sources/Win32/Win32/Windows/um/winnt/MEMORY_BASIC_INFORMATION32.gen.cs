// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MEMORY_BASIC_INFORMATION32
{
    [NativeTypeName("DWORD")]
    public uint BaseAddress;

    [NativeTypeName("DWORD")]
    public uint AllocationBase;

    [NativeTypeName("DWORD")]
    public uint AllocationProtect;

    [NativeTypeName("DWORD")]
    public uint RegionSize;

    [NativeTypeName("DWORD")]
    public uint State;

    [NativeTypeName("DWORD")]
    public uint Protect;

    [NativeTypeName("DWORD")]
    public uint Type;
}
