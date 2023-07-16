// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='UMS_SCHEDULER_STARTUP_INFO.xml' path='doc/member[@name="UMS_SCHEDULER_STARTUP_INFO"]/*'/>
public unsafe partial struct UMS_SCHEDULER_STARTUP_INFO
{
    /// <include file='UMS_SCHEDULER_STARTUP_INFO.xml' path='doc/member[@name="UMS_SCHEDULER_STARTUP_INFO.UmsVersion"]/*'/>
    [NativeTypeName("ULONG")]
    public uint UmsVersion;
    /// <include file='UMS_SCHEDULER_STARTUP_INFO.xml' path='doc/member[@name="UMS_SCHEDULER_STARTUP_INFO.CompletionList"]/*'/>
    [NativeTypeName("PUMS_COMPLETION_LIST")]
    public void* CompletionList;
    /// <include file='UMS_SCHEDULER_STARTUP_INFO.xml' path='doc/member[@name="UMS_SCHEDULER_STARTUP_INFO.SchedulerProc"]/*'/>
    [NativeTypeName("PUMS_SCHEDULER_ENTRY_POINT")]
    public delegate* unmanaged<UMS_SCHEDULER_REASON, nuint, void*, void> SchedulerProc;
    /// <include file='UMS_SCHEDULER_STARTUP_INFO.xml' path='doc/member[@name="UMS_SCHEDULER_STARTUP_INFO.SchedulerParam"]/*'/>
    [NativeTypeName("PVOID")]
    public void* SchedulerParam;
}