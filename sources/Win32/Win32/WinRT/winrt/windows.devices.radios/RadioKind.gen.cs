// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.radios.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum RadioKind
{
    RadioKind_Other = 0,
    RadioKind_WiFi = 1,
    RadioKind_MobileBroadband = 2,
    RadioKind_Bluetooth = 3,
    RadioKind_FM = 4,
}
