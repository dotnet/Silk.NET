// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum NetworkConnectivityLevel
{
    NetworkConnectivityLevel_None = 0,
    NetworkConnectivityLevel_LocalAccess = 1,
    NetworkConnectivityLevel_ConstrainedInternetAccess = 2,
    NetworkConnectivityLevel_InternetAccess = 3,
}
