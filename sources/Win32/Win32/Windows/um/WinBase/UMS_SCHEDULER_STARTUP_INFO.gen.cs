// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct UMS_SCHEDULER_STARTUP_INFO
{
    [NativeTypeName("ULONG")]
    public uint UmsVersion;

    [NativeTypeName("PUMS_COMPLETION_LIST")]
    public void* CompletionList;

    [NativeTypeName("PUMS_SCHEDULER_ENTRY_POINT")]
    public delegate* unmanaged<UMS_SCHEDULER_REASON, nuint, void*, void> SchedulerProc;

    [NativeTypeName("PVOID")]
    public void* SchedulerParam;
}
