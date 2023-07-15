// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MEMORY_BASIC_INFORMATION64.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION64"]/*'/>
public partial struct MEMORY_BASIC_INFORMATION64
{
    /// <include file='MEMORY_BASIC_INFORMATION64.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION64.BaseAddress"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong BaseAddress;
    /// <include file='MEMORY_BASIC_INFORMATION64.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION64.AllocationBase"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong AllocationBase;
    /// <include file='MEMORY_BASIC_INFORMATION64.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION64.AllocationProtect"]/*'/>
    [NativeTypeName("DWORD")]
    public uint AllocationProtect;
    /// <include file='MEMORY_BASIC_INFORMATION64.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION64.__alignment1"]/*'/>
    [NativeTypeName("DWORD")]
    public uint __alignment1;
    /// <include file='MEMORY_BASIC_INFORMATION64.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION64.RegionSize"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong RegionSize;
    /// <include file='MEMORY_BASIC_INFORMATION64.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION64.State"]/*'/>
    [NativeTypeName("DWORD")]
    public uint State;
    /// <include file='MEMORY_BASIC_INFORMATION64.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION64.Protect"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Protect;
    /// <include file='MEMORY_BASIC_INFORMATION64.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION64.Type"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Type;
    /// <include file='MEMORY_BASIC_INFORMATION64.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION64.__alignment2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint __alignment2;
}