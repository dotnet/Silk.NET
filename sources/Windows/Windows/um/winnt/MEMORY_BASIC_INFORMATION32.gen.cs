// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MEMORY_BASIC_INFORMATION32.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION32"]/*'/>
public partial struct MEMORY_BASIC_INFORMATION32
{
    /// <include file='MEMORY_BASIC_INFORMATION32.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION32.BaseAddress"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BaseAddress;
    /// <include file='MEMORY_BASIC_INFORMATION32.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION32.AllocationBase"]/*'/>
    [NativeTypeName("DWORD")]
    public uint AllocationBase;
    /// <include file='MEMORY_BASIC_INFORMATION32.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION32.AllocationProtect"]/*'/>
    [NativeTypeName("DWORD")]
    public uint AllocationProtect;
    /// <include file='MEMORY_BASIC_INFORMATION32.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION32.RegionSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint RegionSize;
    /// <include file='MEMORY_BASIC_INFORMATION32.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION32.State"]/*'/>
    [NativeTypeName("DWORD")]
    public uint State;
    /// <include file='MEMORY_BASIC_INFORMATION32.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION32.Protect"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Protect;
    /// <include file='MEMORY_BASIC_INFORMATION32.xml' path='doc/member[@name="MEMORY_BASIC_INFORMATION32.Type"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Type;
}