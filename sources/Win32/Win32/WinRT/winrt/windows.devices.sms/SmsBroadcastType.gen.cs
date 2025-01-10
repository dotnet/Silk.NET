// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum SmsBroadcastType
{
    SmsBroadcastType_Other = 0,
    SmsBroadcastType_CmasPresidential = 1,
    SmsBroadcastType_CmasExtreme = 2,
    SmsBroadcastType_CmasSevere = 3,
    SmsBroadcastType_CmasAmber = 4,
    SmsBroadcastType_CmasTest = 5,
    SmsBroadcastType_EUAlert1 = 6,
    SmsBroadcastType_EUAlert2 = 7,
    SmsBroadcastType_EUAlert3 = 8,
    SmsBroadcastType_EUAlertAmber = 9,
    SmsBroadcastType_EUAlertInfo = 10,
    SmsBroadcastType_EtwsEarthquake = 11,
    SmsBroadcastType_EtwsTsunami = 12,
    SmsBroadcastType_EtwsTsunamiAndEarthquake = 13,
    SmsBroadcastType_LatAlertLocal = 14,
}
