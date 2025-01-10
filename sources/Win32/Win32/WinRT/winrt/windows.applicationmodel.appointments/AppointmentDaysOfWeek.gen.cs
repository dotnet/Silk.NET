// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("unsigned int")]
public enum AppointmentDaysOfWeek : uint
{
    AppointmentDaysOfWeek_None = 0,
    AppointmentDaysOfWeek_Sunday = 0x1,
    AppointmentDaysOfWeek_Monday = 0x2,
    AppointmentDaysOfWeek_Tuesday = 0x4,
    AppointmentDaysOfWeek_Wednesday = 0x8,
    AppointmentDaysOfWeek_Thursday = 0x10,
    AppointmentDaysOfWeek_Friday = 0x20,
    AppointmentDaysOfWeek_Saturday = 0x40,
}
