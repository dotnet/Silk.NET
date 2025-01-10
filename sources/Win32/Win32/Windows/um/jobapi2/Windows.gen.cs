// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/namespaceapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateJobObjectW(
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpJobAttributes,
        [NativeTypeName("LPCWSTR")] ushort* lpName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0")]
    public static extern void FreeMemoryJobObject(void* Buffer);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenJobObjectW(
        [NativeTypeName("DWORD")] uint dwDesiredAccess,
        BOOL bInheritHandle,
        [NativeTypeName("LPCWSTR")] ushort* lpName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AssignProcessToJobObject(HANDLE hJob, HANDLE hProcess);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL TerminateJobObject(HANDLE hJob, uint uExitCode);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetInformationJobObject(
        HANDLE hJob,
        JOBOBJECTINFOCLASS JobObjectInformationClass,
        [NativeTypeName("LPVOID")] void* lpJobObjectInformation,
        [NativeTypeName("DWORD")] uint cbJobObjectInformationLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows10.0")]
    public static extern uint SetIoRateControlInformationJobObject(
        HANDLE hJob,
        JOBOBJECT_IO_RATE_CONTROL_INFORMATION* IoRateControlInfo
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL QueryInformationJobObject(
        HANDLE hJob,
        JOBOBJECTINFOCLASS JobObjectInformationClass,
        [NativeTypeName("LPVOID")] void* lpJobObjectInformation,
        [NativeTypeName("DWORD")] uint cbJobObjectInformationLength,
        [NativeTypeName("LPDWORD")] uint* lpReturnLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows10.0")]
    public static extern uint QueryIoRateControlInformationJobObject(
        HANDLE hJob,
        [NativeTypeName("PCWSTR")] ushort* VolumeName,
        JOBOBJECT_IO_RATE_CONTROL_INFORMATION** InfoBlocks,
        [NativeTypeName("ULONG *")] uint* InfoBlockCount
    );
}
