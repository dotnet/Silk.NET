// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sysinfoapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MEMORYSTATUSEX.xml' path='doc/member[@name="MEMORYSTATUSEX"]/*'/>
public partial struct MEMORYSTATUSEX
{
    /// <include file='MEMORYSTATUSEX.xml' path='doc/member[@name="MEMORYSTATUSEX.dwLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwLength;
    /// <include file='MEMORYSTATUSEX.xml' path='doc/member[@name="MEMORYSTATUSEX.dwMemoryLoad"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMemoryLoad;
    /// <include file='MEMORYSTATUSEX.xml' path='doc/member[@name="MEMORYSTATUSEX.ullTotalPhys"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong ullTotalPhys;
    /// <include file='MEMORYSTATUSEX.xml' path='doc/member[@name="MEMORYSTATUSEX.ullAvailPhys"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong ullAvailPhys;
    /// <include file='MEMORYSTATUSEX.xml' path='doc/member[@name="MEMORYSTATUSEX.ullTotalPageFile"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong ullTotalPageFile;
    /// <include file='MEMORYSTATUSEX.xml' path='doc/member[@name="MEMORYSTATUSEX.ullAvailPageFile"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong ullAvailPageFile;
    /// <include file='MEMORYSTATUSEX.xml' path='doc/member[@name="MEMORYSTATUSEX.ullTotalVirtual"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong ullTotalVirtual;
    /// <include file='MEMORYSTATUSEX.xml' path='doc/member[@name="MEMORYSTATUSEX.ullAvailVirtual"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong ullAvailVirtual;
    /// <include file='MEMORYSTATUSEX.xml' path='doc/member[@name="MEMORYSTATUSEX.ullAvailExtendedVirtual"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong ullAvailExtendedVirtual;
}