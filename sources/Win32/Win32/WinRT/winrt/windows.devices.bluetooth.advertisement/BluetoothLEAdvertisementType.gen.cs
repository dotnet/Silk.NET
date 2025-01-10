// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum BluetoothLEAdvertisementType
{
    BluetoothLEAdvertisementType_ConnectableUndirected = 0,
    BluetoothLEAdvertisementType_ConnectableDirected = 1,
    BluetoothLEAdvertisementType_ScannableUndirected = 2,
    BluetoothLEAdvertisementType_NonConnectableUndirected = 3,
    BluetoothLEAdvertisementType_ScanResponse = 4,
    BluetoothLEAdvertisementType_Extended = 5,
}
