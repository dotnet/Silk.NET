// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/heapapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HeapCreate"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE HeapCreate([NativeTypeName("DWORD")] uint flOptions, [NativeTypeName("SIZE_T")] nuint dwInitialSize, [NativeTypeName("SIZE_T")] nuint dwMaximumSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HeapDestroy"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL HeapDestroy(HANDLE hHeap);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HeapAlloc"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPVOID")]
    public static extern void* HeapAlloc(HANDLE hHeap, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("SIZE_T")] nuint dwBytes);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HeapReAlloc"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPVOID")]
    public static extern void* HeapReAlloc(HANDLE hHeap, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPVOID")] void* lpMem, [NativeTypeName("SIZE_T")] nuint dwBytes);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HeapFree"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL HeapFree(HANDLE hHeap, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPVOID")] void* lpMem);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HeapSize"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("SIZE_T")]
    public static extern nuint HeapSize(HANDLE hHeap, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCVOID")] void* lpMem);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProcessHeap"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE GetProcessHeap();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HeapCompact"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("SIZE_T")]
    public static extern nuint HeapCompact(HANDLE hHeap, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HeapSetInformation"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL HeapSetInformation(HANDLE HeapHandle, HEAP_INFORMATION_CLASS HeapInformationClass, [NativeTypeName("PVOID")] void* HeapInformation, [NativeTypeName("SIZE_T")] nuint HeapInformationLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HeapValidate"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL HeapValidate(HANDLE hHeap, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCVOID")] void* lpMem);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HeapSummary"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL HeapSummary(HANDLE hHeap, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPHEAP_SUMMARY")] HEAP_SUMMARY* lpSummary);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProcessHeaps"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetProcessHeaps([NativeTypeName("DWORD")] uint NumberOfHeaps, [NativeTypeName("PHANDLE")] HANDLE* ProcessHeaps);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HeapLock"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL HeapLock(HANDLE hHeap);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HeapUnlock"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL HeapUnlock(HANDLE hHeap);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HeapWalk"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL HeapWalk(HANDLE hHeap, [NativeTypeName("LPPROCESS_HEAP_ENTRY")] PROCESS_HEAP_ENTRY* lpEntry);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HeapQueryInformation"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL HeapQueryInformation(HANDLE HeapHandle, HEAP_INFORMATION_CLASS HeapInformationClass, [NativeTypeName("PVOID")] void* HeapInformation, [NativeTypeName("SIZE_T")] nuint HeapInformationLength, [NativeTypeName("PSIZE_T")] nuint* ReturnLength);
}