// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum SystemConditionType
{
    SystemConditionType_Invalid = 0,
    SystemConditionType_UserPresent = 1,
    SystemConditionType_UserNotPresent = 2,
    SystemConditionType_InternetAvailable = 3,
    SystemConditionType_InternetNotAvailable = 4,
    SystemConditionType_SessionConnected = 5,
    SystemConditionType_SessionDisconnected = 6,
    SystemConditionType_FreeNetworkAvailable = 7,
    SystemConditionType_BackgroundWorkCostNotHigh = 8,
}
