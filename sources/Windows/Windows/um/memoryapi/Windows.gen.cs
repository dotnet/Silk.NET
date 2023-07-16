// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/memoryapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.VirtualAlloc"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPVOID")]
    public static extern void* VirtualAlloc([NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize, [NativeTypeName("DWORD")] uint flAllocationType, [NativeTypeName("DWORD")] uint flProtect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.VirtualProtect"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL VirtualProtect([NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize, [NativeTypeName("DWORD")] uint flNewProtect, [NativeTypeName("PDWORD")] uint* lpflOldProtect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.VirtualFree"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL VirtualFree([NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize, [NativeTypeName("DWORD")] uint dwFreeType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.VirtualQuery"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("SIZE_T")]
    public static extern nuint VirtualQuery([NativeTypeName("LPCVOID")] void* lpAddress, [NativeTypeName("PMEMORY_BASIC_INFORMATION")] MEMORY_BASIC_INFORMATION* lpBuffer, [NativeTypeName("SIZE_T")] nuint dwLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.VirtualAllocEx"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPVOID")]
    public static extern void* VirtualAllocEx(HANDLE hProcess, [NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize, [NativeTypeName("DWORD")] uint flAllocationType, [NativeTypeName("DWORD")] uint flProtect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.VirtualProtectEx"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL VirtualProtectEx(HANDLE hProcess, [NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize, [NativeTypeName("DWORD")] uint flNewProtect, [NativeTypeName("PDWORD")] uint* lpflOldProtect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.VirtualQueryEx"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("SIZE_T")]
    public static extern nuint VirtualQueryEx(HANDLE hProcess, [NativeTypeName("LPCVOID")] void* lpAddress, [NativeTypeName("PMEMORY_BASIC_INFORMATION")] MEMORY_BASIC_INFORMATION* lpBuffer, [NativeTypeName("SIZE_T")] nuint dwLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReadProcessMemory"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReadProcessMemory(HANDLE hProcess, [NativeTypeName("LPCVOID")] void* lpBaseAddress, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("SIZE_T")] nuint nSize, [NativeTypeName("SIZE_T *")] nuint* lpNumberOfBytesRead);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WriteProcessMemory"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WriteProcessMemory(HANDLE hProcess, [NativeTypeName("LPVOID")] void* lpBaseAddress, [NativeTypeName("LPCVOID")] void* lpBuffer, [NativeTypeName("SIZE_T")] nuint nSize, [NativeTypeName("SIZE_T *")] nuint* lpNumberOfBytesWritten);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateFileMappingW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateFileMappingW(HANDLE hFile, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpFileMappingAttributes, [NativeTypeName("DWORD")] uint flProtect, [NativeTypeName("DWORD")] uint dwMaximumSizeHigh, [NativeTypeName("DWORD")] uint dwMaximumSizeLow, [NativeTypeName("LPCWSTR")] ushort* lpName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenFileMappingW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenFileMappingW([NativeTypeName("DWORD")] uint dwDesiredAccess, BOOL bInheritHandle, [NativeTypeName("LPCWSTR")] ushort* lpName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MapViewOfFile"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPVOID")]
    public static extern void* MapViewOfFile(HANDLE hFileMappingObject, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwFileOffsetHigh, [NativeTypeName("DWORD")] uint dwFileOffsetLow, [NativeTypeName("SIZE_T")] nuint dwNumberOfBytesToMap);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MapViewOfFileEx"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPVOID")]
    public static extern void* MapViewOfFileEx(HANDLE hFileMappingObject, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwFileOffsetHigh, [NativeTypeName("DWORD")] uint dwFileOffsetLow, [NativeTypeName("SIZE_T")] nuint dwNumberOfBytesToMap, [NativeTypeName("LPVOID")] void* lpBaseAddress);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.VirtualFreeEx"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL VirtualFreeEx(HANDLE hProcess, [NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize, [NativeTypeName("DWORD")] uint dwFreeType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlushViewOfFile"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FlushViewOfFile([NativeTypeName("LPCVOID")] void* lpBaseAddress, [NativeTypeName("SIZE_T")] nuint dwNumberOfBytesToFlush);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnmapViewOfFile"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UnmapViewOfFile([NativeTypeName("LPCVOID")] void* lpBaseAddress);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetLargePageMinimum"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("SIZE_T")]
    public static extern nuint GetLargePageMinimum();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProcessWorkingSetSize"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetProcessWorkingSetSize(HANDLE hProcess, [NativeTypeName("PSIZE_T")] nuint* lpMinimumWorkingSetSize, [NativeTypeName("PSIZE_T")] nuint* lpMaximumWorkingSetSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProcessWorkingSetSizeEx"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL GetProcessWorkingSetSizeEx(HANDLE hProcess, [NativeTypeName("PSIZE_T")] nuint* lpMinimumWorkingSetSize, [NativeTypeName("PSIZE_T")] nuint* lpMaximumWorkingSetSize, [NativeTypeName("PDWORD")] uint* Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetProcessWorkingSetSize"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetProcessWorkingSetSize(HANDLE hProcess, [NativeTypeName("SIZE_T")] nuint dwMinimumWorkingSetSize, [NativeTypeName("SIZE_T")] nuint dwMaximumWorkingSetSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetProcessWorkingSetSizeEx"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetProcessWorkingSetSizeEx(HANDLE hProcess, [NativeTypeName("SIZE_T")] nuint dwMinimumWorkingSetSize, [NativeTypeName("SIZE_T")] nuint dwMaximumWorkingSetSize, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.VirtualLock"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL VirtualLock([NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.VirtualUnlock"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL VirtualUnlock([NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWriteWatch"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern uint GetWriteWatch([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PVOID")] void* lpBaseAddress, [NativeTypeName("SIZE_T")] nuint dwRegionSize, [NativeTypeName("PVOID *")] void** lpAddresses, [NativeTypeName("ULONG_PTR *")] nuint* lpdwCount, [NativeTypeName("LPDWORD")] uint* lpdwGranularity);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ResetWriteWatch"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern uint ResetWriteWatch([NativeTypeName("LPVOID")] void* lpBaseAddress, [NativeTypeName("SIZE_T")] nuint dwRegionSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateMemoryResourceNotification"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateMemoryResourceNotification(MEMORY_RESOURCE_NOTIFICATION_TYPE NotificationType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.QueryMemoryResourceNotification"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL QueryMemoryResourceNotification(HANDLE ResourceNotificationHandle, [NativeTypeName("PBOOL")] BOOL* ResourceState);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSystemFileCacheSize"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetSystemFileCacheSize([NativeTypeName("PSIZE_T")] nuint* lpMinimumFileCacheSize, [NativeTypeName("PSIZE_T")] nuint* lpMaximumFileCacheSize, [NativeTypeName("PDWORD")] uint* lpFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetSystemFileCacheSize"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetSystemFileCacheSize([NativeTypeName("SIZE_T")] nuint MinimumFileCacheSize, [NativeTypeName("SIZE_T")] nuint MaximumFileCacheSize, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateFileMappingNumaW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateFileMappingNumaW(HANDLE hFile, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpFileMappingAttributes, [NativeTypeName("DWORD")] uint flProtect, [NativeTypeName("DWORD")] uint dwMaximumSizeHigh, [NativeTypeName("DWORD")] uint dwMaximumSizeLow, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("DWORD")] uint nndPreferred);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PrefetchVirtualMemory"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL PrefetchVirtualMemory(HANDLE hProcess, [NativeTypeName("ULONG_PTR")] nuint NumberOfEntries, [NativeTypeName("PWIN32_MEMORY_RANGE_ENTRY")] WIN32_MEMORY_RANGE_ENTRY* VirtualAddresses, [NativeTypeName("ULONG")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateFileMappingFromApp"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern HANDLE CreateFileMappingFromApp(HANDLE hFile, [NativeTypeName("PSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* SecurityAttributes, [NativeTypeName("ULONG")] uint PageProtection, [NativeTypeName("ULONG64")] ulong MaximumSize, [NativeTypeName("PCWSTR")] ushort* Name);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MapViewOfFileFromApp"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PVOID")]
    [SupportedOSPlatform("windows6.2")]
    public static extern void* MapViewOfFileFromApp(HANDLE hFileMappingObject, [NativeTypeName("ULONG")] uint DesiredAccess, [NativeTypeName("ULONG64")] ulong FileOffset, [NativeTypeName("SIZE_T")] nuint NumberOfBytesToMap);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnmapViewOfFileEx"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL UnmapViewOfFileEx([NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("ULONG")] uint UnmapFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AllocateUserPhysicalPages"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AllocateUserPhysicalPages(HANDLE hProcess, [NativeTypeName("PULONG_PTR")] nuint* NumberOfPages, [NativeTypeName("PULONG_PTR")] nuint* PageArray);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FreeUserPhysicalPages"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FreeUserPhysicalPages(HANDLE hProcess, [NativeTypeName("PULONG_PTR")] nuint* NumberOfPages, [NativeTypeName("PULONG_PTR")] nuint* PageArray);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MapUserPhysicalPages"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MapUserPhysicalPages([NativeTypeName("PVOID")] void* VirtualAddress, [NativeTypeName("ULONG_PTR")] nuint NumberOfPages, [NativeTypeName("PULONG_PTR")] nuint* PageArray);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AllocateUserPhysicalPagesNuma"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AllocateUserPhysicalPagesNuma(HANDLE hProcess, [NativeTypeName("PULONG_PTR")] nuint* NumberOfPages, [NativeTypeName("PULONG_PTR")] nuint* PageArray, [NativeTypeName("DWORD")] uint nndPreferred);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.VirtualAllocExNuma"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPVOID")]
    public static extern void* VirtualAllocExNuma(HANDLE hProcess, [NativeTypeName("LPVOID")] void* lpAddress, [NativeTypeName("SIZE_T")] nuint dwSize, [NativeTypeName("DWORD")] uint flAllocationType, [NativeTypeName("DWORD")] uint flProtect, [NativeTypeName("DWORD")] uint nndPreferred);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMemoryErrorHandlingCapabilities"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetMemoryErrorHandlingCapabilities([NativeTypeName("PULONG")] uint* Capabilities);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterBadMemoryNotification"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("PVOID")]
    [SupportedOSPlatform("windows6.2")]
    public static extern void* RegisterBadMemoryNotification([NativeTypeName("PBAD_MEMORY_CALLBACK_ROUTINE")] delegate* unmanaged<void> Callback);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnregisterBadMemoryNotification"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL UnregisterBadMemoryNotification([NativeTypeName("PVOID")] void* RegistrationHandle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OfferVirtualMemory"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.3")]
    public static extern uint OfferVirtualMemory([NativeTypeName("PVOID")] void* VirtualAddress, [NativeTypeName("SIZE_T")] nuint Size, OFFER_PRIORITY Priority);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReclaimVirtualMemory"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.3")]
    public static extern uint ReclaimVirtualMemory([NativeTypeName("const void *")] void* VirtualAddress, [NativeTypeName("SIZE_T")] nuint Size);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DiscardVirtualMemory"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.3")]
    public static extern uint DiscardVirtualMemory([NativeTypeName("PVOID")] void* VirtualAddress, [NativeTypeName("SIZE_T")] nuint Size);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetProcessValidCallTargets"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0")]
    public static extern BOOL SetProcessValidCallTargets(HANDLE hProcess, [NativeTypeName("PVOID")] void* VirtualAddress, [NativeTypeName("SIZE_T")] nuint RegionSize, [NativeTypeName("ULONG")] uint NumberOfOffsets, [NativeTypeName("PCFG_CALL_TARGET_INFO")] CFG_CALL_TARGET_INFO* OffsetInformation);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.VirtualAllocFromApp"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PVOID")]
    [SupportedOSPlatform("windows10.0")]
    public static extern void* VirtualAllocFromApp([NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("ULONG")] uint AllocationType, [NativeTypeName("ULONG")] uint Protection);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.VirtualProtectFromApp"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0")]
    public static extern BOOL VirtualProtectFromApp([NativeTypeName("PVOID")] void* Address, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("ULONG")] uint NewProtection, [NativeTypeName("PULONG")] uint* OldProtection);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenFileMappingFromApp"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0")]
    public static extern HANDLE OpenFileMappingFromApp([NativeTypeName("ULONG")] uint DesiredAccess, BOOL InheritHandle, [NativeTypeName("PCWSTR")] ushort* Name);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.QueryVirtualMemoryInformation"]/*'/>
    [DllImport("api-ms-win-core-memory-l1-1-4", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.14393.0")]
    public static extern BOOL QueryVirtualMemoryInformation(HANDLE Process, [NativeTypeName("const void *")] void* VirtualAddress, WIN32_MEMORY_INFORMATION_CLASS MemoryInformationClass, [NativeTypeName("PVOID")] void* MemoryInformation, [NativeTypeName("SIZE_T")] nuint MemoryInformationSize, [NativeTypeName("PSIZE_T")] nuint* ReturnSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MapViewOfFileNuma2"]/*'/>
    [DllImport("api-ms-win-core-memory-l1-1-5", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PVOID")]
    [SupportedOSPlatform("windows10.0.15063.0")]
    public static extern void* MapViewOfFileNuma2(HANDLE FileMappingHandle, HANDLE ProcessHandle, [NativeTypeName("ULONG64")] ulong Offset, [NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("SIZE_T")] nuint ViewSize, [NativeTypeName("ULONG")] uint AllocationType, [NativeTypeName("ULONG")] uint PageProtection, [NativeTypeName("ULONG")] uint PreferredNode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MapViewOfFile2"]/*'/>
    [SetsLastSystemError]
    [return: NativeTypeName("PVOID")]
    [SupportedOSPlatform("windows10.0.15063.0")]
    public static void* MapViewOfFile2(HANDLE FileMappingHandle, HANDLE ProcessHandle, [NativeTypeName("ULONG64")] ulong Offset, [NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("SIZE_T")] nuint ViewSize, [NativeTypeName("ULONG")] uint AllocationType, [NativeTypeName("ULONG")] uint PageProtection)
    {
        return MapViewOfFileNuma2(FileMappingHandle, ProcessHandle, Offset, BaseAddress, ViewSize, AllocationType, PageProtection, unchecked((uint)(-1)));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnmapViewOfFile2"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.15063.0")]
    public static extern BOOL UnmapViewOfFile2(HANDLE Process, [NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("ULONG")] uint UnmapFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.VirtualAlloc2"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PVOID")]
    [SupportedOSPlatform("windows10.0")]
    public static extern void* VirtualAlloc2(HANDLE Process, [NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("ULONG")] uint AllocationType, [NativeTypeName("ULONG")] uint PageProtection, MEM_EXTENDED_PARAMETER* ExtendedParameters, [NativeTypeName("ULONG")] uint ParameterCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MapViewOfFile3"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PVOID")]
    [SupportedOSPlatform("windows10.0.17134.0")]
    public static extern void* MapViewOfFile3(HANDLE FileMapping, HANDLE Process, [NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("ULONG64")] ulong Offset, [NativeTypeName("SIZE_T")] nuint ViewSize, [NativeTypeName("ULONG")] uint AllocationType, [NativeTypeName("ULONG")] uint PageProtection, MEM_EXTENDED_PARAMETER* ExtendedParameters, [NativeTypeName("ULONG")] uint ParameterCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.VirtualAlloc2FromApp"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PVOID")]
    [SupportedOSPlatform("windows10.0")]
    public static extern void* VirtualAlloc2FromApp(HANDLE Process, [NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("SIZE_T")] nuint Size, [NativeTypeName("ULONG")] uint AllocationType, [NativeTypeName("ULONG")] uint PageProtection, MEM_EXTENDED_PARAMETER* ExtendedParameters, [NativeTypeName("ULONG")] uint ParameterCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MapViewOfFile3FromApp"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PVOID")]
    [SupportedOSPlatform("windows10.0")]
    public static extern void* MapViewOfFile3FromApp(HANDLE FileMapping, HANDLE Process, [NativeTypeName("PVOID")] void* BaseAddress, [NativeTypeName("ULONG64")] ulong Offset, [NativeTypeName("SIZE_T")] nuint ViewSize, [NativeTypeName("ULONG")] uint AllocationType, [NativeTypeName("ULONG")] uint PageProtection, MEM_EXTENDED_PARAMETER* ExtendedParameters, [NativeTypeName("ULONG")] uint ParameterCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateFileMapping2"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateFileMapping2(HANDLE File, SECURITY_ATTRIBUTES* SecurityAttributes, [NativeTypeName("ULONG")] uint DesiredAccess, [NativeTypeName("ULONG")] uint PageProtection, [NativeTypeName("ULONG")] uint AllocationAttributes, [NativeTypeName("ULONG64")] ulong MaximumSize, [NativeTypeName("PCWSTR")] ushort* Name, MEM_EXTENDED_PARAMETER* ExtendedParameters, [NativeTypeName("ULONG")] uint ParameterCount);
    [NativeTypeName("#define CreateFileMapping CreateFileMappingW")]
    public static delegate*<HANDLE, SECURITY_ATTRIBUTES*, uint, uint, uint, ushort*, HANDLE> CreateFileMapping => &CreateFileMappingW;

    [NativeTypeName("#define OpenFileMapping OpenFileMappingW")]
    public static delegate*<uint, BOOL, ushort*, HANDLE> OpenFileMapping => &OpenFileMappingW;

    [NativeTypeName("#define CreateFileMappingNuma CreateFileMappingNumaW")]
    public static delegate*<HANDLE, SECURITY_ATTRIBUTES*, uint, uint, uint, ushort*, uint, HANDLE> CreateFileMappingNuma => &CreateFileMappingNumaW;

    [NativeTypeName("#define MEHC_PATROL_SCRUBBER_PRESENT 0x1")]
    public const int MEHC_PATROL_SCRUBBER_PRESENT = 0x1;
}