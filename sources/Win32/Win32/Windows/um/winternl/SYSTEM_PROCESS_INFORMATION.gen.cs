// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SYSTEM_PROCESS_INFORMATION
{
    [NativeTypeName("ULONG")]
    public uint NextEntryOffset;

    [NativeTypeName("ULONG")]
    public uint NumberOfThreads;

    [NativeTypeName("BYTE[48]")]
    public _Reserved1_e__FixedBuffer Reserved1;
    public UNICODE_STRING ImageName;

    [NativeTypeName("KPRIORITY")]
    public int BasePriority;
    public HANDLE UniqueProcessId;

    [NativeTypeName("PVOID")]
    public void* Reserved2;

    [NativeTypeName("ULONG")]
    public uint HandleCount;

    [NativeTypeName("ULONG")]
    public uint SessionId;

    [NativeTypeName("PVOID")]
    public void* Reserved3;

    [NativeTypeName("SIZE_T")]
    public nuint PeakVirtualSize;

    [NativeTypeName("SIZE_T")]
    public nuint VirtualSize;

    [NativeTypeName("ULONG")]
    public uint Reserved4;

    [NativeTypeName("SIZE_T")]
    public nuint PeakWorkingSetSize;

    [NativeTypeName("SIZE_T")]
    public nuint WorkingSetSize;

    [NativeTypeName("PVOID")]
    public void* Reserved5;

    [NativeTypeName("SIZE_T")]
    public nuint QuotaPagedPoolUsage;

    [NativeTypeName("PVOID")]
    public void* Reserved6;

    [NativeTypeName("SIZE_T")]
    public nuint QuotaNonPagedPoolUsage;

    [NativeTypeName("SIZE_T")]
    public nuint PagefileUsage;

    [NativeTypeName("SIZE_T")]
    public nuint PeakPagefileUsage;

    [NativeTypeName("SIZE_T")]
    public nuint PrivatePageCount;

    [NativeTypeName("LARGE_INTEGER[6]")]
    public _Reserved7_e__FixedBuffer Reserved7;

    [InlineArray(48)]
    public partial struct _Reserved1_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(6)]
    public partial struct _Reserved7_e__FixedBuffer
    {
        public LARGE_INTEGER e0;
    }
}
