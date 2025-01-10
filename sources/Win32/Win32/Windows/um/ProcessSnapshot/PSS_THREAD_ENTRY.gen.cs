// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.3")]
public unsafe partial struct PSS_THREAD_ENTRY
{
    [NativeTypeName("DWORD")]
    public uint ExitStatus;
    public void* TebBaseAddress;

    [NativeTypeName("DWORD")]
    public uint ProcessId;

    [NativeTypeName("DWORD")]
    public uint ThreadId;

    [NativeTypeName("ULONG_PTR")]
    public nuint AffinityMask;
    public int Priority;
    public int BasePriority;
    public void* LastSyscallFirstArgument;

    [NativeTypeName("WORD")]
    public ushort LastSyscallNumber;
    public FILETIME CreateTime;
    public FILETIME ExitTime;
    public FILETIME KernelTime;
    public FILETIME UserTime;
    public void* Win32StartAddress;
    public FILETIME CaptureTime;
    public PSS_THREAD_FLAGS Flags;

    [NativeTypeName("WORD")]
    public ushort SuspendCount;

    [NativeTypeName("WORD")]
    public ushort SizeOfContextRecord;

    [NativeTypeName("PCONTEXT")]
    public void* ContextRecord;
}
