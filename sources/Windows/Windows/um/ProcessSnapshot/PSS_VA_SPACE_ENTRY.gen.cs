// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='PSS_VA_SPACE_ENTRY.xml' path='doc/member[@name="PSS_VA_SPACE_ENTRY"]/*' />
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct PSS_VA_SPACE_ENTRY
{
    /// <include file='PSS_VA_SPACE_ENTRY.xml' path='doc/member[@name="PSS_VA_SPACE_ENTRY.BaseAddress"]/*' />
    public void* BaseAddress;

    /// <include file='PSS_VA_SPACE_ENTRY.xml' path='doc/member[@name="PSS_VA_SPACE_ENTRY.AllocationBase"]/*' />
    public void* AllocationBase;

    /// <include file='PSS_VA_SPACE_ENTRY.xml' path='doc/member[@name="PSS_VA_SPACE_ENTRY.AllocationProtect"]/*' />
    [NativeTypeName("DWORD")]
    public uint AllocationProtect;

    /// <include file='PSS_VA_SPACE_ENTRY.xml' path='doc/member[@name="PSS_VA_SPACE_ENTRY.RegionSize"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint RegionSize;

    /// <include file='PSS_VA_SPACE_ENTRY.xml' path='doc/member[@name="PSS_VA_SPACE_ENTRY.State"]/*' />
    [NativeTypeName("DWORD")]
    public uint State;

    /// <include file='PSS_VA_SPACE_ENTRY.xml' path='doc/member[@name="PSS_VA_SPACE_ENTRY.Protect"]/*' />
    [NativeTypeName("DWORD")]
    public uint Protect;

    /// <include file='PSS_VA_SPACE_ENTRY.xml' path='doc/member[@name="PSS_VA_SPACE_ENTRY.Type"]/*' />
    [NativeTypeName("DWORD")]
    public uint Type;

    /// <include file='PSS_VA_SPACE_ENTRY.xml' path='doc/member[@name="PSS_VA_SPACE_ENTRY.TimeDateStamp"]/*' />
    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;

    /// <include file='PSS_VA_SPACE_ENTRY.xml' path='doc/member[@name="PSS_VA_SPACE_ENTRY.SizeOfImage"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfImage;

    /// <include file='PSS_VA_SPACE_ENTRY.xml' path='doc/member[@name="PSS_VA_SPACE_ENTRY.ImageBase"]/*' />
    public void* ImageBase;

    /// <include file='PSS_VA_SPACE_ENTRY.xml' path='doc/member[@name="PSS_VA_SPACE_ENTRY.CheckSum"]/*' />
    [NativeTypeName("DWORD")]
    public uint CheckSum;

    /// <include file='PSS_VA_SPACE_ENTRY.xml' path='doc/member[@name="PSS_VA_SPACE_ENTRY.MappedFileNameLength"]/*' />
    [NativeTypeName("WORD")]
    public ushort MappedFileNameLength;

    /// <include file='PSS_VA_SPACE_ENTRY.xml' path='doc/member[@name="PSS_VA_SPACE_ENTRY.MappedFileName"]/*' />
    [NativeTypeName("const wchar_t *")]
    public ushort* MappedFileName;
}
