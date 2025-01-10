// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum BluetoothLEAdvertisementPublisherStatus
{
    BluetoothLEAdvertisementPublisherStatus_Created = 0,
    BluetoothLEAdvertisementPublisherStatus_Waiting = 1,
    BluetoothLEAdvertisementPublisherStatus_Started = 2,
    BluetoothLEAdvertisementPublisherStatus_Stopping = 3,
    BluetoothLEAdvertisementPublisherStatus_Stopped = 4,
    BluetoothLEAdvertisementPublisherStatus_Aborted = 5,
}
