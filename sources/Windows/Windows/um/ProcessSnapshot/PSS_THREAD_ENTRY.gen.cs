// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='PSS_THREAD_ENTRY.xml' path='doc/member[@name="PSS_THREAD_ENTRY"]/*' />
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct PSS_THREAD_ENTRY
{
    /// <include file='PSS_THREAD_ENTRY.xml' path='doc/member[@name="PSS_THREAD_ENTRY.ExitStatus"]/*' />
    [NativeTypeName("DWORD")]
    public uint ExitStatus;

    /// <include file='PSS_THREAD_ENTRY.xml' path='doc/member[@name="PSS_THREAD_ENTRY.TebBaseAddress"]/*' />
    public void* TebBaseAddress;

    /// <include file='PSS_THREAD_ENTRY.xml' path='doc/member[@name="PSS_THREAD_ENTRY.ProcessId"]/*' />
    [NativeTypeName("DWORD")]
    public uint ProcessId;

    /// <include file='PSS_THREAD_ENTRY.xml' path='doc/member[@name="PSS_THREAD_ENTRY.ThreadId"]/*' />
    [NativeTypeName("DWORD")]
    public uint ThreadId;

    /// <include file='PSS_THREAD_ENTRY.xml' path='doc/member[@name="PSS_THREAD_ENTRY.AffinityMask"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint AffinityMask;

    /// <include file='PSS_THREAD_ENTRY.xml' path='doc/member[@name="PSS_THREAD_ENTRY.Priority"]/*' />
    public int Priority;

    /// <include file='PSS_THREAD_ENTRY.xml' path='doc/member[@name="PSS_THREAD_ENTRY.BasePriority"]/*' />
    public int BasePriority;

    /// <include file='PSS_THREAD_ENTRY.xml' path='doc/member[@name="PSS_THREAD_ENTRY.LastSyscallFirstArgument"]/*' />
    public void* LastSyscallFirstArgument;

    /// <include file='PSS_THREAD_ENTRY.xml' path='doc/member[@name="PSS_THREAD_ENTRY.LastSyscallNumber"]/*' />
    [NativeTypeName("WORD")]
    public ushort LastSyscallNumber;

    /// <include file='PSS_THREAD_ENTRY.xml' path='doc/member[@name="PSS_THREAD_ENTRY.CreateTime"]/*' />
    public FILETIME CreateTime;

    /// <include file='PSS_THREAD_ENTRY.xml' path='doc/member[@name="PSS_THREAD_ENTRY.ExitTime"]/*' />
    public FILETIME ExitTime;

    /// <include file='PSS_THREAD_ENTRY.xml' path='doc/member[@name="PSS_THREAD_ENTRY.KernelTime"]/*' />
    public FILETIME KernelTime;

    /// <include file='PSS_THREAD_ENTRY.xml' path='doc/member[@name="PSS_THREAD_ENTRY.UserTime"]/*' />
    public FILETIME UserTime;

    /// <include file='PSS_THREAD_ENTRY.xml' path='doc/member[@name="PSS_THREAD_ENTRY.Win32StartAddress"]/*' />
    public void* Win32StartAddress;

    /// <include file='PSS_THREAD_ENTRY.xml' path='doc/member[@name="PSS_THREAD_ENTRY.CaptureTime"]/*' />
    public FILETIME CaptureTime;

    /// <include file='PSS_THREAD_ENTRY.xml' path='doc/member[@name="PSS_THREAD_ENTRY.Flags"]/*' />
    public PSS_THREAD_FLAGS Flags;

    /// <include file='PSS_THREAD_ENTRY.xml' path='doc/member[@name="PSS_THREAD_ENTRY.SuspendCount"]/*' />
    [NativeTypeName("WORD")]
    public ushort SuspendCount;

    /// <include file='PSS_THREAD_ENTRY.xml' path='doc/member[@name="PSS_THREAD_ENTRY.SizeOfContextRecord"]/*' />
    [NativeTypeName("WORD")]
    public ushort SizeOfContextRecord;

    /// <include file='PSS_THREAD_ENTRY.xml' path='doc/member[@name="PSS_THREAD_ENTRY.ContextRecord"]/*' />
    [NativeTypeName("PCONTEXT")]
    public void* ContextRecord;
}
