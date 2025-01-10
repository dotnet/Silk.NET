// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum BluetoothMajorClass
{
    BluetoothMajorClass_Miscellaneous = 0,
    BluetoothMajorClass_Computer = 1,
    BluetoothMajorClass_Phone = 2,
    BluetoothMajorClass_NetworkAccessPoint = 3,
    BluetoothMajorClass_AudioVideo = 4,
    BluetoothMajorClass_Peripheral = 5,
    BluetoothMajorClass_Imaging = 6,
    BluetoothMajorClass_Wearable = 7,
    BluetoothMajorClass_Toy = 8,
    BluetoothMajorClass_Health = 9,
}
