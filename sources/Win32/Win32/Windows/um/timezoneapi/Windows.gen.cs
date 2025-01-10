// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/timezoneapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SystemTimeToTzSpecificLocalTime(
        [NativeTypeName("const TIME_ZONE_INFORMATION *")]
            TIME_ZONE_INFORMATION* lpTimeZoneInformation,
        [NativeTypeName("const SYSTEMTIME *")] SYSTEMTIME* lpUniversalTime,
        [NativeTypeName("LPSYSTEMTIME")] SYSTEMTIME* lpLocalTime
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL TzSpecificLocalTimeToSystemTime(
        [NativeTypeName("const TIME_ZONE_INFORMATION *")]
            TIME_ZONE_INFORMATION* lpTimeZoneInformation,
        [NativeTypeName("const SYSTEMTIME *")] SYSTEMTIME* lpLocalTime,
        [NativeTypeName("LPSYSTEMTIME")] SYSTEMTIME* lpUniversalTime
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SuppressGCTransition]
    public static extern BOOL FileTimeToSystemTime(
        [NativeTypeName("const FILETIME *")] FILETIME* lpFileTime,
        [NativeTypeName("LPSYSTEMTIME")] SYSTEMTIME* lpSystemTime
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SuppressGCTransition]
    public static extern BOOL SystemTimeToFileTime(
        [NativeTypeName("const SYSTEMTIME *")] SYSTEMTIME* lpSystemTime,
        [NativeTypeName("LPFILETIME")] FILETIME* lpFileTime
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetTimeZoneInformation(
        [NativeTypeName("LPTIME_ZONE_INFORMATION")] TIME_ZONE_INFORMATION* lpTimeZoneInformation
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetTimeZoneInformation(
        [NativeTypeName("const TIME_ZONE_INFORMATION *")]
            TIME_ZONE_INFORMATION* lpTimeZoneInformation
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetDynamicTimeZoneInformation(
        [NativeTypeName("const DYNAMIC_TIME_ZONE_INFORMATION *")]
            DYNAMIC_TIME_ZONE_INFORMATION* lpTimeZoneInformation
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetDynamicTimeZoneInformation(
        [NativeTypeName("PDYNAMIC_TIME_ZONE_INFORMATION")]
            DYNAMIC_TIME_ZONE_INFORMATION* pTimeZoneInformation
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetTimeZoneInformationForYear(
        ushort wYear,
        [NativeTypeName("PDYNAMIC_TIME_ZONE_INFORMATION")] DYNAMIC_TIME_ZONE_INFORMATION* pdtzi,
        [NativeTypeName("LPTIME_ZONE_INFORMATION")] TIME_ZONE_INFORMATION* ptzi
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint EnumDynamicTimeZoneInformation(
        [NativeTypeName("const DWORD")] uint dwIndex,
        [NativeTypeName("PDYNAMIC_TIME_ZONE_INFORMATION")]
            DYNAMIC_TIME_ZONE_INFORMATION* lpTimeZoneInformation
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint GetDynamicTimeZoneInformationEffectiveYears(
        [NativeTypeName("const PDYNAMIC_TIME_ZONE_INFORMATION")]
            DYNAMIC_TIME_ZONE_INFORMATION* lpTimeZoneInformation,
        [NativeTypeName("LPDWORD")] uint* FirstYear,
        [NativeTypeName("LPDWORD")] uint* LastYear
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SystemTimeToTzSpecificLocalTimeEx(
        [NativeTypeName("const DYNAMIC_TIME_ZONE_INFORMATION *")]
            DYNAMIC_TIME_ZONE_INFORMATION* lpTimeZoneInformation,
        [NativeTypeName("const SYSTEMTIME *")] SYSTEMTIME* lpUniversalTime,
        [NativeTypeName("LPSYSTEMTIME")] SYSTEMTIME* lpLocalTime
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL TzSpecificLocalTimeToSystemTimeEx(
        [NativeTypeName("const DYNAMIC_TIME_ZONE_INFORMATION *")]
            DYNAMIC_TIME_ZONE_INFORMATION* lpTimeZoneInformation,
        [NativeTypeName("const SYSTEMTIME *")] SYSTEMTIME* lpLocalTime,
        [NativeTypeName("LPSYSTEMTIME")] SYSTEMTIME* lpUniversalTime
    );

    [DllImport("api-ms-win-core-timezone-l1-1-1", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern BOOL LocalFileTimeToLocalSystemTime(
        [NativeTypeName("const TIME_ZONE_INFORMATION *")]
            TIME_ZONE_INFORMATION* timeZoneInformation,
        [NativeTypeName("const FILETIME *")] FILETIME* localFileTime,
        SYSTEMTIME* localSystemTime
    );

    [DllImport("api-ms-win-core-timezone-l1-1-1", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern BOOL LocalSystemTimeToLocalFileTime(
        [NativeTypeName("const TIME_ZONE_INFORMATION *")]
            TIME_ZONE_INFORMATION* timeZoneInformation,
        [NativeTypeName("const SYSTEMTIME *")] SYSTEMTIME* localSystemTime,
        FILETIME* localFileTime
    );
}
