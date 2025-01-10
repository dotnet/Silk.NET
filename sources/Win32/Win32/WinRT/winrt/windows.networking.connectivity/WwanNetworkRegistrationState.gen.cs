// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum WwanNetworkRegistrationState
{
    WwanNetworkRegistrationState_None = 0,
    WwanNetworkRegistrationState_Deregistered = 1,
    WwanNetworkRegistrationState_Searching = 2,
    WwanNetworkRegistrationState_Home = 3,
    WwanNetworkRegistrationState_Roaming = 4,
    WwanNetworkRegistrationState_Partner = 5,
    WwanNetworkRegistrationState_Denied = 6,
}
