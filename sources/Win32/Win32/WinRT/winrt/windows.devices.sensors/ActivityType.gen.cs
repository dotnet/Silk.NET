// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum ActivityType
{
    ActivityType_Unknown = 0,
    ActivityType_Idle = 1,
    ActivityType_Stationary = 2,
    ActivityType_Fidgeting = 3,
    ActivityType_Walking = 4,
    ActivityType_Running = 5,
    ActivityType_InVehicle = 6,
    ActivityType_Biking = 7,
}
