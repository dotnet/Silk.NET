// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum AppointmentStoreChangeType
{
    AppointmentStoreChangeType_AppointmentCreated = 0,
    AppointmentStoreChangeType_AppointmentModified = 1,
    AppointmentStoreChangeType_AppointmentDeleted = 2,
    AppointmentStoreChangeType_ChangeTrackingLost = 3,
    AppointmentStoreChangeType_CalendarCreated = 4,
    AppointmentStoreChangeType_CalendarModified = 5,
    AppointmentStoreChangeType_CalendarDeleted = 6,
}
