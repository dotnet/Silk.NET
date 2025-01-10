// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum PhoneNetworkState
{
    PhoneNetworkState_Unknown = 0,
    PhoneNetworkState_NoSignal = 1,
    PhoneNetworkState_Deregistered = 2,
    PhoneNetworkState_Denied = 3,
    PhoneNetworkState_Searching = 4,
    PhoneNetworkState_Home = 5,
    PhoneNetworkState_RoamingInternational = 6,
    PhoneNetworkState_RoamingDomestic = 7,
}
