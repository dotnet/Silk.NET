// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sysinfoapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GlobalMemoryStatusEx(
        [NativeTypeName("LPMEMORYSTATUSEX")] MEMORYSTATUSEX* lpBuffer
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void GetSystemInfo(
        [NativeTypeName("LPSYSTEM_INFO")] SYSTEM_INFO* lpSystemInfo
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SuppressGCTransition]
    public static extern void GetSystemTime(
        [NativeTypeName("LPSYSTEMTIME")] SYSTEMTIME* lpSystemTime
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void GetSystemTimeAsFileTime(
        [NativeTypeName("LPFILETIME")] FILETIME* lpSystemTimeAsFileTime
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void GetLocalTime(
        [NativeTypeName("LPSYSTEMTIME")] SYSTEMTIME* lpSystemTime
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern BOOL IsUserCetAvailableInEnvironment(
        [NativeTypeName("DWORD")] uint UserCetEnvironment
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    public static extern BOOL GetSystemLeapSecondInformation(
        [NativeTypeName("PBOOL")] BOOL* Enabled,
        [NativeTypeName("PDWORD")] uint* Flags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [Obsolete]
    public static extern uint GetVersion();

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetLocalTime(
        [NativeTypeName("const SYSTEMTIME *")] SYSTEMTIME* lpSystemTime
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetTickCount();

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("ULONGLONG")]
    public static extern ulong GetTickCount64();

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetSystemTimeAdjustment(
        [NativeTypeName("PDWORD")] uint* lpTimeAdjustment,
        [NativeTypeName("PDWORD")] uint* lpTimeIncrement,
        [NativeTypeName("PBOOL")] BOOL* lpTimeAdjustmentDisabled
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0")]
    public static extern BOOL GetSystemTimeAdjustmentPrecise(
        [NativeTypeName("PDWORD64")] ulong* lpTimeAdjustment,
        [NativeTypeName("PDWORD64")] ulong* lpTimeIncrement,
        [NativeTypeName("PBOOL")] BOOL* lpTimeAdjustmentDisabled
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetSystemDirectoryA(
        [NativeTypeName("LPSTR")] sbyte* lpBuffer,
        uint uSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetSystemDirectoryW(
        [NativeTypeName("LPWSTR")] ushort* lpBuffer,
        uint uSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetWindowsDirectoryA(
        [NativeTypeName("LPSTR")] sbyte* lpBuffer,
        uint uSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetWindowsDirectoryW(
        [NativeTypeName("LPWSTR")] ushort* lpBuffer,
        uint uSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetSystemWindowsDirectoryA(
        [NativeTypeName("LPSTR")] sbyte* lpBuffer,
        uint uSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetSystemWindowsDirectoryW(
        [NativeTypeName("LPWSTR")] ushort* lpBuffer,
        uint uSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetComputerNameExA(
        COMPUTER_NAME_FORMAT NameType,
        [NativeTypeName("LPSTR")] sbyte* lpBuffer,
        [NativeTypeName("LPDWORD")] uint* nSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetComputerNameExW(
        COMPUTER_NAME_FORMAT NameType,
        [NativeTypeName("LPWSTR")] ushort* lpBuffer,
        [NativeTypeName("LPDWORD")] uint* nSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetComputerNameExW(
        COMPUTER_NAME_FORMAT NameType,
        [NativeTypeName("LPCWSTR")] ushort* lpBuffer
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetSystemTime(
        [NativeTypeName("const SYSTEMTIME *")] SYSTEMTIME* lpSystemTime
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [Obsolete]
    public static extern BOOL GetVersionExA(
        [NativeTypeName("LPOSVERSIONINFOA")] OSVERSIONINFOA* lpVersionInformation
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [Obsolete]
    public static extern BOOL GetVersionExW(
        [NativeTypeName("LPOSVERSIONINFOW")] OSVERSIONINFOW* lpVersionInformation
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetLogicalProcessorInformation(
        [NativeTypeName("PSYSTEM_LOGICAL_PROCESSOR_INFORMATION")]
            SYSTEM_LOGICAL_PROCESSOR_INFORMATION* Buffer,
        [NativeTypeName("PDWORD")] uint* ReturnedLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetLogicalProcessorInformationEx(
        LOGICAL_PROCESSOR_RELATIONSHIP RelationshipType,
        [NativeTypeName("PSYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX")]
            SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX* Buffer,
        [NativeTypeName("PDWORD")] uint* ReturnedLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void GetNativeSystemInfo(
        [NativeTypeName("LPSYSTEM_INFO")] SYSTEM_INFO* lpSystemInfo
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern void GetSystemTimePreciseAsFileTime(
        [NativeTypeName("LPFILETIME")] FILETIME* lpSystemTimeAsFileTime
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL GetProductInfo(
        [NativeTypeName("DWORD")] uint dwOSMajorVersion,
        [NativeTypeName("DWORD")] uint dwOSMinorVersion,
        [NativeTypeName("DWORD")] uint dwSpMajorVersion,
        [NativeTypeName("DWORD")] uint dwSpMinorVersion,
        [NativeTypeName("PDWORD")] uint* pdwReturnedProductType
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("ULONGLONG")]
    public static extern ulong VerSetConditionMask(
        [NativeTypeName("ULONGLONG")] ulong ConditionMask,
        [NativeTypeName("ULONG")] uint TypeMask,
        [NativeTypeName("UCHAR")] byte Condition
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    public static extern BOOL GetOsSafeBootMode([NativeTypeName("PDWORD")] uint* Flags);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint EnumSystemFirmwareTables(
        [NativeTypeName("DWORD")] uint FirmwareTableProviderSignature,
        [NativeTypeName("PVOID")] void* pFirmwareTableEnumBuffer,
        [NativeTypeName("DWORD")] uint BufferSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetSystemFirmwareTable(
        [NativeTypeName("DWORD")] uint FirmwareTableProviderSignature,
        [NativeTypeName("DWORD")] uint FirmwareTableID,
        [NativeTypeName("PVOID")] void* pFirmwareTableBuffer,
        [NativeTypeName("DWORD")] uint BufferSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL DnsHostnameToComputerNameExW(
        [NativeTypeName("LPCWSTR")] ushort* Hostname,
        [NativeTypeName("LPWSTR")] ushort* ComputerName,
        [NativeTypeName("LPDWORD")] uint* nSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetPhysicallyInstalledSystemMemory(
        [NativeTypeName("PULONGLONG")] ulong* TotalMemoryInKilobytes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL SetComputerNameEx2W(
        COMPUTER_NAME_FORMAT NameType,
        [NativeTypeName("DWORD")] uint Flags,
        [NativeTypeName("LPCWSTR")] ushort* lpBuffer
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetSystemTimeAdjustment(
        [NativeTypeName("DWORD")] uint dwTimeAdjustment,
        BOOL bTimeAdjustmentDisabled
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0")]
    public static extern BOOL SetSystemTimeAdjustmentPrecise(
        [NativeTypeName("DWORD64")] ulong dwTimeAdjustment,
        BOOL bTimeAdjustmentDisabled
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.3")]
    public static extern BOOL InstallELAMCertificateInfo(HANDLE ELAMFile);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetProcessorSystemCycleTime(
        ushort Group,
        [NativeTypeName("PSYSTEM_PROCESSOR_CYCLE_TIME_INFORMATION")]
            SYSTEM_PROCESSOR_CYCLE_TIME_INFORMATION* Buffer,
        [NativeTypeName("PDWORD")] uint* ReturnedLength
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    public static extern BOOL GetOsManufacturingMode([NativeTypeName("PBOOL")] BOOL* pbEnabled);

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0")]
    public static extern HRESULT GetIntegratedDisplaySize(double* sizeInInches);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetComputerNameA([NativeTypeName("LPCSTR")] sbyte* lpComputerName);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetComputerNameW([NativeTypeName("LPCWSTR")] ushort* lpComputerName);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetComputerNameExA(
        COMPUTER_NAME_FORMAT NameType,
        [NativeTypeName("LPCSTR")] sbyte* lpBuffer
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22631.0")]
    public static extern DEVELOPER_DRIVE_ENABLEMENT_STATE GetDeveloperDriveEnablementState();

    [NativeTypeName("#define USER_CET_ENVIRONMENT_WIN32_PROCESS 0x00000000")]
    public const int USER_CET_ENVIRONMENT_WIN32_PROCESS = 0x00000000;

    [NativeTypeName("#define USER_CET_ENVIRONMENT_SGX2_ENCLAVE 0x00000002")]
    public const int USER_CET_ENVIRONMENT_SGX2_ENCLAVE = 0x00000002;

    [NativeTypeName("#define USER_CET_ENVIRONMENT_VBS_ENCLAVE 0x00000010")]
    public const int USER_CET_ENVIRONMENT_VBS_ENCLAVE = 0x00000010;

    [NativeTypeName("#define USER_CET_ENVIRONMENT_VBS_BASIC_ENCLAVE 0x00000011")]
    public const int USER_CET_ENVIRONMENT_VBS_BASIC_ENCLAVE = 0x00000011;

    [NativeTypeName("#define GetSystemDirectory GetSystemDirectoryW")]
    public static delegate* <ushort*, uint, uint> GetSystemDirectory => &GetSystemDirectoryW;

    [NativeTypeName("#define GetWindowsDirectory GetWindowsDirectoryW")]
    public static delegate* <ushort*, uint, uint> GetWindowsDirectory => &GetWindowsDirectoryW;

    [NativeTypeName("#define GetSystemWindowsDirectory GetSystemWindowsDirectoryW")]
    public static delegate* <ushort*, uint, uint> GetSystemWindowsDirectory =>
        &GetSystemWindowsDirectoryW;

    [NativeTypeName("#define GetComputerNameEx GetComputerNameExW")]
    public static delegate* <COMPUTER_NAME_FORMAT, ushort*, uint*, BOOL> GetComputerNameEx =>
        &GetComputerNameExW;

    [NativeTypeName("#define SetComputerNameEx SetComputerNameExW")]
    public static delegate* <COMPUTER_NAME_FORMAT, ushort*, BOOL> SetComputerNameEx =>
        &SetComputerNameExW;

    [NativeTypeName("#define GetVersionEx GetVersionExW")]
    [Obsolete]
    public static delegate* <OSVERSIONINFOW*, BOOL> GetVersionEx => &GetVersionExW;

    [NativeTypeName("#define SCEX2_ALT_NETBIOS_NAME 0x00000001")]
    public const int SCEX2_ALT_NETBIOS_NAME = 0x00000001;

    [NativeTypeName("#define SetComputerNameEx2 SetComputerNameEx2W")]
    public static delegate* <COMPUTER_NAME_FORMAT, uint, ushort*, BOOL> SetComputerNameEx2 =>
        &SetComputerNameEx2W;

    [NativeTypeName("#define SetComputerName SetComputerNameW")]
    public static delegate* <ushort*, BOOL> SetComputerName => &SetComputerNameW;
}
