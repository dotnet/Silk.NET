// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.NtClose"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtClose(HANDLE Handle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.NtCreateFile"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtCreateFile([NativeTypeName("PHANDLE")] HANDLE* FileHandle, [NativeTypeName("ACCESS_MASK")] uint DesiredAccess, [NativeTypeName("POBJECT_ATTRIBUTES")] OBJECT_ATTRIBUTES* ObjectAttributes, [NativeTypeName("PIO_STATUS_BLOCK")] IO_STATUS_BLOCK* IoStatusBlock, [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* AllocationSize, [NativeTypeName("ULONG")] uint FileAttributes, [NativeTypeName("ULONG")] uint ShareAccess, [NativeTypeName("ULONG")] uint CreateDisposition, [NativeTypeName("ULONG")] uint CreateOptions, [NativeTypeName("PVOID")] void* EaBuffer, [NativeTypeName("ULONG")] uint EaLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.NtOpenFile"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtOpenFile([NativeTypeName("PHANDLE")] HANDLE* FileHandle, [NativeTypeName("ACCESS_MASK")] uint DesiredAccess, [NativeTypeName("POBJECT_ATTRIBUTES")] OBJECT_ATTRIBUTES* ObjectAttributes, [NativeTypeName("PIO_STATUS_BLOCK")] IO_STATUS_BLOCK* IoStatusBlock, [NativeTypeName("ULONG")] uint ShareAccess, [NativeTypeName("ULONG")] uint OpenOptions);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.NtRenameKey"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtRenameKey(HANDLE KeyHandle, [NativeTypeName("PUNICODE_STRING")] UNICODE_STRING* NewName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.NtNotifyChangeMultipleKeys"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtNotifyChangeMultipleKeys(HANDLE MasterKeyHandle, [NativeTypeName("ULONG")] uint Count, [NativeTypeName("OBJECT_ATTRIBUTES[]")] OBJECT_ATTRIBUTES* SubordinateObjects, HANDLE Event, [NativeTypeName("PIO_APC_ROUTINE")] delegate* unmanaged<void*, IO_STATUS_BLOCK*, uint, void> ApcRoutine, [NativeTypeName("PVOID")] void* ApcContext, [NativeTypeName("PIO_STATUS_BLOCK")] IO_STATUS_BLOCK* IoStatusBlock, [NativeTypeName("ULONG")] uint CompletionFilter, [NativeTypeName("BOOLEAN")] byte WatchTree, [NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("ULONG")] uint BufferSize, [NativeTypeName("BOOLEAN")] byte Asynchronous);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.NtQueryMultipleValueKey"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtQueryMultipleValueKey(HANDLE KeyHandle, [NativeTypeName("PKEY_VALUE_ENTRY")] KEY_VALUE_ENTRY* ValueEntries, [NativeTypeName("ULONG")] uint EntryCount, [NativeTypeName("PVOID")] void* ValueBuffer, [NativeTypeName("PULONG")] uint* BufferLength, [NativeTypeName("PULONG")] uint* RequiredBufferLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.NtSetInformationKey"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtSetInformationKey(HANDLE KeyHandle, KEY_SET_INFORMATION_CLASS KeySetInformationClass, [NativeTypeName("PVOID")] void* KeySetInformation, [NativeTypeName("ULONG")] uint KeySetInformationLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.NtDeviceIoControlFile"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtDeviceIoControlFile(HANDLE FileHandle, HANDLE Event, [NativeTypeName("PIO_APC_ROUTINE")] delegate* unmanaged<void*, IO_STATUS_BLOCK*, uint, void> ApcRoutine, [NativeTypeName("PVOID")] void* ApcContext, [NativeTypeName("PIO_STATUS_BLOCK")] IO_STATUS_BLOCK* IoStatusBlock, [NativeTypeName("ULONG")] uint IoControlCode, [NativeTypeName("PVOID")] void* InputBuffer, [NativeTypeName("ULONG")] uint InputBufferLength, [NativeTypeName("PVOID")] void* OutputBuffer, [NativeTypeName("ULONG")] uint OutputBufferLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.NtWaitForSingleObject"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtWaitForSingleObject(HANDLE Handle, [NativeTypeName("BOOLEAN")] byte Alertable, [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* Timeout);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RtlIsNameLegalDOS8Dot3"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte RtlIsNameLegalDOS8Dot3([NativeTypeName("PUNICODE_STRING")] UNICODE_STRING* Name, [NativeTypeName("POEM_STRING")] STRING* OemName, [NativeTypeName("PBOOLEAN")] byte* NameContainsSpaces);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RtlNtStatusToDosError"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint RtlNtStatusToDosError([NativeTypeName("NTSTATUS")] int Status);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.NtQueryInformationProcess"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtQueryInformationProcess(HANDLE ProcessHandle, PROCESSINFOCLASS ProcessInformationClass, [NativeTypeName("PVOID")] void* ProcessInformation, [NativeTypeName("ULONG")] uint ProcessInformationLength, [NativeTypeName("PULONG")] uint* ReturnLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.NtQueryInformationThread"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtQueryInformationThread(HANDLE ThreadHandle, THREADINFOCLASS ThreadInformationClass, [NativeTypeName("PVOID")] void* ThreadInformation, [NativeTypeName("ULONG")] uint ThreadInformationLength, [NativeTypeName("PULONG")] uint* ReturnLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.NtSetInformationThread"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtSetInformationThread(HANDLE ThreadHandle, THREADINFOCLASS ThreadInformationClass, [NativeTypeName("PVOID")] void* ThreadInformation, [NativeTypeName("ULONG")] uint ThreadInformationLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.NtQueryObject"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtQueryObject(HANDLE Handle, OBJECT_INFORMATION_CLASS ObjectInformationClass, [NativeTypeName("PVOID")] void* ObjectInformation, [NativeTypeName("ULONG")] uint ObjectInformationLength, [NativeTypeName("PULONG")] uint* ReturnLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.NtQuerySystemInformation"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtQuerySystemInformation(SYSTEM_INFORMATION_CLASS SystemInformationClass, [NativeTypeName("PVOID")] void* SystemInformation, [NativeTypeName("ULONG")] uint SystemInformationLength, [NativeTypeName("PULONG")] uint* ReturnLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.NtQuerySystemTime"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtQuerySystemTime([NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* SystemTime);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.NtQueryTimerResolution"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int NtQueryTimerResolution([NativeTypeName("PULONG")] uint* MaximumTime, [NativeTypeName("PULONG")] uint* MinimumTime, [NativeTypeName("PULONG")] uint* CurrentTime);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RtlLocalTimeToSystemTime"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int RtlLocalTimeToSystemTime([NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* LocalTime, [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* SystemTime);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RtlTimeToSecondsSince1970"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte RtlTimeToSecondsSince1970([NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* Time, [NativeTypeName("PULONG")] uint* ElapsedSeconds);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RtlFreeAnsiString"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    public static extern void RtlFreeAnsiString([NativeTypeName("PANSI_STRING")] STRING* AnsiString);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RtlFreeUnicodeString"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    public static extern void RtlFreeUnicodeString([NativeTypeName("PUNICODE_STRING")] UNICODE_STRING* UnicodeString);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RtlFreeOemString"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    public static extern void RtlFreeOemString([NativeTypeName("POEM_STRING")] STRING* OemString);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RtlInitString"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    public static extern void RtlInitString([NativeTypeName("PSTRING")] STRING* DestinationString, [NativeTypeName("PCSZ")] sbyte* SourceString);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RtlInitStringEx"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int RtlInitStringEx([NativeTypeName("PSTRING")] STRING* DestinationString, [NativeTypeName("PCSZ")] sbyte* SourceString);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RtlInitAnsiString"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    public static extern void RtlInitAnsiString([NativeTypeName("PANSI_STRING")] STRING* DestinationString, [NativeTypeName("PCSZ")] sbyte* SourceString);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RtlInitAnsiStringEx"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int RtlInitAnsiStringEx([NativeTypeName("PANSI_STRING")] STRING* DestinationString, [NativeTypeName("PCSZ")] sbyte* SourceString);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RtlInitUnicodeString"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    public static extern void RtlInitUnicodeString([NativeTypeName("PUNICODE_STRING")] UNICODE_STRING* DestinationString, [NativeTypeName("PCWSTR")] ushort* SourceString);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RtlAnsiStringToUnicodeString"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int RtlAnsiStringToUnicodeString([NativeTypeName("PUNICODE_STRING")] UNICODE_STRING* DestinationString, [NativeTypeName("PCANSI_STRING")] STRING* SourceString, [NativeTypeName("BOOLEAN")] byte AllocateDestinationString);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RtlUnicodeStringToAnsiString"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int RtlUnicodeStringToAnsiString([NativeTypeName("PANSI_STRING")] STRING* DestinationString, [NativeTypeName("PCUNICODE_STRING")] UNICODE_STRING* SourceString, [NativeTypeName("BOOLEAN")] byte AllocateDestinationString);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RtlUnicodeStringToOemString"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int RtlUnicodeStringToOemString([NativeTypeName("POEM_STRING")] STRING* DestinationString, [NativeTypeName("PCUNICODE_STRING")] UNICODE_STRING* SourceString, [NativeTypeName("BOOLEAN")] byte AllocateDestinationString);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RtlUnicodeToMultiByteSize"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int RtlUnicodeToMultiByteSize([NativeTypeName("PULONG")] uint* BytesInMultiByteString, [NativeTypeName("PWCH")] ushort* UnicodeString, [NativeTypeName("ULONG")] uint BytesInUnicodeString);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RtlCharToInteger"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int RtlCharToInteger([NativeTypeName("PCSZ")] sbyte* String, [NativeTypeName("ULONG")] uint Base, [NativeTypeName("PULONG")] uint* Value);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RtlConvertSidToUnicodeString"]/*'/>
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("NTSTATUS")]
    public static extern int RtlConvertSidToUnicodeString([NativeTypeName("PUNICODE_STRING")] UNICODE_STRING* UnicodeString, [NativeTypeName("PSID")] void* Sid, [NativeTypeName("BOOLEAN")] byte AllocateDestinationString);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RtlUniform"]/*'/>
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