// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ioapiset.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateIoCompletionPort"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HANDLE CreateIoCompletionPort(HANDLE FileHandle, HANDLE ExistingCompletionPort, [NativeTypeName("ULONG_PTR")] nuint CompletionKey, [NativeTypeName("DWORD")] uint NumberOfConcurrentThreads);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetQueuedCompletionStatus"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetQueuedCompletionStatus(HANDLE CompletionPort, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesTransferred, [NativeTypeName("PULONG_PTR")] nuint* lpCompletionKey, [NativeTypeName("LPOVERLAPPED *")] OVERLAPPED** lpOverlapped, [NativeTypeName("DWORD")] uint dwMilliseconds);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetQueuedCompletionStatusEx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetQueuedCompletionStatusEx(HANDLE CompletionPort, [NativeTypeName("LPOVERLAPPED_ENTRY")] OVERLAPPED_ENTRY* lpCompletionPortEntries, [NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("PULONG")] uint* ulNumEntriesRemoved, [NativeTypeName("DWORD")] uint dwMilliseconds, BOOL fAlertable);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PostQueuedCompletionStatus"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PostQueuedCompletionStatus(HANDLE CompletionPort, [NativeTypeName("DWORD")] uint dwNumberOfBytesTransferred, [NativeTypeName("ULONG_PTR")] nuint dwCompletionKey, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeviceIoControl"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeviceIoControl(HANDLE hDevice, [NativeTypeName("DWORD")] uint dwIoControlCode, [NativeTypeName("LPVOID")] void* lpInBuffer, [NativeTypeName("DWORD")] uint nInBufferSize, [NativeTypeName("LPVOID")] void* lpOutBuffer, [NativeTypeName("DWORD")] uint nOutBufferSize, [NativeTypeName("LPDWORD")] uint* lpBytesReturned, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetOverlappedResult"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetOverlappedResult(HANDLE hFile, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesTransferred, BOOL bWait);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CancelIoEx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CancelIoEx(HANDLE hFile, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CancelIo"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CancelIo(HANDLE hFile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetOverlappedResultEx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetOverlappedResultEx(HANDLE hFile, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesTransferred, [NativeTypeName("DWORD")] uint dwMilliseconds, BOOL bAlertable);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CancelSynchronousIo"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CancelSynchronousIo(HANDLE hThread);
}
