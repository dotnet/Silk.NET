// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ktmw32.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateTransaction(
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpTransactionAttributes,
        [NativeTypeName("LPGUID")] Guid* UOW,
        [NativeTypeName("DWORD")] uint CreateOptions,
        [NativeTypeName("DWORD")] uint IsolationLevel,
        [NativeTypeName("DWORD")] uint IsolationFlags,
        [NativeTypeName("DWORD")] uint Timeout,
        [NativeTypeName("LPWSTR")] ushort* Description
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenTransaction(
        [NativeTypeName("DWORD")] uint dwDesiredAccess,
        [NativeTypeName("LPGUID")] Guid* TransactionId
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CommitTransaction(HANDLE TransactionHandle);

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CommitTransactionAsync(HANDLE TransactionHandle);

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RollbackTransaction(HANDLE TransactionHandle);

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RollbackTransactionAsync(HANDLE TransactionHandle);

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetTransactionId(
        HANDLE TransactionHandle,
        [NativeTypeName("LPGUID")] Guid* TransactionId
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetTransactionInformation(
        HANDLE TransactionHandle,
        [NativeTypeName("PDWORD")] uint* Outcome,
        [NativeTypeName("PDWORD")] uint* IsolationLevel,
        [NativeTypeName("PDWORD")] uint* IsolationFlags,
        [NativeTypeName("PDWORD")] uint* Timeout,
        [NativeTypeName("DWORD")] uint BufferLength,
        [NativeTypeName("LPWSTR")] ushort* Description
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetTransactionInformation(
        HANDLE TransactionHandle,
        [NativeTypeName("DWORD")] uint IsolationLevel,
        [NativeTypeName("DWORD")] uint IsolationFlags,
        [NativeTypeName("DWORD")] uint Timeout,
        [NativeTypeName("LPWSTR")] ushort* Description
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateTransactionManager(
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpTransactionAttributes,
        [NativeTypeName("LPWSTR")] ushort* LogFileName,
        [NativeTypeName("ULONG")] uint CreateOptions,
        [NativeTypeName("ULONG")] uint CommitStrength
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenTransactionManager(
        [NativeTypeName("LPWSTR")] ushort* LogFileName,
        [NativeTypeName("ACCESS_MASK")] uint DesiredAccess,
        [NativeTypeName("ULONG")] uint OpenOptions
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenTransactionManagerById(
        [NativeTypeName("LPGUID")] Guid* TransactionManagerId,
        [NativeTypeName("ACCESS_MASK")] uint DesiredAccess,
        [NativeTypeName("ULONG")] uint OpenOptions
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RenameTransactionManager(
        [NativeTypeName("LPWSTR")] ushort* LogFileName,
        [NativeTypeName("LPGUID")] Guid* ExistingTransactionManagerGuid
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RollforwardTransactionManager(
        HANDLE TransactionManagerHandle,
        [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* TmVirtualClock
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RecoverTransactionManager(HANDLE TransactionManagerHandle);

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetCurrentClockTransactionManager(
        HANDLE TransactionManagerHandle,
        [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* TmVirtualClock
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetTransactionManagerId(
        HANDLE TransactionManagerHandle,
        [NativeTypeName("LPGUID")] Guid* TransactionManagerId
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateResourceManager(
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpResourceManagerAttributes,
        [NativeTypeName("LPGUID")] Guid* ResourceManagerId,
        [NativeTypeName("DWORD")] uint CreateOptions,
        HANDLE TmHandle,
        [NativeTypeName("LPWSTR")] ushort* Description
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenResourceManager(
        [NativeTypeName("DWORD")] uint dwDesiredAccess,
        HANDLE TmHandle,
        [NativeTypeName("LPGUID")] Guid* ResourceManagerId
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RecoverResourceManager(HANDLE ResourceManagerHandle);

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNotificationResourceManager(
        HANDLE ResourceManagerHandle,
        [NativeTypeName("PTRANSACTION_NOTIFICATION")]
            TRANSACTION_NOTIFICATION* TransactionNotification,
        [NativeTypeName("ULONG")] uint NotificationLength,
        [NativeTypeName("DWORD")] uint dwMilliseconds,
        [NativeTypeName("PULONG")] uint* ReturnLength
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNotificationResourceManagerAsync(
        HANDLE ResourceManagerHandle,
        [NativeTypeName("PTRANSACTION_NOTIFICATION")]
            TRANSACTION_NOTIFICATION* TransactionNotification,
        [NativeTypeName("ULONG")] uint TransactionNotificationLength,
        [NativeTypeName("PULONG")] uint* ReturnLength,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetResourceManagerCompletionPort(
        HANDLE ResourceManagerHandle,
        HANDLE IoCompletionPortHandle,
        [NativeTypeName("ULONG_PTR")] nuint CompletionKey
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateEnlistment(
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpEnlistmentAttributes,
        HANDLE ResourceManagerHandle,
        HANDLE TransactionHandle,
        [NativeTypeName("NOTIFICATION_MASK")] uint NotificationMask,
        [NativeTypeName("DWORD")] uint CreateOptions,
        [NativeTypeName("PVOID")] void* EnlistmentKey
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenEnlistment(
        [NativeTypeName("DWORD")] uint dwDesiredAccess,
        HANDLE ResourceManagerHandle,
        [NativeTypeName("LPGUID")] Guid* EnlistmentId
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RecoverEnlistment(
        HANDLE EnlistmentHandle,
        [NativeTypeName("PVOID")] void* EnlistmentKey
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetEnlistmentRecoveryInformation(
        HANDLE EnlistmentHandle,
        [NativeTypeName("ULONG")] uint BufferSize,
        [NativeTypeName("PVOID")] void* Buffer,
        [NativeTypeName("PULONG")] uint* BufferUsed
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetEnlistmentId(
        HANDLE EnlistmentHandle,
        [NativeTypeName("LPGUID")] Guid* EnlistmentId
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetEnlistmentRecoveryInformation(
        HANDLE EnlistmentHandle,
        [NativeTypeName("ULONG")] uint BufferSize,
        [NativeTypeName("PVOID")] void* Buffer
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PrepareEnlistment(
        HANDLE EnlistmentHandle,
        [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* TmVirtualClock
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PrePrepareEnlistment(
        HANDLE EnlistmentHandle,
        [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* TmVirtualClock
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CommitEnlistment(
        HANDLE EnlistmentHandle,
        [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* TmVirtualClock
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RollbackEnlistment(
        HANDLE EnlistmentHandle,
        [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* TmVirtualClock
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PrePrepareComplete(
        HANDLE EnlistmentHandle,
        [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* TmVirtualClock
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PrepareComplete(
        HANDLE EnlistmentHandle,
        [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* TmVirtualClock
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReadOnlyEnlistment(
        HANDLE EnlistmentHandle,
        [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* TmVirtualClock
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CommitComplete(
        HANDLE EnlistmentHandle,
        [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* TmVirtualClock
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RollbackComplete(
        HANDLE EnlistmentHandle,
        [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* TmVirtualClock
    );

    [DllImport("ktmw32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SinglePhaseReject(
        HANDLE EnlistmentHandle,
        [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* TmVirtualClock
    );
}
