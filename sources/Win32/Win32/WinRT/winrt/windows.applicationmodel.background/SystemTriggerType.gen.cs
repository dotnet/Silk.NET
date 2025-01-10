// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum SystemTriggerType
{
    SystemTriggerType_Invalid = 0,
    SystemTriggerType_SmsReceived = 1,
    SystemTriggerType_UserPresent = 2,
    SystemTriggerType_UserAway = 3,
    SystemTriggerType_NetworkStateChange = 4,
    SystemTriggerType_ControlChannelReset = 5,
    SystemTriggerType_InternetAvailable = 6,
    SystemTriggerType_SessionConnected = 7,
    SystemTriggerType_ServicingComplete = 8,
    SystemTriggerType_LockScreenApplicationAdded = 9,
    SystemTriggerType_LockScreenApplicationRemoved = 10,
    SystemTriggerType_TimeZoneChange = 11,
    SystemTriggerType_OnlineIdConnectedStateChange = 12,
    SystemTriggerType_BackgroundWorkCostChange = 13,
    SystemTriggerType_PowerStateChange = 14,
    SystemTriggerType_DefaultSignInAccountChange = 15,
}
