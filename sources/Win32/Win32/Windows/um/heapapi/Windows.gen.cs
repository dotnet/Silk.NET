// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/heapapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE HeapCreate(
        [NativeTypeName("DWORD")] uint flOptions,
        [NativeTypeName("SIZE_T")] nuint dwInitialSize,
        [NativeTypeName("SIZE_T")] nuint dwMaximumSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL HeapDestroy(HANDLE hHeap);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPVOID")]
    public static extern void* HeapAlloc(
        HANDLE hHeap,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("SIZE_T")] nuint dwBytes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPVOID")]
    public static extern void* HeapReAlloc(
        HANDLE hHeap,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPVOID")] void* lpMem,
        [NativeTypeName("SIZE_T")] nuint dwBytes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL HeapFree(
        HANDLE hHeap,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPVOID")] void* lpMem
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("SIZE_T")]
    public static extern nuint HeapSize(
        HANDLE hHeap,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPCVOID")] void* lpMem
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE GetProcessHeap();

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("SIZE_T")]
    public static extern nuint HeapCompact(HANDLE hHeap, [NativeTypeName("DWORD")] uint dwFlags);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL HeapSetInformation(
        HANDLE HeapHandle,
        HEAP_INFORMATION_CLASS HeapInformationClass,
        [NativeTypeName("PVOID")] void* HeapInformation,
        [NativeTypeName("SIZE_T")] nuint HeapInformationLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL HeapValidate(
        HANDLE hHeap,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPCVOID")] void* lpMem
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern BOOL HeapSummary(
        HANDLE hHeap,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPHEAP_SUMMARY")] HEAP_SUMMARY* lpSummary
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetProcessHeaps(
        [NativeTypeName("DWORD")] uint NumberOfHeaps,
        [NativeTypeName("PHANDLE")] HANDLE* ProcessHeaps
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL HeapLock(HANDLE hHeap);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL HeapUnlock(HANDLE hHeap);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL HeapWalk(
        HANDLE hHeap,
        [NativeTypeName("LPPROCESS_HEAP_ENTRY")] PROCESS_HEAP_ENTRY* lpEntry
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL HeapQueryInformation(
        HANDLE HeapHandle,
        HEAP_INFORMATION_CLASS HeapInformationClass,
        [NativeTypeName("PVOID")] void* HeapInformation,
        [NativeTypeName("SIZE_T")] nuint HeapInformationLength,
        [NativeTypeName("PSIZE_T")] nuint* ReturnLength
    );
}
