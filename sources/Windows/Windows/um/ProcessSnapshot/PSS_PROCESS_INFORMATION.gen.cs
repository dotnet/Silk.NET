// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION"]/*'/>
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct PSS_PROCESS_INFORMATION
{
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.ExitStatus"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ExitStatus;
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.PebBaseAddress"]/*'/>
    public void* PebBaseAddress;
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.AffinityMask"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint AffinityMask;
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.BasePriority"]/*'/>
    [NativeTypeName("LONG")]
    public int BasePriority;
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.ProcessId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ProcessId;
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.ParentProcessId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ParentProcessId;
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.Flags"]/*'/>
    public PSS_PROCESS_FLAGS Flags;
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.CreateTime"]/*'/>
    public FILETIME CreateTime;
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.ExitTime"]/*'/>
    public FILETIME ExitTime;
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.KernelTime"]/*'/>
    public FILETIME KernelTime;
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.UserTime"]/*'/>
    public FILETIME UserTime;
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.PriorityClass"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PriorityClass;
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.PeakVirtualSize"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint PeakVirtualSize;
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.VirtualSize"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint VirtualSize;
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.PageFaultCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PageFaultCount;
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.PeakWorkingSetSize"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint PeakWorkingSetSize;
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.WorkingSetSize"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint WorkingSetSize;
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.QuotaPeakPagedPoolUsage"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint QuotaPeakPagedPoolUsage;
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.QuotaPagedPoolUsage"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint QuotaPagedPoolUsage;
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.QuotaPeakNonPagedPoolUsage"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint QuotaPeakNonPagedPoolUsage;
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.QuotaNonPagedPoolUsage"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint QuotaNonPagedPoolUsage;
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.PagefileUsage"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint PagefileUsage;
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.PeakPagefileUsage"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint PeakPagefileUsage;
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.PrivateUsage"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint PrivateUsage;
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.ExecuteFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ExecuteFlags;
    /// <include file='PSS_PROCESS_INFORMATION.xml' path='doc/member[@name="PSS_PROCESS_INFORMATION.ImageFileName"]/*'/>
    [NativeTypeName("wchar_t[260]")]
    public fixed ushort ImageFileName[260];
}