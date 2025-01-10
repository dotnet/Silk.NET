// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.3")]
public unsafe partial struct PSS_PROCESS_INFORMATION
{
    [NativeTypeName("DWORD")]
    public uint ExitStatus;
    public void* PebBaseAddress;

    [NativeTypeName("ULONG_PTR")]
    public nuint AffinityMask;

    [NativeTypeName("LONG")]
    public int BasePriority;

    [NativeTypeName("DWORD")]
    public uint ProcessId;

    [NativeTypeName("DWORD")]
    public uint ParentProcessId;
    public PSS_PROCESS_FLAGS Flags;
    public FILETIME CreateTime;
    public FILETIME ExitTime;
    public FILETIME KernelTime;
    public FILETIME UserTime;

    [NativeTypeName("DWORD")]
    public uint PriorityClass;

    [NativeTypeName("ULONG_PTR")]
    public nuint PeakVirtualSize;

    [NativeTypeName("ULONG_PTR")]
    public nuint VirtualSize;

    [NativeTypeName("DWORD")]
    public uint PageFaultCount;

    [NativeTypeName("ULONG_PTR")]
    public nuint PeakWorkingSetSize;

    [NativeTypeName("ULONG_PTR")]
    public nuint WorkingSetSize;

    [NativeTypeName("ULONG_PTR")]
    public nuint QuotaPeakPagedPoolUsage;

    [NativeTypeName("ULONG_PTR")]
    public nuint QuotaPagedPoolUsage;

    [NativeTypeName("ULONG_PTR")]
    public nuint QuotaPeakNonPagedPoolUsage;

    [NativeTypeName("ULONG_PTR")]
    public nuint QuotaNonPagedPoolUsage;

    [NativeTypeName("ULONG_PTR")]
    public nuint PagefileUsage;

    [NativeTypeName("ULONG_PTR")]
    public nuint PeakPagefileUsage;

    [NativeTypeName("ULONG_PTR")]
    public nuint PrivateUsage;

    [NativeTypeName("DWORD")]
    public uint ExecuteFlags;

    [NativeTypeName("wchar_t[260]")]
    public _ImageFileName_e__FixedBuffer ImageFileName;

    [InlineArray(260)]
    public partial struct _ImageFileName_e__FixedBuffer
    {
        public ushort e0;
    }
}
