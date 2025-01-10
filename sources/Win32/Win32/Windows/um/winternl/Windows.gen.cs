// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtClose(HANDLE Handle);

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtCreateFile(
        [NativeTypeName("PHANDLE")] HANDLE* FileHandle,
        [NativeTypeName("ACCESS_MASK")] uint DesiredAccess,
        [NativeTypeName("POBJECT_ATTRIBUTES")] OBJECT_ATTRIBUTES* ObjectAttributes,
        [NativeTypeName("PIO_STATUS_BLOCK")] IO_STATUS_BLOCK* IoStatusBlock,
        [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* AllocationSize,
        [NativeTypeName("ULONG")] uint FileAttributes,
        [NativeTypeName("ULONG")] uint ShareAccess,
        [NativeTypeName("ULONG")] uint CreateDisposition,
        [NativeTypeName("ULONG")] uint CreateOptions,
        [NativeTypeName("PVOID")] void* EaBuffer,
        [NativeTypeName("ULONG")] uint EaLength
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtOpenFile(
        [NativeTypeName("PHANDLE")] HANDLE* FileHandle,
        [NativeTypeName("ACCESS_MASK")] uint DesiredAccess,
        [NativeTypeName("POBJECT_ATTRIBUTES")] OBJECT_ATTRIBUTES* ObjectAttributes,
        [NativeTypeName("PIO_STATUS_BLOCK")] IO_STATUS_BLOCK* IoStatusBlock,
        [NativeTypeName("ULONG")] uint ShareAccess,
        [NativeTypeName("ULONG")] uint OpenOptions
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtRenameKey(
        HANDLE KeyHandle,
        [NativeTypeName("PUNICODE_STRING")] UNICODE_STRING* NewName
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtNotifyChangeMultipleKeys(
        HANDLE MasterKeyHandle,
        [NativeTypeName("ULONG")] uint Count,
        [NativeTypeName("OBJECT_ATTRIBUTES[]")] OBJECT_ATTRIBUTES* SubordinateObjects,
        HANDLE Event,
        [NativeTypeName("PIO_APC_ROUTINE")]
            delegate* unmanaged<void*, IO_STATUS_BLOCK*, uint, void> ApcRoutine,
        [NativeTypeName("PVOID")] void* ApcContext,
        [NativeTypeName("PIO_STATUS_BLOCK")] IO_STATUS_BLOCK* IoStatusBlock,
        [NativeTypeName("ULONG")] uint CompletionFilter,
        [NativeTypeName("BOOLEAN")] byte WatchTree,
        [NativeTypeName("PVOID")] void* Buffer,
        [NativeTypeName("ULONG")] uint BufferSize,
        [NativeTypeName("BOOLEAN")] byte Asynchronous
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtQueryMultipleValueKey(
        HANDLE KeyHandle,
        [NativeTypeName("PKEY_VALUE_ENTRY")] KEY_VALUE_ENTRY* ValueEntries,
        [NativeTypeName("ULONG")] uint EntryCount,
        [NativeTypeName("PVOID")] void* ValueBuffer,
        [NativeTypeName("PULONG")] uint* BufferLength,
        [NativeTypeName("PULONG")] uint* RequiredBufferLength
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtSetInformationKey(
        HANDLE KeyHandle,
        KEY_SET_INFORMATION_CLASS KeySetInformationClass,
        [NativeTypeName("PVOID")] void* KeySetInformation,
        [NativeTypeName("ULONG")] uint KeySetInformationLength
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtDeviceIoControlFile(
        HANDLE FileHandle,
        HANDLE Event,
        [NativeTypeName("PIO_APC_ROUTINE")]
            delegate* unmanaged<void*, IO_STATUS_BLOCK*, uint, void> ApcRoutine,
        [NativeTypeName("PVOID")] void* ApcContext,
        [NativeTypeName("PIO_STATUS_BLOCK")] IO_STATUS_BLOCK* IoStatusBlock,
        [NativeTypeName("ULONG")] uint IoControlCode,
        [NativeTypeName("PVOID")] void* InputBuffer,
        [NativeTypeName("ULONG")] uint InputBufferLength,
        [NativeTypeName("PVOID")] void* OutputBuffer,
        [NativeTypeName("ULONG")] uint OutputBufferLength
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtWaitForSingleObject(
        HANDLE Handle,
        [NativeTypeName("BOOLEAN")] byte Alertable,
        [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* Timeout
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte RtlIsNameLegalDOS8Dot3(
        [NativeTypeName("PUNICODE_STRING")] UNICODE_STRING* Name,
        [NativeTypeName("POEM_STRING")] STRING* OemName,
        [NativeTypeName("PBOOLEAN")] byte* NameContainsSpaces
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint RtlNtStatusToDosError([NativeTypeName("NTSTATUS")] int Status);

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtQueryInformationProcess(
        HANDLE ProcessHandle,
        PROCESSINFOCLASS ProcessInformationClass,
        [NativeTypeName("PVOID")] void* ProcessInformation,
        [NativeTypeName("ULONG")] uint ProcessInformationLength,
        [NativeTypeName("PULONG")] uint* ReturnLength
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtQueryInformationThread(
        HANDLE ThreadHandle,
        THREADINFOCLASS ThreadInformationClass,
        [NativeTypeName("PVOID")] void* ThreadInformation,
        [NativeTypeName("ULONG")] uint ThreadInformationLength,
        [NativeTypeName("PULONG")] uint* ReturnLength
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtSetInformationThread(
        HANDLE ThreadHandle,
        THREADINFOCLASS ThreadInformationClass,
        [NativeTypeName("PVOID")] void* ThreadInformation,
        [NativeTypeName("ULONG")] uint ThreadInformationLength
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtQueryObject(
        HANDLE Handle,
        OBJECT_INFORMATION_CLASS ObjectInformationClass,
        [NativeTypeName("PVOID")] void* ObjectInformation,
        [NativeTypeName("ULONG")] uint ObjectInformationLength,
        [NativeTypeName("PULONG")] uint* ReturnLength
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtQuerySystemInformation(
        SYSTEM_INFORMATION_CLASS SystemInformationClass,
        [NativeTypeName("PVOID")] void* SystemInformation,
        [NativeTypeName("ULONG")] uint SystemInformationLength,
        [NativeTypeName("PULONG")] uint* ReturnLength
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtQuerySystemTime(
        [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* SystemTime
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtQueryTimerResolution(
        [NativeTypeName("PULONG")] uint* MaximumTime,
        [NativeTypeName("PULONG")] uint* MinimumTime,
        [NativeTypeName("PULONG")] uint* CurrentTime
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int RtlLocalTimeToSystemTime(
        [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* LocalTime,
        [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* SystemTime
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte RtlTimeToSecondsSince1970(
        [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* Time,
        [NativeTypeName("PULONG")] uint* ElapsedSeconds
    );

    [DllImport("ntdll", ExactSpelling = true)]
    public static extern void RtlFreeAnsiString(
        [NativeTypeName("PANSI_STRING")] STRING* AnsiString
    );

    [DllImport("ntdll", ExactSpelling = true)]
    public static extern void RtlFreeUnicodeString(
        [NativeTypeName("PUNICODE_STRING")] UNICODE_STRING* UnicodeString
    );

    [DllImport("ntdll", ExactSpelling = true)]
    public static extern void RtlFreeOemString([NativeTypeName("POEM_STRING")] STRING* OemString);

    [DllImport("ntdll", ExactSpelling = true)]
    public static extern void RtlInitString(
        [NativeTypeName("PSTRING")] STRING* DestinationString,
        [NativeTypeName("PCSZ")] sbyte* SourceString
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int RtlInitStringEx(
        [NativeTypeName("PSTRING")] STRING* DestinationString,
        [NativeTypeName("PCSZ")] sbyte* SourceString
    );

    [DllImport("ntdll", ExactSpelling = true)]
    public static extern void RtlInitAnsiString(
        [NativeTypeName("PANSI_STRING")] STRING* DestinationString,
        [NativeTypeName("PCSZ")] sbyte* SourceString
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int RtlInitAnsiStringEx(
        [NativeTypeName("PANSI_STRING")] STRING* DestinationString,
        [NativeTypeName("PCSZ")] sbyte* SourceString
    );

    [DllImport("ntdll", ExactSpelling = true)]
    public static extern void RtlInitUnicodeString(
        [NativeTypeName("PUNICODE_STRING")] UNICODE_STRING* DestinationString,
        [NativeTypeName("PCWSTR")] ushort* SourceString
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int RtlAnsiStringToUnicodeString(
        [NativeTypeName("PUNICODE_STRING")] UNICODE_STRING* DestinationString,
        [NativeTypeName("PCANSI_STRING")] STRING* SourceString,
        [NativeTypeName("BOOLEAN")] byte AllocateDestinationString
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int RtlUnicodeStringToAnsiString(
        [NativeTypeName("PANSI_STRING")] STRING* DestinationString,
        [NativeTypeName("PCUNICODE_STRING")] UNICODE_STRING* SourceString,
        [NativeTypeName("BOOLEAN")] byte AllocateDestinationString
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int RtlUnicodeStringToOemString(
        [NativeTypeName("POEM_STRING")] STRING* DestinationString,
        [NativeTypeName("PCUNICODE_STRING")] UNICODE_STRING* SourceString,
        [NativeTypeName("BOOLEAN")] byte AllocateDestinationString
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int RtlUnicodeToMultiByteSize(
        [NativeTypeName("PULONG")] uint* BytesInMultiByteString,
        [NativeTypeName("PWCH")] ushort* UnicodeString,
        [NativeTypeName("ULONG")] uint BytesInUnicodeString
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int RtlCharToInteger(
        [NativeTypeName("PCSZ")] sbyte* String,
        [NativeTypeName("ULONG")] uint Base,
        [NativeTypeName("PULONG")] uint* Value
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int RtlConvertSidToUnicodeString(
        [NativeTypeName("PUNICODE_STRING")] UNICODE_STRING* UnicodeString,
        [NativeTypeName("PSID")] void* Sid,
        [NativeTypeName("BOOLEAN")] byte AllocateDestinationString
    );

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint RtlUniform([NativeTypeName("PULONG")] uint* Seed);

    [NativeTypeName("#define INTERNAL_TS_ACTIVE_CONSOLE_ID ( *((volatile ULONG*)(0x7ffe02d8)) )")]
    public static uint INTERNAL_TS_ACTIVE_CONSOLE_ID => (*((uint*)(0x7ffe02d8)));

    [NativeTypeName("#define LOGONID_CURRENT ((ULONG)-1)")]
    public const uint LOGONID_CURRENT = unchecked((uint)(-1));

    [NativeTypeName("#define SERVERNAME_CURRENT ((HANDLE)NULL)")]
    public static void* SERVERNAME_CURRENT => unchecked((HANDLE)(0));
}
