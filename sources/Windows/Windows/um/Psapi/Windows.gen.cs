// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Psapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32EnumProcesses"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL K32EnumProcesses([NativeTypeName("DWORD *")] uint* lpidProcess, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("LPDWORD")] uint* lpcbNeeded);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32EnumProcessModules"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL K32EnumProcessModules(HANDLE hProcess, HMODULE* lphModule, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("LPDWORD")] uint* lpcbNeeded);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32EnumProcessModulesEx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL K32EnumProcessModulesEx(HANDLE hProcess, HMODULE* lphModule, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("LPDWORD")] uint* lpcbNeeded, [NativeTypeName("DWORD")] uint dwFilterFlag);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32GetModuleBaseNameA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint K32GetModuleBaseNameA(HANDLE hProcess, HMODULE hModule, [NativeTypeName("LPSTR")] sbyte* lpBaseName, [NativeTypeName("DWORD")] uint nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32GetModuleBaseNameW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint K32GetModuleBaseNameW(HANDLE hProcess, HMODULE hModule, [NativeTypeName("LPWSTR")] ushort* lpBaseName, [NativeTypeName("DWORD")] uint nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32GetModuleFileNameExA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint K32GetModuleFileNameExA(HANDLE hProcess, HMODULE hModule, [NativeTypeName("LPSTR")] sbyte* lpFilename, [NativeTypeName("DWORD")] uint nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32GetModuleFileNameExW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint K32GetModuleFileNameExW(HANDLE hProcess, HMODULE hModule, [NativeTypeName("LPWSTR")] ushort* lpFilename, [NativeTypeName("DWORD")] uint nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32GetModuleInformation"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL K32GetModuleInformation(HANDLE hProcess, HMODULE hModule, [NativeTypeName("LPMODULEINFO")] MODULEINFO* lpmodinfo, [NativeTypeName("DWORD")] uint cb);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32EmptyWorkingSet"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL K32EmptyWorkingSet(HANDLE hProcess);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32InitializeProcessForWsWatch"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL K32InitializeProcessForWsWatch(HANDLE hProcess);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32GetWsChanges"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL K32GetWsChanges(HANDLE hProcess, [NativeTypeName("PPSAPI_WS_WATCH_INFORMATION")] PSAPI_WS_WATCH_INFORMATION* lpWatchInfo, [NativeTypeName("DWORD")] uint cb);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32GetWsChangesEx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL K32GetWsChangesEx(HANDLE hProcess, [NativeTypeName("PPSAPI_WS_WATCH_INFORMATION_EX")] PSAPI_WS_WATCH_INFORMATION_EX* lpWatchInfoEx, [NativeTypeName("PDWORD")] uint* cb);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32GetMappedFileNameW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint K32GetMappedFileNameW(HANDLE hProcess, [NativeTypeName("LPVOID")] void* lpv, [NativeTypeName("LPWSTR")] ushort* lpFilename, [NativeTypeName("DWORD")] uint nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32GetMappedFileNameA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint K32GetMappedFileNameA(HANDLE hProcess, [NativeTypeName("LPVOID")] void* lpv, [NativeTypeName("LPSTR")] sbyte* lpFilename, [NativeTypeName("DWORD")] uint nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32EnumDeviceDrivers"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL K32EnumDeviceDrivers([NativeTypeName("LPVOID *")] void** lpImageBase, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("LPDWORD")] uint* lpcbNeeded);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32GetDeviceDriverBaseNameA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint K32GetDeviceDriverBaseNameA([NativeTypeName("LPVOID")] void* ImageBase, [NativeTypeName("LPSTR")] sbyte* lpFilename, [NativeTypeName("DWORD")] uint nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32GetDeviceDriverBaseNameW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint K32GetDeviceDriverBaseNameW([NativeTypeName("LPVOID")] void* ImageBase, [NativeTypeName("LPWSTR")] ushort* lpBaseName, [NativeTypeName("DWORD")] uint nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32GetDeviceDriverFileNameA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint K32GetDeviceDriverFileNameA([NativeTypeName("LPVOID")] void* ImageBase, [NativeTypeName("LPSTR")] sbyte* lpFilename, [NativeTypeName("DWORD")] uint nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32GetDeviceDriverFileNameW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint K32GetDeviceDriverFileNameW([NativeTypeName("LPVOID")] void* ImageBase, [NativeTypeName("LPWSTR")] ushort* lpFilename, [NativeTypeName("DWORD")] uint nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32QueryWorkingSet"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL K32QueryWorkingSet(HANDLE hProcess, [NativeTypeName("PVOID")] void* pv, [NativeTypeName("DWORD")] uint cb);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32QueryWorkingSetEx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL K32QueryWorkingSetEx(HANDLE hProcess, [NativeTypeName("PVOID")] void* pv, [NativeTypeName("DWORD")] uint cb);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32GetProcessMemoryInfo"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL K32GetProcessMemoryInfo(HANDLE Process, [NativeTypeName("PPROCESS_MEMORY_COUNTERS")] PROCESS_MEMORY_COUNTERS* ppsmemCounters, [NativeTypeName("DWORD")] uint cb);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32GetPerformanceInfo"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL K32GetPerformanceInfo([NativeTypeName("PPERFORMANCE_INFORMATION")] PERFORMANCE_INFORMATION* pPerformanceInformation, [NativeTypeName("DWORD")] uint cb);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32EnumPageFilesW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL K32EnumPageFilesW([NativeTypeName("PENUM_PAGE_FILE_CALLBACKW")] delegate* unmanaged<void*, ENUM_PAGE_FILE_INFORMATION*, ushort*, BOOL> pCallBackRoutine, [NativeTypeName("LPVOID")] void* pContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32EnumPageFilesA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL K32EnumPageFilesA([NativeTypeName("PENUM_PAGE_FILE_CALLBACKA")] delegate* unmanaged<void*, ENUM_PAGE_FILE_INFORMATION*, sbyte*, BOOL> pCallBackRoutine, [NativeTypeName("LPVOID")] void* pContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32GetProcessImageFileNameA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint K32GetProcessImageFileNameA(HANDLE hProcess, [NativeTypeName("LPSTR")] sbyte* lpImageFileName, [NativeTypeName("DWORD")] uint nSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.K32GetProcessImageFileNameW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint K32GetProcessImageFileNameW(HANDLE hProcess, [NativeTypeName("LPWSTR")] ushort* lpImageFileName, [NativeTypeName("DWORD")] uint nSize);

    [NativeTypeName("#define PSAPI_VERSION 2")]
    public const int PSAPI_VERSION = 2;

    [NativeTypeName("#define EnumProcessModules K32EnumProcessModules")]
    public static delegate*<HANDLE, HMODULE*, uint, uint*, BOOL> EnumProcessModules => &K32EnumProcessModules;

    [NativeTypeName("#define EnumProcessModulesEx K32EnumProcessModulesEx")]
    public static delegate*<HANDLE, HMODULE*, uint, uint*, uint, BOOL> EnumProcessModulesEx => &K32EnumProcessModulesEx;

    [NativeTypeName("#define InitializeProcessForWsWatch K32InitializeProcessForWsWatch")]
    public static delegate*<HANDLE, BOOL> InitializeProcessForWsWatch => &K32InitializeProcessForWsWatch;

    [NativeTypeName("#define GetWsChanges K32GetWsChanges")]
    public static delegate*<HANDLE, PSAPI_WS_WATCH_INFORMATION*, uint, BOOL> GetWsChanges => &K32GetWsChanges;

    [NativeTypeName("#define GetWsChangesEx K32GetWsChangesEx")]
    public static delegate*<HANDLE, PSAPI_WS_WATCH_INFORMATION_EX*, uint*, BOOL> GetWsChangesEx => &K32GetWsChangesEx;

    [NativeTypeName("#define GetMappedFileNameW K32GetMappedFileNameW")]
    public static delegate*<HANDLE, void*, ushort*, uint, uint> GetMappedFileNameW => &K32GetMappedFileNameW;

    [NativeTypeName("#define GetMappedFileNameA K32GetMappedFileNameA")]
    public static delegate*<HANDLE, void*, sbyte*, uint, uint> GetMappedFileNameA => &K32GetMappedFileNameA;

    [NativeTypeName("#define EnumDeviceDrivers K32EnumDeviceDrivers")]
    public static delegate*<void**, uint, uint*, BOOL> EnumDeviceDrivers => &K32EnumDeviceDrivers;

    [NativeTypeName("#define GetDeviceDriverBaseNameA K32GetDeviceDriverBaseNameA")]
    public static delegate*<void*, sbyte*, uint, uint> GetDeviceDriverBaseNameA => &K32GetDeviceDriverBaseNameA;

    [NativeTypeName("#define GetDeviceDriverBaseNameW K32GetDeviceDriverBaseNameW")]
    public static delegate*<void*, ushort*, uint, uint> GetDeviceDriverBaseNameW => &K32GetDeviceDriverBaseNameW;

    [NativeTypeName("#define GetDeviceDriverFileNameA K32GetDeviceDriverFileNameA")]
    public static delegate*<void*, sbyte*, uint, uint> GetDeviceDriverFileNameA => &K32GetDeviceDriverFileNameA;

    [NativeTypeName("#define GetDeviceDriverFileNameW K32GetDeviceDriverFileNameW")]
    public static delegate*<void*, ushort*, uint, uint> GetDeviceDriverFileNameW => &K32GetDeviceDriverFileNameW;

    [NativeTypeName("#define GetPerformanceInfo K32GetPerformanceInfo")]
    public static delegate*<PERFORMANCE_INFORMATION*, uint, BOOL> GetPerformanceInfo => &K32GetPerformanceInfo;

    [NativeTypeName("#define GetProcessImageFileNameA K32GetProcessImageFileNameA")]
    public static delegate*<HANDLE, sbyte*, uint, uint> GetProcessImageFileNameA => &K32GetProcessImageFileNameA;

    [NativeTypeName("#define GetProcessImageFileNameW K32GetProcessImageFileNameW")]
    public static delegate*<HANDLE, ushort*, uint, uint> GetProcessImageFileNameW => &K32GetProcessImageFileNameW;

    [NativeTypeName("#define GetModuleBaseNameA K32GetModuleBaseNameA")]
    public static delegate*<HANDLE, HMODULE, sbyte*, uint, uint> GetModuleBaseNameA => &K32GetModuleBaseNameA;

    [NativeTypeName("#define GetModuleBaseNameW K32GetModuleBaseNameW")]
    public static delegate*<HANDLE, HMODULE, ushort*, uint, uint> GetModuleBaseNameW => &K32GetModuleBaseNameW;

    [NativeTypeName("#define GetModuleFileNameExA K32GetModuleFileNameExA")]
    public static delegate*<HANDLE, HMODULE, sbyte*, uint, uint> GetModuleFileNameExA => &K32GetModuleFileNameExA;

    [NativeTypeName("#define GetModuleFileNameExW K32GetModuleFileNameExW")]
    public static delegate*<HANDLE, HMODULE, ushort*, uint, uint> GetModuleFileNameExW => &K32GetModuleFileNameExW;

    [NativeTypeName("#define EmptyWorkingSet K32EmptyWorkingSet")]
    public static delegate*<HANDLE, BOOL> EmptyWorkingSet => &K32EmptyWorkingSet;

    [NativeTypeName("#define EnumPageFilesW K32EnumPageFilesW")]
    public static delegate*<delegate* unmanaged<void*, ENUM_PAGE_FILE_INFORMATION*, ushort*, BOOL>, void*, BOOL> EnumPageFilesW => &K32EnumPageFilesW;

    [NativeTypeName("#define EnumPageFilesA K32EnumPageFilesA")]
    public static delegate*<delegate* unmanaged<void*, ENUM_PAGE_FILE_INFORMATION*, sbyte*, BOOL>, void*, BOOL> EnumPageFilesA => &K32EnumPageFilesA;

    [NativeTypeName("#define EnumProcesses K32EnumProcesses")]
    public static delegate*<uint*, uint, uint*, BOOL> EnumProcesses => &K32EnumProcesses;

    [NativeTypeName("#define GetProcessMemoryInfo K32GetProcessMemoryInfo")]
    public static delegate*<HANDLE, PROCESS_MEMORY_COUNTERS*, uint, BOOL> GetProcessMemoryInfo => &K32GetProcessMemoryInfo;

    [NativeTypeName("#define GetModuleInformation K32GetModuleInformation")]
    public static delegate*<HANDLE, HMODULE, MODULEINFO*, uint, BOOL> GetModuleInformation => &K32GetModuleInformation;

    [NativeTypeName("#define QueryWorkingSet K32QueryWorkingSet")]
    public static delegate*<HANDLE, void*, uint, BOOL> QueryWorkingSet => &K32QueryWorkingSet;

    [NativeTypeName("#define QueryWorkingSetEx K32QueryWorkingSetEx")]
    public static delegate*<HANDLE, void*, uint, BOOL> QueryWorkingSetEx => &K32QueryWorkingSetEx;

    [NativeTypeName("#define GetModuleBaseName GetModuleBaseNameW")]
    public static delegate*<HANDLE, HMODULE, ushort*, uint, uint> GetModuleBaseName => &K32GetModuleBaseNameW;

    [NativeTypeName("#define GetModuleFileNameEx GetModuleFileNameExW")]
    public static delegate*<HANDLE, HMODULE, ushort*, uint, uint> GetModuleFileNameEx => &K32GetModuleFileNameExW;

    [NativeTypeName("#define GetMappedFileName GetMappedFileNameW")]
    public static delegate*<HANDLE, void*, ushort*, uint, uint> GetMappedFileName => &K32GetMappedFileNameW;

    [NativeTypeName("#define GetDeviceDriverBaseName GetDeviceDriverBaseNameW")]
    public static delegate*<void*, ushort*, uint, uint> GetDeviceDriverBaseName => &K32GetDeviceDriverBaseNameW;

    [NativeTypeName("#define GetDeviceDriverFileName GetDeviceDriverFileNameW")]
    public static delegate*<void*, ushort*, uint, uint> GetDeviceDriverFileName => &K32GetDeviceDriverFileNameW;

    [NativeTypeName("#define EnumPageFiles EnumPageFilesW")]
    public static delegate*<delegate* unmanaged<void*, ENUM_PAGE_FILE_INFORMATION*, ushort*, BOOL>, void*, BOOL> EnumPageFiles => &K32EnumPageFilesW;

    [NativeTypeName("#define GetProcessImageFileName GetProcessImageFileNameW")]
    public static delegate*<HANDLE, ushort*, uint, uint> GetProcessImageFileName => &K32GetProcessImageFileNameW;
}
