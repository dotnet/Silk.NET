// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum SmsDeviceStatus
{
    SmsDeviceStatus_Off = 0,
    SmsDeviceStatus_Ready = 1,
    SmsDeviceStatus_SimNotInserted = 2,
    SmsDeviceStatus_BadSim = 3,
    SmsDeviceStatus_DeviceFailure = 4,
    SmsDeviceStatus_SubscriptionNotActivated = 5,
    SmsDeviceStatus_DeviceLocked = 6,
    SmsDeviceStatus_DeviceBlocked = 7,
}
