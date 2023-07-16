// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Psapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PROCESS_MEMORY_COUNTERS_EX.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX"]/*'/>
public partial struct PROCESS_MEMORY_COUNTERS_EX
{
    /// <include file='PROCESS_MEMORY_COUNTERS_EX.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX.cb"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cb;
    /// <include file='PROCESS_MEMORY_COUNTERS_EX.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX.PageFaultCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PageFaultCount;
    /// <include file='PROCESS_MEMORY_COUNTERS_EX.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX.PeakWorkingSetSize"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint PeakWorkingSetSize;
    /// <include file='PROCESS_MEMORY_COUNTERS_EX.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX.WorkingSetSize"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint WorkingSetSize;
    /// <include file='PROCESS_MEMORY_COUNTERS_EX.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX.QuotaPeakPagedPoolUsage"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint QuotaPeakPagedPoolUsage;
    /// <include file='PROCESS_MEMORY_COUNTERS_EX.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX.QuotaPagedPoolUsage"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint QuotaPagedPoolUsage;
    /// <include file='PROCESS_MEMORY_COUNTERS_EX.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX.QuotaPeakNonPagedPoolUsage"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint QuotaPeakNonPagedPoolUsage;
    /// <include file='PROCESS_MEMORY_COUNTERS_EX.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX.QuotaNonPagedPoolUsage"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint QuotaNonPagedPoolUsage;
    /// <include file='PROCESS_MEMORY_COUNTERS_EX.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX.PagefileUsage"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint PagefileUsage;
    /// <include file='PROCESS_MEMORY_COUNTERS_EX.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX.PeakPagefileUsage"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint PeakPagefileUsage;
    /// <include file='PROCESS_MEMORY_COUNTERS_EX.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS_EX.PrivateUsage"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint PrivateUsage;
}