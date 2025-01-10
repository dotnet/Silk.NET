// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("unsigned int")]
public enum BluetoothServiceCapabilities : uint
{
    BluetoothServiceCapabilities_None = 0,
    BluetoothServiceCapabilities_LimitedDiscoverableMode = 0x1,
    BluetoothServiceCapabilities_PositioningService = 0x8,
    BluetoothServiceCapabilities_NetworkingService = 0x10,
    BluetoothServiceCapabilities_RenderingService = 0x20,
    BluetoothServiceCapabilities_CapturingService = 0x40,
    BluetoothServiceCapabilities_ObjectTransferService = 0x80,
    BluetoothServiceCapabilities_AudioService = 0x100,
    BluetoothServiceCapabilities_TelephoneService = 0x200,
    BluetoothServiceCapabilities_InformationService = 0x400,
}
