// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum AppointmentCalendarSyncStatus
{
    AppointmentCalendarSyncStatus_Idle = 0,
    AppointmentCalendarSyncStatus_Syncing = 1,
    AppointmentCalendarSyncStatus_UpToDate = 2,
    AppointmentCalendarSyncStatus_AuthenticationError = 3,
    AppointmentCalendarSyncStatus_PolicyError = 4,
    AppointmentCalendarSyncStatus_UnknownError = 5,
    AppointmentCalendarSyncStatus_ManualAccountRemovalRequired = 6,
}
