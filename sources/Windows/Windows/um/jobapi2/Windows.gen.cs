// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/namespaceapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateJobObjectW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateJobObjectW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpJobAttributes, [NativeTypeName("LPCWSTR")] ushort* lpName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FreeMemoryJobObject"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0")]
    public static extern void FreeMemoryJobObject(void* Buffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenJobObjectW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenJobObjectW([NativeTypeName("DWORD")] uint dwDesiredAccess, BOOL bInheritHandle, [NativeTypeName("LPCWSTR")] ushort* lpName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AssignProcessToJobObject"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AssignProcessToJobObject(HANDLE hJob, HANDLE hProcess);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TerminateJobObject"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL TerminateJobObject(HANDLE hJob, uint uExitCode);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetInformationJobObject"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetInformationJobObject(HANDLE hJob, JOBOBJECTINFOCLASS JobObjectInformationClass, [NativeTypeName("LPVOID")] void* lpJobObjectInformation, [NativeTypeName("DWORD")] uint cbJobObjectInformationLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetIoRateControlInformationJobObject"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows10.0")]
    public static extern uint SetIoRateControlInformationJobObject(HANDLE hJob, JOBOBJECT_IO_RATE_CONTROL_INFORMATION* IoRateControlInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.QueryInformationJobObject"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL QueryInformationJobObject(HANDLE hJob, JOBOBJECTINFOCLASS JobObjectInformationClass, [NativeTypeName("LPVOID")] void* lpJobObjectInformation, [NativeTypeName("DWORD")] uint cbJobObjectInformationLength, [NativeTypeName("LPDWORD")] uint* lpReturnLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.QueryIoRateControlInformationJobObject"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows10.0")]
    public static extern uint QueryIoRateControlInformationJobObject(HANDLE hJob, [NativeTypeName("PCWSTR")] ushort* VolumeName, JOBOBJECT_IO_RATE_CONTROL_INFORMATION** InfoBlocks, [NativeTypeName("ULONG *")] uint* InfoBlockCount);
}
