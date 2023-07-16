// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/synchapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitializeSRWLock"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void InitializeSRWLock([NativeTypeName("PSRWLOCK")] SRWLOCK* SRWLock);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReleaseSRWLockExclusive"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void ReleaseSRWLockExclusive([NativeTypeName("PSRWLOCK")] SRWLOCK* SRWLock);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReleaseSRWLockShared"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void ReleaseSRWLockShared([NativeTypeName("PSRWLOCK")] SRWLOCK* SRWLock);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AcquireSRWLockExclusive"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void AcquireSRWLockExclusive([NativeTypeName("PSRWLOCK")] SRWLOCK* SRWLock);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AcquireSRWLockShared"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void AcquireSRWLockShared([NativeTypeName("PSRWLOCK")] SRWLOCK* SRWLock);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TryAcquireSRWLockExclusive"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte TryAcquireSRWLockExclusive([NativeTypeName("PSRWLOCK")] SRWLOCK* SRWLock);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TryAcquireSRWLockShared"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte TryAcquireSRWLockShared([NativeTypeName("PSRWLOCK")] SRWLOCK* SRWLock);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitializeCriticalSection"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void InitializeCriticalSection([NativeTypeName("LPCRITICAL_SECTION")] CRITICAL_SECTION* lpCriticalSection);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnterCriticalSection"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void EnterCriticalSection([NativeTypeName("LPCRITICAL_SECTION")] CRITICAL_SECTION* lpCriticalSection);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LeaveCriticalSection"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void LeaveCriticalSection([NativeTypeName("LPCRITICAL_SECTION")] CRITICAL_SECTION* lpCriticalSection);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitializeCriticalSectionAndSpinCount"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InitializeCriticalSectionAndSpinCount([NativeTypeName("LPCRITICAL_SECTION")] CRITICAL_SECTION* lpCriticalSection, [NativeTypeName("DWORD")] uint dwSpinCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitializeCriticalSectionEx"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InitializeCriticalSectionEx([NativeTypeName("LPCRITICAL_SECTION")] CRITICAL_SECTION* lpCriticalSection, [NativeTypeName("DWORD")] uint dwSpinCount, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetCriticalSectionSpinCount"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetCriticalSectionSpinCount([NativeTypeName("LPCRITICAL_SECTION")] CRITICAL_SECTION* lpCriticalSection, [NativeTypeName("DWORD")] uint dwSpinCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TryEnterCriticalSection"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL TryEnterCriticalSection([NativeTypeName("LPCRITICAL_SECTION")] CRITICAL_SECTION* lpCriticalSection);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeleteCriticalSection"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void DeleteCriticalSection([NativeTypeName("LPCRITICAL_SECTION")] CRITICAL_SECTION* lpCriticalSection);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitOnceInitialize"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void InitOnceInitialize([NativeTypeName("PINIT_ONCE")] INIT_ONCE* InitOnce);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitOnceExecuteOnce"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InitOnceExecuteOnce([NativeTypeName("PINIT_ONCE")] INIT_ONCE* InitOnce, [NativeTypeName("PINIT_ONCE_FN")] delegate* unmanaged<INIT_ONCE*, void*, void**, BOOL> InitFn, [NativeTypeName("PVOID")] void* Parameter, [NativeTypeName("LPVOID *")] void** Context);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitOnceBeginInitialize"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InitOnceBeginInitialize([NativeTypeName("LPINIT_ONCE")] INIT_ONCE* lpInitOnce, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PBOOL")] BOOL* fPending, [NativeTypeName("LPVOID *")] void** lpContext);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitOnceComplete"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InitOnceComplete([NativeTypeName("LPINIT_ONCE")] INIT_ONCE* lpInitOnce, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPVOID")] void* lpContext);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitializeConditionVariable"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void InitializeConditionVariable([NativeTypeName("PCONDITION_VARIABLE")] CONDITION_VARIABLE* ConditionVariable);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WakeConditionVariable"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void WakeConditionVariable([NativeTypeName("PCONDITION_VARIABLE")] CONDITION_VARIABLE* ConditionVariable);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WakeAllConditionVariable"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void WakeAllConditionVariable([NativeTypeName("PCONDITION_VARIABLE")] CONDITION_VARIABLE* ConditionVariable);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SleepConditionVariableCS"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SleepConditionVariableCS([NativeTypeName("PCONDITION_VARIABLE")] CONDITION_VARIABLE* ConditionVariable, [NativeTypeName("PCRITICAL_SECTION")] CRITICAL_SECTION* CriticalSection, [NativeTypeName("DWORD")] uint dwMilliseconds);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SleepConditionVariableSRW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SleepConditionVariableSRW([NativeTypeName("PCONDITION_VARIABLE")] CONDITION_VARIABLE* ConditionVariable, [NativeTypeName("PSRWLOCK")] SRWLOCK* SRWLock, [NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("ULONG")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetEvent"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetEvent(HANDLE hEvent);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ResetEvent"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ResetEvent(HANDLE hEvent);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReleaseSemaphore"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReleaseSemaphore(HANDLE hSemaphore, [NativeTypeName("LONG")] int lReleaseCount, [NativeTypeName("LPLONG")] int* lpPreviousCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReleaseMutex"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReleaseMutex(HANDLE hMutex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WaitForSingleObject"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WaitForSingleObject(HANDLE hHandle, [NativeTypeName("DWORD")] uint dwMilliseconds);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SleepEx"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SleepEx([NativeTypeName("DWORD")] uint dwMilliseconds, BOOL bAlertable);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WaitForSingleObjectEx"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WaitForSingleObjectEx(HANDLE hHandle, [NativeTypeName("DWORD")] uint dwMilliseconds, BOOL bAlertable);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WaitForMultipleObjectsEx"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WaitForMultipleObjectsEx([NativeTypeName("DWORD")] uint nCount, [NativeTypeName("const HANDLE *")] HANDLE* lpHandles, BOOL bWaitAll, [NativeTypeName("DWORD")] uint dwMilliseconds, BOOL bAlertable);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateMutexA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateMutexA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpMutexAttributes, BOOL bInitialOwner, [NativeTypeName("LPCSTR")] sbyte* lpName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateMutexW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateMutexW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpMutexAttributes, BOOL bInitialOwner, [NativeTypeName("LPCWSTR")] ushort* lpName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenMutexW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenMutexW([NativeTypeName("DWORD")] uint dwDesiredAccess, BOOL bInheritHandle, [NativeTypeName("LPCWSTR")] ushort* lpName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateEventA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateEventA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpEventAttributes, BOOL bManualReset, BOOL bInitialState, [NativeTypeName("LPCSTR")] sbyte* lpName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateEventW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateEventW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpEventAttributes, BOOL bManualReset, BOOL bInitialState, [NativeTypeName("LPCWSTR")] ushort* lpName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenEventA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenEventA([NativeTypeName("DWORD")] uint dwDesiredAccess, BOOL bInheritHandle, [NativeTypeName("LPCSTR")] sbyte* lpName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenEventW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenEventW([NativeTypeName("DWORD")] uint dwDesiredAccess, BOOL bInheritHandle, [NativeTypeName("LPCWSTR")] ushort* lpName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenSemaphoreW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenSemaphoreW([NativeTypeName("DWORD")] uint dwDesiredAccess, BOOL bInheritHandle, [NativeTypeName("LPCWSTR")] ushort* lpName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenWaitableTimerW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenWaitableTimerW([NativeTypeName("DWORD")] uint dwDesiredAccess, BOOL bInheritHandle, [NativeTypeName("LPCWSTR")] ushort* lpTimerName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWaitableTimerEx"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetWaitableTimerEx(HANDLE hTimer, [NativeTypeName("const LARGE_INTEGER *")] LARGE_INTEGER* lpDueTime, [NativeTypeName("LONG")] int lPeriod, [NativeTypeName("PTIMERAPCROUTINE")] delegate* unmanaged<void*, uint, uint, void> pfnCompletionRoutine, [NativeTypeName("LPVOID")] void* lpArgToCompletionRoutine, [NativeTypeName("PREASON_CONTEXT")] REASON_CONTEXT* WakeContext, [NativeTypeName("ULONG")] uint TolerableDelay);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWaitableTimer"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetWaitableTimer(HANDLE hTimer, [NativeTypeName("const LARGE_INTEGER *")] LARGE_INTEGER* lpDueTime, [NativeTypeName("LONG")] int lPeriod, [NativeTypeName("PTIMERAPCROUTINE")] delegate* unmanaged<void*, uint, uint, void> pfnCompletionRoutine, [NativeTypeName("LPVOID")] void* lpArgToCompletionRoutine, BOOL fResume);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CancelWaitableTimer"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CancelWaitableTimer(HANDLE hTimer);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateMutexExA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateMutexExA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpMutexAttributes, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateMutexExW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateMutexExW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpMutexAttributes, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateEventExA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateEventExA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpEventAttributes, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateEventExW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateEventExW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpEventAttributes, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateSemaphoreExW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateSemaphoreExW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSemaphoreAttributes, [NativeTypeName("LONG")] int lInitialCount, [NativeTypeName("LONG")] int lMaximumCount, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateWaitableTimerExW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateWaitableTimerExW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpTimerAttributes, [NativeTypeName("LPCWSTR")] ushort* lpTimerName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnterSynchronizationBarrier"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL EnterSynchronizationBarrier([NativeTypeName("LPSYNCHRONIZATION_BARRIER")] SYNCHRONIZATION_BARRIER* lpBarrier, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitializeSynchronizationBarrier"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL InitializeSynchronizationBarrier([NativeTypeName("LPSYNCHRONIZATION_BARRIER")] SYNCHRONIZATION_BARRIER* lpBarrier, [NativeTypeName("LONG")] int lTotalThreads, [NativeTypeName("LONG")] int lSpinCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeleteSynchronizationBarrier"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL DeleteSynchronizationBarrier([NativeTypeName("LPSYNCHRONIZATION_BARRIER")] SYNCHRONIZATION_BARRIER* lpBarrier);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.Sleep"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void Sleep([NativeTypeName("DWORD")] uint dwMilliseconds);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WaitOnAddress"]/*'/>
    [DllImport("api-ms-win-core-synch-l1-2-0", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL WaitOnAddress([NativeTypeName("volatile void *")] void* Address, [NativeTypeName("PVOID")] void* CompareAddress, [NativeTypeName("SIZE_T")] nuint AddressSize, [NativeTypeName("DWORD")] uint dwMilliseconds);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WakeByAddressSingle"]/*'/>
    [DllImport("api-ms-win-core-synch-l1-2-0", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern void WakeByAddressSingle([NativeTypeName("PVOID")] void* Address);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WakeByAddressAll"]/*'/>
    [DllImport("api-ms-win-core-synch-l1-2-0", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern void WakeByAddressAll([NativeTypeName("PVOID")] void* Address);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SignalObjectAndWait"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SignalObjectAndWait(HANDLE hObjectToSignal, HANDLE hObjectToWaitOn, [NativeTypeName("DWORD")] uint dwMilliseconds, BOOL bAlertable);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WaitForMultipleObjects"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WaitForMultipleObjects([NativeTypeName("DWORD")] uint nCount, [NativeTypeName("const HANDLE *")] HANDLE* lpHandles, BOOL bWaitAll, [NativeTypeName("DWORD")] uint dwMilliseconds);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateSemaphoreW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateSemaphoreW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSemaphoreAttributes, [NativeTypeName("LONG")] int lInitialCount, [NativeTypeName("LONG")] int lMaximumCount, [NativeTypeName("LPCWSTR")] ushort* lpName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateWaitableTimerW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateWaitableTimerW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpTimerAttributes, BOOL bManualReset, [NativeTypeName("LPCWSTR")] ushort* lpTimerName);
    [NativeTypeName("#define CONDITION_VARIABLE_LOCKMODE_SHARED RTL_CONDITION_VARIABLE_LOCKMODE_SHARED")]
    public const int CONDITION_VARIABLE_LOCKMODE_SHARED = 0x1;
    [NativeTypeName("#define MUTEX_MODIFY_STATE MUTANT_QUERY_STATE")]
    public const int MUTEX_MODIFY_STATE = 0x0001;
    [NativeTypeName("#define MUTEX_ALL_ACCESS MUTANT_ALL_ACCESS")]
    public const int MUTEX_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0x0001);
    [NativeTypeName("#define CreateMutex CreateMutexW")]
    public static delegate*<SECURITY_ATTRIBUTES*, BOOL, ushort*, HANDLE> CreateMutex => &CreateMutexW;

    [NativeTypeName("#define OpenMutex OpenMutexW")]
    public static delegate*<uint, BOOL, ushort*, HANDLE> OpenMutex => &OpenMutexW;

    [NativeTypeName("#define CreateEvent CreateEventW")]
    public static delegate*<SECURITY_ATTRIBUTES*, BOOL, BOOL, ushort*, HANDLE> CreateEvent => &CreateEventW;

    [NativeTypeName("#define OpenEvent OpenEventW")]
    public static delegate*<uint, BOOL, ushort*, HANDLE> OpenEvent => &OpenEventW;

    [NativeTypeName("#define OpenSemaphore OpenSemaphoreW")]
    public static delegate*<uint, BOOL, ushort*, HANDLE> OpenSemaphore => &OpenSemaphoreW;

    [NativeTypeName("#define OpenWaitableTimer OpenWaitableTimerW")]
    public static delegate*<uint, BOOL, ushort*, HANDLE> OpenWaitableTimer => &OpenWaitableTimerW;

    [NativeTypeName("#define CreateMutexEx CreateMutexExW")]
    public static delegate*<SECURITY_ATTRIBUTES*, ushort*, uint, uint, HANDLE> CreateMutexEx => &CreateMutexExW;

    [NativeTypeName("#define CreateEventEx CreateEventExW")]
    public static delegate*<SECURITY_ATTRIBUTES*, ushort*, uint, uint, HANDLE> CreateEventEx => &CreateEventExW;

    [NativeTypeName("#define CreateSemaphoreEx CreateSemaphoreExW")]
    public static delegate*<SECURITY_ATTRIBUTES*, int, int, ushort*, uint, uint, HANDLE> CreateSemaphoreEx => &CreateSemaphoreExW;

    [NativeTypeName("#define CreateWaitableTimerEx CreateWaitableTimerExW")]
    public static delegate*<SECURITY_ATTRIBUTES*, ushort*, uint, uint, HANDLE> CreateWaitableTimerEx => &CreateWaitableTimerExW;

    [NativeTypeName("#define SYNCHRONIZATION_BARRIER_FLAGS_SPIN_ONLY 0x01")]
    public const int SYNCHRONIZATION_BARRIER_FLAGS_SPIN_ONLY = 0x01;
    [NativeTypeName("#define SYNCHRONIZATION_BARRIER_FLAGS_BLOCK_ONLY 0x02")]
    public const int SYNCHRONIZATION_BARRIER_FLAGS_BLOCK_ONLY = 0x02;
    [NativeTypeName("#define SYNCHRONIZATION_BARRIER_FLAGS_NO_DELETE 0x04")]
    public const int SYNCHRONIZATION_BARRIER_FLAGS_NO_DELETE = 0x04;
    [NativeTypeName("#define CreateSemaphore CreateSemaphoreW")]
    public static delegate*<SECURITY_ATTRIBUTES*, int, int, ushort*, HANDLE> CreateSemaphore => &CreateSemaphoreW;

    [NativeTypeName("#define CreateWaitableTimer CreateWaitableTimerW")]
    public static delegate*<SECURITY_ATTRIBUTES*, BOOL, ushort*, HANDLE> CreateWaitableTimer => &CreateWaitableTimerW;
}