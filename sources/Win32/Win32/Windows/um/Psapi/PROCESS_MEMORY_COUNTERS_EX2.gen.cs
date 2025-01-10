// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Psapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct PROCESS_MEMORY_COUNTERS_EX2
{
    [NativeTypeName("DWORD")]
    public uint cb;

    [NativeTypeName("DWORD")]
    public uint PageFaultCount;

    [NativeTypeName("SIZE_T")]
    public nuint PeakWorkingSetSize;

    [NativeTypeName("SIZE_T")]
    public nuint WorkingSetSize;

    [NativeTypeName("SIZE_T")]
    public nuint QuotaPeakPagedPoolUsage;

    [NativeTypeName("SIZE_T")]
    public nuint QuotaPagedPoolUsage;

    [NativeTypeName("SIZE_T")]
    public nuint QuotaPeakNonPagedPoolUsage;

    [NativeTypeName("SIZE_T")]
    public nuint QuotaNonPagedPoolUsage;

    [NativeTypeName("SIZE_T")]
    public nuint PagefileUsage;

    [NativeTypeName("SIZE_T")]
    public nuint PeakPagefileUsage;

    [NativeTypeName("SIZE_T")]
    public nuint PrivateUsage;

    [NativeTypeName("SIZE_T")]
    public nuint PrivateWorkingSetSize;

    [NativeTypeName("ULONG64")]
    public ulong SharedCommitUsage;
}
