// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("unsigned int")]
public enum BluetoothLEAdvertisementFlags : uint
{
    BluetoothLEAdvertisementFlags_None = 0,
    BluetoothLEAdvertisementFlags_LimitedDiscoverableMode = 0x1,
    BluetoothLEAdvertisementFlags_GeneralDiscoverableMode = 0x2,
    BluetoothLEAdvertisementFlags_ClassicNotSupported = 0x4,
    BluetoothLEAdvertisementFlags_DualModeControllerCapable = 0x8,
    BluetoothLEAdvertisementFlags_DualModeHostCapable = 0x10,
}
