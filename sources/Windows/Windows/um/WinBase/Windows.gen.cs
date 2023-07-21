// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GlobalAlloc"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HGLOBAL GlobalAlloc(uint uFlags, [NativeTypeName("SIZE_T")] nuint dwBytes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GlobalReAlloc"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HGLOBAL GlobalReAlloc(HGLOBAL hMem, [NativeTypeName("SIZE_T")] nuint dwBytes, uint uFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GlobalSize"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("SIZE_T")]
    public static extern nuint GlobalSize(HGLOBAL hMem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GlobalUnlock"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GlobalUnlock(HGLOBAL hMem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GlobalLock"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPVOID")]
    public static extern void* GlobalLock(HGLOBAL hMem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GlobalFlags"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GlobalFlags(HGLOBAL hMem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GlobalHandle"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HGLOBAL GlobalHandle([NativeTypeName("LPCVOID")] void* pMem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GlobalFree"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HGLOBAL GlobalFree(HGLOBAL hMem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GlobalCompact"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("SIZE_T")]
    public static extern nuint GlobalCompact([NativeTypeName("DWORD")] uint dwMinFree);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GlobalFix"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void GlobalFix(HGLOBAL hMem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GlobalUnfix"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void GlobalUnfix(HGLOBAL hMem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GlobalWire"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LPVOID")]
    public static extern void* GlobalWire(HGLOBAL hMem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GlobalUnWire"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL GlobalUnWire(HGLOBAL hMem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GlobalMemoryStatus"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void GlobalMemoryStatus([NativeTypeName("LPMEMORYSTATUS")] MEMORYSTATUS* lpBuffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LocalAlloc"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HLOCAL LocalAlloc(uint uFlags, [NativeTypeName("SIZE_T")] nuint uBytes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LocalReAlloc"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HLOCAL LocalReAlloc(HLOCAL hMem, [NativeTypeName("SIZE_T")] nuint uBytes, uint uFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LocalLock"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPVOID")]
    public static extern void* LocalLock(HLOCAL hMem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LocalHandle"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HLOCAL LocalHandle([NativeTypeName("LPCVOID")] void* pMem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LocalUnlock"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LocalUnlock(HLOCAL hMem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LocalSize"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("SIZE_T")]
    public static extern nuint LocalSize(HLOCAL hMem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LocalFlags"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint LocalFlags(HLOCAL hMem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LocalFree"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HLOCAL LocalFree(HLOCAL hMem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LocalShrink"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("SIZE_T")]
    public static extern nuint LocalShrink(HLOCAL hMem, uint cbNewSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LocalCompact"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("SIZE_T")]
    public static extern nuint LocalCompact(uint uMinFree);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetBinaryTypeA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetBinaryTypeA([NativeTypeName("LPCSTR")] sbyte* lpApplicationName, [NativeTypeName("LPDWORD")] uint* lpBinaryType);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetBinaryTypeW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetBinaryTypeW([NativeTypeName("LPCWSTR")] ushort* lpApplicationName, [NativeTypeName("LPDWORD")] uint* lpBinaryType);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetShortPathNameA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetShortPathNameA([NativeTypeName("LPCSTR")] sbyte* lpszLongPath, [NativeTypeName("LPSTR")] sbyte* lpszShortPath, [NativeTypeName("DWORD")] uint cchBuffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetLongPathNameTransactedA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetLongPathNameTransactedA([NativeTypeName("LPCSTR")] sbyte* lpszShortPath, [NativeTypeName("LPSTR")] sbyte* lpszLongPath, [NativeTypeName("DWORD")] uint cchBuffer, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetLongPathNameTransactedW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetLongPathNameTransactedW([NativeTypeName("LPCWSTR")] ushort* lpszShortPath, [NativeTypeName("LPWSTR")] ushort* lpszLongPath, [NativeTypeName("DWORD")] uint cchBuffer, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProcessAffinityMask"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetProcessAffinityMask(HANDLE hProcess, [NativeTypeName("PDWORD_PTR")] nuint* lpProcessAffinityMask, [NativeTypeName("PDWORD_PTR")] nuint* lpSystemAffinityMask);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetProcessAffinityMask"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetProcessAffinityMask(HANDLE hProcess, [NativeTypeName("DWORD_PTR")] nuint dwProcessAffinityMask);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProcessIoCounters"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetProcessIoCounters(HANDLE hProcess, [NativeTypeName("PIO_COUNTERS")] IO_COUNTERS* lpIoCounters);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FatalExit"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void FatalExit(int ExitCode);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetEnvironmentStringsA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL SetEnvironmentStringsA([NativeTypeName("LPCH")] sbyte* NewEnvironment);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SwitchToFiber"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void SwitchToFiber([NativeTypeName("LPVOID")] void* lpFiber);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeleteFiber"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void DeleteFiber([NativeTypeName("LPVOID")] void* lpFiber);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ConvertFiberToThread"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ConvertFiberToThread();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateFiberEx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPVOID")]
    public static extern void* CreateFiberEx([NativeTypeName("SIZE_T")] nuint dwStackCommitSize, [NativeTypeName("SIZE_T")] nuint dwStackReserveSize, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPFIBER_START_ROUTINE")] delegate* unmanaged<void*, void> lpStartAddress, [NativeTypeName("LPVOID")] void* lpParameter);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ConvertThreadToFiberEx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPVOID")]
    public static extern void* ConvertThreadToFiberEx([NativeTypeName("LPVOID")] void* lpParameter, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateFiber"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPVOID")]
    public static extern void* CreateFiber([NativeTypeName("SIZE_T")] nuint dwStackSize, [NativeTypeName("LPFIBER_START_ROUTINE")] delegate* unmanaged<void*, void> lpStartAddress, [NativeTypeName("LPVOID")] void* lpParameter);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ConvertThreadToFiber"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPVOID")]
    public static extern void* ConvertThreadToFiber([NativeTypeName("LPVOID")] void* lpParameter);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateUmsCompletionList"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateUmsCompletionList([NativeTypeName("PUMS_COMPLETION_LIST *")] void** UmsCompletionList);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DequeueUmsCompletionListItems"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DequeueUmsCompletionListItems([NativeTypeName("PUMS_COMPLETION_LIST")] void* UmsCompletionList, [NativeTypeName("DWORD")] uint WaitTimeOut, [NativeTypeName("PUMS_CONTEXT *")] void** UmsThreadList);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetUmsCompletionListEvent"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetUmsCompletionListEvent([NativeTypeName("PUMS_COMPLETION_LIST")] void* UmsCompletionList, [NativeTypeName("PHANDLE")] HANDLE* UmsCompletionEvent);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExecuteUmsThread"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ExecuteUmsThread([NativeTypeName("PUMS_CONTEXT")] void* UmsThread);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UmsThreadYield"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UmsThreadYield([NativeTypeName("PVOID")] void* SchedulerParam);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeleteUmsCompletionList"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeleteUmsCompletionList([NativeTypeName("PUMS_COMPLETION_LIST")] void* UmsCompletionList);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentUmsThread"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PUMS_CONTEXT")]
    public static extern void* GetCurrentUmsThread();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetNextUmsListItem"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PUMS_CONTEXT")]
    public static extern void* GetNextUmsListItem([NativeTypeName("PUMS_CONTEXT")] void* UmsContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.QueryUmsThreadInformation"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL QueryUmsThreadInformation([NativeTypeName("PUMS_CONTEXT")] void* UmsThread, UMS_THREAD_INFO_CLASS UmsThreadInfoClass, [NativeTypeName("PVOID")] void* UmsThreadInformation, [NativeTypeName("ULONG")] uint UmsThreadInformationLength, [NativeTypeName("PULONG")] uint* ReturnLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetUmsThreadInformation"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetUmsThreadInformation([NativeTypeName("PUMS_CONTEXT")] void* UmsThread, UMS_THREAD_INFO_CLASS UmsThreadInfoClass, [NativeTypeName("PVOID")] void* UmsThreadInformation, [NativeTypeName("ULONG")] uint UmsThreadInformationLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeleteUmsThreadContext"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeleteUmsThreadContext([NativeTypeName("PUMS_CONTEXT")] void* UmsThread);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateUmsThreadContext"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateUmsThreadContext([NativeTypeName("PUMS_CONTEXT *")] void** lpUmsThread);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnterUmsSchedulingMode"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnterUmsSchedulingMode([NativeTypeName("PUMS_SCHEDULER_STARTUP_INFO")] UMS_SCHEDULER_STARTUP_INFO* SchedulerStartupInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetUmsSystemThreadInformation"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL GetUmsSystemThreadInformation(HANDLE ThreadHandle, [NativeTypeName("PUMS_SYSTEM_THREAD_INFORMATION")] UMS_SYSTEM_THREAD_INFORMATION* SystemThreadInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThreadAffinityMask"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD_PTR")]
    public static extern nuint SetThreadAffinityMask(HANDLE hThread, [NativeTypeName("DWORD_PTR")] nuint dwThreadAffinityMask);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetProcessDEPPolicy"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetProcessDEPPolicy([NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProcessDEPPolicy"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetProcessDEPPolicy(HANDLE hProcess, [NativeTypeName("LPDWORD")] uint* lpFlags, [NativeTypeName("PBOOL")] BOOL* lpPermanent);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RequestWakeupLatency"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL RequestWakeupLatency(LATENCY_TIME latency);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsSystemResumeAutomatic"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL IsSystemResumeAutomatic();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThreadSelectorEntry"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetThreadSelectorEntry(HANDLE hThread, [NativeTypeName("DWORD")] uint dwSelector, [NativeTypeName("LPLDT_ENTRY")] void* lpSelectorEntry);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThreadExecutionState"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("EXECUTION_STATE")]
    public static extern uint SetThreadExecutionState([NativeTypeName("EXECUTION_STATE")] uint esFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PowerCreateRequest"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE PowerCreateRequest([NativeTypeName("PREASON_CONTEXT")] REASON_CONTEXT* Context);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PowerSetRequest"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PowerSetRequest(HANDLE PowerRequest, POWER_REQUEST_TYPE RequestType);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PowerClearRequest"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PowerClearRequest(HANDLE PowerRequest, POWER_REQUEST_TYPE RequestType);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetFileCompletionNotificationModes"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileCompletionNotificationModes(HANDLE FileHandle, [NativeTypeName("UCHAR")] byte Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Wow64GetThreadSelectorEntry"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL Wow64GetThreadSelectorEntry(HANDLE hThread, [NativeTypeName("DWORD")] uint dwSelector, [NativeTypeName("PWOW64_LDT_ENTRY")] WOW64_LDT_ENTRY* lpSelectorEntry);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DebugSetProcessKillOnExit"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DebugSetProcessKillOnExit(BOOL KillOnExit);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DebugBreakProcess"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DebugBreakProcess(HANDLE Process);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PulseEvent"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PulseEvent(HANDLE hEvent);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GlobalDeleteAtom"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort GlobalDeleteAtom([NativeTypeName("ATOM")] ushort nAtom);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitAtomTable"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL InitAtomTable([NativeTypeName("DWORD")] uint nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeleteAtom"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort DeleteAtom([NativeTypeName("ATOM")] ushort nAtom);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetHandleCount"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern uint SetHandleCount(uint uNumber);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RequestDeviceWakeup"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL RequestDeviceWakeup(HANDLE hDevice);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CancelDeviceWakeupRequest"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL CancelDeviceWakeupRequest(HANDLE hDevice);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDevicePowerState"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL GetDevicePowerState(HANDLE hDevice, BOOL* pfOn);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetMessageWaitingIndicator"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL SetMessageWaitingIndicator(HANDLE hMsgIndicator, [NativeTypeName("ULONG")] uint ulMsgCount);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetFileShortNameA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileShortNameA(HANDLE hFile, [NativeTypeName("LPCSTR")] sbyte* lpShortName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetFileShortNameW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileShortNameW(HANDLE hFile, [NativeTypeName("LPCWSTR")] ushort* lpShortName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadModule"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint LoadModule([NativeTypeName("LPCSTR")] sbyte* lpModuleName, [NativeTypeName("LPVOID")] void* lpParameterBlock);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WinExec"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern uint WinExec([NativeTypeName("LPCSTR")] sbyte* lpCmdLine, uint uCmdShow);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ClearCommBreak"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ClearCommBreak(HANDLE hFile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ClearCommError"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ClearCommError(HANDLE hFile, [NativeTypeName("LPDWORD")] uint* lpErrors, [NativeTypeName("LPCOMSTAT")] COMSTAT* lpStat);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupComm"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupComm(HANDLE hFile, [NativeTypeName("DWORD")] uint dwInQueue, [NativeTypeName("DWORD")] uint dwOutQueue);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EscapeCommFunction"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EscapeCommFunction(HANDLE hFile, [NativeTypeName("DWORD")] uint dwFunc);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCommConfig"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetCommConfig(HANDLE hCommDev, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC, [NativeTypeName("LPDWORD")] uint* lpdwSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCommMask"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetCommMask(HANDLE hFile, [NativeTypeName("LPDWORD")] uint* lpEvtMask);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCommProperties"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetCommProperties(HANDLE hFile, [NativeTypeName("LPCOMMPROP")] COMMPROP* lpCommProp);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCommModemStatus"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetCommModemStatus(HANDLE hFile, [NativeTypeName("LPDWORD")] uint* lpModemStat);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCommState"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetCommState(HANDLE hFile, [NativeTypeName("LPDCB")] DCB* lpDCB);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCommTimeouts"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetCommTimeouts(HANDLE hFile, [NativeTypeName("LPCOMMTIMEOUTS")] COMMTIMEOUTS* lpCommTimeouts);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PurgeComm"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PurgeComm(HANDLE hFile, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetCommBreak"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetCommBreak(HANDLE hFile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetCommConfig"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetCommConfig(HANDLE hCommDev, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC, [NativeTypeName("DWORD")] uint dwSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetCommMask"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetCommMask(HANDLE hFile, [NativeTypeName("DWORD")] uint dwEvtMask);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetCommState"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetCommState(HANDLE hFile, [NativeTypeName("LPDCB")] DCB* lpDCB);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetCommTimeouts"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetCommTimeouts(HANDLE hFile, [NativeTypeName("LPCOMMTIMEOUTS")] COMMTIMEOUTS* lpCommTimeouts);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TransmitCommChar"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL TransmitCommChar(HANDLE hFile, [NativeTypeName("char")] sbyte cChar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WaitCommEvent"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WaitCommEvent(HANDLE hFile, [NativeTypeName("LPDWORD")] uint* lpEvtMask, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenCommPort"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.16299.0")]
    public static extern HANDLE OpenCommPort([NativeTypeName("ULONG")] uint uPortNumber, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCommPorts"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    [SupportedOSPlatform("windows10.0.17134.0")]
    public static extern uint GetCommPorts([NativeTypeName("PULONG")] uint* lpPortNumbers, [NativeTypeName("ULONG")] uint uPortNumbersCount, [NativeTypeName("PULONG")] uint* puPortNumbersFound);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetTapePosition"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetTapePosition(HANDLE hDevice, [NativeTypeName("DWORD")] uint dwPositionMethod, [NativeTypeName("DWORD")] uint dwPartition, [NativeTypeName("DWORD")] uint dwOffsetLow, [NativeTypeName("DWORD")] uint dwOffsetHigh, BOOL bImmediate);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTapePosition"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetTapePosition(HANDLE hDevice, [NativeTypeName("DWORD")] uint dwPositionType, [NativeTypeName("LPDWORD")] uint* lpdwPartition, [NativeTypeName("LPDWORD")] uint* lpdwOffsetLow, [NativeTypeName("LPDWORD")] uint* lpdwOffsetHigh);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrepareTape"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint PrepareTape(HANDLE hDevice, [NativeTypeName("DWORD")] uint dwOperation, BOOL bImmediate);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EraseTape"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint EraseTape(HANDLE hDevice, [NativeTypeName("DWORD")] uint dwEraseType, BOOL bImmediate);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateTapePartition"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CreateTapePartition(HANDLE hDevice, [NativeTypeName("DWORD")] uint dwPartitionMethod, [NativeTypeName("DWORD")] uint dwCount, [NativeTypeName("DWORD")] uint dwSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WriteTapemark"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WriteTapemark(HANDLE hDevice, [NativeTypeName("DWORD")] uint dwTapemarkType, [NativeTypeName("DWORD")] uint dwTapemarkCount, BOOL bImmediate);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTapeStatus"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetTapeStatus(HANDLE hDevice);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTapeParameters"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetTapeParameters(HANDLE hDevice, [NativeTypeName("DWORD")] uint dwOperation, [NativeTypeName("LPDWORD")] uint* lpdwSize, [NativeTypeName("LPVOID")] void* lpTapeInformation);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetTapeParameters"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetTapeParameters(HANDLE hDevice, [NativeTypeName("DWORD")] uint dwOperation, [NativeTypeName("LPVOID")] void* lpTapeInformation);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MulDiv"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern int MulDiv(int nNumber, int nNumerator, int nDenominator);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSystemDEPPolicy"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern DEP_SYSTEM_POLICY_TYPE GetSystemDEPPolicy();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSystemRegistryQuota"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetSystemRegistryQuota([NativeTypeName("PDWORD")] uint* pdwQuotaAllowed, [NativeTypeName("PDWORD")] uint* pdwQuotaUsed);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FileTimeToDosDateTime"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FileTimeToDosDateTime([NativeTypeName("const FILETIME *")] FILETIME* lpFileTime, [NativeTypeName("LPWORD")] ushort* lpFatDate, [NativeTypeName("LPWORD")] ushort* lpFatTime);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DosDateTimeToFileTime"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DosDateTimeToFileTime([NativeTypeName("WORD")] ushort wFatDate, [NativeTypeName("WORD")] ushort wFatTime, [NativeTypeName("LPFILETIME")] FILETIME* lpFileTime);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FormatMessageA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint FormatMessageA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCVOID")] void* lpSource, [NativeTypeName("DWORD")] uint dwMessageId, [NativeTypeName("DWORD")] uint dwLanguageId, [NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("va_list *")] sbyte** Arguments);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FormatMessageW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint FormatMessageW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCVOID")] void* lpSource, [NativeTypeName("DWORD")] uint dwMessageId, [NativeTypeName("DWORD")] uint dwLanguageId, [NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("va_list *")] sbyte** Arguments);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateMailslotA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateMailslotA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint nMaxMessageSize, [NativeTypeName("DWORD")] uint lReadTimeout, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateMailslotW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateMailslotW([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("DWORD")] uint nMaxMessageSize, [NativeTypeName("DWORD")] uint lReadTimeout, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMailslotInfo"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetMailslotInfo(HANDLE hMailslot, [NativeTypeName("LPDWORD")] uint* lpMaxMessageSize, [NativeTypeName("LPDWORD")] uint* lpNextSize, [NativeTypeName("LPDWORD")] uint* lpMessageCount, [NativeTypeName("LPDWORD")] uint* lpReadTimeout);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetMailslotInfo"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetMailslotInfo(HANDLE hMailslot, [NativeTypeName("DWORD")] uint lReadTimeout);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EncryptFileA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EncryptFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EncryptFileW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EncryptFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DecryptFileA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DecryptFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DecryptFileW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DecryptFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FileEncryptionStatusA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FileEncryptionStatusA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPDWORD")] uint* lpStatus);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FileEncryptionStatusW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FileEncryptionStatusW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("LPDWORD")] uint* lpStatus);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenEncryptedFileRawA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint OpenEncryptedFileRawA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("ULONG")] uint ulFlags, [NativeTypeName("PVOID *")] void** pvContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenEncryptedFileRawW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint OpenEncryptedFileRawW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("ULONG")] uint ulFlags, [NativeTypeName("PVOID *")] void** pvContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReadEncryptedFileRaw"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint ReadEncryptedFileRaw([NativeTypeName("PFE_EXPORT_FUNC")] delegate* unmanaged<byte*, void*, uint, uint> pfExportCallback, [NativeTypeName("PVOID")] void* pvCallbackContext, [NativeTypeName("PVOID")] void* pvContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WriteEncryptedFileRaw"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WriteEncryptedFileRaw([NativeTypeName("PFE_IMPORT_FUNC")] delegate* unmanaged<byte*, void*, uint*, uint> pfImportCallback, [NativeTypeName("PVOID")] void* pvCallbackContext, [NativeTypeName("PVOID")] void* pvContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CloseEncryptedFileRaw"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    public static extern void CloseEncryptedFileRaw([NativeTypeName("PVOID")] void* pvContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.lstrcmpA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern int lstrcmpA([NativeTypeName("LPCSTR")] sbyte* lpString1, [NativeTypeName("LPCSTR")] sbyte* lpString2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.lstrcmpW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern int lstrcmpW([NativeTypeName("LPCWSTR")] ushort* lpString1, [NativeTypeName("LPCWSTR")] ushort* lpString2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.lstrcmpiA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern int lstrcmpiA([NativeTypeName("LPCSTR")] sbyte* lpString1, [NativeTypeName("LPCSTR")] sbyte* lpString2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.lstrcmpiW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern int lstrcmpiW([NativeTypeName("LPCWSTR")] ushort* lpString1, [NativeTypeName("LPCWSTR")] ushort* lpString2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.lstrcpynA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* lstrcpynA([NativeTypeName("LPSTR")] sbyte* lpString1, [NativeTypeName("LPCSTR")] sbyte* lpString2, int iMaxLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.lstrcpynW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern ushort* lstrcpynW([NativeTypeName("LPWSTR")] ushort* lpString1, [NativeTypeName("LPCWSTR")] ushort* lpString2, int iMaxLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.lstrcpyA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* lstrcpyA([NativeTypeName("LPSTR")] sbyte* lpString1, [NativeTypeName("LPCSTR")] sbyte* lpString2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.lstrcpyW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern ushort* lstrcpyW([NativeTypeName("LPWSTR")] ushort* lpString1, [NativeTypeName("LPCWSTR")] ushort* lpString2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.lstrcatA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* lstrcatA([NativeTypeName("LPSTR")] sbyte* lpString1, [NativeTypeName("LPCSTR")] sbyte* lpString2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.lstrcatW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern ushort* lstrcatW([NativeTypeName("LPWSTR")] ushort* lpString1, [NativeTypeName("LPCWSTR")] ushort* lpString2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.lstrlenA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern int lstrlenA([NativeTypeName("LPCSTR")] sbyte* lpString);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.lstrlenW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern int lstrlenW([NativeTypeName("LPCWSTR")] ushort* lpString);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenFile"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("HFILE")]
    public static extern int OpenFile([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPOFSTRUCT")] OFSTRUCT* lpReOpenBuff, uint uStyle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows._lopen"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("HFILE")]
    public static extern int _lopen([NativeTypeName("LPCSTR")] sbyte* lpPathName, int iReadWrite);

    /// <include file='Windows.xml' path='doc/member[@name="Windows._lcreat"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("HFILE")]
    public static extern int _lcreat([NativeTypeName("LPCSTR")] sbyte* lpPathName, int iAttribute);

    /// <include file='Windows.xml' path='doc/member[@name="Windows._lread"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern uint _lread([NativeTypeName("HFILE")] int hFile, [NativeTypeName("LPVOID")] void* lpBuffer, uint uBytes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows._lwrite"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint _lwrite([NativeTypeName("HFILE")] int hFile, [NativeTypeName("LPCCH")] sbyte* lpBuffer, uint uBytes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows._lclose"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("HFILE")]
    public static extern int _lclose([NativeTypeName("HFILE")] int hFile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows._llseek"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LONG")]
    public static extern int _llseek([NativeTypeName("HFILE")] int hFile, [NativeTypeName("LONG")] int lOffset, int iOrigin);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsTextUnicode"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    public static extern BOOL IsTextUnicode([NativeTypeName("const void *")] void* lpv, int iSize, [NativeTypeName("LPINT")] int* lpiResult);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BackupRead"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL BackupRead(HANDLE hFile, [NativeTypeName("LPBYTE")] byte* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesRead, BOOL bAbort, BOOL bProcessSecurity, [NativeTypeName("LPVOID *")] void** lpContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BackupSeek"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL BackupSeek(HANDLE hFile, [NativeTypeName("DWORD")] uint dwLowBytesToSeek, [NativeTypeName("DWORD")] uint dwHighBytesToSeek, [NativeTypeName("LPDWORD")] uint* lpdwLowByteSeeked, [NativeTypeName("LPDWORD")] uint* lpdwHighByteSeeked, [NativeTypeName("LPVOID *")] void** lpContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BackupWrite"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL BackupWrite(HANDLE hFile, [NativeTypeName("LPBYTE")] byte* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToWrite, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesWritten, BOOL bAbort, BOOL bProcessSecurity, [NativeTypeName("LPVOID *")] void** lpContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenMutexA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HANDLE OpenMutexA([NativeTypeName("DWORD")] uint dwDesiredAccess, BOOL bInheritHandle, [NativeTypeName("LPCSTR")] sbyte* lpName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateSemaphoreA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateSemaphoreA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSemaphoreAttributes, [NativeTypeName("LONG")] int lInitialCount, [NativeTypeName("LONG")] int lMaximumCount, [NativeTypeName("LPCSTR")] sbyte* lpName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenSemaphoreA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HANDLE OpenSemaphoreA([NativeTypeName("DWORD")] uint dwDesiredAccess, BOOL bInheritHandle, [NativeTypeName("LPCSTR")] sbyte* lpName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateWaitableTimerA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HANDLE CreateWaitableTimerA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpTimerAttributes, BOOL bManualReset, [NativeTypeName("LPCSTR")] sbyte* lpTimerName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenWaitableTimerA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HANDLE OpenWaitableTimerA([NativeTypeName("DWORD")] uint dwDesiredAccess, BOOL bInheritHandle, [NativeTypeName("LPCSTR")] sbyte* lpTimerName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateSemaphoreExA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateSemaphoreExA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSemaphoreAttributes, [NativeTypeName("LONG")] int lInitialCount, [NativeTypeName("LONG")] int lMaximumCount, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateWaitableTimerExA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HANDLE CreateWaitableTimerExA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpTimerAttributes, [NativeTypeName("LPCSTR")] sbyte* lpTimerName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateFileMappingA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateFileMappingA(HANDLE hFile, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpFileMappingAttributes, [NativeTypeName("DWORD")] uint flProtect, [NativeTypeName("DWORD")] uint dwMaximumSizeHigh, [NativeTypeName("DWORD")] uint dwMaximumSizeLow, [NativeTypeName("LPCSTR")] sbyte* lpName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateFileMappingNumaA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateFileMappingNumaA(HANDLE hFile, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpFileMappingAttributes, [NativeTypeName("DWORD")] uint flProtect, [NativeTypeName("DWORD")] uint dwMaximumSizeHigh, [NativeTypeName("DWORD")] uint dwMaximumSizeLow, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint nndPreferred);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenFileMappingA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenFileMappingA([NativeTypeName("DWORD")] uint dwDesiredAccess, BOOL bInheritHandle, [NativeTypeName("LPCSTR")] sbyte* lpName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetLogicalDriveStringsA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetLogicalDriveStringsA([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadPackagedLibrary"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern HMODULE LoadPackagedLibrary([NativeTypeName("LPCWSTR")] ushort* lpwLibFileName, [NativeTypeName("DWORD")] uint Reserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.QueryFullProcessImageNameA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL QueryFullProcessImageNameA(HANDLE hProcess, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPSTR")] sbyte* lpExeName, [NativeTypeName("PDWORD")] uint* lpdwSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.QueryFullProcessImageNameW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL QueryFullProcessImageNameW(HANDLE hProcess, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* lpExeName, [NativeTypeName("PDWORD")] uint* lpdwSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetStartupInfoA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void GetStartupInfoA([NativeTypeName("LPSTARTUPINFOA")] STARTUPINFOA* lpStartupInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFirmwareEnvironmentVariableA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFirmwareEnvironmentVariableA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPCSTR")] sbyte* lpGuid, [NativeTypeName("PVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFirmwareEnvironmentVariableW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFirmwareEnvironmentVariableW([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPCWSTR")] ushort* lpGuid, [NativeTypeName("PVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFirmwareEnvironmentVariableExA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint GetFirmwareEnvironmentVariableExA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPCSTR")] sbyte* lpGuid, [NativeTypeName("PVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("PDWORD")] uint* pdwAttribubutes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFirmwareEnvironmentVariableExW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint GetFirmwareEnvironmentVariableExW([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPCWSTR")] ushort* lpGuid, [NativeTypeName("PVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("PDWORD")] uint* pdwAttribubutes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetFirmwareEnvironmentVariableA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFirmwareEnvironmentVariableA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPCSTR")] sbyte* lpGuid, [NativeTypeName("PVOID")] void* pValue, [NativeTypeName("DWORD")] uint nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetFirmwareEnvironmentVariableW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFirmwareEnvironmentVariableW([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPCWSTR")] ushort* lpGuid, [NativeTypeName("PVOID")] void* pValue, [NativeTypeName("DWORD")] uint nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetFirmwareEnvironmentVariableExA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL SetFirmwareEnvironmentVariableExA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPCSTR")] sbyte* lpGuid, [NativeTypeName("PVOID")] void* pValue, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("DWORD")] uint dwAttributes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetFirmwareEnvironmentVariableExW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL SetFirmwareEnvironmentVariableExW([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPCWSTR")] ushort* lpGuid, [NativeTypeName("PVOID")] void* pValue, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("DWORD")] uint dwAttributes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFirmwareType"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetFirmwareType([NativeTypeName("PFIRMWARE_TYPE")] FIRMWARE_TYPE* FirmwareType);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsNativeVhdBoot"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL IsNativeVhdBoot([NativeTypeName("PBOOL")] BOOL* NativeVhdBoot);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindResourceA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HRSRC FindResourceA(HMODULE hModule, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPCSTR")] sbyte* lpType);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindResourceExA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HRSRC FindResourceExA(HMODULE hModule, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("WORD")] ushort wLanguage);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumResourceTypesA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumResourceTypesA(HMODULE hModule, [NativeTypeName("ENUMRESTYPEPROCA")] delegate* unmanaged<HMODULE, sbyte*, nint, BOOL> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumResourceTypesW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumResourceTypesW(HMODULE hModule, [NativeTypeName("ENUMRESTYPEPROCW")] delegate* unmanaged<HMODULE, ushort*, nint, BOOL> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumResourceLanguagesA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumResourceLanguagesA(HMODULE hModule, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("ENUMRESLANGPROCA")] delegate* unmanaged<HMODULE, sbyte*, sbyte*, ushort, nint, BOOL> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumResourceLanguagesW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumResourceLanguagesW(HMODULE hModule, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("ENUMRESLANGPROCW")] delegate* unmanaged<HMODULE, ushort*, ushort*, ushort, nint, BOOL> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BeginUpdateResourceA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE BeginUpdateResourceA([NativeTypeName("LPCSTR")] sbyte* pFileName, BOOL bDeleteExistingResources);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BeginUpdateResourceW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE BeginUpdateResourceW([NativeTypeName("LPCWSTR")] ushort* pFileName, BOOL bDeleteExistingResources);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UpdateResourceA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UpdateResourceA(HANDLE hUpdate, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("WORD")] ushort wLanguage, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("DWORD")] uint cb);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UpdateResourceW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UpdateResourceW(HANDLE hUpdate, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("WORD")] ushort wLanguage, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("DWORD")] uint cb);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EndUpdateResourceA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EndUpdateResourceA(HANDLE hUpdate, BOOL fDiscard);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EndUpdateResourceW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EndUpdateResourceW(HANDLE hUpdate, BOOL fDiscard);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GlobalAddAtomA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort GlobalAddAtomA([NativeTypeName("LPCSTR")] sbyte* lpString);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GlobalAddAtomW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort GlobalAddAtomW([NativeTypeName("LPCWSTR")] ushort* lpString);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GlobalAddAtomExA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort GlobalAddAtomExA([NativeTypeName("LPCSTR")] sbyte* lpString, [NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GlobalAddAtomExW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort GlobalAddAtomExW([NativeTypeName("LPCWSTR")] ushort* lpString, [NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GlobalFindAtomA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort GlobalFindAtomA([NativeTypeName("LPCSTR")] sbyte* lpString);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GlobalFindAtomW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort GlobalFindAtomW([NativeTypeName("LPCWSTR")] ushort* lpString);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GlobalGetAtomNameA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GlobalGetAtomNameA([NativeTypeName("ATOM")] ushort nAtom, [NativeTypeName("LPSTR")] sbyte* lpBuffer, int nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GlobalGetAtomNameW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GlobalGetAtomNameW([NativeTypeName("ATOM")] ushort nAtom, [NativeTypeName("LPWSTR")] ushort* lpBuffer, int nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddAtomA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort AddAtomA([NativeTypeName("LPCSTR")] sbyte* lpString);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddAtomW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort AddAtomW([NativeTypeName("LPCWSTR")] ushort* lpString);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindAtomA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort FindAtomA([NativeTypeName("LPCSTR")] sbyte* lpString);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindAtomW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort FindAtomW([NativeTypeName("LPCWSTR")] ushort* lpString);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetAtomNameA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetAtomNameA([NativeTypeName("ATOM")] ushort nAtom, [NativeTypeName("LPSTR")] sbyte* lpBuffer, int nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetAtomNameW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetAtomNameW([NativeTypeName("ATOM")] ushort nAtom, [NativeTypeName("LPWSTR")] ushort* lpBuffer, int nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProfileIntA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern uint GetProfileIntA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpKeyName, int nDefault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProfileIntW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern uint GetProfileIntW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpKeyName, int nDefault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProfileStringA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetProfileStringA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpKeyName, [NativeTypeName("LPCSTR")] sbyte* lpDefault, [NativeTypeName("LPSTR")] sbyte* lpReturnedString, [NativeTypeName("DWORD")] uint nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProfileStringW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetProfileStringW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpKeyName, [NativeTypeName("LPCWSTR")] ushort* lpDefault, [NativeTypeName("LPWSTR")] ushort* lpReturnedString, [NativeTypeName("DWORD")] uint nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WriteProfileStringA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WriteProfileStringA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpKeyName, [NativeTypeName("LPCSTR")] sbyte* lpString);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WriteProfileStringW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WriteProfileStringW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpKeyName, [NativeTypeName("LPCWSTR")] ushort* lpString);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProfileSectionA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetProfileSectionA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPSTR")] sbyte* lpReturnedString, [NativeTypeName("DWORD")] uint nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProfileSectionW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetProfileSectionW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPWSTR")] ushort* lpReturnedString, [NativeTypeName("DWORD")] uint nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WriteProfileSectionA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WriteProfileSectionA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpString);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WriteProfileSectionW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WriteProfileSectionW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpString);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPrivateProfileIntA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern uint GetPrivateProfileIntA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpKeyName, int nDefault, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPrivateProfileIntW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern uint GetPrivateProfileIntW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpKeyName, int nDefault, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPrivateProfileStringA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetPrivateProfileStringA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpKeyName, [NativeTypeName("LPCSTR")] sbyte* lpDefault, [NativeTypeName("LPSTR")] sbyte* lpReturnedString, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPrivateProfileStringW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetPrivateProfileStringW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpKeyName, [NativeTypeName("LPCWSTR")] ushort* lpDefault, [NativeTypeName("LPWSTR")] ushort* lpReturnedString, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WritePrivateProfileStringA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WritePrivateProfileStringA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpKeyName, [NativeTypeName("LPCSTR")] sbyte* lpString, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WritePrivateProfileStringW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WritePrivateProfileStringW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpKeyName, [NativeTypeName("LPCWSTR")] ushort* lpString, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPrivateProfileSectionA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetPrivateProfileSectionA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPSTR")] sbyte* lpReturnedString, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPrivateProfileSectionW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetPrivateProfileSectionW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPWSTR")] ushort* lpReturnedString, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WritePrivateProfileSectionA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WritePrivateProfileSectionA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpString, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WritePrivateProfileSectionW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WritePrivateProfileSectionW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpString, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPrivateProfileSectionNamesA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetPrivateProfileSectionNamesA([NativeTypeName("LPSTR")] sbyte* lpszReturnBuffer, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPrivateProfileSectionNamesW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetPrivateProfileSectionNamesW([NativeTypeName("LPWSTR")] ushort* lpszReturnBuffer, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPrivateProfileStructA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL GetPrivateProfileStructA([NativeTypeName("LPCSTR")] sbyte* lpszSection, [NativeTypeName("LPCSTR")] sbyte* lpszKey, [NativeTypeName("LPVOID")] void* lpStruct, uint uSizeStruct, [NativeTypeName("LPCSTR")] sbyte* szFile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPrivateProfileStructW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL GetPrivateProfileStructW([NativeTypeName("LPCWSTR")] ushort* lpszSection, [NativeTypeName("LPCWSTR")] ushort* lpszKey, [NativeTypeName("LPVOID")] void* lpStruct, uint uSizeStruct, [NativeTypeName("LPCWSTR")] ushort* szFile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WritePrivateProfileStructA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WritePrivateProfileStructA([NativeTypeName("LPCSTR")] sbyte* lpszSection, [NativeTypeName("LPCSTR")] sbyte* lpszKey, [NativeTypeName("LPVOID")] void* lpStruct, uint uSizeStruct, [NativeTypeName("LPCSTR")] sbyte* szFile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WritePrivateProfileStructW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WritePrivateProfileStructW([NativeTypeName("LPCWSTR")] ushort* lpszSection, [NativeTypeName("LPCWSTR")] ushort* lpszKey, [NativeTypeName("LPVOID")] void* lpStruct, uint uSizeStruct, [NativeTypeName("LPCWSTR")] ushort* szFile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetDllDirectoryA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetDllDirectoryA([NativeTypeName("LPCSTR")] sbyte* lpPathName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetDllDirectoryW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetDllDirectoryW([NativeTypeName("LPCWSTR")] ushort* lpPathName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDllDirectoryA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetDllDirectoryA([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDllDirectoryW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetDllDirectoryW([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] ushort* lpBuffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetSearchPathMode"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetSearchPathMode([NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateDirectoryExA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateDirectoryExA([NativeTypeName("LPCSTR")] sbyte* lpTemplateDirectory, [NativeTypeName("LPCSTR")] sbyte* lpNewDirectory, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateDirectoryExW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateDirectoryExW([NativeTypeName("LPCWSTR")] ushort* lpTemplateDirectory, [NativeTypeName("LPCWSTR")] ushort* lpNewDirectory, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateDirectoryTransactedA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateDirectoryTransactedA([NativeTypeName("LPCSTR")] sbyte* lpTemplateDirectory, [NativeTypeName("LPCSTR")] sbyte* lpNewDirectory, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateDirectoryTransactedW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateDirectoryTransactedW([NativeTypeName("LPCWSTR")] ushort* lpTemplateDirectory, [NativeTypeName("LPCWSTR")] ushort* lpNewDirectory, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RemoveDirectoryTransactedA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RemoveDirectoryTransactedA([NativeTypeName("LPCSTR")] sbyte* lpPathName, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RemoveDirectoryTransactedW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RemoveDirectoryTransactedW([NativeTypeName("LPCWSTR")] ushort* lpPathName, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFullPathNameTransactedA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFullPathNameTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("LPSTR *")] sbyte** lpFilePart, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFullPathNameTransactedW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFullPathNameTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("LPWSTR *")] ushort** lpFilePart, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DefineDosDeviceA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DefineDosDeviceA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCSTR")] sbyte* lpDeviceName, [NativeTypeName("LPCSTR")] sbyte* lpTargetPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.QueryDosDeviceA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint QueryDosDeviceA([NativeTypeName("LPCSTR")] sbyte* lpDeviceName, [NativeTypeName("LPSTR")] sbyte* lpTargetPath, [NativeTypeName("DWORD")] uint ucchMax);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateFileTransactedA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateFileTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint dwCreationDisposition, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes, HANDLE hTemplateFile, HANDLE hTransaction, [NativeTypeName("PUSHORT")] ushort* pusMiniVersion, [NativeTypeName("PVOID")] void* lpExtendedParameter);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateFileTransactedW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateFileTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint dwCreationDisposition, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes, HANDLE hTemplateFile, HANDLE hTransaction, [NativeTypeName("PUSHORT")] ushort* pusMiniVersion, [NativeTypeName("PVOID")] void* lpExtendedParameter);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReOpenFile"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE ReOpenFile(HANDLE hOriginalFile, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetFileAttributesTransactedA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileAttributesTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint dwFileAttributes, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetFileAttributesTransactedW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileAttributesTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwFileAttributes, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFileAttributesTransactedA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetFileAttributesTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, GET_FILEEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFileInformation, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFileAttributesTransactedW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetFileAttributesTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, GET_FILEEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFileInformation, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCompressedFileSizeTransactedA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetCompressedFileSizeTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCompressedFileSizeTransactedW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetCompressedFileSizeTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeleteFileTransactedA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeleteFileTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeleteFileTransactedW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeleteFileTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CheckNameLegalDOS8Dot3A"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CheckNameLegalDOS8Dot3A([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPSTR")] sbyte* lpOemName, [NativeTypeName("DWORD")] uint OemNameSize, [NativeTypeName("PBOOL")] BOOL* pbNameContainsSpaces, [NativeTypeName("PBOOL")] BOOL* pbNameLegal);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CheckNameLegalDOS8Dot3W"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CheckNameLegalDOS8Dot3W([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPSTR")] sbyte* lpOemName, [NativeTypeName("DWORD")] uint OemNameSize, [NativeTypeName("PBOOL")] BOOL* pbNameContainsSpaces, [NativeTypeName("PBOOL")] BOOL* pbNameLegal);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindFirstFileTransactedA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstFileTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, [NativeTypeName("LPVOID")] void* lpSearchFilter, [NativeTypeName("DWORD")] uint dwAdditionalFlags, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindFirstFileTransactedW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstFileTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, [NativeTypeName("LPVOID")] void* lpSearchFilter, [NativeTypeName("DWORD")] uint dwAdditionalFlags, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CopyFileA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CopyFileA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName, BOOL bFailIfExists);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CopyFileW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CopyFileW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName, BOOL bFailIfExists);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CopyFileExA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CopyFileExA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, HANDLE, HANDLE, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("LPBOOL")] BOOL* pbCancel, [NativeTypeName("DWORD")] uint dwCopyFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CopyFileExW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CopyFileExW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, HANDLE, HANDLE, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("LPBOOL")] BOOL* pbCancel, [NativeTypeName("DWORD")] uint dwCopyFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CopyFileTransactedA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CopyFileTransactedA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, HANDLE, HANDLE, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("LPBOOL")] BOOL* pbCancel, [NativeTypeName("DWORD")] uint dwCopyFlags, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CopyFileTransactedW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CopyFileTransactedW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, HANDLE, HANDLE, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("LPBOOL")] BOOL* pbCancel, [NativeTypeName("DWORD")] uint dwCopyFlags, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CopyFile2"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT CopyFile2([NativeTypeName("PCWSTR")] ushort* pwszExistingFileName, [NativeTypeName("PCWSTR")] ushort* pwszNewFileName, COPYFILE2_EXTENDED_PARAMETERS* pExtendedParameters);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MoveFileA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MoveFileA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MoveFileW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MoveFileW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MoveFileExA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MoveFileExA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MoveFileExW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MoveFileExW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MoveFileWithProgressA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MoveFileWithProgressA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, HANDLE, HANDLE, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MoveFileWithProgressW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MoveFileWithProgressW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, HANDLE, HANDLE, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MoveFileTransactedA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MoveFileTransactedA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, HANDLE, HANDLE, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("DWORD")] uint dwFlags, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MoveFileTransactedW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MoveFileTransactedW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, HANDLE, HANDLE, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("DWORD")] uint dwFlags, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReplaceFileA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReplaceFileA([NativeTypeName("LPCSTR")] sbyte* lpReplacedFileName, [NativeTypeName("LPCSTR")] sbyte* lpReplacementFileName, [NativeTypeName("LPCSTR")] sbyte* lpBackupFileName, [NativeTypeName("DWORD")] uint dwReplaceFlags, [NativeTypeName("LPVOID")] void* lpExclude, [NativeTypeName("LPVOID")] void* lpReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReplaceFileW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReplaceFileW([NativeTypeName("LPCWSTR")] ushort* lpReplacedFileName, [NativeTypeName("LPCWSTR")] ushort* lpReplacementFileName, [NativeTypeName("LPCWSTR")] ushort* lpBackupFileName, [NativeTypeName("DWORD")] uint dwReplaceFlags, [NativeTypeName("LPVOID")] void* lpExclude, [NativeTypeName("LPVOID")] void* lpReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateHardLinkA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateHardLinkA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateHardLinkW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateHardLinkW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateHardLinkTransactedA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateHardLinkTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateHardLinkTransactedW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateHardLinkTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindFirstStreamTransactedW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstStreamTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, STREAM_INFO_LEVELS InfoLevel, [NativeTypeName("LPVOID")] void* lpFindStreamData, [NativeTypeName("DWORD")] uint dwFlags, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindFirstFileNameTransactedW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstFileNameTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPDWORD")] uint* StringLength, [NativeTypeName("PWSTR")] ushort* LinkName, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateNamedPipeA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateNamedPipeA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint dwOpenMode, [NativeTypeName("DWORD")] uint dwPipeMode, [NativeTypeName("DWORD")] uint nMaxInstances, [NativeTypeName("DWORD")] uint nOutBufferSize, [NativeTypeName("DWORD")] uint nInBufferSize, [NativeTypeName("DWORD")] uint nDefaultTimeOut, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetNamedPipeHandleStateA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNamedPipeHandleStateA(HANDLE hNamedPipe, [NativeTypeName("LPDWORD")] uint* lpState, [NativeTypeName("LPDWORD")] uint* lpCurInstances, [NativeTypeName("LPDWORD")] uint* lpMaxCollectionCount, [NativeTypeName("LPDWORD")] uint* lpCollectDataTimeout, [NativeTypeName("LPSTR")] sbyte* lpUserName, [NativeTypeName("DWORD")] uint nMaxUserNameSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CallNamedPipeA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CallNamedPipeA([NativeTypeName("LPCSTR")] sbyte* lpNamedPipeName, [NativeTypeName("LPVOID")] void* lpInBuffer, [NativeTypeName("DWORD")] uint nInBufferSize, [NativeTypeName("LPVOID")] void* lpOutBuffer, [NativeTypeName("DWORD")] uint nOutBufferSize, [NativeTypeName("LPDWORD")] uint* lpBytesRead, [NativeTypeName("DWORD")] uint nTimeOut);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WaitNamedPipeA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WaitNamedPipeA([NativeTypeName("LPCSTR")] sbyte* lpNamedPipeName, [NativeTypeName("DWORD")] uint nTimeOut);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetNamedPipeClientComputerNameA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNamedPipeClientComputerNameA(HANDLE Pipe, [NativeTypeName("LPSTR")] sbyte* ClientComputerName, [NativeTypeName("ULONG")] uint ClientComputerNameLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetNamedPipeClientProcessId"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNamedPipeClientProcessId(HANDLE Pipe, [NativeTypeName("PULONG")] uint* ClientProcessId);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetNamedPipeClientSessionId"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNamedPipeClientSessionId(HANDLE Pipe, [NativeTypeName("PULONG")] uint* ClientSessionId);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetNamedPipeServerProcessId"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNamedPipeServerProcessId(HANDLE Pipe, [NativeTypeName("PULONG")] uint* ServerProcessId);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetNamedPipeServerSessionId"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNamedPipeServerSessionId(HANDLE Pipe, [NativeTypeName("PULONG")] uint* ServerSessionId);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetVolumeLabelA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetVolumeLabelA([NativeTypeName("LPCSTR")] sbyte* lpRootPathName, [NativeTypeName("LPCSTR")] sbyte* lpVolumeName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetVolumeLabelW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetVolumeLabelW([NativeTypeName("LPCWSTR")] ushort* lpRootPathName, [NativeTypeName("LPCWSTR")] ushort* lpVolumeName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetFileBandwidthReservation"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileBandwidthReservation(HANDLE hFile, [NativeTypeName("DWORD")] uint nPeriodMilliseconds, [NativeTypeName("DWORD")] uint nBytesPerPeriod, BOOL bDiscardable, [NativeTypeName("LPDWORD")] uint* lpTransferSize, [NativeTypeName("LPDWORD")] uint* lpNumOutstandingRequests);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFileBandwidthReservation"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetFileBandwidthReservation(HANDLE hFile, [NativeTypeName("LPDWORD")] uint* lpPeriodMilliseconds, [NativeTypeName("LPDWORD")] uint* lpBytesPerPeriod, [NativeTypeName("LPBOOL")] BOOL* pDiscardable, [NativeTypeName("LPDWORD")] uint* lpTransferSize, [NativeTypeName("LPDWORD")] uint* lpNumOutstandingRequests);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ClearEventLogA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ClearEventLogA(HANDLE hEventLog, [NativeTypeName("LPCSTR")] sbyte* lpBackupFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ClearEventLogW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ClearEventLogW(HANDLE hEventLog, [NativeTypeName("LPCWSTR")] ushort* lpBackupFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BackupEventLogA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL BackupEventLogA(HANDLE hEventLog, [NativeTypeName("LPCSTR")] sbyte* lpBackupFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BackupEventLogW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL BackupEventLogW(HANDLE hEventLog, [NativeTypeName("LPCWSTR")] ushort* lpBackupFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CloseEventLog"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CloseEventLog(HANDLE hEventLog);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeregisterEventSource"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeregisterEventSource(HANDLE hEventLog);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NotifyChangeEventLog"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL NotifyChangeEventLog(HANDLE hEventLog, HANDLE hEvent);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetNumberOfEventLogRecords"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNumberOfEventLogRecords(HANDLE hEventLog, [NativeTypeName("PDWORD")] uint* NumberOfRecords);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetOldestEventLogRecord"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetOldestEventLogRecord(HANDLE hEventLog, [NativeTypeName("PDWORD")] uint* OldestRecord);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenEventLogA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenEventLogA([NativeTypeName("LPCSTR")] sbyte* lpUNCServerName, [NativeTypeName("LPCSTR")] sbyte* lpSourceName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenEventLogW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenEventLogW([NativeTypeName("LPCWSTR")] ushort* lpUNCServerName, [NativeTypeName("LPCWSTR")] ushort* lpSourceName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterEventSourceA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE RegisterEventSourceA([NativeTypeName("LPCSTR")] sbyte* lpUNCServerName, [NativeTypeName("LPCSTR")] sbyte* lpSourceName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterEventSourceW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE RegisterEventSourceW([NativeTypeName("LPCWSTR")] ushort* lpUNCServerName, [NativeTypeName("LPCWSTR")] ushort* lpSourceName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenBackupEventLogA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenBackupEventLogA([NativeTypeName("LPCSTR")] sbyte* lpUNCServerName, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenBackupEventLogW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenBackupEventLogW([NativeTypeName("LPCWSTR")] ushort* lpUNCServerName, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReadEventLogA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReadEventLogA(HANDLE hEventLog, [NativeTypeName("DWORD")] uint dwReadFlags, [NativeTypeName("DWORD")] uint dwRecordOffset, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("DWORD *")] uint* pnBytesRead, [NativeTypeName("DWORD *")] uint* pnMinNumberOfBytesNeeded);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReadEventLogW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReadEventLogW(HANDLE hEventLog, [NativeTypeName("DWORD")] uint dwReadFlags, [NativeTypeName("DWORD")] uint dwRecordOffset, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("DWORD *")] uint* pnBytesRead, [NativeTypeName("DWORD *")] uint* pnMinNumberOfBytesNeeded);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReportEventA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReportEventA(HANDLE hEventLog, [NativeTypeName("WORD")] ushort wType, [NativeTypeName("WORD")] ushort wCategory, [NativeTypeName("DWORD")] uint dwEventID, [NativeTypeName("PSID")] void* lpUserSid, [NativeTypeName("WORD")] ushort wNumStrings, [NativeTypeName("DWORD")] uint dwDataSize, [NativeTypeName("LPCSTR *")] sbyte** lpStrings, [NativeTypeName("LPVOID")] void* lpRawData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReportEventW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReportEventW(HANDLE hEventLog, [NativeTypeName("WORD")] ushort wType, [NativeTypeName("WORD")] ushort wCategory, [NativeTypeName("DWORD")] uint dwEventID, [NativeTypeName("PSID")] void* lpUserSid, [NativeTypeName("WORD")] ushort wNumStrings, [NativeTypeName("DWORD")] uint dwDataSize, [NativeTypeName("LPCWSTR *")] ushort** lpStrings, [NativeTypeName("LPVOID")] void* lpRawData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetEventLogInformation"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetEventLogInformation(HANDLE hEventLog, [NativeTypeName("DWORD")] uint dwInfoLevel, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint cbBufSize, [NativeTypeName("LPDWORD")] uint* pcbBytesNeeded);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OperationStart"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL OperationStart(OPERATION_START_PARAMETERS* OperationStartParams);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OperationEnd"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL OperationEnd(OPERATION_END_PARAMETERS* OperationEndParams);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AccessCheckAndAuditAlarmA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AccessCheckAndAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("LPSTR")] sbyte* ObjectTypeName, [NativeTypeName("LPSTR")] sbyte* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, BOOL ObjectCreation, [NativeTypeName("LPDWORD")] uint* GrantedAccess, [NativeTypeName("LPBOOL")] BOOL* AccessStatus, [NativeTypeName("LPBOOL")] BOOL* pfGenerateOnClose);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AccessCheckByTypeAndAuditAlarmA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AccessCheckByTypeAndAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("LPCSTR")] sbyte* ObjectTypeName, [NativeTypeName("LPCSTR")] sbyte* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("PSID")] void* PrincipalSelfSid, [NativeTypeName("DWORD")] uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList, [NativeTypeName("DWORD")] uint ObjectTypeListLength, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, BOOL ObjectCreation, [NativeTypeName("LPDWORD")] uint* GrantedAccess, [NativeTypeName("LPBOOL")] BOOL* AccessStatus, [NativeTypeName("LPBOOL")] BOOL* pfGenerateOnClose);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AccessCheckByTypeResultListAndAuditAlarmA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AccessCheckByTypeResultListAndAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("LPCSTR")] sbyte* ObjectTypeName, [NativeTypeName("LPCSTR")] sbyte* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("PSID")] void* PrincipalSelfSid, [NativeTypeName("DWORD")] uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList, [NativeTypeName("DWORD")] uint ObjectTypeListLength, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, BOOL ObjectCreation, [NativeTypeName("LPDWORD")] uint* GrantedAccess, [NativeTypeName("LPDWORD")] uint* AccessStatusList, [NativeTypeName("LPBOOL")] BOOL* pfGenerateOnClose);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AccessCheckByTypeResultListAndAuditAlarmByHandleA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AccessCheckByTypeResultListAndAuditAlarmByHandleA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, HANDLE ClientToken, [NativeTypeName("LPCSTR")] sbyte* ObjectTypeName, [NativeTypeName("LPCSTR")] sbyte* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("PSID")] void* PrincipalSelfSid, [NativeTypeName("DWORD")] uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList, [NativeTypeName("DWORD")] uint ObjectTypeListLength, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, BOOL ObjectCreation, [NativeTypeName("LPDWORD")] uint* GrantedAccess, [NativeTypeName("LPDWORD")] uint* AccessStatusList, [NativeTypeName("LPBOOL")] BOOL* pfGenerateOnClose);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ObjectOpenAuditAlarmA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ObjectOpenAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("LPSTR")] sbyte* ObjectTypeName, [NativeTypeName("LPSTR")] sbyte* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, HANDLE ClientToken, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("DWORD")] uint GrantedAccess, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* Privileges, BOOL ObjectCreation, BOOL AccessGranted, [NativeTypeName("LPBOOL")] BOOL* GenerateOnClose);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ObjectPrivilegeAuditAlarmA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ObjectPrivilegeAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, HANDLE ClientToken, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* Privileges, BOOL AccessGranted);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ObjectCloseAuditAlarmA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ObjectCloseAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, BOOL GenerateOnClose);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ObjectDeleteAuditAlarmA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ObjectDeleteAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, BOOL GenerateOnClose);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrivilegedServiceAuditAlarmA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PrivilegedServiceAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPCSTR")] sbyte* ServiceName, HANDLE ClientToken, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* Privileges, BOOL AccessGranted);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddConditionalAce"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddConditionalAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AceFlags, [NativeTypeName("UCHAR")] byte AceType, [NativeTypeName("DWORD")] uint AccessMask, [NativeTypeName("PSID")] void* pSid, [NativeTypeName("PWCHAR")] ushort* ConditionStr, [NativeTypeName("DWORD *")] uint* ReturnLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetFileSecurityA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileSecurityA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFileSecurityA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetFileSecurityA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("SECURITY_INFORMATION")] uint RequestedInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReadDirectoryChangesW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReadDirectoryChangesW(HANDLE hDirectory, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nBufferLength, BOOL bWatchSubtree, [NativeTypeName("DWORD")] uint dwNotifyFilter, [NativeTypeName("LPDWORD")] uint* lpBytesReturned, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")] delegate* unmanaged<uint, uint, OVERLAPPED*, void> lpCompletionRoutine);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReadDirectoryChangesExW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.16299.0")]
    public static extern BOOL ReadDirectoryChangesExW(HANDLE hDirectory, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nBufferLength, BOOL bWatchSubtree, [NativeTypeName("DWORD")] uint dwNotifyFilter, [NativeTypeName("LPDWORD")] uint* lpBytesReturned, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")] delegate* unmanaged<uint, uint, OVERLAPPED*, void> lpCompletionRoutine, READ_DIRECTORY_NOTIFY_INFORMATION_CLASS ReadDirectoryNotifyInformationClass);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MapViewOfFileExNuma"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPVOID")]
    public static extern void* MapViewOfFileExNuma(HANDLE hFileMappingObject, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwFileOffsetHigh, [NativeTypeName("DWORD")] uint dwFileOffsetLow, [NativeTypeName("SIZE_T")] nuint dwNumberOfBytesToMap, [NativeTypeName("LPVOID")] void* lpBaseAddress, [NativeTypeName("DWORD")] uint nndPreferred);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsBadReadPtr"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL IsBadReadPtr([NativeTypeName("const void *")] void* lp, [NativeTypeName("UINT_PTR")] nuint ucb);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsBadWritePtr"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL IsBadWritePtr([NativeTypeName("LPVOID")] void* lp, [NativeTypeName("UINT_PTR")] nuint ucb);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsBadHugeReadPtr"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL IsBadHugeReadPtr([NativeTypeName("const void *")] void* lp, [NativeTypeName("UINT_PTR")] nuint ucb);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsBadHugeWritePtr"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL IsBadHugeWritePtr([NativeTypeName("LPVOID")] void* lp, [NativeTypeName("UINT_PTR")] nuint ucb);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsBadCodePtr"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL IsBadCodePtr([NativeTypeName("FARPROC")] IntPtr lpfn);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsBadStringPtrA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL IsBadStringPtrA([NativeTypeName("LPCSTR")] sbyte* lpsz, [NativeTypeName("UINT_PTR")] nuint ucchMax);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsBadStringPtrW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL IsBadStringPtrW([NativeTypeName("LPCWSTR")] ushort* lpsz, [NativeTypeName("UINT_PTR")] nuint ucchMax);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LookupAccountSidA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupAccountSidA([NativeTypeName("LPCSTR")] sbyte* lpSystemName, [NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPSTR")] sbyte* Name, [NativeTypeName("LPDWORD")] uint* cchName, [NativeTypeName("LPSTR")] sbyte* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LookupAccountSidW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupAccountSidW([NativeTypeName("LPCWSTR")] ushort* lpSystemName, [NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPWSTR")] ushort* Name, [NativeTypeName("LPDWORD")] uint* cchName, [NativeTypeName("LPWSTR")] ushort* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LookupAccountNameA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupAccountNameA([NativeTypeName("LPCSTR")] sbyte* lpSystemName, [NativeTypeName("LPCSTR")] sbyte* lpAccountName, [NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPDWORD")] uint* cbSid, [NativeTypeName("LPSTR")] sbyte* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LookupAccountNameW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupAccountNameW([NativeTypeName("LPCWSTR")] ushort* lpSystemName, [NativeTypeName("LPCWSTR")] ushort* lpAccountName, [NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPDWORD")] uint* cbSid, [NativeTypeName("LPWSTR")] ushort* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LookupAccountSidLocalA"]/*' />
    [DllImport("sechost", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupAccountSidLocalA([NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPSTR")] sbyte* Name, [NativeTypeName("LPDWORD")] uint* cchName, [NativeTypeName("LPSTR")] sbyte* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LookupAccountSidLocalW"]/*' />
    [DllImport("sechost", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupAccountSidLocalW([NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPWSTR")] ushort* Name, [NativeTypeName("LPDWORD")] uint* cchName, [NativeTypeName("LPWSTR")] ushort* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LookupPrivilegeValueA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupPrivilegeValueA([NativeTypeName("LPCSTR")] sbyte* lpSystemName, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("PLUID")] LUID* lpLuid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LookupPrivilegeValueW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupPrivilegeValueW([NativeTypeName("LPCWSTR")] ushort* lpSystemName, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("PLUID")] LUID* lpLuid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LookupPrivilegeNameA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupPrivilegeNameA([NativeTypeName("LPCSTR")] sbyte* lpSystemName, [NativeTypeName("PLUID")] LUID* lpLuid, [NativeTypeName("LPSTR")] sbyte* lpName, [NativeTypeName("LPDWORD")] uint* cchName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LookupPrivilegeNameW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupPrivilegeNameW([NativeTypeName("LPCWSTR")] ushort* lpSystemName, [NativeTypeName("PLUID")] LUID* lpLuid, [NativeTypeName("LPWSTR")] ushort* lpName, [NativeTypeName("LPDWORD")] uint* cchName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LookupPrivilegeDisplayNameA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupPrivilegeDisplayNameA([NativeTypeName("LPCSTR")] sbyte* lpSystemName, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPSTR")] sbyte* lpDisplayName, [NativeTypeName("LPDWORD")] uint* cchDisplayName, [NativeTypeName("LPDWORD")] uint* lpLanguageId);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LookupPrivilegeDisplayNameW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupPrivilegeDisplayNameW([NativeTypeName("LPCWSTR")] ushort* lpSystemName, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPWSTR")] ushort* lpDisplayName, [NativeTypeName("LPDWORD")] uint* cchDisplayName, [NativeTypeName("LPDWORD")] uint* lpLanguageId);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BuildCommDCBA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL BuildCommDCBA([NativeTypeName("LPCSTR")] sbyte* lpDef, [NativeTypeName("LPDCB")] DCB* lpDCB);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BuildCommDCBW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL BuildCommDCBW([NativeTypeName("LPCWSTR")] ushort* lpDef, [NativeTypeName("LPDCB")] DCB* lpDCB);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BuildCommDCBAndTimeoutsA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL BuildCommDCBAndTimeoutsA([NativeTypeName("LPCSTR")] sbyte* lpDef, [NativeTypeName("LPDCB")] DCB* lpDCB, [NativeTypeName("LPCOMMTIMEOUTS")] COMMTIMEOUTS* lpCommTimeouts);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BuildCommDCBAndTimeoutsW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL BuildCommDCBAndTimeoutsW([NativeTypeName("LPCWSTR")] ushort* lpDef, [NativeTypeName("LPDCB")] DCB* lpDCB, [NativeTypeName("LPCOMMTIMEOUTS")] COMMTIMEOUTS* lpCommTimeouts);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CommConfigDialogA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CommConfigDialogA([NativeTypeName("LPCSTR")] sbyte* lpszName, HWND hWnd, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CommConfigDialogW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CommConfigDialogW([NativeTypeName("LPCWSTR")] ushort* lpszName, HWND hWnd, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDefaultCommConfigA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetDefaultCommConfigA([NativeTypeName("LPCSTR")] sbyte* lpszName, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC, [NativeTypeName("LPDWORD")] uint* lpdwSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDefaultCommConfigW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetDefaultCommConfigW([NativeTypeName("LPCWSTR")] ushort* lpszName, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC, [NativeTypeName("LPDWORD")] uint* lpdwSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetDefaultCommConfigA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetDefaultCommConfigA([NativeTypeName("LPCSTR")] sbyte* lpszName, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC, [NativeTypeName("DWORD")] uint dwSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetDefaultCommConfigW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetDefaultCommConfigW([NativeTypeName("LPCWSTR")] ushort* lpszName, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC, [NativeTypeName("DWORD")] uint dwSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetComputerNameA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetComputerNameA([NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("LPDWORD")] uint* nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetComputerNameW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetComputerNameW([NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("LPDWORD")] uint* nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DnsHostnameToComputerNameA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DnsHostnameToComputerNameA([NativeTypeName("LPCSTR")] sbyte* Hostname, [NativeTypeName("LPSTR")] sbyte* ComputerName, [NativeTypeName("LPDWORD")] uint* nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DnsHostnameToComputerNameW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DnsHostnameToComputerNameW([NativeTypeName("LPCWSTR")] ushort* Hostname, [NativeTypeName("LPWSTR")] ushort* ComputerName, [NativeTypeName("LPDWORD")] uint* nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetUserNameA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetUserNameA([NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("LPDWORD")] uint* pcbBuffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetUserNameW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetUserNameW([NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("LPDWORD")] uint* pcbBuffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LogonUserA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LogonUserA([NativeTypeName("LPCSTR")] sbyte* lpszUsername, [NativeTypeName("LPCSTR")] sbyte* lpszDomain, [NativeTypeName("LPCSTR")] sbyte* lpszPassword, [NativeTypeName("DWORD")] uint dwLogonType, [NativeTypeName("DWORD")] uint dwLogonProvider, [NativeTypeName("PHANDLE")] HANDLE* phToken);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LogonUserW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LogonUserW([NativeTypeName("LPCWSTR")] ushort* lpszUsername, [NativeTypeName("LPCWSTR")] ushort* lpszDomain, [NativeTypeName("LPCWSTR")] ushort* lpszPassword, [NativeTypeName("DWORD")] uint dwLogonType, [NativeTypeName("DWORD")] uint dwLogonProvider, [NativeTypeName("PHANDLE")] HANDLE* phToken);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LogonUserExA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LogonUserExA([NativeTypeName("LPCSTR")] sbyte* lpszUsername, [NativeTypeName("LPCSTR")] sbyte* lpszDomain, [NativeTypeName("LPCSTR")] sbyte* lpszPassword, [NativeTypeName("DWORD")] uint dwLogonType, [NativeTypeName("DWORD")] uint dwLogonProvider, [NativeTypeName("PHANDLE")] HANDLE* phToken, [NativeTypeName("PSID *")] void** ppLogonSid, [NativeTypeName("PVOID *")] void** ppProfileBuffer, [NativeTypeName("LPDWORD")] uint* pdwProfileLength, [NativeTypeName("PQUOTA_LIMITS")] QUOTA_LIMITS* pQuotaLimits);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LogonUserExW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LogonUserExW([NativeTypeName("LPCWSTR")] ushort* lpszUsername, [NativeTypeName("LPCWSTR")] ushort* lpszDomain, [NativeTypeName("LPCWSTR")] ushort* lpszPassword, [NativeTypeName("DWORD")] uint dwLogonType, [NativeTypeName("DWORD")] uint dwLogonProvider, [NativeTypeName("PHANDLE")] HANDLE* phToken, [NativeTypeName("PSID *")] void** ppLogonSid, [NativeTypeName("PVOID *")] void** ppProfileBuffer, [NativeTypeName("LPDWORD")] uint* pdwProfileLength, [NativeTypeName("PQUOTA_LIMITS")] QUOTA_LIMITS* pQuotaLimits);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateProcessWithLogonW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateProcessWithLogonW([NativeTypeName("LPCWSTR")] ushort* lpUsername, [NativeTypeName("LPCWSTR")] ushort* lpDomain, [NativeTypeName("LPCWSTR")] ushort* lpPassword, [NativeTypeName("DWORD")] uint dwLogonFlags, [NativeTypeName("LPCWSTR")] ushort* lpApplicationName, [NativeTypeName("LPWSTR")] ushort* lpCommandLine, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPVOID")] void* lpEnvironment, [NativeTypeName("LPCWSTR")] ushort* lpCurrentDirectory, [NativeTypeName("LPSTARTUPINFOW")] STARTUPINFOW* lpStartupInfo, [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateProcessWithTokenW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateProcessWithTokenW(HANDLE hToken, [NativeTypeName("DWORD")] uint dwLogonFlags, [NativeTypeName("LPCWSTR")] ushort* lpApplicationName, [NativeTypeName("LPWSTR")] ushort* lpCommandLine, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPVOID")] void* lpEnvironment, [NativeTypeName("LPCWSTR")] ushort* lpCurrentDirectory, [NativeTypeName("LPSTARTUPINFOW")] STARTUPINFOW* lpStartupInfo, [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsTokenUntrusted"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    public static extern BOOL IsTokenUntrusted(HANDLE TokenHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterWaitForSingleObject"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RegisterWaitForSingleObject([NativeTypeName("PHANDLE")] HANDLE* phNewWaitObject, HANDLE hObject, [NativeTypeName("WAITORTIMERCALLBACK")] delegate* unmanaged<void*, byte, void> Callback, [NativeTypeName("PVOID")] void* Context, [NativeTypeName("ULONG")] uint dwMilliseconds, [NativeTypeName("ULONG")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnregisterWait"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UnregisterWait(HANDLE WaitHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BindIoCompletionCallback"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL BindIoCompletionCallback(HANDLE FileHandle, [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")] delegate* unmanaged<uint, uint, OVERLAPPED*, void> Function, [NativeTypeName("ULONG")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetTimerQueueTimer"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HANDLE SetTimerQueueTimer(HANDLE TimerQueue, [NativeTypeName("WAITORTIMERCALLBACK")] delegate* unmanaged<void*, byte, void> Callback, [NativeTypeName("PVOID")] void* Parameter, [NativeTypeName("DWORD")] uint DueTime, [NativeTypeName("DWORD")] uint Period, BOOL PreferIo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CancelTimerQueueTimer"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL CancelTimerQueueTimer(HANDLE TimerQueue, HANDLE Timer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreatePrivateNamespaceA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreatePrivateNamespaceA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpPrivateNamespaceAttributes, [NativeTypeName("LPVOID")] void* lpBoundaryDescriptor, [NativeTypeName("LPCSTR")] sbyte* lpAliasPrefix);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenPrivateNamespaceA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HANDLE OpenPrivateNamespaceA([NativeTypeName("LPVOID")] void* lpBoundaryDescriptor, [NativeTypeName("LPCSTR")] sbyte* lpAliasPrefix);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateBoundaryDescriptorA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateBoundaryDescriptorA([NativeTypeName("LPCSTR")] sbyte* Name, [NativeTypeName("ULONG")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddIntegrityLabelToBoundaryDescriptor"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddIntegrityLabelToBoundaryDescriptor(HANDLE* BoundaryDescriptor, [NativeTypeName("PSID")] void* IntegrityLabel);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentHwProfileA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetCurrentHwProfileA([NativeTypeName("LPHW_PROFILE_INFOA")] HW_PROFILE_INFOA* lpHwProfileInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentHwProfileW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetCurrentHwProfileW([NativeTypeName("LPHW_PROFILE_INFOW")] HW_PROFILE_INFOW* lpHwProfileInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VerifyVersionInfoA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL VerifyVersionInfoA([NativeTypeName("LPOSVERSIONINFOEXA")] OSVERSIONINFOEXA* lpVersionInformation, [NativeTypeName("DWORD")] uint dwTypeMask, [NativeTypeName("DWORDLONG")] ulong dwlConditionMask);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VerifyVersionInfoW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL VerifyVersionInfoW([NativeTypeName("LPOSVERSIONINFOEXW")] OSVERSIONINFOEXW* lpVersionInformation, [NativeTypeName("DWORD")] uint dwTypeMask, [NativeTypeName("DWORDLONG")] ulong dwlConditionMask);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetSystemPowerState"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetSystemPowerState(BOOL fSuspend, BOOL fForce);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSystemPowerStatus"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetSystemPowerStatus([NativeTypeName("LPSYSTEM_POWER_STATUS")] SYSTEM_POWER_STATUS* lpSystemPowerStatus);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MapUserPhysicalPagesScatter"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MapUserPhysicalPagesScatter([NativeTypeName("PVOID *")] void** VirtualAddresses, [NativeTypeName("ULONG_PTR")] nuint NumberOfPages, [NativeTypeName("PULONG_PTR")] nuint* PageArray);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateJobObjectA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateJobObjectA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpJobAttributes, [NativeTypeName("LPCSTR")] sbyte* lpName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenJobObjectA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenJobObjectA([NativeTypeName("DWORD")] uint dwDesiredAccess, BOOL bInheritHandle, [NativeTypeName("LPCSTR")] sbyte* lpName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateJobSet"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL CreateJobSet([NativeTypeName("ULONG")] uint NumJob, [NativeTypeName("PJOB_SET_ARRAY")] JOB_SET_ARRAY* UserJobSet, [NativeTypeName("ULONG")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindFirstVolumeA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstVolumeA([NativeTypeName("LPSTR")] sbyte* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindNextVolumeA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindNextVolumeA(HANDLE hFindVolume, [NativeTypeName("LPSTR")] sbyte* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindFirstVolumeMountPointA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstVolumeMountPointA([NativeTypeName("LPCSTR")] sbyte* lpszRootPathName, [NativeTypeName("LPSTR")] sbyte* lpszVolumeMountPoint, [NativeTypeName("DWORD")] uint cchBufferLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindFirstVolumeMountPointW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstVolumeMountPointW([NativeTypeName("LPCWSTR")] ushort* lpszRootPathName, [NativeTypeName("LPWSTR")] ushort* lpszVolumeMountPoint, [NativeTypeName("DWORD")] uint cchBufferLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindNextVolumeMountPointA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindNextVolumeMountPointA(HANDLE hFindVolumeMountPoint, [NativeTypeName("LPSTR")] sbyte* lpszVolumeMountPoint, [NativeTypeName("DWORD")] uint cchBufferLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindNextVolumeMountPointW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindNextVolumeMountPointW(HANDLE hFindVolumeMountPoint, [NativeTypeName("LPWSTR")] ushort* lpszVolumeMountPoint, [NativeTypeName("DWORD")] uint cchBufferLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindVolumeMountPointClose"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindVolumeMountPointClose(HANDLE hFindVolumeMountPoint);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetVolumeMountPointA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetVolumeMountPointA([NativeTypeName("LPCSTR")] sbyte* lpszVolumeMountPoint, [NativeTypeName("LPCSTR")] sbyte* lpszVolumeName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetVolumeMountPointW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetVolumeMountPointW([NativeTypeName("LPCWSTR")] ushort* lpszVolumeMountPoint, [NativeTypeName("LPCWSTR")] ushort* lpszVolumeName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeleteVolumeMountPointA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeleteVolumeMountPointA([NativeTypeName("LPCSTR")] sbyte* lpszVolumeMountPoint);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetVolumeNameForVolumeMountPointA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetVolumeNameForVolumeMountPointA([NativeTypeName("LPCSTR")] sbyte* lpszVolumeMountPoint, [NativeTypeName("LPSTR")] sbyte* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetVolumePathNameA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetVolumePathNameA([NativeTypeName("LPCSTR")] sbyte* lpszFileName, [NativeTypeName("LPSTR")] sbyte* lpszVolumePathName, [NativeTypeName("DWORD")] uint cchBufferLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetVolumePathNamesForVolumeNameA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetVolumePathNamesForVolumeNameA([NativeTypeName("LPCSTR")] sbyte* lpszVolumeName, [NativeTypeName("LPCH")] sbyte* lpszVolumePathNames, [NativeTypeName("DWORD")] uint cchBufferLength, [NativeTypeName("PDWORD")] uint* lpcchReturnLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateActCtxA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateActCtxA([NativeTypeName("PCACTCTXA")] ACTCTXA* pActCtx);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateActCtxW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateActCtxW([NativeTypeName("PCACTCTXW")] ACTCTXW* pActCtx);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddRefActCtx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void AddRefActCtx(HANDLE hActCtx);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReleaseActCtx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void ReleaseActCtx(HANDLE hActCtx);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ZombifyActCtx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ZombifyActCtx(HANDLE hActCtx);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ActivateActCtx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ActivateActCtx(HANDLE hActCtx, [NativeTypeName("ULONG_PTR *")] nuint* lpCookie);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeactivateActCtx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeactivateActCtx([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG_PTR")] nuint ulCookie);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentActCtx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetCurrentActCtx(HANDLE* lphActCtx);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindActCtxSectionStringA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindActCtxSectionStringA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const GUID *")] Guid* lpExtensionGuid, [NativeTypeName("ULONG")] uint ulSectionId, [NativeTypeName("LPCSTR")] sbyte* lpStringToFind, [NativeTypeName("PACTCTX_SECTION_KEYED_DATA")] ACTCTX_SECTION_KEYED_DATA* ReturnedData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindActCtxSectionStringW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindActCtxSectionStringW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const GUID *")] Guid* lpExtensionGuid, [NativeTypeName("ULONG")] uint ulSectionId, [NativeTypeName("LPCWSTR")] ushort* lpStringToFind, [NativeTypeName("PACTCTX_SECTION_KEYED_DATA")] ACTCTX_SECTION_KEYED_DATA* ReturnedData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindActCtxSectionGuid"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindActCtxSectionGuid([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const GUID *")] Guid* lpExtensionGuid, [NativeTypeName("ULONG")] uint ulSectionId, [NativeTypeName("const GUID *")] Guid* lpGuidToFind, [NativeTypeName("PACTCTX_SECTION_KEYED_DATA")] ACTCTX_SECTION_KEYED_DATA* ReturnedData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.QueryActCtxW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL QueryActCtxW([NativeTypeName("DWORD")] uint dwFlags, HANDLE hActCtx, [NativeTypeName("PVOID")] void* pvSubInstance, [NativeTypeName("ULONG")] uint ulInfoClass, [NativeTypeName("PVOID")] void* pvBuffer, [NativeTypeName("SIZE_T")] nuint cbBuffer, [NativeTypeName("SIZE_T *")] nuint* pcbWrittenOrRequired);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WTSGetActiveConsoleSessionId"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WTSGetActiveConsoleSessionId();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WTSGetServiceSessionId"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WTSGetServiceSessionId();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WTSIsServerContainer"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte WTSIsServerContainer();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetActiveProcessorGroupCount"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("WORD")]
    public static extern ushort GetActiveProcessorGroupCount();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMaximumProcessorGroupCount"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("WORD")]
    public static extern ushort GetMaximumProcessorGroupCount();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetActiveProcessorCount"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetActiveProcessorCount([NativeTypeName("WORD")] ushort GroupNumber);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMaximumProcessorCount"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetMaximumProcessorCount([NativeTypeName("WORD")] ushort GroupNumber);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetNumaProcessorNode"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNumaProcessorNode([NativeTypeName("UCHAR")] byte Processor, [NativeTypeName("PUCHAR")] byte* NodeNumber);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetNumaNodeNumberFromHandle"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNumaNodeNumberFromHandle(HANDLE hFile, [NativeTypeName("PUSHORT")] ushort* NodeNumber);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetNumaProcessorNodeEx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNumaProcessorNodeEx([NativeTypeName("PPROCESSOR_NUMBER")] PROCESSOR_NUMBER* Processor, [NativeTypeName("PUSHORT")] ushort* NodeNumber);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetNumaNodeProcessorMask"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNumaNodeProcessorMask([NativeTypeName("UCHAR")] byte Node, [NativeTypeName("PULONGLONG")] ulong* ProcessorMask);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetNumaAvailableMemoryNode"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNumaAvailableMemoryNode([NativeTypeName("UCHAR")] byte Node, [NativeTypeName("PULONGLONG")] ulong* AvailableBytes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetNumaAvailableMemoryNodeEx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNumaAvailableMemoryNodeEx(ushort Node, [NativeTypeName("PULONGLONG")] ulong* AvailableBytes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetNumaProximityNode"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNumaProximityNode([NativeTypeName("ULONG")] uint ProximityId, [NativeTypeName("PUCHAR")] byte* NodeNumber);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterApplicationRecoveryCallback"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HRESULT RegisterApplicationRecoveryCallback([NativeTypeName("APPLICATION_RECOVERY_CALLBACK")] delegate* unmanaged<void*, uint> pRecoveyCallback, [NativeTypeName("PVOID")] void* pvParameter, [NativeTypeName("DWORD")] uint dwPingInterval, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnregisterApplicationRecoveryCallback"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HRESULT UnregisterApplicationRecoveryCallback();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterApplicationRestart"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HRESULT RegisterApplicationRestart([NativeTypeName("PCWSTR")] ushort* pwzCommandline, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnregisterApplicationRestart"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HRESULT UnregisterApplicationRestart();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetApplicationRecoveryCallback"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HRESULT GetApplicationRecoveryCallback(HANDLE hProcess, [NativeTypeName("APPLICATION_RECOVERY_CALLBACK *")] delegate* unmanaged<void*, uint>* pRecoveryCallback, [NativeTypeName("PVOID *")] void** ppvParameter, [NativeTypeName("PDWORD")] uint* pdwPingInterval, [NativeTypeName("PDWORD")] uint* pdwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetApplicationRestartSettings"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HRESULT GetApplicationRestartSettings(HANDLE hProcess, [NativeTypeName("PWSTR")] ushort* pwzCommandline, [NativeTypeName("PDWORD")] uint* pcchSize, [NativeTypeName("PDWORD")] uint* pdwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ApplicationRecoveryInProgress"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HRESULT ApplicationRecoveryInProgress([NativeTypeName("PBOOL")] BOOL* pbCancelled);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ApplicationRecoveryFinished"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void ApplicationRecoveryFinished(BOOL bSuccess);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFileInformationByHandleEx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetFileInformationByHandleEx(HANDLE hFile, FILE_INFO_BY_HANDLE_CLASS FileInformationClass, [NativeTypeName("LPVOID")] void* lpFileInformation, [NativeTypeName("DWORD")] uint dwBufferSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenFileById"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenFileById(HANDLE hVolumeHint, [NativeTypeName("LPFILE_ID_DESCRIPTOR")] FILE_ID_DESCRIPTOR* lpFileId, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateSymbolicLinkA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte CreateSymbolicLinkA([NativeTypeName("LPCSTR")] sbyte* lpSymlinkFileName, [NativeTypeName("LPCSTR")] sbyte* lpTargetFileName, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateSymbolicLinkW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte CreateSymbolicLinkW([NativeTypeName("LPCWSTR")] ushort* lpSymlinkFileName, [NativeTypeName("LPCWSTR")] ushort* lpTargetFileName, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.QueryActCtxSettingsW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL QueryActCtxSettingsW([NativeTypeName("DWORD")] uint dwFlags, HANDLE hActCtx, [NativeTypeName("PCWSTR")] ushort* settingsNameSpace, [NativeTypeName("PCWSTR")] ushort* settingName, [NativeTypeName("PWSTR")] ushort* pvBuffer, [NativeTypeName("SIZE_T")] nuint dwBuffer, [NativeTypeName("SIZE_T *")] nuint* pdwWrittenOrRequired);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateSymbolicLinkTransactedA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte CreateSymbolicLinkTransactedA([NativeTypeName("LPCSTR")] sbyte* lpSymlinkFileName, [NativeTypeName("LPCSTR")] sbyte* lpTargetFileName, [NativeTypeName("DWORD")] uint dwFlags, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateSymbolicLinkTransactedW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte CreateSymbolicLinkTransactedW([NativeTypeName("LPCWSTR")] ushort* lpSymlinkFileName, [NativeTypeName("LPCWSTR")] ushort* lpTargetFileName, [NativeTypeName("DWORD")] uint dwFlags, HANDLE hTransaction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReplacePartitionUnit"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL ReplacePartitionUnit([NativeTypeName("PWSTR")] ushort* TargetPartition, [NativeTypeName("PWSTR")] ushort* SparePartition, [NativeTypeName("ULONG")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddSecureMemoryCacheCallback"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddSecureMemoryCacheCallback([NativeTypeName("PSECURE_MEMORY_CACHE_CALLBACK")] delegate* unmanaged<void*, nuint, byte> pfnCallBack);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RemoveSecureMemoryCacheCallback"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL RemoveSecureMemoryCacheCallback([NativeTypeName("PSECURE_MEMORY_CACHE_CALLBACK")] delegate* unmanaged<void*, nuint, byte> pfnCallBack);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CopyContext"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CopyContext([NativeTypeName("PCONTEXT")] void* Destination, [NativeTypeName("DWORD")] uint ContextFlags, [NativeTypeName("PCONTEXT")] void* Source);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitializeContext"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InitializeContext([NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("DWORD")] uint ContextFlags, [NativeTypeName("PCONTEXT *")] void** Context, [NativeTypeName("PDWORD")] uint* ContextLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitializeContext2"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL InitializeContext2([NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("DWORD")] uint ContextFlags, [NativeTypeName("PCONTEXT *")] void** Context, [NativeTypeName("PDWORD")] uint* ContextLength, [NativeTypeName("ULONG64")] ulong XStateCompactionMask);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetEnabledXStateFeatures"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD64")]
    public static extern ulong GetEnabledXStateFeatures();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetXStateFeaturesMask"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL GetXStateFeaturesMask([NativeTypeName("PCONTEXT")] void* Context, [NativeTypeName("PDWORD64")] ulong* FeatureMask);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LocateXStateFeature"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("PVOID")]
    public static extern void* LocateXStateFeature([NativeTypeName("PCONTEXT")] void* Context, [NativeTypeName("DWORD")] uint FeatureId, [NativeTypeName("PDWORD")] uint* Length);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetXStateFeaturesMask"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL SetXStateFeaturesMask([NativeTypeName("PCONTEXT")] void* Context, [NativeTypeName("DWORD64")] ulong FeatureMask);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThreadEnabledXStateFeatures"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD64")]
    public static extern ulong GetThreadEnabledXStateFeatures();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnableProcessOptionalXStateFeatures"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL EnableProcessOptionalXStateFeatures([NativeTypeName("DWORD64")] ulong Features);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnableThreadProfiling"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint EnableThreadProfiling(HANDLE ThreadHandle, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD64")] ulong HardwareCounters, HANDLE* PerformanceDataHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DisableThreadProfiling"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint DisableThreadProfiling(HANDLE PerformanceDataHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.QueryThreadProfiling"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint QueryThreadProfiling(HANDLE ThreadHandle, [NativeTypeName("PBOOLEAN")] byte* Enabled);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReadThreadProfilingData"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint ReadThreadProfilingData(HANDLE PerformanceDataHandle, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PPERFORMANCE_DATA")] PERFORMANCE_DATA* PerformanceData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RaiseCustomSystemEventTrigger"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint RaiseCustomSystemEventTrigger([NativeTypeName("PCUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG")] CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG* CustomSystemEventTriggerConfig);

    [NativeTypeName("#define PROGRESS_CONTINUE 0")]
    public const int PROGRESS_CONTINUE = 0;

    [NativeTypeName("#define PROGRESS_CANCEL 1")]
    public const int PROGRESS_CANCEL = 1;

    [NativeTypeName("#define PROGRESS_STOP 2")]
    public const int PROGRESS_STOP = 2;

    [NativeTypeName("#define PROGRESS_QUIET 3")]
    public const int PROGRESS_QUIET = 3;

    [NativeTypeName("#define CALLBACK_CHUNK_FINISHED 0x00000000")]
    public const int CALLBACK_CHUNK_FINISHED = 0x00000000;

    [NativeTypeName("#define CALLBACK_STREAM_SWITCH 0x00000001")]
    public const int CALLBACK_STREAM_SWITCH = 0x00000001;

    [NativeTypeName("#define REPLACEFILE_WRITE_THROUGH 0x00000001")]
    public const int REPLACEFILE_WRITE_THROUGH = 0x00000001;

    [NativeTypeName("#define REPLACEFILE_IGNORE_MERGE_ERRORS 0x00000002")]
    public const int REPLACEFILE_IGNORE_MERGE_ERRORS = 0x00000002;

    [NativeTypeName("#define REPLACEFILE_IGNORE_ACL_ERRORS 0x00000004")]
    public const int REPLACEFILE_IGNORE_ACL_ERRORS = 0x00000004;

    [NativeTypeName("#define FAIL_FAST_GENERATE_EXCEPTION_ADDRESS 0x1")]
    public const int FAIL_FAST_GENERATE_EXCEPTION_ADDRESS = 0x1;

    [NativeTypeName("#define FAIL_FAST_NO_HARD_ERROR_DLG 0x2")]
    public const int FAIL_FAST_NO_HARD_ERROR_DLG = 0x2;

    [NativeTypeName("#define DATABITS_5 ((WORD)0x0001)")]
    public const ushort DATABITS_5 = ((ushort)(0x0001));

    [NativeTypeName("#define DATABITS_6 ((WORD)0x0002)")]
    public const ushort DATABITS_6 = ((ushort)(0x0002));

    [NativeTypeName("#define DATABITS_7 ((WORD)0x0004)")]
    public const ushort DATABITS_7 = ((ushort)(0x0004));

    [NativeTypeName("#define DATABITS_8 ((WORD)0x0008)")]
    public const ushort DATABITS_8 = ((ushort)(0x0008));

    [NativeTypeName("#define DATABITS_16 ((WORD)0x0010)")]
    public const ushort DATABITS_16 = ((ushort)(0x0010));

    [NativeTypeName("#define DATABITS_16X ((WORD)0x0020)")]
    public const ushort DATABITS_16X = ((ushort)(0x0020));

    [NativeTypeName("#define STOPBITS_10 ((WORD)0x0001)")]
    public const ushort STOPBITS_10 = ((ushort)(0x0001));

    [NativeTypeName("#define STOPBITS_15 ((WORD)0x0002)")]
    public const ushort STOPBITS_15 = ((ushort)(0x0002));

    [NativeTypeName("#define STOPBITS_20 ((WORD)0x0004)")]
    public const ushort STOPBITS_20 = ((ushort)(0x0004));

    [NativeTypeName("#define PARITY_NONE ((WORD)0x0100)")]
    public const ushort PARITY_NONE = ((ushort)(0x0100));

    [NativeTypeName("#define PARITY_ODD ((WORD)0x0200)")]
    public const ushort PARITY_ODD = ((ushort)(0x0200));

    [NativeTypeName("#define PARITY_EVEN ((WORD)0x0400)")]
    public const ushort PARITY_EVEN = ((ushort)(0x0400));

    [NativeTypeName("#define PARITY_MARK ((WORD)0x0800)")]
    public const ushort PARITY_MARK = ((ushort)(0x0800));

    [NativeTypeName("#define PARITY_SPACE ((WORD)0x1000)")]
    public const ushort PARITY_SPACE = ((ushort)(0x1000));

    [NativeTypeName("#define COMMPROP_INITIALIZED ((DWORD)0xE73CF52E)")]
    public const uint COMMPROP_INITIALIZED = ((uint)(0xE73CF52E));

    [NativeTypeName("#define DTR_CONTROL_DISABLE 0x00")]
    public const int DTR_CONTROL_DISABLE = 0x00;

    [NativeTypeName("#define DTR_CONTROL_ENABLE 0x01")]
    public const int DTR_CONTROL_ENABLE = 0x01;

    [NativeTypeName("#define DTR_CONTROL_HANDSHAKE 0x02")]
    public const int DTR_CONTROL_HANDSHAKE = 0x02;

    [NativeTypeName("#define RTS_CONTROL_DISABLE 0x00")]
    public const int RTS_CONTROL_DISABLE = 0x00;

    [NativeTypeName("#define RTS_CONTROL_ENABLE 0x01")]
    public const int RTS_CONTROL_ENABLE = 0x01;

    [NativeTypeName("#define RTS_CONTROL_HANDSHAKE 0x02")]
    public const int RTS_CONTROL_HANDSHAKE = 0x02;

    [NativeTypeName("#define RTS_CONTROL_TOGGLE 0x03")]
    public const int RTS_CONTROL_TOGGLE = 0x03;

    [NativeTypeName("#define GHND (GMEM_MOVEABLE | GMEM_ZEROINIT)")]
    public const int GHND = (0x0002 | 0x0040);

    [NativeTypeName("#define GPTR (GMEM_FIXED | GMEM_ZEROINIT)")]
    public const int GPTR = (0x0000 | 0x0040);

    [NativeTypeName("#define DEBUG_PROCESS 0x00000001")]
    public const int DEBUG_PROCESS = 0x00000001;

    [NativeTypeName("#define DEBUG_ONLY_THIS_PROCESS 0x00000002")]
    public const int DEBUG_ONLY_THIS_PROCESS = 0x00000002;

    [NativeTypeName("#define DETACHED_PROCESS 0x00000008")]
    public const int DETACHED_PROCESS = 0x00000008;

    [NativeTypeName("#define NORMAL_PRIORITY_CLASS 0x00000020")]
    public const int NORMAL_PRIORITY_CLASS = 0x00000020;

    [NativeTypeName("#define IDLE_PRIORITY_CLASS 0x00000040")]
    public const int IDLE_PRIORITY_CLASS = 0x00000040;

    [NativeTypeName("#define HIGH_PRIORITY_CLASS 0x00000080")]
    public const int HIGH_PRIORITY_CLASS = 0x00000080;

    [NativeTypeName("#define REALTIME_PRIORITY_CLASS 0x00000100")]
    public const int REALTIME_PRIORITY_CLASS = 0x00000100;

    [NativeTypeName("#define BELOW_NORMAL_PRIORITY_CLASS 0x00004000")]
    public const int BELOW_NORMAL_PRIORITY_CLASS = 0x00004000;

    [NativeTypeName("#define ABOVE_NORMAL_PRIORITY_CLASS 0x00008000")]
    public const int ABOVE_NORMAL_PRIORITY_CLASS = 0x00008000;

    [NativeTypeName("#define INHERIT_PARENT_AFFINITY 0x00010000")]
    public const int INHERIT_PARENT_AFFINITY = 0x00010000;

    [NativeTypeName("#define INHERIT_CALLER_PRIORITY 0x00020000")]
    public const int INHERIT_CALLER_PRIORITY = 0x00020000;

    [NativeTypeName("#define EXTENDED_STARTUPINFO_PRESENT 0x00080000")]
    public const int EXTENDED_STARTUPINFO_PRESENT = 0x00080000;

    [NativeTypeName("#define PROFILE_USER 0x10000000")]
    public const int PROFILE_USER = 0x10000000;

    [NativeTypeName("#define PROFILE_KERNEL 0x20000000")]
    public const int PROFILE_KERNEL = 0x20000000;

    [NativeTypeName("#define PROFILE_SERVER 0x40000000")]
    public const int PROFILE_SERVER = 0x40000000;

    [NativeTypeName("#define STACK_SIZE_PARAM_IS_A_RESERVATION 0x00010000")]
    public const int STACK_SIZE_PARAM_IS_A_RESERVATION = 0x00010000;

    [NativeTypeName("#define VOLUME_NAME_DOS 0x0")]
    public const int VOLUME_NAME_DOS = 0x0;

    [NativeTypeName("#define VOLUME_NAME_GUID 0x1")]
    public const int VOLUME_NAME_GUID = 0x1;

    [NativeTypeName("#define VOLUME_NAME_NT 0x2")]
    public const int VOLUME_NAME_NT = 0x2;

    [NativeTypeName("#define VOLUME_NAME_NONE 0x4")]
    public const int VOLUME_NAME_NONE = 0x4;

    [NativeTypeName("#define DRIVE_UNKNOWN 0")]
    public const int DRIVE_UNKNOWN = 0;

    [NativeTypeName("#define DRIVE_NO_ROOT_DIR 1")]
    public const int DRIVE_NO_ROOT_DIR = 1;

    [NativeTypeName("#define DRIVE_REMOVABLE 2")]
    public const int DRIVE_REMOVABLE = 2;

    [NativeTypeName("#define DRIVE_FIXED 3")]
    public const int DRIVE_FIXED = 3;

    [NativeTypeName("#define DRIVE_REMOTE 4")]
    public const int DRIVE_REMOTE = 4;

    [NativeTypeName("#define DRIVE_CDROM 5")]
    public const int DRIVE_CDROM = 5;

    [NativeTypeName("#define DRIVE_RAMDISK 6")]
    public const int DRIVE_RAMDISK = 6;

    [NativeTypeName("#define NOPARITY 0")]
    public const int NOPARITY = 0;

    [NativeTypeName("#define ODDPARITY 1")]
    public const int ODDPARITY = 1;

    [NativeTypeName("#define EVENPARITY 2")]
    public const int EVENPARITY = 2;

    [NativeTypeName("#define MARKPARITY 3")]
    public const int MARKPARITY = 3;

    [NativeTypeName("#define SPACEPARITY 4")]
    public const int SPACEPARITY = 4;

    [NativeTypeName("#define ONESTOPBIT 0")]
    public const int ONESTOPBIT = 0;

    [NativeTypeName("#define ONE5STOPBITS 1")]
    public const int ONE5STOPBITS = 1;

    [NativeTypeName("#define TWOSTOPBITS 2")]
    public const int TWOSTOPBITS = 2;

    [NativeTypeName("#define IGNORE 0")]
    public const int IGNORE = 0;

    [NativeTypeName("#define INFINITE 0xFFFFFFFF")]
    public const uint INFINITE = 0xFFFFFFFF;

    [NativeTypeName("#define IE_BADID (-1)")]
    public const int IE_BADID = (-1);

    [NativeTypeName("#define IE_OPEN (-2)")]
    public const int IE_OPEN = (-2);

    [NativeTypeName("#define IE_NOPEN (-3)")]
    public const int IE_NOPEN = (-3);

    [NativeTypeName("#define IE_MEMORY (-4)")]
    public const int IE_MEMORY = (-4);

    [NativeTypeName("#define IE_DEFAULT (-5)")]
    public const int IE_DEFAULT = (-5);

    [NativeTypeName("#define IE_HARDWARE (-10)")]
    public const int IE_HARDWARE = (-10);

    [NativeTypeName("#define IE_BYTESIZE (-11)")]
    public const int IE_BYTESIZE = (-11);

    [NativeTypeName("#define IE_BAUDRATE (-12)")]
    public const int IE_BAUDRATE = (-12);

    [NativeTypeName("#define SETXOFF 1")]
    public const int SETXOFF = 1;

    [NativeTypeName("#define SETXON 2")]
    public const int SETXON = 2;

    [NativeTypeName("#define SETRTS 3")]
    public const int SETRTS = 3;

    [NativeTypeName("#define CLRRTS 4")]
    public const int CLRRTS = 4;

    [NativeTypeName("#define SETDTR 5")]
    public const int SETDTR = 5;

    [NativeTypeName("#define CLRDTR 6")]
    public const int CLRDTR = 6;

    [NativeTypeName("#define RESETDEV 7")]
    public const int RESETDEV = 7;

    [NativeTypeName("#define SETBREAK 8")]
    public const int SETBREAK = 8;

    [NativeTypeName("#define CLRBREAK 9")]
    public const int CLRBREAK = 9;

    [NativeTypeName("#define PURGE_TXABORT 0x0001")]
    public const int PURGE_TXABORT = 0x0001;

    [NativeTypeName("#define PURGE_RXABORT 0x0002")]
    public const int PURGE_RXABORT = 0x0002;

    [NativeTypeName("#define PURGE_TXCLEAR 0x0004")]
    public const int PURGE_TXCLEAR = 0x0004;

    [NativeTypeName("#define PURGE_RXCLEAR 0x0008")]
    public const int PURGE_RXCLEAR = 0x0008;

    [NativeTypeName("#define LPTx 0x80")]
    public const int LPTx = 0x80;

    [NativeTypeName("#define NMPWAIT_WAIT_FOREVER 0xffffffff")]
    public const uint NMPWAIT_WAIT_FOREVER = 0xffffffff;

    [NativeTypeName("#define NMPWAIT_NOWAIT 0x00000001")]
    public const int NMPWAIT_NOWAIT = 0x00000001;

    [NativeTypeName("#define NMPWAIT_USE_DEFAULT_WAIT 0x00000000")]
    public const int NMPWAIT_USE_DEFAULT_WAIT = 0x00000000;

    [NativeTypeName("#define OFS_MAXPATHNAME 128")]
    public const int OFS_MAXPATHNAME = 128;

    [NativeTypeName("#define MAXINTATOM 0xC000")]
    public const int MAXINTATOM = 0xC000;

    [NativeTypeName("#define INVALID_ATOM ((ATOM)0)")]
    public const ushort INVALID_ATOM = ((ushort)(0));

    [NativeTypeName("#define GetBinaryType GetBinaryTypeW")]
    public static delegate*<ushort*, uint*, BOOL> GetBinaryType => &GetBinaryTypeW;

    [NativeTypeName("#define GetLongPathNameTransacted GetLongPathNameTransactedW")]
    public static delegate*<ushort*, ushort*, uint, HANDLE, uint> GetLongPathNameTransacted => &GetLongPathNameTransactedW;

    [NativeTypeName("#define FIBER_FLAG_FLOAT_SWITCH 0x1")]
    public const int FIBER_FLAG_FLOAT_SWITCH = 0x1;

    [NativeTypeName("#define UMS_VERSION RTL_UMS_VERSION")]
    public const int UMS_VERSION = (0x0100);

    [NativeTypeName("#define SEM_FAILCRITICALERRORS 0x0001")]
    public const int SEM_FAILCRITICALERRORS = 0x0001;

    [NativeTypeName("#define SEM_NOGPFAULTERRORBOX 0x0002")]
    public const int SEM_NOGPFAULTERRORBOX = 0x0002;

    [NativeTypeName("#define SEM_NOALIGNMENTFAULTEXCEPT 0x0004")]
    public const int SEM_NOALIGNMENTFAULTEXCEPT = 0x0004;

    [NativeTypeName("#define SEM_NOOPENFILEERRORBOX 0x8000")]
    public const int SEM_NOOPENFILEERRORBOX = 0x8000;

    [NativeTypeName("#define CRITICAL_SECTION_NO_DEBUG_INFO RTL_CRITICAL_SECTION_FLAG_NO_DEBUG_INFO")]
    public const int CRITICAL_SECTION_NO_DEBUG_INFO = 0x01000000;

    [NativeTypeName("#define SetFileShortName SetFileShortNameW")]
    public static delegate*<HANDLE, ushort*, BOOL> SetFileShortName => &SetFileShortNameW;

    [NativeTypeName("#define HINSTANCE_ERROR 32")]
    public const int HINSTANCE_ERROR = 32;

    [NativeTypeName("#define FormatMessage FormatMessageW")]
    public static delegate*<uint, void*, uint, uint, ushort*, uint, sbyte**, uint> FormatMessage => &FormatMessageW;

    [NativeTypeName("#define CreateMailslot CreateMailslotW")]
    public static delegate*<ushort*, uint, uint, SECURITY_ATTRIBUTES*, HANDLE> CreateMailslot => &CreateMailslotW;

    [NativeTypeName("#define EncryptFile EncryptFileW")]
    public static delegate*<ushort*, BOOL> EncryptFile => &EncryptFileW;

    [NativeTypeName("#define DecryptFile DecryptFileW")]
    public static delegate*<ushort*, uint, BOOL> DecryptFile => &DecryptFileW;

    [NativeTypeName("#define FileEncryptionStatus FileEncryptionStatusW")]
    public static delegate*<ushort*, uint*, BOOL> FileEncryptionStatus => &FileEncryptionStatusW;

    [NativeTypeName("#define EFS_USE_RECOVERY_KEYS (0x1)")]
    public const int EFS_USE_RECOVERY_KEYS = (0x1);

    [NativeTypeName("#define OVERWRITE_HIDDEN (4)")]
    public const int OVERWRITE_HIDDEN = (4);

    [NativeTypeName("#define EFSRPC_SECURE_ONLY (8)")]
    public const int EFSRPC_SECURE_ONLY = (8);

    [NativeTypeName("#define EFS_DROP_ALTERNATE_STREAMS (0x10)")]
    public const int EFS_DROP_ALTERNATE_STREAMS = (0x10);

    [NativeTypeName("#define OpenEncryptedFileRaw OpenEncryptedFileRawW")]
    public static delegate*<ushort*, uint, void**, uint> OpenEncryptedFileRaw => &OpenEncryptedFileRawW;

    [NativeTypeName("#define lstrcmp lstrcmpW")]
    public static delegate*<ushort*, ushort*, int> lstrcmp => &lstrcmpW;

    [NativeTypeName("#define lstrcmpi lstrcmpiW")]
    public static delegate*<ushort*, ushort*, int> lstrcmpi => &lstrcmpiW;

    [NativeTypeName("#define lstrcpyn lstrcpynW")]
    public static delegate*<ushort*, ushort*, int, ushort*> lstrcpyn => &lstrcpynW;

    [NativeTypeName("#define lstrcpy lstrcpyW")]
    public static delegate*<ushort*, ushort*, ushort*> lstrcpy => &lstrcpyW;

    [NativeTypeName("#define lstrcat lstrcatW")]
    public static delegate*<ushort*, ushort*, ushort*> lstrcat => &lstrcatW;

    [NativeTypeName("#define lstrlen lstrlenW")]
    public static delegate*<ushort*, int> lstrlen => &lstrlenW;

    [NativeTypeName("#define QueryFullProcessImageName QueryFullProcessImageNameW")]
    public static delegate*<HANDLE, uint, ushort*, uint*, BOOL> QueryFullProcessImageName => &QueryFullProcessImageNameW;

    [NativeTypeName("#define GetFirmwareEnvironmentVariable GetFirmwareEnvironmentVariableW")]
    public static delegate*<ushort*, ushort*, void*, uint, uint> GetFirmwareEnvironmentVariable => &GetFirmwareEnvironmentVariableW;

    [NativeTypeName("#define GetFirmwareEnvironmentVariableEx GetFirmwareEnvironmentVariableExW")]
    [SupportedOSPlatform("windows6.2")]
    public static delegate*<ushort*, ushort*, void*, uint, uint*, uint> GetFirmwareEnvironmentVariableEx => &GetFirmwareEnvironmentVariableExW;

    [NativeTypeName("#define SetFirmwareEnvironmentVariable SetFirmwareEnvironmentVariableW")]
    public static delegate*<ushort*, ushort*, void*, uint, BOOL> SetFirmwareEnvironmentVariable => &SetFirmwareEnvironmentVariableW;

    [NativeTypeName("#define SetFirmwareEnvironmentVariableEx SetFirmwareEnvironmentVariableExW")]
    [SupportedOSPlatform("windows6.2")]
    public static delegate*<ushort*, ushort*, void*, uint, uint, BOOL> SetFirmwareEnvironmentVariableEx => &SetFirmwareEnvironmentVariableExW;

    [NativeTypeName("#define EnumResourceTypes EnumResourceTypesW")]
    public static delegate*<HMODULE, delegate* unmanaged<HMODULE, ushort*, nint, BOOL>, nint, BOOL> EnumResourceTypes => &EnumResourceTypesW;

    [NativeTypeName("#define EnumResourceLanguages EnumResourceLanguagesW")]
    public static delegate*<HMODULE, ushort*, ushort*, delegate* unmanaged<HMODULE, ushort*, ushort*, ushort, nint, BOOL>, nint, BOOL> EnumResourceLanguages => &EnumResourceLanguagesW;

    [NativeTypeName("#define BeginUpdateResource BeginUpdateResourceW")]
    public static delegate*<ushort*, BOOL, HANDLE> BeginUpdateResource => &BeginUpdateResourceW;

    [NativeTypeName("#define UpdateResource UpdateResourceW")]
    public static delegate*<HANDLE, ushort*, ushort*, ushort, void*, uint, BOOL> UpdateResource => &UpdateResourceW;

    [NativeTypeName("#define EndUpdateResource EndUpdateResourceW")]
    public static delegate*<HANDLE, BOOL, BOOL> EndUpdateResource => &EndUpdateResourceW;

    [NativeTypeName("#define ATOM_FLAG_GLOBAL 0x2")]
    public const int ATOM_FLAG_GLOBAL = 0x2;

    [NativeTypeName("#define GlobalAddAtom GlobalAddAtomW")]
    public static delegate*<ushort*, ushort> GlobalAddAtom => &GlobalAddAtomW;

    [NativeTypeName("#define GlobalAddAtomEx GlobalAddAtomExW")]
    public static delegate*<ushort*, uint, ushort> GlobalAddAtomEx => &GlobalAddAtomExW;

    [NativeTypeName("#define GlobalFindAtom GlobalFindAtomW")]
    public static delegate*<ushort*, ushort> GlobalFindAtom => &GlobalFindAtomW;

    [NativeTypeName("#define GlobalGetAtomName GlobalGetAtomNameW")]
    public static delegate*<ushort, ushort*, int, uint> GlobalGetAtomName => &GlobalGetAtomNameW;

    [NativeTypeName("#define AddAtom AddAtomW")]
    public static delegate*<ushort*, ushort> AddAtom => &AddAtomW;

    [NativeTypeName("#define FindAtom FindAtomW")]
    public static delegate*<ushort*, ushort> FindAtom => &FindAtomW;

    [NativeTypeName("#define GetAtomName GetAtomNameW")]
    public static delegate*<ushort, ushort*, int, uint> GetAtomName => &GetAtomNameW;

    [NativeTypeName("#define GetProfileInt GetProfileIntW")]
    public static delegate*<ushort*, ushort*, int, uint> GetProfileInt => &GetProfileIntW;

    [NativeTypeName("#define GetProfileString GetProfileStringW")]
    public static delegate*<ushort*, ushort*, ushort*, ushort*, uint, uint> GetProfileString => &GetProfileStringW;

    [NativeTypeName("#define WriteProfileString WriteProfileStringW")]
    public static delegate*<ushort*, ushort*, ushort*, BOOL> WriteProfileString => &WriteProfileStringW;

    [NativeTypeName("#define GetProfileSection GetProfileSectionW")]
    public static delegate*<ushort*, ushort*, uint, uint> GetProfileSection => &GetProfileSectionW;

    [NativeTypeName("#define WriteProfileSection WriteProfileSectionW")]
    public static delegate*<ushort*, ushort*, BOOL> WriteProfileSection => &WriteProfileSectionW;

    [NativeTypeName("#define GetPrivateProfileInt GetPrivateProfileIntW")]
    public static delegate*<ushort*, ushort*, int, ushort*, uint> GetPrivateProfileInt => &GetPrivateProfileIntW;

    [NativeTypeName("#define GetPrivateProfileString GetPrivateProfileStringW")]
    public static delegate*<ushort*, ushort*, ushort*, ushort*, uint, ushort*, uint> GetPrivateProfileString => &GetPrivateProfileStringW;

    [NativeTypeName("#define WritePrivateProfileString WritePrivateProfileStringW")]
    public static delegate*<ushort*, ushort*, ushort*, ushort*, BOOL> WritePrivateProfileString => &WritePrivateProfileStringW;

    [NativeTypeName("#define GetPrivateProfileSection GetPrivateProfileSectionW")]
    public static delegate*<ushort*, ushort*, uint, ushort*, uint> GetPrivateProfileSection => &GetPrivateProfileSectionW;

    [NativeTypeName("#define WritePrivateProfileSection WritePrivateProfileSectionW")]
    public static delegate*<ushort*, ushort*, ushort*, BOOL> WritePrivateProfileSection => &WritePrivateProfileSectionW;

    [NativeTypeName("#define GetPrivateProfileSectionNames GetPrivateProfileSectionNamesW")]
    public static delegate*<ushort*, uint, ushort*, uint> GetPrivateProfileSectionNames => &GetPrivateProfileSectionNamesW;

    [NativeTypeName("#define GetPrivateProfileStruct GetPrivateProfileStructW")]
    public static delegate*<ushort*, ushort*, void*, uint, ushort*, BOOL> GetPrivateProfileStruct => &GetPrivateProfileStructW;

    [NativeTypeName("#define WritePrivateProfileStruct WritePrivateProfileStructW")]
    public static delegate*<ushort*, ushort*, void*, uint, ushort*, BOOL> WritePrivateProfileStruct => &WritePrivateProfileStructW;

    [NativeTypeName("#define SetDllDirectory SetDllDirectoryW")]
    public static delegate*<ushort*, BOOL> SetDllDirectory => &SetDllDirectoryW;

    [NativeTypeName("#define GetDllDirectory GetDllDirectoryW")]
    public static delegate*<uint, ushort*, uint> GetDllDirectory => &GetDllDirectoryW;

    [NativeTypeName("#define BASE_SEARCH_PATH_ENABLE_SAFE_SEARCHMODE 0x1")]
    public const int BASE_SEARCH_PATH_ENABLE_SAFE_SEARCHMODE = 0x1;

    [NativeTypeName("#define BASE_SEARCH_PATH_DISABLE_SAFE_SEARCHMODE 0x10000")]
    public const int BASE_SEARCH_PATH_DISABLE_SAFE_SEARCHMODE = 0x10000;

    [NativeTypeName("#define BASE_SEARCH_PATH_PERMANENT 0x8000")]
    public const int BASE_SEARCH_PATH_PERMANENT = 0x8000;

    [NativeTypeName("#define BASE_SEARCH_PATH_INVALID_FLAGS ~0x18001")]
    public const int BASE_SEARCH_PATH_INVALID_FLAGS = ~0x18001;

    [NativeTypeName("#define CreateDirectoryEx CreateDirectoryExW")]
    public static delegate*<ushort*, ushort*, SECURITY_ATTRIBUTES*, BOOL> CreateDirectoryEx => &CreateDirectoryExW;

    [NativeTypeName("#define CreateDirectoryTransacted CreateDirectoryTransactedW")]
    public static delegate*<ushort*, ushort*, SECURITY_ATTRIBUTES*, HANDLE, BOOL> CreateDirectoryTransacted => &CreateDirectoryTransactedW;

    [NativeTypeName("#define RemoveDirectoryTransacted RemoveDirectoryTransactedW")]
    public static delegate*<ushort*, HANDLE, BOOL> RemoveDirectoryTransacted => &RemoveDirectoryTransactedW;

    [NativeTypeName("#define GetFullPathNameTransacted GetFullPathNameTransactedW")]
    public static delegate*<ushort*, uint, ushort*, ushort**, HANDLE, uint> GetFullPathNameTransacted => &GetFullPathNameTransactedW;

    [NativeTypeName("#define DDD_RAW_TARGET_PATH 0x00000001")]
    public const int DDD_RAW_TARGET_PATH = 0x00000001;

    [NativeTypeName("#define DDD_REMOVE_DEFINITION 0x00000002")]
    public const int DDD_REMOVE_DEFINITION = 0x00000002;

    [NativeTypeName("#define DDD_EXACT_MATCH_ON_REMOVE 0x00000004")]
    public const int DDD_EXACT_MATCH_ON_REMOVE = 0x00000004;

    [NativeTypeName("#define DDD_NO_BROADCAST_SYSTEM 0x00000008")]
    public const int DDD_NO_BROADCAST_SYSTEM = 0x00000008;

    [NativeTypeName("#define DDD_LUID_BROADCAST_DRIVE 0x00000010")]
    public const int DDD_LUID_BROADCAST_DRIVE = 0x00000010;

    [NativeTypeName("#define CreateFileTransacted CreateFileTransactedW")]
    public static delegate*<ushort*, uint, uint, SECURITY_ATTRIBUTES*, uint, uint, HANDLE, HANDLE, ushort*, void*, HANDLE> CreateFileTransacted => &CreateFileTransactedW;

    [NativeTypeName("#define SetFileAttributesTransacted SetFileAttributesTransactedW")]
    public static delegate*<ushort*, uint, HANDLE, BOOL> SetFileAttributesTransacted => &SetFileAttributesTransactedW;

    [NativeTypeName("#define GetFileAttributesTransacted GetFileAttributesTransactedW")]
    public static delegate*<ushort*, GET_FILEEX_INFO_LEVELS, void*, HANDLE, BOOL> GetFileAttributesTransacted => &GetFileAttributesTransactedW;

    [NativeTypeName("#define GetCompressedFileSizeTransacted GetCompressedFileSizeTransactedW")]
    public static delegate*<ushort*, uint*, HANDLE, uint> GetCompressedFileSizeTransacted => &GetCompressedFileSizeTransactedW;

    [NativeTypeName("#define DeleteFileTransacted DeleteFileTransactedW")]
    public static delegate*<ushort*, HANDLE, BOOL> DeleteFileTransacted => &DeleteFileTransactedW;

    [NativeTypeName("#define CheckNameLegalDOS8Dot3 CheckNameLegalDOS8Dot3W")]
    public static delegate*<ushort*, sbyte*, uint, BOOL*, BOOL*, BOOL> CheckNameLegalDOS8Dot3 => &CheckNameLegalDOS8Dot3W;

    [NativeTypeName("#define FindFirstFileTransacted FindFirstFileTransactedW")]
    public static delegate*<ushort*, FINDEX_INFO_LEVELS, void*, FINDEX_SEARCH_OPS, void*, uint, HANDLE, HANDLE> FindFirstFileTransacted => &FindFirstFileTransactedW;

    [NativeTypeName("#define CopyFile CopyFileW")]
    public static delegate*<ushort*, ushort*, BOOL, BOOL> CopyFile => &CopyFileW;

    [NativeTypeName("#define CopyFileEx CopyFileExW")]
    public static delegate*<ushort*, ushort*, delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, HANDLE, HANDLE, void*, uint>, void*, BOOL*, uint, BOOL> CopyFileEx => &CopyFileExW;

    [NativeTypeName("#define CopyFileTransacted CopyFileTransactedW")]
    public static delegate*<ushort*, ushort*, delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, HANDLE, HANDLE, void*, uint>, void*, BOOL*, uint, HANDLE, BOOL> CopyFileTransacted => &CopyFileTransactedW;

    [NativeTypeName("#define COPYFILE2_MESSAGE_COPY_OFFLOAD (0x00000001L)")]
    public const int COPYFILE2_MESSAGE_COPY_OFFLOAD = (0x00000001);

    [NativeTypeName("#define COPYFILE2_IO_CYCLE_SIZE_MIN 4096")]
    public const int COPYFILE2_IO_CYCLE_SIZE_MIN = 4096;

    [NativeTypeName("#define COPYFILE2_IO_CYCLE_SIZE_MAX 0x40000000")]
    public const int COPYFILE2_IO_CYCLE_SIZE_MAX = 0x40000000;

    [NativeTypeName("#define COPYFILE2_IO_RATE_MIN 512")]
    public const int COPYFILE2_IO_RATE_MIN = 512;

    [NativeTypeName("#define MoveFile MoveFileW")]
    public static delegate*<ushort*, ushort*, BOOL> MoveFile => &MoveFileW;

    [NativeTypeName("#define MoveFileEx MoveFileExW")]
    public static delegate*<ushort*, ushort*, uint, BOOL> MoveFileEx => &MoveFileExW;

    [NativeTypeName("#define MoveFileWithProgress MoveFileWithProgressW")]
    public static delegate*<ushort*, ushort*, delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, HANDLE, HANDLE, void*, uint>, void*, uint, BOOL> MoveFileWithProgress => &MoveFileWithProgressW;

    [NativeTypeName("#define MoveFileTransacted MoveFileTransactedW")]
    public static delegate*<ushort*, ushort*, delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, HANDLE, HANDLE, void*, uint>, void*, uint, HANDLE, BOOL> MoveFileTransacted => &MoveFileTransactedW;

    [NativeTypeName("#define MOVEFILE_REPLACE_EXISTING 0x00000001")]
    public const int MOVEFILE_REPLACE_EXISTING = 0x00000001;

    [NativeTypeName("#define MOVEFILE_COPY_ALLOWED 0x00000002")]
    public const int MOVEFILE_COPY_ALLOWED = 0x00000002;

    [NativeTypeName("#define MOVEFILE_DELAY_UNTIL_REBOOT 0x00000004")]
    public const int MOVEFILE_DELAY_UNTIL_REBOOT = 0x00000004;

    [NativeTypeName("#define MOVEFILE_WRITE_THROUGH 0x00000008")]
    public const int MOVEFILE_WRITE_THROUGH = 0x00000008;

    [NativeTypeName("#define MOVEFILE_CREATE_HARDLINK 0x00000010")]
    public const int MOVEFILE_CREATE_HARDLINK = 0x00000010;

    [NativeTypeName("#define MOVEFILE_FAIL_IF_NOT_TRACKABLE 0x00000020")]
    public const int MOVEFILE_FAIL_IF_NOT_TRACKABLE = 0x00000020;

    [NativeTypeName("#define ReplaceFile ReplaceFileW")]
    public static delegate*<ushort*, ushort*, ushort*, uint, void*, void*, BOOL> ReplaceFile => &ReplaceFileW;

    [NativeTypeName("#define CreateHardLink CreateHardLinkW")]
    public static delegate*<ushort*, ushort*, SECURITY_ATTRIBUTES*, BOOL> CreateHardLink => &CreateHardLinkW;

    [NativeTypeName("#define CreateHardLinkTransacted CreateHardLinkTransactedW")]
    public static delegate*<ushort*, ushort*, SECURITY_ATTRIBUTES*, HANDLE, BOOL> CreateHardLinkTransacted => &CreateHardLinkTransactedW;

    [NativeTypeName("#define SetVolumeLabel SetVolumeLabelW")]
    public static delegate*<ushort*, ushort*, BOOL> SetVolumeLabel => &SetVolumeLabelW;

    [NativeTypeName("#define ClearEventLog ClearEventLogW")]
    public static delegate*<HANDLE, ushort*, BOOL> ClearEventLog => &ClearEventLogW;

    [NativeTypeName("#define BackupEventLog BackupEventLogW")]
    public static delegate*<HANDLE, ushort*, BOOL> BackupEventLog => &BackupEventLogW;

    [NativeTypeName("#define OpenEventLog OpenEventLogW")]
    public static delegate*<ushort*, ushort*, HANDLE> OpenEventLog => &OpenEventLogW;

    [NativeTypeName("#define RegisterEventSource RegisterEventSourceW")]
    public static delegate*<ushort*, ushort*, HANDLE> RegisterEventSource => &RegisterEventSourceW;

    [NativeTypeName("#define OpenBackupEventLog OpenBackupEventLogW")]
    public static delegate*<ushort*, ushort*, HANDLE> OpenBackupEventLog => &OpenBackupEventLogW;

    [NativeTypeName("#define ReadEventLog ReadEventLogW")]
    public static delegate*<HANDLE, uint, uint, void*, uint, uint*, uint*, BOOL> ReadEventLog => &ReadEventLogW;

    [NativeTypeName("#define ReportEvent ReportEventW")]
    public static delegate*<HANDLE, ushort, ushort, uint, void*, ushort, uint, ushort**, void*, BOOL> ReportEvent => &ReportEventW;

    [NativeTypeName("#define OPERATION_API_VERSION 1")]
    public const int OPERATION_API_VERSION = 1;

    [NativeTypeName("#define OPERATION_START_TRACE_CURRENT_THREAD 0x1")]
    public const int OPERATION_START_TRACE_CURRENT_THREAD = 0x1;

    [NativeTypeName("#define OPERATION_END_DISCARD 0x1")]
    public const int OPERATION_END_DISCARD = 0x1;

    [NativeTypeName("#define IsBadStringPtr IsBadStringPtrW")]
    public static delegate*<ushort*, nuint, BOOL> IsBadStringPtr => &IsBadStringPtrW;

    [NativeTypeName("#define LookupAccountSid LookupAccountSidW")]
    public static delegate*<ushort*, void*, ushort*, uint*, ushort*, uint*, SID_NAME_USE*, BOOL> LookupAccountSid => &LookupAccountSidW;

    [NativeTypeName("#define LookupAccountName LookupAccountNameW")]
    public static delegate*<ushort*, ushort*, void*, uint*, ushort*, uint*, SID_NAME_USE*, BOOL> LookupAccountName => &LookupAccountNameW;

    [NativeTypeName("#define LookupAccountSidLocal LookupAccountSidLocalW")]
    public static delegate*<void*, ushort*, uint*, ushort*, uint*, SID_NAME_USE*, BOOL> LookupAccountSidLocal => &LookupAccountSidLocalW;

    [NativeTypeName("#define LookupPrivilegeValue LookupPrivilegeValueW")]
    public static delegate*<ushort*, ushort*, LUID*, BOOL> LookupPrivilegeValue => &LookupPrivilegeValueW;

    [NativeTypeName("#define LookupPrivilegeName LookupPrivilegeNameW")]
    public static delegate*<ushort*, LUID*, ushort*, uint*, BOOL> LookupPrivilegeName => &LookupPrivilegeNameW;

    [NativeTypeName("#define LookupPrivilegeDisplayName LookupPrivilegeDisplayNameW")]
    public static delegate*<ushort*, ushort*, ushort*, uint*, uint*, BOOL> LookupPrivilegeDisplayName => &LookupPrivilegeDisplayNameW;

    [NativeTypeName("#define BuildCommDCB BuildCommDCBW")]
    public static delegate*<ushort*, DCB*, BOOL> BuildCommDCB => &BuildCommDCBW;

    [NativeTypeName("#define BuildCommDCBAndTimeouts BuildCommDCBAndTimeoutsW")]
    public static delegate*<ushort*, DCB*, COMMTIMEOUTS*, BOOL> BuildCommDCBAndTimeouts => &BuildCommDCBAndTimeoutsW;

    [NativeTypeName("#define CommConfigDialog CommConfigDialogW")]
    public static delegate*<ushort*, HWND, COMMCONFIG*, BOOL> CommConfigDialog => &CommConfigDialogW;

    [NativeTypeName("#define GetDefaultCommConfig GetDefaultCommConfigW")]
    public static delegate*<ushort*, COMMCONFIG*, uint*, BOOL> GetDefaultCommConfig => &GetDefaultCommConfigW;

    [NativeTypeName("#define SetDefaultCommConfig SetDefaultCommConfigW")]
    public static delegate*<ushort*, COMMCONFIG*, uint, BOOL> SetDefaultCommConfig => &SetDefaultCommConfigW;

    [NativeTypeName("#define GetComputerName GetComputerNameW")]
    public static delegate*<ushort*, uint*, BOOL> GetComputerName => &GetComputerNameW;

    [NativeTypeName("#define DnsHostnameToComputerName DnsHostnameToComputerNameW")]
    public static delegate*<ushort*, ushort*, uint*, BOOL> DnsHostnameToComputerName => &DnsHostnameToComputerNameW;

    [NativeTypeName("#define GetUserName GetUserNameW")]
    public static delegate*<ushort*, uint*, BOOL> GetUserName => &GetUserNameW;

    [NativeTypeName("#define LogonUser LogonUserW")]
    public static delegate*<ushort*, ushort*, ushort*, uint, uint, HANDLE*, BOOL> LogonUser => &LogonUserW;

    [NativeTypeName("#define LogonUserEx LogonUserExW")]
    public static delegate*<ushort*, ushort*, ushort*, uint, uint, HANDLE*, void**, void**, uint*, QUOTA_LIMITS*, BOOL> LogonUserEx => &LogonUserExW;

    [NativeTypeName("#define CreatePrivateNamespace CreatePrivateNamespaceW")]
    public static delegate*<SECURITY_ATTRIBUTES*, void*, ushort*, HANDLE> CreatePrivateNamespace => &CreatePrivateNamespaceW;

    [NativeTypeName("#define OpenPrivateNamespace OpenPrivateNamespaceW")]
    public static delegate*<void*, ushort*, HANDLE> OpenPrivateNamespace => &OpenPrivateNamespaceW;

    [NativeTypeName("#define CreateBoundaryDescriptor CreateBoundaryDescriptorW")]
    public static delegate*<ushort*, uint, HANDLE> CreateBoundaryDescriptor => &CreateBoundaryDescriptorW;

    [NativeTypeName("#define HW_PROFILE_GUIDLEN 39")]
    public const int HW_PROFILE_GUIDLEN = 39;

    [NativeTypeName("#define DOCKINFO_UNDOCKED (0x1)")]
    public const int DOCKINFO_UNDOCKED = (0x1);

    [NativeTypeName("#define DOCKINFO_DOCKED (0x2)")]
    public const int DOCKINFO_DOCKED = (0x2);

    [NativeTypeName("#define DOCKINFO_USER_SUPPLIED (0x4)")]
    public const int DOCKINFO_USER_SUPPLIED = (0x4);

    [NativeTypeName("#define DOCKINFO_USER_UNDOCKED (DOCKINFO_USER_SUPPLIED | DOCKINFO_UNDOCKED)")]
    public const int DOCKINFO_USER_UNDOCKED = ((0x4) | (0x1));

    [NativeTypeName("#define DOCKINFO_USER_DOCKED (DOCKINFO_USER_SUPPLIED | DOCKINFO_DOCKED)")]
    public const int DOCKINFO_USER_DOCKED = ((0x4) | (0x2));

    [NativeTypeName("#define GetCurrentHwProfile GetCurrentHwProfileW")]
    public static delegate*<HW_PROFILE_INFOW*, BOOL> GetCurrentHwProfile => &GetCurrentHwProfileW;

    [NativeTypeName("#define VerifyVersionInfo VerifyVersionInfoW")]
    public static delegate*<OSVERSIONINFOEXW*, uint, ulong, BOOL> VerifyVersionInfo => &VerifyVersionInfoW;

    [NativeTypeName("#define AC_LINE_OFFLINE 0x00")]
    public const int AC_LINE_OFFLINE = 0x00;

    [NativeTypeName("#define AC_LINE_ONLINE 0x01")]
    public const int AC_LINE_ONLINE = 0x01;

    [NativeTypeName("#define AC_LINE_BACKUP_POWER 0x02")]
    public const int AC_LINE_BACKUP_POWER = 0x02;

    [NativeTypeName("#define AC_LINE_UNKNOWN 0xFF")]
    public const int AC_LINE_UNKNOWN = 0xFF;

    [NativeTypeName("#define CreateJobObject CreateJobObjectW")]
    public static delegate*<SECURITY_ATTRIBUTES*, ushort*, HANDLE> CreateJobObject => &CreateJobObjectW;

    [NativeTypeName("#define OpenJobObject OpenJobObjectW")]
    public static delegate*<uint, BOOL, ushort*, HANDLE> OpenJobObject => &OpenJobObjectW;

    [NativeTypeName("#define FindFirstVolumeMountPoint FindFirstVolumeMountPointW")]
    public static delegate*<ushort*, ushort*, uint, HANDLE> FindFirstVolumeMountPoint => &FindFirstVolumeMountPointW;

    [NativeTypeName("#define FindNextVolumeMountPoint FindNextVolumeMountPointW")]
    public static delegate*<HANDLE, ushort*, uint, BOOL> FindNextVolumeMountPoint => &FindNextVolumeMountPointW;

    [NativeTypeName("#define SetVolumeMountPoint SetVolumeMountPointW")]
    public static delegate*<ushort*, ushort*, BOOL> SetVolumeMountPoint => &SetVolumeMountPointW;

    [NativeTypeName("#define ACTCTX_FLAG_PROCESSOR_ARCHITECTURE_VALID (0x00000001)")]
    public const int ACTCTX_FLAG_PROCESSOR_ARCHITECTURE_VALID = (0x00000001);

    [NativeTypeName("#define ACTCTX_FLAG_LANGID_VALID (0x00000002)")]
    public const int ACTCTX_FLAG_LANGID_VALID = (0x00000002);

    [NativeTypeName("#define ACTCTX_FLAG_ASSEMBLY_DIRECTORY_VALID (0x00000004)")]
    public const int ACTCTX_FLAG_ASSEMBLY_DIRECTORY_VALID = (0x00000004);

    [NativeTypeName("#define ACTCTX_FLAG_RESOURCE_NAME_VALID (0x00000008)")]
    public const int ACTCTX_FLAG_RESOURCE_NAME_VALID = (0x00000008);

    [NativeTypeName("#define ACTCTX_FLAG_SET_PROCESS_DEFAULT (0x00000010)")]
    public const int ACTCTX_FLAG_SET_PROCESS_DEFAULT = (0x00000010);

    [NativeTypeName("#define ACTCTX_FLAG_APPLICATION_NAME_VALID (0x00000020)")]
    public const int ACTCTX_FLAG_APPLICATION_NAME_VALID = (0x00000020);

    [NativeTypeName("#define ACTCTX_FLAG_SOURCE_IS_ASSEMBLYREF (0x00000040)")]
    public const int ACTCTX_FLAG_SOURCE_IS_ASSEMBLYREF = (0x00000040);

    [NativeTypeName("#define ACTCTX_FLAG_HMODULE_VALID (0x00000080)")]
    public const int ACTCTX_FLAG_HMODULE_VALID = (0x00000080);

    [NativeTypeName("#define CreateActCtx CreateActCtxW")]
    public static delegate*<ACTCTXW*, HANDLE> CreateActCtx => &CreateActCtxW;

    [NativeTypeName("#define DEACTIVATE_ACTCTX_FLAG_FORCE_EARLY_DEACTIVATION (0x00000001)")]
    public const int DEACTIVATE_ACTCTX_FLAG_FORCE_EARLY_DEACTIVATION = (0x00000001);

    [NativeTypeName("#define FIND_ACTCTX_SECTION_KEY_RETURN_HACTCTX (0x00000001)")]
    public const int FIND_ACTCTX_SECTION_KEY_RETURN_HACTCTX = (0x00000001);

    [NativeTypeName("#define FIND_ACTCTX_SECTION_KEY_RETURN_FLAGS (0x00000002)")]
    public const int FIND_ACTCTX_SECTION_KEY_RETURN_FLAGS = (0x00000002);

    [NativeTypeName("#define FIND_ACTCTX_SECTION_KEY_RETURN_ASSEMBLY_METADATA (0x00000004)")]
    public const int FIND_ACTCTX_SECTION_KEY_RETURN_ASSEMBLY_METADATA = (0x00000004);

    [NativeTypeName("#define FindActCtxSectionString FindActCtxSectionStringW")]
    public static delegate*<uint, Guid*, uint, ushort*, ACTCTX_SECTION_KEYED_DATA*, BOOL> FindActCtxSectionString => &FindActCtxSectionStringW;

    [NativeTypeName("#define RESTART_MAX_CMD_LINE 1024")]
    public const int RESTART_MAX_CMD_LINE = 1024;

    [NativeTypeName("#define RESTART_NO_CRASH 1")]
    public const int RESTART_NO_CRASH = 1;

    [NativeTypeName("#define RESTART_NO_HANG 2")]
    public const int RESTART_NO_HANG = 2;

    [NativeTypeName("#define RESTART_NO_PATCH 4")]
    public const int RESTART_NO_PATCH = 4;

    [NativeTypeName("#define RESTART_NO_REBOOT 8")]
    public const int RESTART_NO_REBOOT = 8;

    [NativeTypeName("#define RECOVERY_DEFAULT_PING_INTERVAL 5000")]
    public const int RECOVERY_DEFAULT_PING_INTERVAL = 5000;

    [NativeTypeName("#define RECOVERY_MAX_PING_INTERVAL (5 * 60 * 1000)")]
    public const int RECOVERY_MAX_PING_INTERVAL = (5 * 60 * 1000);

    [NativeTypeName("#define REMOTE_PROTOCOL_INFO_FLAG_LOOPBACK 0x00000001")]
    public const int REMOTE_PROTOCOL_INFO_FLAG_LOOPBACK = 0x00000001;

    [NativeTypeName("#define REMOTE_PROTOCOL_INFO_FLAG_OFFLINE 0x00000002")]
    public const int REMOTE_PROTOCOL_INFO_FLAG_OFFLINE = 0x00000002;

    [NativeTypeName("#define REMOTE_PROTOCOL_INFO_FLAG_PERSISTENT_HANDLE 0x00000004")]
    public const int REMOTE_PROTOCOL_INFO_FLAG_PERSISTENT_HANDLE = 0x00000004;

    [NativeTypeName("#define SYMBOLIC_LINK_FLAG_DIRECTORY (0x1)")]
    public const int SYMBOLIC_LINK_FLAG_DIRECTORY = (0x1);

    [NativeTypeName("#define SYMBOLIC_LINK_FLAG_ALLOW_UNPRIVILEGED_CREATE (0x2)")]
    public const int SYMBOLIC_LINK_FLAG_ALLOW_UNPRIVILEGED_CREATE = (0x2);

    [NativeTypeName("#define CreateSymbolicLink CreateSymbolicLinkW")]
    public static delegate*<ushort*, ushort*, uint, byte> CreateSymbolicLink => &CreateSymbolicLinkW;

    [NativeTypeName("#define CreateSymbolicLinkTransacted CreateSymbolicLinkTransactedW")]
    public static delegate*<ushort*, ushort*, uint, HANDLE, byte> CreateSymbolicLinkTransacted => &CreateSymbolicLinkTransactedW;

    [NativeTypeName("#define MICROSOFT_WINBASE_H_DEFINE_INTERLOCKED_CPLUSPLUS_OVERLOADS 0")]
    public const int MICROSOFT_WINBASE_H_DEFINE_INTERLOCKED_CPLUSPLUS_OVERLOADS = 0;
}
