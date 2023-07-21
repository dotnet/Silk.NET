// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MEMORY_BASIC_INFORMATION.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION"]/*' />
public unsafe partial struct MEMORY_BASIC_INFORMATION
{
    /// <include file='MEMORY_BASIC_INFORMATION.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION.BaseAddress"]/*' />
    [NativeTypeName("PVOID")]
    public void* BaseAddress;

    /// <include file='MEMORY_BASIC_INFORMATION.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION.AllocationBase"]/*' />
    [NativeTypeName("PVOID")]
    public void* AllocationBase;

    /// <include file='MEMORY_BASIC_INFORMATION.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION.AllocationProtect"]/*' />
    [NativeTypeName("DWORD")]
    public uint AllocationProtect;

    /// <include file='MEMORY_BASIC_INFORMATION.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION.PartitionId"]/*' />
    [NativeTypeName("WORD")]
    public ushort PartitionId;

    /// <include file='MEMORY_BASIC_INFORMATION.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION.RegionSize"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint RegionSize;

    /// <include file='MEMORY_BASIC_INFORMATION.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION.State"]/*' />
    [NativeTypeName("DWORD")]
    public uint State;

    /// <include file='MEMORY_BASIC_INFORMATION.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION.Protect"]/*' />
    [NativeTypeName("DWORD")]
    public uint Protect;

    /// <include file='MEMORY_BASIC_INFORMATION.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION.Type"]/*' />
    [NativeTypeName("DWORD")]
    public uint Type;
}
