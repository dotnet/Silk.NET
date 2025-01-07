// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using static Silk.NET.Windows.FACILITY;
using static Silk.NET.Windows.HIDP;

namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool HidP_IsSameUsageAndPage(USAGE_AND_PAGE* u1, USAGE_AND_PAGE* u2) => *(uint*)u1 == *(uint*)u2;

    public static int HidP_SetButtons(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("PUSAGE")] ushort* UsageList, [NativeTypeName("PULONG")] uint* UsageLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength) =>
        HidP_SetUsages(ReportType, UsagePage, LinkCollection, UsageList, UsageLength, PreparsedData, Report, ReportLength);

    public static int HidP_UnsetButtons(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("PUSAGE")] ushort* UsageList, [NativeTypeName("PULONG")] uint* UsageLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength) =>
        HidP_UnsetUsages(ReportType, UsagePage, LinkCollection, UsageList, UsageLength, PreparsedData, Report, ReportLength);

    public static int HidP_GetButtons(HIDP_REPORT_TYPE ReportType, [NativeTypeName("USAGE")] ushort UsagePage, ushort LinkCollection, [NativeTypeName("PUSAGE")] ushort* UsageList, [NativeTypeName("PULONG")] uint* UsageLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength) =>
        HidP_GetUsages(ReportType, UsagePage, LinkCollection, UsageList, UsageLength, PreparsedData, Report, ReportLength);

    public static int HidP_GetButtonsEx(HIDP_REPORT_TYPE ReportType, ushort LinkCollection, [NativeTypeName("PUSAGE_AND_PAGE")] USAGE_AND_PAGE* ButtonList, [NativeTypeName("ULONG *")] uint* UsageLength, PHIDP_PREPARSED_DATA PreparsedData, [NativeTypeName("PCHAR")] sbyte* Report, [NativeTypeName("ULONG")] uint ReportLength) =>
        HidP_GetUsagesEx(ReportType, LinkCollection, ButtonList, UsageLength, PreparsedData, Report, ReportLength);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int HIDP_ERROR_CODES(int sev, int code) => (sev << 28) | (FACILITY_HID_ERROR_CODE << 16) | code;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_GetVersion"]/*' />
    [return: NativeTypeName("NTSTATUS")]
    public static int HidP_GetVersion([NativeTypeName("ULONG *")] uint* Version)
    {
        int status = HIDP_STATUS_SUCCESS;
        *Version = 1;

        HMODULE module;

        fixed (char* lpLibFileName = "hid.dll")
        {
            module = LoadLibraryW((ushort*)lpLibFileName);
        }

        if (module == HMODULE.NULL)
        {
            return HIDP_STATUS_INTERNAL_ERROR;
        }

        delegate* unmanaged<uint*, int> fnVersionInternal;

        fixed (byte* lpProcName = "HidP_GetVersionInternal"u8)
        {
            fnVersionInternal = (delegate* unmanaged<uint*, int>)GetProcAddress(module, (sbyte*)lpProcName);
        }

        if (fnVersionInternal != null)
        {
            status = fnVersionInternal(Version);
        }

        return status;
    }
}
