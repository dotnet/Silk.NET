// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint QueueUserAPC(
        [NativeTypeName("PAPCFUNC")] delegate* unmanaged<nuint, void> pfnAPC,
        HANDLE hThread,
        [NativeTypeName("ULONG_PTR")] nuint dwData
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.22000.0")]
    public static extern BOOL QueueUserAPC2(
        [NativeTypeName("PAPCFUNC")] delegate* unmanaged<nuint, void> ApcRoutine,
        HANDLE Thread,
        [NativeTypeName("ULONG_PTR")] nuint Data,
        QUEUE_USER_APC_FLAGS Flags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetProcessTimes(
        HANDLE hProcess,
        [NativeTypeName("LPFILETIME")] FILETIME* lpCreationTime,
        [NativeTypeName("LPFILETIME")] FILETIME* lpExitTime,
        [NativeTypeName("LPFILETIME")] FILETIME* lpKernelTime,
        [NativeTypeName("LPFILETIME")] FILETIME* lpUserTime
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HANDLE GetCurrentProcess();

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetCurrentProcessId();

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void ExitProcess(uint uExitCode);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL TerminateProcess(HANDLE hProcess, uint uExitCode);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetExitCodeProcess(
        HANDLE hProcess,
        [NativeTypeName("LPDWORD")] uint* lpExitCode
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL SwitchToThread();

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateThread(
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes,
        [NativeTypeName("SIZE_T")] nuint dwStackSize,
        [NativeTypeName("LPTHREAD_START_ROUTINE")] delegate* unmanaged<void*, uint> lpStartAddress,
        [NativeTypeName("LPVOID")] void* lpParameter,
        [NativeTypeName("DWORD")] uint dwCreationFlags,
        [NativeTypeName("LPDWORD")] uint* lpThreadId
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateRemoteThread(
        HANDLE hProcess,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes,
        [NativeTypeName("SIZE_T")] nuint dwStackSize,
        [NativeTypeName("LPTHREAD_START_ROUTINE")] delegate* unmanaged<void*, uint> lpStartAddress,
        [NativeTypeName("LPVOID")] void* lpParameter,
        [NativeTypeName("DWORD")] uint dwCreationFlags,
        [NativeTypeName("LPDWORD")] uint* lpThreadId
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HANDLE GetCurrentThread();

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SuppressGCTransition]
    public static extern uint GetCurrentThreadId();

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenThread(
        [NativeTypeName("DWORD")] uint dwDesiredAccess,
        BOOL bInheritHandle,
        [NativeTypeName("DWORD")] uint dwThreadId
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetThreadPriority(HANDLE hThread, int nPriority);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetThreadPriorityBoost(HANDLE hThread, BOOL bDisablePriorityBoost);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetThreadPriorityBoost(
        HANDLE hThread,
        [NativeTypeName("PBOOL")] BOOL* pDisablePriorityBoost
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int GetThreadPriority(HANDLE hThread);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void ExitThread([NativeTypeName("DWORD")] uint dwExitCode);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL TerminateThread(
        HANDLE hThread,
        [NativeTypeName("DWORD")] uint dwExitCode
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetExitCodeThread(
        HANDLE hThread,
        [NativeTypeName("LPDWORD")] uint* lpExitCode
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint SuspendThread(HANDLE hThread);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint ResumeThread(HANDLE hThread);

    [DllImport("kernelbase", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint TlsAlloc();

    [DllImport("kernelbase", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPVOID")]
    public static extern void* TlsGetValue([NativeTypeName("DWORD")] uint dwTlsIndex);

    [DllImport("kernelbase", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL TlsSetValue(
        [NativeTypeName("DWORD")] uint dwTlsIndex,
        [NativeTypeName("LPVOID")] void* lpTlsValue
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL TlsFree([NativeTypeName("DWORD")] uint dwTlsIndex);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateProcessA(
        [NativeTypeName("LPCSTR")] sbyte* lpApplicationName,
        [NativeTypeName("LPSTR")] sbyte* lpCommandLine,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpProcessAttributes,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes,
        BOOL bInheritHandles,
        [NativeTypeName("DWORD")] uint dwCreationFlags,
        [NativeTypeName("LPVOID")] void* lpEnvironment,
        [NativeTypeName("LPCSTR")] sbyte* lpCurrentDirectory,
        [NativeTypeName("LPSTARTUPINFOA")] STARTUPINFOA* lpStartupInfo,
        [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateProcessW(
        [NativeTypeName("LPCWSTR")] ushort* lpApplicationName,
        [NativeTypeName("LPWSTR")] ushort* lpCommandLine,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpProcessAttributes,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes,
        BOOL bInheritHandles,
        [NativeTypeName("DWORD")] uint dwCreationFlags,
        [NativeTypeName("LPVOID")] void* lpEnvironment,
        [NativeTypeName("LPCWSTR")] ushort* lpCurrentDirectory,
        [NativeTypeName("LPSTARTUPINFOW")] STARTUPINFOW* lpStartupInfo,
        [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetProcessShutdownParameters(
        [NativeTypeName("DWORD")] uint dwLevel,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetProcessVersion([NativeTypeName("DWORD")] uint ProcessId);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void GetStartupInfoW(
        [NativeTypeName("LPSTARTUPINFOW")] STARTUPINFOW* lpStartupInfo
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateProcessAsUserW(
        HANDLE hToken,
        [NativeTypeName("LPCWSTR")] ushort* lpApplicationName,
        [NativeTypeName("LPWSTR")] ushort* lpCommandLine,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpProcessAttributes,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes,
        BOOL bInheritHandles,
        [NativeTypeName("DWORD")] uint dwCreationFlags,
        [NativeTypeName("LPVOID")] void* lpEnvironment,
        [NativeTypeName("LPCWSTR")] ushort* lpCurrentDirectory,
        [NativeTypeName("LPSTARTUPINFOW")] STARTUPINFOW* lpStartupInfo,
        [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation
    );

    [SupportedOSPlatform("windows6.2")]
    public static HANDLE GetCurrentProcessToken()
    {
        return (HANDLE)((nint)(-4));
    }

    [SupportedOSPlatform("windows6.2")]
    public static HANDLE GetCurrentThreadToken()
    {
        return (HANDLE)((nint)(-5));
    }

    [SupportedOSPlatform("windows6.2")]
    public static HANDLE GetCurrentThreadEffectiveToken()
    {
        return (HANDLE)((nint)(-6));
    }

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetThreadToken(
        [NativeTypeName("PHANDLE")] HANDLE* Thread,
        HANDLE Token
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL OpenProcessToken(
        HANDLE ProcessHandle,
        [NativeTypeName("DWORD")] uint DesiredAccess,
        [NativeTypeName("PHANDLE")] HANDLE* TokenHandle
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL OpenThreadToken(
        HANDLE ThreadHandle,
        [NativeTypeName("DWORD")] uint DesiredAccess,
        BOOL OpenAsSelf,
        [NativeTypeName("PHANDLE")] HANDLE* TokenHandle
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetPriorityClass(
        HANDLE hProcess,
        [NativeTypeName("DWORD")] uint dwPriorityClass
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetPriorityClass(HANDLE hProcess);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetThreadStackGuarantee(
        [NativeTypeName("PULONG")] uint* StackSizeInBytes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ProcessIdToSessionId(
        [NativeTypeName("DWORD")] uint dwProcessId,
        [NativeTypeName("DWORD *")] uint* pSessionId
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetProcessId(HANDLE Process);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetThreadId(HANDLE Thread);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void FlushProcessWriteBuffers();

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetProcessIdOfThread(HANDLE Thread);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InitializeProcThreadAttributeList(
        LPPROC_THREAD_ATTRIBUTE_LIST lpAttributeList,
        [NativeTypeName("DWORD")] uint dwAttributeCount,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("PSIZE_T")] nuint* lpSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void DeleteProcThreadAttributeList(
        LPPROC_THREAD_ATTRIBUTE_LIST lpAttributeList
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UpdateProcThreadAttribute(
        LPPROC_THREAD_ATTRIBUTE_LIST lpAttributeList,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD_PTR")] nuint Attribute,
        [NativeTypeName("PVOID")] void* lpValue,
        [NativeTypeName("SIZE_T")] nuint cbSize,
        [NativeTypeName("PVOID")] void* lpPreviousValue,
        [NativeTypeName("PSIZE_T")] nuint* lpReturnSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern BOOL SetProcessDynamicEHContinuationTargets(
        HANDLE Process,
        ushort NumberOfTargets,
        [NativeTypeName("PPROCESS_DYNAMIC_EH_CONTINUATION_TARGET")]
            PROCESS_DYNAMIC_EH_CONTINUATION_TARGET* Targets
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.19041.0")]
    public static extern BOOL SetProcessDynamicEnforcedCetCompatibleRanges(
        HANDLE Process,
        ushort NumberOfRanges,
        [NativeTypeName("PPROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE")]
            PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE* Ranges
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetProcessAffinityUpdateMode(
        HANDLE hProcess,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL QueryProcessAffinityUpdateMode(
        HANDLE hProcess,
        [NativeTypeName("LPDWORD")] uint* lpdwFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateRemoteThreadEx(
        HANDLE hProcess,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes,
        [NativeTypeName("SIZE_T")] nuint dwStackSize,
        [NativeTypeName("LPTHREAD_START_ROUTINE")] delegate* unmanaged<void*, uint> lpStartAddress,
        [NativeTypeName("LPVOID")] void* lpParameter,
        [NativeTypeName("DWORD")] uint dwCreationFlags,
        LPPROC_THREAD_ATTRIBUTE_LIST lpAttributeList,
        [NativeTypeName("LPDWORD")] uint* lpThreadId
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern void GetCurrentThreadStackLimits(
        [NativeTypeName("PULONG_PTR")] nuint* LowLimit,
        [NativeTypeName("PULONG_PTR")] nuint* HighLimit
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetThreadContext(
        HANDLE hThread,
        [NativeTypeName("LPCONTEXT")] void* lpContext
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetProcessMitigationPolicy(
        HANDLE hProcess,
        PROCESS_MITIGATION_POLICY MitigationPolicy,
        [NativeTypeName("PVOID")] void* lpBuffer,
        [NativeTypeName("SIZE_T")] nuint dwLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetThreadContext(
        HANDLE hThread,
        [NativeTypeName("const CONTEXT *")] void* lpContext
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL SetProcessMitigationPolicy(
        PROCESS_MITIGATION_POLICY MitigationPolicy,
        [NativeTypeName("PVOID")] void* lpBuffer,
        [NativeTypeName("SIZE_T")] nuint dwLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FlushInstructionCache(
        HANDLE hProcess,
        [NativeTypeName("LPCVOID")] void* lpBaseAddress,
        [NativeTypeName("SIZE_T")] nuint dwSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetThreadTimes(
        HANDLE hThread,
        [NativeTypeName("LPFILETIME")] FILETIME* lpCreationTime,
        [NativeTypeName("LPFILETIME")] FILETIME* lpExitTime,
        [NativeTypeName("LPFILETIME")] FILETIME* lpKernelTime,
        [NativeTypeName("LPFILETIME")] FILETIME* lpUserTime
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenProcess(
        [NativeTypeName("DWORD")] uint dwDesiredAccess,
        BOOL bInheritHandle,
        [NativeTypeName("DWORD")] uint dwProcessId
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL IsProcessorFeaturePresent(
        [NativeTypeName("DWORD")] uint ProcessorFeature
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetProcessHandleCount(
        HANDLE hProcess,
        [NativeTypeName("PDWORD")] uint* pdwHandleCount
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetCurrentProcessorNumber();

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetThreadIdealProcessorEx(
        HANDLE hThread,
        [NativeTypeName("PPROCESSOR_NUMBER")] PROCESSOR_NUMBER* lpIdealProcessor,
        [NativeTypeName("PPROCESSOR_NUMBER")] PROCESSOR_NUMBER* lpPreviousIdealProcessor
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetThreadIdealProcessorEx(
        HANDLE hThread,
        [NativeTypeName("PPROCESSOR_NUMBER")] PROCESSOR_NUMBER* lpIdealProcessor
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void GetCurrentProcessorNumberEx(
        [NativeTypeName("PPROCESSOR_NUMBER")] PROCESSOR_NUMBER* ProcNumber
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetProcessPriorityBoost(
        HANDLE hProcess,
        [NativeTypeName("PBOOL")] BOOL* pDisablePriorityBoost
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetProcessPriorityBoost(HANDLE hProcess, BOOL bDisablePriorityBoost);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetThreadIOPendingFlag(
        HANDLE hThread,
        [NativeTypeName("PBOOL")] BOOL* lpIOIsPending
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetSystemTimes(
        [NativeTypeName("PFILETIME")] FILETIME* lpIdleTime,
        [NativeTypeName("PFILETIME")] FILETIME* lpKernelTime,
        [NativeTypeName("PFILETIME")] FILETIME* lpUserTime
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetThreadInformation(
        HANDLE hThread,
        THREAD_INFORMATION_CLASS ThreadInformationClass,
        [NativeTypeName("LPVOID")] void* ThreadInformation,
        [NativeTypeName("DWORD")] uint ThreadInformationSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL SetThreadInformation(
        HANDLE hThread,
        THREAD_INFORMATION_CLASS ThreadInformationClass,
        [NativeTypeName("LPVOID")] void* ThreadInformation,
        [NativeTypeName("DWORD")] uint ThreadInformationSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.3")]
    public static extern BOOL IsProcessCritical(
        HANDLE hProcess,
        [NativeTypeName("PBOOL")] BOOL* Critical
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern BOOL SetProtectedPolicy(
        [NativeTypeName("LPCGUID")] Guid* PolicyGuid,
        [NativeTypeName("ULONG_PTR")] nuint PolicyValue,
        [NativeTypeName("PULONG_PTR")] nuint* OldPolicyValue
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern BOOL QueryProtectedPolicy(
        [NativeTypeName("LPCGUID")] Guid* PolicyGuid,
        [NativeTypeName("PULONG_PTR")] nuint* PolicyValue
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetThreadIdealProcessor(
        HANDLE hThread,
        [NativeTypeName("DWORD")] uint dwIdealProcessor
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL SetProcessInformation(
        HANDLE hProcess,
        PROCESS_INFORMATION_CLASS ProcessInformationClass,
        [NativeTypeName("LPVOID")] void* ProcessInformation,
        [NativeTypeName("DWORD")] uint ProcessInformationSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetProcessInformation(
        HANDLE hProcess,
        PROCESS_INFORMATION_CLASS ProcessInformationClass,
        [NativeTypeName("LPVOID")] void* ProcessInformation,
        [NativeTypeName("DWORD")] uint ProcessInformationSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0")]
    public static extern BOOL GetSystemCpuSetInformation(
        [NativeTypeName("PSYSTEM_CPU_SET_INFORMATION")] SYSTEM_CPU_SET_INFORMATION* Information,
        [NativeTypeName("ULONG")] uint BufferLength,
        [NativeTypeName("PULONG")] uint* ReturnedLength,
        HANDLE Process,
        [NativeTypeName("ULONG")] uint Flags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0")]
    public static extern BOOL GetProcessDefaultCpuSets(
        HANDLE Process,
        [NativeTypeName("PULONG")] uint* CpuSetIds,
        [NativeTypeName("ULONG")] uint CpuSetIdCount,
        [NativeTypeName("PULONG")] uint* RequiredIdCount
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0")]
    public static extern BOOL SetProcessDefaultCpuSets(
        HANDLE Process,
        [NativeTypeName("const ULONG *")] uint* CpuSetIds,
        [NativeTypeName("ULONG")] uint CpuSetIdCount
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0")]
    public static extern BOOL GetThreadSelectedCpuSets(
        HANDLE Thread,
        [NativeTypeName("PULONG")] uint* CpuSetIds,
        [NativeTypeName("ULONG")] uint CpuSetIdCount,
        [NativeTypeName("PULONG")] uint* RequiredIdCount
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0")]
    public static extern BOOL SetThreadSelectedCpuSets(
        HANDLE Thread,
        [NativeTypeName("const ULONG *")] uint* CpuSetIds,
        [NativeTypeName("ULONG")] uint CpuSetIdCount
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateProcessAsUserA(
        HANDLE hToken,
        [NativeTypeName("LPCSTR")] sbyte* lpApplicationName,
        [NativeTypeName("LPSTR")] sbyte* lpCommandLine,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpProcessAttributes,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes,
        BOOL bInheritHandles,
        [NativeTypeName("DWORD")] uint dwCreationFlags,
        [NativeTypeName("LPVOID")] void* lpEnvironment,
        [NativeTypeName("LPCSTR")] sbyte* lpCurrentDirectory,
        [NativeTypeName("LPSTARTUPINFOA")] STARTUPINFOA* lpStartupInfo,
        [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetProcessShutdownParameters(
        [NativeTypeName("LPDWORD")] uint* lpdwLevel,
        [NativeTypeName("LPDWORD")] uint* lpdwFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.22000.0")]
    public static extern BOOL GetProcessDefaultCpuSetMasks(
        HANDLE Process,
        [NativeTypeName("PGROUP_AFFINITY")] GROUP_AFFINITY* CpuSetMasks,
        ushort CpuSetMaskCount,
        [NativeTypeName("PUSHORT")] ushort* RequiredMaskCount
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22000.0")]
    public static extern BOOL SetProcessDefaultCpuSetMasks(
        HANDLE Process,
        [NativeTypeName("PGROUP_AFFINITY")] GROUP_AFFINITY* CpuSetMasks,
        ushort CpuSetMaskCount
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.22000.0")]
    public static extern BOOL GetThreadSelectedCpuSetMasks(
        HANDLE Thread,
        [NativeTypeName("PGROUP_AFFINITY")] GROUP_AFFINITY* CpuSetMasks,
        ushort CpuSetMaskCount,
        [NativeTypeName("PUSHORT")] ushort* RequiredMaskCount
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.22000.0")]
    public static extern BOOL SetThreadSelectedCpuSetMasks(
        HANDLE Thread,
        [NativeTypeName("PGROUP_AFFINITY")] GROUP_AFFINITY* CpuSetMasks,
        ushort CpuSetMaskCount
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22000.0")]
    [SupportedOSPlatform("windows10.0.22621.0")]
    public static extern HRESULT GetMachineTypeAttributes(
        ushort Machine,
        MACHINE_ATTRIBUTES* MachineTypeAttributes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.14393.0")]
    public static extern HRESULT SetThreadDescription(
        HANDLE hThread,
        [NativeTypeName("PCWSTR")] ushort* lpThreadDescription
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.14393.0")]
    public static extern HRESULT GetThreadDescription(
        HANDLE hThread,
        [NativeTypeName("PWSTR *")] ushort** ppszThreadDescription
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("LPVOID")]
    public static extern void* TlsGetValue2([NativeTypeName("DWORD")] uint dwTlsIndex);

    [NativeTypeName("#define TLS_OUT_OF_INDEXES ((DWORD)0xFFFFFFFF)")]
    public const uint TLS_OUT_OF_INDEXES = ((uint)(0xFFFFFFFF));

    [NativeTypeName("#define CreateProcess CreateProcessW")]
    public static delegate* <
        ushort*,
        ushort*,
        SECURITY_ATTRIBUTES*,
        SECURITY_ATTRIBUTES*,
        BOOL,
        uint,
        void*,
        ushort*,
        STARTUPINFOW*,
        PROCESS_INFORMATION*,
        BOOL> CreateProcess => &CreateProcessW;

    [NativeTypeName("#define GetStartupInfo GetStartupInfoW")]
    public static delegate* <STARTUPINFOW*, void> GetStartupInfo => &GetStartupInfoW;

    [NativeTypeName("#define CreateProcessAsUser CreateProcessAsUserW")]
    public static delegate* <
        HANDLE,
        ushort*,
        ushort*,
        SECURITY_ATTRIBUTES*,
        SECURITY_ATTRIBUTES*,
        BOOL,
        uint,
        void*,
        ushort*,
        STARTUPINFOW*,
        PROCESS_INFORMATION*,
        BOOL> CreateProcessAsUser => &CreateProcessAsUserW;

    [NativeTypeName("#define PME_CURRENT_VERSION 1")]
    public const int PME_CURRENT_VERSION = 1;

    [NativeTypeName("#define PME_FAILFAST_ON_COMMIT_FAIL_DISABLE 0x0")]
    public const int PME_FAILFAST_ON_COMMIT_FAIL_DISABLE = 0x0;

    [NativeTypeName("#define PME_FAILFAST_ON_COMMIT_FAIL_ENABLE 0x1")]
    public const int PME_FAILFAST_ON_COMMIT_FAIL_ENABLE = 0x1;
}
