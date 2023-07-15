// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.QueueUserAPC"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint QueueUserAPC([NativeTypeName("PAPCFUNC")] delegate* unmanaged<nuint, void> pfnAPC, HANDLE hThread, [NativeTypeName("ULONG_PTR")] nuint dwData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.QueueUserAPC2"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL QueueUserAPC2([NativeTypeName("PAPCFUNC")] delegate* unmanaged<nuint, void> ApcRoutine, HANDLE Thread, [NativeTypeName("ULONG_PTR")] nuint Data, QUEUE_USER_APC_FLAGS Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProcessTimes"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetProcessTimes(HANDLE hProcess, [NativeTypeName("LPFILETIME")] FILETIME* lpCreationTime, [NativeTypeName("LPFILETIME")] FILETIME* lpExitTime, [NativeTypeName("LPFILETIME")] FILETIME* lpKernelTime, [NativeTypeName("LPFILETIME")] FILETIME* lpUserTime);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentProcess"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HANDLE GetCurrentProcess();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentProcessId"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetCurrentProcessId();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExitProcess"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void ExitProcess(uint uExitCode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TerminateProcess"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL TerminateProcess(HANDLE hProcess, uint uExitCode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetExitCodeProcess"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetExitCodeProcess(HANDLE hProcess, [NativeTypeName("LPDWORD")] uint* lpExitCode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SwitchToThread"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL SwitchToThread();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateThread"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateThread([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, [NativeTypeName("SIZE_T")] nuint dwStackSize, [NativeTypeName("LPTHREAD_START_ROUTINE")] delegate* unmanaged<void*, uint> lpStartAddress, [NativeTypeName("LPVOID")] void* lpParameter, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPDWORD")] uint* lpThreadId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateRemoteThread"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateRemoteThread(HANDLE hProcess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, [NativeTypeName("SIZE_T")] nuint dwStackSize, [NativeTypeName("LPTHREAD_START_ROUTINE")] delegate* unmanaged<void*, uint> lpStartAddress, [NativeTypeName("LPVOID")] void* lpParameter, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPDWORD")] uint* lpThreadId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentThread"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HANDLE GetCurrentThread();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentThreadId"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SuppressGCTransition]
    public static extern uint GetCurrentThreadId();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenThread"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenThread([NativeTypeName("DWORD")] uint dwDesiredAccess, BOOL bInheritHandle, [NativeTypeName("DWORD")] uint dwThreadId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThreadPriority"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetThreadPriority(HANDLE hThread, int nPriority);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThreadPriorityBoost"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetThreadPriorityBoost(HANDLE hThread, BOOL bDisablePriorityBoost);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThreadPriorityBoost"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetThreadPriorityBoost(HANDLE hThread, [NativeTypeName("PBOOL")] BOOL* pDisablePriorityBoost);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThreadPriority"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int GetThreadPriority(HANDLE hThread);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExitThread"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void ExitThread([NativeTypeName("DWORD")] uint dwExitCode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TerminateThread"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL TerminateThread(HANDLE hThread, [NativeTypeName("DWORD")] uint dwExitCode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetExitCodeThread"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetExitCodeThread(HANDLE hThread, [NativeTypeName("LPDWORD")] uint* lpExitCode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SuspendThread"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint SuspendThread(HANDLE hThread);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ResumeThread"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint ResumeThread(HANDLE hThread);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TlsAlloc"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint TlsAlloc();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TlsGetValue"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPVOID")]
    public static extern void* TlsGetValue([NativeTypeName("DWORD")] uint dwTlsIndex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TlsSetValue"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL TlsSetValue([NativeTypeName("DWORD")] uint dwTlsIndex, [NativeTypeName("LPVOID")] void* lpTlsValue);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TlsFree"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL TlsFree([NativeTypeName("DWORD")] uint dwTlsIndex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateProcessA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateProcessA([NativeTypeName("LPCSTR")] sbyte* lpApplicationName, [NativeTypeName("LPSTR")] sbyte* lpCommandLine, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpProcessAttributes, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, BOOL bInheritHandles, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPVOID")] void* lpEnvironment, [NativeTypeName("LPCSTR")] sbyte* lpCurrentDirectory, [NativeTypeName("LPSTARTUPINFOA")] STARTUPINFOA* lpStartupInfo, [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateProcessW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateProcessW([NativeTypeName("LPCWSTR")] ushort* lpApplicationName, [NativeTypeName("LPWSTR")] ushort* lpCommandLine, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpProcessAttributes, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, BOOL bInheritHandles, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPVOID")] void* lpEnvironment, [NativeTypeName("LPCWSTR")] ushort* lpCurrentDirectory, [NativeTypeName("LPSTARTUPINFOW")] STARTUPINFOW* lpStartupInfo, [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetProcessShutdownParameters"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetProcessShutdownParameters([NativeTypeName("DWORD")] uint dwLevel, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProcessVersion"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetProcessVersion([NativeTypeName("DWORD")] uint ProcessId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetStartupInfoW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void GetStartupInfoW([NativeTypeName("LPSTARTUPINFOW")] STARTUPINFOW* lpStartupInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateProcessAsUserW"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateProcessAsUserW(HANDLE hToken, [NativeTypeName("LPCWSTR")] ushort* lpApplicationName, [NativeTypeName("LPWSTR")] ushort* lpCommandLine, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpProcessAttributes, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, BOOL bInheritHandles, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPVOID")] void* lpEnvironment, [NativeTypeName("LPCWSTR")] ushort* lpCurrentDirectory, [NativeTypeName("LPSTARTUPINFOW")] STARTUPINFOW* lpStartupInfo, [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThreadToken"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetThreadToken([NativeTypeName("PHANDLE")] HANDLE* Thread, HANDLE Token);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenProcessToken"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL OpenProcessToken(HANDLE ProcessHandle, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("PHANDLE")] HANDLE* TokenHandle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenThreadToken"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL OpenThreadToken(HANDLE ThreadHandle, [NativeTypeName("DWORD")] uint DesiredAccess, BOOL OpenAsSelf, [NativeTypeName("PHANDLE")] HANDLE* TokenHandle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetPriorityClass"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetPriorityClass(HANDLE hProcess, [NativeTypeName("DWORD")] uint dwPriorityClass);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPriorityClass"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetPriorityClass(HANDLE hProcess);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThreadStackGuarantee"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetThreadStackGuarantee([NativeTypeName("PULONG")] uint* StackSizeInBytes);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ProcessIdToSessionId"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ProcessIdToSessionId([NativeTypeName("DWORD")] uint dwProcessId, [NativeTypeName("DWORD *")] uint* pSessionId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProcessId"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetProcessId(HANDLE Process);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThreadId"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetThreadId(HANDLE Thread);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlushProcessWriteBuffers"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void FlushProcessWriteBuffers();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProcessIdOfThread"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetProcessIdOfThread(HANDLE Thread);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitializeProcThreadAttributeList"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InitializeProcThreadAttributeList(LPPROC_THREAD_ATTRIBUTE_LIST lpAttributeList, [NativeTypeName("DWORD")] uint dwAttributeCount, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PSIZE_T")] nuint* lpSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeleteProcThreadAttributeList"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void DeleteProcThreadAttributeList(LPPROC_THREAD_ATTRIBUTE_LIST lpAttributeList);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UpdateProcThreadAttribute"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UpdateProcThreadAttribute(LPPROC_THREAD_ATTRIBUTE_LIST lpAttributeList, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint Attribute, [NativeTypeName("PVOID")] void* lpValue, [NativeTypeName("SIZE_T")] nuint cbSize, [NativeTypeName("PVOID")] void* lpPreviousValue, [NativeTypeName("PSIZE_T")] nuint* lpReturnSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetProcessDynamicEHContinuationTargets"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL SetProcessDynamicEHContinuationTargets(HANDLE Process, ushort NumberOfTargets, [NativeTypeName("PPROCESS_DYNAMIC_EH_CONTINUATION_TARGET")] PROCESS_DYNAMIC_EH_CONTINUATION_TARGET* Targets);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetProcessDynamicEnforcedCetCompatibleRanges"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19041.0")]
    public static extern BOOL SetProcessDynamicEnforcedCetCompatibleRanges(HANDLE Process, ushort NumberOfRanges, [NativeTypeName("PPROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE")] PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE* Ranges);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetProcessAffinityUpdateMode"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetProcessAffinityUpdateMode(HANDLE hProcess, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.QueryProcessAffinityUpdateMode"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL QueryProcessAffinityUpdateMode(HANDLE hProcess, [NativeTypeName("LPDWORD")] uint* lpdwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateRemoteThreadEx"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateRemoteThreadEx(HANDLE hProcess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, [NativeTypeName("SIZE_T")] nuint dwStackSize, [NativeTypeName("LPTHREAD_START_ROUTINE")] delegate* unmanaged<void*, uint> lpStartAddress, [NativeTypeName("LPVOID")] void* lpParameter, [NativeTypeName("DWORD")] uint dwCreationFlags, LPPROC_THREAD_ATTRIBUTE_LIST lpAttributeList, [NativeTypeName("LPDWORD")] uint* lpThreadId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentThreadStackLimits"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern void GetCurrentThreadStackLimits([NativeTypeName("PULONG_PTR")] nuint* LowLimit, [NativeTypeName("PULONG_PTR")] nuint* HighLimit);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThreadContext"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetThreadContext(HANDLE hThread, [NativeTypeName("LPCONTEXT")] void* lpContext);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProcessMitigationPolicy"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetProcessMitigationPolicy(HANDLE hProcess, PROCESS_MITIGATION_POLICY MitigationPolicy, [NativeTypeName("PVOID")] void* lpBuffer, [NativeTypeName("SIZE_T")] nuint dwLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThreadContext"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetThreadContext(HANDLE hThread, [NativeTypeName("const CONTEXT *")] void* lpContext);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetProcessMitigationPolicy"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL SetProcessMitigationPolicy(PROCESS_MITIGATION_POLICY MitigationPolicy, [NativeTypeName("PVOID")] void* lpBuffer, [NativeTypeName("SIZE_T")] nuint dwLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlushInstructionCache"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FlushInstructionCache(HANDLE hProcess, [NativeTypeName("LPCVOID")] void* lpBaseAddress, [NativeTypeName("SIZE_T")] nuint dwSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThreadTimes"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetThreadTimes(HANDLE hThread, [NativeTypeName("LPFILETIME")] FILETIME* lpCreationTime, [NativeTypeName("LPFILETIME")] FILETIME* lpExitTime, [NativeTypeName("LPFILETIME")] FILETIME* lpKernelTime, [NativeTypeName("LPFILETIME")] FILETIME* lpUserTime);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenProcess"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenProcess([NativeTypeName("DWORD")] uint dwDesiredAccess, BOOL bInheritHandle, [NativeTypeName("DWORD")] uint dwProcessId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsProcessorFeaturePresent"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL IsProcessorFeaturePresent([NativeTypeName("DWORD")] uint ProcessorFeature);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProcessHandleCount"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetProcessHandleCount(HANDLE hProcess, [NativeTypeName("PDWORD")] uint* pdwHandleCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentProcessorNumber"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetCurrentProcessorNumber();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThreadIdealProcessorEx"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetThreadIdealProcessorEx(HANDLE hThread, [NativeTypeName("PPROCESSOR_NUMBER")] PROCESSOR_NUMBER* lpIdealProcessor, [NativeTypeName("PPROCESSOR_NUMBER")] PROCESSOR_NUMBER* lpPreviousIdealProcessor);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThreadIdealProcessorEx"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetThreadIdealProcessorEx(HANDLE hThread, [NativeTypeName("PPROCESSOR_NUMBER")] PROCESSOR_NUMBER* lpIdealProcessor);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentProcessorNumberEx"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void GetCurrentProcessorNumberEx([NativeTypeName("PPROCESSOR_NUMBER")] PROCESSOR_NUMBER* ProcNumber);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProcessPriorityBoost"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetProcessPriorityBoost(HANDLE hProcess, [NativeTypeName("PBOOL")] BOOL* pDisablePriorityBoost);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetProcessPriorityBoost"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetProcessPriorityBoost(HANDLE hProcess, BOOL bDisablePriorityBoost);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThreadIOPendingFlag"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetThreadIOPendingFlag(HANDLE hThread, [NativeTypeName("PBOOL")] BOOL* lpIOIsPending);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSystemTimes"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetSystemTimes([NativeTypeName("PFILETIME")] FILETIME* lpIdleTime, [NativeTypeName("PFILETIME")] FILETIME* lpKernelTime, [NativeTypeName("PFILETIME")] FILETIME* lpUserTime);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThreadInformation"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetThreadInformation(HANDLE hThread, THREAD_INFORMATION_CLASS ThreadInformationClass, [NativeTypeName("LPVOID")] void* ThreadInformation, [NativeTypeName("DWORD")] uint ThreadInformationSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThreadInformation"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL SetThreadInformation(HANDLE hThread, THREAD_INFORMATION_CLASS ThreadInformationClass, [NativeTypeName("LPVOID")] void* ThreadInformation, [NativeTypeName("DWORD")] uint ThreadInformationSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsProcessCritical"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.3")]
    public static extern BOOL IsProcessCritical(HANDLE hProcess, [NativeTypeName("PBOOL")] BOOL* Critical);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetProtectedPolicy"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern BOOL SetProtectedPolicy([NativeTypeName("LPCGUID")] Guid* PolicyGuid, [NativeTypeName("ULONG_PTR")] nuint PolicyValue, [NativeTypeName("PULONG_PTR")] nuint* OldPolicyValue);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.QueryProtectedPolicy"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern BOOL QueryProtectedPolicy([NativeTypeName("LPCGUID")] Guid* PolicyGuid, [NativeTypeName("PULONG_PTR")] nuint* PolicyValue);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThreadIdealProcessor"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetThreadIdealProcessor(HANDLE hThread, [NativeTypeName("DWORD")] uint dwIdealProcessor);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetProcessInformation"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL SetProcessInformation(HANDLE hProcess, PROCESS_INFORMATION_CLASS ProcessInformationClass, [NativeTypeName("LPVOID")] void* ProcessInformation, [NativeTypeName("DWORD")] uint ProcessInformationSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProcessInformation"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetProcessInformation(HANDLE hProcess, PROCESS_INFORMATION_CLASS ProcessInformationClass, [NativeTypeName("LPVOID")] void* ProcessInformation, [NativeTypeName("DWORD")] uint ProcessInformationSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSystemCpuSetInformation"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0")]
    public static extern BOOL GetSystemCpuSetInformation([NativeTypeName("PSYSTEM_CPU_SET_INFORMATION")] SYSTEM_CPU_SET_INFORMATION* Information, [NativeTypeName("ULONG")] uint BufferLength, [NativeTypeName("PULONG")] uint* ReturnedLength, HANDLE Process, [NativeTypeName("ULONG")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProcessDefaultCpuSets"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0")]
    public static extern BOOL GetProcessDefaultCpuSets(HANDLE Process, [NativeTypeName("PULONG")] uint* CpuSetIds, [NativeTypeName("ULONG")] uint CpuSetIdCount, [NativeTypeName("PULONG")] uint* RequiredIdCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetProcessDefaultCpuSets"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0")]
    public static extern BOOL SetProcessDefaultCpuSets(HANDLE Process, [NativeTypeName("const ULONG *")] uint* CpuSetIds, [NativeTypeName("ULONG")] uint CpuSetIdCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThreadSelectedCpuSets"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0")]
    public static extern BOOL GetThreadSelectedCpuSets(HANDLE Thread, [NativeTypeName("PULONG")] uint* CpuSetIds, [NativeTypeName("ULONG")] uint CpuSetIdCount, [NativeTypeName("PULONG")] uint* RequiredIdCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThreadSelectedCpuSets"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0")]
    public static extern BOOL SetThreadSelectedCpuSets(HANDLE Thread, [NativeTypeName("const ULONG *")] uint* CpuSetIds, [NativeTypeName("ULONG")] uint CpuSetIdCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateProcessAsUserA"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateProcessAsUserA(HANDLE hToken, [NativeTypeName("LPCSTR")] sbyte* lpApplicationName, [NativeTypeName("LPSTR")] sbyte* lpCommandLine, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpProcessAttributes, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, BOOL bInheritHandles, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPVOID")] void* lpEnvironment, [NativeTypeName("LPCSTR")] sbyte* lpCurrentDirectory, [NativeTypeName("LPSTARTUPINFOA")] STARTUPINFOA* lpStartupInfo, [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProcessShutdownParameters"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetProcessShutdownParameters([NativeTypeName("LPDWORD")] uint* lpdwLevel, [NativeTypeName("LPDWORD")] uint* lpdwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProcessDefaultCpuSetMasks"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetProcessDefaultCpuSetMasks(HANDLE Process, [NativeTypeName("PGROUP_AFFINITY")] GROUP_AFFINITY* CpuSetMasks, ushort CpuSetMaskCount, [NativeTypeName("PUSHORT")] ushort* RequiredMaskCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetProcessDefaultCpuSetMasks"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL SetProcessDefaultCpuSetMasks(HANDLE Process, [NativeTypeName("PGROUP_AFFINITY")] GROUP_AFFINITY* CpuSetMasks, ushort CpuSetMaskCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThreadSelectedCpuSetMasks"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetThreadSelectedCpuSetMasks(HANDLE Thread, [NativeTypeName("PGROUP_AFFINITY")] GROUP_AFFINITY* CpuSetMasks, ushort CpuSetMaskCount, [NativeTypeName("PUSHORT")] ushort* RequiredMaskCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThreadSelectedCpuSetMasks"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetThreadSelectedCpuSetMasks(HANDLE Thread, [NativeTypeName("PGROUP_AFFINITY")] GROUP_AFFINITY* CpuSetMasks, ushort CpuSetMaskCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMachineTypeAttributes"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22621.0")]
    public static extern HRESULT GetMachineTypeAttributes(ushort Machine, MACHINE_ATTRIBUTES* MachineTypeAttributes);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThreadDescription"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.14393.0")]
    public static extern HRESULT SetThreadDescription(HANDLE hThread, [NativeTypeName("PCWSTR")] ushort* lpThreadDescription);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThreadDescription"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.14393.0")]
    public static extern HRESULT GetThreadDescription(HANDLE hThread, [NativeTypeName("PWSTR *")] ushort** ppszThreadDescription);
    [NativeTypeName("#define TLS_OUT_OF_INDEXES ((DWORD)0xFFFFFFFF)")]
    public const uint TLS_OUT_OF_INDEXES = ((uint)(0xFFFFFFFF));
    [NativeTypeName("#define CreateProcess CreateProcessW")]
    public static delegate*<ushort*, ushort*, SECURITY_ATTRIBUTES*, SECURITY_ATTRIBUTES*, BOOL, uint, void*, ushort*, STARTUPINFOW*, PROCESS_INFORMATION*, BOOL> CreateProcess => &CreateProcessW;

    [NativeTypeName("#define GetStartupInfo GetStartupInfoW")]
    public static delegate*<STARTUPINFOW*, void> GetStartupInfo => &GetStartupInfoW;

    [NativeTypeName("#define CreateProcessAsUser CreateProcessAsUserW")]
    public static delegate*<HANDLE, ushort*, ushort*, SECURITY_ATTRIBUTES*, SECURITY_ATTRIBUTES*, BOOL, uint, void*, ushort*, STARTUPINFOW*, PROCESS_INFORMATION*, BOOL> CreateProcessAsUser => &CreateProcessAsUserW;

    [NativeTypeName("#define PME_CURRENT_VERSION 1")]
    public const int PME_CURRENT_VERSION = 1;
    [NativeTypeName("#define PME_FAILFAST_ON_COMMIT_FAIL_DISABLE 0x0")]
    public const int PME_FAILFAST_ON_COMMIT_FAIL_DISABLE = 0x0;
    [NativeTypeName("#define PME_FAILFAST_ON_COMMIT_FAIL_ENABLE 0x1")]
    public const int PME_FAILFAST_ON_COMMIT_FAIL_ENABLE = 0x1;
}