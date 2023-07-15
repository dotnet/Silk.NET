// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Psapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PROCESS_MEMORY_COUNTERS.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS"]/*'/>
public partial struct PROCESS_MEMORY_COUNTERS
{
    /// <include file='PROCESS_MEMORY_COUNTERS.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS.cb"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cb;
    /// <include file='PROCESS_MEMORY_COUNTERS.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS.PageFaultCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PageFaultCount;
    /// <include file='PROCESS_MEMORY_COUNTERS.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS.PeakWorkingSetSize"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint PeakWorkingSetSize;
    /// <include file='PROCESS_MEMORY_COUNTERS.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS.WorkingSetSize"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint WorkingSetSize;
    /// <include file='PROCESS_MEMORY_COUNTERS.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS.QuotaPeakPagedPoolUsage"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint QuotaPeakPagedPoolUsage;
    /// <include file='PROCESS_MEMORY_COUNTERS.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS.QuotaPagedPoolUsage"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint QuotaPagedPoolUsage;
    /// <include file='PROCESS_MEMORY_COUNTERS.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS.QuotaPeakNonPagedPoolUsage"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint QuotaPeakNonPagedPoolUsage;
    /// <include file='PROCESS_MEMORY_COUNTERS.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS.QuotaNonPagedPoolUsage"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint QuotaNonPagedPoolUsage;
    /// <include file='PROCESS_MEMORY_COUNTERS.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS.PagefileUsage"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint PagefileUsage;
    /// <include file='PROCESS_MEMORY_COUNTERS.xml' path='doc/member[@name="PROCESS_MEMORY_COUNTERS.PeakPagefileUsage"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint PeakPagefileUsage;
}